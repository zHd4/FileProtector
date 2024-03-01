using FileProtector.Exceptions;
using FileProtector.Forms.Message;
using FileProtector.Forms.Modal.ProceedCrypto;
using FileProtector.Models;
using FileProtector.Utils;

namespace FileProtector
{
    public partial class MainForm : Form
    {
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

        private void Reset()
        {
            SelectedPaths.Clear();

            BrowseButton.Text = "Browse...";
            BrowseButton.BackColor = Color.FromArgb(43, 38, 86);

            FolderCheckBox.Checked = false;

            PasswordTextBox.Text = string.Empty;
            ConfirmPasswordTextBox.Text = string.Empty;
        }

        private Point GetShowPasswordLocation()
        {
            Point location = ShowPasswordCheckBox.Location;
            return new Point(location.X, location.Y);
        }

        private void StartCryptoProccess(TransformationMode mode, List<string> paths, string password, bool hideFiles)
        {
            ProceedCryptoForm form = new ProceedCryptoForm(this, mode, paths, password, hideFiles);
            form.ShowDialog();
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
                SelectedPaths.AddRange(FSUtils.OpenSelectFilesDialog());
            }
            else
            {
                SelectedPaths.Add(FSUtils.OpenSelectFolderDialog());
            }

            if (SelectedPaths.Count > 0)
            {
                BrowseButton.BackColor = Color.FromArgb(190, 13, 237);
                BrowseButton.Text = "Other...";
            }
        }

        private void OnProceedButtonClick(object sender, EventArgs e)
        {
            string password = PasswordTextBox.Text;

            try
            {
                CheckUtils.CheckSelectedPaths(SelectedPaths);
            }
            catch (Exception ex) when (ex is InvalidOperationException || 
                ex is PathNotFoundException)
            {
                ModalMessageBox.Show(ex.Message, this);
                return;
            }

            CryptoConfirmationForm confirmationForm = new CryptoConfirmationForm(this, CurrentMode, SelectedPaths);

            if (CurrentMode == TransformationMode.Encrypt)
            {
                string passwordConfirmation = ConfirmPasswordTextBox.Text;
                
                try
                {
                    CheckUtils.CheckPasswords(password, passwordConfirmation);
                }
                catch (ArgumentException ex)
                {
                    ModalMessageBox.Show(ex.Message, this);
                    return;
                }

            }

            DialogResult dialogResult = confirmationForm.ShowDialog();
            
            if (dialogResult == DialogResult.OK)
            {
                StartCryptoProccess(CurrentMode, SelectedPaths, password, confirmationForm.HideFiles);
                Reset();
            }
        }
    }
}