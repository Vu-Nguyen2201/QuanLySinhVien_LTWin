using QuanLyDeAn.Controllers;
using QuanLyDeAn.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeAn.Views
{
    public partial class frmTienDo : Form
    {
        int currentIDNhom;
        int currentIDDeAn;
        int currentIDTienDo = -1;
        public frmTienDo(int currentIDNhom, int currentIDDeAn)
        {
            InitializeComponent();
            this.currentIDDeAn = currentIDDeAn;
            this.currentIDNhom = currentIDNhom;
            dtpNgayBaoCao.Value = DateTime.Now;

            cIDTienDo.DataPropertyName = nameof(TienDo.IDTienDo);
            cNoiDung.DataPropertyName = nameof(TienDo.NoiDung);
            cHoanThanh.DataPropertyName = nameof(TienDo.HoanThanh);
            cTaiLieuBaoCao.DataPropertyName = nameof(TienDo.TaiLieuBaoCao);
            cThoiGianBaoCao.DataPropertyName = nameof(TienDo.ThoiGianBaoCao);
            cNhanXet.DataPropertyName = nameof(TienDo.NhanXet);
            cIDDeAn.DataPropertyName = nameof(TienDo.IDDeAn);
            cIDSinhVien.DataPropertyName = nameof(TienDo.IDSinhVien);
            cIDNhom.DataPropertyName = nameof(TienDo.IDNhom);
            cStatus.DataPropertyName = nameof(TienDo.status);

            cDeAn.DataPropertyName = nameof(TienDo.DeAn);
            cSinhVien.DataPropertyName = nameof(TienDo.SinhVien);
            cNhom.DataPropertyName = nameof(TienDo.Nhom);

            List<SinhVien> svThuocNhom = SinhVienController.GetSinhVienThuocNhom(currentIDNhom);
            cbSinhVien.DataSource = svThuocNhom;
            cbSinhVien.DisplayMember = "HoTen";

            showTienDo();
        }

        public void showTienDo()
        {
            BindingSource source = new BindingSource();
            source.DataSource = TienDoController.GetListTienDo(currentIDNhom);
            this.dgvTienDo.DataSource = source;
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            errorTienDo.Clear();
            if (txtTaiLieu.Text.Trim().Length <= 0)
            {
                errorTienDo.SetError(txtTaiLieu, "Thêm tài liệu báo cáo");
                return;
            }

            if (rtbNhanXet.Text.Trim().Length <= 0)
            {
                errorTienDo.SetError(rtbNhanXet, "Thêm tài nội dung tiến độ");
                return;
            }
            if(cbSinhVien.SelectedItem as SinhVien == null)
            {
                errorTienDo.SetError(cbSinhVien, "Thêm sinh viên thực hiện");
                return;
            }
            if(Int32.Parse(txtHoanThanh.Text.Trim()) > 100 && Int32.Parse(txtHoanThanh.Text.Trim()) < 0)
            {
                errorTienDo.SetError(txtHoanThanh, "Hoàn thành có giá trị từ 0 đến 100%");
                return;
            }
            if (DateTime.Now > dtpNgayBaoCao.Value)
            {
                errorTienDo.SetError(dtpNgayBaoCao, "Chọn ngày báo cáo phù hợp");
                return;
            }
            TienDo td = new TienDo();
            td.NoiDung = rtbNoiDungTienDo.Text.Trim();
            td.TaiLieuBaoCao = txtTaiLieu.Text.Trim();
            td.ThoiGianBaoCao = dtpNgayBaoCao.Value;
            td.HoanThanh = Int32.Parse(txtHoanThanh.Text.Trim());
            td.NhanXet = rtbNhanXet.Text.Trim();
            td.IDDeAn = currentIDDeAn;
            td.IDNhom = currentIDNhom;
            td.status = 1;
            SinhVien sv = cbSinhVien.SelectedItem as SinhVien;
            td.IDSinhVien = sv.IDSinhVien;
            if (TienDoController.ThemTienDo(td) == false)
            {
                MessageBox.Show("Khong them Tien Do duoc");
                return;
            }
            showTienDo();
            currentIDTienDo = -1;
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (currentIDTienDo == -1)
            {
                MessageBox.Show("Vui long chon Tien do");
                return;
            }
            TienDo td = new TienDo();
            td.IDTienDo = currentIDTienDo;
            td.NoiDung = rtbNoiDungTienDo.Text.Trim();
            td.TaiLieuBaoCao = txtTaiLieu.Text.Trim();
            td.ThoiGianBaoCao = dtpNgayBaoCao.Value;
            td.HoanThanh = Int32.Parse(txtHoanThanh.Text.Trim());
            td.NhanXet = rtbNhanXet.Text.Trim();
            td.IDDeAn = currentIDDeAn;
            td.IDNhom = currentIDNhom;
            td.status = 1;
            SinhVien sv = cbSinhVien.SelectedItem as SinhVien;
            td.IDSinhVien = sv.IDSinhVien;
            if (TienDoController.CapNhatTienDo(td) == false)
            {
                MessageBox.Show("Khong them Tien Do duoc");
                return;
            }
            showTienDo();
            currentIDTienDo = -1;
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (currentIDTienDo == -1)
            {
                MessageBox.Show("Vui long chon Tien do");
                return;
            }
            TienDo td = new TienDo();
            td.IDTienDo = currentIDTienDo;
            td.NoiDung = rtbNoiDungTienDo.Text.Trim();
            td.TaiLieuBaoCao = txtTaiLieu.Text.Trim();
            td.ThoiGianBaoCao = dtpNgayBaoCao.Value;
            td.HoanThanh = Int32.Parse(txtHoanThanh.Text.Trim());
            td.NhanXet = rtbNhanXet.Text.Trim();
            td.IDDeAn = currentIDDeAn;
            td.IDNhom = currentIDNhom;
            td.status = 0;
            SinhVien sv = cbSinhVien.SelectedItem as SinhVien;
            td.IDSinhVien = sv.IDSinhVien;
            if (TienDoController.CapNhatTienDo(td) == false)
            {
                MessageBox.Show("Khong xoa duoc Tien do");
                return;
            }
            showTienDo();
            currentIDTienDo = -1;
        }

        private void dgvTienDo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTienDo.CurrentCell.ColumnIndex != 0)
            {
                return;
            }
            currentIDTienDo = Int32.Parse(dgvTienDo.CurrentRow.Cells[0].Value.ToString());
            TienDo td = TienDoController.GetTienDo(currentIDTienDo);
            txtTaiLieu.Text = td.TaiLieuBaoCao.Trim();
            rtbNoiDungTienDo.Text = td.NoiDung.Trim();
            txtHoanThanh.Text = td.HoanThanh.ToString();
            rtbNhanXet.Text = td.NhanXet.Trim();
            dtpNgayBaoCao.Value = DateTime.Parse(td.ThoiGianBaoCao.ToString());
            foreach(SinhVien sv in cbSinhVien.Items)
            {
                if(sv.IDSinhVien == td.IDSinhVien)
                {
                    cbSinhVien.SelectedItem = cbSinhVien.Items.IndexOf(sv);
                    return;
                }
            }
        }

       
    }
}
