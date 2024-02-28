﻿using System.Text;
using System.Security.Cryptography;
using FileProtector.Models;

namespace FileProtector.Crypto
{
    public class CryptoWorker
    {
        public CryptoState State { get; } = new CryptoState();

        private byte[] PasswordBytes;

        public CryptoWorker(string password)
        {
            PasswordBytes = Encoding.UTF8.GetBytes(password);
        }

        public async void EncryptAsync(List<string> paths)
        {
            await Task.Run(() => DoWork(paths, "encrypt", EncryptFile));
        }

        public async void DecryptAsync(List<string> paths)
        {
            await Task.Run(() => DoWork(paths, "decrypt", DecryptFile));
        }

        private void DoWork(List<string> paths, string workName, Action<string> transformFunction)
        {
            State.FilesCount = paths.Count;

            paths.ForEach(path => 
            {
                State.Message = string.Format("{0}ing: {1}", Capitalize(workName), path);

                try
                {
                    transformFunction(path);
                    State.TransformedFilesCount += 1;
                }
                catch (Exception e)
                {
                    string message = string.Format("Cannot {0}: {1}", workName, Decapitalize(e.Message));

                    State.Message = message;
                    State.Errors.Add(message);
                }
            });

            State.Completed = true;
        }

        private void EncryptFile(string path)
        {
            AesCryptor cryptor = new AesCryptor(GetKey(), GetIV());
            File.WriteAllBytes(path, cryptor.Encrypt(File.ReadAllBytes(path)));
        }

        private void DecryptFile(string path)
        {
            AesCryptor cryptor = new AesCryptor(GetKey(), GetIV());

            try
            {
                File.WriteAllBytes(path, cryptor.Decrypt(File.ReadAllBytes(path)));
            }
            catch (CryptographicException)
            {
                throw new CryptographicException("Cannot decrypt: " + path);
            }
        }

        private byte[] GetKey()
        {
            return SHA256.Create().ComputeHash(PasswordBytes);
        }

        private byte[] GetIV()
        {
            return MD5.Create().ComputeHash(PasswordBytes);
        }

        private static string Capitalize(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            return char.ToUpper(text[0]) + text.Substring(1);
        }

        private static string Decapitalize(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            return char.ToLower(text[0]) + text.Substring(1);
        }
    }
}
