using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace FileProtector
{
    static class Program
    {
        public static string version = "2.2";

        [STAThread]
        static void Main()
        {
            if (Process.GetProcessesByName(Path.GetFileName(Application.ExecutablePath).Replace(".exe", "")).Length > 1)
                Environment.Exit(0);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartScreen());
        }

        public static void ShowMessageBox(string contents)
        {
            FrmDialogBox.contents = contents;
            FrmDialogBox dialog = new FrmDialogBox();
            dialog.ShowDialog();
        }

        public static bool Download(string url, string savePath)
        {
            try
            {
                using (var client = new WebClient())
                    client.DownloadFile(url, savePath);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static string GET(string url)
        {
            string html = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }

            return html;
        }

        public static string ToBase64(string plain)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(plain));
        }

        public static string FromBase64(string b64)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(b64));
        }

        public static string md5(string input)
        {
            MD5 md5Hash = MD5.Create();

            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        public static bool IsAdministrator()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
