﻿using FileProtector.Crypto;
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
            Worker = new CryptoWorker(password);
            Mode = mode;

            Paths = FSUtils.FindAllFiles(paths);
            HideFiles = hideFiles;

            InitializeComponent();

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

                if (state.Errors.Count > 0)
                {
                    CryptoErrorsForm errorsForm = new CryptoErrorsForm(this, state.Errors);
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
