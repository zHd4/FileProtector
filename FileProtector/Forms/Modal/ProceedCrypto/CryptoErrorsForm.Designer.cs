namespace FileProtector.Forms.Modal.ProceedCrypto
{
    partial class CryptoErrorsForm
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
            this.FormLabel = new System.Windows.Forms.Label();
            this.ErrorsListBox = new System.Windows.Forms.ListBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))));
            this.MainPanel.Controls.Add(this.CloseButton);
            this.MainPanel.Controls.Add(this.ErrorsListBox);
            this.MainPanel.Controls.Add(this.FormLabel);
            this.MainPanel.Location = new System.Drawing.Point(3, 20);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(506, 234);
            this.MainPanel.TabIndex = 0;
            // 
            // FormLabel
            // 
            this.FormLabel.AutoSize = true;
            this.FormLabel.Location = new System.Drawing.Point(3, 3);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(151, 18);
            this.FormLabel.TabIndex = 0;
            this.FormLabel.Text = "completed with errors";
            // 
            // ErrorsListBox
            // 
            this.ErrorsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(38)))), ((int)(((byte)(86)))));
            this.ErrorsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ErrorsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ErrorsListBox.ForeColor = System.Drawing.Color.White;
            this.ErrorsListBox.FormattingEnabled = true;
            this.ErrorsListBox.HorizontalScrollbar = true;
            this.ErrorsListBox.ItemHeight = 16;
            this.ErrorsListBox.Location = new System.Drawing.Point(3, 27);
            this.ErrorsListBox.Name = "ErrorsListBox";
            this.ErrorsListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ErrorsListBox.Size = new System.Drawing.Size(500, 160);
            this.ErrorsListBox.Sorted = true;
            this.ErrorsListBox.TabIndex = 13;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(38)))), ((int)(((byte)(86)))));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(3, 192);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(172, 38);
            this.CloseButton.TabIndex = 14;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CryptoErrorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(512, 257);
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CryptoErrorsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MainPanel;
        private Label FormLabel;
        private ListBox ErrorsListBox;
        private Button CloseButton;
    }
}