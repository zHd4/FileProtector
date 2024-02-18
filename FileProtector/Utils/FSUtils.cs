namespace FileProtector.Utils
{
    public class FSUtils
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

        public static List<string> FindAllFiles(List<string> paths)
        {
            List<string> filesPaths = new List<string>();


            paths.ForEach(path =>
            {
                if (Directory.Exists(path))
                {
                    string[] foundFiles = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
                    filesPaths.AddRange(foundFiles.ToList());
                }
                else if (File.Exists(path))
                {
                    filesPaths.Add(path);
                }
            });

            return filesPaths;
        }
    }
}
