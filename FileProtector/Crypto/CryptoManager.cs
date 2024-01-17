using System.Text;
using System.Security.Cryptography;

namespace FileProtector.Crypto
{
    public class CryptoManager
    {
        private byte[] passwordBytes;

        public CryptoManager(string password)
        {
            passwordBytes = Encoding.UTF8.GetBytes(password);
        }

        public void EncryptFile(string path)
        {
            AesProcessor processor = new AesProcessor(GetKey(), GetIV());
            File.WriteAllBytes(path, processor.Encrypt(File.ReadAllBytes(path)));
        }

        public void DecryptFile(string path)
        {
            AesProcessor processor = new AesProcessor(GetKey(), GetIV());
            File.WriteAllBytes(path, processor.Decrypt(File.ReadAllBytes(path)));
        }

        private byte[] GetKey()
        {
            return SHA256.Create().ComputeHash(passwordBytes);
        }

        private byte[] GetIV()
        {
            return MD5.Create().ComputeHash(passwordBytes);
        }
    }
}
