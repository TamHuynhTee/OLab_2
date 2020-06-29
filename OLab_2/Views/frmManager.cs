using OLab_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OLab_2.Views
{
    public partial class frmManager : Form
    {
        List<Job> ListJobParent = new List<Job>();

        List<Project> ListProject;
        List<Member> ListMember;
        List<Job> ListJob = new List<Job>();

        List<Project> ListProjectShow = new List<Project>();
        List<Member> ListMemberShow = new List<Member>();
        List<Job> ListJobShow = new List<Job>();

        Member Login;

        public frmManager(ref List<Project> LP, ref List<Member> LM, ref List<Job> LJ, string input)
        {
            InitializeComponent();
            Login = LM.Find(x => x.MaTV == input);

            colMemLevel.Items.Add("Cử Nhân     ");
            colMemLevel.Items.Add("Thạc Sĩ     ");
            colMemLevel.Items.Add("Tiến Sĩ     ");
            colMemLevel.Items.Add("PGS. Tiến Sĩ");
            colMemLevel.Items.Add("GS. Tiến Sĩ ");

            colMemPosition.Items.Add("Nhân Viên   ");
            colMemPosition.Items.Add("Trưởng Nhóm ");
            colMemPosition.Items.Add("Trưởng Dự Án");
            colMemPosition.Items.Add("Giám Đốc    ");

            colProID.DataPropertyName = nameof(Project.MaDA);
            colProName.DataPropertyName = nameof(Project.TenDA);
            colProContent.DataPropertyName = nameof(Project.NoiDung);
            colProDate.DataPropertyName = nameof(Project.ThoiGian);
            colProProgress.DataPropertyName = nameof(Project.TienDo);


            colJobID.DataPropertyName = nameof(Job.MaCV);
            colJobName.DataPropertyName = nameof(Job.TenCV);
            colJobContent.DataPropertyName = nameof(Job.NoiDung);
            colJobDate.DataPropertyName = nameof(Job.ThoiGian);
            colJobDone.DataPropertyName = nameof(Job.HoanThanh);


            colMemID.DataPropertyName = nameof(Member.MaTV);
            colMemName.DataPropertyName = nameof(Member.TenTV);
            colMemWork.DataPropertyName = nameof(Member.NoiDung);
            colMemPosition.DataPropertyName = nameof(Member.ChucVu);
            colMemLevel.DataPropertyName = nameof(Member.HocVan);

            switch (Login.ChucVu.Trim())
            {
                case "Giám Đốc":
                    ListProjectShow = LP; ListMember = LM; ListJob = LJ;
                    break;
                case "Trưởng Dự Án":
                    ListProject = LP; ListMember = LM; ListJob = LJ;
                    int index = ListProject.FindIndex(x => x.MaDA == Login.MaDA);
                    ListProjectShow.Add(ListProject[index]);
                    ListProject.RemoveAt(index);
                    colMemPosition.Items.RemoveAt(3);
                    break;
                case "Trưởng Nhóm":
                    ListProject = LP; ListMember = LM; ListJobParent = LJ;
                    int indexPrj = ListProject.FindIndex(x => x.MaDA == Login.MaDA);
                    ListProjectShow.Add(ListProject[indexPrj]);
                    ListProject.RemoveAt(indexPrj);
                    int indexJob = ListJobParent.FindIndex(x => x.MaCV == Login.MaCV);
                    ListJob.Add(ListJobParent[indexJob]);
                    ListJobParent.RemoveAt(indexJob);
                    colMemPosition.Items.RemoveAt(3);
                    colMemPosition.Items.RemoveAt(2);
                    dgvProject.Visible = false;
                    break;
            }


            dgvMember.DataError += DgvMember_DataError;
        }
        private void DgvMember_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        // FORM
        private void frmManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Login.ChucVu.Trim() != "Giám Đốc")
                ListProject.AddRange(ListProjectShow);

            refillJob();
            refillMember();

            if (Login.ChucVu.Trim() == "Trưởng Nhóm")
                ListJobParent.AddRange(ListJob);
        }
        private void frmManager_Load(object sender, EventArgs e)
        {
            fillDataToDGV("Project");

            switch (Login.ChucVu.Trim())
            {
                case "Giám Đốc":
                    dgvProject.Visible = dgvJob.Visible = dgvMember.Visible = true;
                    cbMemberType.SelectedIndex = 0;
                    cbJobType.SelectedIndex = 0;
                    break;
                case "Trưởng Dự Án":
                    dgvJob.Visible = dgvMember.Visible = true;
                    searchProject(Login.MaDA);
                    labSelectedProject.Text = Login.MaDA;
                    cbJobType.Enabled = false;
                    break;
                case "Trưởng Nhóm":
                    dgvMember.Visible = true;
                    searchProject(Login.MaDA);
                    searchJob(Login.MaCV);
                    labSelectedProject.Text = Login.MaDA;
                    cbJobType.Enabled = false;
                    cbMemberType.Enabled = false;
                    break;
            }
        }

        // SUPPORT
        string nameTemp;
        Form childForm = null;
        private void setAmount(Label input, int number)
        {
            input.Text = "[ " + number.ToString() + " ]";
        }
        private void fillDataToDGV(string type)
        {
            BindingSource bs = new BindingSource();
            if (type == "Project")
            {
                dtpDate.Visible = false;
                bs.DataSource = ListProjectShow;
                dgvProject.DataSource = bs;
                setAmount(labAmountProject, ListProjectShow.Count);
                labSelectedProject.Text = "";
            }
            else if (type == "Job")
            {
                dtpDate.Visible = false;
                bs.DataSource = ListJobShow;
                dgvJob.DataSource = bs;
                setAmount(labAmountJob, ListJobShow.Count);
                labSelectedJob.Text = "";

            }
            else if (type == "Member")
            {
                bs.DataSource = ListMemberShow;
                dgvMember.DataSource = bs;
                setAmount(labAmountMember, ListMemberShow.Count);
                labSelectedMember.Text = "";

            }
        }
        private void fullCellWithControl(Control ctl, Rectangle rect, DataGridView dgv)
        {
            dgv.Controls.Add(ctl);
            ctl.Location = new Point(rect.X, rect.Y);
            ctl.Size = new Size(rect.Width, rect.Height);
            ctl.Visible = true;
            ctl.Focus();
        }
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDate.Visible == true)
            {
                if (dgvProject.Controls.Contains(dtpDate))
                {
                    dgvProject.CurrentCell.Value = dtpDate.Value;
                }
                else dgvJob.CurrentCell.Value = dtpDate.Value;
                dtpDate.Visible = false;
            }
        }

        private void closeChildForm()
        {
            if (childForm != null)
            {
                pnForm.Controls.Remove(childForm);
                childForm.Dispose();
                childForm = null;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (childForm != null)
            {
                if (childForm.Text == "Project")
                {
                    frmProjectInfo temp = childForm as frmProjectInfo;
                    int index = ListProjectShow.FindIndex(x => x.MaDA == temp.main.MaDA);

                    if (temp.deleteNumber == 1)
                    {
                        if (ListProjectShow.Contains(temp.main))
                            deleteProject(temp.main.MaDA);
                        closeChildForm();
                    }
                    else if (temp.checkChange() == true)
                    {
                        if (index != -1)
                        {
                            ListProjectShow[index] = temp.main;
                        }

                        dgvProject.Refresh();
                    }
                }
                else if (childForm.Text == "Job")
                {
                    frmJobInfo temp = childForm as frmJobInfo;
                    if (temp.deleteNumber == 1)
                    {
                        deleteJob(temp.main.MaCV);
                        closeChildForm();
                    }
                    else
                    {
                        int cc = temp.checkChange();
                        if (cc != 0)
                        {
                            int index = ListJob.FindIndex(x => x.MaCV == temp.main.MaCV);
                            if (index != -1)
                            {
                                ListJob[index] = temp.main;
                                if (cc == 2)
                                {
                                    int indexPrj = ListProjectShow.FindIndex(x => x.MaDA == ListJob[index].MaDA);
                                    if (ListProjectShow[indexPrj].HoanThanh != true)
                                    {
                                        ListProjectShow.Find(x => x.MaDA == ListJob[index].MaDA).TienDo = checkProgress(ListJob[index].MaDA);
                                        dgvProject.Refresh();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Dự Án đã ký kết, phải hủy ký mới thay đổi Công việc được");
                                        ListJob[index].HoanThanh = true;
                                    }
                                }
                            }
                            else
                            {
                                index = ListJobShow.FindIndex(x => x.MaCV == temp.main.MaCV);
                                if (index == -1)
                                    return;
                                ListJobShow[index] = temp.main;

                                if (cc == 2)
                                {
                                    int indexPrj = ListProjectShow.FindIndex(x => x.MaDA == ListJobShow[index].MaDA);
                                    if (ListProjectShow[indexPrj].HoanThanh != true)
                                    {
                                        ListProjectShow.Find(x => x.MaDA == ListJobShow[index].MaDA).TienDo = checkProgress(ListJobShow[index].MaDA);
                                        dgvProject.Refresh();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Dự Án đã ký kết, phải hủy ký mới thay đổi Công việc được");
                                        ListJobShow[index].HoanThanh = true;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    bool isClose = false;
                    bool isChange = false;
                    frmMemberInfo temp = childForm as frmMemberInfo;

                    if (temp.deleteNumber == 1)
                    {
                        if (temp.main.MaTV == Login.MaTV)
                        {
                            MessageBox.Show("Bạn không thể tự Out");
                            return;
                        }
                        deleteMember(temp.main);
                        isClose = true;
                    }
                    else if (temp.deleteNumber == 2)
                    {
                        if (temp.main.MaTV == Login.MaTV)
                        {
                            MessageBox.Show("Bạn không thể tự Out");
                            return;
                        }
                        breakMemberFromProject(temp.main);
                        temp.main.MaCV = null;
                        temp.main.MaDA = null;
                        temp.main.ChucVu = "Nhân Viên   ";
                        isChange = true;
                        isClose = true;
                    }
                    else if (temp.deleteNumber == 3)
                    {
                        if (temp.main.MaTV == Login.MaTV)
                        {
                            MessageBox.Show("Bạn không thể tự Out");
                            return;
                        }
                        breakMemberFromJob(temp.main);
                        temp.main.MaCV = null;
                        temp.main.ChucVu = "Nhân Viên   ";
                        isChange = true;
                        isClose = true;
                    }
                    if (temp.checkChange() == true || isChange == true)
                    {
                        int index = ListMember.FindIndex(x => x.MaTV == temp.main.MaTV);
                        if (index != -1)
                        {
                            ListMember[index] = temp.main;
                        }
                        else
                        {
                            index = ListMemberShow.FindIndex(x => x.MaTV == temp.main.MaTV);
                            if (index != -1)
                            {
                                ListMemberShow[index] = temp.main;
                                if (isChange == true)
                                {
                                    index = cbMemberType.SelectedIndex;
                                    cbMemberType.SelectedIndex = -1;
                                    cbMemberType.SelectedIndex = index;
                                }
                                else dgvMember.Refresh();

                            }
                        }
                        if (temp.main.MaTV == Login.MaTV)
                        {
                            Login = temp.main;
                        }
                    }
                    if (isClose)
                        closeChildForm();
                }

            }
        }

        private void showChildForm(Form input)
        {
            pnForm.Visible = false;

            if (childForm != null)
                btnUpdate_Click("", EventArgs.Empty);
            closeChildForm();

            childForm = input;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnForm.Controls.Add(childForm);
            pnForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            pnForm.Visible = true;
        }
        // DGV PROJECT
        private double checkProgress(string MaDA)
        {
            int TatCa = ListJobShow.Count(x => x.MaDA == MaDA) + ListJob.Count(x => x.MaDA == MaDA) + ListJobParent.Count(x => x.MaDA == MaDA);
            int HoanThanh = ListJobShow.Count(x => (x.MaDA == MaDA) && (x.HoanThanh == true)) + ListJob.Count(x => (x.MaDA == MaDA) && (x.HoanThanh == true))
                + ListJobParent.Count(x => (x.MaDA == MaDA) && (x.HoanThanh == true));
            return 100 * (double)HoanThanh / TatCa;
        }
        private void deleteProject(string MaDA)
        {
            foreach (Member run in ListMember)
                if (run.MaDA == MaDA)
                {
                    run.MaCV = null;
                    run.MaDA = null;
                    run.ChucVu = "Nhân Viên   ";
                }
            foreach (Member run in ListMemberShow)
                if (run.MaDA == MaDA)
                {
                    run.MaCV = null;
                    run.MaDA = null;
                    run.ChucVu = "Nhân Viên   ";
                }
            for (int i = 0; i < ListJob.Count; i++)
                if (ListJob[i].MaDA == MaDA)
                {
                    ListJob.RemoveAt(i);
                    i--;
                }
            for (int i = 0; i < ListJobShow.Count; i++)
                if (ListJobShow[i].MaDA == MaDA)
                {
                    ListJobShow.RemoveAt(i);
                    i--;
                }
            ListProjectShow.RemoveAt(ListProjectShow.FindIndex(x => x.MaDA == MaDA));
            fillDataToDGV("Project");

            cbJobType.SelectedIndex = -1;
            cbJobType.SelectedIndex = 0;
            cbMemberType.SelectedIndex = -1;
            cbMemberType.SelectedIndex = 0;
        }
        private string projectID()
        {
            int id = 0;
            while (ListProjectShow.Find(x => x.MaDA == ("DA" + new string('0', 4 - id.ToString().Length)
            + id.ToString())) != null)
            {
                id++;
            }
            return "DA" + new string('0', 4 - id.ToString().Length) + id.ToString();
        }
        private void dgvProject_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            labSelectedProject.Text = dgvProject.CurrentRow.Cells[0].Value.ToString();
            searchProject(labSelectedProject.Text);

            showChildForm(new frmProjectInfo(ListProjectShow[dgvProject.CurrentRow.Index], ListJobShow.Count, ListMemberShow.Count, Login.ChucVu.Trim(), Login.MaTV));
        }
        private void btnAddProject_Click(object sender, EventArgs e)
        {
            ListProjectShow.Add(new Project()
            {
                MaDA = projectID(),
                TenDA = "NEW PROJECT",
                ThoiGian = DateTime.Now,
            });

            fillDataToDGV("Project");
        }
        private void dgvProject_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn loại Project này khỏi Job, Việc này ảnh hưởng tới tất cả nhân viên có trong Project", "Cảnh báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                deleteProject(ListProjectShow[dgvProject.CurrentCell.RowIndex].MaDA);
                cbJobType.SelectedIndex = 0;
                cbMemberType.SelectedIndex = 0;
            }
        }
        private void dgvProject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtpDate.Visible = false;
            if (dgvProject.Columns[dgvProject.CurrentCell.ColumnIndex].DataPropertyName == "ThoiGian") // name of(Job.ThoiGian,Project.ThoiGian)
            {
                dtpDate.Value = Convert.ToDateTime(dgvProject.CurrentCell.Value);
                Rectangle rect = dgvProject.GetCellDisplayRectangle(dgvProject.CurrentCell.ColumnIndex, dgvProject.CurrentCell.RowIndex, true);
                fullCellWithControl(dtpDate, rect, dgvProject);
            }
            else if (dgvProject.Columns[dgvProject.CurrentCell.ColumnIndex].DataPropertyName == nameof(Project.TenDA))
            {
                nameTemp = ListProjectShow[dgvProject.CurrentCell.RowIndex].TenDA;
            }
            labSelectedProject.Text = dgvProject.CurrentRow.Cells[0].Value.ToString();
        }
        private void dgvProject_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProject.Columns[dgvProject.CurrentCell.ColumnIndex].DataPropertyName == nameof(Project.TenDA))
            {
                if (dgvProject.CurrentCell.Value == null || dgvProject.CurrentCell.Value.ToString().Trim() == "")
                {
                    MessageBox.Show("Tên không được bỏ trống");
                    dgvProject.CurrentCell.Value = nameTemp;
                }
            }
        }

        // DGV JOB
        // Job Type
        bool? isDoneTemp;
        private string jobID()
        {
            int id = 0;
            while (ListJob.Find(x => x.MaCV == ("CV" + new string('0', 4 - id.ToString().Length)
                + id.ToString())) != null || ListJobShow.Find(x => x.MaCV == ("CV" + new string('0', 4 - id.ToString().Length)
                + id.ToString())) != null)
            {
                id++;
            }
            return "CV" + new string('0', 4 - id.ToString().Length) + id.ToString();
        }
        private void refillJob()
        {
            ListJob.AddRange(ListJobShow);
            ListJobShow.Clear();
        }
        private void deleteJob(string MaCV)
        {
            foreach (Member run in ListMember)
                if (run.MaCV == MaCV)
                {
                    run.MaCV = null;
                    run.ChucVu = "Nhân Viên   ";
                }
            foreach (Member run in ListMemberShow)
                if (run.MaCV == MaCV)
                {
                    run.MaCV = null;
                    run.ChucVu = "Nhân Viên   ";
                }
            if (ListJobShow.Remove(ListJobShow.Find(x => x.MaCV == MaCV)) == false)
            {
                ListJob.Remove(ListJobShow.Find(x => x.MaCV == MaCV));
            }
            else fillDataToDGV("Job");
        }
        private void cbJobType_SelectedIndexChanged(object sender, EventArgs e)
        {
            refillJob();
            switch (cbJobType.SelectedIndex)
            {
                case 0: //  Company
                    if (Login.ChucVu.Trim() == "Trưởng Dự Án" && cbMemberType.DroppedDown == true)
                        cbMemberType.SelectedIndex = 2;
                    labJobProject.Text = "[PRJ:]";

                    ListJobShow.AddRange(ListJob);
                    ListJob.Clear();
                    btnAddJob.Visible = false;
                    break;
                case 1: //Project
                    if (ListProjectShow.Count > 0  && dgvProject.Rows[dgvProject.CurrentCell.RowIndex].Cells[0].Value != null)
                    {
                        string MaDA = dgvProject.CurrentRow.Cells[0].Value.ToString();
                        labJobProject.Text = "[PRJ:" + MaDA + "]";

                        ListJobShow.AddRange(ListJob.FindAll(x => x.MaDA == MaDA));
                        ListJob.RemoveAll(x => x.MaDA == MaDA);
                        btnAddJob.Visible = true;
                    }
                    break;
                case 2: //DONE
                    if (Login.ChucVu.Trim() == "Trưởng Dự Án" && cbMemberType.DroppedDown == true)
                        cbMemberType.SelectedIndex = 2;
                    labJobProject.Text = "[PRJ:]";

                    ListJobShow.AddRange(ListJob.FindAll(x => x.HoanThanh == true));
                    ListJob.RemoveAll(x => x.HoanThanh == true);
                    btnAddJob.Visible = false;
                    break;
            }
            fillDataToDGV("Job");
            if (ListJobShow.Count > 0)
                labSelectedJob.Text = dgvJob.CurrentRow.Cells[0].Value.ToString();
        }
        private void dgvJob_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            labSelectedJob.Text = dgvJob.CurrentRow.Cells[0].Value.ToString();
            if (cbJobType.SelectedIndex == 1)
                searchJob(labSelectedJob.Text);
            else
            {
                string MaCV = labSelectedJob.Text;
                string MaDA = ListJobShow[dgvJob.CurrentCell.RowIndex].MaDA;

                searchProject(MaDA);
                searchJob(MaCV);
            }
            showChildForm(new frmJobInfo(ListJobShow[dgvJob.CurrentCell.RowIndex], ListMemberShow.Count, Login.ChucVu.Trim(), Login.MaTV));
        }
        private void btnAddJob_Click(object sender, EventArgs e)
        {
            ListJobShow.Add(new Job()
            {
                MaCV = jobID(),
                MaDA = dgvProject[0, dgvProject.CurrentCell.RowIndex].Value.ToString(),
                TenCV = "NEW JOB",
                ThoiGian = DateTime.Now,
            });

            fillDataToDGV("Job");
        }
        private void dgvJob_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn loại Job này khỏi Project, Việc này ảnh hưởng tới tất cả nhân viên có trong Job", "Cảnh báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                deleteJob(dgvJob.Rows[dgvJob.CurrentCell.RowIndex].Cells[0].Value.ToString());
                cbMemberType.SelectedIndex = 2;
            }
        }
        private void dgvJob_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtpDate.Visible = false;
            if (dgvJob.Columns[dgvJob.CurrentCell.ColumnIndex].DataPropertyName == "ThoiGian") // name of(Job.ThoiGian,Project.ThoiGian)
            {
                dtpDate.Value = Convert.ToDateTime(dgvJob.CurrentCell.Value);
                Rectangle rect = dgvJob.GetCellDisplayRectangle(dgvJob.CurrentCell.ColumnIndex, dgvJob.CurrentCell.RowIndex, true);
                fullCellWithControl(dtpDate, rect, dgvJob);
            }
            else if (dgvJob.Columns[dgvJob.CurrentCell.ColumnIndex].DataPropertyName == nameof(Job.TenCV))
            {
                nameTemp = ListJobShow[dgvJob.CurrentCell.RowIndex].TenCV;
            }
            else if (dgvJob.Columns[dgvJob.CurrentCell.ColumnIndex].DataPropertyName == nameof(Job.HoanThanh))
            {
                isDoneTemp = ListJobShow[dgvJob.CurrentCell.RowIndex].HoanThanh;
            }
            labSelectedJob.Text = dgvJob.CurrentRow.Cells[0].Value.ToString();
        }
        private void dgvJobAndProject_Resize(object sender, EventArgs e)
        {
            if (dtpDate.Visible == true)
            {
                if (dgvJob.Controls.Contains(dtpDate))
                {
                    Rectangle rect = dgvJob.GetCellDisplayRectangle(dgvJob.CurrentCell.ColumnIndex, dgvJob.CurrentCell.RowIndex, true);
                    fullCellWithControl(dtpDate, rect, dgvJob);
                }
                else
                {
                    Rectangle rect = dgvProject.GetCellDisplayRectangle(dgvProject.CurrentCell.ColumnIndex, dgvProject.CurrentCell.RowIndex, true);
                    fullCellWithControl(dtpDate, rect, dgvProject);
                }
            }
        }
        private void dgvJob_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvJob.Columns[dgvJob.CurrentCell.ColumnIndex].DataPropertyName == nameof(Job.TenCV))
            {
                if (dgvJob.CurrentCell.Value == null || dgvJob.CurrentCell.Value.ToString().Trim() == "")
                {
                    MessageBox.Show("Tên không được bỏ trống");
                    dgvJob.CurrentCell.Value = nameTemp;
                }
            }
            else if (dgvJob.Columns[dgvJob.CurrentCell.ColumnIndex].DataPropertyName == nameof(Job.HoanThanh))
            {
                if (isDoneTemp != ListJobShow[dgvJob.CurrentCell.RowIndex].HoanThanh)
                {
                    if (ListJobShow[dgvJob.CurrentCell.RowIndex].HoanThanh == true)
                    {
                        Image.FromFile(@"Images\" + Login.MaTV + "SIGN.jpg").Save(@"Images\" + ListJobShow[dgvJob.CurrentCell.RowIndex].MaCV + ".jpg");
                    }
                    if (ListProjectShow.Find(x => x.MaDA == ListJobShow[dgvJob.CurrentCell.RowIndex].MaDA).HoanThanh == true)
                    {
                        MessageBox.Show("Dự Án đã ký kết, phải hủy ký kết mới có thể thay đổi độ hoàn thành công việc được");
                        ListJobShow[dgvJob.CurrentCell.RowIndex].HoanThanh = true;
                        dgvJob.Refresh();
                    }
                    else
                    {
                        ListProjectShow.Find(x => x.MaDA == ListJobShow[dgvJob.CurrentCell.RowIndex].MaDA).TienDo
                            = checkProgress(ListJobShow[dgvJob.CurrentCell.RowIndex].MaDA);
                        dgvProject.Refresh();
                    }
                }
            }
        }


        // DGV MEMBER
        // Member Type
        bool MemberDrop = false;
        string ChucVu;
        private void refillMember()
        {
            ListMember.AddRange(ListMemberShow);
            ListMemberShow.Clear();
        }
        private void cbMemberType_DropDown(object sender, EventArgs e)
        {
            MemberDrop = true;
        }
        private void cbMemberType_Leave(object sender, EventArgs e)
        {
            MemberDrop = false;
        }
        private void cbMemberType_SelectedIndexChanged(object sender, EventArgs e)
        {
            refillMember();
            loadMemberController(cbMemberType.SelectedIndex);

            string MaDA = "";
            string MaCV = "";
            switch (cbMemberType.SelectedIndex)
            {
                case 0: //  Company
                    if (Login.ChucVu.Trim() == "Trưởng Dự Án" && MemberDrop == true)
                    {
                        cbMemberType.SelectedIndex = 2;
                        return;
                    }
                    ListMemberShow.AddRange(ListMember);
                    ListMember.Clear();
                    break;
                case 1: // Free in Olab
                    if (Login.ChucVu.Trim() == "Trưởng Dự Án" && MemberDrop == true)
                    {
                        cbMemberType.SelectedIndex = 2;
                        return;
                    }
                    labMemberProject.Text = "[PRJ:]";
                    labMemberJob.Text = "[JOB:]";

                    ListMemberShow.AddRange(ListMember.FindAll(x => (x.MaDA == null) && (x.ChucVu.Trim() == "Nhân Viên")));
                    ListMember.RemoveAll(x => (x.MaDA == null) && (x.ChucVu.Trim() == "Nhân Viên"));

                    break;
                case 2: // Project
                    if (Login.ChucVu.Trim() == "Trưởng Nhóm" && MemberDrop == true)
                    {
                        cbMemberType.SelectedIndex = 4;
                        return;
                    }
                    if (ListProjectShow.Count > 0 && dgvProject.Rows[dgvProject.CurrentCell.RowIndex].Cells[0].Value != null)
                    {
                        MaDA = dgvProject.CurrentRow.Cells[0].Value.ToString();

                        ListMemberShow.AddRange(ListMember.FindAll(x => x.MaDA == MaDA));
                        ListMember.RemoveAll(x => x.MaDA == MaDA);
                    }
                    break;
                case 3: // Free in Project
                    if (Login.ChucVu.Trim() == "Trưởng Nhóm" && MemberDrop == true)
                    {
                        cbMemberType.SelectedIndex = 4;
                        return;
                    }
                    if (ListProjectShow.Count > 0 && dgvProject.Rows[dgvProject.CurrentCell.RowIndex].Cells[0].Value != null)
                    {
                        MaDA = dgvProject.CurrentRow.Cells[0].Value.ToString();

                        ListMemberShow.AddRange(ListMember.FindAll(x => (x.MaDA == MaDA) && (x.MaCV == null) && (x.ChucVu.Trim() == "Nhân Viên")));
                        ListMember.RemoveAll(x => (x.MaDA == MaDA) && (x.MaCV == null) && (x.ChucVu.Trim() == "Nhân Viên"));
                    }
                    break;
                case 4: // Job
                    if (ListJobShow.Count > 0 && dgvJob.Rows[dgvJob.CurrentCell.RowIndex].Cells[0].Value != null)
                    {
                        MaDA = dgvProject.CurrentRow.Cells[0].Value.ToString();
                        MaCV = dgvJob.CurrentRow.Cells[0].Value.ToString();

                        ListMemberShow.AddRange(ListMember.FindAll(x => x.MaCV == MaCV));
                        ListMember.RemoveAll(x => x.MaCV == MaCV);
                    }
                    break;
            }
            labMemberProject.Text = "[PRJ:" + MaDA + "]";
            labMemberJob.Text = "[JOB:" + MaCV + "]";
            fillDataToDGV("Member");
            if (ListMemberShow.Count > 0)
                labSelectedMember.Text = dgvMember.CurrentRow.Cells[0].Value.ToString();
            MemberDrop = false;
        }
        private void deleteMember(Member TV)
        {
            bool ok = ListMember.Remove(TV);
            if (ok == false)
            {
                ok = ListMemberShow.Remove(TV);
                fillDataToDGV("Member");
            }
            if (ok == true)
            {
                breakMemberFromProject(TV);
            }
        }
        private void breakMemberFromJob(Member input)
        {
            string MaTV = input.MaTV;
            if (input.ChucVu.Trim() == "Trưởng Nhóm")
            {
                int index = ListJobShow.FindIndex(x => x.MaNQL == MaTV);
                if (index != -1)
                {
                    ListJobShow[index].MaNQL = null;
                    dgvJob.Refresh();
                }
                else
                {
                    index = ListJob.FindIndex(x => x.MaNQL == MaTV);
                    ListJob[index].MaNQL = null;
                }
            }
        }
        private void breakMemberFromProject(Member input)
        {
            if (input.ChucVu.Trim() == "Trưởng Dự Án")
            {
                string MaTV = input.MaTV;
                ListProjectShow.Find(x => x.MaNQL == MaTV).MaNQL = null;
            }
            breakMemberFromJob(input);
        }
        private void dgvMember_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            labSelectedMember.Text = dgvMember.CurrentRow.Cells[0].Value.ToString();
            if (cbMemberController.SelectedIndex == 0)
            {
                if (cbMemberType.SelectedIndex == 4 || cbMemberType.SelectedIndex == 3)
                    searchMember(labSelectedMember.Text);
                else
                {
                    string MaTV = labSelectedMember.Text;
                    int index = ListMemberShow.FindIndex(x => x.MaTV == MaTV);

                    string MaCV = ListMemberShow[index].MaCV;
                    string MaDA = ListMemberShow[index].MaDA;

                    if (MaDA != null)
                    {
                        searchProject(MaDA);
                        if (MaCV != null)
                            searchJob(MaCV);
                    }
                    searchMember(MaTV);
                }
                showChildForm(new frmMemberInfo(ListMemberShow[dgvMember.CurrentCell.RowIndex], Login.ChucVu.Trim()));
            }
            else
            {
                int index = dgvMember.CurrentCell.RowIndex;
                bool isDelete = false;
                DialogResult dr;
                switch (cbMemberController.SelectedItem)
                {
                    case "Remove from OLab":
                        dr = MessageBox.Show("Bạn có chắc muốn loại người này khỏi OLab", "Cảnh báo", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            breakMemberFromProject(ListMemberShow[index]);
                            isDelete = true;
                        }
                        else return;
                        break;
                    case "Remove from Project":
                        dr = MessageBox.Show("Bạn có chắc muốn loại người này khỏi Project", "Cảnh báo", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            breakMemberFromProject(ListMemberShow[index]);
                            ListMemberShow[index].MaDA = ListMemberShow[index].MaCV = null;
                        }
                        else return;
                        break;
                    case "Add to select Project":

                        ListMemberShow[dgvMember.CurrentCell.RowIndex].MaDA = ListProjectShow[dgvProject.CurrentCell.RowIndex].MaDA;
                        break;
                    case "Remove from Job":
                        dr = MessageBox.Show("Bạn có chắc muốn loại người này khỏi Job", "Cảnh báo", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            breakMemberFromJob(ListMemberShow[index]);
                            ListMemberShow[index].MaCV = null;
                        }
                        else return;
                        break;
                    case "Add to select Job":
                        ListMemberShow[dgvMember.CurrentCell.RowIndex].MaCV = ListJobShow[dgvJob.CurrentCell.RowIndex].MaCV;
                        break;
                }
                if (isDelete == true)
                    ListMemberShow.RemoveAt(dgvMember.CurrentCell.RowIndex);
                else
                {
                    ListMemberShow[dgvMember.CurrentCell.RowIndex].ChucVu = "Nhân Viên   ";
                    ListMember.Add(ListMemberShow[dgvMember.CurrentCell.RowIndex]);
                    ListMemberShow.RemoveAt(dgvMember.CurrentCell.RowIndex);
                }
                fillDataToDGV("Member");
            }
        }
        private void dgvMember_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMember.Columns[dgvMember.CurrentCell.ColumnIndex].DataPropertyName == nameof(Member.TenTV))
            {
                if (dgvMember.CurrentCell.Value == null || dgvMember.CurrentCell.Value.ToString().Trim() == "")
                {
                    MessageBox.Show("Tên không được bỏ trống");
                    dgvMember.CurrentCell.Value = nameTemp;
                }
            }
            else if (dgvMember.Columns[dgvMember.CurrentCell.ColumnIndex].DataPropertyName == nameof(Member.ChucVu))
            {
                if (ListMemberShow[dgvMember.CurrentCell.RowIndex].MaTV == Login.MaTV)
                {
                    ListMemberShow[dgvMember.CurrentCell.RowIndex].ChucVu = ChucVu;
                    dgvMember.Refresh();
                    return;
                }
                bool isOkay = true;
                string CV = dgvMember.CurrentCell.Value.ToString().Trim();
                if (CV == "Trưởng Dự Án")
                {
                    int indexPrj = ListProjectShow.FindIndex(x => x.MaDA == ListMemberShow[dgvMember.CurrentCell.RowIndex].MaDA);
                    if (ListMemberShow[dgvMember.CurrentCell.RowIndex].MaDA == null)
                    {
                        MessageBox.Show("Người này chưa có dự án");
                        isOkay = false;
                    }
                    else if (ListProjectShow[indexPrj].MaNQL != null)
                    {
                        MessageBox.Show("Dự Án đã có người quản lý");
                        isOkay = false;
                    }
                    else if (ListMemberShow[dgvMember.CurrentCell.RowIndex].MaCV != null)
                    {
                        DialogResult dr = DialogResult.Yes;
                        if (ListMemberShow[dgvMember.CurrentCell.RowIndex].ChucVu == "Trưởng Phòng")
                            dr = MessageBox.Show("Bạn có chắc muốn hủy chức trưởng phòng và thăng lên làm Trưởng Dự Án?", "Nhắc Nhở",
                          MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            ListMemberShow[dgvMember.CurrentCell.RowIndex].ChucVu = ChucVu;
                            breakMemberFromJob(ListMemberShow[dgvMember.CurrentCell.RowIndex]);
                            ListMemberShow[dgvMember.CurrentCell.RowIndex].ChucVu = "Trưởng Dự Án";
                            ListMemberShow[dgvMember.CurrentCell.RowIndex].MaCV = null;
                            ListProjectShow[indexPrj].MaNQL = ListMemberShow[dgvMember.CurrentCell.RowIndex].MaTV;
                        }
                        else
                            isOkay = false;
                    }
                    else
                    {
                        ListMemberShow[dgvMember.CurrentCell.RowIndex].ChucVu = "Trưởng Dự Án";
                        ListProjectShow[indexPrj].MaNQL = ListMemberShow[dgvMember.CurrentCell.RowIndex].MaTV;
                    }
                }
                else if (CV == "Trưởng Nhóm")
                {
                    if (ListMemberShow[dgvMember.CurrentCell.RowIndex].MaCV == null)
                    {
                        MessageBox.Show("Người này chưa có công việc.");
                        isOkay = false;
                    }
                    else
                    {
                        int index = ListJobShow.FindIndex(x => x.MaCV == ListMemberShow[dgvMember.CurrentCell.RowIndex].MaCV);
                        if (index == -1)
                        {
                            index = ListJob.FindIndex(x => x.MaCV == ListMemberShow[dgvMember.CurrentCell.RowIndex].MaCV);
                            if (ListJob[index].MaNQL != null)
                            {
                                MessageBox.Show("Công Việc đã có Người Quản Lý.");
                                isOkay = false;
                            }
                            else ListJob[index].MaNQL = ListMemberShow[dgvMember.CurrentCell.RowIndex].MaTV;
                        }
                        else
                        {
                            if (ListJobShow[index].MaNQL != null)
                            {
                                MessageBox.Show("Công Việc đã có Người Quản Lý.");
                                isOkay = false;
                            }
                            else ListJobShow[index].MaNQL = ListMemberShow[dgvMember.CurrentCell.RowIndex].MaTV;
                        }
                    }
                }
                else if (CV == "Nhân Viên")
                {
                    if (ChucVu == "Giám Đốc")
                    {
                        MessageBox.Show("Bạn là Giám Đốc");
                        isOkay = false;
                    }
                    else if (ChucVu.Trim() == "Trưởng Dự Án")
                    {
                        DialogResult dr = MessageBox.Show("Người này đang là Trưởng Dự Án, bạn có muốn giáng chức họ?"
                            , "Nhắc nhở", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            ListMemberShow[dgvMember.CurrentCell.RowIndex].ChucVu = ChucVu;
                            breakMemberFromProject(ListMemberShow[dgvMember.CurrentCell.RowIndex]);
                            ListMemberShow[dgvMember.CurrentCell.RowIndex].ChucVu = "Nhân Viên   ";
                        }
                        else
                            isOkay = false;
                    }
                    else if (ChucVu.Trim() == "Trưởng Nhóm")
                    {
                        DialogResult dr = MessageBox.Show("Người này đang là Trưởng Nhóm, bạn có muốn giáng chức họ?"
                            , "Nhắc nhở", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            ListMemberShow[dgvMember.CurrentCell.RowIndex].ChucVu = ChucVu;
                            breakMemberFromJob(ListMemberShow[dgvMember.CurrentCell.RowIndex]);
                            ListMemberShow[dgvMember.CurrentCell.RowIndex].ChucVu = "Nhân Viên   ";
                        }
                        else
                            isOkay = false;
                    }
                }
                else isOkay = false;
                if (isOkay == false)
                {
                    ListMemberShow[dgvMember.CurrentCell.RowIndex].ChucVu = ChucVu;
                    dgvMember.Refresh();
                }
            }
        }
        private void dgvMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMember.Columns[dgvMember.CurrentCell.ColumnIndex].DataPropertyName == nameof(Member.TenTV))
            {
                nameTemp = ListMemberShow[dgvMember.CurrentCell.RowIndex].TenTV;
            }
            else if (dgvMember.Columns[dgvMember.CurrentCell.ColumnIndex].DataPropertyName == nameof(Member.ChucVu))
            {
                ChucVu = dgvMember.CurrentCell.Value.ToString();
            }
            labSelectedMember.Text = dgvMember.CurrentRow.Cells[0].Value.ToString();
        }
        private void loadMemberController(int input)
        {
            cbMemberController.Items.Clear();
            cbMemberController.Items.Add("Traceability => Info");
            switch (input)
            {
                case 0:
                    cbMemberController.Items.Add("Remove from OLab");
                    break;
                case 1:
                    cbMemberController.Items.Add("Add to select Project");
                    cbMemberController.Items.Add("Remove from OLab");
                    break;
                case 2:
                    cbMemberController.Items.Add("Add more to Project");
                    cbMemberController.Items.Add("Remove from Project");
                    cbMemberController.Items.Add("Remove from OLab");
                    break;
                case 3:
                    cbMemberController.Items.Add("Add to select Job");
                    cbMemberController.Items.Add("Remove from Project");
                    cbMemberController.Items.Add("Remove from OLab");
                    break;
                case 4:
                    cbMemberController.Items.Add("Add more to Job");
                    cbMemberController.Items.Add("Remove from Job");
                    cbMemberController.Items.Add("Remove from Project");
                    cbMemberController.Items.Add("Remove from OLab");
                    break;
            }
            cbMemberController.SelectedIndex = 0;
        }
        private void cbMemberController_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbMemberController.SelectedItem)
            {
                case "Add more to Job":
                    cbMemberType.SelectedIndex = 3;
                    cbMemberController.SelectedIndex = 1;
                    return;
                case "Add more to Project":
                    cbMemberType.SelectedIndex = 1;
                    cbMemberController.SelectedIndex = 1;
                    return;
                case "Remove from Project":
                    if (Login.ChucVu.Trim() == "Trưởng Nhóm")
                        cbMemberController.SelectedIndex = 0;
                    break;
                case "Remove from OLab":
                    if (Login.ChucVu.Trim() != "Giám Đốc")
                        cbMemberController.SelectedIndex = 0;
                    break;
            }
        }

        // SEARCH FORM
        private void searchProject(string Ma)
        {
            int index = ListProjectShow.FindIndex(x => x.MaDA == Ma);
            dgvProject.CurrentCell = dgvProject[0, index];
            dgvProject.Rows[index].Selected = true;
            dgvProject.FirstDisplayedScrollingRowIndex = index;

            cbJobType.SelectedIndex = -1;
            cbMemberType.SelectedIndex = -1;

            cbJobType.SelectedIndex = 1;
            cbMemberType.SelectedIndex = 2;
        }
        private void searchJob(string Ma)
        {
            int index = ListJobShow.FindIndex(x => x.MaCV == Ma);
            dgvJob.CurrentCell = dgvJob[0, index];
            dgvJob.Rows[index].Selected = true;
            dgvJob.FirstDisplayedScrollingRowIndex = index;

            cbMemberType.SelectedIndex = -1;
            cbMemberType.SelectedIndex = 4;
        }
        private void searchMember(string Ma)
        {
            int index = ListMemberShow.FindIndex(x => x.MaTV == Ma);
            dgvMember.CurrentCell = dgvMember[0, index];
            dgvMember.Rows[index].Selected = true;
            dgvMember.FirstDisplayedScrollingRowIndex = index;
        }
        private void cbSearch_DropDown(object sender, EventArgs e)
        {
            cbSearch.Items.Clear();
            foreach (Member run in ListMember)
                if (run.MaTV.Contains(cbSearch.Text) || run.TenTV.Contains(cbSearch.Text))
                    cbSearch.Items.Add(SP.key(run));
            foreach (Member run in ListMemberShow)
                if (run.MaTV.Contains(cbSearch.Text) || run.TenTV.Contains(cbSearch.Text))
                    cbSearch.Items.Add(SP.key(run));
            foreach (Job run in ListJobShow)
                if (run.MaCV.Contains(cbSearch.Text) || run.TenCV.Contains(cbSearch.Text))
                    cbSearch.Items.Add(SP.key(run));
            foreach (Job run in ListJob)
                if (run.MaCV.Contains(cbSearch.Text) || run.TenCV.Contains(cbSearch.Text))
                    cbSearch.Items.Add(SP.key(run));
            foreach (Project run in ListProjectShow)
                if (run.MaDA.Contains(cbSearch.Text) || run.TenDA.Contains(cbSearch.Text))
                    cbSearch.Items.Add(SP.key(run));
            cbSearch.SelectedIndex = -1;
        }
        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSearch.SelectedIndex == -1)
                return;
            string Ma = SP.GetIDFromKey(cbSearch.Text);
            string Type = Ma.Substring(0, 2);

            if (Type == "DA")
            {
                searchProject(Ma);
                showChildForm(new frmProjectInfo(ListProjectShow[dgvProject.CurrentRow.Index], ListJobShow.Count, ListMemberShow.Count, Login.ChucVu.Trim(), Login.MaTV));
            }
            else if (Type == "CV")
            {
                refillJob();
                string MaDA = ListJob.Find(x => x.MaCV == Ma).MaDA;

                searchProject(MaDA);
                searchJob(Ma);
                showChildForm(new frmJobInfo(ListJobShow[dgvJob.CurrentCell.RowIndex], ListMemberShow.Count, Login.ChucVu.Trim(), Login.MaTV));

            }
            else
            {
                refillMember();
                int index = ListMember.FindIndex(x => x.MaTV == Ma);
                string MaDA = ListMember[index].MaDA;
                string MaCV = ListMember[index].MaCV;

                if (MaDA != null)
                    searchProject(MaDA);
                if (MaCV != null)
                    searchJob(MaCV);

                if (MaDA == null && MaCV == null)
                {
                    cbMemberType.SelectedIndex = -1;
                    cbMemberType.SelectedIndex = 0;
                }
                searchMember(Ma);
                showChildForm(new frmMemberInfo(ListMemberShow[dgvMember.CurrentCell.RowIndex], Login.ChucVu.Trim()));
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            cbSearch.DroppedDown = true;
            cbSearch.SelectedIndex = -1;
            if (cbSearch.Items.Count > 0)
                cbSearch.SelectedIndex = 0;
            else MessageBox.Show("Không search thấy");
            cbSearch.DroppedDown = false;
        }
        private void cbFormType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFormType.SelectedIndex == -1)
                return;

            cbSearch.Text = (cbFormType.SelectedIndex == 0) ? labSelectedProject.Text :
                (cbFormType.SelectedIndex == 1) ? labSelectedJob.Text : labSelectedMember.Text;
            btnSearch_Click("", EventArgs.Empty);
            cbSearch.Text = "";
            cbFormType.SelectedIndex = -1;
        }
        private void cbFormType_Leave(object sender, EventArgs e)
        {
            cbFormType.Text = "[Row Header Click]";
        }

        private void frmManager_Resize(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = this.Height / 2;
            SCUP.SplitterDistance = SCDOWN.SplitterDistance = this.Width / 2;
        }
    }
}
