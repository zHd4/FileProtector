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
            this.EncryptionPanel = new System.Windows.Forms.Panel();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.EncryptionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EncryptionPanel
            // 
            this.EncryptionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))));
            this.EncryptionPanel.Controls.Add(this.ShowPasswordCheckBox);
            this.EncryptionPanel.Controls.Add(this.button1);
            this.EncryptionPanel.Controls.Add(this.OkButton);
            this.EncryptionPanel.Controls.Add(this.listView1);
            this.EncryptionPanel.Controls.Add(this.label1);
            this.EncryptionPanel.Location = new System.Drawing.Point(3, 20);
            this.EncryptionPanel.Name = "EncryptionPanel";
            this.EncryptionPanel.Size = new System.Drawing.Size(455, 277);
            this.EncryptionPanel.TabIndex = 0;
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(98, 185);
            this.ShowPasswordCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(84, 22);
            this.ShowPasswordCheckBox.TabIndex = 11;
            this.ShowPasswordCheckBox.Text = "Hide files";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(38)))), ((int)(((byte)(86)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(234, 212);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(38)))), ((int)(((byte)(86)))));
            this.OkButton.FlatAppearance.BorderSize = 0;
            this.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.OkButton.Location = new System.Drawing.Point(98, 212);
            this.OkButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(122, 38);
            this.OkButton.TabIndex = 9;
            this.OkButton.Text = "Continue";
            this.OkButton.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(38)))), ((int)(((byte)(86)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.Location = new System.Drawing.Point(98, 66);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(258, 114);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "This action will encrypt following paths";
            // 
            // ProceedCryptoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(1234, 751);
            this.Controls.Add(this.EncryptionPanel);
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
            this.EncryptionPanel.ResumeLayout(false);
            this.EncryptionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel EncryptionPanel;
        private Label label1;
        private ListView listView1;
        private Button button1;
        private Button OkButton;
        private CheckBox ShowPasswordCheckBox;
    }
}