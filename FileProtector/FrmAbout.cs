using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace FileProtector
{
    public partial class FrmAbout : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public FrmAbout()
        {
            InitializeComponent();

            version.Text = Program.version;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void tglink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://t.me/DarkMorre");
        }

        private void FrmAbout_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            FrmAbout_MouseDown(sender, e);
        }
    }
}
