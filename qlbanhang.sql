USE [master]
GO
/****** Object:  Database [QuanLyBanHangv2]    Script Date: 11/6/2018 11:00:55 AM ******/
CREATE DATABASE [QuanLyBanHangv2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyBanHangv2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\QuanLyBanHangv2.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyBanHangv2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\QuanLyBanHangv2_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyBanHangv2] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyBanHangv2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyBanHangv2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyBanHangv2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyBanHangv2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyBanHangv2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyBanHangv2] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyBanHangv2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyBanHangv2] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyBanHangv2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyBanHangv2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyBanHangv2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyBanHangv2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyBanHangv2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyBanHangv2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyBanHangv2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyBanHangv2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyBanHangv2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyBanHangv2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyBanHangv2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyBanHangv2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyBanHangv2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyBanHangv2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyBanHangv2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyBanHangv2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyBanHangv2] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyBanHangv2] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyBanHangv2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyBanHangv2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyBanHangv2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyBanHangv2] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyBanHangv2', N'ON'
GO
USE [QuanLyBanHangv2]
GO
/****** Object:  Table [dbo].[khachhang]    Script Date: 11/6/2018 11:00:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khachhang](
	[hoten] [nchar](10) NULL,
	[diachi] [nchar](10) NULL,
	[makh] [nchar](10) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_CTHD]    Script Date: 11/6/2018 11:00:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_CTHD](
	[MaHoaDon] [nvarchar](11) NOT NULL,
	[MaHang] [nvarchar](11) NOT NULL,
	[DonGia] [money] NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_tb_CTHD] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC,
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_DoanhSo]    Script Date: 11/6/2018 11:00:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_DoanhSo](
	[MaHD] [nvarchar](11) NOT NULL,
	[DoanhThu] [money] NOT NULL,
 CONSTRAINT [PK_tb_DoanhSo] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_HangHoa1]    Script Date: 11/6/2018 11:00:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_HangHoa1](
	[MaHang] [nvarchar](11) NOT NULL,
	[TenHang] [nvarchar](40) NOT NULL,
	[ThuongHieu] [nvarchar](50) NOT NULL,
	[DonGia] [money] NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_tb_HangHoa1] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_HoaDon1]    Script Date: 11/6/2018 11:00:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_HoaDon1](
	[MaHD] [nvarchar](11) NOT NULL,
	[MaKH] [nvarchar](10) NOT NULL,
	[MaNV] [nvarchar](10) NOT NULL,
	[NgayLap] [date] NOT NULL,
	[TongSoTien] [money] NOT NULL,
 CONSTRAINT [PK_tb_HoaDon1] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_KhachHang]    Script Date: 11/6/2018 11:00:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_KhachHang](
	[MaKH] [nvarchar](10) NOT NULL,
	[TenKH] [nvarchar](40) NOT NULL,
	[SDTKH] [nvarchar](50) NOT NULL,
	[GioiTinhKH] [nvarchar](4) NOT NULL,
	[DiaChiKH] [nvarchar](40) NOT NULL,
 CONSTRAINT [PK_tb_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_NhanVien]    Script Date: 11/6/2018 11:00:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_NhanVien](
	[MaNV] [nvarchar](10) NOT NULL,
	[TenNV] [nvarchar](40) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](4) NULL,
	[DiaChi] [nvarchar](40) NULL,
	[SDT] [nvarchar](11) NULL,
	[NgayCapNhat] [date] NULL,
 CONSTRAINT [PK_tb_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_QLTaiKhoan]    Script Date: 11/6/2018 11:00:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_QLTaiKhoan](
	[taikhoan] [nvarchar](15) NOT NULL,
	[matkhau] [nvarchar](15) NOT NULL,
	[quyen] [nvarchar](5) NOT NULL,
	[MaNV] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_tb_QLTaiKhoan_1] PRIMARY KEY CLUSTERED 
(
	[taikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[khachhang] ([hoten], [diachi], [makh]) VALUES (N'nguyen a  ', NULL, NULL)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'1HDKH034DI', N'HHDT1114', 4000000.0000, 2)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'1HDKH034DI', N'HHDT117', 1900000.0000, 3)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'1HDKH635NG', N'HHDT117', 1900000.0000, 3)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'1HDKH713DO', N'HHDT1981', 7000000.0000, 2)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'1HDKH713DO', N'HHDT883', 7800000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'1HDKH789NG', N'HHDT8137', 890000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'1HDKH801DU', N'HHDT320', 22900000.0000, 20)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'1HDKH819NG', N'HHDT446', 190000.0000, 5)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'1HDKH819NG', N'HHDT8137', 890000.0000, 2)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'1HDKH841PH', N'HHDT2428', 32900000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'1HDKH841PH', N'HHDT446', 190000.0000, 195)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'1HDKH841PH', N'HHDT6713', 990000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'1HDKH841PH', N'HHDT717', 489000.0000, 10)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'2HDKH034DI', N'HHDT7040', 6000000.0000, 5)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'2HDKH635NG', N'HHDT2428', 32900000.0000, 3)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'2HDKH713DO', N'HHDT7040', 6000000.0000, 2)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'2HDKH789NG', N'HHDT2442', 7000000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'2HDKH789NG', N'HHDT320', 22900000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'2HDKH819NG', N'HHDT117', 1900000.0000, 3)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'2HDKH841PH', N'HHDT717', 489000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'3HDKH635NG', N'HHDT883', 7800000.0000, 3)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'3HDKH713DO', N'HHDT7040', 6000000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'3HDKH789NG', N'HHDT1981', 7000000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'3HDKH801DU', N'HHDT117', 1900000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'3HDKH801DU', N'HHDT2428', 32900000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'3HDKH801DU', N'HHDT320', 22900000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'3HDKH819NG', N'HHDT7040', 6000000.0000, 3)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'3HDKH841PH', N'HHDT3784', 4000000.0000, 4)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'4HDKH635NG', N'HHDT320', 22900000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'4HDKH713DO', N'HHDT1981', 7000000.0000, 4)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'4HDKH713DO', N'HHDT6713', 990000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'4HDKH789NG', N'HHDT2428', 32900000.0000, 3)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'4HDKH801DU', N'HHDT1114', 4000000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'4HDKH801DU', N'HHDT117', 1900000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'4HDKH801DU', N'HHDT1981', 7000000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'4HDKH801DU', N'HHDT2428', 32900000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'4HDKH819NG', N'HHDT1114', 4000000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'4HDKH819NG', N'HHDT117', 1900000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'4HDKH841PH', N'HHDT717', 489000.0000, 3)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'5HDKH635NG', N'HHDT1114', 4000000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'5HDKH635NG', N'HHDT3784', 4000000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'5HDKH635NG', N'HHDT6713', 990000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'5HDKH713DO', N'HHDT320', 22900000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'5HDKH789NG', N'HHDT117', 1900000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'5HDKH789NG', N'HHDT1981', 7000000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'5HDKH789NG', N'HHDT3784', 4000000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'5HDKH801DU', N'HHDT1981', 7000000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'5HDKH801DU', N'HHDT2428', 32900000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'5HDKH801DU', N'HHDT2442', 7000000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'5HDKH801DU', N'HHDT320', 22900000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'5HDKH801DU', N'HHDT6713', 990000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'5HDKH819NG', N'HHDT3784', 4000000.0000, 3)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'5HDKH841PH', N'HHDT117', 1900000.0000, 3)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'5HDKH841PH', N'HHDT2442', 7000000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'5HDKH841PH', N'HHDT717', 489000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'5HDKH841PH', N'HHDT8294', 799000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'6HDKH713DO', N'HHDT117', 1900000.0000, 2)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'6HDKH713DO', N'HHDT3784', 4000000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'6HDKH789NG', N'HHDT1981', 7000000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'6HDKH789NG', N'HHDT2442', 7000000.0000, 3)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'6HDKH789NG', N'HHDT320', 22900000.0000, 2)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'6HDKH789NG', N'HHDT8124', 590000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'6HDKH789NG', N'HHDT8294', 799000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'6HDKH789NG', N'HHDT883', 7800000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'6HDKH801DU', N'HHDT1981', 7000000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'6HDKH819NG', N'HHDT2442', 7000000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'6HDKH819NG', N'HHDT8137', 890000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'6HDKH841PH', N'HHDT2428', 32900000.0000, 5)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'7HDKH713DO', N'HHDT1114', 4000000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'7HDKH713DO', N'HHDT117', 1900000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'7HDKH713DO', N'HHDT1981', 7000000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'7HDKH713DO', N'HHDT2428', 32900000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'7HDKH713DO', N'HHDT2442', 7000000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'7HDKH713DO', N'HHDT320', 22900000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'7HDKH713DO', N'HHDT3784', 4000000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'7HDKH713DO', N'HHDT8294', 799000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'7HDKH713DO', N'HHDT883', 7800000.0000, 1)
INSERT [dbo].[tb_CTHD] ([MaHoaDon], [MaHang], [DonGia], [SoLuong]) VALUES (N'7HDKH801DU', N'HHDT7040', 6000000.0000, 1)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'1HDKH034DI', 13700000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'1HDKH635NG', 5700000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'1HDKH713DO', 21800000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'1HDKH789NG', 890000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'1HDKH801DU', 458000000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'1HDKH819NG', 2730000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'1HDKH841PH', 75830000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'2HDKH034DI', 30000000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'2HDKH635NG', 98700000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'2HDKH713DO', 12000000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'2HDKH789NG', 29900000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'2HDKH819NG', 5700000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'2HDKH841PH', 489000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'3HDKH635NG', 23400000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'3HDKH713DO', 6000000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'3HDKH789NG', 7000000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'3HDKH801DU', 57700000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'3HDKH819NG', 18000000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'3HDKH841PH', 16000000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'4HDKH635NG', 22900000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'4HDKH713DO', 28990000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'4HDKH789NG', 98700000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'4HDKH801DU', 45800000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'4HDKH819NG', 5900000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'4HDKH841PH', 1467000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'5HDKH635NG', 8990000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'5HDKH713DO', 22900000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'5HDKH789NG', 12900000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'5HDKH801DU', 70790000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'5HDKH819NG', 12000000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'5HDKH841PH', 13988000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'6HDKH713DO', 7800000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'6HDKH789NG', 82989000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'6HDKH801DU', 7000000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'6HDKH819NG', 7890000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'6HDKH841PH', 164500000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'7HDKH713DO', 88299000.0000)
INSERT [dbo].[tb_DoanhSo] ([MaHD], [DoanhThu]) VALUES (N'7HDKH801DU', 6000000.0000)
INSERT [dbo].[tb_HangHoa1] ([MaHang], [TenHang], [ThuongHieu], [DonGia], [SoLuong]) VALUES (N'HHDT1114', N'TI VI', N'SONY', 4000000.0000, 94)
INSERT [dbo].[tb_HangHoa1] ([MaHang], [TenHang], [ThuongHieu], [DonGia], [SoLuong]) VALUES (N'HHDT117', N'TAI NGHE', N'SONY', 1900000.0000, 26)
INSERT [dbo].[tb_HangHoa1] ([MaHang], [TenHang], [ThuongHieu], [DonGia], [SoLuong]) VALUES (N'HHDT1981', N'LOA KEO', N'JBL', 7000000.0000, 67)
INSERT [dbo].[tb_HangHoa1] ([MaHang], [TenHang], [ThuongHieu], [DonGia], [SoLuong]) VALUES (N'HHDT2428', N'IPHONE XSMAX', N'APPLE', 32900000.0000, 134)
INSERT [dbo].[tb_HangHoa1] ([MaHang], [TenHang], [ThuongHieu], [DonGia], [SoLuong]) VALUES (N'HHDT2442', N'TU LANH', N'SAMSUNG', 7000000.0000, 42)
INSERT [dbo].[tb_HangHoa1] ([MaHang], [TenHang], [ThuongHieu], [DonGia], [SoLuong]) VALUES (N'HHDT320', N'GALAXY NOTE9', N'SAMSUNG', 22900000.0000, 152)
INSERT [dbo].[tb_HangHoa1] ([MaHang], [TenHang], [ThuongHieu], [DonGia], [SoLuong]) VALUES (N'HHDT3784', N'MAY LANH', N'LG', 4000000.0000, 18)
INSERT [dbo].[tb_HangHoa1] ([MaHang], [TenHang], [ThuongHieu], [DonGia], [SoLuong]) VALUES (N'HHDT446', N'CHUOT KHONG DAY', N'LENOVO', 190000.0000, 0)
INSERT [dbo].[tb_HangHoa1] ([MaHang], [TenHang], [ThuongHieu], [DonGia], [SoLuong]) VALUES (N'HHDT6713', N'LOA MAY TINH ', N'SOUNDMAX', 990000.0000, 46)
INSERT [dbo].[tb_HangHoa1] ([MaHang], [TenHang], [ThuongHieu], [DonGia], [SoLuong]) VALUES (N'HHDT7040', N'MAY GIAT', N'PANASONIC', 6000000.0000, 28)
INSERT [dbo].[tb_HangHoa1] ([MaHang], [TenHang], [ThuongHieu], [DonGia], [SoLuong]) VALUES (N'HHDT717', N'USB 32G', N'KINGMAX', 489000.0000, 385)
INSERT [dbo].[tb_HangHoa1] ([MaHang], [TenHang], [ThuongHieu], [DonGia], [SoLuong]) VALUES (N'HHDT8124', N'LOA DI DONG', N'JBL', 590000.0000, 119)
INSERT [dbo].[tb_HangHoa1] ([MaHang], [TenHang], [ThuongHieu], [DonGia], [SoLuong]) VALUES (N'HHDT8137', N'QUAT MAY', N'QUOC VIET', 890000.0000, 96)
INSERT [dbo].[tb_HangHoa1] ([MaHang], [TenHang], [ThuongHieu], [DonGia], [SoLuong]) VALUES (N'HHDT8294', N'LOA BLUETOOTH', N'XIAOMI', 799000.0000, 297)
INSERT [dbo].[tb_HangHoa1] ([MaHang], [TenHang], [ThuongHieu], [DonGia], [SoLuong]) VALUES (N'HHDT883', N'LAPTOP', N'ASUS', 7800000.0000, 24)
INSERT [dbo].[tb_HangHoa1] ([MaHang], [TenHang], [ThuongHieu], [DonGia], [SoLuong]) VALUES (N'HHDT8862', N'LAPTOP', N'ACER', 8900000.0000, 40)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'1HDKH034DI', N'KH034DI', N'NV001', CAST(0xEB3E0B00 AS Date), 13700000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'1HDKH635NG', N'KH635NG', N'NV001', CAST(0xEB3E0B00 AS Date), 5700000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'1HDKH713DO', N'KH713DO', N'NV003', CAST(0xEB3E0B00 AS Date), 21800000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'1HDKH789NG', N'KH789NG', N'NV001', CAST(0xEB3E0B00 AS Date), 890000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'1HDKH801DU', N'KH801DU', N'NV001', CAST(0xEB3E0B00 AS Date), 458000000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'1HDKH819NG', N'KH819NG', N'NV003', CAST(0xEB3E0B00 AS Date), 2730000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'1HDKH841PH', N'KH841PH', N'NV001', CAST(0xEB3E0B00 AS Date), 75830000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'2HDKH034DI', N'KH034DI', N'NV001', CAST(0xEB3E0B00 AS Date), 30000000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'2HDKH635NG', N'KH635NG', N'NV001', CAST(0xEB3E0B00 AS Date), 98700000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'2HDKH713DO', N'KH713DO', N'NV001', CAST(0xEB3E0B00 AS Date), 12000000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'2HDKH789NG', N'KH789NG', N'NV001', CAST(0xEB3E0B00 AS Date), 29900000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'2HDKH819NG', N'KH819NG', N'NV001', CAST(0xEB3E0B00 AS Date), 5700000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'2HDKH841PH', N'KH841PH', N'NV001', CAST(0xEB3E0B00 AS Date), 489000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'3HDKH635NG', N'KH635NG', N'NV001', CAST(0xEB3E0B00 AS Date), 23400000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'3HDKH713DO', N'KH713DO', N'NV001', CAST(0xEB3E0B00 AS Date), 6000000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'3HDKH789NG', N'KH789NG', N'NV005', CAST(0xEB3E0B00 AS Date), 7000000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'3HDKH801DU', N'KH801DU', N'NV001', CAST(0xEB3E0B00 AS Date), 57700000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'3HDKH819NG', N'KH819NG', N'NV001', CAST(0xEB3E0B00 AS Date), 18000000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'3HDKH841PH', N'KH841PH', N'NV001', CAST(0xEB3E0B00 AS Date), 16000000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'4HDKH635NG', N'KH635NG', N'NV001', CAST(0xEB3E0B00 AS Date), 22900000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'4HDKH713DO', N'KH713DO', N'NV001', CAST(0xEB3E0B00 AS Date), 28990000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'4HDKH789NG', N'KH789NG', N'NV001', CAST(0xEB3E0B00 AS Date), 98700000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'4HDKH801DU', N'KH801DU', N'NV001', CAST(0xEB3E0B00 AS Date), 45800000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'4HDKH819NG', N'KH819NG', N'NV001', CAST(0xEB3E0B00 AS Date), 5900000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'4HDKH841PH', N'KH841PH', N'NV001', CAST(0xEB3E0B00 AS Date), 1467000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'5HDKH635NG', N'KH635NG', N'NV007', CAST(0xEB3E0B00 AS Date), 8990000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'5HDKH713DO', N'KH713DO', N'NV001', CAST(0xEB3E0B00 AS Date), 22900000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'5HDKH789NG', N'KH789NG', N'NV001', CAST(0xEB3E0B00 AS Date), 12900000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'5HDKH801DU', N'KH801DU', N'NV001', CAST(0xEB3E0B00 AS Date), 70790000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'5HDKH819NG', N'KH819NG', N'NV001', CAST(0xEB3E0B00 AS Date), 12000000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'5HDKH841PH', N'KH841PH', N'NV001', CAST(0xEB3E0B00 AS Date), 13988000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'6HDKH713DO', N'KH713DO', N'NV001', CAST(0xEB3E0B00 AS Date), 7800000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'6HDKH789NG', N'KH789NG', N'NV001', CAST(0xEB3E0B00 AS Date), 82989000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'6HDKH801DU', N'KH801DU', N'NV001', CAST(0xEB3E0B00 AS Date), 7000000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'6HDKH819NG', N'KH819NG', N'NV001', CAST(0xEB3E0B00 AS Date), 7890000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'6HDKH841PH', N'KH841PH', N'NV001', CAST(0xEB3E0B00 AS Date), 164500000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'7HDKH713DO', N'KH713DO', N'NV007', CAST(0xEB3E0B00 AS Date), 88299000.0000)
INSERT [dbo].[tb_HoaDon1] ([MaHD], [MaKH], [MaNV], [NgayLap], [TongSoTien]) VALUES (N'7HDKH801DU', N'KH801DU', N'NV001', CAST(0xEB3E0B00 AS Date), 6000000.0000)
INSERT [dbo].[tb_KhachHang] ([MaKH], [TenKH], [SDTKH], [GioiTinhKH], [DiaChiKH]) VALUES (N'KH034DI', N'DINH THUY HIEN', N'01683984034', N'Nữ', N'BINH DINH')
INSERT [dbo].[tb_KhachHang] ([MaKH], [TenKH], [SDTKH], [GioiTinhKH], [DiaChiKH]) VALUES (N'KH635NG', N'NGUYEN DINH TIEN', N'0975491635', N'Nam', N'DA NANG')
INSERT [dbo].[tb_KhachHang] ([MaKH], [TenKH], [SDTKH], [GioiTinhKH], [DiaChiKH]) VALUES (N'KH713DO', N'DOAN THANH HUYEN', N'0968394713', N'Nữ', N'DALAT')
INSERT [dbo].[tb_KhachHang] ([MaKH], [TenKH], [SDTKH], [GioiTinhKH], [DiaChiKH]) VALUES (N'KH789NG', N'NGUYEN BA DAO', N'0123456789', N'Nữ', N'DA NANG')
INSERT [dbo].[tb_KhachHang] ([MaKH], [TenKH], [SDTKH], [GioiTinhKH], [DiaChiKH]) VALUES (N'KH801DU', N'DUONG TUNG LAM', N'01687479801', N'Nam', N'HO CHI MINH')
INSERT [dbo].[tb_KhachHang] ([MaKH], [TenKH], [SDTKH], [GioiTinhKH], [DiaChiKH]) VALUES (N'KH819NG', N'NGUYEN VAN LANH', N'0968374819', N'Nam', N'DAK LAK')
INSERT [dbo].[tb_KhachHang] ([MaKH], [TenKH], [SDTKH], [GioiTinhKH], [DiaChiKH]) VALUES (N'KH841PH', N'PHAN VAN THANG', N'01684920841', N'Nam', N'QUANG TRI')
INSERT [dbo].[tb_NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [NgayCapNhat]) VALUES (N'NV001', N'PHAM VAN HIEP', CAST(0x71210B00 AS Date), N'Nam', N'DA LAT', N'01663809931', CAST(0xEB3E0B00 AS Date))
INSERT [dbo].[tb_NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [NgayCapNhat]) VALUES (N'NV002', N'KHAU TAN DAT', CAST(0x48220B00 AS Date), N'Nam', N'HO CHI MINH', N'01637981262', CAST(0xEA3E0B00 AS Date))
INSERT [dbo].[tb_NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [NgayCapNhat]) VALUES (N'NV003', N'VUONG NGOC MAI', CAST(0x2D210B00 AS Date), N'Nam', N'HA NOI', N'01689473842', CAST(0xEB3E0B00 AS Date))
INSERT [dbo].[tb_NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [NgayCapNhat]) VALUES (N'NV004', N'TRAN THANH THUY', CAST(0xAA240B00 AS Date), N'Nữ', N'HO CHI MINH', N'01682894729', CAST(0xEB3E0B00 AS Date))
INSERT [dbo].[tb_NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [NgayCapNhat]) VALUES (N'NV005', N'HOANG THI MY HA', CAST(0xEC220B00 AS Date), N'Nữ', N'HA NOI', N'01689493349', CAST(0xEB3E0B00 AS Date))
INSERT [dbo].[tb_NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [NgayCapNhat]) VALUES (N'NV006', N'NGUYEN CHI CONG', CAST(0xA61D0B00 AS Date), N'Nam', N'HO CHI MINH ', N'0983692452', CAST(0xEB3E0B00 AS Date))
INSERT [dbo].[tb_NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [NgayCapNhat]) VALUES (N'NV007', N'NGUYEN THI TUYET HOA', CAST(0xC6210B00 AS Date), N'Nữ', N'TAN PHU', N'0123456789', CAST(0xEB3E0B00 AS Date))
INSERT [dbo].[tb_QLTaiKhoan] ([taikhoan], [matkhau], [quyen], [MaNV]) VALUES (N'admin', N'1', N'admin', N'NV001')
INSERT [dbo].[tb_QLTaiKhoan] ([taikhoan], [matkhau], [quyen], [MaNV]) VALUES (N'admin1', N'1', N'admin', N'NV002')
INSERT [dbo].[tb_QLTaiKhoan] ([taikhoan], [matkhau], [quyen], [MaNV]) VALUES (N'nhanvien', N'123', N'user', N'NV003')
INSERT [dbo].[tb_QLTaiKhoan] ([taikhoan], [matkhau], [quyen], [MaNV]) VALUES (N'nhanvien1', N'123', N'user', N'NV004')
INSERT [dbo].[tb_QLTaiKhoan] ([taikhoan], [matkhau], [quyen], [MaNV]) VALUES (N'nhanvien2', N'123', N'user', N'NV005')
INSERT [dbo].[tb_QLTaiKhoan] ([taikhoan], [matkhau], [quyen], [MaNV]) VALUES (N'nhanvien3', N'321', N'user', N'NV006')
INSERT [dbo].[tb_QLTaiKhoan] ([taikhoan], [matkhau], [quyen], [MaNV]) VALUES (N'nhanvien4', N'321', N'user', N'NV007')
ALTER TABLE [dbo].[tb_CTHD]  WITH CHECK ADD  CONSTRAINT [FK_tb_CTHD_tb_HangHoa11] FOREIGN KEY([MaHang])
REFERENCES [dbo].[tb_HangHoa1] ([MaHang])
GO
ALTER TABLE [dbo].[tb_CTHD] CHECK CONSTRAINT [FK_tb_CTHD_tb_HangHoa11]
GO
ALTER TABLE [dbo].[tb_CTHD]  WITH CHECK ADD  CONSTRAINT [FK_tb_CTHD_tb_HoaDon11] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[tb_HoaDon1] ([MaHD])
GO
ALTER TABLE [dbo].[tb_CTHD] CHECK CONSTRAINT [FK_tb_CTHD_tb_HoaDon11]
GO
ALTER TABLE [dbo].[tb_DoanhSo]  WITH CHECK ADD  CONSTRAINT [FK_tb_DoanhSo_tb_HoaDon11] FOREIGN KEY([MaHD])
REFERENCES [dbo].[tb_HoaDon1] ([MaHD])
GO
ALTER TABLE [dbo].[tb_DoanhSo] CHECK CONSTRAINT [FK_tb_DoanhSo_tb_HoaDon11]
GO
ALTER TABLE [dbo].[tb_HoaDon1]  WITH CHECK ADD  CONSTRAINT [FK_tb_HoaDon1_tb_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[tb_KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[tb_HoaDon1] CHECK CONSTRAINT [FK_tb_HoaDon1_tb_KhachHang]
GO
ALTER TABLE [dbo].[tb_HoaDon1]  WITH CHECK ADD  CONSTRAINT [FK_tb_HoaDon1_tb_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tb_NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tb_HoaDon1] CHECK CONSTRAINT [FK_tb_HoaDon1_tb_NhanVien]
GO
ALTER TABLE [dbo].[tb_QLTaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_tb_QLTaiKhoan_tb_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tb_NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tb_QLTaiKhoan] CHECK CONSTRAINT [FK_tb_QLTaiKhoan_tb_NhanVien]
GO
USE [master]
GO
ALTER DATABASE [QuanLyBanHangv2] SET  READ_WRITE 
GO
