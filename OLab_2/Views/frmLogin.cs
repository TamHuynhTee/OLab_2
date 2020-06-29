using OLab_2.Controllers;
using OLab_2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace OLab_2.Views
{
    public partial class frmLogin : Form
    {
        public Member login = null;
        public bool isOkay = false;
        List<Member> ListMember = MemberControllers.GetList();
        int index;
        public frmLogin()
        {
            InitializeComponent();
            if (ListMember.Count == 0)
            {
                if (Directory.Exists("Images") == false)
                    Directory.CreateDirectory("Images");
                MessageBox.Show("Chương trình lần đầu khởi tạo. Tạo Account Giám Đốc", "Nhắc Nhở");

                frmMemberForm temp = new frmMemberForm();
                temp.ShowDialog();
                login = temp.GD;

                if (login != null)
                {
                    isOkay = true;

                    AllController.clearAllData();
                    SLevelControllers.clearAllData();
                    SPositionControllers.clearAllData();

                    SLevelControllers.AddOrUpdate(new SalaryLevel() { HocVan = "Cử Nhân", Luong = 500 });
                    SLevelControllers.AddOrUpdate(new SalaryLevel() { HocVan = "Thạc Sĩ", Luong = 750 });
                    SLevelControllers.AddOrUpdate(new SalaryLevel() { HocVan = "Tiến Sĩ", Luong = 1500 });
                    SLevelControllers.AddOrUpdate(new SalaryLevel() { HocVan = "PGS. Tiến Sĩ", Luong = 3000 });
                    SLevelControllers.AddOrUpdate(new SalaryLevel() { HocVan = "GS. Tiến Sĩ", Luong = 7000 });

                    SPositionControllers.AddOrUpdate(new SalaryPosition() { ChucVu = "Nhân Viên", Luong = 750 });
                    SPositionControllers.AddOrUpdate(new SalaryPosition() { ChucVu = "Trưởng Nhóm", Luong = 1500 });
                    SPositionControllers.AddOrUpdate(new SalaryPosition() { ChucVu = "Trưởng Dự Án", Luong = 3000 });
                    SPositionControllers.AddOrUpdate(new SalaryPosition() { ChucVu = "Giám Đốc", Luong = 10000 });

                    MemberControllers.AddOrUpdate(login);
                }
                Close();
            }
            else ShowDialog();
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (label1.Text != "NAME:")
            {
                btnShow.Visible = false;
                txtPass.UseSystemPasswordChar = true;

                index = ListMember.FindIndex(x => x.MaTV == txtID.Text);
                if (index == -1)
                    login = null;
                else
                {
                    login = ListMember[index];
                    if (login.Password == null)
                    {
                        txtPass.UseSystemPasswordChar = false;
                        txtPass.Text = "";
                        MessageBox.Show("Tài khoản bạn chưa có mật khẩu, mời bạn tạo");
                        btnShow.Visible = true;
                    }
                }
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (label2.Text != "PHONE:" && login!=null)
            {
                if (login.Password == null)
                    login.Password = txtPass.Text;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (btnLogin.Text == "LOGIN")
            {
                if (login == null || login.Password.Trim() != txtPass.Text)
                    MessageBox.Show("Mật Khẩu hoặc Tài Khoản không đúng");
                else if (login.Password.Trim() == txtPass.Text)
                {
                    ListMember[index] = login;
                    MemberControllers.AddOrUpdate(login);
                    isOkay = true;
                    Close();
                }
            }
            else
            {
                if (txtID.Text == login.TenTV.Trim() && txtPass.Text == login.Phone.Trim())
                {
                    MessageBox.Show("Xác Nhận Thành Công");
                    label1.Text = "ID:"; txtID.Text = login.MaTV;
                    label2.Text = "PASS:"; txtPass.Text = login.Password;
                    btnLogin.Text = "LOGIN";
                    btnLost.Text = "LOST";
                }
                else
                    MessageBox.Show("Xác Nhận Thất Bại");
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, EventArgs.Empty);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar == true)
            {
                btnShow.Text = "HIDE";
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                btnShow.Text = "SHOW";
                txtPass.UseSystemPasswordChar = true;
            }

        }

        private void btnLost_Click(object sender, EventArgs e)
        {
            if (btnLost.Text == "LOST")
            {
                if(login == null)
                {
                    MessageBox.Show("ID ?");
                    return;
                }    
                MessageBox.Show("Nhập thông tin để xác thực");
                label1.Text = "NAME:";
                label2.Text = "PHONE:";
                txtID.Text = txtPass.Text = "";
                txtPass.UseSystemPasswordChar = false;
                btnLogin.Text = "CONFIRM";
                btnLost.Text = "EXIT";
            }
            else
            {
                label1.Text = "ID:";
                label2.Text = "PASS:";
                txtPass.UseSystemPasswordChar = true;
                btnLogin.Text = "LOGIN";
                btnLost.Text = "LOST";
            }
        }
    }
}
