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

        public ProceedCryptoForm(Form baseForm,
            TransformationMode mode,
            List<string> paths,
            string password,
            bool hideFiles)
        {
            Worker = new CryptoWorker(password, hideFiles);
            Mode = mode;

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
                NameLabel.Text = "Encrypting";
                Worker.EncryptAsync(paths);
            }
            else if (Mode == TransformationMode.Decrypt)
            {
                NameLabel.Text = "Decrypting";
                Worker.DecryptAsync(paths);
                
            }
            
            FormUpdateTimer.Start();
        }

        private void OnFormUpdateTimerTick(object sender, EventArgs e)
        {
            CryptoState state = Worker.State;

            MainProgressBar.Maximum = (int)state.FilesCount;
            MainProgressBar.Value = (int)state.TransformedFilesCount;

            if (state.Completed)
            {
                FormUpdateTimer.Stop();
                MainProgressBar.Value = MainProgressBar.Maximum;

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
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !AllowClosing;
        }
    }
}
