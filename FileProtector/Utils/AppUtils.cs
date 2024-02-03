using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

namespace FileProtector.Utils
{
    public static class AppUtils
    {
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        public static string FetchVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo info = FileVersionInfo.GetVersionInfo(assembly.Location);

            return info.FileVersion ?? throw new NullReferenceException();
        }

        public static MouseEventHandler GetMoveWindowHandler(IntPtr handle)
        {
            return new MouseEventHandler((sender, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            });
        }
    }
}
