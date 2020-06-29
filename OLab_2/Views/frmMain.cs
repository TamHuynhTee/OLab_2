using OLab_2.Controllers;
using OLab_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OLab_2.Views
{
    public partial class frmMain : Form
    {
        List<Project> ListProject = ProjectControllers.GetList();
        List<Job> ListJob = JobControllers.GetList();
        List<Member> ListMember = MemberControllers.GetList();
        string Login;
        string tempContent;
        public frmMain(Member input)
        {
            Login = input.MaTV;

            InitializeComponent();

            btnProject.Enabled = btnJob.Enabled = btnMember.Enabled = btnSalary.Enabled = false;
            switch (ListMember.Find(x => x.MaTV == Login).ChucVu.Trim())
            {
                case "Trưởng Dự Án":
                    btnJob.Enabled = true;
                    break;
                case "Trưởng Nhóm":
                    break;
                case "Nhân Viên":
                    btnManagement.Enabled = false;
                    break;
                case "Giám Đốc":
                    btnProject.Enabled = btnJob.Enabled = btnMember.Enabled = btnSalary.Enabled = true;
                    rtxtOLabGoal.ReadOnly = false;
                    break;
            }

            updateInfo();
            labManager.Text = SP.key(ListMember.Find(x => x.MaTV == "TV0000")).Trim();
            if (Login != "TV0000")
                rtxtOLabGoal.Text = ListMember.Find(x => x.MaTV == "TV0000").NoiDung;
            else btnClear.Visible = true;
        }
        //I. Form


        //II. Button
        Form childForm;
        int indexForm = -1;

        private void closeChildForm()
        {
            pnWindow.Visible = false;
            pnWindow.Controls.Remove(childForm);
            if (childForm != null)
            {
                childForm.Close();
                childForm.Dispose();
            }
        }
        private void showChildForm(Form input)
        {
            childForm = input;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnWindow.Controls.Add(childForm);
            pnWindow.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            pnWindow.Visible = true;
        }
        //  - Button Form
        private void btnProject_Click(object sender, EventArgs e)
        {
            closeChildForm();

            showChildForm(new frmProjectForm(ref ListProject, ref ListMember, ref ListJob));
            indexForm = 2;
        }
        private void btnJob_Click(object sender, EventArgs e)
        {
            closeChildForm();

            if (Login == "TV0000")
                showChildForm(new frmJobForm(ref ListProject, ref ListMember, ref ListJob));
            else
            {
                showChildForm(new frmJobForm(ListProject.Find(x=>x.MaNQL == Login), ref ListMember, ref ListJob));
            }                
            indexForm = 3;
        }
        private void btnMember_Click(object sender, EventArgs e)
        {
            closeChildForm();

            showChildForm(new frmMemberForm(ref ListProject, ref ListMember, ref ListJob));
            indexForm = 4;
        }
        //  - Button Manager
        private void btnManagement_Click(object sender, EventArgs e)
        {
            closeChildForm();
            showChildForm(new frmManager(ref ListProject, ref ListMember, ref ListJob, Login));
            indexForm = 1;
        }
        private void btnSalary_Click(object sender, EventArgs e)
        {
            closeChildForm();
            showChildForm(new frmSalary());
            indexForm = 5;
        }
        //  - Button Program
        private void btnHome_Click(object sender, EventArgs e)
        {
            indexForm = -1;
            pnWindow.Controls.Remove(childForm);
            if (childForm != null)
            {
                childForm.Close();
                childForm.Dispose();
                updateInfo();
            }
        }
        private void btnFounder_Click(object sender, EventArgs e)
        {
            closeChildForm();
            showChildForm(new frmFounders());
            indexForm = 7;
        }
        //  - Button Account
        private void btnAccount_Click(object sender, EventArgs e)
        {
            btnHome_Click(sender, e);
            showChildForm(new frmAccount(ref ListMember, Login));
            indexForm = 6;
        }

        //III. Support Program
        private void updateInfo()
        {
            labProject.Text = ListProject.Count.ToString();
            labJob.Text = ListJob.Count.ToString();
            labMember.Text = ListMember.Count.ToString();

            labProjectDone.Text = ListProject.Count(x => x.HoanThanh == true).ToString();
            labJobDone.Text = ListJob.Count(x => x.HoanThanh == true).ToString();

            int index = ListMember.FindIndex(x => x.MaTV == Login);
            labUserKey.Text = SP.key(ListMember[index]).Trim();
            rtxtUserContent.Text = ListMember[index].NoiDung;
            if (Login == "TV0000")
                tempContent = rtxtOLabGoal.Text = rtxtUserContent.Text;

            int indexProject = ListProject.FindIndex(x => x.MaDA == ListMember[index].MaDA);
            if (indexProject != -1)
            {
                labUserProject.Text = SP.key(ListProject[indexProject]).Trim();
                rtxtProjectContent.Text = ListProject[indexProject].NoiDung;
            }
            else labUserProject.Text = rtxtProjectContent.Text = "NULL";

            int indexJob = ListJob.FindIndex(x => x.MaDA == ListMember[index].MaDA);
            if (indexProject != -1)
            {
                labUserJob.Text = SP.key(ListJob[indexJob]).Trim();
                rtxtJobContent.Text = ListJob[indexJob].NoiDung;

            }
            else labUserJob.Text = rtxtJobContent.Text = "NULL";

            labKeyPos.Text = ListMember[index].ChucVu;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (btnDetails.Text == "Details")
            {
                btnDetails.Text = "Hide";
                gbContent.Visible = true;
            }
            else
            {
                btnDetails.Text = "Details";
                gbContent.Visible = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AllController.clearAllData();
            AllController.SaveAllData(ListProject, ListJob, ListMember);

            MessageBox.Show("Đã Lưu Hoàn Thành");
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnHome_Click("", EventArgs.Empty);
            DialogResult dr = MessageBox.Show("Bạn có muốn cập nhật lại toàn bộ dữ liệu hay không ? Nhấn Cancel để hủy thoát", "Nhắc nhở",
                MessageBoxButtons.YesNoCancel);

            if (dr == DialogResult.Yes)
            {
                btnSave_Click("", EventArgs.Empty);
            }
            else if (dr == DialogResult.Cancel)
                e.Cancel = true;

        }

        private void rtxtOLabGoal_Leave(object sender, EventArgs e)
        {
            if(tempContent!=rtxtOLabGoal.Text)
            {
                int index = ListMember.FindIndex(x => x.MaTV == "TV0000");
                tempContent = ListMember[index].NoiDung = rtxtOLabGoal.Text;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn là Giám Đốc, Bạn xác nhận xóa hết tất cả dữ liệu công ty? Chọn Yes để xác nhân",
                "Cảnh Cáo",MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error );
            if (dr == DialogResult.Yes)
            {
                AllController.clearAllData();
                this.FormClosing -= frmMain_FormClosing;
                Close();
            }
        }
    }
}
