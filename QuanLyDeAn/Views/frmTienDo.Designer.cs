namespace QuanLyDeAn.Views
{
    partial class frmTienDo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbSinhVien = new System.Windows.Forms.ComboBox();
            this.rtbNoiDungTienDo = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaiLieu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayBaoCao = new System.Windows.Forms.DateTimePicker();
            this.txtHoanThanh = new System.Windows.Forms.TextBox();
            this.rtbNhanXet = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTienDo = new System.Windows.Forms.DataGridView();
            this.cIDTienDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTaiLieuBaoCao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cThoiGianBaoCao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHoanThanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNhanXet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDDeAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDeAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorTienDo = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTienDo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSinhVien
            // 
            this.cbSinhVien.FormattingEnabled = true;
            this.cbSinhVien.Location = new System.Drawing.Point(870, 70);
            this.cbSinhVien.Name = "cbSinhVien";
            this.cbSinhVien.Size = new System.Drawing.Size(283, 33);
            this.cbSinhVien.TabIndex = 30;
            // 
            // rtbNoiDungTienDo
            // 
            this.rtbNoiDungTienDo.Location = new System.Drawing.Point(248, 152);
            this.rtbNoiDungTienDo.Name = "rtbNoiDungTienDo";
            this.rtbNoiDungTienDo.Size = new System.Drawing.Size(283, 96);
            this.rtbNoiDungTienDo.TabIndex = 28;
            this.rtbNoiDungTienDo.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(622, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "SINH VIÊN THỰC HIỆN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "NỘI DUNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(622, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "THỜI GIAN BÁO CÁO";
            // 
            // txtTaiLieu
            // 
            this.txtTaiLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiLieu.Location = new System.Drawing.Point(248, 76);
            this.txtTaiLieu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTaiLieu.Name = "txtTaiLieu";
            this.txtTaiLieu.Size = new System.Drawing.Size(283, 30);
            this.txtTaiLieu.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "TÀI LIỆU BÁO CÁO";
            // 
            // dtpNgayBaoCao
            // 
            this.dtpNgayBaoCao.Location = new System.Drawing.Point(870, 127);
            this.dtpNgayBaoCao.Name = "dtpNgayBaoCao";
            this.dtpNgayBaoCao.Size = new System.Drawing.Size(283, 30);
            this.dtpNgayBaoCao.TabIndex = 33;
            // 
            // txtHoanThanh
            // 
            this.txtHoanThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoanThanh.Location = new System.Drawing.Point(870, 179);
            this.txtHoanThanh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoanThanh.Name = "txtHoanThanh";
            this.txtHoanThanh.Size = new System.Drawing.Size(283, 30);
            this.txtHoanThanh.TabIndex = 42;
            // 
            // rtbNhanXet
            // 
            this.rtbNhanXet.Location = new System.Drawing.Point(870, 230);
            this.rtbNhanXet.Name = "rtbNhanXet";
            this.rtbNhanXet.Size = new System.Drawing.Size(283, 96);
            this.rtbNhanXet.TabIndex = 41;
            this.rtbNhanXet.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(622, 233);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 25);
            this.label7.TabIndex = 40;
            this.label7.Text = "NHẬN XÉT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(622, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "HOÀN THÀNH";
            // 
            // dgvTienDo
            // 
            this.dgvTienDo.AllowUserToAddRows = false;
            this.dgvTienDo.AllowUserToDeleteRows = false;
            this.dgvTienDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTienDo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDTienDo,
            this.cNoiDung,
            this.cTaiLieuBaoCao,
            this.cThoiGianBaoCao,
            this.cHoanThanh,
            this.cNhanXet,
            this.cIDDeAn,
            this.cIDSinhVien,
            this.cIDNhom,
            this.cDeAn,
            this.cNhom,
            this.cSinhVien,
            this.cStatus});
            this.dgvTienDo.Location = new System.Drawing.Point(12, 389);
            this.dgvTienDo.Name = "dgvTienDo";
            this.dgvTienDo.ReadOnly = true;
            this.dgvTienDo.RowHeadersWidth = 51;
            this.dgvTienDo.Size = new System.Drawing.Size(1176, 291);
            this.dgvTienDo.TabIndex = 54;
            this.dgvTienDo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTienDo_CellClick);
            // 
            // cIDTienDo
            // 
            this.cIDTienDo.HeaderText = "ID Tiến độ";
            this.cIDTienDo.MinimumWidth = 6;
            this.cIDTienDo.Name = "cIDTienDo";
            this.cIDTienDo.ReadOnly = true;
            this.cIDTienDo.Width = 125;
            // 
            // cNoiDung
            // 
            this.cNoiDung.HeaderText = "Nội dung";
            this.cNoiDung.MinimumWidth = 6;
            this.cNoiDung.Name = "cNoiDung";
            this.cNoiDung.ReadOnly = true;
            this.cNoiDung.Width = 125;
            // 
            // cTaiLieuBaoCao
            // 
            this.cTaiLieuBaoCao.HeaderText = "Tài liệu báo cáo";
            this.cTaiLieuBaoCao.MinimumWidth = 6;
            this.cTaiLieuBaoCao.Name = "cTaiLieuBaoCao";
            this.cTaiLieuBaoCao.ReadOnly = true;
            this.cTaiLieuBaoCao.Width = 125;
            // 
            // cThoiGianBaoCao
            // 
            this.cThoiGianBaoCao.HeaderText = "Thời gian báo cáo";
            this.cThoiGianBaoCao.MinimumWidth = 6;
            this.cThoiGianBaoCao.Name = "cThoiGianBaoCao";
            this.cThoiGianBaoCao.ReadOnly = true;
            this.cThoiGianBaoCao.Width = 125;
            // 
            // cHoanThanh
            // 
            this.cHoanThanh.HeaderText = "Hoàn thành (%)";
            this.cHoanThanh.MinimumWidth = 6;
            this.cHoanThanh.Name = "cHoanThanh";
            this.cHoanThanh.ReadOnly = true;
            this.cHoanThanh.Width = 125;
            // 
            // cNhanXet
            // 
            this.cNhanXet.HeaderText = "Nhận xét";
            this.cNhanXet.MinimumWidth = 6;
            this.cNhanXet.Name = "cNhanXet";
            this.cNhanXet.ReadOnly = true;
            this.cNhanXet.Width = 125;
            // 
            // cIDDeAn
            // 
            this.cIDDeAn.HeaderText = "IDDeAn";
            this.cIDDeAn.MinimumWidth = 6;
            this.cIDDeAn.Name = "cIDDeAn";
            this.cIDDeAn.ReadOnly = true;
            this.cIDDeAn.Width = 125;
            // 
            // cIDSinhVien
            // 
            this.cIDSinhVien.HeaderText = "IDSinhVien";
            this.cIDSinhVien.MinimumWidth = 6;
            this.cIDSinhVien.Name = "cIDSinhVien";
            this.cIDSinhVien.ReadOnly = true;
            this.cIDSinhVien.Width = 125;
            // 
            // cIDNhom
            // 
            this.cIDNhom.HeaderText = "IDNhom";
            this.cIDNhom.MinimumWidth = 6;
            this.cIDNhom.Name = "cIDNhom";
            this.cIDNhom.ReadOnly = true;
            this.cIDNhom.Width = 125;
            // 
            // cDeAn
            // 
            this.cDeAn.HeaderText = "DeAn";
            this.cDeAn.MinimumWidth = 6;
            this.cDeAn.Name = "cDeAn";
            this.cDeAn.ReadOnly = true;
            this.cDeAn.Visible = false;
            this.cDeAn.Width = 125;
            // 
            // cNhom
            // 
            this.cNhom.HeaderText = "Nhom";
            this.cNhom.MinimumWidth = 6;
            this.cNhom.Name = "cNhom";
            this.cNhom.ReadOnly = true;
            this.cNhom.Visible = false;
            this.cNhom.Width = 125;
            // 
            // cSinhVien
            // 
            this.cSinhVien.HeaderText = "SinhVien";
            this.cSinhVien.MinimumWidth = 6;
            this.cSinhVien.Name = "cSinhVien";
            this.cSinhVien.ReadOnly = true;
            this.cSinhVien.Visible = false;
            this.cSinhVien.Width = 125;
            // 
            // cStatus
            // 
            this.cStatus.HeaderText = "Status";
            this.cStatus.MinimumWidth = 6;
            this.cStatus.Name = "cStatus";
            this.cStatus.ReadOnly = true;
            this.cStatus.Visible = false;
            this.cStatus.Width = 125;
            // 
            // errorTienDo
            // 
            this.errorTienDo.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 100);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit";
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(260, 33);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 35);
            this.btnSua.TabIndex = 27;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(451, 33);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 35);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(73, 33);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 35);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // frmTienDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 692);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTienDo);
            this.Controls.Add(this.txtHoanThanh);
            this.Controls.Add(this.rtbNhanXet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpNgayBaoCao);
            this.Controls.Add(this.txtTaiLieu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbSinhVien);
            this.Controls.Add(this.rtbNoiDungTienDo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTienDo";
            this.Text = "Tiến độ Đề án";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTienDo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSinhVien;
        private System.Windows.Forms.RichTextBox rtbNoiDungTienDo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaiLieu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgayBaoCao;
        private System.Windows.Forms.TextBox txtHoanThanh;
        private System.Windows.Forms.RichTextBox rtbNhanXet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTienDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDTienDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTaiLieuBaoCao;
        private System.Windows.Forms.DataGridViewTextBoxColumn cThoiGianBaoCao;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHoanThanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNhanXet;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDeAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDeAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStatus;
        private System.Windows.Forms.ErrorProvider errorTienDo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
    }
}