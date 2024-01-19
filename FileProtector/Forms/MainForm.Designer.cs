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
            this.AppTabsControl = new System.Windows.Forms.TabControl();
            this.EncryptionTabPage = new System.Windows.Forms.TabPage();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.ShowEncryptionPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.ConfirmEncryptionPasswordTextBox = new System.Windows.Forms.TextBox();
            this.EncryptionPasswordTextBox = new System.Windows.Forms.TextBox();
            this.EncryptionBrowseButton = new System.Windows.Forms.Button();
            this.EncryptionPathTextBox = new System.Windows.Forms.TextBox();
            this.DecryptionTabPage = new System.Windows.Forms.TabPage();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.ShowDecryptionPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.DecryptionPasswordTextBox = new System.Windows.Forms.TextBox();
            this.DecryptionBrowseButton = new System.Windows.Forms.Button();
            this.DecryptionPathTextBox = new System.Windows.Forms.TextBox();
            this.MainProgressBar = new System.Windows.Forms.ProgressBar();
            this.MainStatusLabel = new System.Windows.Forms.Label();
            this.AppTabsControl.SuspendLayout();
            this.EncryptionTabPage.SuspendLayout();
            this.DecryptionTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppTabsControl
            // 
            this.AppTabsControl.Controls.Add(this.EncryptionTabPage);
            this.AppTabsControl.Controls.Add(this.DecryptionTabPage);
            this.AppTabsControl.Location = new System.Drawing.Point(0, 0);
            this.AppTabsControl.Name = "AppTabsControl";
            this.AppTabsControl.SelectedIndex = 0;
            this.AppTabsControl.Size = new System.Drawing.Size(352, 179);
            this.AppTabsControl.TabIndex = 0;
            // 
            // EncryptionTabPage
            // 
            this.EncryptionTabPage.Controls.Add(this.EncryptButton);
            this.EncryptionTabPage.Controls.Add(this.ShowEncryptionPasswordCheckBox);
            this.EncryptionTabPage.Controls.Add(this.ConfirmEncryptionPasswordTextBox);
            this.EncryptionTabPage.Controls.Add(this.EncryptionPasswordTextBox);
            this.EncryptionTabPage.Controls.Add(this.EncryptionBrowseButton);
            this.EncryptionTabPage.Controls.Add(this.EncryptionPathTextBox);
            this.EncryptionTabPage.Location = new System.Drawing.Point(4, 24);
            this.EncryptionTabPage.Name = "EncryptionTabPage";
            this.EncryptionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EncryptionTabPage.Size = new System.Drawing.Size(344, 151);
            this.EncryptionTabPage.TabIndex = 0;
            this.EncryptionTabPage.Text = "Encrypt";
            this.EncryptionTabPage.UseVisualStyleBackColor = true;
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(8, 118);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(108, 27);
            this.EncryptButton.TabIndex = 5;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            // 
            // ShowEncryptionPasswordCheckBox
            // 
            this.ShowEncryptionPasswordCheckBox.AutoSize = true;
            this.ShowEncryptionPasswordCheckBox.Location = new System.Drawing.Point(8, 93);
            this.ShowEncryptionPasswordCheckBox.Name = "ShowEncryptionPasswordCheckBox";
            this.ShowEncryptionPasswordCheckBox.Size = new System.Drawing.Size(108, 19);
            this.ShowEncryptionPasswordCheckBox.TabIndex = 4;
            this.ShowEncryptionPasswordCheckBox.Text = "Show password";
            this.ShowEncryptionPasswordCheckBox.UseVisualStyleBackColor = true;
            // 
            // ConfirmEncryptionPasswordTextBox
            // 
            this.ConfirmEncryptionPasswordTextBox.Location = new System.Drawing.Point(8, 64);
            this.ConfirmEncryptionPasswordTextBox.Name = "ConfirmEncryptionPasswordTextBox";
            this.ConfirmEncryptionPasswordTextBox.Size = new System.Drawing.Size(251, 23);
            this.ConfirmEncryptionPasswordTextBox.TabIndex = 3;
            this.ConfirmEncryptionPasswordTextBox.Text = "Confirm password";
            // 
            // EncryptionPasswordTextBox
            // 
            this.EncryptionPasswordTextBox.Location = new System.Drawing.Point(8, 35);
            this.EncryptionPasswordTextBox.Name = "EncryptionPasswordTextBox";
            this.EncryptionPasswordTextBox.Size = new System.Drawing.Size(251, 23);
            this.EncryptionPasswordTextBox.TabIndex = 2;
            this.EncryptionPasswordTextBox.Text = "Password";
            // 
            // EncryptionBrowseButton
            // 
            this.EncryptionBrowseButton.Location = new System.Drawing.Point(265, 6);
            this.EncryptionBrowseButton.Name = "EncryptionBrowseButton";
            this.EncryptionBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.EncryptionBrowseButton.TabIndex = 1;
            this.EncryptionBrowseButton.Text = "Browse...";
            this.EncryptionBrowseButton.UseVisualStyleBackColor = true;
            // 
            // EncryptionPathTextBox
            // 
            this.EncryptionPathTextBox.Location = new System.Drawing.Point(8, 6);
            this.EncryptionPathTextBox.Name = "EncryptionPathTextBox";
            this.EncryptionPathTextBox.Size = new System.Drawing.Size(251, 23);
            this.EncryptionPathTextBox.TabIndex = 0;
            this.EncryptionPathTextBox.Text = "Path";
            // 
            // DecryptionTabPage
            // 
            this.DecryptionTabPage.Controls.Add(this.DecryptButton);
            this.DecryptionTabPage.Controls.Add(this.ShowDecryptionPasswordCheckBox);
            this.DecryptionTabPage.Controls.Add(this.DecryptionPasswordTextBox);
            this.DecryptionTabPage.Controls.Add(this.DecryptionBrowseButton);
            this.DecryptionTabPage.Controls.Add(this.DecryptionPathTextBox);
            this.DecryptionTabPage.Location = new System.Drawing.Point(4, 24);
            this.DecryptionTabPage.Name = "DecryptionTabPage";
            this.DecryptionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DecryptionTabPage.Size = new System.Drawing.Size(344, 151);
            this.DecryptionTabPage.TabIndex = 1;
            this.DecryptionTabPage.Text = "Decrypt";
            this.DecryptionTabPage.UseVisualStyleBackColor = true;
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(6, 89);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(108, 27);
            this.DecryptButton.TabIndex = 4;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            // 
            // ShowDecryptionPasswordCheckBox
            // 
            this.ShowDecryptionPasswordCheckBox.AutoSize = true;
            this.ShowDecryptionPasswordCheckBox.Location = new System.Drawing.Point(8, 65);
            this.ShowDecryptionPasswordCheckBox.Name = "ShowDecryptionPasswordCheckBox";
            this.ShowDecryptionPasswordCheckBox.Size = new System.Drawing.Size(108, 19);
            this.ShowDecryptionPasswordCheckBox.TabIndex = 3;
            this.ShowDecryptionPasswordCheckBox.Text = "Show password";
            this.ShowDecryptionPasswordCheckBox.UseVisualStyleBackColor = true;
            // 
            // DecryptionPasswordTextBox
            // 
            this.DecryptionPasswordTextBox.Location = new System.Drawing.Point(8, 35);
            this.DecryptionPasswordTextBox.Name = "DecryptionPasswordTextBox";
            this.DecryptionPasswordTextBox.Size = new System.Drawing.Size(251, 23);
            this.DecryptionPasswordTextBox.TabIndex = 2;
            this.DecryptionPasswordTextBox.Text = "Password";
            // 
            // DecryptionBrowseButton
            // 
            this.DecryptionBrowseButton.Location = new System.Drawing.Point(265, 6);
            this.DecryptionBrowseButton.Name = "DecryptionBrowseButton";
            this.DecryptionBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.DecryptionBrowseButton.TabIndex = 1;
            this.DecryptionBrowseButton.Text = "Browse...";
            this.DecryptionBrowseButton.UseVisualStyleBackColor = true;
            // 
            // DecryptionPathTextBox
            // 
            this.DecryptionPathTextBox.Location = new System.Drawing.Point(8, 6);
            this.DecryptionPathTextBox.Name = "DecryptionPathTextBox";
            this.DecryptionPathTextBox.Size = new System.Drawing.Size(251, 23);
            this.DecryptionPathTextBox.TabIndex = 0;
            this.DecryptionPathTextBox.Text = "Path";
            // 
            // MainProgressBar
            // 
            this.MainProgressBar.Location = new System.Drawing.Point(2, 181);
            this.MainProgressBar.Name = "MainProgressBar";
            this.MainProgressBar.Size = new System.Drawing.Size(350, 23);
            this.MainProgressBar.TabIndex = 1;
            // 
            // MainStatusLabel
            // 
            this.MainStatusLabel.AutoSize = true;
            this.MainStatusLabel.Location = new System.Drawing.Point(2, 207);
            this.MainStatusLabel.Name = "MainStatusLabel";
            this.MainStatusLabel.Size = new System.Drawing.Size(42, 15);
            this.MainStatusLabel.TabIndex = 2;
            this.MainStatusLabel.Text = "Status:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 229);
            this.Controls.Add(this.MainStatusLabel);
            this.Controls.Add(this.MainProgressBar);
            this.Controls.Add(this.AppTabsControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileProtector";
            this.AppTabsControl.ResumeLayout(false);
            this.EncryptionTabPage.ResumeLayout(false);
            this.EncryptionTabPage.PerformLayout();
            this.DecryptionTabPage.ResumeLayout(false);
            this.DecryptionTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl AppTabsControl;
        private TabPage EncryptionTabPage;
        private TabPage DecryptionTabPage;
        private Button EncryptButton;
        private CheckBox ShowEncryptionPasswordCheckBox;
        private TextBox ConfirmEncryptionPasswordTextBox;
        private TextBox EncryptionPasswordTextBox;
        private Button EncryptionBrowseButton;
        private TextBox EncryptionPathTextBox;
        private ProgressBar MainProgressBar;
        private Label MainStatusLabel;
        private TextBox DecryptionPasswordTextBox;
        private Button DecryptionBrowseButton;
        private TextBox DecryptionPathTextBox;
        private Button DecryptButton;
        private CheckBox ShowDecryptionPasswordCheckBox;
    }
}