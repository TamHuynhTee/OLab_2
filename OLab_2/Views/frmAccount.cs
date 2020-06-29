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
    public partial class frmAccount : Form
    {
        List<Member> ListMember;
        int index;
        string passTemp;
        public frmAccount(ref List<Member> LM, string Ma)
        {
            ListMember = LM;
            index = ListMember.FindIndex(x => x.MaTV == Ma);
            if (index == -1)
                MessageBox.Show("Lỗi Chương Trình, không tìm thấy Account");

            InitializeComponent();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            labKey.Text = ListMember[index].MaTV;
            passTemp = txtPass.Text = ListMember[index].Password;
            txtName.Text = ListMember[index].TenTV;
            cbSex.Text = ListMember[index].GioiTinh;
            dtpBirthday.Value = ListMember[index].NgaySinh;
            txtPhone.Text = ListMember[index].Phone;
            txtEmail.Text = ListMember[index].Email;

            picFace.Image = Image.FromFile(@"Images\" + ListMember[index].MaTV + "FACE.jpg");
            picSign.Image = Image.FromFile(@"Images\" + ListMember[index].MaTV + "SIGN.jpg");

            labLevel.Text = "[LEVEL ACCOUNT: " + ((ListMember[index].ChucVu.Trim() == "Giám Đốc") ? "1" :
                (ListMember[index].ChucVu.Trim() == "Trưởng Dự Án") ? "2" :
                (ListMember[index].ChucVu.Trim() == "Trưởng Nhóm") ? "3" : "4") + "  ]";
        }

        //Pass

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (btnChangePass.Text == "Change")
            {
                btnChangePass.Text = "Confirm";
                MessageBox.Show("Nhập mật khẩu cũ");
                txtPass.UseSystemPasswordChar = false;
                txtPass.Text = "";
            }
            else if (btnChangePass.Text == "Confirm")
            {
                if (txtPass.Text == passTemp)
                {
                    MessageBox.Show("Xác nhận, nhập mật khẩu mới");
                    btnChangePass.Text = "Okay";
                }
                else
                {
                    btnChangePass.Text = "Change";
                    txtPass.UseSystemPasswordChar = true;
                    txtPass.Text = passTemp;
                }
            }
            else
            {
                passTemp = txtPass.Text;
                btnChangePass.Text = "Change";
                txtPass.UseSystemPasswordChar = true;
            }
        }
        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (btnChangePass.Focused == false)
            {
                btnChangePass.Text = "Change";
                txtPass.UseSystemPasswordChar = true;
                txtPass.Text = passTemp;
            }
        }

        // Name

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được bỏ trống");
                txtName.Text = ListMember[index].TenTV;
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtName_Leave(sender, EventArgs.Empty);
        }

        private void cbSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSex.Text.Trim() == "")
            {
                MessageBox.Show("Giới tính không được bỏ trống");
                cbSex.Text = ListMember[index].TenTV;
            }
        }

        // Birth
        private void dtpBirthday_Leave(object sender, EventArgs e)
        {
            if (DateTime.Now.Year - dtpBirthday.Value.Year < 18)
            {
                MessageBox.Show("Phải trên 18 tuổi");
                dtpBirthday.Value = ListMember[index].NgaySinh;
            }
        }

        //Phone
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
                txtPhone.Text = ListMember[index].Phone;
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPhone_Leave("", EventArgs.Empty);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ListMember[index].TenTV = txtName.Text;
            ListMember[index].GioiTinh = cbSex.Text;
            ListMember[index].Phone = txtPhone.Text;
            ListMember[index].Email = txtEmail.Text;
            ListMember[index].Password = txtPass.Text;

            MessageBox.Show("Đã cập nhật, Save để lưu thay đổi");
        }
    }
}
