namespace QuanLyDeAn.Views
{
    partial class frmSinhVien
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoaSinhVien = new System.Windows.Forms.Button();
            this.btnSuaSinhVien = new System.Windows.Forms.Button();
            this.btnThemSinhVien = new System.Windows.Forms.Button();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbNhom = new System.Windows.Forms.ComboBox();
            this.cbGioitinh = new System.Windows.Forms.ComboBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMssv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.dgvSinhvien = new System.Windows.Forms.DataGridView();
            this.cIDSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDNhomOfSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNhomSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTienDoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStatusS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoan = new System.Windows.Forms.Button();
            this.btnSuaNhom = new System.Windows.Forms.Button();
            this.btnThemn = new System.Windows.Forms.Button();
            this.txtTenNhom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvNhom = new System.Windows.Forms.DataGridView();
            this.cIDNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDeAns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSinhViens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTienDoes2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStatusN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorThemSinhVien = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorThemNhom = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorThemSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorThemNhom)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1359, 606);
            this.splitContainer1.SplitterDistance = 769;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel1.Controls.Add(this.dtpNgaySinh);
            this.splitContainer2.Panel1.Controls.Add(this.cbNhom);
            this.splitContainer2.Panel1.Controls.Add(this.cbGioitinh);
            this.splitContainer2.Panel1.Controls.Add(this.txtSdt);
            this.splitContainer2.Panel1.Controls.Add(this.txtEmail);
            this.splitContainer2.Panel1.Controls.Add(this.txtMssv);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.txtHoten);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvSinhvien);
            this.splitContainer2.Size = new System.Drawing.Size(769, 606);
            this.splitContainer2.SplitterDistance = 339;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoaSinhVien);
            this.groupBox1.Controls.Add(this.btnSuaSinhVien);
            this.groupBox1.Controls.Add(this.btnThemSinhVien);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(511, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 272);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit";
            // 
            // btnXoaSinhVien
            // 
            this.btnXoaSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSinhVien.Location = new System.Drawing.Point(31, 185);
            this.btnXoaSinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaSinhVien.Name = "btnXoaSinhVien";
            this.btnXoaSinhVien.Size = new System.Drawing.Size(139, 44);
            this.btnXoaSinhVien.TabIndex = 18;
            this.btnXoaSinhVien.Text = "Xóa";
            this.btnXoaSinhVien.UseVisualStyleBackColor = true;
            this.btnXoaSinhVien.Click += new System.EventHandler(this.btnXoaSinhVien_Click_1);
            // 
            // btnSuaSinhVien
            // 
            this.btnSuaSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaSinhVien.Location = new System.Drawing.Point(31, 110);
            this.btnSuaSinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaSinhVien.Name = "btnSuaSinhVien";
            this.btnSuaSinhVien.Size = new System.Drawing.Size(139, 44);
            this.btnSuaSinhVien.TabIndex = 17;
            this.btnSuaSinhVien.Text = "Sửa";
            this.btnSuaSinhVien.UseVisualStyleBackColor = true;
            this.btnSuaSinhVien.Click += new System.EventHandler(this.btnSuaSinhVien_Click_1);
            // 
            // btnThemSinhVien
            // 
            this.btnThemSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSinhVien.Location = new System.Drawing.Point(31, 41);
            this.btnThemSinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemSinhVien.Name = "btnThemSinhVien";
            this.btnThemSinhVien.Size = new System.Drawing.Size(139, 46);
            this.btnThemSinhVien.TabIndex = 16;
            this.btnThemSinhVien.Text = "Thêm";
            this.btnThemSinhVien.UseVisualStyleBackColor = true;
            this.btnThemSinhVien.Click += new System.EventHandler(this.btnThemSinhVien_Click);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(187, 105);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(265, 22);
            this.dtpNgaySinh.TabIndex = 16;
            // 
            // cbNhom
            // 
            this.cbNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNhom.FormattingEnabled = true;
            this.cbNhom.Location = new System.Drawing.Point(187, 262);
            this.cbNhom.Margin = new System.Windows.Forms.Padding(4);
            this.cbNhom.Name = "cbNhom";
            this.cbNhom.Size = new System.Drawing.Size(263, 33);
            this.cbNhom.TabIndex = 12;
            // 
            // cbGioitinh
            // 
            this.cbGioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGioitinh.FormattingEnabled = true;
            this.cbGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbGioitinh.Location = new System.Drawing.Point(187, 219);
            this.cbGioitinh.Margin = new System.Windows.Forms.Padding(4);
            this.cbGioitinh.Name = "cbGioitinh";
            this.cbGioitinh.Size = new System.Drawing.Size(263, 33);
            this.cbGioitinh.TabIndex = 11;
            // 
            // txtSdt
            // 
            this.txtSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdt.Location = new System.Drawing.Point(187, 181);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(4);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(263, 30);
            this.txtSdt.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(187, 140);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(263, 30);
            this.txtEmail.TabIndex = 10;
            // 
            // txtMssv
            // 
            this.txtMssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMssv.Location = new System.Drawing.Point(187, 57);
            this.txtMssv.Margin = new System.Windows.Forms.Padding(4);
            this.txtMssv.Name = "txtMssv";
            this.txtMssv.Size = new System.Drawing.Size(263, 30);
            this.txtMssv.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 272);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "NHÓM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 229);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "GIỚI TÍNH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "SĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "EMAIL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "NGÀY SINH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "MSSV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "HỌ TÊN";
            // 
            // txtHoten
            // 
            this.txtHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoten.Location = new System.Drawing.Point(187, 16);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(263, 30);
            this.txtHoten.TabIndex = 0;
            // 
            // dgvSinhvien
            // 
            this.dgvSinhvien.AllowUserToAddRows = false;
            this.dgvSinhvien.AllowUserToDeleteRows = false;
            this.dgvSinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDSinhVien,
            this.cHoTen,
            this.cMSSV,
            this.cNgaySinh,
            this.cEmail,
            this.cSdt,
            this.cGioiTinh,
            this.cNhom,
            this.cIDNhomOfSinhVien,
            this.cNhomSV,
            this.cTienDoes,
            this.cStatusS});
            this.dgvSinhvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSinhvien.Location = new System.Drawing.Point(0, 0);
            this.dgvSinhvien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSinhvien.Name = "dgvSinhvien";
            this.dgvSinhvien.ReadOnly = true;
            this.dgvSinhvien.RowHeadersWidth = 51;
            this.dgvSinhvien.Size = new System.Drawing.Size(769, 262);
            this.dgvSinhvien.TabIndex = 0;
            this.dgvSinhvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhvien_CellClick);
            // 
            // cIDSinhVien
            // 
            this.cIDSinhVien.HeaderText = "ID SINH VIÊN";
            this.cIDSinhVien.MinimumWidth = 6;
            this.cIDSinhVien.Name = "cIDSinhVien";
            this.cIDSinhVien.ReadOnly = true;
            this.cIDSinhVien.Width = 125;
            // 
            // cHoTen
            // 
            this.cHoTen.HeaderText = "HỌ TÊN";
            this.cHoTen.MinimumWidth = 6;
            this.cHoTen.Name = "cHoTen";
            this.cHoTen.ReadOnly = true;
            this.cHoTen.Width = 125;
            // 
            // cMSSV
            // 
            this.cMSSV.HeaderText = "MSSV";
            this.cMSSV.MinimumWidth = 6;
            this.cMSSV.Name = "cMSSV";
            this.cMSSV.ReadOnly = true;
            this.cMSSV.Width = 125;
            // 
            // cNgaySinh
            // 
            this.cNgaySinh.HeaderText = "NGÀY SINH";
            this.cNgaySinh.MinimumWidth = 6;
            this.cNgaySinh.Name = "cNgaySinh";
            this.cNgaySinh.ReadOnly = true;
            this.cNgaySinh.Width = 125;
            // 
            // cEmail
            // 
            this.cEmail.HeaderText = "EMAIL";
            this.cEmail.MinimumWidth = 6;
            this.cEmail.Name = "cEmail";
            this.cEmail.ReadOnly = true;
            this.cEmail.Width = 125;
            // 
            // cSdt
            // 
            this.cSdt.HeaderText = "SĐT";
            this.cSdt.MinimumWidth = 6;
            this.cSdt.Name = "cSdt";
            this.cSdt.ReadOnly = true;
            this.cSdt.Width = 125;
            // 
            // cGioiTinh
            // 
            this.cGioiTinh.HeaderText = "GIỚI TÍNH";
            this.cGioiTinh.MinimumWidth = 6;
            this.cGioiTinh.Name = "cGioiTinh";
            this.cGioiTinh.ReadOnly = true;
            this.cGioiTinh.Width = 125;
            // 
            // cNhom
            // 
            this.cNhom.HeaderText = "ID Nhóm";
            this.cNhom.MinimumWidth = 6;
            this.cNhom.Name = "cNhom";
            this.cNhom.ReadOnly = true;
            this.cNhom.Width = 125;
            // 
            // cIDNhomOfSinhVien
            // 
            this.cIDNhomOfSinhVien.HeaderText = "ID Nhóm";
            this.cIDNhomOfSinhVien.MinimumWidth = 6;
            this.cIDNhomOfSinhVien.Name = "cIDNhomOfSinhVien";
            this.cIDNhomOfSinhVien.ReadOnly = true;
            this.cIDNhomOfSinhVien.Visible = false;
            this.cIDNhomOfSinhVien.Width = 125;
            // 
            // cNhomSV
            // 
            this.cNhomSV.HeaderText = "Nhom";
            this.cNhomSV.MinimumWidth = 6;
            this.cNhomSV.Name = "cNhomSV";
            this.cNhomSV.ReadOnly = true;
            this.cNhomSV.Visible = false;
            this.cNhomSV.Width = 125;
            // 
            // cTienDoes
            // 
            this.cTienDoes.HeaderText = "TienDoes";
            this.cTienDoes.MinimumWidth = 6;
            this.cTienDoes.Name = "cTienDoes";
            this.cTienDoes.ReadOnly = true;
            this.cTienDoes.Visible = false;
            this.cTienDoes.Width = 125;
            // 
            // cStatusS
            // 
            this.cStatusS.HeaderText = "STATUS SINH VIÊN";
            this.cStatusS.MinimumWidth = 6;
            this.cStatusS.Name = "cStatusS";
            this.cStatusS.ReadOnly = true;
            this.cStatusS.Visible = false;
            this.cStatusS.Width = 125;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer3.Panel1.Controls.Add(this.txtTenNhom);
            this.splitContainer3.Panel1.Controls.Add(this.label8);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dgvNhom);
            this.splitContainer3.Size = new System.Drawing.Size(585, 606);
            this.splitContainer3.SplitterDistance = 339;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoan);
            this.groupBox2.Controls.Add(this.btnSuaNhom);
            this.groupBox2.Controls.Add(this.btnThemn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 117);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit";
            // 
            // btnXoan
            // 
            this.btnXoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoan.Location = new System.Drawing.Point(361, 36);
            this.btnXoan.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoan.Name = "btnXoan";
            this.btnXoan.Size = new System.Drawing.Size(137, 44);
            this.btnXoan.TabIndex = 19;
            this.btnXoan.Text = "Xóa";
            this.btnXoan.UseVisualStyleBackColor = true;
            this.btnXoan.Click += new System.EventHandler(this.btnXoan_Click_1);
            // 
            // btnSuaNhom
            // 
            this.btnSuaNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNhom.Location = new System.Drawing.Point(193, 36);
            this.btnSuaNhom.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaNhom.Name = "btnSuaNhom";
            this.btnSuaNhom.Size = new System.Drawing.Size(137, 44);
            this.btnSuaNhom.TabIndex = 18;
            this.btnSuaNhom.Text = "Sửa";
            this.btnSuaNhom.UseVisualStyleBackColor = true;
            this.btnSuaNhom.Click += new System.EventHandler(this.btnSuaNhom_Click_1);
            // 
            // btnThemn
            // 
            this.btnThemn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemn.Location = new System.Drawing.Point(31, 36);
            this.btnThemn.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemn.Name = "btnThemn";
            this.btnThemn.Size = new System.Drawing.Size(137, 44);
            this.btnThemn.TabIndex = 17;
            this.btnThemn.Text = "Thêm";
            this.btnThemn.UseVisualStyleBackColor = true;
            this.btnThemn.Click += new System.EventHandler(this.btnThemn_Click_1);
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhom.Location = new System.Drawing.Point(181, 36);
            this.txtTenNhom.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(263, 30);
            this.txtTenNhom.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 43);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "TÊN NHÓM";
            // 
            // dgvNhom
            // 
            this.dgvNhom.AllowUserToAddRows = false;
            this.dgvNhom.AllowUserToDeleteRows = false;
            this.dgvNhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDNhom,
            this.cTenNhom,
            this.cDeAns,
            this.cSinhViens,
            this.cTienDoes2,
            this.cStatusN});
            this.dgvNhom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhom.Location = new System.Drawing.Point(0, 0);
            this.dgvNhom.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNhom.Name = "dgvNhom";
            this.dgvNhom.ReadOnly = true;
            this.dgvNhom.RowHeadersWidth = 51;
            this.dgvNhom.Size = new System.Drawing.Size(585, 262);
            this.dgvNhom.TabIndex = 0;
            this.dgvNhom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhom_CellClick);
            // 
            // cIDNhom
            // 
            this.cIDNhom.FillWeight = 50F;
            this.cIDNhom.Frozen = true;
            this.cIDNhom.HeaderText = "ID NHÓM";
            this.cIDNhom.MinimumWidth = 6;
            this.cIDNhom.Name = "cIDNhom";
            this.cIDNhom.ReadOnly = true;
            this.cIDNhom.Width = 120;
            // 
            // cTenNhom
            // 
            this.cTenNhom.HeaderText = "TÊN NHÓM";
            this.cTenNhom.MinimumWidth = 6;
            this.cTenNhom.Name = "cTenNhom";
            this.cTenNhom.ReadOnly = true;
            this.cTenNhom.Width = 150;
            // 
            // cDeAns
            // 
            this.cDeAns.HeaderText = "cDeAns";
            this.cDeAns.MinimumWidth = 6;
            this.cDeAns.Name = "cDeAns";
            this.cDeAns.ReadOnly = true;
            this.cDeAns.Visible = false;
            this.cDeAns.Width = 125;
            // 
            // cSinhViens
            // 
            this.cSinhViens.HeaderText = "cSinhViens";
            this.cSinhViens.MinimumWidth = 6;
            this.cSinhViens.Name = "cSinhViens";
            this.cSinhViens.ReadOnly = true;
            this.cSinhViens.Visible = false;
            this.cSinhViens.Width = 125;
            // 
            // cTienDoes2
            // 
            this.cTienDoes2.HeaderText = "TienDoes2";
            this.cTienDoes2.MinimumWidth = 6;
            this.cTienDoes2.Name = "cTienDoes2";
            this.cTienDoes2.ReadOnly = true;
            this.cTienDoes2.Visible = false;
            this.cTienDoes2.Width = 125;
            // 
            // cStatusN
            // 
            this.cStatusN.HeaderText = "STATUS NHÓM";
            this.cStatusN.MinimumWidth = 6;
            this.cStatusN.Name = "cStatusN";
            this.cStatusN.ReadOnly = true;
            this.cStatusN.Visible = false;
            this.cStatusN.Width = 125;
            // 
            // errorThemSinhVien
            // 
            this.errorThemSinhVien.ContainerControl = this;
            // 
            // errorThemNhom
            // 
            this.errorThemNhom.ContainerControl = this;
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 606);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSinhVien";
            this.Text = "Sinh viên và Nhóm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhvien)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorThemSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorThemNhom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ComboBox cbNhom;
        private System.Windows.Forms.ComboBox cbGioitinh;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMssv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.DataGridView dgvSinhvien;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TextBox txtTenNhom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvNhom;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDNhomOfSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNhomSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTienDoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStatusS;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDeAns;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSinhViens;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTienDoes2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStatusN;
        private System.Windows.Forms.ErrorProvider errorThemSinhVien;
        private System.Windows.Forms.ErrorProvider errorThemNhom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoaSinhVien;
        private System.Windows.Forms.Button btnSuaSinhVien;
        private System.Windows.Forms.Button btnThemSinhVien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoan;
        private System.Windows.Forms.Button btnSuaNhom;
        private System.Windows.Forms.Button btnThemn;
    }
}