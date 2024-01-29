using FileProtector.Crypto;
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

        private const int MIN_PASSWORD_LENGTH = 6;

        private const string DefaultBrowseText = "Browse...";
        private const string ActivatedBrowseText = "Other...";

        private readonly Color DefaultBrowseColor = Color.FromArgb(43, 38, 86);
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

        private void ShowPasswordCheckedChanged(object sender, EventArgs e)
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

        private void OnPasswordFieldEnter(TextBox field)
        {
            if (field.ForeColor == FieldsPlaceholderColor)
            {
                field.Text = "";
                field.ForeColor = FieldsTextColor;
                field.UseSystemPasswordChar = true;
            }
        }

        private void OnPasswordFieldLeave(TextBox field, string placeholder)
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
            OnPasswordFieldEnter(PasswordTextBox);
        }

        private void OnConfirmPasswordTextBoxEnter(object sender, EventArgs e)
        {
            OnPasswordFieldEnter(ConfirmPasswordTextBox);
        }

        private void OnPasswordTextBoxLeave(object sender, EventArgs e)
        {
            OnPasswordFieldLeave(PasswordTextBox, "Password");
        }

        private void OnConfirmPasswordTextBoxLeave(object sender, EventArgs e)
        {
            OnPasswordFieldLeave(ConfirmPasswordTextBox, "Confirm password");
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
                SelectedPaths.AddRange(OpenSelectFilesDialog());
            }
            else
            {
                SelectedPaths.Add(OpenSelectFolderDialog());
            }

            BrowseButton.BackColor = ActivatedBrowseColor;
            BrowseButton.Text = ActivatedBrowseText;
        }

        private List<string> OpenSelectFilesDialog()
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Multiselect = true;
            dialog.ShowDialog();

            return dialog.FileNames.ToList();
        }

        private string OpenSelectFolderDialog()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            dialog.ShowDialog();
            return dialog.SelectedPath;
        }

        private void OnProceedButtonClick(object sender, EventArgs e)
        {
            string password = PasswordTextBox.Text;
            CryptoService cryptoService = new CryptoService(password);

            try
            {
                CheckSelectedPaths();
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
                PasswordsCheckStatus checkStatus = CheckPasswords(password, passwordConfirmation);

                if (!checkStatus.Success)
                {
                    // Message
                    return;
                }

                cryptoService.Encrypt(SelectedPaths);
            }
            else
            {
                cryptoService.Decrypt(SelectedPaths);
            }
        }

        private PasswordsCheckStatus CheckPasswords(string password, string passwordConfirmation)
        {
            if (password.Length < MIN_PASSWORD_LENGTH)
            {
                return new PasswordsCheckStatus(false, "Password must be at least %s characters long");
            }

            if (password != passwordConfirmation)
            {
                return new PasswordsCheckStatus(false, "Passwords not match");
            }

            return new PasswordsCheckStatus(true, "");
        }

        private void CheckSelectedPaths()
        {
            if (SelectedPaths.Count == 0)
            {
                throw new InvalidOperationException("Please select file(s) or folder");
            }

            SelectedPaths.ForEach(path => {
                bool isDir = IsDirectory(path);
                Func<string, bool> check = isDir ? Directory.Exists : File.Exists;

                if (!check(path))
                {
                    string message = "Cannot find: " + path;
                    throw isDir ? new DirectoryNotFoundException(message) : new FileNotFoundException(message);
                }
            });
        }

        private bool IsDirectory(string path)
        {
            return (File.GetAttributes(path) & FileAttributes.Directory) == FileAttributes.Directory;
        }
    }
}