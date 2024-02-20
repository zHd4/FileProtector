using FileProtector.Models;
using FileProtector.Utils;

namespace FileProtector.Forms.Modal.ProceedCrypto
{
    public partial class CryptoConfirmationForm : Form
    {
        Size FormSize = new Size(661, 500);

        TransformationMode Mode;
        List<string> Paths;
        string Password;

        public CryptoConfirmationForm(Form baseForm,
            TransformationMode mode, 
            List<string> paths, 
            string password)
        {
            InitializeComponent();

            Mode = mode;
            Paths = FSUtils.FindAllFiles(paths);
            Password = password;

            Size = FormSize;

            Point startLocation = ModalUtils.GetModalWindowLocation(baseForm, this);

            Left = startLocation.X;
            Top = startLocation.Y;

            MouseEventHandler moveWindowHandler = AppUtils.GetMoveWindowHandler(Handle);

            MouseDown += moveWindowHandler;
            EncryptionPanel.MouseDown += moveWindowHandler;

            LoadPaths();
        }

        private void LoadPaths()
        {
            Paths.ForEach(path => EncryptListBox.Items.Add(path));
        }

        private void CancelEncryptionButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
