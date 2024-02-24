namespace FileProtector.Forms.Message
{
    public static class ModalMessageBox
    {
        public static void Show(string text, Form baseForm)
        {
            new ModalMessageForm(text, baseForm).ShowDialog();
        }
    }
}
