using FileProtector.Models;
using FileProtector.Utils;

namespace FileProtector.Forms.Modal.ProceedCrypto
{
    public partial class CryptoErrorsForm : Form
    {
        List<string> Errors;

        public CryptoErrorsForm(Form baseForm, TransformationMode mode, List<string> errors)
        {
            Errors = errors;
            InitializeComponent();

            Point startLocation = ModalUtils.GetModalWindowLocation(baseForm, this);

            Left = startLocation.X;
            Top = startLocation.Y;

            MouseEventHandler moveWindowHandler = AppUtils.GetMoveWindowHandler(Handle);

            MouseDown += moveWindowHandler;
            MainPanel.MouseDown += moveWindowHandler;

            Prepare(mode);
        }

        private void Prepare(TransformationMode mode)
        {
            if (mode == TransformationMode.Encrypt)
            {
                FormLabel.Text = "Encryption " + FormLabel.Text;
            }
            else if (mode == TransformationMode.Decrypt)
            {
                FormLabel.Text = "Decryption " + FormLabel.Text;
            }

            Errors.ForEach(error => ErrorsListBox.Items.Add(error));
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
