using System.Diagnostics;
using System.Reflection;

namespace FileProtector
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Text += " " + FetchVersion();
            MaximizeBox = false;
        }

        private string FetchVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo info = FileVersionInfo.GetVersionInfo(assembly.Location);

            return info.FileVersion ?? throw new NullReferenceException();
        }
    }
}