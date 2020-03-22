namespace FileProtector
{
    partial class FrmSettings
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
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hideFiles = new System.Windows.Forms.CheckBox();
            this.protectedEncryption = new System.Windows.Forms.CheckBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(4, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Настройки";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label4_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.hideFiles);
            this.panel1.Controls.Add(this.protectedEncryption);
            this.panel1.Location = new System.Drawing.Point(4, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 90);
            this.panel1.TabIndex = 32;
            // 
            // hideFiles
            // 
            this.hideFiles.AutoSize = true;
            this.hideFiles.Checked = true;
            this.hideFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hideFiles.Location = new System.Drawing.Point(12, 44);
            this.hideFiles.Margin = new System.Windows.Forms.Padding(4);
            this.hideFiles.Name = "hideFiles";
            this.hideFiles.Size = new System.Drawing.Size(256, 21);
            this.hideFiles.TabIndex = 1;
            this.hideFiles.Text = "Скрыть файлы после шифрования";
            this.hideFiles.UseVisualStyleBackColor = true;
            this.hideFiles.CheckedChanged += new System.EventHandler(this.hideFiles_CheckedChanged);
            // 
            // protectedEncryption
            // 
            this.protectedEncryption.AutoSize = true;
            this.protectedEncryption.Checked = true;
            this.protectedEncryption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.protectedEncryption.Location = new System.Drawing.Point(12, 14);
            this.protectedEncryption.Margin = new System.Windows.Forms.Padding(4);
            this.protectedEncryption.Name = "protectedEncryption";
            this.protectedEncryption.Size = new System.Drawing.Size(312, 21);
            this.protectedEncryption.TabIndex = 0;
            this.protectedEncryption.Text = "Делать резервные копии при шифровании";
            this.protectedEncryption.UseVisualStyleBackColor = true;
            this.protectedEncryption.CheckedChanged += new System.EventHandler(this.protectedEncryption_CheckedChanged);
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.buttonExit.ForeColor = System.Drawing.Color.Red;
            this.buttonExit.Location = new System.Drawing.Point(379, 0);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(32, 29);
            this.buttonExit.TabIndex = 33;
            this.buttonExit.Text = "×";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(413, 126);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmSettings_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox hideFiles;
        private System.Windows.Forms.CheckBox protectedEncryption;
        private System.Windows.Forms.Button buttonExit;
    }
}