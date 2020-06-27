namespace QuanLyDeAn.Views
{
    partial class frmDeAn
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenDeAn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbLoaiDeAn = new System.Windows.Forms.ComboBox();
            this.rtbNoiDung = new System.Windows.Forms.RichTextBox();
            this.cbNhom = new System.Windows.Forms.ComboBox();
            this.cbGiaoVien = new System.Windows.Forms.ComboBox();
            this.dgvDeAn = new System.Windows.Forms.DataGridView();
            this.errorDeAn = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTienDo = new System.Windows.Forms.Button();
            this.cIDDeAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenDeAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLoaiDeAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTienDoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDeAn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÊN ĐỀ ÁN";
            // 
            // txtTenDeAn
            // 
            this.txtTenDeAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDeAn.Location = new System.Drawing.Point(237, 27);
            this.txtTenDeAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenDeAn.Name = "txtTenDeAn";
            this.txtTenDeAn.Size = new System.Drawing.Size(148, 30);
            this.txtTenDeAn.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "LOẠI ĐỀ ÁN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "NỘI DUNG -  GIỚI THIỆU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(553, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "NHÓM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(553, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "GIÁO VIÊN";
            // 
            // cbLoaiDeAn
            // 
            this.cbLoaiDeAn.FormattingEnabled = true;
            this.cbLoaiDeAn.Items.AddRange(new object[] {
            "Môn học",
            "Tốt nghiệp"});
            this.cbLoaiDeAn.Location = new System.Drawing.Point(237, 101);
            this.cbLoaiDeAn.Name = "cbLoaiDeAn";
            this.cbLoaiDeAn.Size = new System.Drawing.Size(121, 33);
            this.cbLoaiDeAn.TabIndex = 13;
            // 
            // rtbNoiDung
            // 
            this.rtbNoiDung.Location = new System.Drawing.Point(237, 178);
            this.rtbNoiDung.Name = "rtbNoiDung";
            this.rtbNoiDung.Size = new System.Drawing.Size(283, 96);
            this.rtbNoiDung.TabIndex = 14;
            this.rtbNoiDung.Text = "";
            // 
            // cbNhom
            // 
            this.cbNhom.FormattingEnabled = true;
            this.cbNhom.Location = new System.Drawing.Point(685, 25);
            this.cbNhom.Name = "cbNhom";
            this.cbNhom.Size = new System.Drawing.Size(121, 33);
            this.cbNhom.TabIndex = 15;
            // 
            // cbGiaoVien
            // 
            this.cbGiaoVien.FormattingEnabled = true;
            this.cbGiaoVien.Location = new System.Drawing.Point(685, 104);
            this.cbGiaoVien.Name = "cbGiaoVien";
            this.cbGiaoVien.Size = new System.Drawing.Size(121, 33);
            this.cbGiaoVien.TabIndex = 16;
            // 
            // dgvDeAn
            // 
            this.dgvDeAn.AllowUserToAddRows = false;
            this.dgvDeAn.AllowUserToDeleteRows = false;
            this.dgvDeAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDDeAn,
            this.cTenDeAn,
            this.cLoaiDeAn,
            this.cNoiDung,
            this.cTenNhom,
            this.cTenGiaoVien,
            this.cGiaoVien,
            this.cNhom,
            this.cTienDoes,
            this.cStatus});
            this.dgvDeAn.Location = new System.Drawing.Point(12, 402);
            this.dgvDeAn.Name = "dgvDeAn";
            this.dgvDeAn.ReadOnly = true;
            this.dgvDeAn.RowHeadersWidth = 51;
            this.dgvDeAn.Size = new System.Drawing.Size(1154, 278);
            this.dgvDeAn.TabIndex = 17;
            this.dgvDeAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeAn_CellClick);
            // 
            // errorDeAn
            // 
            this.errorDeAn.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTienDo);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Location = new System.Drawing.Point(41, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1067, 88);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(751, 33);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(112, 35);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(358, 33);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 35);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(556, 33);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 35);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(154, 31);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 35);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnTienDo
            // 
            this.btnTienDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTienDo.Location = new System.Drawing.Point(921, 31);
            this.btnTienDo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTienDo.Name = "btnTienDo";
            this.btnTienDo.Size = new System.Drawing.Size(112, 35);
            this.btnTienDo.TabIndex = 16;
            this.btnTienDo.Text = "Tiến độ";
            this.btnTienDo.UseVisualStyleBackColor = true;
            this.btnTienDo.Click += new System.EventHandler(this.btnTienDo_Click);
            // 
            // cIDDeAn
            // 
            this.cIDDeAn.HeaderText = "ID đề án";
            this.cIDDeAn.MinimumWidth = 6;
            this.cIDDeAn.Name = "cIDDeAn";
            this.cIDDeAn.ReadOnly = true;
            this.cIDDeAn.Width = 200;
            // 
            // cTenDeAn
            // 
            this.cTenDeAn.HeaderText = "Tên đề án";
            this.cTenDeAn.MinimumWidth = 6;
            this.cTenDeAn.Name = "cTenDeAn";
            this.cTenDeAn.ReadOnly = true;
            this.cTenDeAn.Width = 200;
            // 
            // cLoaiDeAn
            // 
            this.cLoaiDeAn.HeaderText = "Loại đề án";
            this.cLoaiDeAn.MinimumWidth = 6;
            this.cLoaiDeAn.Name = "cLoaiDeAn";
            this.cLoaiDeAn.ReadOnly = true;
            this.cLoaiDeAn.Width = 200;
            // 
            // cNoiDung
            // 
            this.cNoiDung.HeaderText = "Nội dung";
            this.cNoiDung.MinimumWidth = 6;
            this.cNoiDung.Name = "cNoiDung";
            this.cNoiDung.ReadOnly = true;
            this.cNoiDung.Width = 200;
            // 
            // cTenNhom
            // 
            this.cTenNhom.HeaderText = "IDNhom";
            this.cTenNhom.MinimumWidth = 6;
            this.cTenNhom.Name = "cTenNhom";
            this.cTenNhom.ReadOnly = true;
            this.cTenNhom.Width = 125;
            // 
            // cTenGiaoVien
            // 
            this.cTenGiaoVien.HeaderText = "IDGiaoVien";
            this.cTenGiaoVien.MinimumWidth = 6;
            this.cTenGiaoVien.Name = "cTenGiaoVien";
            this.cTenGiaoVien.ReadOnly = true;
            this.cTenGiaoVien.Width = 125;
            // 
            // cGiaoVien
            // 
            this.cGiaoVien.HeaderText = "GiaoVien";
            this.cGiaoVien.MinimumWidth = 6;
            this.cGiaoVien.Name = "cGiaoVien";
            this.cGiaoVien.ReadOnly = true;
            this.cGiaoVien.Visible = false;
            this.cGiaoVien.Width = 125;
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
            // cTienDoes
            // 
            this.cTienDoes.HeaderText = "TienDo";
            this.cTienDoes.MinimumWidth = 6;
            this.cTienDoes.Name = "cTienDoes";
            this.cTienDoes.ReadOnly = true;
            this.cTienDoes.Visible = false;
            this.cTienDoes.Width = 125;
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
            // frmDeAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDeAn);
            this.Controls.Add(this.cbGiaoVien);
            this.Controls.Add(this.cbNhom);
            this.Controls.Add(this.rtbNoiDung);
            this.Controls.Add(this.cbLoaiDeAn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenDeAn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDeAn";
            this.Text = "Đề án";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDeAn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenDeAn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbLoaiDeAn;
        private System.Windows.Forms.RichTextBox rtbNoiDung;
        private System.Windows.Forms.ComboBox cbNhom;
        private System.Windows.Forms.ComboBox cbGiaoVien;
        private System.Windows.Forms.DataGridView dgvDeAn;
        private System.Windows.Forms.ErrorProvider errorDeAn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTienDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDeAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenDeAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLoaiDeAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTienDoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStatus;
    }
}