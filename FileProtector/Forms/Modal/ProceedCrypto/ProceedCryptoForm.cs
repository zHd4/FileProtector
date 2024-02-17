using FileProtector.Models;
using FileProtector.Utils;

namespace FileProtector.Forms.Modal.ProceedCrypto
{
    public partial class ProceedCryptoForm : Form
    {
        Size FormSize = new Size(461, 300);

        TransformationMode Mode;
        List<string> Paths;
        string Password;

        public ProceedCryptoForm(Form baseForm,
            TransformationMode mode, 
            List<string> paths, 
            string password)
        {
            InitializeComponent();

            Mode = mode;
            Paths = paths;
            Password = password;

            Size = FormSize;

            Point startLocation = ModalUtils.GetModalWindowLocation(baseForm, this);

            Left = startLocation.X;
            Top = startLocation.Y;

            MouseEventHandler moveWindowHandler = AppUtils.GetMoveWindowHandler(Handle);

            MouseDown += moveWindowHandler;
            EncryptionPanel.MouseDown += moveWindowHandler;
        }

        private void CancelEncryptionButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
