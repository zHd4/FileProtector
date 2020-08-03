using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FileProtector
{
    class Crypter
    {
        public static bool protectedEncryption = true;
        public static bool hideFiles = true;

        public static int result = 0;

        public static bool EncryptFile(string path, string key)
        {
            try
            {
                byte[] non = File.ReadAllBytes(path);
                File.WriteAllBytes(path, AES.Encrypt(non, key));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool DecryptFile(string path, string key, out bool wrongPassword)
        {
            try
            {
                byte[] non = File.ReadAllBytes(path);
                File.WriteAllBytes(path, AES.Decrypt(non, key));
                wrongPassword = false;

                return true;
            }
            catch (System.Security.Cryptography.CryptographicException)
            {
                wrongPassword = true;
                return false;
            }
            catch
            {
                wrongPassword = false;
                return false;
            }
        }

        public static void Encrypt(string path, string key)
        {
            new Thread(() =>
            {
                string[] allfiles = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
                List<string> backups = new List<string>();
                int filesEncrypted = 0;

                try
                {
                    foreach (string file in allfiles)
                    {
                        FrmEncrypt.currPath = file;
                        FrmEncrypt.allFilesCount = allfiles.Length;
                        FrmEncrypt.filesEncrypted = filesEncrypted;

                        if (protectedEncryption)
                        {
                            File.Copy(file, file + ".bak");
                            backups.Add(file + ".bak");
                        }

                        if (!EncryptFile(file, key))
                        {
                            if (protectedEncryption)
                            {
                                FrmEncrypt.currPath = "Ошибка при шифровании. Востановление файлов...";

                                foreach (string backuped in backups)
                                {
                                    try
                                    {
                                        File.Delete(Path.Combine(Path.GetDirectoryName(backuped), Path.GetFileNameWithoutExtension(backuped)));
                                        File.Move(backuped, Path.Combine(Path.GetDirectoryName(backuped), Path.GetFileNameWithoutExtension(backuped)));
                                    }
                                    catch
                                    {
                                        File.Delete(backuped);
                                    }
                                }
                            }

                            result = 2;
                            break;
                        }
                        else
                        {
                            filesEncrypted++;
                        }
                    }

                    if (result == 0)
                    {
                        DirectoryInfo dinf = Directory.CreateDirectory(Path.Combine(path, ".encrypted_by_fileprotector"));
                        dinf.Attributes = FileAttributes.Hidden;

                        if (hideFiles)
                            HideContent(path);

                        if (protectedEncryption)
                        {
                            FrmEncrypt.currPath = "Удаление резервных копий...";
                            foreach (string backuped in backups)
                                File.Delete(backuped);
                        }

                        result = 1;
                    }
                }
                catch
                {
                    result = 2;
                }
            }).Start();
        }

        public static void Decrypt(string path, string key)
        {
            new Thread(() =>
            {
                string[] allfiles = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
                int filesDecrypted = 0;
                bool wasHidden = false;

                key = PasswordRecovery(path, key);

                try
                {
                    if ((File.GetAttributes(allfiles[0]) & FileAttributes.Hidden) == FileAttributes.Hidden)
                    {
                        ShowContent(path);
                        wasHidden = true;
                    }

                    foreach (string file in allfiles)
                    {
                        FrmDecrypt.allFilesCount = allfiles.Length;
                        FrmDecrypt.filesEncrypted = filesDecrypted;

                        FrmDecrypt.currPath = file;
                        bool wrongPassword = false;
                        if (!DecryptFile(file, key, out wrongPassword))
                        {
                            if (wasHidden)
                                HideContent(path);
                            if (wrongPassword)
                                result = 2;
                            else
                                result = 3;
                            break;
                        }
                        else
                        {
                            filesDecrypted++;
                        }
                    }

                    if (result == 0)
                    {
                        result = 1;
                        Directory.Delete(Path.Combine(path, ".encrypted_by_fileprotector"));
                    }
                        
                }
                catch
                {
                    result = 2;
                }
            }).Start();
        }

        private static void HideContent(string path)
        {
            string[] files = Directory.GetFiles(path);
            string[] directories = Directory.GetDirectories(path);

            foreach(string file in files)
            {
                File.SetAttributes(file, File.GetAttributes(file) | FileAttributes.Hidden);
            }

            foreach(string directory in directories)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(directory);
                directoryInfo.Attributes = FileAttributes.Hidden;
            }
        }

        private static void ShowContent(string path)
        {
            try
            {
                string[] files = Directory.GetFiles(path);
                string[] directories = Directory.GetDirectories(path);

                foreach (string file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    fileInfo.Attributes &= ~FileAttributes.Hidden;
                }

                foreach (string directory in directories)
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(directory);
                    directoryInfo.Attributes &= ~FileAttributes.Hidden;
                }
            }
            catch { }
        }

        public static string PasswordRecovery(string path, string master_password)
        {
            if (File.Exists(Program.md5(path)))
            {
                try
                {
                    string restored_password = Encoding.UTF8.GetString(AES.Decrypt(File.ReadAllBytes(Program.md5(path)), master_password));

                    try
                    {
                        File.Delete(Program.md5(path));
                    }
                    catch { }

                    return restored_password;
                }
                catch
                {
                    try
                    {
                        File.Delete(Program.md5(path));
                    }
                    catch { }

                    return master_password;
                }
            }
            else
            {
                try
                {
                    File.Delete(Program.md5(path));
                }
                catch { }

                return master_password;
            }
        }
    }
}
