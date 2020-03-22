namespace FileProtector
{
    partial class FrmEncrypt
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
            this.label3 = new System.Windows.Forms.Label();
            this.eShow = new System.Windows.Forms.CheckBox();
            this.eBUTTON = new System.Windows.Forms.Button();
            this.eBROWSE = new System.Windows.Forms.Button();
            this.ePASS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ePATHFIELD = new System.Windows.Forms.TextBox();
            this.encryptor = new System.Windows.Forms.Timer(this.components);
            this.buttonExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ePASS_REPEAT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._progress = new System.Windows.Forms.ProgressBar();
            this.openSettings = new System.Windows.Forms.Button();
            this.openDecryptForm = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.MINIMIZE = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // STATUS
            // 
            this.STATUS.AutoSize = true;
            this.STATUS.Location = new System.Drawing.Point(64, 216);
            this.STATUS.Name = "STATUS";
            this.STATUS.Size = new System.Drawing.Size(13, 17);
            this.STATUS.TabIndex = 9;
            this.STATUS.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Статус: ";
            // 
            // eShow
            // 
            this.eShow.AutoSize = true;
            this.eShow.Location = new System.Drawing.Point(548, 119);
            this.eShow.Name = "eShow";
            this.eShow.Size = new System.Drawing.Size(140, 21);
            this.eShow.TabIndex = 7;
            this.eShow.Text = "Показать пароль";
            this.eShow.UseVisualStyleBackColor = true;
            this.eShow.CheckedChanged += new System.EventHandler(this.eShow_CheckedChanged);
            // 
            // eBUTTON
            // 
            this.eBUTTON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.eBUTTON.FlatAppearance.BorderSize = 0;
            this.eBUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eBUTTON.ForeColor = System.Drawing.Color.Lime;
            this.eBUTTON.Location = new System.Drawing.Point(8, 149);
            this.eBUTTON.Name = "eBUTTON";
            this.eBUTTON.Size = new System.Drawing.Size(688, 42);
            this.eBUTTON.TabIndex = 6;
            this.eBUTTON.Text = "Зашифровать";
            this.eBUTTON.UseVisualStyleBackColor = false;
            this.eBUTTON.Click += new System.EventHandler(this.eBUTTON_Click);
            // 
            // eBROWSE
            // 
            this.eBROWSE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.eBROWSE.FlatAppearance.BorderSize = 0;
            this.eBROWSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eBROWSE.Location = new System.Drawing.Point(548, 50);
            this.eBROWSE.Name = "eBROWSE";
            this.eBROWSE.Size = new System.Drawing.Size(149, 58);
            this.eBROWSE.TabIndex = 5;
            this.eBROWSE.Text = "Выбрать..";
            this.eBROWSE.UseVisualStyleBackColor = false;
            this.eBROWSE.Click += new System.EventHandler(this.eBROWSE_Click);
            // 
            // ePASS
            // 
            this.ePASS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ePASS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ePASS.ForeColor = System.Drawing.SystemColors.Window;
            this.ePASS.Location = new System.Drawing.Point(77, 85);
            this.ePASS.Name = "ePASS";
            this.ePASS.Size = new System.Drawing.Size(465, 23);
            this.ePASS.TabIndex = 4;
            this.ePASS.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Путь: ";
            // 
            // ePATHFIELD
            // 
            this.ePATHFIELD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ePATHFIELD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ePATHFIELD.ForeColor = System.Drawing.SystemColors.Window;
            this.ePATHFIELD.Location = new System.Drawing.Point(77, 50);
            this.ePATHFIELD.Name = "ePATHFIELD";
            this.ePATHFIELD.Size = new System.Drawing.Size(465, 23);
            this.ePATHFIELD.TabIndex = 0;
            // 
            // encryptor
            // 
            this.encryptor.Interval = 1;
            this.encryptor.Tick += new System.EventHandler(this.encryptor_Tick);
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.buttonExit.ForeColor = System.Drawing.Color.Red;
            this.buttonExit.Location = new System.Drawing.Point(680, 0);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(32, 29);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "×";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(4, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "FileProtector - Шифрование";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label4_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.ePASS_REPEAT);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this._progress);
            this.panel1.Controls.Add(this.openSettings);
            this.panel1.Controls.Add(this.openDecryptForm);
            this.panel1.Controls.Add(this.aboutButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ePASS);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.eBROWSE);
            this.panel1.Controls.Add(this.ePATHFIELD);
            this.panel1.Controls.Add(this.STATUS);
            this.panel1.Controls.Add(this.eBUTTON);
            this.panel1.Controls.Add(this.eShow);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(4, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 238);
            this.panel1.TabIndex = 14;
            // 
            // ePASS_REPEAT
            // 
            this.ePASS_REPEAT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ePASS_REPEAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ePASS_REPEAT.ForeColor = System.Drawing.SystemColors.Window;
            this.ePASS_REPEAT.Location = new System.Drawing.Point(150, 120);
            this.ePASS_REPEAT.Name = "ePASS_REPEAT";
            this.ePASS_REPEAT.Size = new System.Drawing.Size(392, 23);
            this.ePASS_REPEAT.TabIndex = 19;
            this.ePASS_REPEAT.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Повторите пароль: ";
            // 
            // _progress
            // 
            this._progress.Location = new System.Drawing.Point(7, 198);
            this._progress.Name = "_progress";
            this._progress.Size = new System.Drawing.Size(689, 14);
            this._progress.Step = 1;
            this._progress.TabIndex = 17;
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
            this.openSettings.TabIndex = 16;
            this.openSettings.Text = "Настройки";
            this.openSettings.UseVisualStyleBackColor = false;
            this.openSettings.Click += new System.EventHandler(this.openSettings_Click);
            // 
            // openDecryptForm
            // 
            this.openDecryptForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.openDecryptForm.FlatAppearance.BorderSize = 0;
            this.openDecryptForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openDecryptForm.ForeColor = System.Drawing.Color.Red;
            this.openDecryptForm.Location = new System.Drawing.Point(7, 7);
            this.openDecryptForm.Name = "openDecryptForm";
            this.openDecryptForm.Size = new System.Drawing.Size(232, 34);
            this.openDecryptForm.TabIndex = 15;
            this.openDecryptForm.Text = "Расшифровать";
            this.openDecryptForm.UseVisualStyleBackColor = false;
            this.openDecryptForm.Click += new System.EventHandler(this.openDecryptForm_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.ForeColor = System.Drawing.SystemColors.Control;
            this.aboutButton.Location = new System.Drawing.Point(471, 7);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(227, 34);
            this.aboutButton.TabIndex = 14;
            this.aboutButton.Text = "О программе";
            this.aboutButton.UseVisualStyleBackColor = false;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
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
            this.MINIMIZE.TabIndex = 15;
            this.MINIMIZE.Text = "-";
            this.MINIMIZE.UseVisualStyleBackColor = true;
            this.MINIMIZE.Click += new System.EventHandler(this.MINIMIZE_Click);
            // 
            // FrmEncrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(712, 273);
            this.Controls.Add(this.MINIMIZE);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonExit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(6, 13);
            this.MaximizeBox = false;
            this.Name = "FrmEncrypt";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileProtector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEncrypt_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmEncrypt_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label STATUS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox eShow;
        private System.Windows.Forms.Button eBUTTON;
        private System.Windows.Forms.Button eBROWSE;
        private System.Windows.Forms.TextBox ePASS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ePATHFIELD;
        private System.Windows.Forms.Timer encryptor;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button openSettings;
        private System.Windows.Forms.Button openDecryptForm;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button MINIMIZE;
        private System.Windows.Forms.ProgressBar _progress;
        private System.Windows.Forms.TextBox ePASS_REPEAT;
        private System.Windows.Forms.Label label5;
    }
}

