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
    public partial class frmMain : Form
    {
        frmDeAn formdean;
        frmGiaoVien formgiaovien;
        frmSinhVien formsinhvien;
        int currentGiaoVien;
        int admin;
        public frmMain(int currentGiaoVien, int admin)
        {
            InitializeComponent();
            this.currentGiaoVien = currentGiaoVien;
            this.admin = admin;
        }

        private void mQLSV_Click(object sender, EventArgs e)
        {
            if (this.formsinhvien is null || this.formsinhvien.IsDisposed)
            {
                this.formsinhvien = new frmSinhVien(currentGiaoVien, admin);
                this.formsinhvien.MdiParent = this;
                this.formsinhvien.Show();
            }
            else
            {
                this.formsinhvien.Select();
            }
        }

        private void mQLGV_Click(object sender, EventArgs e)
        {
            if (this.formgiaovien is null || this.formgiaovien.IsDisposed)
            {
                this.formgiaovien = new frmGiaoVien(currentGiaoVien, admin);
                this.formgiaovien.MdiParent = this;
                this.formgiaovien.Show();
            }
            else
            {
                this.formgiaovien.Select();
            }
        }

        private void mQLDA_Click(object sender, EventArgs e)
        {
            if (this.formdean is null || this.formdean.IsDisposed)
            {
                this.formdean = new frmDeAn(currentGiaoVien, admin);
                this.formdean.MdiParent = this;
                this.formdean.Show();
            }
            else
            {
                this.formdean.Select();
            }
        }

        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                return;
            }
            this.ActiveMdiChild.WindowState = FormWindowState.Maximized;
            if (this.ActiveMdiChild.Tag == null)
            {
                TabPage tp = new TabPage(this.ActiveMdiChild.Text);
                tp.Tag = this.ActiveMdiChild;
                tp.Parent = this.tabMain;
                this.tabMain.SelectedTab = tp;
                this.ActiveMdiChild.Tag = tp;
                this.ActiveMdiChild.FormClosed += ActiveMdiChild_FormClosed;
            }
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabMain.SelectedTab != null && this.tabMain.SelectedTab.Tag != null)
            {
                (this.tabMain.SelectedTab.Tag as Form).Select();
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn đăng xuất ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                frmLogin lg = new frmLogin();
                lg.Show();
            }
        }
    }
}
