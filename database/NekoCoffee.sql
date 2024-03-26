create database NekoCoffee
---------------------------------------
use NekoCoffee
---------------------------------------
SET DATEFORMAT dmy; 
---------------------------------------
create table LoaiNuoc
(
	MaLoai char(1) not null,
	TenLoai nvarchar(20) not null,
	constraint pk_LoaiNuoc primary key (MaLoai),
	CHECK (MaLoai IN ('L','N'))
);
---------------------------------------
create table Meo
(
	MaMeo nchar(5) not null,
	TenMeo nvarchar(50) not null,
	Valid bit default 1,
	constraint  pk_Meo primary key (MaMeo),
	unique (MaMeo)
);
create table ThucUong
(
	MaThucUong nchar(5) not null,
	MaLoai char(1) not null,
	TenThucUong nvarchar(50) not null,
	DonGia smallmoney default 0,
	KhaDung bit default 1,
	constraint pk_ThucUong primary key (MaThucUong, MaLoai),
	foreign key (MaLoai) references LoaiNuoc(MaLoai),
	unique (MaThucUong, MaLoai)
);
---------------------------------------
create table TaiKhoan
(
	TenDangNhap nvarchar(20) not null,
	HoTen nvarchar(100) null,
	MatKhau nvarchar(100) not null,
	LoaiTaiKhoan bit default 0,
	CMND nvarchar(10) not null unique,
	NgaySinh date not null,
	SoDT nvarchar(10) not null,
	ConLam bit default 1,
	constraint pk_TaiKhoan primary key (TenDangNhap)
);
---------------------------------------
create table Ban
(
	MaBan nchar(5) not null,
	MaTang nchar(5) not null,
	TenBan nvarchar(20) not null,
	TrangThai tinyint default 0,
	constraint pk_Ban primary key (MaBan, MaTang),
	unique (MaBan, MaTang)
);
---------------------------------------
create table HoaDon
(
	MaHD nchar(12) not null,
	NgayHD date not null,
	MaNV nvarchar(20) not null,
	MaBan nchar(5) not null,
	MaTang nchar(5) not null,
	TongTien int default 0,
	constraint pk_HoaDon primary key (MaHD),
	foreign key (MaBan, MaTang) references Ban(MaBan, MaTang),
	foreign key (MaNV) references TaiKhoan(TenDangNhap),
);
---------------------------------------
create table DonHang
(
	MaDonHang nchar(12) not null,
	MaThucUong nchar(5) not null,
	MaLoai char(1) not null,
	MaMeo nchar(5) not null,
	SoLuong tinyint not null default 0,
	MaHD nchar(12) not null,
	constraint pk_DonHang primary key (MaDonHang),
	unique (MaThucUong, MaLoai),
	foreign key (MaThucUong, MaLoai) references ThucUong(MaThucUong, MaLoai),
	foreign key (MaHD) references HoaDon(MaHD),
	foreign key (MaMeo) references Meo(MaMeo)
);
select * from DonHang

