using FileProtector.Models;
using System.Diagnostics;
using System.Reflection;

namespace FileProtector
{
    public partial class MainForm : Form
    {
        private static Color FieldsTextColor = Color.Black;
        private static Color FieldsPlaceholderColor = Color.DimGray;

        public MainForm()
        {
            InitializeComponent();
            Text += " " + FetchVersion();
            MaximizeBox = false;
            SetFieldsPlaceholders();
        }

        private List<FormField> GetFieldsList()
        {
            return new List<FormField> 
            {
                new FormField(PathTextBox, "Path"),
                new FormField(PasswordTextBox, "Password", true),
                new FormField(ConfirmPasswordTextBox, "Confirm password", true)
            };
        }

        private void SetFieldsPlaceholders()
        {
            foreach (FormField formField in GetFieldsList())
            {
                TextBox field = formField.Field;
                String placeholder = formField.Placeholder;

                bool isPassword = formField.IsPassword;
                field.ForeColor = FieldsPlaceholderColor;

                field.Enter += new EventHandler((sender, e) => {
                    if (field.ForeColor == FieldsPlaceholderColor)
                    {
                        field.Text = "";
                        field.ForeColor = FieldsTextColor;

                        if (isPassword)
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

                        if (isPassword)
                        {
                            field.UseSystemPasswordChar = false;
                        }
                    }
                });
            }
        }

        private string FetchVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo info = FileVersionInfo.GetVersionInfo(assembly.Location);

            return info.FileVersion ?? throw new NullReferenceException();
        }
    }
}