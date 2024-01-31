namespace FileProtector.Forms.Message
{
    public static class CustomMessageBox
    {
        public static void Show(string text)
        {
            new CustomMessageForm(text).ShowDialog();
        }
    }
}
