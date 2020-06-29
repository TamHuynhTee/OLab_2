namespace OLab_2.Views
{
    partial class frmJobInfo
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
            this.pnMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnInfo = new System.Windows.Forms.Panel();
            this.pnSign = new System.Windows.Forms.Panel();
            this.picSign = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnClearSign = new System.Windows.Forms.Button();
            this.rtxtContent = new System.Windows.Forms.RichTextBox();
            this.labDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labMemberCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labProjectKey = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labLeaderID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChangeInfo = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnInfo.SuspendLayout();
            this.pnSign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSign)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnMain.Controls.Add(this.panel1);
            this.pnMain.Controls.Add(this.btnDelete);
            this.pnMain.Controls.Add(this.btnChangeInfo);
            this.pnMain.Controls.Add(this.txtName);
            this.pnMain.Controls.Add(this.label3);
            this.pnMain.Controls.Add(this.label1);
            this.pnMain.Controls.Add(this.label2);
            this.pnMain.Controls.Add(this.labID);
            this.pnMain.ForeColor = System.Drawing.Color.White;
            this.pnMain.Location = new System.Drawing.Point(252, 63);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(465, 337);
            this.pnMain.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.pnInfo);
            this.panel1.Location = new System.Drawing.Point(35, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 188);
            this.panel1.TabIndex = 86;
            // 
            // pnInfo
            // 
            this.pnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(91)))));
            this.pnInfo.Controls.Add(this.pnSign);
            this.pnInfo.Controls.Add(this.rtxtContent);
            this.pnInfo.Controls.Add(this.labDate);
            this.pnInfo.Controls.Add(this.label8);
            this.pnInfo.Controls.Add(this.labMemberCount);
            this.pnInfo.Controls.Add(this.label7);
            this.pnInfo.Controls.Add(this.labProjectKey);
            this.pnInfo.Controls.Add(this.label5);
            this.pnInfo.Controls.Add(this.labLeaderID);
            this.pnInfo.Controls.Add(this.label4);
            this.pnInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnInfo.Location = new System.Drawing.Point(0, 0);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(408, 188);
            this.pnInfo.TabIndex = 55;
            // 
            // pnSign
            // 
            this.pnSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(91)))));
            this.pnSign.Controls.Add(this.picSign);
            this.pnSign.Controls.Add(this.label12);
            this.pnSign.Controls.Add(this.btnSign);
            this.pnSign.Controls.Add(this.btnClearSign);
            this.pnSign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSign.ForeColor = System.Drawing.Color.White;
            this.pnSign.Location = new System.Drawing.Point(0, 0);
            this.pnSign.Name = "pnSign";
            this.pnSign.Size = new System.Drawing.Size(408, 188);
            this.pnSign.TabIndex = 2;
            this.pnSign.Visible = false;
            // 
            // picSign
            // 
            this.picSign.BackColor = System.Drawing.Color.LightSteelBlue;
            this.picSign.Location = new System.Drawing.Point(268, 9);
            this.picSign.Name = "picSign";
            this.picSign.Size = new System.Drawing.Size(112, 150);
            this.picSign.TabIndex = 79;
            this.picSign.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(180, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 20);
            this.label12.TabIndex = 80;
            this.label12.Text = "LEADER:";
            // 
            // btnSign
            // 
            this.btnSign.ForeColor = System.Drawing.Color.Black;
            this.btnSign.Location = new System.Drawing.Point(194, 92);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(68, 29);
            this.btnSign.TabIndex = 82;
            this.btnSign.Text = "SIGN";
            this.toolTip1.SetToolTip(this.btnSign, "Sign and done Job");
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnClearSign
            // 
            this.btnClearSign.ForeColor = System.Drawing.Color.Black;
            this.btnClearSign.Location = new System.Drawing.Point(194, 127);
            this.btnClearSign.Name = "btnClearSign";
            this.btnClearSign.Size = new System.Drawing.Size(68, 29);
            this.btnClearSign.TabIndex = 81;
            this.btnClearSign.Text = "CLEAR";
            this.toolTip1.SetToolTip(this.btnClearSign, "Unsign and continue Job");
            this.btnClearSign.UseVisualStyleBackColor = true;
            this.btnClearSign.Click += new System.EventHandler(this.btnClearSign_Click);
            // 
            // rtxtContent
            // 
            this.rtxtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtContent.Location = new System.Drawing.Point(0, 0);
            this.rtxtContent.Name = "rtxtContent";
            this.rtxtContent.Size = new System.Drawing.Size(408, 188);
            this.rtxtContent.TabIndex = 89;
            this.rtxtContent.Text = "";
            this.rtxtContent.Visible = false;
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDate.Location = new System.Drawing.Point(134, 122);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(27, 20);
            this.labDate.TabIndex = 88;
            this.labDate.Text = "??";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 87;
            this.label8.Text = "FROM DATE:";
            // 
            // labMemberCount
            // 
            this.labMemberCount.AutoSize = true;
            this.labMemberCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMemberCount.Location = new System.Drawing.Point(134, 69);
            this.labMemberCount.Name = "labMemberCount";
            this.labMemberCount.Size = new System.Drawing.Size(27, 20);
            this.labMemberCount.TabIndex = 86;
            this.labMemberCount.Text = "??";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 85;
            this.label7.Text = "MEMBERS:";
            // 
            // labProjectKey
            // 
            this.labProjectKey.AutoSize = true;
            this.labProjectKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labProjectKey.Location = new System.Drawing.Point(134, 20);
            this.labProjectKey.Name = "labProjectKey";
            this.labProjectKey.Size = new System.Drawing.Size(27, 20);
            this.labProjectKey.TabIndex = 78;
            this.labProjectKey.Text = "??";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 77;
            this.label5.Text = "PROJECT:";
            // 
            // labLeaderID
            // 
            this.labLeaderID.AutoSize = true;
            this.labLeaderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLeaderID.Location = new System.Drawing.Point(282, 69);
            this.labLeaderID.Name = "labLeaderID";
            this.labLeaderID.Size = new System.Drawing.Size(27, 20);
            this.labLeaderID.TabIndex = 76;
            this.labLeaderID.Text = "??";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(201, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 75;
            this.label4.Text = "LEADER:";
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(358, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 29);
            this.btnDelete.TabIndex = 83;
            this.btnDelete.Text = "[X]";
            this.toolTip1.SetToolTip(this.btnDelete, "Delete Job and Free all Members");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChangeInfo
            // 
            this.btnChangeInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(91)))));
            this.btnChangeInfo.FlatAppearance.BorderSize = 0;
            this.btnChangeInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeInfo.ForeColor = System.Drawing.Color.White;
            this.btnChangeInfo.Location = new System.Drawing.Point(35, 111);
            this.btnChangeInfo.Name = "btnChangeInfo";
            this.btnChangeInfo.Size = new System.Drawing.Size(408, 29);
            this.btnChangeInfo.TabIndex = 85;
            this.btnChangeInfo.Text = "INFO";
            this.toolTip1.SetToolTip(this.btnChangeInfo, "Switch infomation");
            this.btnChangeInfo.UseVisualStyleBackColor = false;
            this.btnChangeInfo.Click += new System.EventHandler(this.btnChangeInfo_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(229, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(214, 27);
            this.txtName.TabIndex = 84;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 83;
            this.label3.Text = "NAME:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "JOB INFO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 73;
            this.label2.Text = "ID:";
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labID.Location = new System.Drawing.Point(68, 69);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(27, 20);
            this.labID.TabIndex = 74;
            this.labID.Text = "??";
            // 
            // frmJobInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(979, 453);
            this.Controls.Add(this.pnMain);
            this.Name = "frmJobInfo";
            this.Text = "Job";
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnInfo.ResumeLayout(false);
            this.pnInfo.PerformLayout();
            this.pnSign.ResumeLayout(false);
            this.pnSign.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSign)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnInfo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnClearSign;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox picSign;
        private System.Windows.Forms.Label labProjectKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labLeaderID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labMemberCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnSign;
        private System.Windows.Forms.Button btnChangeInfo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtxtContent;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}