using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDeAn.Models;
using QuanLyDeAn.Controllers;

namespace QuanLyDeAn.Views
{
    public partial class frmGiaoVien : Form
    {
        int currentIDGV = -1;
        int currentGiaoVien;
        int admin;
        public frmGiaoVien(int currentGiaoVien, int admin)
        {
            InitializeComponent();
            this.currentGiaoVien = currentGiaoVien;
            this.admin = admin;
            dgvTeacher.AutoGenerateColumns = false;
            this.cIDgv.DataPropertyName = nameof(GiaoVien.IDGiaoVien);
            this.cTen.DataPropertyName = nameof(GiaoVien.HoTen);
            this.cEmail.DataPropertyName = nameof(GiaoVien.Email);
            this.cSDT.DataPropertyName = nameof(GiaoVien.SDT);
            this.cSex.DataPropertyName = nameof(GiaoVien.GioiTinh);
            this.cBomon.DataPropertyName = nameof(GiaoVien.BoMon);
            this.cbirthday.DataPropertyName = nameof(GiaoVien.NgaySinh);
            this.cUsername.DataPropertyName = nameof(GiaoVien.username);
            this.cPass.DataPropertyName = nameof(GiaoVien.pass);
            this.cAdmin.DataPropertyName = nameof(GiaoVien.ad);
            showGV();
        }
        public void showGV()
        {
            if(this.admin == 1)
            {
                BindingSource source = new BindingSource();
                source.DataSource = GiaoVienController.GetListGiaoVien();
                this.dgvTeacher.DataSource = source;
            }
            else
            {
                BindingSource source = new BindingSource();
                source.DataSource = GiaoVienController.GetGV(currentGiaoVien);
                this.dgvTeacher.DataSource = source;
            }
        }

        private void btAdd_Click_1(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtName.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtName, "Nhập tên ");
                return;
            }
            if (txtSDT.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtSDT, "Nhập SDT");
                return;
            }
            if (cbBomon.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.cbBomon, "Nhập bộ môn");
                return;
            }
            if (cbSex.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.cbSex, "Nhập giới tính");
                return;
            }
            if (txtEmail.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtEmail, "Nhập email");
                return;
            }
            if (DateTime.Now.Year - Birthday.Value.Year < 10)
            {
                errorProvider1.SetError(Birthday, "Chọn ngày sinh phù hợp");
                return;
            }
            if (txtusername.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtusername, "Nhập username");
                return;
            }
            if (txtpass.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtpass, "Nhập password");
                return;
            }


            GiaoVien gv = new GiaoVien();
            gv.HoTen = txtName.Text.Trim();
            gv.SDT = txtSDT.Text.Trim();
            gv.NgaySinh = Birthday.Value;
            gv.Email = txtEmail.Text.Trim();
            gv.GioiTinh = cbSex.SelectedItem.ToString();
            gv.BoMon = cbBomon.SelectedItem.ToString();
            gv.username = txtusername.Text.Trim();
            gv.pass = txtpass.Text.Trim();
            gv.ad = 0;
            gv.status = 1;
            if (GiaoVienController.ThemGV(gv) == false)
            {
                MessageBox.Show("Khong them giao vien duoc");
                return;
            }
            this.txtEmail.Clear();
            this.txtName.Clear();
            this.txtSDT.Clear();
            this.cbBomon.SelectedIndex = 0;
            this.cbSex.SelectedIndex = 0;
            this.Birthday.Value = DateTime.Now;
            this.currentIDGV = -1;
            showGV();
        }

        private void btXoa_Click_1(object sender, EventArgs e)
        {
            if (this.currentIDGV == -1)
            {
                MessageBox.Show("Vui long chon Giao vien");
                return;
            }
            GiaoVien gv = new GiaoVien();
            gv.IDGiaoVien = this.currentIDGV;
            gv.HoTen = this.txtName.Text;
            gv.Email = this.txtEmail.Text;
            gv.NgaySinh = this.Birthday.Value;
            gv.SDT = this.txtSDT.Text;
            gv.BoMon = this.cbBomon.Text;
            gv.GioiTinh = this.cbSex.Text;
            gv.username = this.txtusername.Text;
            gv.pass = this.txtpass.Text;
            gv.status = 0;
            GiaoVienController.UpdateGV(gv);
            if (GiaoVienController.UpdateGV(gv) != true)
            {
                MessageBox.Show("Khong xoa Giao vien duoc");
                return;
            }
            this.currentIDGV = -1;
            showGV();
        }

        private void dgvTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTeacher.CurrentCell.ColumnIndex != 0)
            {
                return;
            }
            this.currentIDGV = Int32.Parse(dgvTeacher.CurrentRow.Cells[0].Value.ToString());
            GiaoVien task = GiaoVienController.GetGV(this.currentIDGV);
            this.txtEmail.Text = task.Email.Trim();
            this.txtName.Text = task.HoTen.Trim();
            this.Birthday.Value = DateTime.Parse(task.NgaySinh.ToString());
            this.txtSDT.Text = task.SDT.Trim();
            this.cbBomon.SelectedItem = task.BoMon.Trim();
            this.cbSex.SelectedItem = task.GioiTinh.Trim();
            this.txtusername.Text = task.username.Trim();
            this.txtpass.Text = task.pass.Trim();
        }

        private void btUpdate_Click_1(object sender, EventArgs e)
        {
            if (this.currentIDGV == -1)
            {
                MessageBox.Show("Vui long chon Giao vien");
                return;
            }
            GiaoVien gv = new GiaoVien();
            gv.IDGiaoVien = this.currentIDGV;
            gv.HoTen = this.txtName.Text;
            gv.Email = this.txtEmail.Text;
            gv.NgaySinh = this.Birthday.Value;
            gv.SDT = this.txtSDT.Text;
            gv.BoMon = this.cbBomon.Text;
            gv.GioiTinh = this.cbSex.Text;
            gv.username = this.txtusername.Text;
            gv.pass = this.txtpass.Text;
            gv.status = 1;
            GiaoVienController.UpdateGV(gv);
            this.currentIDGV = -1;
            showGV();
            txtEmail.Text = "";
            txtName.Text = "";
            txtpass.Text = "";
            txtSDT.Text = "";
            txtusername.Text = "";
            cbBomon.Text = "";
            cbSex.Text = "";
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            txtpass.UseSystemPasswordChar = true;
            if (this.admin == 0)
            {
                btAdd.Enabled = false;
                btXoa.Enabled = false;
            }
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }
    }
}
