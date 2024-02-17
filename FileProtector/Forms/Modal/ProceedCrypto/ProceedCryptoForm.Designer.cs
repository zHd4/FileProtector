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
            this.HideFilesCheckBox = new System.Windows.Forms.CheckBox();
            this.CancelEncryptionButton = new System.Windows.Forms.Button();
            this.StartEncryptionButton = new System.Windows.Forms.Button();
            this.EncryptListView = new System.Windows.Forms.ListView();
            this.EncryptionWarningLabel = new System.Windows.Forms.Label();
            this.EncryptionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EncryptionPanel
            // 
            this.EncryptionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))));
            this.EncryptionPanel.Controls.Add(this.HideFilesCheckBox);
            this.EncryptionPanel.Controls.Add(this.CancelEncryptionButton);
            this.EncryptionPanel.Controls.Add(this.StartEncryptionButton);
            this.EncryptionPanel.Controls.Add(this.EncryptListView);
            this.EncryptionPanel.Controls.Add(this.EncryptionWarningLabel);
            this.EncryptionPanel.Location = new System.Drawing.Point(3, 20);
            this.EncryptionPanel.Name = "EncryptionPanel";
            this.EncryptionPanel.Size = new System.Drawing.Size(455, 277);
            this.EncryptionPanel.TabIndex = 0;
            // 
            // HideFilesCheckBox
            // 
            this.HideFilesCheckBox.AutoSize = true;
            this.HideFilesCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideFilesCheckBox.Location = new System.Drawing.Point(98, 185);
            this.HideFilesCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HideFilesCheckBox.Name = "HideFilesCheckBox";
            this.HideFilesCheckBox.Size = new System.Drawing.Size(84, 22);
            this.HideFilesCheckBox.TabIndex = 11;
            this.HideFilesCheckBox.Text = "Hide files";
            this.HideFilesCheckBox.UseVisualStyleBackColor = true;
            // 
            // CancelEncryptionButton
            // 
            this.CancelEncryptionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(38)))), ((int)(((byte)(86)))));
            this.CancelEncryptionButton.FlatAppearance.BorderSize = 0;
            this.CancelEncryptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelEncryptionButton.ForeColor = System.Drawing.Color.White;
            this.CancelEncryptionButton.Location = new System.Drawing.Point(234, 212);
            this.CancelEncryptionButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CancelEncryptionButton.Name = "CancelEncryptionButton";
            this.CancelEncryptionButton.Size = new System.Drawing.Size(122, 38);
            this.CancelEncryptionButton.TabIndex = 10;
            this.CancelEncryptionButton.Text = "Cancel";
            this.CancelEncryptionButton.UseVisualStyleBackColor = false;
            this.CancelEncryptionButton.Click += new System.EventHandler(this.CancelEncryptionButton_Click);
            // 
            // StartEncryptionButton
            // 
            this.StartEncryptionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(38)))), ((int)(((byte)(86)))));
            this.StartEncryptionButton.FlatAppearance.BorderSize = 0;
            this.StartEncryptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartEncryptionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.StartEncryptionButton.Location = new System.Drawing.Point(98, 212);
            this.StartEncryptionButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartEncryptionButton.Name = "StartEncryptionButton";
            this.StartEncryptionButton.Size = new System.Drawing.Size(122, 38);
            this.StartEncryptionButton.TabIndex = 9;
            this.StartEncryptionButton.Text = "Continue";
            this.StartEncryptionButton.UseVisualStyleBackColor = false;
            // 
            // EncryptListView
            // 
            this.EncryptListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(38)))), ((int)(((byte)(86)))));
            this.EncryptListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EncryptListView.ForeColor = System.Drawing.Color.White;
            this.EncryptListView.Location = new System.Drawing.Point(98, 66);
            this.EncryptListView.Name = "EncryptListView";
            this.EncryptListView.Size = new System.Drawing.Size(258, 114);
            this.EncryptListView.TabIndex = 1;
            this.EncryptListView.UseCompatibleStateImageBehavior = false;
            // 
            // EncryptionWarningLabel
            // 
            this.EncryptionWarningLabel.AutoSize = true;
            this.EncryptionWarningLabel.Location = new System.Drawing.Point(98, 31);
            this.EncryptionWarningLabel.Name = "EncryptionWarningLabel";
            this.EncryptionWarningLabel.Size = new System.Drawing.Size(258, 18);
            this.EncryptionWarningLabel.TabIndex = 0;
            this.EncryptionWarningLabel.Text = "This action will encrypt following paths";
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
        private Label EncryptionWarningLabel;
        private ListView EncryptListView;
        private Button CancelEncryptionButton;
        private Button StartEncryptionButton;
        private CheckBox HideFilesCheckBox;
    }
}