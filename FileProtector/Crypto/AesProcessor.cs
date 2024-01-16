using System.Security.Cryptography;

namespace FileProtector.Crypto
{
    public class AesProcessor
    {
        private readonly byte[] key;
        private readonly byte[] iv;

        public AesProcessor(byte[] key, byte[] iv) 
        {
            this.key = key;
            this.iv = iv;
        }

        public byte[] Encrypt(byte[] data)
        {
            using (Aes aesInsance = Aes.Create())
            {
                aesInsance.Key = key;
                aesInsance.IV = iv;

                ICryptoTransform encryptor = aesInsance.CreateEncryptor(aesInsance.Key, aesInsance.IV);
                byte[] encryptedBytes;

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(data, 0, data.Length);
                    }

                    encryptedBytes = memoryStream.ToArray();
                }

                return encryptedBytes;
            }
        }

        public byte[] Decrypt(byte[] data)
        {
            using (Aes aesInsance = Aes.Create())
            {
                aesInsance.Key = key;
                aesInsance.IV = iv;

                ICryptoTransform decryptor = aesInsance.CreateDecryptor(aesInsance.Key, aesInsance.IV);
                byte[] decryptedBytes;

                using (MemoryStream memoryStream = new MemoryStream(data))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (MemoryStream resultMemoryStream = new MemoryStream())
                        {
                            cryptoStream.CopyTo(resultMemoryStream);
                            decryptedBytes = resultMemoryStream.ToArray();
                        }
                    }
                }

                return decryptedBytes;
            }
        }
    }
}
