using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FileProtector
{
    public partial class FrmDecrypt : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public static string currPath = "-";
        public static int allFilesCount = 0;
        public static int filesEncrypted = 0;

        public FrmDecrypt()
        {
            InitializeComponent();
        }

        private void DisableAll() // Отключение всех компонентов окна
        {
            dPATHFIELD.ReadOnly = true;
            dPASS.ReadOnly = true;
            dBROWSE.Click -= new EventHandler(dBROWSE_Click);
            dShow.Click -= new EventHandler(dShow_CheckedChanged);
            dBUTTON.Click -= new EventHandler(dBUTTON_Click);
            aboutButton.Click -= new EventHandler(aboutButton_Click);
            openEncryptForm.Click -= new EventHandler(openEncryptForm_Click);
            openSettings.Click -= new EventHandler(openSettings_Click);
        }

        private void EnableAll() // Включение всех компонентов окна
        {
            dPATHFIELD.ReadOnly = false;
            dPASS.ReadOnly = false;
            dBROWSE.Click += new EventHandler(dBROWSE_Click);
            dShow.Click += new EventHandler(dShow_CheckedChanged);
            dBUTTON.Click += new EventHandler(dBUTTON_Click);
            aboutButton.Click += new EventHandler(aboutButton_Click);
            openEncryptForm.Click += new EventHandler(openEncryptForm_Click);
            openSettings.Click += new EventHandler(openSettings_Click);

            STATUS.Text = "-";
            _progress.Value = 0;
        }

        private void AutoClear() // Очистка полей для ввода
        {
            dPATHFIELD.Text = string.Empty;
            dPASS.Text = string.Empty;
        }

        private void dBROWSE_Click(object sender, EventArgs e) // Окрытие окна обозревателя для выбора директории
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    dPATHFIELD.Text = fbd.SelectedPath;
                }
            }
        }

        private void dShow_CheckedChanged(object sender, EventArgs e) // Функция "Показать пароль"
        {
            if (dShow.Checked)
            {
                dPASS.UseSystemPasswordChar = false;
            }
            else
            {
                dPASS.UseSystemPasswordChar = true;
            }
        }

        private void aboutButton_Click(object sender, EventArgs e) // Открытие окна "О программе"
        {
            FrmAbout about = new FrmAbout();
            about.ShowDialog();
        }

        private void dBUTTON_Click(object sender, EventArgs e) // Кнопка расшифровать
        {
            if (dPATHFIELD.Text != "" && dPATHFIELD.Text.Replace(" ", "").Length > 0)
            {
                if (Directory.Exists(dPATHFIELD.Text))
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(dPATHFIELD.Text);

                    if (directoryInfo.GetFiles().Length > 0)
                    {
                        if (dPASS.Text.Length >= 6 && dPASS.Text.Replace(" ", "").Length > 0)
                        {
                            if (Directory.Exists(Path.Combine(dPATHFIELD.Text, ".encrypted_by_fileprotector")))
                            {
                                DisableAll();
                                decryptor.Start();
                                Crypter.Decrypt(dPATHFIELD.Text, dPASS.Text);
                            }
                            else
                            {
                                Program.ShowMessageBox("Эта директория не зашифрована");
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

        private void FrmDecrypt_FormClosing(object sender, FormClosingEventArgs e) // Функция закрытие формы
        {
            if (STATUS.Text == "-")
                Environment.Exit(0);
            else
                e.Cancel = true;
        }

        private void openEncryptForm_Click(object sender, EventArgs e) // Открыть вкладку шифрования
        {
            FrmEncrypt frmEncrypt = new FrmEncrypt();
            frmEncrypt.Show();
            Hide();
        }

        private void decryptor_Tick(object sender, EventArgs e) // Таймер дешифрования
        {
            STATUS.Text = currPath;

            _progress.Maximum = allFilesCount;
            _progress.Value = filesEncrypted;

            if (Crypter.result == 1)
            {
                decryptor.Stop();
                _progress.Value = _progress.Maximum;
                Program.ShowMessageBox("Данные успешно расшифрованы!");
                AutoClear();
                EnableAll();
                Crypter.result = 0;
            }
            else if (Crypter.result == 2)
            {
                decryptor.Stop();
                _progress.Value = _progress.Maximum;
                Program.ShowMessageBox("Неправильный пароль");
                EnableAll();
                Crypter.result = 0;
            }
            else if (Crypter.result == 3)
            {
                decryptor.Stop();
                _progress.Value = _progress.Maximum;
                Program.ShowMessageBox("Ошибка расшифровки данных");
                EnableAll();
                Crypter.result = 0;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmDecrypt_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            FrmDecrypt_MouseDown(sender, e);
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

        private void FrmDecrypt_Load(object sender, EventArgs e)
        {
            dBUTTON.Text = "\uD83D\uDD13 " + dBUTTON.Text;
        }
    }
}
