using System.Text;
using System.Security.Cryptography;

namespace FileProtector.Crypto
{
    public class CryptoWorker
    {
        private byte[] PasswordBytes;

        public CryptoWorker(string password)
        {
            PasswordBytes = Encoding.UTF8.GetBytes(password);
        }

        public async void EncryptAsync(List<string> paths)
        {
            await Task.Run(() => DoWork(paths, EncryptFile));
        }

        public async void DecryptAsync(List<string> paths)
        {
            await Task.Run(() => DoWork(paths, DecryptFile));
        }

        private void DoWork(List<string> paths, Action<string> transformFunction)
        {
            foreach (string path in paths)
            {
                if (Directory.Exists(path))
                {
                    Directory.GetFiles(path, "*.*", SearchOption.AllDirectories)
                        .ToList()
                        .ForEach(file => transformFunction(file));
                }
                else
                {
                    transformFunction(path);
                }
            }
        }

        public void EncryptFile(string path)
        {
            AesCryptor cryptor = new AesCryptor(GetKey(), GetIV());
            File.WriteAllBytes(path, cryptor.Encrypt(File.ReadAllBytes(path)));
        }

        public void DecryptFile(string path)
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
    }
}
