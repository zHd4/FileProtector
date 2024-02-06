using FileProtector.Utils;

namespace FileProtector.Forms.Message
{
    internal partial class CustomMessageForm : Form
    {
        private const int MAX_MESSAGE_WIDTH = 240;

        public CustomMessageForm(string text, Form baseForm)
        {
            InitializeComponent();
            AdaptForMessage(text);

            Point startLocation = ModalUtils.GetModalWindowLocation(baseForm, this);

            Left = startLocation.X;
            Top = startLocation.Y;

            MouseEventHandler moveWindowHandler = AppUtils.GetMoveWindowHandler(Handle);

            MouseDown += moveWindowHandler;
            MessagePanel.MouseDown += moveWindowHandler;
        }

        private void AdaptForMessage(string message)
        {
            int messageLineHeight = MessageTextLabel.Height;
            MessageTextLabel.Text = message;

            if (MessageTextLabel.Width > MAX_MESSAGE_WIDTH)
            {
                int diff = MessageTextLabel.Width - MAX_MESSAGE_WIDTH;

                Width += diff;
                MessagePanel.Width += diff;
            }

            if (MessageTextLabel.Height > messageLineHeight)
            {
                int diff = MessageTextLabel.Height - messageLineHeight;

                Height += diff;
                MessagePanel.Height += diff;
                OkButton.Location = new Point(OkButton.Location.X, OkButton.Location.Y + diff);
            }

            CentralizeControlHorizontal(MessageTextLabel);
            CentralizeControlHorizontal(OkButton);
        }

        private void CentralizeControlHorizontal(Control control)
        {
            control.Location = new Point((MessagePanel.Width / 2) - (control.Width / 2), control.Location.Y);
        }

        private void OnOkButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
