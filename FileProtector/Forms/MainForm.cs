using FileProtector.Models;
using FileProtector.Utils;
using System.Runtime.InteropServices;

namespace FileProtector
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        private readonly Color FieldsTextColor = Color.White;
        private readonly Color FieldsPlaceholderColor = Color.DimGray;

        private Point ShowPasswordLoacation;
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
            
        }
    }
}