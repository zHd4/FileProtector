using FileProtector.Crypto;
using FileProtector.Forms.Main;
using FileProtector.Models;
using FileProtector.Utils;
using System.Runtime.InteropServices;

namespace FileProtector
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        private const string ActivatedBrowseText = "Other...";

        private readonly Color ActivatedBrowseColor = Color.FromArgb(190, 13, 237);
        private readonly Color FieldsTextColor = Color.White;
        private readonly Color FieldsPlaceholderColor = Color.DimGray;

        private Point ShowPasswordLoacation;

        private List<string> SelectedPaths = new List<string>();
        private TransformationMode CurrentMode = TransformationMode.Encrypt;

        public MainForm()
        {
            InitializeComponent();
            ConfigureMovables(GetMovables());

            AppVersionLabel.Text = "v" + AppUtils.FetchVersion();

            MaximizeBox = false;
            ShowPasswordLoacation = GetShowPasswordLocation();

            PasswordTextBox.ForeColor = FieldsPlaceholderColor;
            ConfirmPasswordTextBox.ForeColor = FieldsPlaceholderColor;
        }

        private List<Control> GetMovables()
        {
            return new List<Control>
            {
                this, WindowControlPanel, WindowNameLabel, IconPictureBox
            };
        }

        private void ConfigureMovables(List<Control> movables)
        {
            movables.ForEach(movable => movable.MouseDown += new MouseEventHandler((sender, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }));
        }

        private Point GetShowPasswordLocation()
        {
            Point location = ShowPasswordCheckBox.Location;
            return new Point(location.X, location.Y);
        }

        private void OnEncryptRadioCheckedChanged(object sender, EventArgs e)
        {
            CurrentMode = TransformationMode.Encrypt;
            ShowPasswordCheckBox.Location = ShowPasswordLoacation;

            ConfirmPasswordTextBoxExternalContainer.Enabled = true;
            ConfirmPasswordTextBoxExternalContainer.Visible = true;

            ProceedButton.Text = "Encrypt!";
        }

        private void OnDecryptRadioCheckedChanged(object sender, EventArgs e)
        {
            CurrentMode = TransformationMode.Decrypt;

            ConfirmPasswordTextBoxExternalContainer.Enabled = false;
            ConfirmPasswordTextBoxExternalContainer.Visible = false;

            ShowPasswordCheckBox.Location = ConfirmPasswordTextBoxExternalContainer.Location;
            ProceedButton.Text = "Decrypt!";
        }

        private void OnFieldEnter(TextBox field)
        {
            if (field.ForeColor == FieldsPlaceholderColor)
            {
                field.Text = "";
                field.ForeColor = FieldsTextColor;
                field.UseSystemPasswordChar = true;
            }
        }

        private void OnFieldLeave(TextBox field, string placeholder)
        {
            if (field.Text == "")
            {
                field.Text = placeholder;
                field.ForeColor = FieldsPlaceholderColor;
                field.UseSystemPasswordChar = false;
            }
        }

        private void OnPasswordTextBoxEnter(object sender, EventArgs e)
        {
            OnFieldEnter(PasswordTextBox);
        }

        private void OnConfirmPasswordTextBoxEnter(object sender, EventArgs e)
        {
            OnFieldEnter(ConfirmPasswordTextBox);
        }

        private void OnPasswordTextBoxLeave(object sender, EventArgs e)
        {
            OnFieldLeave(PasswordTextBox, "Password");
        }

        private void OnConfirmPasswordTextBoxLeave(object sender, EventArgs e)
        {
            OnFieldLeave(ConfirmPasswordTextBox, "Confirm password");
        }

        private void OnPasswordTextBoxTextChanged(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = !ShowPasswordCheckBox.Checked;
        }

        private void OnConfirmPasswordTextBoxTextChanged(object sender, EventArgs e)
        {
            ConfirmPasswordTextBox.UseSystemPasswordChar = !ShowPasswordCheckBox.Checked;
        }

        private void OnShowPasswordCheckedChanged(object sender, EventArgs e)
        {
            if (PasswordTextBox.ForeColor != FieldsPlaceholderColor)
            {
                PasswordTextBox.UseSystemPasswordChar = !ShowPasswordCheckBox.Checked;
            }

            if (ConfirmPasswordTextBox.ForeColor != FieldsPlaceholderColor)
            {
                ConfirmPasswordTextBox.UseSystemPasswordChar = !ShowPasswordCheckBox.Checked;
            }
        }

        private void OnCloseButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void OnMinimizeButtonClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void OnBrowseButtonClick(object sender, EventArgs e)
        {
            SelectedPaths.Clear();

            if (!FolderCheckBox.Checked)
            {
                SelectedPaths.AddRange(FilesManager.OpenSelectFilesDialog());
            }
            else
            {
                SelectedPaths.Add(FilesManager.OpenSelectFolderDialog());
            }

            BrowseButton.BackColor = ActivatedBrowseColor;
            BrowseButton.Text = ActivatedBrowseText;
        }

        private void OnProceedButtonClick(object sender, EventArgs e)
        {
            string password = PasswordTextBox.Text;
            CryptoService cryptoService = new CryptoService(password);

            try
            {
                CheckUtils.CheckSelectedPaths(SelectedPaths);
            }
            catch (Exception ex) when (ex is InvalidOperationException || 
                ex is DirectoryNotFoundException || 
                ex is FileNotFoundException)
            {
                //Message
                return;
            }

            if (CurrentMode == TransformationMode.Encrypt)
            {
                string passwordConfirmation = ConfirmPasswordTextBox.Text;
                
                try
                {
                    CheckUtils.CheckPasswords(password, passwordConfirmation);
                }
                catch (ArgumentException ex)
                {
                    //Message
                    return;
                }

                cryptoService.Encrypt(SelectedPaths);
            }
            else
            {
                cryptoService.Decrypt(SelectedPaths);
            }
        }
    }
}