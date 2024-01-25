using FileProtector.Model;
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

        private static Color FieldsTextColor = Color.White;
        private static Color FieldsPlaceholderColor = Color.DimGray;

        private List<FormField> FormFields;
        private Point ShowPasswordLoacation;

        private TransformationMode CurrentMode = TransformationMode.Encrypt;

        public MainForm()
        {
            InitializeComponent();
            ConfigureMovables(GetMovables());

            AppVersionLabel.Text = "v" + AppUtils.FetchVersion();
            FormFields = GetFieldsList();

            MaximizeBox = false;
            ShowPasswordLoacation = GetShowPasswordLocation();

            SetFieldsPlaceholders();
        }

        private List<FormField> GetFieldsList()
        {
            return new List<FormField> 
            {
                new FormField(PasswordTextBox, "Password", true),
                new FormField(ConfirmPasswordTextBox, "Confirm password", true)
            };
        }

        private List<Control> GetMovables()
        {
            return new List<Control>
            {
                this, WindowControlPanel, WindowNameLabel, IconPictureBox
            };
        }

        private void SetFieldsPlaceholders()
        {
            foreach (FormField formField in FormFields)
            {
                TextBox field = formField.Field;
                string placeholder = formField.Placeholder;

                bool isPassword = formField.IsPassword;
                field.ForeColor = FieldsPlaceholderColor;

                field.Enter += new EventHandler((sender, e) => {
                    if (field.ForeColor == FieldsPlaceholderColor)
                    {
                        field.Text = "";
                        field.ForeColor = FieldsTextColor;

                        if (isPassword && PasswordIsHidden())
                        {
                            field.UseSystemPasswordChar = true;
                        }
                    }
                });

                field.Leave += new EventHandler((sender, e) => {
                    if (field.Text == "")
                    {
                        field.Text = placeholder;
                        field.ForeColor = FieldsPlaceholderColor;

                        if (isPassword && PasswordIsHidden())
                        {
                            field.UseSystemPasswordChar = false;
                        }
                    }
                });
            }
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

        private bool PasswordIsHidden()
        {
            return !ShowPasswordCheckBox.Checked;
        }

        private void ShowPasswordCheckedChanged(object sender, EventArgs e)
        {
            FormFields.Where(field => field.IsPassword)
                .ToList()
                .ForEach(field =>
                {
                    if (field.Field.Text != field.Placeholder)
                    {
                        field.Field.UseSystemPasswordChar = !ShowPasswordCheckBox.Checked;
                    }
                });
        }

        private Point GetShowPasswordLocation()
        {
            Point location = ShowPasswordCheckBox.Location;
            return new Point(location.X, location.Y);
        }

        private void OnCloseButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void OnMinimizeButtonClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
    }
}