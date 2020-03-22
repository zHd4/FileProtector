using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FileProtector
{
    public partial class FrmDialogBox : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public static string contents = string.Empty;

        public FrmDialogBox()
        {
            InitializeComponent();
            MSG.Text = contents;
            MSG.Location = new Point(ClientSize.Width / 2 - MSG.Size.Width / 2, MSG.Location.Y);
            OKBUTTON.Location = new Point(ClientSize.Width / 2 - OKBUTTON.Size.Width / 2, OKBUTTON.Location.Y);
        }

        private void FrmDialogBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void OKBUTTON_Click(object sender, EventArgs e)
        {
            contents = string.Empty;
            MSG.Text = contents;
            Close();
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            FrmDialogBox_MouseDown(sender, e);
        }
    }
}
