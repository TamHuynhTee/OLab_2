namespace OLab_2.Views
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.labNameProgram = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnLost = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labNameProgram
            // 
            this.labNameProgram.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labNameProgram.AutoSize = true;
            this.labNameProgram.Font = new System.Drawing.Font("Script MT Bold", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNameProgram.ForeColor = System.Drawing.Color.White;
            this.labNameProgram.Location = new System.Drawing.Point(98, 19);
            this.labNameProgram.Name = "labNameProgram";
            this.labNameProgram.Size = new System.Drawing.Size(320, 120);
            this.labNameProgram.TabIndex = 1;
            this.labNameProgram.Text = "OLAB";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(60)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Controls.Add(this.btnLost);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labNameProgram);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(82, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 277);
            this.panel1.TabIndex = 2;
            // 
            // btnShow
            // 
            this.btnShow.ForeColor = System.Drawing.Color.Black;
            this.btnShow.Location = new System.Drawing.Point(413, 184);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(87, 36);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "HIDE";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Visible = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnLost
            // 
            this.btnLost.ForeColor = System.Drawing.Color.Black;
            this.btnLost.Location = new System.Drawing.Point(201, 222);
            this.btnLost.Name = "btnLost";
            this.btnLost.Size = new System.Drawing.Size(100, 36);
            this.btnLost.TabIndex = 7;
            this.btnLost.Text = "LOST";
            this.toolTip1.SetToolTip(this.btnLost, "Show Form to Confirm Account");
            this.btnLost.UseVisualStyleBackColor = true;
            this.btnLost.Click += new System.EventHandler(this.btnLost_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(307, 222);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 36);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(118, 189);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(289, 27);
            this.txtPass.TabIndex = 5;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(118, 156);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(289, 27);
            this.txtID.TabIndex = 4;
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(31, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "PASS:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(27, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(672, 386);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labNameProgram;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLost;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}