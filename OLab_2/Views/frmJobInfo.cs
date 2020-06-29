using OLab_2.Controllers;
using OLab_2.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OLab_2.Views
{
    public partial class frmJobInfo : Form
    {
        public bool isSign;
        public Job main;
        public int countMembers;
        public int deleteNumber = 0;
        bool? DoneTemp;
        string login;

        public frmJobInfo(Job input, int cM,string CV, string Login)
        {
            login = Login;
            main = input;
            InitializeComponent();
            pnInfo.BringToFront();

            if (CV == "Trưởng Nhóm")
                btnDelete.Enabled = false;

            deleteNumber = 0;
            main = input;
            countMembers = cM; labMemberCount.Text = countMembers.ToString();

            labID.Text = '[' + main.MaCV + ']';
            txtName.Text = main.TenCV;
            labLeaderID.Text = '[' + main.MaNQL + ']';
            labProjectKey.Text = '[' + main.MaDA + ']';
            labDate.Text = main.ThoiGian.ToString("dd / MM / yyyy");
            rtxtContent.Text = main.NoiDung;
            DoneTemp = main.HoanThanh;

            if (main.HoanThanh == true)
            {
                try
                {
                    picSign.Image = Image.FromFile(@"Images\" + main.MaCV + ".jpg");
                }
                catch
                {
                    MessageBox.Show("Lỗi dữ liệu, chữ kí đã bị mất");
                }
            }
            else picSign.Image = null;
        }
        private void btnChangeInfo_Click(object sender, EventArgs e)
        {
            if (btnChangeInfo.Text == "INFO")
            {
                btnChangeInfo.Text = "CONTENT";
                rtxtContent.Visible = true;
            }
            else if (btnChangeInfo.Text == "CONTENT")
            {
                btnChangeInfo.Text = "SIGN";
                pnSign.Visible = true;
                pnSign.BringToFront();
            }
            else
            {
                btnChangeInfo.Text = "INFO";
                pnSign.Visible = false;
                rtxtContent.Visible = false;
            }
        }

        // NAME
        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được để trống");
                txtName.Text = main.TenCV;
            }
        }
        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtName_Leave(sender, EventArgs.Empty);
            }
        }

        //Sign
        private void btnSign_Click(object sender, EventArgs e)
        {
            if (main.MaNQL != null)
            {
                picSign.Image = Image.FromFile(@"Images\" + login + "SIGN.jpg");
                DoneTemp = true;
            }
        }

        private void btnClearSign_Click(object sender, EventArgs e)
        {
            picSign.Image = null;
            DoneTemp = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnDelete.Text == "[X]")
            {
                deleteNumber = 1;
                btnDelete.Text = "Cancel";
            }
            else
            {
                deleteNumber = 0;
                btnDelete.Text = "[X]";
            }
        }

        // Check
        public int checkChange()
        {
            int isChange = 0;
            if (txtName.Text.Trim() != main.TenCV.Trim())
            {
                main.TenCV = txtName.Text;
                isChange = 1;
            }
            if (DoneTemp != main.HoanThanh)
            {
                main.HoanThanh = DoneTemp;
                if (main.HoanThanh == true)
                    picSign.Image.Save(@"Images\" + main.MaCV + ".jpg");
                isChange = 2;
            }
            if (rtxtContent.Text != main.NoiDung)
            {
                main.NoiDung = rtxtContent.Text;
                isChange = 1;
            }

            return isChange;
        }
    }
}
