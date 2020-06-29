namespace OLab_2.Views
{
    partial class frmMemberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMemberForm));
            this.pnMain = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPass = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnClearSign = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnClearFace = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.picSign = new System.Windows.Forms.PictureBox();
            this.picFace = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.gbWork = new System.Windows.Forms.GroupBox();
            this.ckbLeaderJob = new System.Windows.Forms.CheckBox();
            this.ckbLeaderProject = new System.Windows.Forms.CheckBox();
            this.cbJob = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbProject = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rtxtContent = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnMain.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbWork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnMain.Controls.Add(this.groupBox2);
            this.pnMain.Controls.Add(this.groupBox1);
            this.pnMain.Controls.Add(this.gbWork);
            this.pnMain.Controls.Add(this.btnClearForm);
            this.pnMain.Controls.Add(this.btnAddMember);
            this.pnMain.Controls.Add(this.label1);
            this.pnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnMain.ForeColor = System.Drawing.Color.White;
            this.pnMain.Location = new System.Drawing.Point(12, 12);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(921, 571);
            this.pnMain.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPass);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btnClearSign);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.btnClearFace);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.picSign);
            this.groupBox2.Controls.Add(this.picFace);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(435, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 299);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PERSONAL";
            // 
            // btnPass
            // 
            this.btnPass.ForeColor = System.Drawing.Color.Black;
            this.btnPass.Location = new System.Drawing.Point(355, 39);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(76, 29);
            this.btnPass.TabIndex = 34;
            this.btnPass.Text = "SHOW";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 20);
            this.label13.TabIndex = 29;
            this.label13.Text = "PASS:";
            // 
            // btnClearSign
            // 
            this.btnClearSign.ForeColor = System.Drawing.Color.Black;
            this.btnClearSign.Location = new System.Drawing.Point(355, 264);
            this.btnClearSign.Name = "btnClearSign";
            this.btnClearSign.Size = new System.Drawing.Size(76, 29);
            this.btnClearSign.TabIndex = 33;
            this.btnClearSign.Text = "CLEAR";
            this.btnClearSign.UseVisualStyleBackColor = true;
            this.btnClearSign.Click += new System.EventHandler(this.btnClearSign_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(84, 41);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(268, 27);
            this.txtPassword.TabIndex = 30;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnClearFace
            // 
            this.btnClearFace.ForeColor = System.Drawing.Color.Black;
            this.btnClearFace.Location = new System.Drawing.Point(143, 264);
            this.btnClearFace.Name = "btnClearFace";
            this.btnClearFace.Size = new System.Drawing.Size(76, 29);
            this.btnClearFace.TabIndex = 32;
            this.btnClearFace.Text = "CLEAR";
            this.btnClearFace.UseVisualStyleBackColor = true;
            this.btnClearFace.Click += new System.EventHandler(this.btnClearFace_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(236, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 20);
            this.label12.TabIndex = 30;
            this.label12.Text = "SIGN:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "FACE:";
            // 
            // picSign
            // 
            this.picSign.BackColor = System.Drawing.Color.LightSteelBlue;
            this.picSign.Location = new System.Drawing.Point(296, 81);
            this.picSign.Name = "picSign";
            this.picSign.Size = new System.Drawing.Size(135, 180);
            this.picSign.TabIndex = 1;
            this.picSign.TabStop = false;
            this.picSign.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picSign_MouseDown);
            this.picSign.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbSign_MouseMove);
            this.picSign.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbSign_MouseUp);
            // 
            // picFace
            // 
            this.picFace.BackColor = System.Drawing.Color.LightSteelBlue;
            this.picFace.Location = new System.Drawing.Point(84, 81);
            this.picFace.Name = "picFace";
            this.picFace.Size = new System.Drawing.Size(135, 180);
            this.picFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFace.TabIndex = 0;
            this.picFace.TabStop = false;
            this.picFace.DragDrop += new System.Windows.Forms.DragEventHandler(this.picFace_DragDrop);
            this.picFace.DragEnter += new System.Windows.Forms.DragEventHandler(this.picFace_DragEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtSalary);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.cbSex);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbLevel);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.dtpBirthday);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(21, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 137);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFO";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(821, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 20);
            this.label16.TabIndex = 33;
            this.label16.Text = "(%)";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(747, 58);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(72, 27);
            this.txtSalary.TabIndex = 32;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(498, 58);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(143, 27);
            this.txtEmail.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(662, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 20);
            this.label15.TabIndex = 31;
            this.label15.Text = "SALARY:";
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbSex.Location = new System.Drawing.Point(312, 93);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(86, 28);
            this.cbSex.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "NAME:";
            // 
            // cbLevel
            // 
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Items.AddRange(new object[] {
            "Cử Nhân     ",
            "Thạc Sĩ     ",
            "Tiến Sĩ     ",
            "PGS. Tiến Sĩ",
            "GS. Tiến Sĩ "});
            this.cbLevel.Location = new System.Drawing.Point(747, 24);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(110, 28);
            this.cbLevel.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(674, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "LEVEL:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(259, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "SEX:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(77, 27);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(321, 27);
            this.txtID.TabIndex = 8;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CustomFormat = " dd / MM / yyyy";
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthday.Location = new System.Drawing.Point(77, 93);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(156, 27);
            this.dtpBirthday.TabIndex = 26;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(77, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(321, 27);
            this.txtName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "DATE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "PHONE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "EMAIL:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(498, 25);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(143, 27);
            this.txtPhone.TabIndex = 23;
            // 
            // gbWork
            // 
            this.gbWork.Controls.Add(this.ckbLeaderJob);
            this.gbWork.Controls.Add(this.ckbLeaderProject);
            this.gbWork.Controls.Add(this.cbJob);
            this.gbWork.Controls.Add(this.label10);
            this.gbWork.Controls.Add(this.cbProject);
            this.gbWork.Controls.Add(this.label7);
            this.gbWork.Controls.Add(this.rtxtContent);
            this.gbWork.Controls.Add(this.label8);
            this.gbWork.ForeColor = System.Drawing.Color.White;
            this.gbWork.Location = new System.Drawing.Point(21, 208);
            this.gbWork.Name = "gbWork";
            this.gbWork.Size = new System.Drawing.Size(398, 299);
            this.gbWork.TabIndex = 29;
            this.gbWork.TabStop = false;
            this.gbWork.Text = "PERTAIN";
            // 
            // ckbLeaderJob
            // 
            this.ckbLeaderJob.BackColor = System.Drawing.Color.Gainsboro;
            this.ckbLeaderJob.Enabled = false;
            this.ckbLeaderJob.ForeColor = System.Drawing.Color.Black;
            this.ckbLeaderJob.Location = new System.Drawing.Point(298, 145);
            this.ckbLeaderJob.Name = "ckbLeaderJob";
            this.ckbLeaderJob.Size = new System.Drawing.Size(83, 24);
            this.ckbLeaderJob.TabIndex = 35;
            this.ckbLeaderJob.Text = "Leader";
            this.ckbLeaderJob.UseVisualStyleBackColor = false;
            this.ckbLeaderJob.CheckedChanged += new System.EventHandler(this.ckbLeaderJob_CheckedChanged);
            // 
            // ckbLeaderProject
            // 
            this.ckbLeaderProject.BackColor = System.Drawing.Color.Gainsboro;
            this.ckbLeaderProject.Enabled = false;
            this.ckbLeaderProject.ForeColor = System.Drawing.Color.Black;
            this.ckbLeaderProject.Location = new System.Drawing.Point(298, 75);
            this.ckbLeaderProject.Name = "ckbLeaderProject";
            this.ckbLeaderProject.Size = new System.Drawing.Size(83, 24);
            this.ckbLeaderProject.TabIndex = 34;
            this.ckbLeaderProject.Text = "Leader";
            this.ckbLeaderProject.UseVisualStyleBackColor = false;
            this.ckbLeaderProject.CheckedChanged += new System.EventHandler(this.ckbLeaderProjet_CheckedChanged);
            // 
            // cbJob
            // 
            this.cbJob.Enabled = false;
            this.cbJob.FormattingEnabled = true;
            this.cbJob.Location = new System.Drawing.Point(113, 111);
            this.cbJob.Name = "cbJob";
            this.cbJob.Size = new System.Drawing.Size(268, 28);
            this.cbJob.TabIndex = 32;
            this.cbJob.SelectedIndexChanged += new System.EventHandler(this.cbJob_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 31;
            this.label10.Text = "JOB:";
            // 
            // cbProject
            // 
            this.cbProject.FormattingEnabled = true;
            this.cbProject.Location = new System.Drawing.Point(113, 41);
            this.cbProject.Name = "cbProject";
            this.cbProject.Size = new System.Drawing.Size(268, 28);
            this.cbProject.TabIndex = 30;
            this.cbProject.SelectedIndexChanged += new System.EventHandler(this.cbProject_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "PROJECT:";
            // 
            // rtxtContent
            // 
            this.rtxtContent.Enabled = false;
            this.rtxtContent.Location = new System.Drawing.Point(113, 181);
            this.rtxtContent.Name = "rtxtContent";
            this.rtxtContent.Size = new System.Drawing.Size(268, 93);
            this.rtxtContent.TabIndex = 10;
            this.rtxtContent.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "CONTENT:";
            // 
            // btnClearForm
            // 
            this.btnClearForm.ForeColor = System.Drawing.Color.Black;
            this.btnClearForm.Location = new System.Drawing.Point(744, 522);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(150, 29);
            this.btnClearForm.TabIndex = 18;
            this.btnClearForm.Text = "CLEAR";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.ForeColor = System.Drawing.Color.Black;
            this.btnAddMember.Location = new System.Drawing.Point(584, 522);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(150, 29);
            this.btnAddMember.TabIndex = 17;
            this.btnAddMember.Text = "ADD MEMBER";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MEMBER FORM:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(945, 595);
            this.Controls.Add(this.pnMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMemberForm";
            this.Text = "frmMemberForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMemberForm_FormClosing);
            this.Load += new System.EventHandler(this.frmMemberForm_Load);
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbWork.ResumeLayout(false);
            this.gbWork.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.RichTextBox rtxtContent;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbWork;
        private System.Windows.Forms.ComboBox cbJob;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbProject;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClearSign;
        private System.Windows.Forms.Button btnClearFace;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox picSign;
        private System.Windows.Forms.PictureBox picFace;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox ckbLeaderJob;
        private System.Windows.Forms.CheckBox ckbLeaderProject;
    }
}