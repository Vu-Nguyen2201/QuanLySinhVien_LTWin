create database DBQuanLyDeAn
go 

use DBQuanLyDeAn
go

create table Nhom(
	IDNhom int IDENTITY(1,1) primary key,
	TenNhom nvarchar(50) null,
	status int null,
)
go
create table SinhVien(
	IDSinhVien int IDENTITY(1,1) primary key,
	HoTen nvarchar(50) Null,
	MSSV char(50) Null,
	Email char(100) Null,
	SDT char(12) null,
	GioiTinh nchar(10) Null,
	NgaySinh datetime null,
	IDNhom int null,
	FOREIGN KEY (IDNhom) REFERENCES Nhom(IDNhom),
	status int null,
)
go
create table GiaoVien(
	IDGiaoVien int IDENTITY(1,1) primary key,
	username varchar(100),
	pass varchar(100),
	HoTen nvarchar(50) Null,
	BoMon nvarchar(50) Null,
	Email char(100) Null,
	SDT char(12) null,
	GioiTinh nchar(10) Null,
	NgaySinh datetime Null,
	ad int,
	status int null,
)
go

create table DeAn(
	IDDeAn int IDENTITY(1,1) primary key,
	TenDeAn nvarchar(100) null,
	LoaiDeAn nvarchar(100) null,
	NoiDung nvarchar(500) null,
	IDNhom int null,
	FOREIGN KEY (IDNhom) REFERENCES Nhom(IDNhom),
	IDGiaoVien int null,
	FOREIGN KEY (IDGiaoVien) REFERENCES GiaoVien(IDGiaoVien),
	status int null,
)
go

create table TienDo(
	IDTienDo int IDENTITY(1,1) primary key,
	NoiDung nvarchar(500) null,
	HoanThanh int null,
	TaiLieuBaoCao nvarchar(500) null,
	ThoiGianBaoCao datetime null,
	NhanXet nvarchar(500) null,
	IDDeAn int null,
	FOREIGN KEY (IDDeAn) REFERENCES DeAn(IDDeAn),
	IDSinhVien int null,
	FOREIGN KEY (IDSinhVien) REFERENCES SinhVien(IDSinhVien),
	IDNhom int null,
	FOREIGN KEY (IDNhom) REFERENCES Nhom(IDNhom),
	status int null,
)
go

insert into Nhom(TenNhom,status)
values(N'nhóm 1-LTWin',1)
go
insert into Nhom(TenNhom,status)
values(N'nhóm 2-LTWin',1)
go
insert into Nhom(TenNhom,status)
values(N'nhóm 3-LTWin',1)
go
insert into Nhom(TenNhom,status)
values(N'nhóm 4-LTWin',1)
go
insert into Nhom(TenNhom,status)
values(N'nhóm 5-LTWin',1)
go
insert into Nhom(TenNhom,status)
values(N'nhóm 6-LTWin',1)
go
insert into Nhom(TenNhom,status)
values(N'nhóm 7-LTWin',1)
go
insert into Nhom(TenNhom,status)
values(N'nhóm 8-LTWin',1)
go

insert into SinhVien (HoTen, MSSV, Email, SDT, GioiTinh,NgaySinh,IDNhom,status)
values(N'Nguyễn Tuấn Vũ', '18133064', 'vunguyen22271@gmail.com', '0386232296', N'Nam','2000-01-01',1,1);
insert into SinhVien (HoTen, MSSV, Email, SDT, GioiTinh,NgaySinh,IDNhom,status)
values(N'Huỳnh Thị Hương ly', '181330', 'huongly21321@gmail.com', '0386232296', N'Nữ','2000-03-07',1,1);
insert into SinhVien (HoTen, MSSV, Email, SDT, GioiTinh,NgaySinh,IDNhom,status)
values(N'Phan Thành Trung', '18133059', 'phantrung1607@gmail.com', '0386232296', N'Nam','2000-07-16',1,1);
insert into SinhVien (HoTen, MSSV, Email, SDT, GioiTinh,NgaySinh,IDNhom,status)
values(N'Trần Gia Nguyên', '18133036', 'nguyêniu21@gmail.com', '0386232296', N'Nữ','2000-09-02',2,1);
insert into SinhVien (HoTen, MSSV, Email, SDT, GioiTinh,NgaySinh,IDNhom,status)
values(N'Võ Thị Thanh Ngân', '18133033', 'nganham512@gmail.com', '0847526410', N'Nữ','2000-12-25',2,1);
insert into SinhVien (HoTen, MSSV, Email, SDT, GioiTinh,NgaySinh,IDNhom,status)
values(N'Lê Đỗ Trà My', '18133030', 'mymydo@gmail.com', '031234568', N'Nữ','2000-01-02',2,1);
insert into SinhVien (HoTen, MSSV, Email, SDT, GioiTinh,NgaySinh,IDNhom,status)
values(N'Lương Uy Long', '18133026', 'longlun123@gmail.com', '0386259896', N'Nam','2000-07-07',3,1);
insert into SinhVien (HoTen, MSSV, Email, SDT, GioiTinh,NgaySinh,IDNhom,status)
values(N'Nguyễn Tuấn Phi', '18133039', 'phicucsuc11@gmail.com', '0357485985', N'Nam','2000-09-16',3,1);
insert into SinhVien (HoTen, MSSV, Email, SDT, GioiTinh,NgaySinh,IDNhom,status)
values(N'Nguyễn Thị Như Quỳnh', '18133060', 'quynhquynh71@gmail.com', '0344232296', N'Nữ','2000-07-16',3,1);
insert into SinhVien (HoTen, MSSV, Email, SDT, GioiTinh,NgaySinh,IDNhom,status)
values(N'Đào Minh Thy', '18133061', 'Thythy3625@gmail.com', '0386232296', N'Nữ','2000-10-10',4,1);
insert into SinhVien (HoTen, MSSV, Email, SDT, GioiTinh,NgaySinh,IDNhom,status)
values(N'Trần Thị Lệ Xuân', '18133069', 'xuanxuan235@gmail.com', '0984462470', N'Nữ','2000-04-30',4,1);
insert into SinhVien (HoTen, MSSV, Email, SDT, GioiTinh,NgaySinh,IDNhom,status)
values(N'Nguyễn Huỳnh Phúc Hậu', '18133015', 'phuchaunhuhau@gmail.com', '090260570', N'Nam','2000-03-03',4,1);
insert into SinhVien (HoTen, MSSV, Email, SDT, GioiTinh,NgaySinh,IDNhom,status)
values(N'Lê Đình Khang', '18133017', 'Khangkhang258@gmail.com', '0147865230', N'Nam','2000-03-22',5,1);
insert into SinhVien (HoTen, MSSV, Email, SDT, GioiTinh,NgaySinh,IDNhom,status)
values(N'Nguyễn Đăng Khoa', '18133022', 'Khoakhoa258@gmail.com', '0344210847', N'Nam','2000-06-15',6,1);
insert into SinhVien (HoTen, MSSV, Email, SDT, GioiTinh,NgaySinh,IDNhom,status)
values(N'Trương Hùng Anh', '18133001', 'anhanh258@gmail.com', '025896314', N'Nam','2000-12-17',6,1);
insert into SinhVien (HoTen, MSSV, Email, SDT, GioiTinh,NgaySinh,IDNhom,status)
values(N'Trần Hoàng An Bình', '18133003', 'binhbinh123@gmail.com', '0361475820', N'Nam','2000-05-02',6,1);
insert into SinhVien (HoTen, MSSV, Email, SDT, GioiTinh,NgaySinh,IDNhom,status)
values(N'Nguyễn Thành Công', '18133004', 'congcong257@gmail.com', '0361475820', N'Nam','2000-01-05',7,1);
insert into SinhVien (HoTen, MSSV, Email, SDT, GioiTinh,NgaySinh,IDNhom,status)
values(N'Phan Thành Đạt', '18133005', 'datdat257@gmail.com', '0361475820', N'Nam','2000-09-05',8,1);
insert into SinhVien (HoTen, MSSV, Email, SDT, GioiTinh,NgaySinh,IDNhom,status)
values(N'Trần Tiến Đức', '18133010', 'duc2358@gmail.com', '024847596', N'Nam','2000-01-08',8,1);
insert into SinhVien (HoTen, MSSV, Email, SDT, GioiTinh,NgaySinh,IDNhom,status)
values(N'Lê Chí Hiếu', '18133014', 'hieuhieu@gmail.com', '026985748', N'Nam','2000-04-08',8,1);
insert into SinhVien (HoTen, MSSV, Email, SDT, GioiTinh,NgaySinh,IDNhom,status)
values(N'Nguyễn Ngọc Hòa', '18133018', 'hohoa@gmail.com', '028968742', N'Nam','2000-10-08',8,1);
go

insert into GiaoVien (HoTen, BoMon, Email, SDT, GioiTinh,NgaySinh,username,pass,ad,status)
values (N'Huỳnh Xuân Phụng', N'Lập Trình Window', 'phx@hcmute.edu.vn', '0123456789',N'Nam','1988-03-04','phung','2512',1,1)
go
insert into GiaoVien (HoTen, BoMon, Email, SDT, GioiTinh,NgaySinh,username,pass,ad,status)
values (N'Trần Nhật Quang', N'Nhập Môn Trí Tuệ Nhân Tạo', 'tnq@hcmute.edu.vn', '0344210847',N'Nam','1989-05-16','thanhtrung','1234',0,1)
go
insert into GiaoVien (HoTen, BoMon, Email, SDT, GioiTinh,NgaySinh,username,pass,ad,status)
values (N'Trịnh Công Tú', N'Kĩ Thuật Lập Trình', 'tct@hcmute.edu.vn', '0347855240',N'Nam','1980-10-16','tuanvu','1234',0,1)
go
insert into GiaoVien (HoTen, BoMon, Email, SDT, GioiTinh,NgaySinh,username,pass,ad,status)
values (N'Lê Văn Khoan', N'Hệ Điều Hành', 'lvk.hcmute@hcmute.edu.vn', '0148963524',N'Nam','1956-04-23','levankhoan','1234',1,1)
go
insert into GiaoVien (HoTen, BoMon, Email, SDT, GioiTinh,NgaySinh,username,pass,ad,status)
values (N' Nguyễn Thành Sơn', N'Hệ Cơ Sở Dữ Liệu', 'nts.hcmute@hcmute.edu.vn', '0148963524',N'Nam','1958-08-23','nguyenthanhson','1234',0,1)
go

insert into DeAn (TenDeAn, NoiDung, LoaiDeAn, IDNhom,IDGiaoVien,status)
values (N'Quản lý đề tài sinh viên',N'Quản lý đề tài sinh viên', N'Môn học', 1,1,1)
go
insert into DeAn (TenDeAn, NoiDung, LoaiDeAn, IDNhom,IDGiaoVien,status)
values (N'báo cáo cuối kì AI', N'báo cáo cuối kì AI', N'Môn học',2,2,1)
go
insert into DeAn (TenDeAn, NoiDung, LoaiDeAn, IDNhom,IDGiaoVien,status)
values (N'Quản lý mã barcode', N'Quản lý mã barcode', N'Môn học', 6,3,1)
go
insert into DeAn (TenDeAn, NoiDung, LoaiDeAn, IDNhom,IDGiaoVien,status)
values (N'Quản lý mạng máy tính', N'Quản lý mạng máy tính', N'Môn học', 8,1,1)
go

insert into TienDo (NoiDung, TaiLieuBaoCao, ThoiGianBaoCao, NhanXet, HoanThanh, IDDeAn, IDSinhVien, IDNhom, status)
values (N'Interface', 'http://interface.com', '2020-10-10', N'Không', 0, 1, 1, 1, 1);
insert into TienDo (NoiDung, TaiLieuBaoCao, ThoiGianBaoCao, NhanXet, HoanThanh, IDDeAn, IDSinhVien, IDNhom, status)
values (N'Models', 'http://models.com', '2020-10-10', N'Không', 0, 1, 2, 1, 1);
insert into TienDo (NoiDung, TaiLieuBaoCao, ThoiGianBaoCao, NhanXet, HoanThanh, IDDeAn, IDSinhVien, IDNhom, status)
values (N'Controllers', 'http://controllers.com', '2020-10-10', N'Không', 0, 1, 3, 1, 1);
insert into TienDo (NoiDung, TaiLieuBaoCao, ThoiGianBaoCao, NhanXet, HoanThanh, IDDeAn, IDSinhVien, IDNhom, status)
values (N'Interface', 'http://interface.com', '2020-10-10', N'Không', 0, 2, 4, 2, 1);
insert into TienDo (NoiDung, TaiLieuBaoCao, ThoiGianBaoCao, NhanXet, HoanThanh, IDDeAn, IDSinhVien, IDNhom, status)
values (N'Models', 'http://models.com', '2020-10-10', N'Không', 0, 2, 5, 2, 1);
insert into TienDo (NoiDung, TaiLieuBaoCao, ThoiGianBaoCao, NhanXet, HoanThanh, IDDeAn, IDSinhVien, IDNhom, status)
values (N'Controllers', 'http://controllers.com', '2020-10-10', N'Không', 0, 2, 6, 2, 1);