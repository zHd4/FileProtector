using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace FileProtector
{
    public partial class FrmSettings : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public static string settingsPath = @"C:\ProgramData\FileProtector\settings";

        public static void ChangeLocalSettings(int offset, string contents)
        {
            try
            {
                string[] data = new string[2];

                if (!File.Exists(settingsPath))
                {
                    if (!Directory.Exists(Path.GetDirectoryName(settingsPath)))
                        Directory.CreateDirectory(Path.GetDirectoryName(settingsPath));

                    File.WriteAllText(settingsPath, "true,true");
                }

                data = File.ReadAllText(settingsPath).Split(',');
                data[offset] = contents;

                File.WriteAllText(settingsPath, string.Join(",", data));
            }
            catch
            {
                Program.ShowMessageBox("Ошибка изменения настроек");
            }
        }

        public FrmSettings()
        {
            InitializeComponent();

            try
            {
                string[] settingsData = File.ReadAllText(settingsPath).Split(',');

                if (settingsData[0] == "false")
                    protectedEncryption.Checked = false;
                if (settingsData[1] == "false")
                    hideFiles.Checked = false;
            }
            catch { }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void FrmSettings_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            FrmSettings_MouseDown(sender, e);
        }

        private void protectedEncryption_CheckedChanged(object sender, EventArgs e)
        {
            Crypter.protectedEncryption = protectedEncryption.Checked;

            if (Crypter.protectedEncryption)
                ChangeLocalSettings(0, "true");
            else
                ChangeLocalSettings(0, "false");
        }

        private void hideFiles_CheckedChanged(object sender, EventArgs e)
        {
            Crypter.hideFiles = hideFiles.Checked;

            if (Crypter.hideFiles)
                ChangeLocalSettings(1, "true");
            else
                ChangeLocalSettings(1, "false");
        }
    }
}
