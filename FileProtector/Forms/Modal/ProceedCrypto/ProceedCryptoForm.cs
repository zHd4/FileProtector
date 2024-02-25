using FileProtector.Crypto;
using FileProtector.Forms.Message;
using FileProtector.Models;
using FileProtector.Utils;

namespace FileProtector.Forms.Modal.ProceedCrypto
{
    public partial class ProceedCryptoForm : Form
    {
        bool AllowClosing = false;

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
                Worker.DecryptAsync(Paths);
            }
            else
            {
                Worker.EncryptAsync(Paths);
            }

            StatusLabel.Text = "";
            FormUpdateTimer.Start();
        }

        private void OnFormUpdateTimerTick(object sender, EventArgs e)
        {
            CryptoState state = Worker.State;

            if (state.Completed)
            {
                FormUpdateTimer.Stop();
                MainProgressBar.Value = 100;

                ModalMessageBox.Show("Completed!", this);
                AllowClosing = true;

                Close();
                return;
            }

            StatusLabel.Text = state.Message;

            long i = (state.TransformedFilesCount / state.FilesCount * 100);
            int iv = (int)i;

            MainProgressBar.Value = iv;
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !AllowClosing;
        }
    }
}
