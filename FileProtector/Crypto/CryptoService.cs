using System.Text;
using System.Security.Cryptography;

namespace FileProtector.Crypto
{
    public class CryptoService
    {
        private byte[] passwordBytes;

        public CryptoService(string password)
        {
            passwordBytes = Encoding.UTF8.GetBytes(password);
        }

        public void Encrypt(List<string> paths)
        {

        }

        public void Decrypt(List<string> paths)
        {

        }

        public void EncryptFile(string path)
        {
            AesCryptor processor = new AesCryptor(GetKey(), GetIV());
            File.WriteAllBytes(path, processor.Encrypt(File.ReadAllBytes(path)));
        }

        public void DecryptFile(string path)
        {
            AesCryptor processor = new AesCryptor(GetKey(), GetIV());
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
