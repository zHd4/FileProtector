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
            ProceedButton = new Button();
            ShowPasswordCheckBox = new CheckBox();
            ConfirmPasswordTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            BrowseButton = new Button();
            EncryptRadioButton = new RadioButton();
            DecryptRadioButton = new RadioButton();
            Step1Label = new Label();
            Step1DescriptionLabel = new Label();
            Step2DescriptionLabel = new Label();
            Step2Label = new Label();
            Step3DescriptionLabel = new Label();
            Step3Label = new Label();
            PasswordTextBoxExternalContainer = new Panel();
            PasswordTextBoxInternalContainer = new Panel();
            ConfirmPasswordTextBoxExternalContainer = new Panel();
            ConfirmPasswordTextBoxInternalContainer = new Panel();
            WindowControlPanel = new Panel();
            IconPictureBox = new PictureBox();
            MinimizeButton = new Button();
            CloseButton = new Button();
            WindowNameLabel = new Label();
            AppVersionLabel = new Label();
            FolderCheckBox = new CheckBox();
            PasswordTextBoxExternalContainer.SuspendLayout();
            PasswordTextBoxInternalContainer.SuspendLayout();
            ConfirmPasswordTextBoxExternalContainer.SuspendLayout();
            ConfirmPasswordTextBoxInternalContainer.SuspendLayout();
            WindowControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IconPictureBox).BeginInit();
            SuspendLayout();
            // 
            // ProceedButton
            // 
            ProceedButton.BackColor = Color.FromArgb(43, 38, 86);
            ProceedButton.FlatAppearance.BorderSize = 0;
            ProceedButton.FlatStyle = FlatStyle.Flat;
            ProceedButton.Font = new Font("Microsoft Sans Serif", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            ProceedButton.Location = new Point(182, 537);
            ProceedButton.Margin = new Padding(3, 4, 3, 4);
            ProceedButton.Name = "ProceedButton";
            ProceedButton.Size = new Size(122, 37);
            ProceedButton.TabIndex = 11;
            ProceedButton.Text = "Encrypt!";
            ProceedButton.UseVisualStyleBackColor = false;
            ProceedButton.Click += OnProceedButtonClick;
            // 
            // ShowPasswordCheckBox
            // 
            ShowPasswordCheckBox.AutoSize = true;
            ShowPasswordCheckBox.Location = new Point(577, 285);
            ShowPasswordCheckBox.Margin = new Padding(3, 4, 3, 4);
            ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            ShowPasswordCheckBox.Size = new Size(134, 22);
            ShowPasswordCheckBox.TabIndex = 10;
            ShowPasswordCheckBox.Text = "Show password";
            ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            ShowPasswordCheckBox.CheckedChanged += ShowPasswordCheckedChanged;
            // 
            // ConfirmPasswordTextBox
            // 
            ConfirmPasswordTextBox.BackColor = Color.FromArgb(18, 16, 41);
            ConfirmPasswordTextBox.BorderStyle = BorderStyle.None;
            ConfirmPasswordTextBox.ForeColor = Color.White;
            ConfirmPasswordTextBox.Location = new Point(2, 2);
            ConfirmPasswordTextBox.Margin = new Padding(3, 4, 3, 4);
            ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            ConfirmPasswordTextBox.Size = new Size(252, 17);
            ConfirmPasswordTextBox.TabIndex = 9;
            ConfirmPasswordTextBox.Text = "Confirm password";
            ConfirmPasswordTextBox.Enter += OnConfirmPasswordTextBoxEnter;
            ConfirmPasswordTextBox.Leave += OnConfirmPasswordTextBoxLeave;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = Color.FromArgb(18, 16, 41);
            PasswordTextBox.BorderStyle = BorderStyle.None;
            PasswordTextBox.ForeColor = Color.White;
            PasswordTextBox.Location = new Point(2, 2);
            PasswordTextBox.Margin = new Padding(3, 4, 3, 4);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(252, 17);
            PasswordTextBox.TabIndex = 8;
            PasswordTextBox.Text = "Password";
            PasswordTextBox.Enter += OnPasswordTextBoxEnter;
            PasswordTextBox.Leave += OnPasswordTextBoxLeave;
            // 
            // BrowseButton
            // 
            BrowseButton.BackColor = Color.FromArgb(43, 38, 86);
            BrowseButton.FlatAppearance.BorderSize = 0;
            BrowseButton.FlatStyle = FlatStyle.Flat;
            BrowseButton.ForeColor = Color.White;
            BrowseButton.Location = new Point(87, 173);
            BrowseButton.Margin = new Padding(3, 4, 3, 4);
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Size = new Size(122, 37);
            BrowseButton.TabIndex = 7;
            BrowseButton.Text = "Browse...";
            BrowseButton.UseVisualStyleBackColor = false;
            BrowseButton.Click += OnBrowseButtonClick;
            // 
            // EncryptRadioButton
            // 
            EncryptRadioButton.AutoSize = true;
            EncryptRadioButton.Checked = true;
            EncryptRadioButton.Location = new Point(165, 502);
            EncryptRadioButton.Margin = new Padding(3, 4, 3, 4);
            EncryptRadioButton.Name = "EncryptRadioButton";
            EncryptRadioButton.Size = new Size(76, 22);
            EncryptRadioButton.TabIndex = 12;
            EncryptRadioButton.TabStop = true;
            EncryptRadioButton.Text = "Encrypt";
            EncryptRadioButton.UseVisualStyleBackColor = true;
            EncryptRadioButton.CheckedChanged += OnEncryptRadioCheckedChanged;
            // 
            // DecryptRadioButton
            // 
            DecryptRadioButton.AutoSize = true;
            DecryptRadioButton.Location = new Point(247, 502);
            DecryptRadioButton.Margin = new Padding(3, 4, 3, 4);
            DecryptRadioButton.Name = "DecryptRadioButton";
            DecryptRadioButton.Size = new Size(77, 22);
            DecryptRadioButton.TabIndex = 13;
            DecryptRadioButton.Text = "Decrypt";
            DecryptRadioButton.UseVisualStyleBackColor = true;
            DecryptRadioButton.CheckedChanged += OnDecryptRadioCheckedChanged;
            // 
            // Step1Label
            // 
            Step1Label.AutoSize = true;
            Step1Label.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Step1Label.Location = new Point(101, 108);
            Step1Label.Name = "Step1Label";
            Step1Label.Size = new Size(92, 31);
            Step1Label.TabIndex = 15;
            Step1Label.Text = "Step 1";
            // 
            // Step1DescriptionLabel
            // 
            Step1DescriptionLabel.AutoSize = true;
            Step1DescriptionLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Step1DescriptionLabel.Location = new Point(77, 146);
            Step1DescriptionLabel.Name = "Step1DescriptionLabel";
            Step1DescriptionLabel.Size = new Size(143, 17);
            Step1DescriptionLabel.TabIndex = 16;
            Step1DescriptionLabel.Text = "Select file(s) or folder";
            // 
            // Step2DescriptionLabel
            // 
            Step2DescriptionLabel.AutoSize = true;
            Step2DescriptionLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Step2DescriptionLabel.Location = new Point(652, 202);
            Step2DescriptionLabel.Name = "Step2DescriptionLabel";
            Step2DescriptionLabel.Size = new Size(106, 17);
            Step2DescriptionLabel.TabIndex = 18;
            Step2DescriptionLabel.Text = "Enter password";
            // 
            // Step2Label
            // 
            Step2Label.AutoSize = true;
            Step2Label.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Step2Label.Location = new Point(657, 164);
            Step2Label.Name = "Step2Label";
            Step2Label.Size = new Size(92, 31);
            Step2Label.TabIndex = 17;
            Step2Label.Text = "Step 2";
            // 
            // Step3DescriptionLabel
            // 
            Step3DescriptionLabel.AutoSize = true;
            Step3DescriptionLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Step3DescriptionLabel.Location = new Point(174, 476);
            Step3DescriptionLabel.Name = "Step3DescriptionLabel";
            Step3DescriptionLabel.Size = new Size(142, 17);
            Step3DescriptionLabel.TabIndex = 20;
            Step3DescriptionLabel.Text = "Select mode and run!";
            // 
            // Step3Label
            // 
            Step3Label.AutoSize = true;
            Step3Label.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Step3Label.Location = new Point(201, 441);
            Step3Label.Name = "Step3Label";
            Step3Label.Size = new Size(92, 31);
            Step3Label.TabIndex = 19;
            Step3Label.Text = "Step 3";
            // 
            // PasswordTextBoxExternalContainer
            // 
            PasswordTextBoxExternalContainer.BackColor = Color.FromArgb(43, 38, 86);
            PasswordTextBoxExternalContainer.BackgroundImageLayout = ImageLayout.None;
            PasswordTextBoxExternalContainer.Controls.Add(PasswordTextBoxInternalContainer);
            PasswordTextBoxExternalContainer.Location = new Point(577, 227);
            PasswordTextBoxExternalContainer.Name = "PasswordTextBoxExternalContainer";
            PasswordTextBoxExternalContainer.Size = new Size(258, 23);
            PasswordTextBoxExternalContainer.TabIndex = 21;
            // 
            // PasswordTextBoxInternalContainer
            // 
            PasswordTextBoxInternalContainer.BackColor = Color.FromArgb(18, 16, 41);
            PasswordTextBoxInternalContainer.Controls.Add(PasswordTextBox);
            PasswordTextBoxInternalContainer.Location = new Point(1, 1);
            PasswordTextBoxInternalContainer.Name = "PasswordTextBoxInternalContainer";
            PasswordTextBoxInternalContainer.Size = new Size(256, 21);
            PasswordTextBoxInternalContainer.TabIndex = 22;
            // 
            // ConfirmPasswordTextBoxExternalContainer
            // 
            ConfirmPasswordTextBoxExternalContainer.BackColor = Color.FromArgb(43, 38, 86);
            ConfirmPasswordTextBoxExternalContainer.BackgroundImageLayout = ImageLayout.None;
            ConfirmPasswordTextBoxExternalContainer.Controls.Add(ConfirmPasswordTextBoxInternalContainer);
            ConfirmPasswordTextBoxExternalContainer.Location = new Point(577, 256);
            ConfirmPasswordTextBoxExternalContainer.Name = "ConfirmPasswordTextBoxExternalContainer";
            ConfirmPasswordTextBoxExternalContainer.Size = new Size(258, 23);
            ConfirmPasswordTextBoxExternalContainer.TabIndex = 22;
            // 
            // ConfirmPasswordTextBoxInternalContainer
            // 
            ConfirmPasswordTextBoxInternalContainer.BackColor = Color.FromArgb(18, 16, 41);
            ConfirmPasswordTextBoxInternalContainer.Controls.Add(ConfirmPasswordTextBox);
            ConfirmPasswordTextBoxInternalContainer.Location = new Point(1, 1);
            ConfirmPasswordTextBoxInternalContainer.Name = "ConfirmPasswordTextBoxInternalContainer";
            ConfirmPasswordTextBoxInternalContainer.Size = new Size(256, 21);
            ConfirmPasswordTextBoxInternalContainer.TabIndex = 22;
            // 
            // WindowControlPanel
            // 
            WindowControlPanel.BackColor = Color.FromArgb(43, 38, 86);
            WindowControlPanel.Controls.Add(IconPictureBox);
            WindowControlPanel.Controls.Add(MinimizeButton);
            WindowControlPanel.Controls.Add(CloseButton);
            WindowControlPanel.Controls.Add(WindowNameLabel);
            WindowControlPanel.Location = new Point(0, 0);
            WindowControlPanel.Name = "WindowControlPanel";
            WindowControlPanel.Size = new Size(900, 29);
            WindowControlPanel.TabIndex = 23;
            // 
            // IconPictureBox
            // 
            IconPictureBox.BackgroundImage = Properties.Resources.icon;
            IconPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            IconPictureBox.Location = new Point(2, 2);
            IconPictureBox.Name = "IconPictureBox";
            IconPictureBox.Size = new Size(25, 25);
            IconPictureBox.TabIndex = 26;
            IconPictureBox.TabStop = false;
            // 
            // MinimizeButton
            // 
            MinimizeButton.BackColor = Color.FromArgb(43, 38, 86);
            MinimizeButton.BackgroundImage = Properties.Resources.minimize_button;
            MinimizeButton.FlatAppearance.BorderSize = 0;
            MinimizeButton.FlatStyle = FlatStyle.Flat;
            MinimizeButton.ForeColor = Color.White;
            MinimizeButton.Location = new Point(810, 0);
            MinimizeButton.Margin = new Padding(3, 4, 3, 4);
            MinimizeButton.Name = "MinimizeButton";
            MinimizeButton.Size = new Size(45, 29);
            MinimizeButton.TabIndex = 25;
            MinimizeButton.UseVisualStyleBackColor = false;
            MinimizeButton.Click += OnMinimizeButtonClick;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.FromArgb(43, 38, 86);
            CloseButton.BackgroundImage = Properties.Resources.close_button;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(855, 0);
            CloseButton.Margin = new Padding(3, 4, 3, 4);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(45, 29);
            CloseButton.TabIndex = 24;
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += OnCloseButtonClick;
            // 
            // WindowNameLabel
            // 
            WindowNameLabel.AutoSize = true;
            WindowNameLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            WindowNameLabel.Location = new Point(406, 6);
            WindowNameLabel.Name = "WindowNameLabel";
            WindowNameLabel.Size = new Size(88, 17);
            WindowNameLabel.TabIndex = 16;
            WindowNameLabel.Text = "FileProtector";
            // 
            // AppVersionLabel
            // 
            AppVersionLabel.AutoSize = true;
            AppVersionLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AppVersionLabel.Location = new Point(871, 632);
            AppVersionLabel.Name = "AppVersionLabel";
            AppVersionLabel.Size = new Size(31, 15);
            AppVersionLabel.TabIndex = 24;
            AppVersionLabel.Text = "vX.X";
            // 
            // FolderCheckBox
            // 
            FolderCheckBox.AutoSize = true;
            FolderCheckBox.Location = new Point(112, 218);
            FolderCheckBox.Margin = new Padding(3, 4, 3, 4);
            FolderCheckBox.Name = "FolderCheckBox";
            FolderCheckBox.Size = new Size(69, 22);
            FolderCheckBox.TabIndex = 25;
            FolderCheckBox.Text = "Folder";
            FolderCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 16, 41);
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(900, 650);
            Controls.Add(FolderCheckBox);
            Controls.Add(AppVersionLabel);
            Controls.Add(WindowControlPanel);
            Controls.Add(ConfirmPasswordTextBoxExternalContainer);
            Controls.Add(PasswordTextBoxExternalContainer);
            Controls.Add(Step3DescriptionLabel);
            Controls.Add(ProceedButton);
            Controls.Add(DecryptRadioButton);
            Controls.Add(EncryptRadioButton);
            Controls.Add(Step3Label);
            Controls.Add(Step2DescriptionLabel);
            Controls.Add(Step2Label);
            Controls.Add(Step1DescriptionLabel);
            Controls.Add(ShowPasswordCheckBox);
            Controls.Add(Step1Label);
            Controls.Add(BrowseButton);
            Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FileProtector";
            PasswordTextBoxExternalContainer.ResumeLayout(false);
            PasswordTextBoxInternalContainer.ResumeLayout(false);
            PasswordTextBoxInternalContainer.PerformLayout();
            ConfirmPasswordTextBoxExternalContainer.ResumeLayout(false);
            ConfirmPasswordTextBoxInternalContainer.ResumeLayout(false);
            ConfirmPasswordTextBoxInternalContainer.PerformLayout();
            WindowControlPanel.ResumeLayout(false);
            WindowControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IconPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private PictureBox IconPictureBox;
        private CheckBox FolderCheckBox;
    }
}