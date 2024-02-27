namespace FileProtector.Forms.Modal.ProceedCrypto
{
    partial class CryptoConfirmationForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PathsListBox = new System.Windows.Forms.ListBox();
            this.HideFilesCheckBox = new System.Windows.Forms.CheckBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))));
            this.MainPanel.Controls.Add(this.PathsListBox);
            this.MainPanel.Controls.Add(this.HideFilesCheckBox);
            this.MainPanel.Controls.Add(this.CancelButton);
            this.MainPanel.Controls.Add(this.ContinueButton);
            this.MainPanel.Location = new System.Drawing.Point(3, 20);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(655, 439);
            this.MainPanel.TabIndex = 0;
            // 
            // PathsListBox
            // 
            this.PathsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(38)))), ((int)(((byte)(86)))));
            this.PathsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PathsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PathsListBox.ForeColor = System.Drawing.Color.White;
            this.PathsListBox.FormattingEnabled = true;
            this.PathsListBox.HorizontalScrollbar = true;
            this.PathsListBox.ItemHeight = 16;
            this.PathsListBox.Location = new System.Drawing.Point(3, 3);
            this.PathsListBox.Name = "PathsListBox";
            this.PathsListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.PathsListBox.Size = new System.Drawing.Size(649, 384);
            this.PathsListBox.Sorted = true;
            this.PathsListBox.TabIndex = 12;
            // 
            // HideFilesCheckBox
            // 
            this.HideFilesCheckBox.AutoSize = true;
            this.HideFilesCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideFilesCheckBox.Location = new System.Drawing.Point(368, 402);
            this.HideFilesCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HideFilesCheckBox.Name = "HideFilesCheckBox";
            this.HideFilesCheckBox.Size = new System.Drawing.Size(189, 22);
            this.HideFilesCheckBox.TabIndex = 11;
            this.HideFilesCheckBox.Text = "Hide files after encryption";
            this.HideFilesCheckBox.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(38)))), ((int)(((byte)(86)))));
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(181, 394);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(172, 38);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelEncryptionButton_Click);
            // 
            // ContinueButton
            // 
            this.ContinueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(38)))), ((int)(((byte)(86)))));
            this.ContinueButton.FlatAppearance.BorderSize = 0;
            this.ContinueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContinueButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(45)))), ((int)(((byte)(0)))));
            this.ContinueButton.Location = new System.Drawing.Point(3, 394);
            this.ContinueButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(172, 38);
            this.ContinueButton.TabIndex = 9;
            this.ContinueButton.Text = "Continue";
            this.ContinueButton.UseVisualStyleBackColor = false;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // CryptoConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(661, 462);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CryptoConfirmationForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MainPanel;
        private Button CancelButton;
        private Button ContinueButton;
        private CheckBox HideFilesCheckBox;
        private ListBox PathsListBox;
    }
}