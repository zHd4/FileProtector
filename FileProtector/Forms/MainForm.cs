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

        private List<TextBox> GetFieldsList()
        {
            return new List<TextBox> 
            {
                EncryptionPathTextBox, EncryptionPasswordTextBox, 
                ConfirmEncryptionPasswordTextBox, DecryptionPathTextBox,
                DecryptionPasswordTextBox
            };
        }

        private void SetFieldsPlaceholders()
        {
            Dictionary<TextBox, string> filedsPlaceholders = new Dictionary<TextBox, string>();

            foreach (TextBox field in GetFieldsList())
            {
                string placeholder = field.Text;

                filedsPlaceholders.Add(field, placeholder);
                field.ForeColor = FieldsPlaceholderColor;

                field.Enter += new EventHandler((sender, e) => {
                    if (field.ForeColor == FieldsPlaceholderColor)
                    {
                        field.Text = "";
                        field.ForeColor = FieldsTextColor;
                    }
                });

                field.Leave += new EventHandler((sender, e) => {
                    if (field.Text == "")
                    {
                        field.Text = filedsPlaceholders[field];
                        field.ForeColor = FieldsPlaceholderColor;
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