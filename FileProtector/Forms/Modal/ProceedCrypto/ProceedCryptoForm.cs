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

        bool HideFiles;

        public ProceedCryptoForm(Form baseForm,
            TransformationMode mode,
            List<string> paths,
            string password,
            bool hideFiles)
        {
            Worker = new CryptoWorker(password);
            Mode = mode;
            HideFiles = hideFiles;

            InitializeComponent();

            Point startLocation = ModalUtils.GetModalWindowLocation(baseForm, this);

            Left = startLocation.X;
            Top = startLocation.Y;

            MouseEventHandler moveWindowHandler = AppUtils.GetMoveWindowHandler(Handle);

            MouseDown += moveWindowHandler;
            MainPanel.MouseDown += moveWindowHandler;

            Run(paths);
        }

        private void Run(List<string> paths)
        {
            StatusLabel.Text = "";

            if (Mode == TransformationMode.Encrypt)
            {
                NameLabel.Text = "Encryption";
                Worker.EncryptAsync(paths);
            }
            else if (Mode == TransformationMode.Decrypt)
            {
                NameLabel.Text = "Decryption";
                Worker.DecryptAsync(paths);
                
            }
            
            FormUpdateTimer.Start();
        }

        private void OnFormUpdateTimerTick(object sender, EventArgs e)
        {
            CryptoState state = Worker.State;

            if (state.Completed)
            {
                FormUpdateTimer.Stop();
                MainProgressBar.Value = 100;

                if (state.Errors.Count > 0)
                {
                    CryptoErrorsForm errorsForm = new CryptoErrorsForm(this, Mode, state.Errors);
                    errorsForm.ShowDialog();
                }
                else
                {
                    ModalMessageBox.Show("Completed successfully!", this);
                }

                AllowClosing = true;

                Close();
                return;
            }

            StatusLabel.Text = state.Message;
            MainProgressBar.Value = (int)(state.TransformedFilesCount / state.FilesCount * 100);
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !AllowClosing;
        }
    }
}
