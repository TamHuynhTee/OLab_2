using OLab_2.Controllers;
using OLab_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OLab_2.Views
{
    public partial class frmSalary : Form
    {
        List<SalaryLevel> ListSLevel = SLevelControllers.GetList();
        List<SalaryPosition> ListSPosition = SPositionControllers.GetList();

        public frmSalary()
        {
            InitializeComponent();
            colLevel.DataPropertyName = nameof(SalaryLevel.HocVan);
            colLevelSalary.DataPropertyName = nameof(SalaryLevel.Luong);

            colPosition.DataPropertyName = nameof(SalaryPosition.ChucVu);
            colPositionSalary.DataPropertyName = nameof(SalaryPosition.Luong);

        }

        private void frmSalary_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = ListSLevel;
            dgvLevel.DataSource = bs;

            BindingSource bs2 = new BindingSource();
            bs2.DataSource = ListSPosition;
            dgvPosition.DataSource = bs2;
        }

        private void fullCellWithControl(Control ctl, Rectangle rect, DataGridView dgv)
        {
            dgv.Controls.Add(ctl);
            ctl.Location = new Point(rect.X, rect.Y);
            ctl.Size = new Size(rect.Width, rect.Height);
            ctl.Visible = true;
            ctl.Focus();
        }

        private void dgvLevel_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SLevelControllers.AddOrUpdate(ListSLevel[dgvLevel.CurrentCell.RowIndex]);
        }

        private void dgvPosition_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SPositionControllers.AddOrUpdate(ListSPosition[dgvPosition.CurrentCell.RowIndex]);
        }
    }
}
