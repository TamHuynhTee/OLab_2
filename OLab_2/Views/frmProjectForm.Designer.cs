namespace OLab_2.Views
{
    partial class frmProjectForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labCountJob = new System.Windows.Forms.Label();
            this.labCountMember = new System.Windows.Forms.Label();
            this.lbJobs = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.lbMembers = new System.Windows.Forms.ListBox();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.cbLeader = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtxtContent = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnMain.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnMain.Controls.Add(this.groupBox2);
            this.pnMain.Controls.Add(this.groupBox1);
            this.pnMain.Controls.Add(this.btnClearForm);
            this.pnMain.Controls.Add(this.btnAddProject);
            this.pnMain.Controls.Add(this.label1);
            this.pnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnMain.ForeColor = System.Drawing.Color.White;
            this.pnMain.Location = new System.Drawing.Point(12, 12);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(921, 571);
            this.pnMain.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labCountJob);
            this.groupBox2.Controls.Add(this.labCountMember);
            this.groupBox2.Controls.Add(this.lbJobs);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnAddJob);
            this.groupBox2.Controls.Add(this.lbMembers);
            this.groupBox2.Controls.Add(this.btnAddMember);
            this.groupBox2.Controls.Add(this.cbLeader);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(465, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 400);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CONTAINS";
            // 
            // labCountJob
            // 
            this.labCountJob.AutoSize = true;
            this.labCountJob.Location = new System.Drawing.Point(108, 334);
            this.labCountJob.Name = "labCountJob";
            this.labCountJob.Size = new System.Drawing.Size(80, 20);
            this.labCountJob.TabIndex = 18;
            this.labCountJob.Text = "<count: >";
            // 
            // labCountMember
            // 
            this.labCountMember.AutoSize = true;
            this.labCountMember.Location = new System.Drawing.Point(108, 131);
            this.labCountMember.Name = "labCountMember";
            this.labCountMember.Size = new System.Drawing.Size(80, 20);
            this.labCountMember.TabIndex = 17;
            this.labCountMember.Text = "<count: >";
            // 
            // lbJobs
            // 
            this.lbJobs.FormattingEnabled = true;
            this.lbJobs.ItemHeight = 20;
            this.lbJobs.Location = new System.Drawing.Point(112, 247);
            this.lbJobs.Name = "lbJobs";
            this.lbJobs.Size = new System.Drawing.Size(310, 84);
            this.lbJobs.TabIndex = 15;
            this.lbJobs.SelectedIndexChanged += new System.EventHandler(this.lbJobs_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "MEMBERS:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "LEADER:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "JOBS:";
            // 
            // btnAddJob
            // 
            this.btnAddJob.ForeColor = System.Drawing.Color.Black;
            this.btnAddJob.Location = new System.Drawing.Point(332, 337);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(90, 29);
            this.btnAddJob.TabIndex = 16;
            this.btnAddJob.Text = "ADD";
            this.toolTip1.SetToolTip(this.btnAddJob, "Create new Job with Members in Project");
            this.btnAddJob.UseVisualStyleBackColor = true;
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
            // 
            // lbMembers
            // 
            this.lbMembers.FormattingEnabled = true;
            this.lbMembers.ItemHeight = 20;
            this.lbMembers.Location = new System.Drawing.Point(112, 44);
            this.lbMembers.Name = "lbMembers";
            this.lbMembers.Size = new System.Drawing.Size(310, 84);
            this.lbMembers.TabIndex = 12;
            this.lbMembers.SelectedIndexChanged += new System.EventHandler(this.lbMembers_SelectedIndexChanged);
            // 
            // btnAddMember
            // 
            this.btnAddMember.ForeColor = System.Drawing.Color.Black;
            this.btnAddMember.Location = new System.Drawing.Point(332, 134);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(90, 29);
            this.btnAddMember.TabIndex = 13;
            this.btnAddMember.Text = "ADD";
            this.toolTip1.SetToolTip(this.btnAddMember, "Show members is added / Members Free In OLab");
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // cbLeader
            // 
            this.cbLeader.FormattingEnabled = true;
            this.cbLeader.Location = new System.Drawing.Point(111, 184);
            this.cbLeader.Name = "cbLeader";
            this.cbLeader.Size = new System.Drawing.Size(311, 28);
            this.cbLeader.TabIndex = 14;
            this.toolTip1.SetToolTip(this.cbLeader, "Selete the member in Members in Project to become Leader");
            this.cbLeader.DropDown += new System.EventHandler(this.cbLeader_DropDown);
            this.cbLeader.SelectedIndexChanged += new System.EventHandler(this.cbLeader_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtxtContent);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(19, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 400);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFO";
            // 
            // rtxtContent
            // 
            this.rtxtContent.Location = new System.Drawing.Point(111, 177);
            this.rtxtContent.Name = "rtxtContent";
            this.rtxtContent.Size = new System.Drawing.Size(310, 104);
            this.rtxtContent.TabIndex = 10;
            this.rtxtContent.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "NAME:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "DATE:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "CONTENT:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(111, 47);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(310, 27);
            this.txtID.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(111, 107);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(310, 27);
            this.txtName.TabIndex = 9;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "    dd , MMMM yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(112, 317);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(232, 27);
            this.dtpDate.TabIndex = 11;
            // 
            // btnClearForm
            // 
            this.btnClearForm.ForeColor = System.Drawing.Color.Black;
            this.btnClearForm.Location = new System.Drawing.Point(731, 514);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(150, 29);
            this.btnClearForm.TabIndex = 18;
            this.btnClearForm.Text = "CLEAR";
            this.toolTip1.SetToolTip(this.btnClearForm, "Clear All Infomation in Form");
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // btnAddProject
            // 
            this.btnAddProject.ForeColor = System.Drawing.Color.Black;
            this.btnAddProject.Location = new System.Drawing.Point(571, 514);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(150, 29);
            this.btnAddProject.TabIndex = 17;
            this.btnAddProject.Text = "ADD PROJECT";
            this.toolTip1.SetToolTip(this.btnAddProject, "Add Project into OLab and save all connection with Members and new Job");
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROJECT FORM:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(945, 595);
            this.Controls.Add(this.pnMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmProjectForm";
            this.Text = "frmProjectForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProjectForm_FormClosing);
            this.Load += new System.EventHandler(this.frmProjectForm_Load);
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddJob;
        private System.Windows.Forms.ListBox lbJobs;
        private System.Windows.Forms.ComboBox cbLeader;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.ListBox lbMembers;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.RichTextBox rtxtContent;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labCountMember;
        private System.Windows.Forms.Label labCountJob;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}