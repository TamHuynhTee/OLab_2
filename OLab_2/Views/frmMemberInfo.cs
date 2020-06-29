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
    public partial class frmMemberInfo : Form
    {
        public Member main;
        public string projectKey;
        public string jobKey;
        public int deleteNumber = 0;

        public frmMemberInfo(Member input, string CV)
        {
            main = input;
            InitializeComponent();
            pnInfo.BringToFront();

            if (CV == "Trưởng Nhóm")
                btnOutJob.Enabled = btnOutProject.Enabled = btnDelete.Enabled = false;
            else if (CV == "Trưởng Dự Án")
                btnOutProject.Enabled = btnDelete.Enabled = false;

            deleteNumber = 0;
            main = input;

            cbSex.Text = main.GioiTinh;
            dtpBirthday.Value = main.NgaySinh;
            txtPhone.Text = main.Phone;
            txtEmail.Text = main.Email;
            txtName.Text = main.TenTV;
            txtLuongThuong.Text = main.LuongThuong.ToString();
            rtxtContent.Text = main.NoiDung;

            labProjectKey.Text = '[' + main.MaDA + ']';
            labJobKey.Text = '[' + main.MaCV + ']';
            labKey.Text = '[' + main.MaTV + ']';
            labPositoon.Text = main.ChucVu;
            labSalary.Text = ((SPositionControllers.Salary(main.ChucVu) + SLevelControllers.Salary(main.HocVan))
                * main.LuongThuong / 100).ToString();
            cbLevel.Text = main.HocVan;


            picFace.Image = Image.FromFile(@"Images\" + main.MaTV + "FACE.jpg");
            picSign.Image = Image.FromFile(@"Images\" + main.MaTV + "SIGN.jpg");
        }

        private void btnChangeInfo_Click(object sender, EventArgs e)
        {
            if (btnChangeInfo.Text == "PERTAIN")
            {
                btnChangeInfo.Text = "PERSONAL";
                pnPersonal.BringToFront();
            }
            else if (btnChangeInfo.Text == "INFO")
            {
                btnChangeInfo.Text = "PERTAIN";
                pnPertain.BringToFront();
            }
            else
            {
                btnChangeInfo.Text = "INFO";
                pnInfo.BringToFront();
            }
        }

        // Name
        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được bỏ trống");
                txtName.Text = main.TenTV;
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtName_Leave(sender, EventArgs.Empty);
            }
        }

        // Birthday
        private void dtpBirthday_Leave(object sender, EventArgs e)
        {
            if (DateTime.Now.Year - dtpBirthday.Value.Year < 18)
            {
                MessageBox.Show("Phải trên 18 tuổi");
                dtpBirthday.Value = main.NgaySinh;
            }
        }

        //SDT
        private void txtPhone_Leave(object sender, EventArgs e)
        {
            bool isOkay = true;
            if (txtPhone.Text == "")
            {
                MessageBox.Show(txtPhone, "SDT không được bỏ trống");
                isOkay = false;
            }
            else if (txtPhone.Text.Length > 10)
            {
                MessageBox.Show(txtPhone, "SDT không lố 10 số");
                isOkay = false;
            }
            else
            {
                for (int i = 0; i < txtPhone.Text.Length; i++)
                    if (txtPhone.Text[i] < '0' || txtPhone.Text[i] > '9')
                    {
                        MessageBox.Show(txtPhone, "SDT không chứa kí tự đặc biệt");
                        isOkay = false;
                        break;
                    }
            }
            if (isOkay == false)
                txtPhone.Text = main.Phone;
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txtPhone_Leave(sender, EventArgs.Empty);
            }

        }

        //Email
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            main.Email = txtEmail.Text;
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtEmail_Leave(sender, EventArgs.Empty);
        }

        // SEx
        private void cbSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSex.SelectedIndex == -1)
            {
                MessageBox.Show("Giới tính không thể bỏ trống");
                cbSex.Text = main.GioiTinh;
            }
        }

        private void cbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLevel.SelectedIndex == -1)
            {
                MessageBox.Show("Học vấn không thể bỏ trống");
                cbLevel.Text = main.HocVan;
            }
            else
                txtLuongThuong_Leave(sender, e);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnDelete.Text == "[X]")
            {
                deleteNumber = 1;
                btnOutJob.Enabled = false;
                btnOutProject.Enabled = false;
                btnOutJob.Text = btnOutProject.Text = "[X]";
                btnDelete.Text = "Cancel";
            }
            else
            {
                deleteNumber = 0;
                btnOutJob.Enabled = true;
                btnOutProject.Enabled = true;
                btnDelete.Text = "[X]";
            }
        }

        private void btnOutJob_Click(object sender, EventArgs e)
        {
            if (btnOutJob.Text == "[X]")
            {
                deleteNumber = 3;
                btnDelete.Text = btnOutProject.Text = "[X]";
                btnOutJob.Text = "Cancel";
            }
            else
            {
                deleteNumber = 0;
                btnOutJob.Text = "[X]";
            }
        }

        private void btnOutProject_Click(object sender, EventArgs e)
        {
            if (btnOutProject.Text == "[X]")
            {
                deleteNumber = 2;
                btnOutJob.Enabled = false;
                btnOutJob.Text = btnDelete.Text = "[X]";
                btnOutProject.Text = "Cancel";
            }
            else
            {
                deleteNumber = 0;
                btnOutJob.Enabled = true;
                btnOutProject.Text = "[X]";
            }
        }

        private void txtLuongThuong_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal tempLuongThuong = Convert.ToDecimal(txtLuongThuong.Text);
                decimal X = SPositionControllers.Salary(main.ChucVu);
                decimal Y = SLevelControllers.Salary(cbLevel.Text);
                labSalary.Text = ((X + Y) * tempLuongThuong / 100).ToString();
            }
            catch
            {
                MessageBox.Show("Lương Thưởng phải là số");
                txtLuongThuong.Text = main.LuongThuong.ToString();
            }
        }

        private void txtLuongThuong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtLuongThuong_Leave(sender, EventArgs.Empty);
        }

        // check change
        public bool checkChange()
        {
            bool isChange = false;
            if (main.TenTV.Trim() != txtName.Text.Trim())
            {
                main.TenTV = txtName.Text.Trim();
                isChange = true;
            }
            if (main.Phone.Trim() != txtPhone.Text.Trim())
            {
                main.Phone = txtPhone.Text.Trim();
                isChange = true;
            }
            if (main.Email != txtEmail.Text)
            {
                main.Email = txtEmail.Text.Trim();
                isChange = true;
            }
            if (main.GioiTinh.Trim() != cbSex.Text.Trim())
            {
                main.GioiTinh = cbSex.Text.Trim();
                isChange = true;
            }
            if (main.NgaySinh != dtpBirthday.Value)
            {
                main.NgaySinh = dtpBirthday.Value;
                isChange = true;
            }
            if (rtxtContent.Text != main.NoiDung)
            {
                main.NoiDung = rtxtContent.Text;
                isChange = true;
            }
            if (Convert.ToDecimal(txtLuongThuong.Text) != main.LuongThuong)
            {
                main.LuongThuong = Convert.ToDecimal(txtLuongThuong.Text);
                isChange = true;
            }
            if (main.HocVan.Trim() != cbLevel.Text.Trim())
            {
                main.HocVan = cbLevel.Text;
                isChange = true;
            }
            return isChange;
        }
    }
}

