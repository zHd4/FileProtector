using System.Diagnostics;
using System.Reflection;

namespace FileProtector.Utils
{
    public static class AppUtils
    {
        public static string FetchVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo info = FileVersionInfo.GetVersionInfo(assembly.Location);

            return info.FileVersion ?? throw new NullReferenceException();
        }
    }
}
