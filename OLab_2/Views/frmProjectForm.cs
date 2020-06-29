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
    public partial class frmProjectForm : Form
    {
        List<Project> ListProject;
        List<Job> ListJob;
        List<Job> ListJobAdd = new List<Job>();
        List<Member> ListMember;
        List<Member> ListMemberFree = new List<Member>();
        List<Member> ListMemberAdd = new List<Member>();
        Project returnProject;

        public frmProjectForm(ref List<Project> LP, ref List<Member> LM, ref List<Job> LJ)
        {
            InitializeComponent();
            ListProject = LP;
            ListJob = LJ;
            ListMember = LM;

            for (int i = 0; i < ListMember.Count; i++)
                if (ListMember[i].MaDA == null && ListMember[i].ChucVu.Trim() != "Giám Đốc")
                {
                    ListMemberFree.Add(ListMember[i]);
                    ListMember.RemoveAt(i);
                    i--;
                }
        }

        //Form
        private string newID()
        {
            int id = 0;
            while (ListProject.Find(x => x.MaDA == ("DA" + new string('0', 4 - id.ToString().Length)
                + id.ToString())) != null)
            {
                id++;
            }
            return "DA" + new string('0', 4 - id.ToString().Length) + id.ToString();
        }
        private void frmProjectForm_Load(object sender, EventArgs e)
        {
            txtID.Text = newID();
        }
        private void frmProjectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            clearForm(true);
        }
        // Add
        private void btnAddProject_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            bool isOkay = true;
            if (txtName.Text.Trim() == "")
            {
                errorProvider.SetError(txtName, "Tên không được bỏ trống");
                isOkay = false;
            }
            if (DateTime.Compare(dtpDate.Value, DateTime.Now) <= 0)
            {
                errorProvider.SetError(dtpDate, "Thời gian không hợp lệ");
                isOkay = false;
            }

            if (isOkay)
            {
                returnProject = collectForm();
                ListProject.Add(returnProject);
                clearForm(false); 
            }
        }
        private void btnClearForm_Click(object sender, EventArgs e)
        {
            clearForm(false);
        }
        private void clearForm(bool back)
        {
            txtID.Text = newID();
            txtName.Text = rtxtContent.Text = "";
            cbLeader.SelectedIndex = -1;
            lbJobs.Items.Clear();
            lbMembers.Items.Clear();
            btnAddMember.Text = "ADD";
            dtpDate.Value = DateTime.Now;

            labCountMember.Text = "<count: >";
            labCountJob.Text = "<count: >";

            if (returnProject == null)
            {
                ListJobAdd.Clear();
                foreach (Member run in ListMemberAdd)
                {
                    run.MaDA = null;
                    run.MaCV = null;
                    run.ChucVu = "Nhân Viên";
                }
                ListMemberFree.AddRange(ListMemberAdd);
                ListMemberAdd.Clear();
            }
            ListMember.AddRange(ListMemberAdd);
            ListMemberAdd.Clear();
            ListJob.AddRange(ListJobAdd);
            ListJobAdd.Clear();
            if (back)
            {
                ListMember.AddRange(ListMemberFree);
            }
        }

        private Project collectForm()
        {
            Project temp = new Project()
            {
                MaDA = txtID.Text,
                TenDA = txtName.Text,
                NoiDung = rtxtContent.Text,
                ThoiGian = dtpDate.Value,
            };
            if (cbLeader.Text != "")
                temp.MaNQL = SP.GetIDFromKey(cbLeader.Text);
            return temp;
        }

        //Member
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            lbMembers.Items.Clear();
            if (btnAddMember.Text == "ADD")
            {
                foreach (Member run in ListMemberFree)
                    if (run.MaDA == null)
                    {
                        lbMembers.Items.Add(SP.key(run));
                    }
                btnAddMember.Text = "DONE";
            }
            else
            {
                foreach (Member run in ListMemberAdd)
                    lbMembers.Items.Add(SP.key(run));
                btnAddMember.Text = "ADD";
            }
        }
        private void lbMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbMembers.SelectedIndex != -1)
            {
                if (btnAddMember.Text == "ADD")
                {
                    ListMemberAdd[lbMembers.SelectedIndex].ChucVu = "Nhân Viên";
                    ListMemberAdd[lbMembers.SelectedIndex].MaDA = null;
                    if (ListMemberAdd[lbMembers.SelectedIndex].MaCV != null)
                    {
                        int jobIndex = ListJobAdd.FindIndex(x => x.MaCV == ListMemberAdd[lbMembers.SelectedIndex].MaCV);
                        string[] temp = lbJobs.Items[jobIndex].ToString().Split('|');
                        string newJobItem = temp[0] + '|' + (Convert.ToInt32(temp[1]) - 1).ToString();
                        lbJobs.Items[jobIndex] = newJobItem;
                        ListMemberAdd[lbMembers.SelectedIndex].MaCV = null;
                    }

                    ListMemberFree.Add(ListMemberAdd[lbMembers.SelectedIndex]);
                    ListMemberAdd.RemoveAt(lbMembers.SelectedIndex);
                    if (lbMembers.SelectedItem.ToString() == cbLeader.Text)
                    {
                        cbLeader.SelectedIndex = -1;
                    }
                }
                else
                {
                    ListMemberFree[lbMembers.SelectedIndex].MaDA = txtID.Text;
                    ListMemberAdd.Add(ListMemberFree[lbMembers.SelectedIndex]);
                    ListMemberFree.RemoveAt(lbMembers.SelectedIndex);
                }
                labCountMember.Text = "<count: " + ListMemberAdd.Count + ">";
                lbMembers.Items.RemoveAt(lbMembers.SelectedIndex);
                lbMembers.SelectedIndex = -1;
            }
        }

        private void cbLeader_DropDown(object sender, EventArgs e)
        {
            cbLeader.Items.Clear();
            foreach (Member run in ListMemberAdd)
                if (run.MaCV == null)
                    cbLeader.Items.Add(SP.key(run));
        }
        private void cbLeader_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLeader.SelectedIndex != -1)
            {
                string MaTV = SP.GetIDFromKey(cbLeader.Text);
                int indexLeader = ListMemberAdd.FindIndex(x => x.MaTV == MaTV);
                ListMemberAdd[indexLeader].ChucVu = "Trưởng Dự Án";
            }
        }

        //Job
        private void btnAddJob_Click(object sender, EventArgs e)
        {
            frmJobForm newJob = new frmJobForm('[' + txtID.Text + ']' + txtName.Text, ref ListMemberAdd, ListJob, ListJobAdd);
            newJob.ShowDialog();
            if (newJob.returnJob != null)
            {
                ListJobAdd.Add(newJob.returnJob);
                lbJobs.Items.Add(SP.key(newJob.returnJob) + '|' + newJob.countMember);
                labCountJob.Text = "<count: " + lbJobs.Items.Count + ">";
            }
        }

        private void lbJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbJobs.SelectedIndex != -1)
            {
                foreach (Member run in ListMemberAdd)
                    if (run.MaCV == ListJobAdd[lbJobs.SelectedIndex].MaCV)
                    {
                        if (run.ChucVu == "Trưởng Dự Án")
                            MessageBox.Show("?");
                        run.ChucVu = "Nhân Viên";
                        run.MaCV = null;
                    }
                ListJobAdd.RemoveAt(lbJobs.SelectedIndex);
                lbJobs.Items.RemoveAt(lbJobs.SelectedIndex);
                labCountJob.Text = "<count: " + lbJobs.Items.Count + ">";
                lbJobs.SelectedIndex = -1;
            }
        }


    }
}
