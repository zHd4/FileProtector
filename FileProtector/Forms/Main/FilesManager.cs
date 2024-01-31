namespace FileProtector.Forms.Main
{
    internal class FilesManager
    {
        public static List<string> OpenSelectFilesDialog()
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Multiselect = true;
            dialog.ShowDialog();

            return dialog.FileNames.ToList();
        }

        public static string OpenSelectFolderDialog()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            dialog.ShowDialog();
            return dialog.SelectedPath;
        }
    }
}
