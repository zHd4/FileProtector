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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ProceedButton = new System.Windows.Forms.Button();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.EncryptRadioButton = new System.Windows.Forms.RadioButton();
            this.DecryptRadioButton = new System.Windows.Forms.RadioButton();
            this.Step1Label = new System.Windows.Forms.Label();
            this.Step1DescriptionLabel = new System.Windows.Forms.Label();
            this.Step2DescriptionLabel = new System.Windows.Forms.Label();
            this.Step2Label = new System.Windows.Forms.Label();
            this.Step3DescriptionLabel = new System.Windows.Forms.Label();
            this.Step3Label = new System.Windows.Forms.Label();
            this.PasswordTextBoxExternalContainer = new System.Windows.Forms.Panel();
            this.PasswordTextBoxInternalContainer = new System.Windows.Forms.Panel();
            this.ConfirmPasswordTextBoxExternalContainer = new System.Windows.Forms.Panel();
            this.ConfirmPasswordTextBoxInternalContainer = new System.Windows.Forms.Panel();
            this.WindowControlPanel = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.WindowNameLabel = new System.Windows.Forms.Label();
            this.AppVersionLabel = new System.Windows.Forms.Label();
            this.PasswordTextBoxExternalContainer.SuspendLayout();
            this.PasswordTextBoxInternalContainer.SuspendLayout();
            this.ConfirmPasswordTextBoxExternalContainer.SuspendLayout();
            this.ConfirmPasswordTextBoxInternalContainer.SuspendLayout();
            this.WindowControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProceedButton
            // 
            this.ProceedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(38)))), ((int)(((byte)(86)))));
            this.ProceedButton.FlatAppearance.BorderSize = 0;
            this.ProceedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProceedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProceedButton.Location = new System.Drawing.Point(182, 537);
            this.ProceedButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProceedButton.Name = "ProceedButton";
            this.ProceedButton.Size = new System.Drawing.Size(122, 37);
            this.ProceedButton.TabIndex = 11;
            this.ProceedButton.Text = "Encrypt!";
            this.ProceedButton.UseVisualStyleBackColor = false;
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(577, 285);
            this.ShowPasswordCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(134, 22);
            this.ShowPasswordCheckBox.TabIndex = 10;
            this.ShowPasswordCheckBox.Text = "Show password";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckedChanged);
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))));
            this.ConfirmPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConfirmPasswordTextBox.ForeColor = System.Drawing.Color.White;
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(2, 2);
            this.ConfirmPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(252, 17);
            this.ConfirmPasswordTextBox.TabIndex = 9;
            this.ConfirmPasswordTextBox.Text = "Confirm password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))));
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.ForeColor = System.Drawing.Color.White;
            this.PasswordTextBox.Location = new System.Drawing.Point(2, 2);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(252, 17);
            this.PasswordTextBox.TabIndex = 8;
            this.PasswordTextBox.Text = "Password";
            // 
            // BrowseButton
            // 
            this.BrowseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(38)))), ((int)(((byte)(86)))));
            this.BrowseButton.FlatAppearance.BorderSize = 0;
            this.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseButton.ForeColor = System.Drawing.Color.White;
            this.BrowseButton.Location = new System.Drawing.Point(87, 184);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(122, 37);
            this.BrowseButton.TabIndex = 7;
            this.BrowseButton.Text = "Browse...";
            this.BrowseButton.UseVisualStyleBackColor = false;
            // 
            // EncryptRadioButton
            // 
            this.EncryptRadioButton.AutoSize = true;
            this.EncryptRadioButton.Checked = true;
            this.EncryptRadioButton.Location = new System.Drawing.Point(161, 502);
            this.EncryptRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EncryptRadioButton.Name = "EncryptRadioButton";
            this.EncryptRadioButton.Size = new System.Drawing.Size(76, 22);
            this.EncryptRadioButton.TabIndex = 12;
            this.EncryptRadioButton.TabStop = true;
            this.EncryptRadioButton.Text = "Encrypt";
            this.EncryptRadioButton.UseVisualStyleBackColor = true;
            this.EncryptRadioButton.CheckedChanged += new System.EventHandler(this.EncryptRadioButton_CheckedChanged);
            // 
            // DecryptRadioButton
            // 
            this.DecryptRadioButton.AutoSize = true;
            this.DecryptRadioButton.Location = new System.Drawing.Point(254, 502);
            this.DecryptRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DecryptRadioButton.Name = "DecryptRadioButton";
            this.DecryptRadioButton.Size = new System.Drawing.Size(77, 22);
            this.DecryptRadioButton.TabIndex = 13;
            this.DecryptRadioButton.Text = "Decrypt";
            this.DecryptRadioButton.UseVisualStyleBackColor = true;
            this.DecryptRadioButton.CheckedChanged += new System.EventHandler(this.DecryptRadioButton_CheckedChanged);
            // 
            // Step1Label
            // 
            this.Step1Label.AutoSize = true;
            this.Step1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Step1Label.Location = new System.Drawing.Point(101, 116);
            this.Step1Label.Name = "Step1Label";
            this.Step1Label.Size = new System.Drawing.Size(92, 31);
            this.Step1Label.TabIndex = 15;
            this.Step1Label.Text = "Step 1";
            // 
            // Step1DescriptionLabel
            // 
            this.Step1DescriptionLabel.AutoSize = true;
            this.Step1DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Step1DescriptionLabel.Location = new System.Drawing.Point(71, 154);
            this.Step1DescriptionLabel.Name = "Step1DescriptionLabel";
            this.Step1DescriptionLabel.Size = new System.Drawing.Size(160, 17);
            this.Step1DescriptionLabel.TabIndex = 16;
            this.Step1DescriptionLabel.Text = "Select file(s) or folder(s)";
            // 
            // Step2DescriptionLabel
            // 
            this.Step2DescriptionLabel.AutoSize = true;
            this.Step2DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Step2DescriptionLabel.Location = new System.Drawing.Point(652, 202);
            this.Step2DescriptionLabel.Name = "Step2DescriptionLabel";
            this.Step2DescriptionLabel.Size = new System.Drawing.Size(106, 17);
            this.Step2DescriptionLabel.TabIndex = 18;
            this.Step2DescriptionLabel.Text = "Enter password";
            // 
            // Step2Label
            // 
            this.Step2Label.AutoSize = true;
            this.Step2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Step2Label.Location = new System.Drawing.Point(657, 164);
            this.Step2Label.Name = "Step2Label";
            this.Step2Label.Size = new System.Drawing.Size(92, 31);
            this.Step2Label.TabIndex = 17;
            this.Step2Label.Text = "Step 2";
            // 
            // Step3DescriptionLabel
            // 
            this.Step3DescriptionLabel.AutoSize = true;
            this.Step3DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Step3DescriptionLabel.Location = new System.Drawing.Point(174, 476);
            this.Step3DescriptionLabel.Name = "Step3DescriptionLabel";
            this.Step3DescriptionLabel.Size = new System.Drawing.Size(142, 17);
            this.Step3DescriptionLabel.TabIndex = 20;
            this.Step3DescriptionLabel.Text = "Select mode and run!";
            // 
            // Step3Label
            // 
            this.Step3Label.AutoSize = true;
            this.Step3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Step3Label.Location = new System.Drawing.Point(201, 441);
            this.Step3Label.Name = "Step3Label";
            this.Step3Label.Size = new System.Drawing.Size(92, 31);
            this.Step3Label.TabIndex = 19;
            this.Step3Label.Text = "Step 3";
            // 
            // PasswordTextBoxExternalContainer
            // 
            this.PasswordTextBoxExternalContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(38)))), ((int)(((byte)(86)))));
            this.PasswordTextBoxExternalContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PasswordTextBoxExternalContainer.Controls.Add(this.PasswordTextBoxInternalContainer);
            this.PasswordTextBoxExternalContainer.Location = new System.Drawing.Point(577, 227);
            this.PasswordTextBoxExternalContainer.Name = "PasswordTextBoxExternalContainer";
            this.PasswordTextBoxExternalContainer.Size = new System.Drawing.Size(258, 23);
            this.PasswordTextBoxExternalContainer.TabIndex = 21;
            // 
            // PasswordTextBoxInternalContainer
            // 
            this.PasswordTextBoxInternalContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))));
            this.PasswordTextBoxInternalContainer.Controls.Add(this.PasswordTextBox);
            this.PasswordTextBoxInternalContainer.Location = new System.Drawing.Point(1, 1);
            this.PasswordTextBoxInternalContainer.Name = "PasswordTextBoxInternalContainer";
            this.PasswordTextBoxInternalContainer.Size = new System.Drawing.Size(256, 21);
            this.PasswordTextBoxInternalContainer.TabIndex = 22;
            // 
            // ConfirmPasswordTextBoxExternalContainer
            // 
            this.ConfirmPasswordTextBoxExternalContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(38)))), ((int)(((byte)(86)))));
            this.ConfirmPasswordTextBoxExternalContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ConfirmPasswordTextBoxExternalContainer.Controls.Add(this.ConfirmPasswordTextBoxInternalContainer);
            this.ConfirmPasswordTextBoxExternalContainer.Location = new System.Drawing.Point(577, 256);
            this.ConfirmPasswordTextBoxExternalContainer.Name = "ConfirmPasswordTextBoxExternalContainer";
            this.ConfirmPasswordTextBoxExternalContainer.Size = new System.Drawing.Size(258, 23);
            this.ConfirmPasswordTextBoxExternalContainer.TabIndex = 22;
            // 
            // ConfirmPasswordTextBoxInternalContainer
            // 
            this.ConfirmPasswordTextBoxInternalContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))));
            this.ConfirmPasswordTextBoxInternalContainer.Controls.Add(this.ConfirmPasswordTextBox);
            this.ConfirmPasswordTextBoxInternalContainer.Location = new System.Drawing.Point(1, 1);
            this.ConfirmPasswordTextBoxInternalContainer.Name = "ConfirmPasswordTextBoxInternalContainer";
            this.ConfirmPasswordTextBoxInternalContainer.Size = new System.Drawing.Size(256, 21);
            this.ConfirmPasswordTextBoxInternalContainer.TabIndex = 22;
            // 
            // WindowControlPanel
            // 
            this.WindowControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(38)))), ((int)(((byte)(86)))));
            this.WindowControlPanel.Controls.Add(this.MinimizeButton);
            this.WindowControlPanel.Controls.Add(this.CloseButton);
            this.WindowControlPanel.Controls.Add(this.WindowNameLabel);
            this.WindowControlPanel.Location = new System.Drawing.Point(0, 0);
            this.WindowControlPanel.Name = "WindowControlPanel";
            this.WindowControlPanel.Size = new System.Drawing.Size(900, 21);
            this.WindowControlPanel.TabIndex = 23;
            this.WindowControlPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowControlPanel_MouseDown);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(38)))), ((int)(((byte)(86)))));
            this.MinimizeButton.BackgroundImage = global::FileProtector.Properties.Resources.minimize_button;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(858, 0);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(21, 21);
            this.MinimizeButton.TabIndex = 25;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(38)))), ((int)(((byte)(86)))));
            this.CloseButton.BackgroundImage = global::FileProtector.Properties.Resources.close_button;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(879, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(21, 21);
            this.CloseButton.TabIndex = 24;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // WindowNameLabel
            // 
            this.WindowNameLabel.AutoSize = true;
            this.WindowNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WindowNameLabel.Location = new System.Drawing.Point(3, 2);
            this.WindowNameLabel.Name = "WindowNameLabel";
            this.WindowNameLabel.Size = new System.Drawing.Size(88, 17);
            this.WindowNameLabel.TabIndex = 16;
            this.WindowNameLabel.Text = "FileProtector";
            this.WindowNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowNameLabel_MouseDown);
            // 
            // AppVersionLabel
            // 
            this.AppVersionLabel.AutoSize = true;
            this.AppVersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AppVersionLabel.Location = new System.Drawing.Point(871, 632);
            this.AppVersionLabel.Name = "AppVersionLabel";
            this.AppVersionLabel.Size = new System.Drawing.Size(31, 15);
            this.AppVersionLabel.TabIndex = 24;
            this.AppVersionLabel.Text = "vX.X";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))));
            this.BackgroundImage = global::FileProtector.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.AppVersionLabel);
            this.Controls.Add(this.WindowControlPanel);
            this.Controls.Add(this.ConfirmPasswordTextBoxExternalContainer);
            this.Controls.Add(this.PasswordTextBoxExternalContainer);
            this.Controls.Add(this.Step3DescriptionLabel);
            this.Controls.Add(this.ProceedButton);
            this.Controls.Add(this.DecryptRadioButton);
            this.Controls.Add(this.EncryptRadioButton);
            this.Controls.Add(this.Step3Label);
            this.Controls.Add(this.Step2DescriptionLabel);
            this.Controls.Add(this.Step2Label);
            this.Controls.Add(this.Step1DescriptionLabel);
            this.Controls.Add(this.ShowPasswordCheckBox);
            this.Controls.Add(this.Step1Label);
            this.Controls.Add(this.BrowseButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileProtector";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.PasswordTextBoxExternalContainer.ResumeLayout(false);
            this.PasswordTextBoxInternalContainer.ResumeLayout(false);
            this.PasswordTextBoxInternalContainer.PerformLayout();
            this.ConfirmPasswordTextBoxExternalContainer.ResumeLayout(false);
            this.ConfirmPasswordTextBoxInternalContainer.ResumeLayout(false);
            this.ConfirmPasswordTextBoxInternalContainer.PerformLayout();
            this.WindowControlPanel.ResumeLayout(false);
            this.WindowControlPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button ProceedButton;
        private CheckBox ShowPasswordCheckBox;
        private TextBox ConfirmPasswordTextBox;
        private TextBox PasswordTextBox;
        private Button BrowseButton;
        private RadioButton EncryptRadioButton;
        private RadioButton DecryptRadioButton;
        private Label Step1Label;
        private Label Step1DescriptionLabel;
        private Label Step2DescriptionLabel;
        private Label Step2Label;
        private Label Step3DescriptionLabel;
        private Label Step3Label;
        private Panel PasswordTextBoxExternalContainer;
        private Panel PasswordTextBoxInternalContainer;
        private Panel ConfirmPasswordTextBoxExternalContainer;
        private Panel ConfirmPasswordTextBoxInternalContainer;
        private Panel WindowControlPanel;
        private Label WindowNameLabel;
        private Button CloseButton;
        private Button MinimizeButton;
        private Label AppVersionLabel;
    }
}