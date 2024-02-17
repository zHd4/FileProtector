using FileProtector.Crypto;
using FileProtector.Exceptions;
using FileProtector.Forms.Main;
using FileProtector.Forms.Message;
using FileProtector.Forms.Modal.ProceedCrypto;
using FileProtector.Models;
using FileProtector.Utils;
using System.Security.Cryptography;

namespace FileProtector
{
    public partial class MainForm : Form
    {
        private const string SelectedBrowseText = "Other...";
        private readonly Color SelectedBrowseColor = Color.FromArgb(190, 13, 237);

        private Point ShowPasswordLoacation;

        private List<string> SelectedPaths = new List<string>();
        private TransformationMode CurrentMode = TransformationMode.Encrypt;

        public MainForm()
        {
            InitializeComponent();
            ConfigureMovables(GetMovables());

            AppVersionLabel.Text = "v" + AppUtils.FetchVersion();

            MaximizeBox = false;
            ShowPasswordLoacation = GetShowPasswordLocation();
        }

        private List<Control> GetMovables()
        {
            return new List<Control>
            {
                this, WindowControlPanel, WindowNameLabel, IconPictureBox
            };
        }

        private void ConfigureMovables(List<Control> movables)
        {
            MouseEventHandler moveWindowHandler = AppUtils.GetMoveWindowHandler(Handle);
            movables.ForEach(movable => movable.MouseDown += moveWindowHandler);
        }

        private Point GetShowPasswordLocation()
        {
            Point location = ShowPasswordCheckBox.Location;
            return new Point(location.X, location.Y);
        }

        private void OnEncryptRadioCheckedChanged(object sender, EventArgs e)
        {
            CurrentMode = TransformationMode.Encrypt;
            ShowPasswordCheckBox.Location = ShowPasswordLoacation;

            ConfirmPasswordPanel.Enabled = true;
            ConfirmPasswordPanel.Visible = true;

            ProceedButton.Text = "Encrypt!";
        }

        private void OnDecryptRadioCheckedChanged(object sender, EventArgs e)
        {
            CurrentMode = TransformationMode.Decrypt;

            ConfirmPasswordPanel.Enabled = false;
            ConfirmPasswordPanel.Visible = false;

            ShowPasswordCheckBox.Location = ConfirmPasswordPanel.Location;
            ProceedButton.Text = "Decrypt!";
        }

        private void OnShowPasswordCheckedChanged(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = !ShowPasswordCheckBox.Checked;
            ConfirmPasswordTextBox.UseSystemPasswordChar = !ShowPasswordCheckBox.Checked;
        }

        private void OnCloseButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void OnMinimizeButtonClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void OnBrowseButtonClick(object sender, EventArgs e)
        {
            SelectedPaths.Clear();

            if (!FolderCheckBox.Checked)
            {
                SelectedPaths.AddRange(FilesManager.OpenSelectFilesDialog());
            }
            else
            {
                SelectedPaths.Add(FilesManager.OpenSelectFolderDialog());
            }

            if (SelectedPaths.Count > 0)
            {
                BrowseButton.BackColor = SelectedBrowseColor;
                BrowseButton.Text = SelectedBrowseText;
            }
        }

        private void OnProceedButtonClick(object sender, EventArgs e)
        {
            string password = PasswordTextBox.Text;
            //CryptoWorker worker = new CryptoWorker(password);

            try
            {
                CheckUtils.CheckSelectedPaths(SelectedPaths);
            }
            catch (Exception ex) when (ex is InvalidOperationException || 
                ex is PathNotFoundException)
            {
                CustomMessageBox.Show(ex.Message, this);
                return;
            }

            ProceedCryptoForm cryptoForm = new ProceedCryptoForm(this, CurrentMode, SelectedPaths, password);

            if (CurrentMode == TransformationMode.Encrypt)
            {
                string passwordConfirmation = ConfirmPasswordTextBox.Text;
                
                try
                {
                    CheckUtils.CheckPasswords(password, passwordConfirmation);
                }
                catch (ArgumentException ex)
                {
                    CustomMessageBox.Show(ex.Message, this);
                    return;
                }

                //worker.EncryptAsync(SelectedPaths);
            }
            //else if (CurrentMode == TransformationMode.Decrypt)
            //{
            //    try
            //    {
            //        worker.DecryptAsync(SelectedPaths);
            //    }
            //    catch (CryptographicException ex)
            //    {
            //        CustomMessageBox.Show(ex.Message, this);
            //    }
            //}

            cryptoForm.ShowDialog();
        }
    }
}