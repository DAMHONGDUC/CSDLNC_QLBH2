﻿IF DB_ID('QLBH') IS NOT NULL 
	DROP DATABASE QLBH
GO
CREATE DATABASE QLBH
GO
USE QLBH
GO

CREATE TABLE KHACHHANG
(
MAKH CHAR(15),
HO NVARCHAR(50),
TEN NVARCHAR(15),
NGSINH DATE,
SONHA CHAR(15),
DUONG NVARCHAR(50),
PHUONG NVARCHAR(50),
QUAN NVARCHAR(50),
TPHO NVARCHAR(50),
DIENTHOAI CHAR(15)

CONSTRAINT PK_KH
PRIMARY KEY (MAKH)
)
GO

CREATE TABLE HOADON
(
MAHD CHAR(15),
MAKH_HD CHAR(15),
NGAYLAP DATE,
TONGTIEN INT

CONSTRAINT PK_HD
PRIMARY KEY (MAHD)
)
GO

CREATE TABLE CT_HOADON
(
MAHD_CT CHAR(15),
MASP_CT CHAR(15),
SOLUONG INT,
GIABAN INT,
GIAGIAM INT,
THANHTIEN INT

CONSTRAINT PK_CTHD
PRIMARY KEY (MAHD_CT, MASP_CT)
)
GO

CREATE TABLE SANPHAM
(
MASP CHAR(15),
TENSP NVARCHAR(50),
SOLUONGTON INT,
MOTA NVARCHAR(100),
GIA INT

CONSTRAINT PK_SP
PRIMARY KEY (MASP)
)
GO

ALTER TABLE HOADON
ADD
	CONSTRAINT FK_HD_KH
	FOREIGN KEY (MAKH_HD)
	REFERENCES KHACHHANG
GO

ALTER TABLE CT_HOADON
ADD 
	CONSTRAINT FK_HD_CT
	FOREIGN KEY (MAHD_CT)
	REFERENCES HOADON,

	CONSTRAINT FK_HD_SP
	FOREIGN KEY (MASP_CT)
	REFERENCES SANPHAM
GO

SELECT *
FROM HOADON

SELECT *
FROM CT_HOADON

SELECT *
FROM KHACHHANG

SELECT *
FROM SANPHAM

SELECT SUM(SP.GIA*CTHD.SOLUONG) FROM CT_HOADON CTHD, SANPHAM SP WHERE CTHD.MASP_CT = SP.MASP