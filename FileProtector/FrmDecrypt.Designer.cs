namespace FileProtector
{
    partial class FrmDecrypt
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
            this.components = new System.ComponentModel.Container();
            this.STATUS = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dShow = new System.Windows.Forms.CheckBox();
            this.dBUTTON = new System.Windows.Forms.Button();
            this.dBROWSE = new System.Windows.Forms.Button();
            this.dPASS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dPATHFIELD = new System.Windows.Forms.TextBox();
            this.aboutButton = new System.Windows.Forms.Button();
            this.decryptor = new System.Windows.Forms.Timer(this.components);
            this.openEncryptForm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this._progress = new System.Windows.Forms.ProgressBar();
            this.openSettings = new System.Windows.Forms.Button();
            this.MINIMIZE = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // STATUS
            // 
            this.STATUS.AutoSize = true;
            this.STATUS.Location = new System.Drawing.Point(64, 183);
            this.STATUS.Name = "STATUS";
            this.STATUS.Size = new System.Drawing.Size(13, 17);
            this.STATUS.TabIndex = 28;
            this.STATUS.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Статус: ";
            // 
            // dShow
            // 
            this.dShow.AutoSize = true;
            this.dShow.Location = new System.Drawing.Point(548, 89);
            this.dShow.Name = "dShow";
            this.dShow.Size = new System.Drawing.Size(140, 21);
            this.dShow.TabIndex = 26;
            this.dShow.Text = "Показать пароль";
            this.dShow.UseVisualStyleBackColor = true;
            this.dShow.CheckedChanged += new System.EventHandler(this.dShow_CheckedChanged);
            // 
            // dBUTTON
            // 
            this.dBUTTON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.dBUTTON.FlatAppearance.BorderSize = 0;
            this.dBUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dBUTTON.ForeColor = System.Drawing.Color.Red;
            this.dBUTTON.Location = new System.Drawing.Point(8, 116);
            this.dBUTTON.Name = "dBUTTON";
            this.dBUTTON.Size = new System.Drawing.Size(688, 42);
            this.dBUTTON.TabIndex = 25;
            this.dBUTTON.Text = "Раcшифровать";
            this.dBUTTON.UseVisualStyleBackColor = false;
            this.dBUTTON.Click += new System.EventHandler(this.dBUTTON_Click);
            // 
            // dBROWSE
            // 
            this.dBROWSE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.dBROWSE.FlatAppearance.BorderSize = 0;
            this.dBROWSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dBROWSE.Location = new System.Drawing.Point(548, 50);
            this.dBROWSE.Name = "dBROWSE";
            this.dBROWSE.Size = new System.Drawing.Size(149, 33);
            this.dBROWSE.TabIndex = 24;
            this.dBROWSE.Text = "Выбрать..";
            this.dBROWSE.UseVisualStyleBackColor = false;
            this.dBROWSE.Click += new System.EventHandler(this.dBROWSE_Click);
            // 
            // dPASS
            // 
            this.dPASS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dPASS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dPASS.ForeColor = System.Drawing.SystemColors.Window;
            this.dPASS.Location = new System.Drawing.Point(77, 85);
            this.dPASS.Name = "dPASS";
            this.dPASS.Size = new System.Drawing.Size(465, 23);
            this.dPASS.TabIndex = 23;
            this.dPASS.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Пароль: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Путь: ";
            // 
            // dPATHFIELD
            // 
            this.dPATHFIELD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dPATHFIELD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dPATHFIELD.ForeColor = System.Drawing.SystemColors.Window;
            this.dPATHFIELD.Location = new System.Drawing.Point(77, 50);
            this.dPATHFIELD.Name = "dPATHFIELD";
            this.dPATHFIELD.Size = new System.Drawing.Size(465, 23);
            this.dPATHFIELD.TabIndex = 20;
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Location = new System.Drawing.Point(471, 7);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(227, 34);
            this.aboutButton.TabIndex = 19;
            this.aboutButton.Text = "О программе ";
            this.aboutButton.UseVisualStyleBackColor = false;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // decryptor
            // 
            this.decryptor.Interval = 1;
            this.decryptor.Tick += new System.EventHandler(this.decryptor_Tick);
            // 
            // openEncryptForm
            // 
            this.openEncryptForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.openEncryptForm.FlatAppearance.BorderSize = 0;
            this.openEncryptForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openEncryptForm.ForeColor = System.Drawing.Color.Lime;
            this.openEncryptForm.Location = new System.Drawing.Point(7, 7);
            this.openEncryptForm.Name = "openEncryptForm";
            this.openEncryptForm.Size = new System.Drawing.Size(232, 34);
            this.openEncryptForm.TabIndex = 29;
            this.openEncryptForm.Text = "Зашифровать";
            this.openEncryptForm.UseVisualStyleBackColor = false;
            this.openEncryptForm.Click += new System.EventHandler(this.openEncryptForm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(4, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "FileProtector - Расшифровка";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label4_MouseDown);
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.Red;
            this.buttonExit.Location = new System.Drawing.Point(680, 0);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(32, 29);
            this.buttonExit.TabIndex = 31;
            this.buttonExit.Text = "×";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this._progress);
            this.panel1.Controls.Add(this.openSettings);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.aboutButton);
            this.panel1.Controls.Add(this.dPATHFIELD);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.openEncryptForm);
            this.panel1.Controls.Add(this.STATUS);
            this.panel1.Controls.Add(this.dPASS);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dBROWSE);
            this.panel1.Controls.Add(this.dShow);
            this.panel1.Controls.Add(this.dBUTTON);
            this.panel1.Location = new System.Drawing.Point(4, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 205);
            this.panel1.TabIndex = 32;
            // 
            // _progress
            // 
            this._progress.Location = new System.Drawing.Point(7, 165);
            this._progress.Name = "_progress";
            this._progress.Size = new System.Drawing.Size(689, 14);
            this._progress.Step = 1;
            this._progress.TabIndex = 31;
            // 
            // openSettings
            // 
            this.openSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.openSettings.FlatAppearance.BorderSize = 0;
            this.openSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openSettings.ForeColor = System.Drawing.SystemColors.Control;
            this.openSettings.Location = new System.Drawing.Point(239, 7);
            this.openSettings.Name = "openSettings";
            this.openSettings.Size = new System.Drawing.Size(232, 34);
            this.openSettings.TabIndex = 30;
            this.openSettings.Text = "Настройки";
            this.openSettings.UseVisualStyleBackColor = false;
            this.openSettings.Click += new System.EventHandler(this.openSettings_Click);
            // 
            // MINIMIZE
            // 
            this.MINIMIZE.FlatAppearance.BorderSize = 0;
            this.MINIMIZE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MINIMIZE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.MINIMIZE.ForeColor = System.Drawing.SystemColors.Control;
            this.MINIMIZE.Location = new System.Drawing.Point(648, 0);
            this.MINIMIZE.Margin = new System.Windows.Forms.Padding(4);
            this.MINIMIZE.Name = "MINIMIZE";
            this.MINIMIZE.Size = new System.Drawing.Size(32, 29);
            this.MINIMIZE.TabIndex = 31;
            this.MINIMIZE.Text = "-";
            this.MINIMIZE.UseVisualStyleBackColor = true;
            this.MINIMIZE.Click += new System.EventHandler(this.MINIMIZE_Click);
            // 
            // FrmDecrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(712, 240);
            this.Controls.Add(this.MINIMIZE);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmDecrypt";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Protector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDecrypt_FormClosing);
            this.Load += new System.EventHandler(this.FrmDecrypt_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmDecrypt_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label STATUS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox dShow;
        private System.Windows.Forms.Button dBUTTON;
        private System.Windows.Forms.Button dBROWSE;
        private System.Windows.Forms.TextBox dPASS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox dPATHFIELD;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Timer decryptor;
        private System.Windows.Forms.Button openEncryptForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button openSettings;
        private System.Windows.Forms.Button MINIMIZE;
        private System.Windows.Forms.ProgressBar _progress;
    }
}