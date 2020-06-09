create database BTL_QuanLyBanHang
go

use BTL_QuanLyBanHang
go

create table NhanVien(
	maNV nchar(20) primary key not null,
	tenNV nvarchar(30),
	chucVu nvarchar(20),
	luongCoBan float,
	phuCap float
)

create table TaiKhoan(
	maNV nchar(20) constraint FK_maNV foreign key (maNV) references NhanVien(maNV),
	username nchar(20) not null,
	pass nchar(30) not null,
	quyenTruyCap nvarchar(15) not null
)

create table SanPham(
	maSP nchar(20) primary key not null,
	tenSP nvarchar(40),
	donGia float,
	soLuong int
)

create table HoaDon(
	maHD nchar(15) primary key not null,
	maNV nchar(20) constraint FK_maNV1 foreign key (maNV) references NhanVien(maNV),
	maKH nchar(15),
	tenKH nvarchar(50),
	ngayLap date,
	diaChi nvarchar(30)
)

create table ChiTietHoaDon(
	maHD nchar(15),
	maSP nchar(20) constraint FK_maSP foreign key (maSP) references SanPham(maSP),
	soLuongBan int
)

create table ThongKe(
	ngayLap date,
	tongDoanhThu float
)
