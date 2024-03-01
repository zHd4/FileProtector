using FileProtector.Models;
using FileProtector.Utils;

namespace FileProtector.Forms.Modal.ProceedCrypto
{
    public partial class CryptoConfirmationForm : Form
    {
        public bool HideFiles { get; } = false;

        TransformationMode Mode;
        List<string> Paths;

        public CryptoConfirmationForm(Form baseForm,
            TransformationMode mode, 
            List<string> paths)
        {
            Mode = mode;
            Paths = FSUtils.FindAllFiles(paths);

            InitializeComponent();

            Point startLocation = ModalUtils.GetModalWindowLocation(baseForm, this);

            Left = startLocation.X;
            Top = startLocation.Y;

            MouseEventHandler moveWindowHandler = AppUtils.GetMoveWindowHandler(Handle);

            MouseDown += moveWindowHandler;
            MainPanel.MouseDown += moveWindowHandler;

            MoveComponents();
            LoadPaths();
        }

        private void LoadPaths()
        {
            Paths.ForEach(path => PathsListBox.Items.Add(path));
        }

        private void MoveComponents()
        {
            if (Mode == TransformationMode.Decrypt)
            {
                HideFilesCheckBox.Enabled = false;
                HideFilesCheckBox.Visible = false;
            }
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelEncryptionButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
