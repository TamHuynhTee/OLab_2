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
    public partial class frmJobForm : Form
    {
        List<Project> ListProject = new List<Project>();

        List<Job> ListJob = new List<Job>();

        List<Member> ListMember;
        List<Member> ListMemberFree = new List<Member>();
        List<Member> ListMemberAdd = new List<Member>();
        public Job returnJob;
        public int countMember = 0;
        public frmJobForm(string key, ref List<Member> LM, List<Job> LJ, List<Job> LJ2)
        {
            InitializeComponent();
            ListMember = LM;
            for (int i = 0; i < ListMember.Count; i++)
                if (ListMember[i].MaCV == null && ListMember[i].ChucVu.Contains("Nhân Viên"))
                {
                    ListMemberFree.Add(ListMember[i]);
                    ListMember.RemoveAt(i);
                    i--;
                }

            ListJob.AddRange(LJ);
            ListJob.AddRange(LJ2);

            cbProject.Text = key;
            cbProject.Enabled = false;
        }
        public frmJobForm(Project input, ref List<Member> LM, ref List<Job> LJ)
        {
            InitializeComponent();
            ListProject.Add(input);
            ListMember = LM;
            ListJob = LJ;
            cbProject.Items.Add(SP.key(input));

            cbProject.SelectedIndex = 0;
        }
        public frmJobForm(ref List<Project> LP, ref List<Member> LM, ref List<Job> LJ)
        {
            InitializeComponent();
            ListProject = LP;
            ListMember = LM;
            ListJob = LJ;
            foreach (Project run in LP)
                cbProject.Items.Add(SP.key(run));
        }
        //Form
        private string newID()
        {
            int id = 0;
            while (ListJob.Find(x => x.MaCV == ("CV" + new string('0', 4 - id.ToString().Length)
                + id.ToString())) != null)
            {
                id++;
            }
            return "CV" + new string('0', 4 - id.ToString().Length) + id.ToString();
        }
        private void frmJobForm_Load(object sender, EventArgs e)
        {
            txtID.Text = newID();
        }
        private void frmJobForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            clearForm();
        }
        // Add
        private Job collectForm()
        {
            Job newJob = new Job()
            {
                MaCV = txtID.Text,
                TenCV = txtName.Text,
                NoiDung = rtxtContent.Text,
                ThoiGian = dtpDate.Value,
                MaDA = SP.GetIDFromKey(cbProject.Text),
            };
            if (cbLeader.Text != "")
                newJob.MaNQL = SP.GetIDFromKey(cbLeader.Text);
            return newJob;
        }
        private void btnAddJob_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            bool isOkay = true;
            if (txtName.Text.Trim() == "")
            {
                errorProvider.SetError(txtName, "Tên không được để trống");
                isOkay = false;
            }
            if (DateTime.Compare(dtpDate.Value, DateTime.Now) <= 0)
            {
                errorProvider.SetError(dtpDate, "Thời gian không hợp lệ");
                isOkay = false;
            }
            if (cbProject.Text == "")
            {
                errorProvider.SetError(dtpDate, "Dự Án không được bỏ trống");
                isOkay = false;
            }

            if (isOkay)
            {
                returnJob = collectForm();
                ListJob.Add(returnJob);
                clearForm();

                if (cbProject.Enabled == false)
                {
                    Close();
                }
            }
        }
        private void btnClearForm_Click(object sender, EventArgs e)
        {
            clearForm();
        }
        private void clearForm()
        {
            txtID.Text = newID();
            txtName.Text = rtxtContent.Text = "";
            dtpDate.Value = DateTime.Now;
            lbMembers.Items.Clear();
            cbLeader.SelectedIndex = -1;
            labCountMember.Text = "<count: >";
            cbProject.SelectedIndex = -1;

            if (returnJob == null)
            {
                foreach (Member run in ListMemberAdd)
                {
                    run.MaCV = null;
                    run.ChucVu = "Nhân Viên";
                }
            }
            ListMember.AddRange(ListMemberFree);
            ListMember.AddRange(ListMemberAdd);
            ListMemberFree.Clear();
            ListMemberAdd.Clear();
        }

        // Member + Leader
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            lbMembers.Items.Clear();
            if (btnAddMember.Text == "ADD")
            {
                foreach (Member run in ListMemberFree)
                    lbMembers.Items.Add(SP.key(run));
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
                    if (ListMemberAdd[lbMembers.SelectedIndex].ChucVu == "Trưởng Dự Án")
                        MessageBox.Show("?");
                    ListMemberAdd[lbMembers.SelectedIndex].ChucVu = "Nhân Viên";
                    ListMemberAdd[lbMembers.SelectedIndex].MaCV = null;

                    ListMemberFree.Add(ListMemberAdd[lbMembers.SelectedIndex]);
                    ListMemberAdd.RemoveAt(lbMembers.SelectedIndex);
                    if (lbMembers.SelectedItem.ToString() == cbLeader.Text)
                    {
                        cbLeader.SelectedIndex = -1;
                    }
                }
                else
                {
                    ListMemberFree[lbMembers.SelectedIndex].MaCV = txtID.Text;

                    ListMemberAdd.Add(ListMemberFree[lbMembers.SelectedIndex]);
                    ListMemberFree.RemoveAt(lbMembers.SelectedIndex);
                }
                labCountMember.Text = "<count: " + ListMemberAdd.Count + ">";
                countMember = ListMemberAdd.Count;
                lbMembers.Items.RemoveAt(lbMembers.SelectedIndex);
                lbMembers.SelectedIndex = -1;
            }
        }
        private void cbLeader_DropDown(object sender, EventArgs e)
        {
            cbLeader.Items.Clear();
            foreach (Member run in ListMemberAdd)
                cbLeader.Items.Add(SP.key(run));
        }
        private void cbLeader_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLeader.SelectedIndex != -1)
                ListMemberAdd[cbLeader.SelectedIndex].ChucVu = "Trưởng Nhóm ";
        }

        // Project
        private void clearMemberTake()
        {
            foreach (Member run in ListMemberAdd)
            {
                run.ChucVu = "Nhân Viên";
                run.MaCV = null;
            }
            ListMember.AddRange(ListMemberAdd);
            ListMember.AddRange(ListMemberFree);
            ListMemberFree.Clear();
            ListMemberAdd.Clear();
            lbMembers.Items.Clear();
        }
        private void cbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProject.SelectedIndex != -1)
            {
                clearMemberTake();
                string MaDA = SP.GetIDFromKey(cbProject.SelectedItem.ToString());
                for (int i = 0; i < ListMember.Count; i++)
                    if (ListMember[i].MaDA == MaDA && ListMember[i].MaCV == null && ListMember[i].ChucVu.Contains("Nhân Viên"))
                    {
                        ListMemberFree.Add(ListMember[i]);
                        ListMember.RemoveAt(i);
                        i--;
                    }
                cbLeader.SelectedIndex = -1;
            }
        }

    }
}
