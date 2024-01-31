namespace FileProtector.Forms.Message
{
    internal partial class CustomMessageForm : Form
    {
        public CustomMessageForm(string text)
        {
            InitializeComponent();
            AdaptForMessage(text);
        }

        private void AdaptForMessage(string message)
        {
            int messageLineHeight = MessageTextLabel.Height;
            MessageTextLabel.Text = message;

            MessageTextLabel.Location = new Point(
                (MessagePanel.Width / 2) - (MessageTextLabel.Width / 2),
                MessageTextLabel.Location.Y);

            if (MessageTextLabel.Height > messageLineHeight)
            {
                int diff = MessageTextLabel.Height - messageLineHeight;

                Height += diff;
                MessagePanel.Height += diff;
                OkButton.Location = new Point(OkButton.Location.X, OkButton.Location.Y + diff);
            }
        }

        private void OnOkButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
