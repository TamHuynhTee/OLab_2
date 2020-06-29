using OLab_2.Controllers;
using OLab_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OLab_2.Views
{
    public partial class frmProjectInfo : Form
    {
        public bool isSign;
        public Project main;
        public int countMembers;
        public int countJobs;
        public int deleteNumber = 0;
        bool? DoneTemp;
        string login;

        public frmProjectInfo(Project input, int cJ, int cM, string CV, string Login)
        {
            main = input;
            login = Login;
            InitializeComponent();
            pnInfo.BringToFront();

            if (CV == "Trưởng Dự Án")
                btnDelete.Enabled = false;

            deleteNumber = 0;
            main = input;
            countJobs = cJ; labAmountJobs.Text = countJobs.ToString();
            countMembers = cM; labAmountMembers.Text = countMembers.ToString();

            labID.Text = main.MaDA;
            txtName.Text = main.TenDA;
            labProgress.Text = main.TienDo.ToString();
            labLeaderID.Text = '[' + main.MaNQL + ']';
            labDate.Text = main.ThoiGian.ToString("dd / MM / yyyy");
            rtxtContent.Text = main.NoiDung;
            DoneTemp = main.HoanThanh;

            if (File.Exists(@"Images\" + main.MaDA + ".jpg"))
            {
                if (main.HoanThanh == true)
                    picSign.Image = Image.FromFile(@"Images\" + main.MaDA + ".jpg");
                else
                    try
                    {
                        File.Delete(@"Images\" + main.MaDA + ".jpg");
                    }
                    catch
                    {

                    }
            }
            else if (main.HoanThanh == true)
            {
                MessageBox.Show("Lỗi Dữ Liệu, Chữ Kí đẫ bị mất");
            }
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
                pnSign.BringToFront();
                pnSign.Visible = true;
            }
            else
            {
                btnChangeInfo.Text = "INFO";
                pnSign.Visible = false;
                rtxtContent.Visible = false;
            }
        }
        // Name
        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được để trống");
                txtName.Text = main.TenDA;
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtName_Leave(sender, EventArgs.Empty);
            }
        }

        // Change
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
        public bool checkChange()
        {
            bool isChange = false;
            if (main.TenDA.Trim() != txtName.Text.Trim())
            {
                main.TenDA = txtName.Text.Trim();
                isChange = true;
            }
            if (rtxtContent.Text != main.NoiDung)
            {
                main.NoiDung = rtxtContent.Text;
                isChange = true;
            }
            if (DoneTemp != main.HoanThanh)
            {
                main.HoanThanh = DoneTemp;
                if (main.HoanThanh == true)
                    new Bitmap(picSign.Image).Save(@"Images\" + main.MaDA + ".jpg", ImageFormat.Jpeg);
                isChange = true;
            }
            return isChange;
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (main.MaNQL != null && main.TienDo == 100)
            {
                DoneTemp = true;
                picSign.Image = Image.FromFile(@"Images\" + login + "SIGN.jpg");
            }
            else
            {
                MessageBox.Show("Tiến độ chưa đạt tiêu chuẩn");
            }
        }

        private void btnClearSign_Click(object sender, EventArgs e)
        {
            if (picSign.Image != null)
            {
                DoneTemp = false;
                picSign.Image.Dispose();
                picSign.Image = null;
            }
        }
    }
}
