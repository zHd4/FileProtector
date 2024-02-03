namespace FileProtector.Forms.Message
{
    public static class CustomMessageBox
    {
        public static void Show(string text, Form baseForm)
        {
            new CustomMessageForm(text, baseForm).ShowDialog();
        }
    }
}
