-- Created by Vertabelo (http://vertabelo.com)
-- Last modification date: 2016-01-25 10:45:45.412
Create Database ASM_khangnhdps03385
Use ASM_khangnhdps03385



-- tables
-- Table: ChiTietHoaDon
CREATE TABLE ChiTietHoaDon (
    MaSP varchar(5)  NOT NULL,
    MaHD varchar(5)  NOT NULL,
    SoLuong char(10)  NOT NULL,
    DonGia money  NOT NULL,
    CONSTRAINT ChiTietHoaDon_pk PRIMARY KEY  (MaSP)
)
;





-- Table: HoaDon
CREATE TABLE HoaDon (
    MaHD varchar(5)  NOT NULL,
    MaKH varchar(5)  NOT NULL,
    NgayHD datetime  NOT NULL,
    CONSTRAINT HoaDon_pk PRIMARY KEY  (MaHD)
)
;





-- Table: KhachHang
CREATE TABLE KhachHang (
    MaKH varchar(5)  NOT NULL,
    TenKH nvarchar(20)  NOT NULL,
    GioiTinh nvarchar(3)  NOT NULL,
    DiaChi nvarchar(40)  NOT NULL,
    SoDT char(12)  NOT NULL,
    CONSTRAINT KhachHang_pk PRIMARY KEY  (MaKH)
)
;





-- Table: LoaiSanPham
CREATE TABLE LoaiSanPham (
    MaLoaiSP varchar(5)  NOT NULL,
    TenLoaiSP nvarchar(15)  NOT NULL,
    CONSTRAINT LoaiSanPham_pk PRIMARY KEY  (MaLoaiSP)
)
;





-- Table: SanPham
CREATE TABLE SanPham (
    MaSP varchar(5)  NOT NULL,
    MaLoaiSP varchar(5)  NOT NULL,
    SoLuongSP char(15)  NOT NULL,
    ChiTietSP nvarchar(200)  NOT NULL,
    CONSTRAINT SanPham_pk PRIMARY KEY  (MaSP)
)
;









-- foreign keys
-- Reference:  ChiTietHoaDon_HoaDon (table: ChiTietHoaDon)

ALTER TABLE ChiTietHoaDon ADD CONSTRAINT ChiTietHoaDon_HoaDon 
    FOREIGN KEY (MaHD)
    REFERENCES HoaDon (MaHD)
;

-- Reference:  ChiTietHoaDon_SanPham (table: ChiTietHoaDon)

ALTER TABLE ChiTietHoaDon ADD CONSTRAINT ChiTietHoaDon_SanPham 
    FOREIGN KEY (MaSP)
    REFERENCES SanPham (MaSP)
;

-- Reference:  HoaDon_KhachHang (table: HoaDon)

ALTER TABLE HoaDon ADD CONSTRAINT HoaDon_KhachHang 
    FOREIGN KEY (MaKH)
    REFERENCES KhachHang (MaKH)
;

-- Reference:  SanPham_LoaiSanPham (table: SanPham)

ALTER TABLE SanPham ADD CONSTRAINT SanPham_LoaiSanPham 
    FOREIGN KEY (MaLoaiSP)
    REFERENCES LoaiSanPham (MaLoaiSP)
;
--Thêm dữ liệu vào bảng KhachHang
Insert into KhachHang
Values('KH1',N'Nguyễn Hoàng','Nam',N'67 Trần Huy Liệu,PN',01252306373)
Insert into KhachHang
Values('KH2',N'Trần Thị Hoa',N'Nữ',N'235 Nam Kỳ Khởi Nghĩa,Q3',0127434678)
Insert into KhachHang
Values('KH3',N'Phạm Hữu Nghĩa','Nam',N'34 Bến Nghé,Q1',01934567678)
Insert into KhachHang
Values('KH4',N'Bùi Bảo Huy','Nam',N'5 Bến Nghé,Q1',01934537879)
Insert into KhachHang
Values('KH5',N'Nguyễn Thị Hương',N'Nữ',N'7 Bến Thành,Q1',0195467890)
Insert into KhachHang
Values('KH6',N'Nguyễn Thị Hưng',N'Nữ',N'7 Bến Thành,Q1',0195467890)

--Thêm dữ liệu vào bảng HoaDon
Insert into HoaDon
Values('HD1','KH1',18/1/2016)
Insert into HoaDon
Values('HD2','KH2',13/1/2016)
Insert into HoaDon
Values('HD3','KH3',5/3/2016)
Insert into HoaDon
Values('HD4','KH4',7/2/2016)
Insert into HoaDon
Values('HD5','KH5',1/3/2016)

--Thêm dữ liệu vào bảng SanPham
Insert into SanPham
Values('SP1','ML1',100,N'Còn hàng')
Insert into SanPham
Values('SP2','ML2',100,N'Còn hàng')
Insert into SanPham
Values('SP3','ML3',50,N'Gần hết')
Insert into SanPham
Values('SP4','ML4',50,N'Gần hết')
Insert into SanPham
Values('SP5','ML5',30,N'Còn ít')

--Thêm dữ liệu vào bảng ChiTietHoaDon
Insert into ChiTietHoaDon
Values('SP1','HD1',5,100000)
Insert into ChiTietHoaDon
Values('SP2','HD2',3,85000)
Insert into ChiTietHoaDon
Values('SP3','HD3',6,7000000)
Insert into ChiTietHoaDon
Values('SP4','HD4',5,5500000)
Insert into ChiTietHoaDon
Values('SP5','HD5',8,7300000)

--Thêm dữ liệu vào bảng LoaiSanPham
Insert into LoaiSanPham
Values('ML1',N'PSP 3000')
Insert into LoaiSanPham
Values('ML2',N'Kính thực tế ảo')
Insert into LoaiSanPham
Values('ML3',N'Tai nghe')
Insert into LoaiSanPham
Values('ML4',N'Bàn phím Lazer')
Insert into LoaiSanPham
Values('ML5',N'Sạc dự phòng')





-- End of file.

