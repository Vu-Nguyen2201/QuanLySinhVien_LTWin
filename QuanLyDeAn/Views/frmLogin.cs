using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyDeAn.Models;
using QuanLyDeAn.Controllers;

namespace QuanLyDeAn.Views
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public static string ID_USER = "";

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtmk.UseSystemPasswordChar = false;
            }
            else
            {
                txtmk.UseSystemPasswordChar = true;
            }
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien();
            gv.username = txttk.Text.Trim();
            gv.pass = txtmk.Text.Trim();
            if (GiaoVienController.DangNhap(gv) == null)
            {
                MessageBox.Show("Vui long kiem tra tai khoan va mat khau");
                return;
            }
            gv = GiaoVienController.DangNhap(gv);
            frmMain mf = new frmMain(gv.IDGiaoVien, (int)gv.ad);
            mf.Show();
            this.Hide();

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát chương trình không ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("Kết thúc", "Thông báo");
                this.Close();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtmk.UseSystemPasswordChar = true;
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btndangnhap_Click(sender, e);
            }
        }

        private void txttk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btndangnhap_Click(sender, e);
            }
        }

        private void txtmk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btndangnhap_Click(sender, e);
            }
        }
    }
}
