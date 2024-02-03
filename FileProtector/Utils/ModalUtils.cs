namespace FileProtector.Utils
{
    public class ModalUtils
    {
        public static Point GetModalWindowLocation(Form baseForm, Form modalForm)
        {
            int baseX = baseForm.Left + baseForm.Width / 2;
            int baseY = baseForm.Top + baseForm.Height / 2;

            int modalX = modalForm.Left + modalForm.Width / 2;
            int modalY = modalForm.Top + modalForm.Height / 2;

            return new Point(baseX - modalX, baseY - modalY);
        }
    }
}
