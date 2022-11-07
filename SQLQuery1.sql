create database QLNH
go
use QLNH
go
create table ChucVu(
   Ma varchar(20) not null primary key,
   Ten varchar(30) not null,
)

go
create table TaiKhoan(
   Ma varchar(20) not null primary key,
   Anh image,
   HoTen nvarchar(30) not null,
   GioiTinh nvarchar(10) not null,
   NgaySinh varchar(100) not null,
   DiaChi nvarchar(1000) not null,
   TrangThai int default 0,
   TenDangNhap varchar(50) not null,
   MatKhau varchar(50) not null,
   MaCV varchar(20) not null foreign key references ChucVu(Ma),
)

go
create table LoaiHang(
   Ma varchar(20) not null primary key,
   Ten nvarchar(50) not null,
)

go
create table Nsx(
   Ma varchar(20) not null primary key,
   Ten nvarchar(50) not null,
)

go
create table Hang(
    Ma varchar(20) not null primary key,
	Anh image,
    Ten nvarchar(50) not null,
	GiaNhap money not null,
	GiaBan money not null,
	SoLuong int not null,
	MaLH varchar(20) not null foreign key references LoaiHang(Ma),
	MaNsx varchar(20) not null foreign key references Nsx(Ma),
)

go
create table Ban(
    Ma varchar(20) not null primary key,
	Ten nvarchar(50) not null,
	TrangThai int default 0,
)

go
create table HoaDon(
    Ma varchar(20) not null primary key,
	MaTK varchar(20) not null foreign key references TaiKhoan(Ma),
	MaB varchar(20) not null foreign key references Ban(Ma),
	ngaytao datetime,
	trangThai int,
	thanhTien money,
)
go
create table HoaDonChiTiet(
    MaHoaDon varchar(20) not null foreign key references HoaDon(Ma),
    MaH varchar(20) not null foreign key references Hang(Ma),
    SoLuong int not null,
	TongTien money not null,
	Constraint PK_HoaDon_Hang Primary Key (MaHoaDon, MaH)
)

