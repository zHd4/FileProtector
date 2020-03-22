using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace FileProtector
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
            version.Text += Program.version.ToString();
        }

        private void StartScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        public void StartProgram()
        {
            FrmEncrypt frmEncrypt = new FrmEncrypt();
            frmEncrypt.Show();

            Hide();
        }

        private void waiting_Tick(object sender, EventArgs e)
        {
            waiting.Stop();
            StartProgram();
        }
    }
}
