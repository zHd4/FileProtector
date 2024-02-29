using FileProtector.Utils;

namespace FileProtector.Forms.Modal.ProceedCrypto
{
    public partial class CryptoErrorsForm : Form
    {
        List<string> Errors;

        public CryptoErrorsForm(Form baseForm, List<string> errors)
        {
            Errors = errors;
            InitializeComponent();

            Point startLocation = ModalUtils.GetModalWindowLocation(baseForm, this);

            Left = startLocation.X;
            Top = startLocation.Y;

            MouseEventHandler moveWindowHandler = AppUtils.GetMoveWindowHandler(Handle);

            MouseDown += moveWindowHandler;
            MainPanel.MouseDown += moveWindowHandler;

            LoadErrors();
        }

        private void LoadErrors()
        {
            Errors.ForEach(error => ErrorsListBox.Items.Add(error));
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
