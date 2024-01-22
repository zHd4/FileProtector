using FileProtector.Model;
using FileProtector.Models;
using System.Diagnostics;
using System.Reflection;
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

        private List<FormField> OperationsFormFields;
        private Point ShowPasswordCheckBoxOriginalLoacation;
        private TransformationMode CurrentMode = TransformationMode.Encrypt;

        public MainForm()
        {
            InitializeComponent();
            Text += " " + FetchVersion();

            MaximizeBox = false;
            OperationsFormFields = GetFieldsList();

            ShowPasswordCheckBoxOriginalLoacation = GetShowPasswordCheckBoxLocation();
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

        private void SetFieldsPlaceholders()
        {
            foreach (FormField formField in OperationsFormFields)
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

        private void MoveForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private bool PasswordIsHidden()
        {
            return !ShowPasswordCheckBox.Checked;
        }

        private void ShowPasswordCheckedChanged(object sender, EventArgs e)
        {
            OperationsFormFields.Where(field => field.IsPassword)
                .ToList()
                .ForEach(field =>
                {
                    if (field.Field.Text != field.Placeholder)
                    {
                        field.Field.UseSystemPasswordChar = !ShowPasswordCheckBox.Checked;
                    }
                });
        }

        private string FetchVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo info = FileVersionInfo.GetVersionInfo(assembly.Location);

            return info.FileVersion ?? throw new NullReferenceException();
        }

        private Point GetShowPasswordCheckBoxLocation()
        {
            Point location = ShowPasswordCheckBox.Location;
            return new Point(location.X, location.Y);
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(sender, e);
        }

        private void WindowControlPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(sender, e);
        }

        private void WindowNameLabel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(sender, e);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void EncryptRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CurrentMode = TransformationMode.Encrypt;
            ShowPasswordCheckBox.Location = ShowPasswordCheckBoxOriginalLoacation;

            ConfirmPasswordTextBoxExternalContainer.Enabled = true;
            ConfirmPasswordTextBoxExternalContainer.Visible = true;

            ProceedButton.Text = "Encrypt!";
        }

        private void DecryptRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CurrentMode = TransformationMode.Decrypt;

            ConfirmPasswordTextBoxExternalContainer.Enabled = false;
            ConfirmPasswordTextBoxExternalContainer.Visible = false;

            ShowPasswordCheckBox.Location = ConfirmPasswordTextBoxExternalContainer.Location;
            ProceedButton.Text = "Decrypt!";
        }
    }
}