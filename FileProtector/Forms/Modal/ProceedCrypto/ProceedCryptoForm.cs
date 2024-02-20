using FileProtector.Models;
using FileProtector.Utils;

namespace FileProtector.Forms.Modal.ProceedCrypto
{
    public partial class ProceedCryptoForm : Form
    {
        TransformationMode Mode;
        List<string> Paths;

        string Password;
        bool HideFiles;

        public ProceedCryptoForm(Form baseForm,
            TransformationMode mode,
            List<string> paths,
            string password,
            bool hideFiles)
        {
            InitializeComponent();

            Mode = mode;
            Paths = FSUtils.FindAllFiles(paths);
            Password = password;
            HideFiles = hideFiles;

            Point startLocation = ModalUtils.GetModalWindowLocation(baseForm, this);

            Left = startLocation.X;
            Top = startLocation.Y;

            MouseEventHandler moveWindowHandler = AppUtils.GetMoveWindowHandler(Handle);

            MouseDown += moveWindowHandler;
            MainPanel.MouseDown += moveWindowHandler;

            Prepare();
        }

        private void Prepare()
        {
            if (Mode == TransformationMode.Decrypt)
            {
                NameLabel.Text = "Decryption";
            }

            StatusLabel.Text = "";
        }

        private void OnFormUpdateTimerTick(object sender, EventArgs e)
        {

        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
