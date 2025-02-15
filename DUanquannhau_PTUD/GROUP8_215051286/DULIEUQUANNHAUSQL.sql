﻿

CREATE DATABASE DULIEUQUANLYQUANNHAU

USE DULIEUQUANLYQUANNHAU
GO 

CREATE TABLE NHANVIEN 
(
	MaNV CHAR(10) NOT NULL,-- KHOA PHU CUA HOADONBANHANG
	TenNV NVARCHAR(50),
	Gioitinh NCHAR(10),
	SDT CHAR(20),
	Chucvu NVARCHAR(50),--BEP CHINH/PHU, PHUC VU,QUAN LY
	Ngaysinh DATE
)

INSERT INTO NHANVIEN (MaNV,TenNV,Gioitinh,SDT,Chucvu,Ngaysinh)
VALUES ('NV01',N'Dương Kim Tuyến',N'Nữ',0336412470,N'Bếp chính','2003-11-19'),
		('QL01',N'Nguyễn Văn Mạnh',N'Nam',0364151925,N'Quản lý','1999-04-15'),
		('NV02',N'Nguyễn Thảo Ngọc',N'Nữ',0898478808,N'Phục vụ','2001-03-12'),
		('NV03',N'Trương Thị Ngọc Như',N'Nữ',0937353723,N'Phục vụ','2003-12-28') 

CREATE TABLE TAIKHOAN
(
	
	Tendangnhap CHAR(20) NOT NULL,
	Matkhau CHAR(20),
	QuyenHan CHAR (10),
	MaNV CHAR (10)NULL

)
INSERT INTO TAIKHOAN (Tendangnhap ,Matkhau, QuyenHan,MaNV)
VALUES ('Manh','123','QL','QL01'),
		('Tuyen','456','NV','NV01'),
		('Ngoc','456','NV','NV02'),
		('Nhu','456','NV','NV03')


CREATE TABLE LUONGNHANVIEN
(
	MaNV CHAR(10)NOT NULL ,-- KHOA PHU CUA NHANVIEN
	Tongluong INT,
	Kyluong NVARCHAR(50)
)


CREATE TABLE CALAMVIEC
(
	MaNV CHAR (10)NOT NULL,
	Ngay DATE
)

CREATE TABLE KHACHHANG
(
	MaKH CHAR(10) NOT NULL,--KHOA PHU CUA HOA DON BAN HANG
	TenKH NVARCHAR(50),
	SDT CHAR(10),
	LoaiKH NVARCHAR(50),
	DiemTL INT
)
INSERT INTO KHACHHANG (MaKH, TenKH,SDT,LoaiKH,DiemTL)
VALUES('KH00',N'Khách Vãng Lai','0000000000',N'Bình Thường',0),
		('KH01',N'Lê Vĩnh Ngọc','1234567890',N'VIP',0),
		('KH02',N'Dương Vũ Kỳ Duyên','9876543210',N'Bình Thường',0)

CREATE TABLE HOADONBANHANG
(
	MaHDBH CHAR(10) NOT NULL,
	MaNV CHAR(10)NULL,
	Tenban  NVARCHAR(10)NULL,
	MaKH CHAR(10)NULL,
	NgayHDBH DATETIME,-- DE NULL CODE MAC DINH
	Thanhtien INT,
	VAT INT,--10%
	DiemTL INT,
	Giamgia INT,
	Tongtien INT
)


CREATE TABLE BAN
(
	Tenban NVARCHAR(10) NOT NULL,--KHOA PHU CUA HOADONBANHANG
	Trangthai NVARCHAR(20),-- DA DAT/TRONG
)

INSERT INTO BAN (Tenban,Trangthai)
VALUES (N'Bàn 01',N'TRỐNG'),
		(N'Bàn 02',N'TRỐNG'),
		(N'Bàn 03',N'TRỐNG'),
		(N'Bàn 04',N'TRỐNG'),
		(N'Bàn 05',N'TRỐNG'),
		(N'Bàn 06',N'TRỐNG'),
		(N'Bàn 07',N'TRỐNG'),
		(N'Bàn 08',N'TRỐNG'),
		(N'Bàn 09',N'TRỐNG'),
		(N'Bàn 10',N'TRỐNG'),
		(N'Mang Về',N'TRỐNG')

CREATE TABLE THUCDON
(
	MonAn NVARCHAR(100)NOT NULL,
	GiaTien int,
	LoaiHang NVARCHAR(20)
)

INSERT INTO THUCDON(MonAn,GiaTien,LoaiHang)
VALUES(N'LẨU DÊ',300000, N'Thức Ăn'),
(N'GÀ NƯỚNG THAN', 250000,N'Thức Ăn'),
(N'LẨU BÒ KOBE', 750000,N'Thức Ăn'),
(N'LÒNG XÀO DƯA', 500000,N'Thức Ăn'),
(N'LẨU GÀ LÁ É', 230000,N'Thức Ăn'),
(N'STING', 20000,N'Đồ Uống'),
(N'7UP', 20000,N'Đồ Uống'),
(N'PEPSI', 20000,N'Đồ Uống'),
(N'COCA', 20000,N'Đồ Uống'),
(N'BIA TIGER', 23000,N'Đồ Uống'),
(N'BIA 333', 23000,N'Đồ Uống')

CREATE TABLE MONANDABAN
(
    MaHDBH CHAR(10) NOT NULL,
	MonAn NVARCHAR(100),
	SoLuong int,
	GiaTien int
)

CREATE TABLE DATHANG 
(
	Tenban NVARCHAR (10) NOT NULL,
	SDT char(11),
	MonAn NVARCHAR (50),
	SoLuong int,
	Giatien int,
	Thanhtien int,
)

-- SET KHÓA CHÍNH 
ALTER TABLE NHANVIEN ADD CONSTRAINT PK_NHANVIEN PRIMARY KEY(MaNV)
ALTER TABLE CALAMVIEC ADD CONSTRAINT PK_CALAMVIEC PRIMARY KEY(MaNV)
ALTER TABLE KHACHHANG ADD CONSTRAINT PK_KHACHHANG PRIMARY KEY(MaKH)
ALTER TABLE HOADONBANHANG ADD CONSTRAINT PK_HOADONBANHANG PRIMARY KEY(MaHDBH)
ALTER TABLE BAN ADD CONSTRAINT PK_BAN PRIMARY KEY(Tenban)
ALTER TABLE TAIKHOAN ADD CONSTRAINT PK_TAIKHOAN PRIMARY KEY(Tendangnhap)
ALTER TABLE THUCDON ADD CONSTRAINT PK_THUCDON PRIMARY KEY(MonAn)

--SET KHOA NGOAI
ALTER TABLE LUONGNHANVIEN ADD CONSTRAINT FK_LUONGNHANVIEN_NHANVIEN
FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV)


ALTER TABLE LUONGNHANVIEN ADD CONSTRAINT FK_LUONGNHANVIEN_CALAMVIEC
FOREIGN KEY (MaNV) REFERENCES CALAMVIEC(MaNV)


ALTER TABLE HOADONBANHANG ADD CONSTRAINT FK_HOADONBANHANG_NHANVIEN
FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV)

ALTER TABLE HOADONBANHANG ADD CONSTRAINT FK_HOADONBANHANG_KHACHHANG
FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH)

ALTER TABLE HOADONBANHANG ADD CONSTRAINT FK_HOADONBANHANG_BAN
FOREIGN KEY (Tenban) REFERENCES BAN (Tenban)

ALTER TABLE TAIKHOAN ADD CONSTRAINT FK_TAIKHOAN_NHANVIEN
FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV)

ALTER TABLE CALAMVIEC ADD CONSTRAINT FK_CALAMVIEC_NHANVIEN
FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV)

ALTER TABLE MONANDABAN ADD CONSTRAINT FK_MONANDABAN_HOADONBANHANG
FOREIGN KEY (MaHDBH) REFERENCES HOADONBANHANG(MaHDBH)

ALTER TABLE DATHANG ADD CONSTRAINT FK_DATHANG_BAN
FOREIGN KEY (Tenban) REFERENCES BAN(Tenban)


ALTER TABLE MONANDABAN ADD CONSTRAINT FK_MONANDABAN_THUCDON
FOREIGN KEY (MonAn) REFERENCES THUCDON(MonAn)








