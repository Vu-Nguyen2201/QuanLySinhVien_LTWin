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
using System.Data.SqlClient;


namespace QuanLyDeAn.Views
{
    public partial class frmDeAn : Form
    {
        int currentIDDeAn = -1;
        int currentGiaoVien;
        int admin;
        List<DeAn> dsDeAn = new List<DeAn>();
        public frmDeAn(int currentGiaoVien, int admin)
        {
            InitializeComponent();
            this.currentGiaoVien = currentGiaoVien;
            this.admin = admin;
            this.cTenDeAn.DataPropertyName = nameof(DeAn.TenDeAn);
            this.cIDDeAn.DataPropertyName = nameof(DeAn.IDDeAn);
            this.cLoaiDeAn.DataPropertyName = nameof(DeAn.LoaiDeAn);
            this.cTenGiaoVien.DataPropertyName = nameof(DeAn.IDGiaoVien);
            this.cTenNhom.DataPropertyName = nameof(DeAn.IDNhom);
            this.cNoiDung.DataPropertyName = nameof(DeAn.NoiDung);
            this.cStatus.DataPropertyName = nameof(DeAn.status);
            cGiaoVien.DataPropertyName = nameof(DeAn.GiaoVien);
            cNhom.DataPropertyName = nameof(DeAn.Nhom);
            cTienDoes.DataPropertyName = nameof(DeAn.TienDoes);

            showDSNhom();
            showDSGiaoVien();
            showDSDeAn();
        }
        public void showDSNhom()
        {
            BindingSource source = new BindingSource();
            List<Nhom> dsNhom = NhomController.GetListNhom();
            //Them ds Nhom vao dgvNhom
            source.DataSource = dsNhom;
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
        public void showDSGiaoVien()
        {
            BindingSource source = new BindingSource();
            List<GiaoVien> dsGiaoVien = new List<GiaoVien>();
            if (this.admin == 1)
            {
                dsGiaoVien = GiaoVienController.GetListGiaoVien();
                source.DataSource = dsGiaoVien;
            }
            else
            {
                GiaoVien gv = GiaoVienController.GetGV(this.currentGiaoVien);
                dsGiaoVien.Add(gv);
                source.DataSource = dsGiaoVien;
            }
            GiaoVien giaoVienRong = new GiaoVien();
            cbGiaoVien.DisplayMember = "HoTen";
            cbGiaoVien.Items.Add(giaoVienRong);
            foreach (GiaoVien gv in dsGiaoVien)
            {
                cbGiaoVien.Items.Add(gv);
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            errorDeAn.Clear();
            if(txtTenDeAn.Text.Trim().Length <= 0)
            {
                errorDeAn.SetError(txtTenDeAn, "Thêm tên đề án");
                return;
            }
            if (rtbNoiDung.Text.Trim().Length <= 5)
            {
                errorDeAn.SetError(rtbNoiDung, "Thêm nội dung đề án");
                return;
            }
            if (cbLoaiDeAn.SelectedItem == null)
            {
                errorDeAn.SetError(cbLoaiDeAn, "Chọn loại đề án");
                return;
            }
            if (cbNhom.SelectedItem as Nhom == null)
            {
                errorDeAn.SetError(cbNhom, "Chọn nhóm");
                return;
            }
            if (cbGiaoVien.SelectedItem as GiaoVien == null)
            {
                errorDeAn.SetError(cbGiaoVien, "Chọn Giáo viên");
                return;
            }

            GiaoVien giaovien = cbGiaoVien.SelectedItem as GiaoVien;
            Nhom nhom = cbNhom.SelectedItem as Nhom;
            DeAn da = new DeAn();
            da.TenDeAn = txtTenDeAn.Text.Trim();
            da.LoaiDeAn = cbLoaiDeAn.SelectedItem.ToString();
            da.NoiDung = rtbNoiDung.Text.Trim();
            da.IDNhom = nhom.IDNhom;
            da.IDGiaoVien = giaovien.IDGiaoVien;
            da.status = 1;
            if (DeAnController.ThemDeAn(da) == false)
            {
                MessageBox.Show("Khong them duoc");
                return;
            }
            showDSDeAn();
            this.txtTenDeAn.Clear();
            this.cbLoaiDeAn.Text = "";
            this.rtbNoiDung.Clear();
            this.cbNhom.Text = "";
            this.cbGiaoVien.Text = "";
        }
        private void dgvDeAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDeAn.CurrentRow.Index >= 0)
            {
                int IDDA = Int32.Parse(dgvDeAn.CurrentRow.Cells[0].Value.ToString());
                DeAn da = DeAnController.GetDeAn(IDDA);
                currentIDDeAn = da.IDDeAn;
                txtTenDeAn.Text = da.TenDeAn.Trim();
                cbLoaiDeAn.SelectedIndex = cbLoaiDeAn.FindStringExact(da.LoaiDeAn.Trim());
                rtbNoiDung.Text = da.NoiDung.Trim();
                foreach (Nhom nhom in cbNhom.Items)
                {
                    if (nhom.IDNhom == da.IDNhom)
                    {
                        cbNhom.SelectedIndex = cbNhom.Items.IndexOf(nhom);
                    }
                }
                foreach (GiaoVien gv in cbGiaoVien.Items)
                {
                    if (gv.IDGiaoVien == da.IDGiaoVien)
                    {
                        cbGiaoVien.SelectedIndex = cbGiaoVien.Items.IndexOf(gv);
                        return;
                    }
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (currentIDDeAn == -1)
            {
                MessageBox.Show("Vui long chon de an");
                return;
            }
            DeAn da = new DeAn();
            da.IDDeAn = currentIDDeAn;
            da.TenDeAn = txtTenDeAn.Text.Trim();
            da.NoiDung = rtbNoiDung.Text.Trim();
            da.LoaiDeAn = cbLoaiDeAn.SelectedItem.ToString();
            Nhom nhom = cbNhom.SelectedItem as Nhom;
            da.IDNhom = nhom.IDNhom;
            GiaoVien gv = cbGiaoVien.SelectedItem as GiaoVien;
            da.IDGiaoVien = gv.IDGiaoVien;
            da.status = 1;
            if (DeAnController.CapNhatDeAn(da) == false)
            {
                MessageBox.Show("Khong sua de an duoc");
                return;
            }
            currentIDDeAn = -1;
            showDSDeAn();
            txtTenDeAn.Text = "";
            rtbNoiDung.Text = "";
            cbGiaoVien.Text = "";
            cbLoaiDeAn.Text = "";
            cbNhom.Text = "";
        }
        public void showDSDeAn()
        {
            BindingSource source = new BindingSource();
            if (this.admin == 1)
            {
                dsDeAn = DeAnController.GetListDeAn();
            }
            else
            {
                dsDeAn = DeAnController.GetDeAnGV(this.currentGiaoVien);
            }
            source.DataSource = dsDeAn;
            this.dgvDeAn.DataSource = source;
            //dgvDeAn.Refresh();
        }
        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            
            GiaoVien giaovien = cbGiaoVien.SelectedItem as GiaoVien;
            Nhom nhom = cbNhom.SelectedItem as Nhom;
            string lda = cbLoaiDeAn.Text ;
            if (txtTenDeAn.Text != "")
            {
                dgvDeAn.DataSource = "";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=DBQuanLyDeAn;Integrated Security=True";
                con.Open();
                string sql = "Select * From DeAn  where TenDeAn =N'" + txtTenDeAn.Text + "' ";
                DataSet ds = new DataSet();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(ds);
                dgvDeAn.DataSource = ds.Tables[0];
                dgvDeAn.Columns[6].Visible = false;
                dgvDeAn.Refresh();
                return;
            }
            if (cbLoaiDeAn.Text != "")
            {
                dgvDeAn.DataSource = "";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=DBQuanLyDeAn;Integrated Security=True";
                con.Open();
                string sql = "Select * From DeAn  where LoaiDeAn =N'" + lda + "' ";
                DataSet ds = new DataSet();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(ds);
                dgvDeAn.DataSource = ds.Tables[0];
                dgvDeAn.Columns[6].Visible = false;
                dgvDeAn.Refresh();
                return;
            }
            if (cbNhom.Text != "" && cbGiaoVien.Text != "")
            {
                dgvDeAn.DataSource = "";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=DBQuanLyDeAn;Integrated Security=True";
                con.Open();
                string sql = "Select * From DeAn  where IDNhom ='" + nhom.IDNhom + "' And IDGiaoVien ='" + giaovien.IDGiaoVien + "'";
                DataSet ds = new DataSet();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(ds);
                dgvDeAn.DataSource = ds.Tables[0];
                dgvDeAn.Columns[6].Visible = false;
                dgvDeAn.Refresh();
                return;
            }
            if (cbNhom.Text == "" && cbGiaoVien.Text == "")
            {
                dgvDeAn.DataSource = "";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=DBQuanLyDeAn;Integrated Security=True";
                con.Open();
                string sql = "Select * From DeAn ";
                DataSet ds = new DataSet();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(ds);
                dgvDeAn.DataSource = ds.Tables[0];
                dgvDeAn.Columns[6].Visible = false;
                dgvDeAn.Refresh();
                return;
            }
            if (cbNhom.Text != "")
            {
                dgvDeAn.DataSource = "";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=DBQuanLyDeAn;Integrated Security=True";
                con.Open();
                string sql = "Select * From DeAn  where IDNhom ='" + nhom.IDNhom + "' ";
                DataSet ds = new DataSet();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(ds);
                dgvDeAn.DataSource = ds.Tables[0];
                dgvDeAn.Columns[6].Visible = false;
                dgvDeAn.Refresh();
                return;
            }
            if (cbGiaoVien.Text != "")
            {
                dgvDeAn.DataSource = "";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=DBQuanLyDeAn;Integrated Security=True";
                con.Open();
                string sql = "Select * From DeAn  where IDGiaoVien ='" + giaovien.IDGiaoVien + "' ";
                DataSet ds = new DataSet();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(ds);
                dgvDeAn.DataSource = ds.Tables[0];
                dgvDeAn.Columns[6].Visible = false;
                dgvDeAn.Refresh();
                return;
            }
        }
        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (currentIDDeAn == -1)
            {
                MessageBox.Show("Vui long chon Sinh vien");
                return;
            }
            DeAn da = new DeAn();
            da.IDDeAn = currentIDDeAn;
            da.TenDeAn = txtTenDeAn.Text.Trim();
            da.NoiDung = rtbNoiDung.Text.Trim();
            da.LoaiDeAn = cbLoaiDeAn.SelectedItem.ToString();
            Nhom nhom = cbNhom.SelectedItem as Nhom;
            da.IDNhom = nhom.IDNhom;
            GiaoVien gv = cbGiaoVien.SelectedItem as GiaoVien;
            da.IDGiaoVien = gv.IDGiaoVien;
            da.status = 0;
            if (DeAnController.CapNhatDeAn(da) == false)
            {
                MessageBox.Show("Khong xoa De an duoc");
                return;
            }
            currentIDDeAn = -1;
            showDSDeAn();
        }

        private void btnTienDo_Click(object sender, EventArgs e)
        {
            if (dgvDeAn.CurrentRow.Index >= 0)
            {
                int IDDA = Int32.Parse(dgvDeAn.CurrentRow.Cells[0].Value.ToString());
                DeAn da = DeAnController.GetDeAn(IDDA);
                frmTienDo ftd = new frmTienDo((int)da.IDNhom, IDDA);
                ftd.Show();
            }    
        }
    }
}