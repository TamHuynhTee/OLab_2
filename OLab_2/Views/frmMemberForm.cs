using OLab_2.Controllers;
using OLab_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OLab_2.Views
{
    public partial class frmMemberForm : Form
    {
        List<Project> ListProject = new List<Project>();
        List<Job> ListJob = new List<Job>();
        List<Member> ListMember = new List<Member>();
        PenDraw pencil = new PenDraw();
        bool isGD = false;
        public Member GD;
        public frmMemberForm(ref List<Project> LP, ref List<Member> LM, ref List<Job> LJ)
        {
            InitializeComponent();
            ListProject = LP;
            ListJob = LJ;
            ListMember = LM;
            picFace.AllowDrop = true;
        }
        public frmMemberForm()
        {
            InitializeComponent();

            isGD = true;
            gbWork.Visible = false;
            picFace.AllowDrop = true;
            gbWork.Visible = false;
        }

        //Form
        private string newID()
        {
            int id = 0;
            while (ListMember.Find(x => x.MaTV == ("TV" + new string('0', 4 - id.ToString().Length)
                + id.ToString())) != null)
            {
                id++;
            }
            return "TV" + new string('0', 4 - id.ToString().Length) + id.ToString();
        }

        private void frmMemberForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void frmMemberForm_Load(object sender, EventArgs e)
        {
            txtID.Text = newID();
            foreach (Project run in ListProject)
            {
                cbProject.Items.Add(SP.key(run));
            }
            txtSalary.Text = "100";
        }
        private void clearForm()
        {
            cbLevel.Text = cbSex.Text = txtName.Text = txtPassword.Text
                = txtEmail.Text = txtPhone.Text = cbProject.Text
                = rtxtContent.Text = "";

            clearImage(picFace);
            clearImage(picSign);

            cbJob.Items.Clear();
            cbJob.Enabled = ckbLeaderProject.Enabled = ckbLeaderJob.Enabled
                = rtxtContent.Enabled = ckbLeaderJob.Checked = ckbLeaderProject.Checked = false;

            dtpBirthday.Value = DateTime.Now;
            txtSalary.Text = "100";
        }
        private void btnClearForm_Click(object sender, EventArgs e)
        {
            clearForm();
        }
        //Add
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            bool isOkay = true;
            if (txtName.Text.Trim() == "")
            {
                errorProvider.SetError(txtName, "Tên không được bỏ trống");
                isOkay = false;
            }
            if (cbSex.Text == "")
            {
                errorProvider.SetError(cbSex, "Giới tính không được bỏ trống");
                isOkay = false;
            }
            if (DateTime.Now.Year - dtpBirthday.Value.Year < 18)
            {
                errorProvider.SetError(dtpBirthday, "Chưa đủ 18 tuổi");
                isOkay = false;
            }
            if (picFace.Image == null)
            {
                errorProvider.SetError(picFace, "Ảnh chân dung không được bỏ trống");
                isOkay = false;
            }
            if (picSign.Image == null)
            {
                errorProvider.SetError(picSign, "Chữ kí không được bỏ trống");
                isOkay = false;
            }
            if (txtPhone.Text == "")
            {
                errorProvider.SetError(txtPhone, "SDT không được bỏ trống");
                isOkay = false;
            }
            else if (txtPhone.Text.Length > 10)
            {
                errorProvider.SetError(txtPhone, "SDT không lố 10 số");
                isOkay = false;
            }
            else
            {
                for (int i = 0; i < txtPhone.Text.Length; i++)
                    if (txtPhone.Text[i] < '0' || txtPhone.Text[i] > '9')
                    {
                        errorProvider.SetError(txtPhone, "SDT không chứa kí tự đặc biệt");
                        isOkay = false;
                        break;
                    }
            }
            try
            {
                decimal test = Convert.ToDecimal(txtSalary.Text);
            }
            catch
            {
                errorProvider.SetError(txtSalary, "Lương (%) thuộc dạng decimal");
                isOkay = false;
            }
            if (cbLevel.Text == "")
            {
                errorProvider.SetError(cbLevel, "Học Vấn không được bỏ trống");
                isOkay = false;
            }

            if (isOkay)
            {
                Member newMember = collectForm();
                if (ckbLeaderJob.Checked == true)
                {
                    int jobIndex = ListJob.FindIndex(x => x.MaCV == newMember.MaCV);
                    ListJob[jobIndex].MaNQL = newMember.MaTV;

                    newMember.ChucVu = "Trưởng Nhóm";
                }
                else if (ckbLeaderProject.Checked == true)
                {
                    int projectIndex = ListProject.FindIndex(x => x.MaDA == newMember.MaDA);
                    ListProject[projectIndex].MaNQL = newMember.MaTV;

                    newMember.ChucVu = "Trưởng Dự Án";
                }
                else
                {
                    newMember.ChucVu = "Nhân Viên";
                    if (isGD == true)
                    {
                        newMember.ChucVu = "Giám Đốc";
                        GD = newMember;
                        Close();
                    }
                }
                (picSign.Image.Clone() as Image).Save(@"Images\" + newMember.MaTV + "SIGN.jpg", ImageFormat.Jpeg);
                (picFace.Image.Clone() as Image).Save(@"Images\" + newMember.MaTV + "FACE.jpg", ImageFormat.Jpeg);

                clearImage(picFace);
                clearImage(picSign);

                ListMember.Add(newMember);
                MessageBox.Show("Add Thành Công");
                clearForm();
                txtID.Text = newID();
            }
        }
        private Member collectForm()
        {
            Member temp = new Member()
            {
                MaTV = txtID.Text,
                TenTV = txtName.Text,
                NgaySinh = dtpBirthday.Value,
                GioiTinh = cbSex.Text,
                Phone = txtPhone.Text,
                HocVan = cbLevel.Text,
                NoiDung = rtxtContent.Text,
                LuongThuong = Convert.ToDecimal(txtSalary.Text)
            };

            if (cbProject.Text != "")
                temp.MaDA = SP.GetIDFromKey(cbProject.Text);
            if (cbJob.Text != "")
                temp.MaCV = SP.GetIDFromKey(cbJob.Text);
            if (txtPassword.Text != "")
                temp.Password = txtPassword.Text;
            return temp;
        }


        // Pertain Form
        private void cbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MaDA = SP.GetIDFromKey(cbProject.Text);
            cbJob.Items.Clear();
            foreach (Job run in ListJob)
                if (run.MaDA == MaDA)
                {
                    cbJob.Items.Add(SP.key(run));
                }
            cbJob.Enabled = true;
            ckbLeaderProject.Enabled = true;
            rtxtContent.Enabled = true;
            ckbLeaderJob.Enabled = false;
        }
        private void cbJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbJob.SelectedIndex == -1)
            {
                ckbLeaderJob.Enabled = false;
                return;
            }
            if (ckbLeaderProject.Checked == true)
            {
                DialogResult dr = MessageBox.Show("Người quản lý dự án không thể thuộc 1 công việc, Bạn có muốn giáng chức người này ?",
                            "Nhắc nhở", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                    ckbLeaderProject.Checked = false;
                else
                {
                    cbJob.SelectedIndex = -1;
                    
                    return;
                }                    
            }
            ckbLeaderJob.Enabled = true;
        }
        private void ckbLeaderProjet_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbLeaderProject.Checked == true)
            {
                if(cbJob.Text != "")
                {
                    DialogResult dr = MessageBox.Show("Người quản lý dự án không thể thuộc 1 công việc, Bạn có muốn loại người này khỏi công viêc ?",
                        "Nhắc nhở",MessageBoxButtons.YesNo);
                    if (dr == DialogResult.No)
                    {
                        return;
                    }
                    else
                        cbJob.SelectedIndex = -1;
                }    
                string MaDA = SP.GetIDFromKey(cbProject.Text);
                if (ListProject.Find(x => x.MaDA == MaDA).MaNQL != null)
                {
                    ckbLeaderProject.Checked = false;
                    MessageBox.Show("Project đã có người quản lý", "Nhắc nhở");
                }
                else if (ckbLeaderJob.Checked == true)
                    ckbLeaderJob.Checked = false;
            }
        }
        private void ckbLeaderJob_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbLeaderJob.Checked == true)
            {
                string MaCV = SP.GetIDFromKey(cbJob.Text);
                if (ListJob.Find(x => x.MaCV == MaCV).MaNQL != null)
                {
                    ckbLeaderJob.Checked = false;
                    MessageBox.Show("Job đã có người quản lý", "Nhắc nhở");
                }
                else if (ckbLeaderProject.Checked == true)
                    ckbLeaderProject.Checked = false;
            }
        }


        // Personal Form
        private void btnPass_Click(object sender, EventArgs e)
        {
            if (btnPass.Text == "SHOW")
            {
                btnPass.Text = "HIDE";
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                btnPass.Text = "SHOW";
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        //FACE
        private void picFace_DragDrop(object sender, DragEventArgs e)
        {
            if (picFace.Image != null)
                picFace.Image.Dispose();
            string[] pic = (string[])e.Data.GetData(DataFormats.FileDrop);
            picFace.Image = Image.FromFile(pic[0]);
        }
        private void picFace_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void btnClearFace_Click(object sender, EventArgs e)
        {
            clearImage(picFace);
        }
        //SIGN
        private void picSign_MouseDown(object sender, MouseEventArgs e)
        {
            if (picSign.Image == null)
                picSign.Image = SP.emptyImage(picSign.Width, picSign.Height);
            picSign.Focus();
            pencil.isUse = true;
            pencil.X = e.X;
            pencil.Y = e.Y;
        }
        private void pbSign_MouseMove(object sender, MouseEventArgs e)
        {
            if (pencil.isUse)
            {
                using (Graphics g = Graphics.FromImage(picSign.Image))
                {
                    g.DrawLine(pencil.pen, pencil.X, pencil.Y, e.X, e.Y);
                    g.Save();
                    picSign.Refresh();
                    pencil.X = e.X;
                    pencil.Y = e.Y;
                }
            }
        }
        private void pbSign_MouseUp(object sender, MouseEventArgs e)
        {
            pencil.isUse = false;
        }
        private void btnClearSign_Click(object sender, EventArgs e)
        {
            clearImage(picSign);
        }

        // Support
        private void clearImage(PictureBox input)
        {
            if (input.Image != null)
            {
                input.Image.Dispose();
                input.Image = null;
            }
        }

    }
}
