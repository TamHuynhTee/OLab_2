namespace OLab_2.Views
{
    partial class frmSalary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvPosition = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvLevel = new System.Windows.Forms.DataGridView();
            this.colLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLevelSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPositionSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 597);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(481, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "POSITION - SALARY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "LEVEL - SALARY";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvPosition);
            this.panel2.Location = new System.Drawing.Point(486, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 459);
            this.panel2.TabIndex = 5;
            // 
            // dgvPosition
            // 
            this.dgvPosition.AllowUserToAddRows = false;
            this.dgvPosition.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPosition.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPosition.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvPosition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPosition.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPosition.ColumnHeadersHeight = 29;
            this.dgvPosition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPosition,
            this.colPositionSalary});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPosition.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPosition.EnableHeadersVisualStyles = false;
            this.dgvPosition.Location = new System.Drawing.Point(0, 0);
            this.dgvPosition.Name = "dgvPosition";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPosition.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPosition.RowHeadersVisible = false;
            this.dgvPosition.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvPosition.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPosition.RowTemplate.Height = 24;
            this.dgvPosition.Size = new System.Drawing.Size(402, 459);
            this.dgvPosition.TabIndex = 3;
            this.dgvPosition.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPosition_CellEndEdit);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvLevel);
            this.panel3.Location = new System.Drawing.Point(58, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 459);
            this.panel3.TabIndex = 4;
            // 
            // dgvLevel
            // 
            this.dgvLevel.AllowUserToAddRows = false;
            this.dgvLevel.AllowUserToResizeColumns = false;
            this.dgvLevel.AllowUserToResizeRows = false;
            this.dgvLevel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLevel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLevel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLevel.ColumnHeadersHeight = 29;
            this.dgvLevel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLevel,
            this.colLevelSalary});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLevel.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLevel.EnableHeadersVisualStyles = false;
            this.dgvLevel.Location = new System.Drawing.Point(0, 0);
            this.dgvLevel.Name = "dgvLevel";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLevel.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvLevel.RowHeadersVisible = false;
            this.dgvLevel.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvLevel.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvLevel.RowTemplate.Height = 24;
            this.dgvLevel.Size = new System.Drawing.Size(402, 459);
            this.dgvLevel.TabIndex = 3;
            this.dgvLevel.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLevel_CellEndEdit);
            // 
            // colLevel
            // 
            this.colLevel.HeaderText = "Level";
            this.colLevel.MinimumWidth = 6;
            this.colLevel.Name = "colLevel";
            this.colLevel.ReadOnly = true;
            // 
            // colLevelSalary
            // 
            this.colLevelSalary.FillWeight = 104.8128F;
            this.colLevelSalary.HeaderText = "Salary";
            this.colLevelSalary.MinimumWidth = 6;
            this.colLevelSalary.Name = "colLevelSalary";
            // 
            // colPosition
            // 
            this.colPosition.HeaderText = "Position";
            this.colPosition.MinimumWidth = 6;
            this.colPosition.Name = "colPosition";
            this.colPosition.ReadOnly = true;
            // 
            // colPositionSalary
            // 
            this.colPositionSalary.FillWeight = 104.8128F;
            this.colPositionSalary.HeaderText = "Salary";
            this.colPositionSalary.MinimumWidth = 6;
            this.colPositionSalary.Name = "colPositionSalary";
            // 
            // frmSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(968, 622);
            this.Controls.Add(this.panel1);
            this.Name = "frmSalary";
            this.Text = "frmSalary";
            this.Load += new System.EventHandler(this.frmSalary_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLevel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvPosition;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPositionSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLevelSalary;
    }
}