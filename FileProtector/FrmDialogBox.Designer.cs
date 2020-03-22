namespace FileProtector
{
    partial class FrmDialogBox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.OKBUTTON = new System.Windows.Forms.Button();
            this.MSG = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.OKBUTTON);
            this.panel1.Controls.Add(this.MSG);
            this.panel1.Location = new System.Drawing.Point(4, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 145);
            this.panel1.TabIndex = 0;
            // 
            // OKBUTTON
            // 
            this.OKBUTTON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.OKBUTTON.FlatAppearance.BorderSize = 0;
            this.OKBUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKBUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.OKBUTTON.Location = new System.Drawing.Point(191, 98);
            this.OKBUTTON.Name = "OKBUTTON";
            this.OKBUTTON.Size = new System.Drawing.Size(132, 27);
            this.OKBUTTON.TabIndex = 6;
            this.OKBUTTON.Text = "OK";
            this.OKBUTTON.UseVisualStyleBackColor = false;
            this.OKBUTTON.Click += new System.EventHandler(this.OKBUTTON_Click);
            // 
            // MSG
            // 
            this.MSG.AutoSize = true;
            this.MSG.Location = new System.Drawing.Point(95, 52);
            this.MSG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MSG.Name = "MSG";
            this.MSG.Size = new System.Drawing.Size(46, 17);
            this.MSG.TabIndex = 0;
            this.MSG.Text = "label1";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(522, 168);
            this.mainPanel.TabIndex = 7;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            // 
            // FrmDialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(523, 169);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDialogBox";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmDialogBox_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label MSG;
        private System.Windows.Forms.Button OKBUTTON;
        private System.Windows.Forms.Panel mainPanel;
    }
}