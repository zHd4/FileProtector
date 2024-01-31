namespace FileProtector.Forms.Message
{
    internal partial class CustomMessageForm : Form
    {
        public CustomMessageForm(string text)
        {
            InitializeComponent();

            MessageTextLabel.Text = text;
            MessageTextLabel.Location = new Point(
                (MessagePanel.Width / 2) - (MessageTextLabel.Width / 2), 
                MessageTextLabel.Location.Y);
        }

        private void OnOkButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
