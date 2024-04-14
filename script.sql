USE [master]
GO
/****** Object:  Database [DUAN1]    Script Date: 14/04/2024 11:38:06 CH ******/
CREATE DATABASE [DUAN1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DUAN1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DUAN1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DUAN1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DUAN1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DUAN1] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DUAN1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DUAN1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DUAN1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DUAN1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DUAN1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DUAN1] SET ARITHABORT OFF 
GO
ALTER DATABASE [DUAN1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DUAN1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DUAN1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DUAN1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DUAN1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DUAN1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DUAN1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DUAN1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DUAN1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DUAN1] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DUAN1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DUAN1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DUAN1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DUAN1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DUAN1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DUAN1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DUAN1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DUAN1] SET RECOVERY FULL 
GO
ALTER DATABASE [DUAN1] SET  MULTI_USER 
GO
ALTER DATABASE [DUAN1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DUAN1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DUAN1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DUAN1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DUAN1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DUAN1] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DUAN1', N'ON'
GO
ALTER DATABASE [DUAN1] SET QUERY_STORE = OFF
GO
USE [DUAN1]
GO
/****** Object:  Table [dbo].[CTSANPHAM]    Script Date: 14/04/2024 11:38:07 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTSANPHAM](
	[IDCTSP] [varchar](10) NOT NULL,
	[IDNCC] [varchar](10) NULL,
	[MASP] [varchar](10) NULL,
	[IDMAU] [nvarchar](50) NULL,
	[IDCHATLIEU] [nvarchar](50) NULL,
	[IDKICHTHUOC] [nvarchar](50) NULL,
	[IDDEGIAY] [nvarchar](50) NULL,
	[SOLUONG] [int] NULL,
	[GIABAN] [int] NULL,
 CONSTRAINT [PK_CTSANPHAM] PRIMARY KEY CLUSTERED 
(
	[IDCTSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHATLIEU]    Script Date: 14/04/2024 11:38:07 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHATLIEU](
	[IDCHATLIEU] [varchar](10) NOT NULL,
	[CHATLIEU] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_CHATLIEU] PRIMARY KEY CLUSTERED 
(
	[CHATLIEU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DEGIAY]    Script Date: 14/04/2024 11:38:07 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DEGIAY](
	[IDDEGIAY] [varchar](10) NOT NULL,
	[DEGIAY] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_DEGIAY] PRIMARY KEY CLUSTERED 
(
	[DEGIAY] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 14/04/2024 11:38:07 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MAHD] [varchar](10) NOT NULL,
	[IDKH] [varchar](10) NULL,
	[IDNguoiDung] [varchar](10) NULL,
	[IDMAGIAMGIA] [varchar](10) NULL,
	[NGAYBAN] [datetime] NULL,
	[TENSP] [nvarchar](50) NULL,
	[SOLUONG] [int] NULL,
	[TONGTIEN] [int] NULL,
	[TRANGTHAI] [nvarchar](50) NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[MAHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADONCT]    Script Date: 14/04/2024 11:38:07 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADONCT](
	[MAHDCT] [varchar](10) NOT NULL,
	[MAHD] [varchar](10) NULL,
	[IDCTSP] [varchar](10) NULL,
	[SLBAN] [int] NULL,
	[GIA] [int] NULL,
	[NGAYBAN] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAHDCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KICHTHUOC]    Script Date: 14/04/2024 11:38:07 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KICHTHUOC](
	[IDKICHTHUOC] [varchar](10) NOT NULL,
	[KICHTHUOC] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_KICHTHUOC] PRIMARY KEY CLUSTERED 
(
	[KICHTHUOC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 14/04/2024 11:38:07 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[IDKH] [varchar](10) NOT NULL,
	[IDLOAIND] [varchar](10) NULL,
	[TEN] [nvarchar](50) NULL,
	[SDT] [nvarchar](15) NULL,
	[DIACHI] [nvarchar](50) NULL,
	[EMAIL] [nvarchar](50) NULL,
	[DIEM] [varchar](10) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[IDKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIKHACHHANG]    Script Date: 14/04/2024 11:38:07 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIKHACHHANG](
	[IDLOAIND] [varchar](10) NOT NULL,
	[TEN] [nvarchar](30) NULL,
	[DIEM] [varchar](10) NULL,
	[MOTA] [nvarchar](50) NULL,
 CONSTRAINT [PK_LOAIKHACHHANG] PRIMARY KEY CLUSTERED 
(
	[IDLOAIND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MAGIAMGIA]    Script Date: 14/04/2024 11:38:07 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MAGIAMGIA](
	[IDMAGIAMGIA] [varchar](10) NOT NULL,
	[TENMA] [nvarchar](50) NULL,
	[PHAMTRAMGIAM] [int] NULL,
	[NGAYBATDAU] [datetime] NULL,
	[NGAYKETTHUC] [datetime] NULL,
 CONSTRAINT [PK_MAGIAMGIA] PRIMARY KEY CLUSTERED 
(
	[IDMAGIAMGIA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MAUSAC]    Script Date: 14/04/2024 11:38:07 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MAUSAC](
	[IDMAU] [varchar](10) NOT NULL,
	[MAU] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MAUSAC] PRIMARY KEY CLUSTERED 
(
	[MAU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 14/04/2024 11:38:07 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[IDNguoiDung] [varchar](10) NOT NULL,
	[IDVaiTro] [varchar](10) NULL,
	[TEN] [nvarchar](10) NULL,
	[MatKhau] [varchar](10) NOT NULL,
	[DIACHI] [nvarchar](50) NULL,
	[EMAIL] [varchar](50) NOT NULL,
	[DTHOAI] [varchar](15) NULL,
	[Trangthai] [nvarchar](50) NULL,
 CONSTRAINT [PK_NguoiDung] PRIMARY KEY CLUSTERED 
(
	[IDNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 14/04/2024 11:38:07 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[IDNCC] [varchar](10) NOT NULL,
	[TENNCC] [nvarchar](30) NULL,
	[EMAIL] [nvarchar](50) NULL,
	[SDT] [nvarchar](15) NULL,
	[LOAIDICHVU] [nvarchar](30) NULL,
	[DIACHI] [nvarchar](100) NULL,
	[DIEUKHOANHOPTAC] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[IDNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 14/04/2024 11:38:07 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[MASP] [varchar](10) NOT NULL,
	[TENSP] [nvarchar](30) NULL,
	[SOLUONG] [int] NULL,
	[GIABAN] [int] NULL,
	[TRANGTHAI] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MASP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VaiTro]    Script Date: 14/04/2024 11:38:07 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VaiTro](
	[IDVaiTro] [varchar](10) NOT NULL,
	[Vaitro] [nvarchar](50) NULL,
 CONSTRAINT [PK_VaiTro] PRIMARY KEY CLUSTERED 
(
	[IDVaiTro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CTSANPHAM] ([IDCTSP], [IDNCC], [MASP], [IDMAU], [IDCHATLIEU], [IDKICHTHUOC], [IDDEGIAY], [SOLUONG], [GIABAN]) VALUES (N'CTSP01', N'NCC01', N'SP03', N'TRANG', N'VAI CAO CAP', N'39', N'CHIRSTY', 55, NULL)
INSERT [dbo].[CTSANPHAM] ([IDCTSP], [IDNCC], [MASP], [IDMAU], [IDCHATLIEU], [IDKICHTHUOC], [IDDEGIAY], [SOLUONG], [GIABAN]) VALUES (N'CTSP02', N'NCC01', N'SP01', N'TRANG', N'VAI CAO CAP', N'39', N'CHIRSTY', 4, NULL)
INSERT [dbo].[CTSANPHAM] ([IDCTSP], [IDNCC], [MASP], [IDMAU], [IDCHATLIEU], [IDKICHTHUOC], [IDDEGIAY], [SOLUONG], [GIABAN]) VALUES (N'CTSP03', NULL, N'SP01', N'TRANG', N'VAI CAO CAP', N'39', N'CHIRSTY', 12, NULL)
INSERT [dbo].[CTSANPHAM] ([IDCTSP], [IDNCC], [MASP], [IDMAU], [IDCHATLIEU], [IDKICHTHUOC], [IDDEGIAY], [SOLUONG], [GIABAN]) VALUES (N'CTSP04', NULL, N'SP01', N'TRANG', N'VAI CAO CAP', N'39', N'CHIRSTY', 6, NULL)
INSERT [dbo].[CTSANPHAM] ([IDCTSP], [IDNCC], [MASP], [IDMAU], [IDCHATLIEU], [IDKICHTHUOC], [IDDEGIAY], [SOLUONG], [GIABAN]) VALUES (N'CTSP05', NULL, N'SP01', N'TRANG', N'VAI CAO CAP', N'39', N'CHIRSTY', 2, NULL)
INSERT [dbo].[CTSANPHAM] ([IDCTSP], [IDNCC], [MASP], [IDMAU], [IDCHATLIEU], [IDKICHTHUOC], [IDDEGIAY], [SOLUONG], [GIABAN]) VALUES (N'CTSP06', NULL, N'SP03', N'TRANG', N'VAI CAO CAP', N'39', N'CHIRSTY', 8, NULL)
GO
INSERT [dbo].[CHATLIEU] ([IDCHATLIEU], [CHATLIEU]) VALUES (N'CL01', N'VAI CAO CAP')
INSERT [dbo].[CHATLIEU] ([IDCHATLIEU], [CHATLIEU]) VALUES (N'CL02', N'VAI TRUNG QUOC')
GO
INSERT [dbo].[DEGIAY] ([IDDEGIAY], [DEGIAY]) VALUES (N'DG01', N'CHIRSTY')
INSERT [dbo].[DEGIAY] ([IDDEGIAY], [DEGIAY]) VALUES (N'DG02', N'POLYURETHANE')
GO
INSERT [dbo].[HOADON] ([MAHD], [IDKH], [IDNguoiDung], [IDMAGIAMGIA], [NGAYBAN], [TENSP], [SOLUONG], [TONGTIEN], [TRANGTHAI]) VALUES (N'HD01', N'KH01', N'ND01', N'MGG01', CAST(N'2023-07-23T00:00:00.000' AS DateTime), N'jodan', 2, 3200, N'DA TT')
INSERT [dbo].[HOADON] ([MAHD], [IDKH], [IDNguoiDung], [IDMAGIAMGIA], [NGAYBAN], [TENSP], [SOLUONG], [TONGTIEN], [TRANGTHAI]) VALUES (N'HD02', N'KH02', N'ND02', N'MGG02', CAST(N'2023-08-05T00:00:00.000' AS DateTime), N'giay xanh', 0, 0, N'CHUA TT')
GO
INSERT [dbo].[KICHTHUOC] ([IDKICHTHUOC], [KICHTHUOC]) VALUES (N'KT02', N'39')
INSERT [dbo].[KICHTHUOC] ([IDKICHTHUOC], [KICHTHUOC]) VALUES (N'KT01', N'41')
GO
INSERT [dbo].[KHACHHANG] ([IDKH], [IDLOAIND], [TEN], [SDT], [DIACHI], [EMAIL], [DIEM]) VALUES (N'KH01', N'LKH01', N'DUNG PHAM', N'098273554', N'ME TRI', N'ABCD@GMAIL.COM', N'8')
INSERT [dbo].[KHACHHANG] ([IDKH], [IDLOAIND], [TEN], [SDT], [DIACHI], [EMAIL], [DIEM]) VALUES (N'KH02', N'LKH01', N'RONALDO', N'0392642', N'CAU GIAY', N'OOWSS@GMAIL.COM', N'20')
GO
INSERT [dbo].[LOAIKHACHHANG] ([IDLOAIND], [TEN], [DIEM], [MOTA]) VALUES (N'LKH01', N'DUNG PHAM', N'8', N' NO KHACH 20K')
INSERT [dbo].[LOAIKHACHHANG] ([IDLOAIND], [TEN], [DIEM], [MOTA]) VALUES (N'LKH02', N'MESSI', N'20', N' KHACH VIP')
GO
INSERT [dbo].[MAGIAMGIA] ([IDMAGIAMGIA], [TENMA], [PHAMTRAMGIAM], [NGAYBATDAU], [NGAYKETTHUC]) VALUES (N'MGG01', N'VALENTINE', 20, CAST(N'1894-06-08T00:00:00.000' AS DateTime), CAST(N'1894-06-17T00:00:00.000' AS DateTime))
INSERT [dbo].[MAGIAMGIA] ([IDMAGIAMGIA], [TENMA], [PHAMTRAMGIAM], [NGAYBATDAU], [NGAYKETTHUC]) VALUES (N'MGG02', N'BLACKFRIDAY', 30, CAST(N'1894-06-23T00:00:00.000' AS DateTime), CAST(N'1894-07-03T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[MAUSAC] ([IDMAU], [MAU]) VALUES (N'M02', N'TRANG')
INSERT [dbo].[MAUSAC] ([IDMAU], [MAU]) VALUES (N'M01', N'XANH')
GO
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [IDVaiTro], [TEN], [MatKhau], [DIACHI], [EMAIL], [DTHOAI], [Trangthai]) VALUES (N'ND01', N'VT01', N'phạm tiến', N'AB1111', N'HA NOI', N'VIETPQPH46072@FPT.EDU.VN', N'0358406612', N'DANG LAM')
INSERT [dbo].[NguoiDung] ([IDNguoiDung], [IDVaiTro], [TEN], [MatKhau], [DIACHI], [EMAIL], [DTHOAI], [Trangthai]) VALUES (N'ND02', N'VT02', N'phạm ABC', N'AB2222', N'VIET NAM', N'VIETPQPH@FPT.EDU.VN', N'0358406612', N'NGHI VIEC')
GO
INSERT [dbo].[NhaCungCap] ([IDNCC], [TENNCC], [EMAIL], [SDT], [LOAIDICHVU], [DIACHI], [DIEUKHOANHOPTAC]) VALUES (N'NCC01', N'HOANG HA', N'HOANGHAGIAY@FPT.EDU.VN', N'02533332', N'SI GIAY JORDAN', N'QUOC OAI', N'UY TIN')
INSERT [dbo].[NhaCungCap] ([IDNCC], [TENNCC], [EMAIL], [SDT], [LOAIDICHVU], [DIACHI], [DIEUKHOANHOPTAC]) VALUES (N'NCC02', N'PHUONG DONG', N'PHUONGDONG@FPT.EDU.VN', N'036287197', N'SI GIAY JORDAN', N'HA DONG', N'DOC QUYEN')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [SOLUONG], [GIABAN], [TRANGTHAI]) VALUES (N'SP01', N'SNEAKER JORDAN 1', 24, 1690000, N'Còn hàng')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [SOLUONG], [GIABAN], [TRANGTHAI]) VALUES (N'SP02', N'SNEAKER JORDAN 4 ', 0, 2400000, N'Hết hàng')
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [SOLUONG], [GIABAN], [TRANGTHAI]) VALUES (N'SP03', N'SNK', 53, 28000, N'Còn hàng')
GO
INSERT [dbo].[VaiTro] ([IDVaiTro], [Vaitro]) VALUES (N'VT01', N'ADMIN')
INSERT [dbo].[VaiTro] ([IDVaiTro], [Vaitro]) VALUES (N'VT02', N'NHANVIEN')
GO
ALTER TABLE [dbo].[CTSANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_CTSANPHAM_CHATLIEU] FOREIGN KEY([IDCHATLIEU])
REFERENCES [dbo].[CHATLIEU] ([CHATLIEU])
GO
ALTER TABLE [dbo].[CTSANPHAM] CHECK CONSTRAINT [FK_CTSANPHAM_CHATLIEU]
GO
ALTER TABLE [dbo].[CTSANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_CTSANPHAM_DEGIAY] FOREIGN KEY([IDDEGIAY])
REFERENCES [dbo].[DEGIAY] ([DEGIAY])
GO
ALTER TABLE [dbo].[CTSANPHAM] CHECK CONSTRAINT [FK_CTSANPHAM_DEGIAY]
GO
ALTER TABLE [dbo].[CTSANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_CTSANPHAM_KICHTHUOC] FOREIGN KEY([IDKICHTHUOC])
REFERENCES [dbo].[KICHTHUOC] ([KICHTHUOC])
GO
ALTER TABLE [dbo].[CTSANPHAM] CHECK CONSTRAINT [FK_CTSANPHAM_KICHTHUOC]
GO
ALTER TABLE [dbo].[CTSANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_CTSANPHAM_MAUSAC] FOREIGN KEY([IDMAU])
REFERENCES [dbo].[MAUSAC] ([MAU])
GO
ALTER TABLE [dbo].[CTSANPHAM] CHECK CONSTRAINT [FK_CTSANPHAM_MAUSAC]
GO
ALTER TABLE [dbo].[CTSANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_CTSANPHAM_NhaCungCap] FOREIGN KEY([IDNCC])
REFERENCES [dbo].[NhaCungCap] ([IDNCC])
GO
ALTER TABLE [dbo].[CTSANPHAM] CHECK CONSTRAINT [FK_CTSANPHAM_NhaCungCap]
GO
ALTER TABLE [dbo].[CTSANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_CTSANPHAM_SANPHAM] FOREIGN KEY([MASP])
REFERENCES [dbo].[SANPHAM] ([MASP])
GO
ALTER TABLE [dbo].[CTSANPHAM] CHECK CONSTRAINT [FK_CTSANPHAM_SANPHAM]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_KHACHHANG] FOREIGN KEY([IDKH])
REFERENCES [dbo].[KHACHHANG] ([IDKH])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_KHACHHANG]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_MAGIAMGIA] FOREIGN KEY([IDMAGIAMGIA])
REFERENCES [dbo].[MAGIAMGIA] ([IDMAGIAMGIA])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_MAGIAMGIA]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_NGUOIDUNG] FOREIGN KEY([IDNguoiDung])
REFERENCES [dbo].[NguoiDung] ([IDNguoiDung])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_NGUOIDUNG]
GO
ALTER TABLE [dbo].[HOADONCT]  WITH CHECK ADD  CONSTRAINT [FK_HOADONCT_CTSANPHAM] FOREIGN KEY([IDCTSP])
REFERENCES [dbo].[CTSANPHAM] ([IDCTSP])
GO
ALTER TABLE [dbo].[HOADONCT] CHECK CONSTRAINT [FK_HOADONCT_CTSANPHAM]
GO
ALTER TABLE [dbo].[HOADONCT]  WITH CHECK ADD  CONSTRAINT [FK_HOADONCT_HOADON] FOREIGN KEY([MAHD])
REFERENCES [dbo].[HOADON] ([MAHD])
GO
ALTER TABLE [dbo].[HOADONCT] CHECK CONSTRAINT [FK_HOADONCT_HOADON]
GO
ALTER TABLE [dbo].[KHACHHANG]  WITH CHECK ADD  CONSTRAINT [FK_KHACHHANG_LOAIKHACHHANG] FOREIGN KEY([IDLOAIND])
REFERENCES [dbo].[LOAIKHACHHANG] ([IDLOAIND])
GO
ALTER TABLE [dbo].[KHACHHANG] CHECK CONSTRAINT [FK_KHACHHANG_LOAIKHACHHANG]
GO
ALTER TABLE [dbo].[NguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_NguoiDung_VaiTro] FOREIGN KEY([IDVaiTro])
REFERENCES [dbo].[VaiTro] ([IDVaiTro])
GO
ALTER TABLE [dbo].[NguoiDung] CHECK CONSTRAINT [FK_NguoiDung_VaiTro]
GO
USE [master]
GO
ALTER DATABASE [DUAN1] SET  READ_WRITE 
GO
