namespace OLab_2.Views
{
    partial class frmAccount
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
            this.pnMain = new System.Windows.Forms.Panel();
            this.btnCofirm = new System.Windows.Forms.Button();
            this.pnPicture = new System.Windows.Forms.Panel();
            this.picFace = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picSign = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.labLevel = new System.Windows.Forms.Label();
            this.pnLogin = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.labKey = new System.Windows.Forms.Label();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pnInfo = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnMain.SuspendLayout();
            this.pnPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSign)).BeginInit();
            this.pnLogin.SuspendLayout();
            this.pnInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnMain.Controls.Add(this.btnCofirm);
            this.pnMain.Controls.Add(this.pnPicture);
            this.pnMain.Controls.Add(this.labLevel);
            this.pnMain.Controls.Add(this.pnLogin);
            this.pnMain.Controls.Add(this.pnInfo);
            this.pnMain.Controls.Add(this.label1);
            this.pnMain.ForeColor = System.Drawing.Color.White;
            this.pnMain.Location = new System.Drawing.Point(72, 63);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(639, 415);
            this.pnMain.TabIndex = 2;
            // 
            // btnCofirm
            // 
            this.btnCofirm.ForeColor = System.Drawing.Color.Black;
            this.btnCofirm.Location = new System.Drawing.Point(317, 360);
            this.btnCofirm.Name = "btnCofirm";
            this.btnCofirm.Size = new System.Drawing.Size(91, 29);
            this.btnCofirm.TabIndex = 56;
            this.btnCofirm.Text = "CONFIRM";
            this.btnCofirm.UseVisualStyleBackColor = true;
            this.btnCofirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // pnPicture
            // 
            this.pnPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.pnPicture.Controls.Add(this.picFace);
            this.pnPicture.Controls.Add(this.label2);
            this.pnPicture.Controls.Add(this.picSign);
            this.pnPicture.Controls.Add(this.label12);
            this.pnPicture.Location = new System.Drawing.Point(426, 62);
            this.pnPicture.Name = "pnPicture";
            this.pnPicture.Size = new System.Drawing.Size(200, 327);
            this.pnPicture.TabIndex = 55;
            // 
            // picFace
            // 
            this.picFace.BackColor = System.Drawing.Color.LightSteelBlue;
            this.picFace.Location = new System.Drawing.Point(85, 165);
            this.picFace.Name = "picFace";
            this.picFace.Size = new System.Drawing.Size(112, 150);
            this.picFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFace.TabIndex = 51;
            this.picFace.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "SIGN:";
            // 
            // picSign
            // 
            this.picSign.BackColor = System.Drawing.Color.LightSteelBlue;
            this.picSign.Location = new System.Drawing.Point(85, 7);
            this.picSign.Name = "picSign";
            this.picSign.Size = new System.Drawing.Size(112, 150);
            this.picSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSign.TabIndex = 48;
            this.picSign.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(25, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 20);
            this.label12.TabIndex = 52;
            this.label12.Text = "FACE:";
            // 
            // labLevel
            // 
            this.labLevel.AutoSize = true;
            this.labLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLevel.Location = new System.Drawing.Point(145, 23);
            this.labLevel.Name = "labLevel";
            this.labLevel.Size = new System.Drawing.Size(192, 20);
            this.labLevel.TabIndex = 54;
            this.labLevel.Text = " [LEVEL ACCOUNT: ??]";
            // 
            // pnLogin
            // 
            this.pnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.pnLogin.Controls.Add(this.label5);
            this.pnLogin.Controls.Add(this.labKey);
            this.pnLogin.Controls.Add(this.btnChangePass);
            this.pnLogin.Controls.Add(this.txtPass);
            this.pnLogin.Controls.Add(this.label13);
            this.pnLogin.Location = new System.Drawing.Point(25, 62);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(395, 76);
            this.pnLogin.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "ID:";
            // 
            // labKey
            // 
            this.labKey.AutoSize = true;
            this.labKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labKey.Location = new System.Drawing.Point(87, 15);
            this.labKey.Name = "labKey";
            this.labKey.Size = new System.Drawing.Size(27, 20);
            this.labKey.TabIndex = 49;
            this.labKey.Text = "??";
            // 
            // btnChangePass
            // 
            this.btnChangePass.ForeColor = System.Drawing.Color.Black;
            this.btnChangePass.Location = new System.Drawing.Point(312, 43);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(80, 29);
            this.btnChangePass.TabIndex = 51;
            this.btnChangePass.Text = "CHANGE";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(92, 44);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(220, 27);
            this.txtPass.TabIndex = 49;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(28, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 20);
            this.label13.TabIndex = 48;
            this.label13.Text = "PASS:";
            // 
            // pnInfo
            // 
            this.pnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.pnInfo.Controls.Add(this.txtName);
            this.pnInfo.Controls.Add(this.label8);
            this.pnInfo.Controls.Add(this.cbSex);
            this.pnInfo.Controls.Add(this.txtEmail);
            this.pnInfo.Controls.Add(this.label7);
            this.pnInfo.Controls.Add(this.label4);
            this.pnInfo.Controls.Add(this.txtPhone);
            this.pnInfo.Controls.Add(this.label6);
            this.pnInfo.Controls.Add(this.dtpBirthday);
            this.pnInfo.Controls.Add(this.label3);
            this.pnInfo.ForeColor = System.Drawing.Color.White;
            this.pnInfo.Location = new System.Drawing.Point(25, 144);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(395, 210);
            this.pnInfo.TabIndex = 48;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(92, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(291, 27);
            this.txtName.TabIndex = 49;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "NAME:";
            // 
            // cbSex
            // 
            this.cbSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbSex.Location = new System.Drawing.Point(92, 51);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(115, 28);
            this.cbSex.TabIndex = 41;
            this.cbSex.SelectedIndexChanged += new System.EventHandler(this.cbSex_SelectedIndexChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(92, 150);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(291, 27);
            this.txtEmail.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "SEX:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "EMAIL:";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(92, 118);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(291, 27);
            this.txtPhone.TabIndex = 46;
            this.txtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhone_KeyDown);
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "PHONE:";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthday.CustomFormat = " dd , MMMM  yyyy";
            this.dtpBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthday.Location = new System.Drawing.Point(92, 85);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(291, 27);
            this.dtpBirthday.TabIndex = 43;
            this.dtpBirthday.Leave += new System.EventHandler(this.dtpBirthday_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "BIRTH:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ACCOUNT:";
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(801, 525);
            this.Controls.Add(this.pnMain);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmAccount";
            this.Text = "frmAccount";
            this.Load += new System.EventHandler(this.frmAccount_Load);
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            this.pnPicture.ResumeLayout(false);
            this.pnPicture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSign)).EndInit();
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            this.pnInfo.ResumeLayout(false);
            this.pnInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Button btnCofirm;
        private System.Windows.Forms.Panel pnPicture;
        private System.Windows.Forms.PictureBox picFace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picSign;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labLevel;
        private System.Windows.Forms.Panel pnLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labKey;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel pnInfo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}