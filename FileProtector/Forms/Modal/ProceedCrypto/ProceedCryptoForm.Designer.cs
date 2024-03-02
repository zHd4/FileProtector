namespace FileProtector.Forms.Modal.ProceedCrypto
{
    partial class ProceedCryptoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.MainProgressBar = new System.Windows.Forms.ProgressBar();
            this.FormUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))));
            this.MainPanel.Controls.Add(this.StatusLabel);
            this.MainPanel.Controls.Add(this.NameLabel);
            this.MainPanel.Controls.Add(this.MainProgressBar);
            this.MainPanel.Location = new System.Drawing.Point(3, 20);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(446, 100);
            this.MainPanel.TabIndex = 0;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusLabel.Location = new System.Drawing.Point(9, 39);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(39, 15);
            this.StatusLabel.TabIndex = 2;
            this.StatusLabel.Text = "status";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(4, 4);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(144, 29);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Encrypting...";
            // 
            // MainProgressBar
            // 
            this.MainProgressBar.Location = new System.Drawing.Point(5, 73);
            this.MainProgressBar.Name = "MainProgressBar";
            this.MainProgressBar.Size = new System.Drawing.Size(437, 23);
            this.MainProgressBar.TabIndex = 0;
            // 
            // FormUpdateTimer
            // 
            this.FormUpdateTimer.Interval = 1;
            this.FormUpdateTimer.Tick += new System.EventHandler(this.OnFormUpdateTimerTick);
            // 
            // ProceedCryptoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(452, 123);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProceedCryptoForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MainPanel;
        private Label StatusLabel;
        private Label NameLabel;
        private ProgressBar MainProgressBar;
        private System.Windows.Forms.Timer FormUpdateTimer;
    }
}