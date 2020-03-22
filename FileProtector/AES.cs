using System;
using System.Text;
using System.Security.Cryptography;

namespace FileProtector
{
    class AES
    {
        public static byte[] Encrypt(byte[] input, string pwd) // Функция шифрования AES32
        {
            RijndaelManaged AES = new RijndaelManaged();
            byte[] hash = new byte[32];
            byte[] temp = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(pwd));
            Array.Copy(temp, 0, hash, 0, 16);
            Array.Copy(temp, 0, hash, 15, 16);
            AES.Key = hash;
            AES.Mode = CipherMode.ECB;
            ICryptoTransform DESEncrypter = AES.CreateEncryptor();
            return DESEncrypter.TransformFinalBlock(input, 0, input.Length);
        }

        public static byte[] Decrypt(byte[] input, string pwd) // Функция расшифровки AES32
        {
            RijndaelManaged AES = new RijndaelManaged();
            byte[] hash = new byte[32];
            byte[] temp = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(pwd));
            Array.Copy(temp, 0, hash, 0, 16);
            Array.Copy(temp, 0, hash, 15, 16);
            AES.Key = hash;
            AES.Mode = CipherMode.ECB;
            ICryptoTransform DESDecrypter = AES.CreateDecryptor();
            return DESDecrypter.TransformFinalBlock(input, 0, input.Length);
        }

    }
}
