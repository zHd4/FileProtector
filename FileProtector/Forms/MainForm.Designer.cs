namespace FileProtector
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainProgressBar = new System.Windows.Forms.ProgressBar();
            this.MainStatusLabel = new System.Windows.Forms.Label();
            this.ProceedButton = new System.Windows.Forms.Button();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.EncryptRadioButton = new System.Windows.Forms.RadioButton();
            this.DecryptRadioButton = new System.Windows.Forms.RadioButton();
            this.OperationsFormPanel = new System.Windows.Forms.Panel();
            this.OperationsFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainProgressBar
            // 
            this.MainProgressBar.Location = new System.Drawing.Point(2, 176);
            this.MainProgressBar.Name = "MainProgressBar";
            this.MainProgressBar.Size = new System.Drawing.Size(338, 23);
            this.MainProgressBar.TabIndex = 1;
            // 
            // MainStatusLabel
            // 
            this.MainStatusLabel.AutoSize = true;
            this.MainStatusLabel.Location = new System.Drawing.Point(2, 202);
            this.MainStatusLabel.Name = "MainStatusLabel";
            this.MainStatusLabel.Size = new System.Drawing.Size(42, 15);
            this.MainStatusLabel.TabIndex = 2;
            this.MainStatusLabel.Text = "Status:";
            // 
            // ProceedButton
            // 
            this.ProceedButton.Location = new System.Drawing.Point(3, 140);
            this.ProceedButton.Name = "ProceedButton";
            this.ProceedButton.Size = new System.Drawing.Size(108, 27);
            this.ProceedButton.TabIndex = 11;
            this.ProceedButton.Text = "Encrypt";
            this.ProceedButton.UseVisualStyleBackColor = true;
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(3, 90);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(108, 19);
            this.ShowPasswordCheckBox.TabIndex = 10;
            this.ShowPasswordCheckBox.Text = "Show password";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckedChanged);
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(3, 61);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(251, 23);
            this.ConfirmPasswordTextBox.TabIndex = 9;
            this.ConfirmPasswordTextBox.Text = "Confirm password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(3, 32);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(251, 23);
            this.PasswordTextBox.TabIndex = 8;
            this.PasswordTextBox.Text = "Password";
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(260, 3);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 7;
            this.BrowseButton.Text = "Browse...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            // 
            // PathTextBox
            // 
            this.PathTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PathTextBox.Location = new System.Drawing.Point(3, 3);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(251, 23);
            this.PathTextBox.TabIndex = 6;
            this.PathTextBox.Text = "Path";
            // 
            // EncryptRadioButton
            // 
            this.EncryptRadioButton.AutoSize = true;
            this.EncryptRadioButton.Checked = true;
            this.EncryptRadioButton.Location = new System.Drawing.Point(3, 115);
            this.EncryptRadioButton.Name = "EncryptRadioButton";
            this.EncryptRadioButton.Size = new System.Drawing.Size(65, 19);
            this.EncryptRadioButton.TabIndex = 12;
            this.EncryptRadioButton.TabStop = true;
            this.EncryptRadioButton.Text = "Encrypt";
            this.EncryptRadioButton.UseVisualStyleBackColor = true;
            // 
            // DecryptRadioButton
            // 
            this.DecryptRadioButton.AutoSize = true;
            this.DecryptRadioButton.Location = new System.Drawing.Point(74, 115);
            this.DecryptRadioButton.Name = "DecryptRadioButton";
            this.DecryptRadioButton.Size = new System.Drawing.Size(66, 19);
            this.DecryptRadioButton.TabIndex = 13;
            this.DecryptRadioButton.Text = "Decrypt";
            this.DecryptRadioButton.UseVisualStyleBackColor = true;
            // 
            // OperationsFormPanel
            // 
            this.OperationsFormPanel.Controls.Add(this.PathTextBox);
            this.OperationsFormPanel.Controls.Add(this.DecryptRadioButton);
            this.OperationsFormPanel.Controls.Add(this.BrowseButton);
            this.OperationsFormPanel.Controls.Add(this.EncryptRadioButton);
            this.OperationsFormPanel.Controls.Add(this.PasswordTextBox);
            this.OperationsFormPanel.Controls.Add(this.ProceedButton);
            this.OperationsFormPanel.Controls.Add(this.ConfirmPasswordTextBox);
            this.OperationsFormPanel.Controls.Add(this.ShowPasswordCheckBox);
            this.OperationsFormPanel.Location = new System.Drawing.Point(2, 2);
            this.OperationsFormPanel.Name = "OperationsFormPanel";
            this.OperationsFormPanel.Size = new System.Drawing.Size(338, 171);
            this.OperationsFormPanel.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 218);
            this.Controls.Add(this.OperationsFormPanel);
            this.Controls.Add(this.MainStatusLabel);
            this.Controls.Add(this.MainProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileProtector";
            this.OperationsFormPanel.ResumeLayout(false);
            this.OperationsFormPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ProgressBar MainProgressBar;
        private Label MainStatusLabel;
        private Button ProceedButton;
        private CheckBox ShowPasswordCheckBox;
        private TextBox ConfirmPasswordTextBox;
        private TextBox PasswordTextBox;
        private Button BrowseButton;
        private TextBox PathTextBox;
        private RadioButton EncryptRadioButton;
        private RadioButton DecryptRadioButton;
        private Panel OperationsFormPanel;
    }
}