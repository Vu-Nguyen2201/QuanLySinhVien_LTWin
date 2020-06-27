using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDeAn.Controllers;
using QuanLyDeAn.Models;

namespace QuanLyDeAn.Views
{
    public partial class frmSinhVien : Form
    {
        int currentIDSinhVien = -1;
        int currentIDNhom = -1;
        public frmSinhVien(int currentGiaoVien, int admin)
        {
            InitializeComponent();
            this.cIDSinhVien.DataPropertyName = nameof(SinhVien.IDSinhVien);
            this.cHoTen.DataPropertyName = nameof(SinhVien.HoTen);
            this.cMSSV.DataPropertyName = nameof(SinhVien.MSSV);
            this.cNgaySinh.DataPropertyName = nameof(SinhVien.NgaySinh);
            this.cEmail.DataPropertyName = nameof(SinhVien.Email);
            this.cSdt.DataPropertyName = nameof(SinhVien.SDT);
            this.cGioiTinh.DataPropertyName = nameof(SinhVien.GioiTinh);
            this.cNhom.DataPropertyName =  nameof(Nhom.IDNhom);
            this.cIDNhomOfSinhVien.DataPropertyName = nameof(Nhom.TenNhom);
            this.cNhomSV.DataPropertyName = nameof(SinhVien.Nhom);
            this.cTienDoes.DataPropertyName = nameof(SinhVien.TienDoes);
            this.cStatusS.DataPropertyName = nameof(SinhVien.status);

            this.cIDNhom.DataPropertyName = nameof(Nhom.IDNhom);
            this.cTenNhom.DataPropertyName = nameof(Nhom.TenNhom);
            this.cDeAns.DataPropertyName = nameof(Nhom.DeAns);
            this.cSinhViens.DataPropertyName = nameof(Nhom.SinhViens);
            this.cTienDoes2.DataPropertyName = nameof(Nhom.TienDoes);
            this.cStatusN.DataPropertyName = nameof(Nhom.status);
            //Hien thi dataNhom
            showDSNhom();
            showDSSinhVien();
        }
        public void showDSNhom()
        {
            BindingSource source = new BindingSource();
            List<Nhom> dsNhom = NhomController.GetListNhom();
            //Them ds Nhom vao dgvNhom
            source.DataSource = dsNhom;
            this.dgvNhom.DataSource = source;
            //Them ds Nhom vao combobox
            cbNhom.Items.Clear();
            Nhom nhomRong = new Nhom();
            cbNhom.DisplayMember = "TenNhom";
            cbNhom.Items.Insert(0, nhomRong);
            foreach (Nhom nhom in dsNhom)
            {
                cbNhom.Items.Add(nhom);
            }
            
        }
        public void showDSSinhVien()
        {
            BindingSource source = new BindingSource();
            source.DataSource = SinhVienController.GetListSinhVien();
            this.dgvSinhvien.DataSource = source;
        }
        private void btnThemSinhVien_Click(object sender, EventArgs e)
        {
            errorThemSinhVien.Clear();
            if(txtHoten.Text.Trim().Length <= 0)
            {
                errorThemSinhVien.SetError(txtHoten, "Nhập Họ và Tên");
                return;
            }
            if(txtMssv.Text.Trim().Length <= 0)
            {
                errorThemSinhVien.SetError(txtMssv, "Thêm MSSV");
                return;
            }
            if(DateTime.Now.Year - dtpNgaySinh.Value.Year < 10)
            {
                errorThemSinhVien.SetError(dtpNgaySinh, "Chọn ngày sinh phù hợp");
                return;
            }
            if(txtEmail.Text.Trim().Length <= 0)
            {
                errorThemSinhVien.SetError(txtEmail, "Thêm email");
                return;
            }
            if (txtSdt.Text.Trim().Length <= 0)
            {
                errorThemSinhVien.SetError(txtSdt, "Thêm SĐT");
                return;
            }
            if(cbGioitinh.SelectedItem == null)
            {
                errorThemSinhVien.SetError(cbGioitinh, "Chọn giới tính");
                return;
            }
            if(cbNhom.SelectedItem as Nhom == null)
            {
                errorThemSinhVien.SetError(cbNhom, "Chọn nhóm");
                return;
            }

            SinhVien sv = new SinhVien();
            sv.HoTen = txtHoten.Text.Trim();
            sv.MSSV = txtMssv.Text.Trim();
            sv.NgaySinh = dtpNgaySinh.Value;
            sv.Email = txtEmail.Text.Trim();
            sv.SDT = txtSdt.Text.Trim();
            sv.GioiTinh = cbGioitinh.SelectedItem.ToString();
            sv.status = 1;
            Nhom nhom = cbNhom.SelectedItem as Nhom;
            sv.IDNhom = nhom.IDNhom;
            if(SinhVienController.ThemSinhVien(sv) == false)
            {
                MessageBox.Show("Khong them nhom duoc");
                return;
            }
            currentIDSinhVien = -1;
            showDSSinhVien();
        }

        private void dgvSinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvSinhvien.CurrentCell.ColumnIndex != 1)
            {
                return;
            }
            currentIDSinhVien = Int32.Parse(dgvSinhvien.CurrentRow.Cells[1].Value.ToString());
            SinhVien sv = SinhVienController.GetSinhVien(currentIDSinhVien);
            txtHoten.Text = sv.HoTen.Trim();
            txtMssv.Text = sv.MSSV.Trim();
            dtpNgaySinh.Value = DateTime.Parse(sv.NgaySinh.ToString());
            txtEmail.Text = sv.Email.Trim();
            txtSdt.Text = sv.SDT.Trim();
            cbGioitinh.SelectedIndex = cbGioitinh.FindStringExact(sv.GioiTinh.Trim());
            foreach(Nhom nhomTrongCB in cbNhom.Items)
            {
                if(nhomTrongCB.IDNhom == sv.Nhom.IDNhom)
                {
                    cbNhom.SelectedIndex = cbNhom.Items.IndexOf(nhomTrongCB);
                    return;
                }
            }
        }

        private void btnSuaSinhVien_Click_1(object sender, EventArgs e)
        {
            if(currentIDSinhVien == -1)
            {
                MessageBox.Show("Vui long chon Sinh vien");
                return;
            }
            SinhVien sv = new SinhVien();
            sv.IDSinhVien = currentIDSinhVien;
            sv.HoTen = txtHoten.Text.Trim();
            sv.MSSV = txtMssv.Text.Trim();
            sv.NgaySinh = dtpNgaySinh.Value;
            sv.Email = txtEmail.Text.Trim();
            sv.SDT = txtSdt.Text.Trim();
            sv.GioiTinh = cbGioitinh.SelectedItem.ToString();
            Nhom nhom = cbNhom.SelectedItem as Nhom;
            sv.IDNhom = nhom.IDNhom;
            sv.status = 1;
            if (SinhVienController.CapNhatSinhVien(sv) == false)
            {
                MessageBox.Show("Khong sua Sinh vien duoc");
                return;
            }
            currentIDSinhVien = -1;
            showDSSinhVien();
            txtEmail.Text = "";
            txtHoten.Text = "";
            txtMssv.Text = "";
            txtSdt.Text = "";
            cbGioitinh.Text = "";
            cbNhom.Text = "";
        }

        private void btnXoaSinhVien_Click_1(object sender, EventArgs e)
        {
            if (currentIDSinhVien == -1)
            {
                MessageBox.Show("Vui long chon Sinh vien");
                return;
            }
            SinhVien sv = new SinhVien();
            sv.IDSinhVien = currentIDSinhVien;
            sv.HoTen = txtHoten.Text.Trim();
            sv.MSSV = txtMssv.Text.Trim();
            sv.NgaySinh = dtpNgaySinh.Value;
            sv.Email = txtEmail.Text.Trim();
            sv.SDT = txtSdt.Text.Trim();
            sv.GioiTinh = cbGioitinh.SelectedItem.ToString();
            Nhom nhom = cbNhom.SelectedItem as Nhom;
            sv.IDNhom = nhom.IDNhom;
            sv.status = 0;
            if (SinhVienController.CapNhatSinhVien(sv) == false)
            {
                MessageBox.Show("Khong xoa duoc Sinh vien");
                return;
            }
            currentIDSinhVien = -1;
            showDSSinhVien();
        }
        private void btnThemn_Click_1(object sender, EventArgs e)
        {
            errorThemNhom.Clear();
            if (txtTenNhom.Text.Trim().Length <= 0)
            {
                errorThemNhom.SetError(txtTenNhom, "Them ten nhom");
                return;
            }

            Nhom nhom = new Nhom();
            nhom.TenNhom = txtTenNhom.Text.Trim();
            nhom.status = 1;
            if (NhomController.ThemNhom(nhom) == false)
            {
                MessageBox.Show("Khong them nhom duoc");
                return;
            }
            currentIDNhom = -1;
            showDSNhom();
        }

        private void btnSuaNhom_Click_1(object sender, EventArgs e) 
        {
            if (currentIDNhom == -1)
            {
                MessageBox.Show("Vui long chon Nhom");
                return;
            }
            Nhom nhom = new Nhom();
            nhom.IDNhom = currentIDNhom;
            nhom.TenNhom = txtTenNhom.Text.Trim();
            nhom.status = 1;
            if (NhomController.CapNhatNhom(nhom) == false)
            {
                MessageBox.Show("Khong sua Nhom duoc");
                return;
            }
            currentIDNhom = -1;
            showDSNhom();
            txtTenNhom.Text = "";
        }

        private void dgvNhom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNhom.CurrentCell.ColumnIndex != 0)
            {
                return;
            }
            currentIDNhom = Int32.Parse(dgvNhom.CurrentRow.Cells[0].Value.ToString());
            Nhom nhom = NhomController.GetNhom(currentIDNhom);
            txtTenNhom.Text = nhom.TenNhom.Trim();

        }

        private void btnXoan_Click_1(object sender, EventArgs e)
        {
            if (currentIDNhom == -1)
            {
                MessageBox.Show("Vui long chon Nhom");
                return;
            }
            Nhom nhom = new Nhom();
            nhom.IDNhom = currentIDNhom;
            nhom.TenNhom = txtTenNhom.Text.Trim();
            nhom.status = 0;
            if (NhomController.CapNhatNhom(nhom) == false)
            {
                MessageBox.Show("Khong xoa duoc Nhom");
                return;
            }
            currentIDNhom = -1;
            showDSNhom();
        }
    }
}
