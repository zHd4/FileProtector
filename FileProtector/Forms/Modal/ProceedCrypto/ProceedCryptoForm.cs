using FileProtector.Crypto;
using FileProtector.Models;
using FileProtector.Utils;

namespace FileProtector.Forms.Modal.ProceedCrypto
{
    public partial class ProceedCryptoForm : Form
    {
        CryptoWorker Worker;
        TransformationMode Mode;

        List<string> Paths;
        bool HideFiles;

        public ProceedCryptoForm(Form baseForm,
            TransformationMode mode,
            List<string> paths,
            string password,
            bool hideFiles)
        {
            InitializeComponent();

            Worker = new CryptoWorker(password);
            Mode = mode;

            Paths = FSUtils.FindAllFiles(paths);
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

            Worker.EncryptAsync(Paths);
            FormUpdateTimer.Start();
        }

        private void OnFormUpdateTimerTick(object sender, EventArgs e)
        {
            CryptoState state = Worker.State;

            if (state.Completed)
            {
                FormUpdateTimer.Stop();
                return;
            }

            StatusLabel.Text = state.Message;
            MainProgressBar.Value = (int)(state.TransformedFilesCount / state.FilesCount * 100);
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
