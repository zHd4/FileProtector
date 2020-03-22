using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace FileProtector
{
    public partial class FrmEncrypt : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public FrmEncrypt()
        {
            InitializeComponent();

            eBUTTON.Text = "\uD83D\uDD12 " + eBUTTON.Text;

            try
            {
                string[] settingsData = File.ReadAllText(FrmSettings.settingsPath).Split(',');

                if (settingsData[0] == "false")
                    Crypter.protectedEncryption = false;
                if (settingsData[1] == "false")
                    Crypter.hideFiles = false;
            }
            catch { }
        }

        public static string currPath = "-";
        public static int allFilesCount = 0;
        public static int filesEncrypted = 0;

        private void eBROWSE_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    ePATHFIELD.Text = fbd.SelectedPath;
                }
            }
        }

        private void eShow_CheckedChanged(object sender, EventArgs e)
        {
            if (eShow.Checked)
            {
                ePASS.UseSystemPasswordChar = false;
            }
            else
            {
                ePASS.UseSystemPasswordChar = true;
            }
        }

        private void DisableAll()
        {
            ePATHFIELD.ReadOnly = true;
            ePASS.ReadOnly = true;
            eBROWSE.Click -= new EventHandler(eBROWSE_Click);
            eShow.Click -= new EventHandler(eShow_CheckedChanged);
            eBUTTON.Click -= new EventHandler(eBUTTON_Click);
            aboutButton.Click -= new EventHandler(aboutButton_Click);
            openDecryptForm.Click -= new EventHandler(openDecryptForm_Click);
            openSettings.Click -= new EventHandler(openSettings_Click);
        }

        private void EnableAll()
        {
            ePATHFIELD.ReadOnly = false;
            ePASS.ReadOnly = false;
            eBROWSE.Click += new EventHandler(eBROWSE_Click);
            eShow.Click += new EventHandler(eShow_CheckedChanged);
            eBUTTON.Click += new EventHandler(eBUTTON_Click);
            aboutButton.Click += new EventHandler(aboutButton_Click);
            openDecryptForm.Click += new EventHandler(openDecryptForm_Click);
            openSettings.Click += new EventHandler(openSettings_Click);

            STATUS.Text = "-";
            _progress.Value = 0;
        }

        private void AutoClear()
        {
            ePATHFIELD.Text = string.Empty;
            ePASS.Text = string.Empty;
            ePASS_REPEAT.Text = string.Empty;
        }

        private void eBUTTON_Click(object sender, EventArgs e)
        {
            if (ePATHFIELD.Text != "" && ePATHFIELD.Text.Replace(" ", "").Length > 0)
            {
                if (Directory.Exists(ePATHFIELD.Text))
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(ePATHFIELD.Text);

                    if(directoryInfo.GetFiles().Length > 0 || directoryInfo.GetDirectories().Length > 0)
                    {
                        if(ePASS.Text.Length >= 6 && ePASS.Text.Replace(" ","").Length > 0)
                        {
                            if (!Directory.Exists(Path.Combine(ePATHFIELD.Text, ".encrypted_by_fileprotector")))
                            {
                                if (ePASS.Text == ePASS_REPEAT.Text)
                                {
                                    DisableAll();
                                    encryptor.Start();
                                    Crypter.Encrypt(ePATHFIELD.Text, ePASS.Text);
                                }
                                else
                                {
                                    Program.ShowMessageBox("Пароли не совпадают");
                                }
                            }
                            else
                            {
                                Program.ShowMessageBox("Эта директория уже зашифрована");
                            }
                        }
                        else
                        {
                            Program.ShowMessageBox("Пароль должен быть не менее 6 символов");
                        }
                    }
                    else
                    {
                        Program.ShowMessageBox("Директория пуста");
                    }
                }
                else
                {
                    Program.ShowMessageBox("Директория не найдена");
                }
            }
            else
            {
                Program.ShowMessageBox("Неправильно указан путь к дериктории");
            }
        }

        private void encryptor_Tick(object sender, EventArgs e)
        {
            STATUS.Text = currPath;

            _progress.Maximum = allFilesCount;
            _progress.Value = filesEncrypted;

            if(Crypter.result == 1)
            {
                encryptor.Stop();
                _progress.Value = _progress.Maximum;
                Program.ShowMessageBox("Данные успешно зашифрованы!");
                AutoClear();
                EnableAll();
                Crypter.result = 0;
            }
            else if(Crypter.result == 2)
            {
                encryptor.Stop();
                _progress.Value = _progress.Maximum;
                Program.ShowMessageBox("Ошибка шифрование данных");
                EnableAll();
                Crypter.result = 0;
            }
        }

        private void FrmEncrypt_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (STATUS.Text == "-")
                Environment.Exit(0);
            else
                e.Cancel = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmEncrypt_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            FrmEncrypt_MouseDown(sender, e);
        }

        private void openDecryptForm_Click(object sender, EventArgs e)
        {
            FrmDecrypt frmDecrypt = new FrmDecrypt();
            frmDecrypt.Show();
            Hide();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            FrmAbout about = new FrmAbout();
            about.ShowDialog();
        }

        private void openSettings_Click(object sender, EventArgs e)
        {
            FrmSettings settings = new FrmSettings();
            settings.ShowDialog();
        }

        private void MINIMIZE_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
