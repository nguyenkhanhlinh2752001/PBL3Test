USE [master]
GO
/****** Object:  Database [qlchungcu]    Script Date: 5/31/2021 6:32:07 PM ******/
CREATE DATABASE [qlchungcu]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'qlchungcu', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\qlchungcu.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'qlchungcu_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\qlchungcu_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [qlchungcu] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [qlchungcu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [qlchungcu] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [qlchungcu] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [qlchungcu] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [qlchungcu] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [qlchungcu] SET ARITHABORT OFF 
GO
ALTER DATABASE [qlchungcu] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [qlchungcu] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [qlchungcu] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [qlchungcu] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [qlchungcu] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [qlchungcu] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [qlchungcu] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [qlchungcu] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [qlchungcu] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [qlchungcu] SET  ENABLE_BROKER 
GO
ALTER DATABASE [qlchungcu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [qlchungcu] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [qlchungcu] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [qlchungcu] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [qlchungcu] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [qlchungcu] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [qlchungcu] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [qlchungcu] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [qlchungcu] SET  MULTI_USER 
GO
ALTER DATABASE [qlchungcu] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [qlchungcu] SET DB_CHAINING OFF 
GO
ALTER DATABASE [qlchungcu] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [qlchungcu] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [qlchungcu] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [qlchungcu] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [qlchungcu] SET QUERY_STORE = OFF
GO
USE [qlchungcu]
GO
/****** Object:  Table [dbo].[canho]    Script Date: 5/31/2021 6:32:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[canho](
	[macanho] [int] NOT NULL,
	[makhu] [int] NULL,
	[maho] [int] NULL,
	[loaicanho] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[macanho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[chitietcanho]    Script Date: 5/31/2021 6:32:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitietcanho](
	[mavatdung] [int] NOT NULL,
	[macanho] [int] NULL,
	[vatdung] [nvarchar](100) NOT NULL,
	[soluong] [int] NOT NULL,
	[dongia] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[mavatdung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[chitiethoadon]    Script Date: 5/31/2021 6:32:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitiethoadon](
	[mahoadon] [int] NOT NULL,
	[madichvu] [int] NOT NULL,
	[soluong] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[mahoadon] ASC,
	[madichvu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[chucvu]    Script Date: 5/31/2021 6:32:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chucvu](
	[machucvu] [int] NOT NULL,
	[tenchucvu] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[machucvu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dichvu]    Script Date: 5/31/2021 6:32:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dichvu](
	[madichvu] [int] NOT NULL,
	[tendichvu] [nvarchar](100) NOT NULL,
	[gia] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[madichvu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hoadondichvu]    Script Date: 5/31/2021 6:32:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoadondichvu](
	[mahoadon] [int] NOT NULL,
	[macanho] [int] NULL,
	[manhanvien] [int] NULL,
	[tongtien] [float] NOT NULL,
	[dathanhtoan] [bit] NOT NULL,
	[ngaylap] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[mahoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hogiadinh]    Script Date: 5/31/2021 6:32:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hogiadinh](
	[maho] [int] NOT NULL,
	[tenchuho] [nvarchar](50) NULL,
	[sothanhvien] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[maho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hopdong]    Script Date: 5/31/2021 6:32:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hopdong](
	[mahopdong] [int] NOT NULL,
	[manhanvien] [int] NULL,
	[macanho] [int] NULL,
	[maho] [int] NULL,
	[tenhopdong] [nvarchar](100) NOT NULL,
	[giatien] [float] NOT NULL,
	[thoihan] [int] NOT NULL,
	[ngayki] [date] NOT NULL,
	[dahuy] [bit] NOT NULL,
	[davao] [bit] NOT NULL,
	[thoigianconlai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[mahopdong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[khu]    Script Date: 5/31/2021 6:32:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khu](
	[makhu] [int] NOT NULL,
	[tenkhu] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[makhu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 5/31/2021 6:32:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanvien](
	[manhanvien] [int] NOT NULL,
	[machucvu] [int] NULL,
	[tennhanvien] [nvarchar](100) NOT NULL,
	[gioitinh] [bit] NOT NULL,
	[cmnd] [varchar](20) NOT NULL,
	[sdt] [varchar](20) NOT NULL,
	[ngaysinh] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[manhanvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[taikhoan]    Script Date: 5/31/2021 6:32:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[taikhoan](
	[tendangnhap] [nvarchar](100) NOT NULL,
	[manhanvien] [int] NULL,
	[matkhau] [nvarchar](100) NOT NULL,
	[dangnhaplancuoi] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[tendangnhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[chitiethoadon] ADD  DEFAULT ((0)) FOR [soluong]
GO
ALTER TABLE [dbo].[dichvu] ADD  DEFAULT ((0)) FOR [gia]
GO
ALTER TABLE [dbo].[hoadondichvu] ADD  DEFAULT ((0)) FOR [tongtien]
GO
ALTER TABLE [dbo].[hopdong] ADD  DEFAULT ((0)) FOR [giatien]
GO
ALTER TABLE [dbo].[canho]  WITH CHECK ADD FOREIGN KEY([maho])
REFERENCES [dbo].[hogiadinh] ([maho])
GO
ALTER TABLE [dbo].[canho]  WITH CHECK ADD FOREIGN KEY([makhu])
REFERENCES [dbo].[khu] ([makhu])
GO
ALTER TABLE [dbo].[chitietcanho]  WITH CHECK ADD FOREIGN KEY([macanho])
REFERENCES [dbo].[canho] ([macanho])
GO
ALTER TABLE [dbo].[chitiethoadon]  WITH CHECK ADD FOREIGN KEY([madichvu])
REFERENCES [dbo].[dichvu] ([madichvu])
GO
ALTER TABLE [dbo].[chitiethoadon]  WITH CHECK ADD FOREIGN KEY([mahoadon])
REFERENCES [dbo].[hoadondichvu] ([mahoadon])
GO
ALTER TABLE [dbo].[hoadondichvu]  WITH CHECK ADD FOREIGN KEY([macanho])
REFERENCES [dbo].[canho] ([macanho])
GO
ALTER TABLE [dbo].[hoadondichvu]  WITH CHECK ADD FOREIGN KEY([manhanvien])
REFERENCES [dbo].[nhanvien] ([manhanvien])
GO
ALTER TABLE [dbo].[hopdong]  WITH CHECK ADD FOREIGN KEY([macanho])
REFERENCES [dbo].[canho] ([macanho])
GO
ALTER TABLE [dbo].[hopdong]  WITH CHECK ADD FOREIGN KEY([maho])
REFERENCES [dbo].[hogiadinh] ([maho])
GO
ALTER TABLE [dbo].[hopdong]  WITH CHECK ADD FOREIGN KEY([manhanvien])
REFERENCES [dbo].[nhanvien] ([manhanvien])
GO
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD FOREIGN KEY([machucvu])
REFERENCES [dbo].[chucvu] ([machucvu])
GO
ALTER TABLE [dbo].[taikhoan]  WITH CHECK ADD FOREIGN KEY([manhanvien])
REFERENCES [dbo].[nhanvien] ([manhanvien])
GO
USE [master]
GO
ALTER DATABASE [qlchungcu] SET  READ_WRITE 
GO
