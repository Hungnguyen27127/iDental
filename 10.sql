USE [master]
GO
/****** Object:  Database [iDental]    Script Date: 12/22/2018 4:11:22 PM ******/
CREATE DATABASE [iDental]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'iDental', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.QUANSQLSEVER\MSSQL\DATA\iDental.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'iDental_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.QUANSQLSEVER\MSSQL\DATA\iDental_log.ldf' , SIZE = 1600KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [iDental] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [iDental].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [iDental] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [iDental] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [iDental] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [iDental] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [iDental] SET ARITHABORT OFF 
GO
ALTER DATABASE [iDental] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [iDental] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [iDental] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [iDental] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [iDental] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [iDental] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [iDental] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [iDental] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [iDental] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [iDental] SET  DISABLE_BROKER 
GO
ALTER DATABASE [iDental] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [iDental] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [iDental] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [iDental] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [iDental] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [iDental] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [iDental] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [iDental] SET RECOVERY FULL 
GO
ALTER DATABASE [iDental] SET  MULTI_USER 
GO
ALTER DATABASE [iDental] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [iDental] SET DB_CHAINING OFF 
GO
ALTER DATABASE [iDental] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [iDental] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [iDental] SET DELAYED_DURABILITY = DISABLED 
GO
USE [iDental]
GO
/****** Object:  Table [dbo].[ACCOUNT]    Script Date: 12/22/2018 4:11:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACCOUNT](
	[AccountID] [int] IDENTITY(1,1) NOT NULL,
	[AccountName] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Role] [nvarchar](50) NULL,
 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[AccountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[APPOINTMENT]    Script Date: 12/22/2018 4:11:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[APPOINTMENT](
	[AppointmentID] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NULL,
	[EmployeeID] [int] NULL,
	[PatientName] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](50) NULL,
 CONSTRAINT [PK_APPOINTMENT] PRIMARY KEY CLUSTERED 
(
	[AppointmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BILL]    Script Date: 12/22/2018 4:11:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BILL](
	[BillID] [int] IDENTITY(1,1) NOT NULL,
	[MedicalRecordID] [int] NULL,
 CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED 
(
	[BillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMPLOYEE]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPLOYEE](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeName] [nvarchar](50) NULL,
	[DateOfBirth] [date] NULL,
	[PhoneNumber] [nchar](20) NULL,
	[Position] [nvarchar](50) NULL,
	[Address] [nvarchar](1000) NULL,
	[Image] [nvarchar](50) NULL,
	[AccountID] [int] NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MATERIAL]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MATERIAL](
	[MaterialID] [int] IDENTITY(1,1) NOT NULL,
	[MaterialName] [nvarchar](1000) NULL,
	[ProviderID] [int] NULL,
	[AvailableAmount] [int] NULL,
	[ExpirationDate] [date] NULL,
 CONSTRAINT [PK_MATERIAL] PRIMARY KEY CLUSTERED 
(
	[MaterialID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MATERIALS_ISSUE]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MATERIALS_ISSUE](
	[MaterialsIssueID] [int] IDENTITY(1,1) NOT NULL,
	[IssueDate] [date] NULL,
	[IssueAmount] [int] NULL,
	[MaterialsID] [int] NULL,
	[EmployeeID] [int] NULL,
 CONSTRAINT [PK_MATERIALS_ISSUE] PRIMARY KEY CLUSTERED 
(
	[MaterialsIssueID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MATERIALS_RECEIPT]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MATERIALS_RECEIPT](
	[MaterialsReceiptID] [int] IDENTITY(1,1) NOT NULL,
	[ReceiptDate] [date] NULL,
	[MaterialID] [int] NULL,
	[ReceiptAmount] [int] NULL,
	[EmployeeID] [int] NULL,
 CONSTRAINT [PK_MATERIALS_RECEIPT] PRIMARY KEY CLUSTERED 
(
	[MaterialsReceiptID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MEDICAL_RECORD]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MEDICAL_RECORD](
	[MedicalRecordID] [int] IDENTITY(1,1) NOT NULL,
	[PatientID] [int] NULL,
	[DateOfCreate] [date] NULL,
	[Diagnostic] [nvarchar](1000) NULL,
	[PaymentState] [nvarchar](50) NULL,
	[EmployeeID] [int] NULL,
 CONSTRAINT [PK_MedicalRecord] PRIMARY KEY CLUSTERED 
(
	[MedicalRecordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MEDICINE]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MEDICINE](
	[MedicineID] [int] IDENTITY(1,1) NOT NULL,
	[MedicineName] [nvarchar](50) NULL,
	[Category] [nvarchar](50) NULL,
 CONSTRAINT [PK_Medicine] PRIMARY KEY CLUSTERED 
(
	[MedicineID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MEDICINE_DETAIL]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MEDICINE_DETAIL](
	[MedicineDetailID] [int] IDENTITY(1,1) NOT NULL,
	[MedicineID] [int] NULL,
	[MedicalRecordID] [int] NULL,
	[Usage] [nvarchar](50) NULL,
	[Among] [nchar](50) NULL,
 CONSTRAINT [PK_MedicineDetailID] PRIMARY KEY CLUSTERED 
(
	[MedicineDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PATIENT]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PATIENT](
	[PatientID] [int] IDENTITY(1,1) NOT NULL,
	[PatientName] [nvarchar](50) NULL,
	[DateOfBirth] [date] NULL,
	[Gender] [nchar](10) NULL,
	[PhoneNumber] [nvarchar](50) NULL,
	[Address] [nvarchar](100) NULL,
	[Image] [nvarchar](50) NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[PatientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PROVIDER]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROVIDER](
	[ProviderID] [int] IDENTITY(1,1) NOT NULL,
	[ProviderName] [nvarchar](50) NULL,
	[PhoneNumder] [nchar](20) NULL,
	[Address] [nvarchar](1000) NULL,
 CONSTRAINT [PK_Provider] PRIMARY KEY CLUSTERED 
(
	[ProviderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SERVICE]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SERVICE](
	[ServiceID] [int] IDENTITY(1,1) NOT NULL,
	[ServiceName] [nvarchar](1000) NULL,
	[UnitPrice] [int] NULL,
	[Notes] [nvarchar](1000) NULL,
 CONSTRAINT [PK_Cure] PRIMARY KEY CLUSTERED 
(
	[ServiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SERVICE_DETAIL]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SERVICE_DETAIL](
	[ServiceDetailID] [int] IDENTITY(1,1) NOT NULL,
	[ServiceID] [int] NULL,
	[BillID] [int] NULL,
 CONSTRAINT [PK_BillDetail] PRIMARY KEY CLUSTERED 
(
	[ServiceDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ACCOUNT] ON 

INSERT [dbo].[ACCOUNT] ([AccountID], [AccountName], [Password], [Role]) VALUES (1, N'BaQuang', N'1', N'NhanVien')
INSERT [dbo].[ACCOUNT] ([AccountID], [AccountName], [Password], [Role]) VALUES (2, N'DoHung', N'2', N'NhanVien')
INSERT [dbo].[ACCOUNT] ([AccountID], [AccountName], [Password], [Role]) VALUES (3, N'HuyHung', N'3', N'QuanLy')
INSERT [dbo].[ACCOUNT] ([AccountID], [AccountName], [Password], [Role]) VALUES (4, N'HaiQuan', N'4', N'BacSy')
INSERT [dbo].[ACCOUNT] ([AccountID], [AccountName], [Password], [Role]) VALUES (5, N'LanOng', N'5', N'BacSy')
SET IDENTITY_INSERT [dbo].[ACCOUNT] OFF
SET IDENTITY_INSERT [dbo].[APPOINTMENT] ON 

INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (5, CAST(N'2018-11-13' AS Date), 5, N'Nguyễn Thị Ngọc Diệp', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (6, CAST(N'2018-10-10' AS Date), 5, N'Đỗ Quang Minh', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (7, CAST(N'2018-06-05' AS Date), 4, N'Cao Văn Cương', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (8, CAST(N'2018-12-07' AS Date), 5, N'Nguyễn Tuấn Mạnh', N'986363626')
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (9, CAST(N'2018-08-04' AS Date), 4, N'Trần Thị Hải Yến', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (10, CAST(N'2018-11-12' AS Date), 5, N'Đoàn Mạnh Hòa', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (11, CAST(N'2018-11-14' AS Date), 4, N'Hứa Đức Hạnh', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (12, CAST(N'2018-11-14' AS Date), 5, N'Doãn Nam Trung', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (13, CAST(N'2018-11-17' AS Date), 4, N'Bùi Thị Khuyên', N'0986747434')
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (14, CAST(N'2018-11-17' AS Date), 4, N'Doãn Trung Hậu', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (15, CAST(N'2018-11-17' AS Date), 4, N'Đoàn Thị Thùy Dung', N'0979897977')
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (16, CAST(N'2018-11-17' AS Date), 4, N'Nguyễn Ái Phương ', N'09887878667')
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (17, CAST(N'2018-11-18' AS Date), 4, N'Nguyễn Ái Phương ', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (18, CAST(N'2018-11-18' AS Date), 4, N'Doãn Trung Hậu', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (19, CAST(N'2018-11-19' AS Date), 4, N'Doãn Nam Trung', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (20, CAST(N'2018-11-19' AS Date), 4, N'Đỗ Quang Minh', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (21, CAST(N'2018-11-19' AS Date), 5, N'Đoàn Thị Thùy Dung', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (22, CAST(N'2018-11-19' AS Date), 4, N'Nguyễn Ái Phương ', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (23, CAST(N'2018-11-19' AS Date), 4, N'Đỗ Quang Minh', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (24, CAST(N'2018-11-19' AS Date), 4, N'Doãn Trung Hậu', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (25, CAST(N'2018-11-20' AS Date), 5, N'Đoàn Thị Thùy Dung', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (26, CAST(N'2018-11-20' AS Date), 5, N'Nguyễn Đình Thi', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (28, CAST(N'2018-11-23' AS Date), 4, N'Đỗ Quang Minh', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (29, CAST(N'2018-11-23' AS Date), 4, N'Doãn Nam Trung', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (30, CAST(N'2018-11-23' AS Date), 5, N'Nguyễn Đình Thi', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (31, CAST(N'2018-11-23' AS Date), 5, N'Đỗ Quang Minh', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (32, CAST(N'2018-11-25' AS Date), 4, N'Trần Thị Hải Yến', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (33, CAST(N'2018-11-25' AS Date), 4, N'Trần Thị Hải Yến', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (34, CAST(N'2018-11-25' AS Date), 4, N'Lương Hữu Dược', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (35, CAST(N'2018-11-25' AS Date), 5, N'Nguyễn Đình Thi', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (36, CAST(N'2018-11-25' AS Date), 5, N'Đoàn Thị Thùy Dung', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (37, CAST(N'2018-11-27' AS Date), 4, N'Lương Hữu Dược', N'0987678765')
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (38, CAST(N'2018-11-26' AS Date), 4, N'Nguyễn Thị Lan', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (39, CAST(N'2018-11-26' AS Date), 4, N'Doãn Nam Trung', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (40, CAST(N'2018-11-26' AS Date), 5, N'Bùi Thị Hương', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (41, CAST(N'2018-11-26' AS Date), 4, N'Bùi Thị Hương', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (42, CAST(N'2018-11-26' AS Date), 5, N'Doãn Nam Trung', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (43, CAST(N'2018-11-26' AS Date), 5, N'Doãn Nam Trung', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (44, NULL, NULL, NULL, NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (45, CAST(N'2018-11-28' AS Date), 4, N'Trương Thị Quỳnh Anh', N'095474738')
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (46, CAST(N'2018-12-05' AS Date), 4, N'Cao Toàn Phát ', N'0131245425')
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (48, CAST(N'2018-12-07' AS Date), 4, N'Dương Cao Minh', N'01643154156')
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (49, CAST(N'2018-12-07' AS Date), 5, N'Đào Thanh Tú', N'06541545251')
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (50, CAST(N'2018-12-07' AS Date), 4, N'Đoạn Văn Hậu', N'0564757374')
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (51, CAST(N'2018-12-08' AS Date), 4, N'Vũ Mạnh Tuấn', N'0987876657')
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (52, CAST(N'2018-12-18' AS Date), 4, N'Dương Tuấn Anh', N'0234423123')
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (53, CAST(N'2018-12-18' AS Date), 5, N'Đoàn Văn Hậu', N'0987878686')
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (55, CAST(N'2018-12-18' AS Date), 4, N'Xuân Diệu', N'0987878642')
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (56, CAST(N'2018-12-21' AS Date), 4, N'Doãn Ngọc Hoa', N'098787677')
SET IDENTITY_INSERT [dbo].[APPOINTMENT] OFF
SET IDENTITY_INSERT [dbo].[BILL] ON 

INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (1, 1)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (2, 2)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (3, 3)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (4, 4)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (5, 5)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (6, 6)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (7, 7)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (8, 8)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (9, 9)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (10, 10)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (11, 11)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (12, 12)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (13, 13)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (14, 14)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (15, 20)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (16, 21)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (17, 22)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (18, 23)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (19, 24)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (20, 25)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (21, 26)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (22, 27)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (23, 28)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (24, 29)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (25, 30)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (26, 31)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (27, 32)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (28, 33)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (29, 34)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (30, 35)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (31, 36)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (32, 37)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (33, 38)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (34, 39)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (35, 40)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (36, 41)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (37, 42)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (38, 43)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (39, 44)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (40, 45)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (41, 46)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (42, 47)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (43, 48)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (44, 49)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (45, 50)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (46, 51)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (47, 52)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (48, 53)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (49, 54)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (50, 55)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (51, 56)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (52, 57)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (53, 58)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (54, 59)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (55, 60)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (56, 61)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (57, 62)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (58, 63)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (59, 64)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (60, 65)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (61, 66)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (62, 67)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (63, 68)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (64, 69)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (65, 70)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (66, 71)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (67, 72)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (68, 73)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (69, 74)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (70, 75)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (71, 76)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (72, 77)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (73, 78)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (74, 79)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (75, 80)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (76, 81)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (77, 82)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (78, 83)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (79, 84)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (80, 85)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (81, 86)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID]) VALUES (82, 87)
SET IDENTITY_INSERT [dbo].[BILL] OFF
SET IDENTITY_INSERT [dbo].[EMPLOYEE] ON 

INSERT [dbo].[EMPLOYEE] ([EmployeeID], [EmployeeName], [DateOfBirth], [PhoneNumber], [Position], [Address], [Image], [AccountID]) VALUES (1, N'Lê Hồ Bá Quang', CAST(N'1997-04-15' AS Date), N'01207273497         ', N'Nhân Viên', N'Nghệ An', NULL, 1)
INSERT [dbo].[EMPLOYEE] ([EmployeeID], [EmployeeName], [DateOfBirth], [PhoneNumber], [Position], [Address], [Image], [AccountID]) VALUES (2, N'Đỗ Vĩnh Hùng', CAST(N'1997-01-01' AS Date), N'0123456789          ', N'Nhân Viên', N'Hà Nội', NULL, 2)
INSERT [dbo].[EMPLOYEE] ([EmployeeID], [EmployeeName], [DateOfBirth], [PhoneNumber], [Position], [Address], [Image], [AccountID]) VALUES (3, N'Nguyễn Huy Hùng', CAST(N'1997-02-02' AS Date), N'0123234444          ', N'Quản Lý', N'Hà Nội', NULL, 3)
INSERT [dbo].[EMPLOYEE] ([EmployeeID], [EmployeeName], [DateOfBirth], [PhoneNumber], [Position], [Address], [Image], [AccountID]) VALUES (4, N'Dương Hải Quân', CAST(N'1997-03-03' AS Date), N'090031232           ', N'Bác Sỹ', N'Hà Nội', NULL, 4)
INSERT [dbo].[EMPLOYEE] ([EmployeeID], [EmployeeName], [DateOfBirth], [PhoneNumber], [Position], [Address], [Image], [AccountID]) VALUES (5, N'Hải Thượng Lãn Ông', CAST(N'1997-04-04' AS Date), N'0998762222          ', N'Bác Sỹ', N'Hà Nội', NULL, 5)
SET IDENTITY_INSERT [dbo].[EMPLOYEE] OFF
SET IDENTITY_INSERT [dbo].[MATERIAL] ON 

INSERT [dbo].[MATERIAL] ([MaterialID], [MaterialName], [ProviderID], [AvailableAmount], [ExpirationDate]) VALUES (1, N'Máy Cạo Vôi Răng', 1, 3, CAST(N'2020-12-12' AS Date))
INSERT [dbo].[MATERIAL] ([MaterialID], [MaterialName], [ProviderID], [AvailableAmount], [ExpirationDate]) VALUES (2, N'Đèn Trám Halogen', 1, 3, CAST(N'2020-12-12' AS Date))
INSERT [dbo].[MATERIAL] ([MaterialID], [MaterialName], [ProviderID], [AvailableAmount], [ExpirationDate]) VALUES (3, N'Thiết Bị Đo Chiều Dài Ống Tủy', 1, 2, CAST(N'2020-12-12' AS Date))
INSERT [dbo].[MATERIAL] ([MaterialID], [MaterialName], [ProviderID], [AvailableAmount], [ExpirationDate]) VALUES (4, N'Lò Hấp AutoClave', 2, 4, CAST(N'2020-12-12' AS Date))
INSERT [dbo].[MATERIAL] ([MaterialID], [MaterialName], [ProviderID], [AvailableAmount], [ExpirationDate]) VALUES (5, N'Máy Đo Huyết Áp', 2, 3, CAST(N'2020-12-12' AS Date))
INSERT [dbo].[MATERIAL] ([MaterialID], [MaterialName], [ProviderID], [AvailableAmount], [ExpirationDate]) VALUES (6, N'Máy X Quang Gender', 2, 4, CAST(N'2020-12-12' AS Date))
INSERT [dbo].[MATERIAL] ([MaterialID], [MaterialName], [ProviderID], [AvailableAmount], [ExpirationDate]) VALUES (7, N'Máy Khoan Đặt Trụ Implant', 2, 2, CAST(N'2020-12-12' AS Date))
INSERT [dbo].[MATERIAL] ([MaterialID], [MaterialName], [ProviderID], [AvailableAmount], [ExpirationDate]) VALUES (8, N'Đèn Tẩy Trắng ZoomWhitening', 4, 3, CAST(N'2020-12-12' AS Date))
INSERT [dbo].[MATERIAL] ([MaterialID], [MaterialName], [ProviderID], [AvailableAmount], [ExpirationDate]) VALUES (9, N'Hệ Thống CAD/CAM Trong Chế Tạo Răng Sứ', 4, 2, CAST(N'2020-12-12' AS Date))
INSERT [dbo].[MATERIAL] ([MaterialID], [MaterialName], [ProviderID], [AvailableAmount], [ExpirationDate]) VALUES (10, N'Bông Băng', 5, 1000, CAST(N'2020-12-12' AS Date))
INSERT [dbo].[MATERIAL] ([MaterialID], [MaterialName], [ProviderID], [AvailableAmount], [ExpirationDate]) VALUES (11, N'Thuốc Gây Mê', 5, 1000, CAST(N'2020-12-12' AS Date))
INSERT [dbo].[MATERIAL] ([MaterialID], [MaterialName], [ProviderID], [AvailableAmount], [ExpirationDate]) VALUES (12, N'Bàn', 3, 10, CAST(N'2020-12-12' AS Date))
INSERT [dbo].[MATERIAL] ([MaterialID], [MaterialName], [ProviderID], [AvailableAmount], [ExpirationDate]) VALUES (13, N'Ghế', 1, 60, CAST(N'2018-12-22' AS Date))
INSERT [dbo].[MATERIAL] ([MaterialID], [MaterialName], [ProviderID], [AvailableAmount], [ExpirationDate]) VALUES (14, N'Máy Tính', 3, 25, CAST(N'2020-12-12' AS Date))
INSERT [dbo].[MATERIAL] ([MaterialID], [MaterialName], [ProviderID], [AvailableAmount], [ExpirationDate]) VALUES (15, N'Điều Hòa', 3, 8, CAST(N'2020-12-12' AS Date))
INSERT [dbo].[MATERIAL] ([MaterialID], [MaterialName], [ProviderID], [AvailableAmount], [ExpirationDate]) VALUES (16, N'Kim Tiêm', 3, 1000, CAST(N'2020-12-12' AS Date))
INSERT [dbo].[MATERIAL] ([MaterialID], [MaterialName], [ProviderID], [AvailableAmount], [ExpirationDate]) VALUES (17, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[MATERIAL] OFF
SET IDENTITY_INSERT [dbo].[MATERIALS_ISSUE] ON 

INSERT [dbo].[MATERIALS_ISSUE] ([MaterialsIssueID], [IssueDate], [IssueAmount], [MaterialsID], [EmployeeID]) VALUES (1, CAST(N'2018-11-04' AS Date), 50, 16, 1)
INSERT [dbo].[MATERIALS_ISSUE] ([MaterialsIssueID], [IssueDate], [IssueAmount], [MaterialsID], [EmployeeID]) VALUES (2, CAST(N'2018-11-04' AS Date), 50, 11, 1)
INSERT [dbo].[MATERIALS_ISSUE] ([MaterialsIssueID], [IssueDate], [IssueAmount], [MaterialsID], [EmployeeID]) VALUES (3, CAST(N'2018-11-05' AS Date), 50, 10, 1)
INSERT [dbo].[MATERIALS_ISSUE] ([MaterialsIssueID], [IssueDate], [IssueAmount], [MaterialsID], [EmployeeID]) VALUES (4, CAST(N'2018-11-05' AS Date), 50, 11, 1)
INSERT [dbo].[MATERIALS_ISSUE] ([MaterialsIssueID], [IssueDate], [IssueAmount], [MaterialsID], [EmployeeID]) VALUES (5, CAST(N'2018-11-06' AS Date), 50, 10, 1)
INSERT [dbo].[MATERIALS_ISSUE] ([MaterialsIssueID], [IssueDate], [IssueAmount], [MaterialsID], [EmployeeID]) VALUES (6, CAST(N'2018-11-06' AS Date), 50, 11, 2)
INSERT [dbo].[MATERIALS_ISSUE] ([MaterialsIssueID], [IssueDate], [IssueAmount], [MaterialsID], [EmployeeID]) VALUES (7, CAST(N'2018-11-07' AS Date), 50, 10, 2)
INSERT [dbo].[MATERIALS_ISSUE] ([MaterialsIssueID], [IssueDate], [IssueAmount], [MaterialsID], [EmployeeID]) VALUES (8, CAST(N'2018-11-07' AS Date), 50, 11, 2)
INSERT [dbo].[MATERIALS_ISSUE] ([MaterialsIssueID], [IssueDate], [IssueAmount], [MaterialsID], [EmployeeID]) VALUES (9, CAST(N'2018-11-08' AS Date), 50, 10, 1)
INSERT [dbo].[MATERIALS_ISSUE] ([MaterialsIssueID], [IssueDate], [IssueAmount], [MaterialsID], [EmployeeID]) VALUES (10, CAST(N'2018-11-08' AS Date), 50, 11, 1)
INSERT [dbo].[MATERIALS_ISSUE] ([MaterialsIssueID], [IssueDate], [IssueAmount], [MaterialsID], [EmployeeID]) VALUES (11, CAST(N'2018-11-09' AS Date), 50, 10, 2)
INSERT [dbo].[MATERIALS_ISSUE] ([MaterialsIssueID], [IssueDate], [IssueAmount], [MaterialsID], [EmployeeID]) VALUES (12, CAST(N'2018-11-09' AS Date), 50, 11, 2)
INSERT [dbo].[MATERIALS_ISSUE] ([MaterialsIssueID], [IssueDate], [IssueAmount], [MaterialsID], [EmployeeID]) VALUES (13, CAST(N'2018-11-10' AS Date), 50, 10, 1)
INSERT [dbo].[MATERIALS_ISSUE] ([MaterialsIssueID], [IssueDate], [IssueAmount], [MaterialsID], [EmployeeID]) VALUES (14, CAST(N'2018-11-10' AS Date), 50, 11, 2)
INSERT [dbo].[MATERIALS_ISSUE] ([MaterialsIssueID], [IssueDate], [IssueAmount], [MaterialsID], [EmployeeID]) VALUES (15, CAST(N'2018-11-11' AS Date), 50, 10, 1)
INSERT [dbo].[MATERIALS_ISSUE] ([MaterialsIssueID], [IssueDate], [IssueAmount], [MaterialsID], [EmployeeID]) VALUES (16, CAST(N'2018-11-11' AS Date), 50, 11, 1)
INSERT [dbo].[MATERIALS_ISSUE] ([MaterialsIssueID], [IssueDate], [IssueAmount], [MaterialsID], [EmployeeID]) VALUES (17, CAST(N'2018-11-12' AS Date), 50, 10, 1)
INSERT [dbo].[MATERIALS_ISSUE] ([MaterialsIssueID], [IssueDate], [IssueAmount], [MaterialsID], [EmployeeID]) VALUES (18, CAST(N'2018-11-12' AS Date), 50, 11, 2)
INSERT [dbo].[MATERIALS_ISSUE] ([MaterialsIssueID], [IssueDate], [IssueAmount], [MaterialsID], [EmployeeID]) VALUES (19, CAST(N'2018-11-13' AS Date), 50, 10, 2)
INSERT [dbo].[MATERIALS_ISSUE] ([MaterialsIssueID], [IssueDate], [IssueAmount], [MaterialsID], [EmployeeID]) VALUES (20, CAST(N'2018-11-13' AS Date), 50, 11, 2)
INSERT [dbo].[MATERIALS_ISSUE] ([MaterialsIssueID], [IssueDate], [IssueAmount], [MaterialsID], [EmployeeID]) VALUES (21, CAST(N'2018-11-04' AS Date), 50, 16, 1)
INSERT [dbo].[MATERIALS_ISSUE] ([MaterialsIssueID], [IssueDate], [IssueAmount], [MaterialsID], [EmployeeID]) VALUES (22, CAST(N'2018-11-05' AS Date), 50, 16, 2)
INSERT [dbo].[MATERIALS_ISSUE] ([MaterialsIssueID], [IssueDate], [IssueAmount], [MaterialsID], [EmployeeID]) VALUES (23, CAST(N'2018-11-06' AS Date), 50, 16, 1)
INSERT [dbo].[MATERIALS_ISSUE] ([MaterialsIssueID], [IssueDate], [IssueAmount], [MaterialsID], [EmployeeID]) VALUES (24, CAST(N'2018-11-07' AS Date), 50, 16, 2)
INSERT [dbo].[MATERIALS_ISSUE] ([MaterialsIssueID], [IssueDate], [IssueAmount], [MaterialsID], [EmployeeID]) VALUES (25, CAST(N'2018-11-08' AS Date), 50, 16, 1)
INSERT [dbo].[MATERIALS_ISSUE] ([MaterialsIssueID], [IssueDate], [IssueAmount], [MaterialsID], [EmployeeID]) VALUES (26, CAST(N'2018-11-09' AS Date), 50, 16, 1)
INSERT [dbo].[MATERIALS_ISSUE] ([MaterialsIssueID], [IssueDate], [IssueAmount], [MaterialsID], [EmployeeID]) VALUES (27, CAST(N'2018-11-10' AS Date), 50, 16, 1)
INSERT [dbo].[MATERIALS_ISSUE] ([MaterialsIssueID], [IssueDate], [IssueAmount], [MaterialsID], [EmployeeID]) VALUES (28, CAST(N'2018-11-11' AS Date), 50, 16, 1)
INSERT [dbo].[MATERIALS_ISSUE] ([MaterialsIssueID], [IssueDate], [IssueAmount], [MaterialsID], [EmployeeID]) VALUES (29, CAST(N'2018-11-12' AS Date), 50, 16, 2)
INSERT [dbo].[MATERIALS_ISSUE] ([MaterialsIssueID], [IssueDate], [IssueAmount], [MaterialsID], [EmployeeID]) VALUES (30, CAST(N'2018-11-13' AS Date), 50, 16, 2)
SET IDENTITY_INSERT [dbo].[MATERIALS_ISSUE] OFF
SET IDENTITY_INSERT [dbo].[MATERIALS_RECEIPT] ON 

INSERT [dbo].[MATERIALS_RECEIPT] ([MaterialsReceiptID], [ReceiptDate], [MaterialID], [ReceiptAmount], [EmployeeID]) VALUES (1, CAST(N'2018-11-04' AS Date), 10, 1500, 1)
INSERT [dbo].[MATERIALS_RECEIPT] ([MaterialsReceiptID], [ReceiptDate], [MaterialID], [ReceiptAmount], [EmployeeID]) VALUES (2, CAST(N'2018-11-04' AS Date), 11, 1500, 2)
INSERT [dbo].[MATERIALS_RECEIPT] ([MaterialsReceiptID], [ReceiptDate], [MaterialID], [ReceiptAmount], [EmployeeID]) VALUES (3, CAST(N'2018-11-04' AS Date), 16, 1500, 2)
INSERT [dbo].[MATERIALS_RECEIPT] ([MaterialsReceiptID], [ReceiptDate], [MaterialID], [ReceiptAmount], [EmployeeID]) VALUES (4, CAST(N'2018-12-22' AS Date), 14, 6, 4)
INSERT [dbo].[MATERIALS_RECEIPT] ([MaterialsReceiptID], [ReceiptDate], [MaterialID], [ReceiptAmount], [EmployeeID]) VALUES (5, CAST(N'2018-12-22' AS Date), 14, 12, 4)
INSERT [dbo].[MATERIALS_RECEIPT] ([MaterialsReceiptID], [ReceiptDate], [MaterialID], [ReceiptAmount], [EmployeeID]) VALUES (6, CAST(N'2018-12-22' AS Date), 13, 30, 4)
INSERT [dbo].[MATERIALS_RECEIPT] ([MaterialsReceiptID], [ReceiptDate], [MaterialID], [ReceiptAmount], [EmployeeID]) VALUES (7, CAST(N'2018-12-22' AS Date), 15, 4, 4)
INSERT [dbo].[MATERIALS_RECEIPT] ([MaterialsReceiptID], [ReceiptDate], [MaterialID], [ReceiptAmount], [EmployeeID]) VALUES (8, CAST(N'2018-12-22' AS Date), 14, 1, 4)
SET IDENTITY_INSERT [dbo].[MATERIALS_RECEIPT] OFF
SET IDENTITY_INSERT [dbo].[MEDICAL_RECORD] ON 

INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (1, 1, CAST(N'2018-01-01' AS Date), N'Răng Khôn Hàm Dưới Mọc Lệch', N'Đã Thanh Toán', 4)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (2, 2, CAST(N'2018-02-02' AS Date), N'Chữa Tủy Răng Ngoài (Từ Răng 1 -> Răng 5)', N'Đã Thanh Toán', 4)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (3, 3, CAST(N'2018-03-03' AS Date), N'Túi Nha Chu Bị Viêm', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (4, 4, CAST(N'2018-01-01' AS Date), N'Lấy Vôi Răng Trẻ Em', N'Đã Thanh Toán', 4)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (5, 5, CAST(N'2018-05-14' AS Date), N'Trám Răng Sữa', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (6, 6, CAST(N'2018-05-26' AS Date), N'Trám Răng Sữa', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (7, 7, CAST(N'2018-05-06' AS Date), N'Tẩy Trắng Ống Tủy', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (8, 8, CAST(N'2018-02-01' AS Date), N'Trám Răng Sâu', N'Đã Thanh Toán', 4)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (9, 9, CAST(N'2018-01-02' AS Date), N'Trám Răng Sâu', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (10, 10, CAST(N'2018-05-04' AS Date), N'Lấy Vôi Răng Trẻ Em', N'Đã Thanh Toán', 4)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (11, 11, CAST(N'2018-05-05' AS Date), N'Lấy Vôi Răng Trẻ Em', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (12, 12, CAST(N'2018-11-13' AS Date), N'Làm Răng Sứ Tạm', N'Đã Thanh Toán', 4)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (13, 13, CAST(N'2018-10-11' AS Date), N'Làm Răng Toàn Sứ', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (14, 14, CAST(N'2018-10-09' AS Date), N'Cắt Chóp', N'Đã Thanh Toán', 4)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (15, 1, CAST(N'2018-10-09' AS Date), N'Cắt Chóp', N'Đã Thanh Toán', 1)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (16, 7, CAST(N'2018-12-04' AS Date), N'Sâu Răng Khôn', N'0', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (17, 7, CAST(N'2018-12-04' AS Date), N'Sâu Răng Khôn 1', N'0', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (18, 12, CAST(N'2018-12-04' AS Date), N'Gãy Răng Cửa', N'0', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (19, 15, CAST(N'2018-12-04' AS Date), N'Viêm Tủy Răng Số 8', N'0', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (20, 1, CAST(N'2018-12-05' AS Date), N'Viêm tủy răng số 8', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (21, 1, CAST(N'2018-12-05' AS Date), N'Viêm Tủy Răng Số 7', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (22, 1, CAST(N'2018-12-05' AS Date), N'Cắt Chóp', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (23, 1, CAST(N'2018-12-05' AS Date), N'', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (24, 1, CAST(N'2018-12-05' AS Date), N'Sâu răng ', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (25, 4, CAST(N'2018-12-05' AS Date), N'Viêm Lợi', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (26, 8, CAST(N'2018-12-06' AS Date), N'Sâu Răng', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (27, 6, CAST(N'2018-12-06' AS Date), N'Sâu Răng', N'Chưa Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (28, 8, CAST(N'2018-12-06' AS Date), N'', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (29, 3, CAST(N'2018-12-06' AS Date), N'', N'Chưa Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (30, 5, CAST(N'2018-12-06' AS Date), N'', N'Chưa Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (31, 3, CAST(N'2018-12-06' AS Date), N'Ngáo đá', N'Chưa Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (32, 9, CAST(N'2018-12-06' AS Date), N'Ngáo Đá ', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (33, 7, CAST(N'2018-12-06' AS Date), N'Ố Vàng Vì Hút Nhiều Thuốc', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (34, 5, CAST(N'2018-12-06' AS Date), N'Răng Mọc Nhầm Chỗ', N'Chưa Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (35, 3, CAST(N'2018-12-06' AS Date), N'Ố Răng Nghiêm Trọng', N'Chưa Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (36, 5, CAST(N'2018-12-06' AS Date), N'Sâu Răng ', N'Chưa Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (37, 3, CAST(N'2018-12-06' AS Date), N'Ngồi nhiều nên đau răng', N'Chưa Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (38, 3, CAST(N'2018-12-06' AS Date), N'Ngồi Nhiều Mọc Răng Khôn', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (39, 2, CAST(N'2018-12-06' AS Date), N'Mẻ răng vì ăn phải thịt', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (40, 8, CAST(N'2018-12-06' AS Date), N'Nói Nhiều Quá mòn Răng', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (41, 6, CAST(N'2018-12-06' AS Date), N'Cao răng đóng tảng không lấy được', N'Chưa Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (42, 5, CAST(N'2018-12-06' AS Date), N'', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (43, 7, CAST(N'2018-12-07' AS Date), N'Ngồi nhiều đau răng ', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (44, 11, CAST(N'2018-12-07' AS Date), N'Quá Nhiều Cao Răng', N'Chưa Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (45, 8, CAST(N'2018-12-07' AS Date), N'Lâu không Đánh Răng', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (46, 11, CAST(N'2018-12-07' AS Date), N'Sâu Răng Hàm', N'Chưa Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (47, 7, CAST(N'2018-12-07' AS Date), N'Sâu răng hàm', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (48, 4, CAST(N'2018-12-07' AS Date), N'Sâu răng hàm ', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (49, 13, CAST(N'2018-12-07' AS Date), N'Sâu Răng Cửa', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (50, 6, CAST(N'2018-12-07' AS Date), N'Răng mọc không đều ', N'Chưa Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (51, 6, CAST(N'2018-12-07' AS Date), N'Chết tủy răng trong cùng hàm dưới', N'Chưa Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (52, 6, CAST(N'2018-12-07' AS Date), N'Ố Vàng Chân Răng', N'Chưa Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (53, 9, CAST(N'2018-12-07' AS Date), N'Mẻ răng cửa', N'Chưa Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (54, 9, CAST(N'2018-12-07' AS Date), N'Cao răng quá nhiều ', N'Chưa Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (55, 9, CAST(N'2018-12-07' AS Date), N'Viêm tủy ngoài', N'Chưa Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (56, 8, CAST(N'2018-12-07' AS Date), N'Vỡ răng hàm ', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (57, 8, CAST(N'2018-12-07' AS Date), N'Quá nhiều cao răng', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (58, 7, CAST(N'2018-12-07' AS Date), N'Răng yếu', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (59, 21, CAST(N'2018-12-07' AS Date), N'dsffdsfs', N'Chưa Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (60, 4, CAST(N'2018-12-07' AS Date), N'dfsfsfsf', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (61, 4, CAST(N'2018-12-07' AS Date), N'kokokok', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (62, 4, CAST(N'2018-12-07' AS Date), N'lplplplplpp', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (63, 15, CAST(N'2018-12-07' AS Date), N'qadsdawdád', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (64, 6, CAST(N'2018-12-08' AS Date), N'ádasdasd', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (65, 9, CAST(N'2018-12-08' AS Date), N'dddđ', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (66, 7, CAST(N'2018-12-08' AS Date), N'ádasđsđá', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (67, 13, CAST(N'2018-12-08' AS Date), N'ádasdasdsad', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (68, 15, CAST(N'2018-12-08' AS Date), N'qqweqweqweqeqwe', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (69, 24, CAST(N'2018-12-08' AS Date), N'Ngồi nhiều đau răng', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (70, 15, CAST(N'2018-12-09' AS Date), N'gjjhjhkkhkk', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (71, 24, CAST(N'2018-12-09' AS Date), N'Chọc tăm vào lợi', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (72, 10, CAST(N'2018-12-09' AS Date), N'sÂU rĂNG ', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (73, 27, CAST(N'2018-12-18' AS Date), N'Tên Bắn vào hàm dưới', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (74, 13, CAST(N'2018-12-19' AS Date), N'Viêm Lợi ', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (75, 8, CAST(N'2018-12-19' AS Date), N'abc', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (76, 29, CAST(N'2018-12-19' AS Date), N'abc', N'Chưa Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (77, 12, CAST(N'2018-12-19' AS Date), N'abc', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (78, 10, CAST(N'2018-12-19' AS Date), N'abc', N'Chưa Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (79, 11, CAST(N'2018-12-19' AS Date), N'abc', N'Chưa Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (80, 12, CAST(N'2018-12-19' AS Date), N'abc', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (81, 12, CAST(N'2018-12-19' AS Date), N'aew', N'Đã Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (82, 13, CAST(N'2018-12-19' AS Date), N'zxc', N'Chưa Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (83, 17, CAST(N'2018-12-19' AS Date), N's', N'Chưa Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (84, 7, CAST(N'2018-12-19' AS Date), N'ertre', N'Chưa Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (85, 20, CAST(N'2018-12-19' AS Date), N'gdgd', N'Chưa Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (86, 10, CAST(N'2018-12-20' AS Date), N'áqwqw', N'Chưa Thanh Toán', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (87, 28, CAST(N'2018-12-20' AS Date), N'hghg', N'Đã Thanh Toán', 5)
SET IDENTITY_INSERT [dbo].[MEDICAL_RECORD] OFF
SET IDENTITY_INSERT [dbo].[MEDICINE] ON 

INSERT [dbo].[MEDICINE] ([MedicineID], [MedicineName], [Category]) VALUES (1, N'Novocain', N'Thuốc Gây Tê')
INSERT [dbo].[MEDICINE] ([MedicineID], [MedicineName], [Category]) VALUES (2, N'Xylocain', N'Thuốc Gây Tê')
INSERT [dbo].[MEDICINE] ([MedicineID], [MedicineName], [Category]) VALUES (3, N'Paracetamol', N'Thuốc Giảm Đau')
INSERT [dbo].[MEDICINE] ([MedicineID], [MedicineName], [Category]) VALUES (4, N'Aspirin', N'Thuốc Giảm Đau')
INSERT [dbo].[MEDICINE] ([MedicineID], [MedicineName], [Category]) VALUES (5, N'Ibuprofen', N'Thuốc Giảm Đau')
INSERT [dbo].[MEDICINE] ([MedicineID], [MedicineName], [Category]) VALUES (6, N'Amoxillin', N'Thuốc Diệt Khuẩn')
INSERT [dbo].[MEDICINE] ([MedicineID], [MedicineName], [Category]) VALUES (7, N'Phenoymethylpenicillin', N'Thuốc Diệt Khuẩn')
INSERT [dbo].[MEDICINE] ([MedicineID], [MedicineName], [Category]) VALUES (8, N'Acyclovir', N'Thuốc Diệt Vi Khuẩn Và Chống Nấm')
INSERT [dbo].[MEDICINE] ([MedicineID], [MedicineName], [Category]) VALUES (9, N'Penciclovir', N'Thuốc Diệt Vi Khuẩn Và Chống Nấm')
INSERT [dbo].[MEDICINE] ([MedicineID], [MedicineName], [Category]) VALUES (10, N'Pilocarpin', N'Thuốc Chống Khô Miệng')
INSERT [dbo].[MEDICINE] ([MedicineID], [MedicineName], [Category]) VALUES (11, N'Vitamin C', N'Vitamin')
INSERT [dbo].[MEDICINE] ([MedicineID], [MedicineName], [Category]) VALUES (12, N'Vitamin A', N'Vitamin')
INSERT [dbo].[MEDICINE] ([MedicineID], [MedicineName], [Category]) VALUES (13, N'Vitamin D3', N'Vitamin')
INSERT [dbo].[MEDICINE] ([MedicineID], [MedicineName], [Category]) VALUES (14, N'Vitamin B2', N'Vitamin')
INSERT [dbo].[MEDICINE] ([MedicineID], [MedicineName], [Category]) VALUES (15, N'Betaderm neomycin', N'Thuốc Điều Trị Viêm Ổ Răng')
INSERT [dbo].[MEDICINE] ([MedicineID], [MedicineName], [Category]) VALUES (16, N'Cebemyxine', N'Thuốc Điều Trị Viêm Ổ Răng')
INSERT [dbo].[MEDICINE] ([MedicineID], [MedicineName], [Category]) VALUES (17, N'Emla', N'Thuốc Điều Trị Viêm Ổ Răng')
INSERT [dbo].[MEDICINE] ([MedicineID], [MedicineName], [Category]) VALUES (18, N'Izac', N'Thuốc Điều Trị Viêm Ổ Răng')
INSERT [dbo].[MEDICINE] ([MedicineID], [MedicineName], [Category]) VALUES (19, N'Acmegel', N'Thuốc Điều Trị Viêm Nha Chu')
INSERT [dbo].[MEDICINE] ([MedicineID], [MedicineName], [Category]) VALUES (20, N'Dophargyl', N'Thuốc Điều Trị Viêm Nha Chu')
INSERT [dbo].[MEDICINE] ([MedicineID], [MedicineName], [Category]) VALUES (21, N'Mediginal', N'Thuốc Điều Trị Viêm Nha Chu')
SET IDENTITY_INSERT [dbo].[MEDICINE] OFF
SET IDENTITY_INSERT [dbo].[MEDICINE_DETAIL] ON 

INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (1, 18, 1, NULL, NULL)
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (2, 3, 1, NULL, NULL)
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (3, 4, 3, NULL, NULL)
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (4, 5, 4, NULL, NULL)
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (5, 9, 5, NULL, NULL)
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (6, 1, 5, NULL, NULL)
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (7, 3, 7, NULL, NULL)
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (8, 21, 8, NULL, NULL)
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (9, 17, 9, NULL, NULL)
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (10, 14, 10, NULL, NULL)
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (11, 15, 11, NULL, NULL)
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (12, 19, 11, NULL, NULL)
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (13, 6, 11, NULL, NULL)
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (14, 7, 14, NULL, NULL)
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (15, 8, 2, NULL, NULL)
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (16, 2, 6, NULL, NULL)
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (17, 3, 12, NULL, NULL)
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (18, 1, 13, NULL, NULL)
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (19, 4, 6, N'Uống ', N'Ngày 2 viên                                       ')
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (20, 3, 6, N'Uống ', N'Ngày 2 viên                                       ')
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (21, 13, 6, N'Uống ', N'Ngày 3 liều , mỗi liều 3 viên                     ')
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (23, 3, 4, N'', N'                                                  ')
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (24, 3, 60, N'', N'                                                  ')
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (25, 6, 61, N'', N'                                                  ')
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (26, 3, 62, N'', N'                                                  ')
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (27, 14, 4, N'', N'                                                  ')
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (28, 7, 4, N'', N'                                                  ')
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (29, 8, 63, N'', N'                                                  ')
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (30, 11, 63, N'', N'                                                  ')
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (31, 7, 65, N'', N'                                                  ')
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (33, 9, 68, N'', N'                                                  ')
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (34, 4, 69, N'tiêm', N'đau thì tiêm                                      ')
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (35, 8, 71, N'Bôi', N'rửa 3 lần 1 ngày                                  ')
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (36, 6, 73, N'Súc Miệng', N'ngày nhiều lần                                    ')
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (37, 10, 73, N'Súc Miệng', N'ngày nhiều lần                                    ')
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (38, 20, 74, N'Súc Miệng', N'Nhiều lần trên ngày                               ')
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (39, 17, 74, N'Nhỏ', N'Nhiều lần trên ngày                               ')
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (40, 15, 75, N'abc', N'abc                                               ')
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (41, 15, 75, N'abc', N'abc                                               ')
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (42, 15, 76, N'abc', N'abc                                               ')
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (43, 16, 79, N'Bác Sỹ Dùng', N'Không có                                          ')
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (44, 15, 80, N'a', N'a                                                 ')
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (45, 11, 81, N'q', N'q                                                 ')
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (46, 15, 82, N'g', N'g                                                 ')
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (47, 11, 83, N'd', N'a                                                 ')
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (48, 4, 83, N'da', N'a                                                 ')
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (49, 15, 83, N'daa', N'aa                                                ')
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (50, 15, 84, N'e', N't                                                 ')
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (51, 11, 84, N'es', N't                                                 ')
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (52, 15, 85, N'', N'                                                  ')
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (53, 11, 85, N'', N'                                                  ')
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (54, 11, 86, N'a', N'a                                                 ')
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [Among]) VALUES (55, 15, 87, N'i', N'i                                                 ')
SET IDENTITY_INSERT [dbo].[MEDICINE_DETAIL] OFF
SET IDENTITY_INSERT [dbo].[PATIENT] ON 

INSERT [dbo].[PATIENT] ([PatientID], [PatientName], [DateOfBirth], [Gender], [PhoneNumber], [Address], [Image]) VALUES (1, N'Nguyễn Văn Toàn', CAST(N'1997-04-15' AS Date), N'Nam       ', N'0123456789', N'Hà Nội', NULL)
INSERT [dbo].[PATIENT] ([PatientID], [PatientName], [DateOfBirth], [Gender], [PhoneNumber], [Address], [Image]) VALUES (2, N'Nguyễn Thị Linh', CAST(N'1998-02-09' AS Date), N'Nữ        ', N'098888822', N'Hà Nội', N'')
INSERT [dbo].[PATIENT] ([PatientID], [PatientName], [DateOfBirth], [Gender], [PhoneNumber], [Address], [Image]) VALUES (3, N'Dương Văn Minh', CAST(N'1880-06-09' AS Date), N'Nam       ', N'0237827322', N'Hà Nội', NULL)
INSERT [dbo].[PATIENT] ([PatientID], [PatientName], [DateOfBirth], [Gender], [PhoneNumber], [Address], [Image]) VALUES (4, N'Phạm Vũ Mạnh', CAST(N'1997-09-08' AS Date), N'Nam       ', N'098765765', N'Hà Nội', NULL)
INSERT [dbo].[PATIENT] ([PatientID], [PatientName], [DateOfBirth], [Gender], [PhoneNumber], [Address], [Image]) VALUES (5, N'Nguyễn Thị Linh', CAST(N'1998-02-09' AS Date), N'Nữ        ', N'098888822', N'Hà Nội', NULL)
INSERT [dbo].[PATIENT] ([PatientID], [PatientName], [DateOfBirth], [Gender], [PhoneNumber], [Address], [Image]) VALUES (6, N'Quỳnh Mai', CAST(N'1990-07-22' AS Date), N'Nữ        ', N'0997287878', N'Hà Nội', NULL)
INSERT [dbo].[PATIENT] ([PatientID], [PatientName], [DateOfBirth], [Gender], [PhoneNumber], [Address], [Image]) VALUES (7, N'Doãn Trung Dũng ', CAST(N'1988-11-04' AS Date), N'Nam       ', N'0343154156', N'Hà Nội', N'')
INSERT [dbo].[PATIENT] ([PatientID], [PatientName], [DateOfBirth], [Gender], [PhoneNumber], [Address], [Image]) VALUES (8, N'Lê Thẩm Dương', CAST(N'1890-05-09' AS Date), N'Nam       ', N'0123676767', N'Hà Nội', NULL)
INSERT [dbo].[PATIENT] ([PatientID], [PatientName], [DateOfBirth], [Gender], [PhoneNumber], [Address], [Image]) VALUES (9, N'Ngô Đình Phúc', CAST(N'1990-02-02' AS Date), N'Nam       ', N'0120787878', N'Hà Nội', NULL)
INSERT [dbo].[PATIENT] ([PatientID], [PatientName], [DateOfBirth], [Gender], [PhoneNumber], [Address], [Image]) VALUES (10, N'Lê Thị Lan', CAST(N'1992-06-07' AS Date), N'Nữ        ', N'098926555', N'Hà Nội', NULL)
INSERT [dbo].[PATIENT] ([PatientID], [PatientName], [DateOfBirth], [Gender], [PhoneNumber], [Address], [Image]) VALUES (11, N'Bạch Thị Thúy Hiền', CAST(N'1997-03-22' AS Date), N'Nữ        ', N'090727272', N'Hà Nội', NULL)
INSERT [dbo].[PATIENT] ([PatientID], [PatientName], [DateOfBirth], [Gender], [PhoneNumber], [Address], [Image]) VALUES (12, N'Agela Phương Trinh', CAST(N'1989-03-27' AS Date), N'Nữ        ', N'098087668', N'Hà Nội', NULL)
INSERT [dbo].[PATIENT] ([PatientID], [PatientName], [DateOfBirth], [Gender], [PhoneNumber], [Address], [Image]) VALUES (13, N'Nguyễn Ngọc Ngạn', CAST(N'1880-09-08' AS Date), N'Nam       ', N'089889922', N'Hà Nội', N'')
INSERT [dbo].[PATIENT] ([PatientID], [PatientName], [DateOfBirth], [Gender], [PhoneNumber], [Address], [Image]) VALUES (14, N'Đặng Hữu Phước Nguyên', CAST(N'1997-03-02' AS Date), N'Nam       ', N'0120777733', N'Hà Nội', NULL)
INSERT [dbo].[PATIENT] ([PatientID], [PatientName], [DateOfBirth], [Gender], [PhoneNumber], [Address], [Image]) VALUES (15, N'Dương Tuấn Anh', CAST(N'1991-10-21' AS Date), N'Nam       ', N'0343154156', N'Hưng Yên', NULL)
INSERT [dbo].[PATIENT] ([PatientID], [PatientName], [DateOfBirth], [Gender], [PhoneNumber], [Address], [Image]) VALUES (17, N'Dương Tuệ Nhân', CAST(N'2018-01-21' AS Date), N'Nam       ', N'0343154156', N'Hưng yên', N'')
INSERT [dbo].[PATIENT] ([PatientID], [PatientName], [DateOfBirth], [Gender], [PhoneNumber], [Address], [Image]) VALUES (20, N'Trần Đăng Hiếu', CAST(N'1997-04-15' AS Date), N'Nam       ', N'0343154156', N'Hưng Yên', N'')
INSERT [dbo].[PATIENT] ([PatientID], [PatientName], [DateOfBirth], [Gender], [PhoneNumber], [Address], [Image]) VALUES (21, N'Trần Đăng Phong ', CAST(N'1997-07-11' AS Date), N'Nam       ', N'0354165167', N'Hưng Yên', N'')
INSERT [dbo].[PATIENT] ([PatientID], [PatientName], [DateOfBirth], [Gender], [PhoneNumber], [Address], [Image]) VALUES (22, N'Doãn Trung Hậu', CAST(N'1958-03-03' AS Date), N'Nam       ', N'0343154156', N'Hà Nội', N'')
INSERT [dbo].[PATIENT] ([PatientID], [PatientName], [DateOfBirth], [Gender], [PhoneNumber], [Address], [Image]) VALUES (23, N'Cao Xuân Sơn', CAST(N'2018-11-25' AS Date), N'Nam       ', N'0343154156', N'Hải Dương', N'')
INSERT [dbo].[PATIENT] ([PatientID], [PatientName], [DateOfBirth], [Gender], [PhoneNumber], [Address], [Image]) VALUES (24, N'Đào Thị Như Hoa', CAST(N'2000-12-08' AS Date), N'Nữ        ', N'0988898787', N'Hưng Yên', N'')
INSERT [dbo].[PATIENT] ([PatientID], [PatientName], [DateOfBirth], [Gender], [PhoneNumber], [Address], [Image]) VALUES (25, N'Đào Bá Lộc', CAST(N'2018-12-18' AS Date), N'Nam       ', N'0989876969', N'Đà Nẵng', N'')
INSERT [dbo].[PATIENT] ([PatientID], [PatientName], [DateOfBirth], [Gender], [PhoneNumber], [Address], [Image]) VALUES (26, N'Doãn Quang Minh', CAST(N'2015-11-08' AS Date), N'Nam       ', N'0987546789', N'Hà Nội', N'')
INSERT [dbo].[PATIENT] ([PatientID], [PatientName], [DateOfBirth], [Gender], [PhoneNumber], [Address], [Image]) VALUES (27, N'Quan Vân Trường', CAST(N'1979-02-02' AS Date), N'Nam       ', N'0987654342', N'Giải Lương-Sơn Tây', N'')
INSERT [dbo].[PATIENT] ([PatientID], [PatientName], [DateOfBirth], [Gender], [PhoneNumber], [Address], [Image]) VALUES (28, N'Nguyễn Ngọc Minh', CAST(N'1997-03-12' AS Date), N'Nam       ', N'0987675652', N'Hưng Yên', N'')
INSERT [dbo].[PATIENT] ([PatientID], [PatientName], [DateOfBirth], [Gender], [PhoneNumber], [Address], [Image]) VALUES (29, N'Nguyễn Việt Anh', CAST(N'1997-07-03' AS Date), N'Nam       ', N'0982656753', N'Hưng Yên', N'')
SET IDENTITY_INSERT [dbo].[PATIENT] OFF
SET IDENTITY_INSERT [dbo].[PROVIDER] ON 

INSERT [dbo].[PROVIDER] ([ProviderID], [ProviderName], [PhoneNumder], [Address]) VALUES (1, N'Công ty TNHH A', N'0123456789          ', N'Hà Nội')
INSERT [dbo].[PROVIDER] ([ProviderID], [ProviderName], [PhoneNumder], [Address]) VALUES (2, N'Công ty TNHH B', N'0222222222          ', N'Hà Nội')
INSERT [dbo].[PROVIDER] ([ProviderID], [ProviderName], [PhoneNumder], [Address]) VALUES (3, N'Công ty TNHH C', N'034567890           ', N'Hà Nội')
INSERT [dbo].[PROVIDER] ([ProviderID], [ProviderName], [PhoneNumder], [Address]) VALUES (4, N'Công ty TNHH D', N'0782378273          ', N'Hồ Chí Minh')
INSERT [dbo].[PROVIDER] ([ProviderID], [ProviderName], [PhoneNumder], [Address]) VALUES (5, N'Công ty TNHH E', N'028391839           ', N'Hồ Chí Minh')
SET IDENTITY_INSERT [dbo].[PROVIDER] OFF
SET IDENTITY_INSERT [dbo].[SERVICE] ON 

INSERT [dbo].[SERVICE] ([ServiceID], [ServiceName], [UnitPrice], [Notes]) VALUES (1, N'Khám Và Tư Vấn', 0, NULL)
INSERT [dbo].[SERVICE] ([ServiceID], [ServiceName], [UnitPrice], [Notes]) VALUES (2, N'Chụp Xquang Quanh Răng - Quanh Chóp', 0, NULL)
INSERT [dbo].[SERVICE] ([ServiceID], [ServiceName], [UnitPrice], [Notes]) VALUES (3, N'Điều Trị Nha Chu – Lấy Vôi Răng, Đánh Bóng 2 Hàm', 300000, N'2 Hàm')
INSERT [dbo].[SERVICE] ([ServiceID], [ServiceName], [UnitPrice], [Notes]) VALUES (4, N'Điều Trị Viêm Nha Chu – Phẫu Thuật Lật Vạt', 5500000, N'Hàm')
INSERT [dbo].[SERVICE] ([ServiceID], [ServiceName], [UnitPrice], [Notes]) VALUES (5, N'Nạo Túi Nha Chu', 300000, N'Răng')
INSERT [dbo].[SERVICE] ([ServiceID], [ServiceName], [UnitPrice], [Notes]) VALUES (6, N'Phẫu Thuật Nạo Túi Nha Chu, Lật Vạt', 1100000, N'Răng')
INSERT [dbo].[SERVICE] ([ServiceID], [ServiceName], [UnitPrice], [Notes]) VALUES (7, N'Lấy Vôi Răng Trẻ Em', 250000, N'Răng')
INSERT [dbo].[SERVICE] ([ServiceID], [ServiceName], [UnitPrice], [Notes]) VALUES (8, N'Răng Sữa – Lung Lay – Bôi Tê/Chích Tê', 100000, N'Răng')
INSERT [dbo].[SERVICE] ([ServiceID], [ServiceName], [UnitPrice], [Notes]) VALUES (9, N'Răng Vĩnh Viễn (Từ Răng 1 -> Răng 5)', 500000, N'Răng')
INSERT [dbo].[SERVICE] ([ServiceID], [ServiceName], [UnitPrice], [Notes]) VALUES (10, N'Răng Vĩnh Viễn (Răng 6, Răng 7)', 600000, N'Răng')
INSERT [dbo].[SERVICE] ([ServiceID], [ServiceName], [UnitPrice], [Notes]) VALUES (11, N'Răng Khôn Hàm Trên', 900000, N'Răng')
INSERT [dbo].[SERVICE] ([ServiceID], [ServiceName], [UnitPrice], [Notes]) VALUES (12, N'Răng Khôn Hàm Trên Mọc Ngầm', 2000000, N'Răng')
INSERT [dbo].[SERVICE] ([ServiceID], [ServiceName], [UnitPrice], [Notes]) VALUES (13, N'Răng Khôn Hàm Dưới', 1000000, N'Răng')
INSERT [dbo].[SERVICE] ([ServiceID], [ServiceName], [UnitPrice], [Notes]) VALUES (14, N'Răng Khôn Hàm Dưới Mọc Lệch', 2500000, N'Răng')
INSERT [dbo].[SERVICE] ([ServiceID], [ServiceName], [UnitPrice], [Notes]) VALUES (15, N'Răng Khôn Hàm Dưới Mọc Ngầm, Lệch', 2000000, N'Răng')
INSERT [dbo].[SERVICE] ([ServiceID], [ServiceName], [UnitPrice], [Notes]) VALUES (16, N'Cắt Chóp', 2500000, N'Răng')
INSERT [dbo].[SERVICE] ([ServiceID], [ServiceName], [UnitPrice], [Notes]) VALUES (17, N'Tẩy Tại Nhà', 2000000, N'Răng')
INSERT [dbo].[SERVICE] ([ServiceID], [ServiceName], [UnitPrice], [Notes]) VALUES (18, N'Tẩy Trắng Ống Tủy', 800000, N'Răng')
INSERT [dbo].[SERVICE] ([ServiceID], [ServiceName], [UnitPrice], [Notes]) VALUES (19, N'Trám Răng Sữa', 150000, N'Răng')
INSERT [dbo].[SERVICE] ([ServiceID], [ServiceName], [UnitPrice], [Notes]) VALUES (20, N'Trám Sealant Phòng Ngừa', 400000, N'Răng')
INSERT [dbo].[SERVICE] ([ServiceID], [ServiceName], [UnitPrice], [Notes]) VALUES (21, N'Trám Răng Sâu', 400000, N'Răng')
INSERT [dbo].[SERVICE] ([ServiceID], [ServiceName], [UnitPrice], [Notes]) VALUES (22, N'Chữa Tủy Răng Ngoài (Từ Răng 1-> Răng 5)', 1000000, N'Răng')
INSERT [dbo].[SERVICE] ([ServiceID], [ServiceName], [UnitPrice], [Notes]) VALUES (23, N'Chữa Tủy Răng Trong Răng 6', 1500000, N'Răng')
INSERT [dbo].[SERVICE] ([ServiceID], [ServiceName], [UnitPrice], [Notes]) VALUES (24, N'Chữa Tủy Răng Trong (Từ Răng 7 -> Răng 8)', 2000000, N'Răng')
INSERT [dbo].[SERVICE] ([ServiceID], [ServiceName], [UnitPrice], [Notes]) VALUES (25, N'Răng Sứ Tạm', 1500000, N'Răng')
INSERT [dbo].[SERVICE] ([ServiceID], [ServiceName], [UnitPrice], [Notes]) VALUES (26, N'Răng Toàn Sứ (cercon Zirconia CAD/CAM)', 6000000, N'Răng')
INSERT [dbo].[SERVICE] ([ServiceID], [ServiceName], [UnitPrice], [Notes]) VALUES (27, N'Hệ thống Implant Cao Cấp: Nobel Active, Straumann Active, Nobel, Tekka, Kontact, Dentist, Neo Biocare', 30000000, N'Răng')
INSERT [dbo].[SERVICE] ([ServiceID], [ServiceName], [UnitPrice], [Notes]) VALUES (30, N'Chăm sóc khách hàng', 2000000, N'dấdsadsadsa')
SET IDENTITY_INSERT [dbo].[SERVICE] OFF
SET IDENTITY_INSERT [dbo].[SERVICE_DETAIL] ON 

INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (1, 14, 1)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (2, 22, 1)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (3, 4, 2)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (4, 7, 3)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (5, 19, 3)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (6, 19, 3)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (7, 18, 4)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (8, 21, 5)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (9, 21, 6)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (10, 7, 7)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (11, 7, 8)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (12, 25, 9)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (13, 26, 9)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (14, 16, 9)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (15, 6, 5)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (16, 8, 5)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (17, 15, 5)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (18, 9, 5)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (19, 12, 3)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (20, 25, 33)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (21, 18, 33)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (22, 9, 34)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (23, 25, 8)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (24, 5, 36)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (25, 13, 6)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (26, 19, 6)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (27, 6, 6)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (28, 18, 54)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (29, 20, 4)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (30, 20, 55)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (31, 4, 56)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (32, 20, 57)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (33, 21, 4)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (34, 25, 4)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (35, 13, 58)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (36, 25, 58)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (37, 1, 60)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (38, 24, 62)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (39, 21, 63)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (40, 17, 64)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (41, 18, 66)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (42, 17, 68)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (43, 23, 68)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (44, 16, 69)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (45, 3, 69)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (46, 19, 70)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (47, 22, 70)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (48, 19, 71)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (49, 19, 74)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (50, 18, 75)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (51, 18, 76)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (52, 11, 77)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (53, 16, 78)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (54, 19, 78)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (55, 8, 78)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (56, 12, 79)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (57, 18, 79)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (58, 17, 80)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (59, 9, 80)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (60, 17, 81)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (61, 10, 82)
SET IDENTITY_INSERT [dbo].[SERVICE_DETAIL] OFF
ALTER TABLE [dbo].[APPOINTMENT]  WITH CHECK ADD  CONSTRAINT [FK_APPOINTMENT_EMPLOYEE] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[EMPLOYEE] ([EmployeeID])
GO
ALTER TABLE [dbo].[APPOINTMENT] CHECK CONSTRAINT [FK_APPOINTMENT_EMPLOYEE]
GO
ALTER TABLE [dbo].[BILL]  WITH CHECK ADD  CONSTRAINT [FK_BILL_MEDICAL_RECORD] FOREIGN KEY([MedicalRecordID])
REFERENCES [dbo].[MEDICAL_RECORD] ([MedicalRecordID])
GO
ALTER TABLE [dbo].[BILL] CHECK CONSTRAINT [FK_BILL_MEDICAL_RECORD]
GO
ALTER TABLE [dbo].[EMPLOYEE]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Account] FOREIGN KEY([AccountID])
REFERENCES [dbo].[ACCOUNT] ([AccountID])
GO
ALTER TABLE [dbo].[EMPLOYEE] CHECK CONSTRAINT [FK_Employee_Account]
GO
ALTER TABLE [dbo].[MATERIAL]  WITH CHECK ADD  CONSTRAINT [FK_MATERIAL_PROVIDER] FOREIGN KEY([ProviderID])
REFERENCES [dbo].[PROVIDER] ([ProviderID])
GO
ALTER TABLE [dbo].[MATERIAL] CHECK CONSTRAINT [FK_MATERIAL_PROVIDER]
GO
ALTER TABLE [dbo].[MATERIALS_ISSUE]  WITH CHECK ADD  CONSTRAINT [FK_MATERIALS_ISSUE_EMPLOYEE] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[EMPLOYEE] ([EmployeeID])
GO
ALTER TABLE [dbo].[MATERIALS_ISSUE] CHECK CONSTRAINT [FK_MATERIALS_ISSUE_EMPLOYEE]
GO
ALTER TABLE [dbo].[MATERIALS_ISSUE]  WITH CHECK ADD  CONSTRAINT [FK_MATERIALS_ISSUE_MATERIAL] FOREIGN KEY([MaterialsID])
REFERENCES [dbo].[MATERIAL] ([MaterialID])
GO
ALTER TABLE [dbo].[MATERIALS_ISSUE] CHECK CONSTRAINT [FK_MATERIALS_ISSUE_MATERIAL]
GO
ALTER TABLE [dbo].[MATERIALS_RECEIPT]  WITH CHECK ADD  CONSTRAINT [FK_MATERIALS_RECEIPT_EMPLOYEE] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[EMPLOYEE] ([EmployeeID])
GO
ALTER TABLE [dbo].[MATERIALS_RECEIPT] CHECK CONSTRAINT [FK_MATERIALS_RECEIPT_EMPLOYEE]
GO
ALTER TABLE [dbo].[MATERIALS_RECEIPT]  WITH CHECK ADD  CONSTRAINT [FK_MATERIALS_RECEIPT_MATERIAL] FOREIGN KEY([MaterialID])
REFERENCES [dbo].[MATERIAL] ([MaterialID])
GO
ALTER TABLE [dbo].[MATERIALS_RECEIPT] CHECK CONSTRAINT [FK_MATERIALS_RECEIPT_MATERIAL]
GO
ALTER TABLE [dbo].[MEDICAL_RECORD]  WITH CHECK ADD  CONSTRAINT [FK_MedicalRecord_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[EMPLOYEE] ([EmployeeID])
GO
ALTER TABLE [dbo].[MEDICAL_RECORD] CHECK CONSTRAINT [FK_MedicalRecord_Employee]
GO
ALTER TABLE [dbo].[MEDICAL_RECORD]  WITH CHECK ADD  CONSTRAINT [FK_MedicalRecord_Patient] FOREIGN KEY([PatientID])
REFERENCES [dbo].[PATIENT] ([PatientID])
GO
ALTER TABLE [dbo].[MEDICAL_RECORD] CHECK CONSTRAINT [FK_MedicalRecord_Patient]
GO
ALTER TABLE [dbo].[MEDICINE_DETAIL]  WITH CHECK ADD  CONSTRAINT [FK_MedicineDetailID_MedicalRecord] FOREIGN KEY([MedicalRecordID])
REFERENCES [dbo].[MEDICAL_RECORD] ([MedicalRecordID])
GO
ALTER TABLE [dbo].[MEDICINE_DETAIL] CHECK CONSTRAINT [FK_MedicineDetailID_MedicalRecord]
GO
ALTER TABLE [dbo].[MEDICINE_DETAIL]  WITH CHECK ADD  CONSTRAINT [FK_MedicineDetailID_Medicine] FOREIGN KEY([MedicineID])
REFERENCES [dbo].[MEDICINE] ([MedicineID])
GO
ALTER TABLE [dbo].[MEDICINE_DETAIL] CHECK CONSTRAINT [FK_MedicineDetailID_Medicine]
GO
ALTER TABLE [dbo].[SERVICE_DETAIL]  WITH CHECK ADD  CONSTRAINT [FK_MedicalRecordDetail_Service] FOREIGN KEY([ServiceID])
REFERENCES [dbo].[SERVICE] ([ServiceID])
GO
ALTER TABLE [dbo].[SERVICE_DETAIL] CHECK CONSTRAINT [FK_MedicalRecordDetail_Service]
GO
ALTER TABLE [dbo].[SERVICE_DETAIL]  WITH CHECK ADD  CONSTRAINT [FK_SERVICE_DETAIL_BILL] FOREIGN KEY([BillID])
REFERENCES [dbo].[BILL] ([BillID])
GO
ALTER TABLE [dbo].[SERVICE_DETAIL] CHECK CONSTRAINT [FK_SERVICE_DETAIL_BILL]
GO
/****** Object:  StoredProcedure [dbo].[DangNhap]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE proc [dbo].[DangNhap](@ACCOUNTNAME nvarchar(50) )
  as
  begin 
  select * from ACCOUNT where AccountName = @ACCOUNTNAME 
  END
GO
/****** Object:  StoredProcedure [dbo].[HienThiNguoiDangNhap]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE proc [dbo].[HienThiNguoiDangNhap] (@ACCOUNTID INT )
  as
  begin
   select EmployeeName , Position , EmployeeID from EMPLOYEE where AccountID = @ACCOUNTID
  end 
GO
/****** Object:  StoredProcedure [dbo].[KiemTraTenDangnhap]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[KiemTraTenDangnhap] (@ACCOUNTNAME nvarchar(50))
  as
  begin
  select AccountName from ACCOUNT   where AccountName =@ACCOUNTNAME
  end 

GO
/****** Object:  StoredProcedure [dbo].[NhapVatLieu]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[NhapVatLieu] (@MATERIALID INT , @RECEIPTAMOUNT INT , @EMPLOYEEID INT ,@RECEIPTDATE DATE)
as
begin
	Insert into MATERIALS_RECEIPT(MaterialID , EmployeeID,ReceiptAmount,ReceiptDate)
	Values (@MATERIALID,@EMPLOYEEID , @RECEIPTAMOUNT , @RECEIPTDATE)	
end

GO
/****** Object:  StoredProcedure [dbo].[SP_CapNhatTinhTrangThanhToan]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_CapNhatTinhTrangThanhToan] (@MEDICALRECORDID int)
as
begin
	update MEDICAL_RECORD
	set PaymentState = N'Đã Thanh Toán'
	where MedicalRecordID = @MEDICALRECORDID
end
GO
/****** Object:  StoredProcedure [dbo].[SP_DembenhNhan1Ngay]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_DembenhNhan1Ngay] (@dateofcreate1 datetime,@dateofcreate2 datetime)
as
begin
	select count(PatientID) as 'PatientNumber',DateOfCreate
	from MEDICAL_RECORD
	group by DateOfCreate
	having DateOfCreate  between @dateofcreate1 and  @dateofcreate2
end

GO
/****** Object:  StoredProcedure [dbo].[Sp_DemLichHen]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Sp_DemLichHen](@Starttime datetime,@Endtime datetime)
As
Begin
select count(AppointmentID)
from APPOINTMENT
where date between @Starttime and @Endtime 
End
GO
/****** Object:  StoredProcedure [dbo].[SP_DSHoaDonMoRong]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_DSHoaDonMoRong] (@PATIENTID INT)
as
begin
select mr.MedicalRecordID , p.PatientName , mr.DateOfCreate , mr.Diagnostic , b.BillID
from BILL b , MEDICAL_RECORD mr , PATIENT p 
where b.MedicalRecordID = mr.MedicalRecordID and mr.PatientID = p.PatientID   AND p.PatientID = @PATIENTID 
end 
GO
/****** Object:  StoredProcedure [dbo].[SP_DSKeDon]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_DSKeDon] (@PATIENTID INT)
as
begin
select md.MedicalRecordID , p.PatientName , mr.DateOfCreate , mr.Diagnostic ,md.MedicineID 
from MEDICINE_DETAIL md , MEDICAL_RECORD mr , PATIENT p
where md.MedicalRecordID = mr.MedicalRecordID and mr.PatientID = p.PatientID AND p.PatientID = @PATIENTID
end 
GO
/****** Object:  StoredProcedure [dbo].[SP_DSNhapVatLieu]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_DSNhapVatLieu]
as
begin 
select * from MATERIALS_RECEIPT 
end 

GO
/****** Object:  StoredProcedure [dbo].[SP_DSXuatVatLieu]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_DSXuatVatLieu]
as
begin
select * from MATERIALS_ISSUE
end 
GO
/****** Object:  StoredProcedure [dbo].[SP_SuaBenhNhan]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_SuaBenhNhan] (@PATIENTID int,@PATIENTNAME NVARCHAR(50) , @DATEOFBIRTH DATE , @GENDER NCHAR(10) , @PHONENUMBER NVARCHAR(50) ,@ADDRESS NVARCHAR(100) , @IMAGE NVARCHAR(50))
As
Begin
	Update PATIENT
	Set PatientName = @PATIENTNAME , DateOfBirth = @DATEOFBIRTH , Gender= @GENDER , PhoneNumber= @PHONENUMBER , Address = @ADDRESS , Image = @IMAGE 
	Where PatientID = @PATIENTID
End
GO
/****** Object:  StoredProcedure [dbo].[SP_SuaDichVu]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SP_SuaDichVu] (@ServiceID int,@ServiceName nvarchar(1000),@UnitPrice int,@Notes nvarchar(1000))
As
Begin
	update SERVICE
	Set ServiceName = @ServiceName, UnitPrice =@UnitPrice,Notes=@Notes
	Where ServiceID =@ServiceID
End
GO
/****** Object:  StoredProcedure [dbo].[SP_SuaLichHen]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_SuaLichHen] (@APPOINTMENTID int,@DATE date,@EMPLOYEEID int , @PHONENUMBER NVARCHAR(50), @PATIENTNAME NVARCHAR(50))
As
Begin
	Update APPOINTMENT
	Set EmployeeID = @EMPLOYEEID ,Date = @DATE, PhoneNumber= @PHONENUMBER ,PatientName = @PATIENTNAME
	Where APPOINTMENTID = @APPOINTMENTID
End
GO
/****** Object:  StoredProcedure [dbo].[SP_SuaMedicalRecord]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_SuaMedicalRecord] (@MEDICALRECORDID INT ,@PATIENTID INT , @DATEOFCREATE DATE , @DIAGNOSTIC NVARCHAR(1000) , @PAYMENTSTATE NVARCHAR(50) ,@EMPLOYEEID INT )
As
Begin
	Update MEDICAL_RECORD
	Set PatientID = @PATIENTID , DateOfCreate = @DATEOFCREATE  , Diagnostic= @DIAGNOSTIC , PaymentState = @PAYMENTSTATE , EmployeeID = @EMPLOYEEID 
	Where MedicalRecordID = @MEDICALRECORDID
End
GO
/****** Object:  StoredProcedure [dbo].[SP_ThemBenhNhan]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[SP_ThemBenhNhan] (@PATIENTNAME NVARCHAR(50) , @DATEOFBIRTH DATE , @GENDER NCHAR(10) , @PHONENUMBER NVARCHAR(50) ,@ADDRESS NVARCHAR(100) , @IMAGE NVARCHAR(50))
As
Begin 
	Insert into PATIENT(PatientName , DateOfBirth , Gender ,PhoneNumber ,Address ,Image)
	Values (@PATIENTNAME,@DATEOFBIRTH,@GENDER,@PHONENUMBER,@ADDRESS,@IMAGE)
End
GO
/****** Object:  StoredProcedure [dbo].[SP_ThemChiTietDichVu]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE proc [dbo].[SP_ThemChiTietDichVu] (@SERVICEID INT , @BILLID INT )
As
Begin
	Insert into  SERVICE_DETAIL(ServiceID,BillID)
	Values (@SERVICEID,@BILLID)
End
GO
/****** Object:  StoredProcedure [dbo].[SP_ThemDichVu]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SP_ThemDichVu] (@ServiceName nvarchar(1000),@UnitPrice int,@Notes nvarchar(1000))
As
Begin
	Insert into SERVICE (ServiceName,UnitPrice,Notes)
	Values (@ServiceName,@UnitPrice,@Notes)
End
GO
/****** Object:  StoredProcedure [dbo].[SP_ThemDichVuTheoMaHoaDon]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_ThemDichVuTheoMaHoaDon](@SERVICEID INT, @BILLID int  )
as
begin
insert into SERVICE_DETAIL (ServiceID ,BillID)
valueS (@SERVICEID ,@BILLID)
end 
GO
/****** Object:  StoredProcedure [dbo].[SP_ThemDonThuoc]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_ThemDonThuoc] (@MEDICALRECORDID INT , @MEDICINEID INT , @AMONG NVARCHAR(50) , @USAGE NVARCHAR(50))
As
Begin
	Insert into  MEDICINE_DETAIL(MedicalRecordID , MedicineID ,Among , Usage)
	Values (@MEDICALRECORDID ,@MEDICINEID ,@AMONG ,@USAGE)
End
GO
/****** Object:  StoredProcedure [dbo].[SP_ThemLichHen]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_ThemLichHen] (@DATE date,@EMPLOYEEID int,@NAME nvarchar(50) , @PHONENUMBER NVARCHAR(50))
As
Begin 
	Insert into APPOINTMENT (DATE,EMPLOYEEID ,PatientName , PhoneNumber )
	Values (@DATE,@EMPLOYEEID,@NAME ,@PHONENUMBER)
End
GO
/****** Object:  StoredProcedure [dbo].[SP_ThemMedicalRecord]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[SP_ThemMedicalRecord] (@PATIENTID INT , @DATEOFCREATE DATE , @DIAGNOSTIC NVARCHAR(1000) , @PAYMENTSTATE NVARCHAR(50) ,@EMPLOYEEID INT )
As
Begin 
	Insert into MEDICAL_RECORD(PatientID , DateOfCreate ,Diagnostic ,PaymentState , EmployeeID)
	Values (@PATIENTID,@DATEOFCREATE,@DIAGNOSTIC,@PAYMENTSTATE,@EMPLOYEEID)
End
GO
/****** Object:  StoredProcedure [dbo].[SP_TimBenhNhanTheoID]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE proc [dbo].[SP_TimBenhNhanTheoID](@PATIENTID INT )
  as 
  begin 

  select PatientID , PatientName , DateOfBirth , Gender
  from PATIENT 
  where PatientID = @PATIENTID
  end
  
GO
/****** Object:  StoredProcedure [dbo].[SP_TimKiemDichVu]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_TimKiemDichVu]
@ServiceName nvarchar(50)
as 
begin

select * 
from SERVICE 
where ServiceName like '%'+@ServiceName+'%'
end 
GO
/****** Object:  StoredProcedure [dbo].[SP_TimKiemDichVuTheoMaDichVu]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_TimKiemDichVuTheoMaDichVu] (@SERVICEID int)
As
Begin
	Select ServiceID , ServiceName , UnitPrice , Notes
	From SERVICE
	Where ServiceID =@SERVICEID
End
GO
/****** Object:  StoredProcedure [dbo].[SP_TimKiemLichHenTheoMaBacSy]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_TimKiemLichHenTheoMaBacSy] (@EMPLOYEEID int)
As
Begin
	Select AppointmentID , Date  ,a.EmployeeID , e.EmployeeName  , a.PatientName , a.PhoneNumber
	From APPOINTMENT a,EMPLOYEE e
	Where a.EmployeeID = @EMPLOYEEID and a.EmployeeID = e.EmployeeID and a.EmployeeID in (select EmployeeID from EMPLOYEE where Position = N'Bác Sỹ') 
End
GO
/****** Object:  StoredProcedure [dbo].[SP_TimKiemLichHenTheoMaLichHen]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_TimKiemLichHenTheoMaLichHen] (@APPOINTMENTID int)
As
Begin
	Select AppointmentID,Date,EmployeeID,PatientName,PhoneNumber
	From APPOINTMENT
	Where AppointmentID =@APPOINTMENTID
End
GO
/****** Object:  StoredProcedure [dbo].[SP_TimKiemVatLieuTheoMa]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_TimKiemVatLieuTheoMa] (@MATERIALID int)
As
Begin
	Select MaterialID , MaterialName , AvailableAmount ,P.ProviderName
	From MATERIAL M , PROVIDER P
	Where MaterialID = @MATERIALID AND M.ProviderID = P.ProviderID
End
GO
/****** Object:  StoredProcedure [dbo].[SP_XemBenhNhan]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[SP_XemBenhNhan]
 as 
 begin 
 select *
 from PATIENT p 
 end 
GO
/****** Object:  StoredProcedure [dbo].[SP_XemBenhNhanTheoBacSy]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_XemBenhNhanTheoBacSy]
as
begin
	select count(PatientID) as 'PatientNumber',EmployeeName
		from MEDICAL_RECORD,EMPLOYEE
	where Medical_Record.EMPLOYEEID = EMPLOYEE.EMPLOYEEID
	group by EmployeeName
end 

GO
/****** Object:  StoredProcedure [dbo].[SP_XemDanhMucThuoc]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_XemDanhMucThuoc]
as 
begin 
select  MedicineID , MedicineName , Category
from MEDICINE 
end
GO
/****** Object:  StoredProcedure [dbo].[SP_XemDichVu]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SP_XemDichVu]
As
Begin
	Select *
	From SERVICE
End
GO
/****** Object:  StoredProcedure [dbo].[SP_XemDichVuTheoMaHoaDon]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_XemDichVuTheoMaHoaDon](@BILLID int)
as
begin 
select sd.ServiceID , s.ServiceName ,s.UnitPrice 
from SERVICE_DETAIL sd , SERVICE s
where sd.ServiceID = s.ServiceID and sd.BillID = @BILLID
end
GO
/****** Object:  StoredProcedure [dbo].[SP_XemDoctor]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_XemDoctor]
as 
begin 
select e.EmployeeID , e.EmployeeName 
from EMPLOYEE e 
where e.Position = N'Bác Sỹ' 
 end 
GO
/****** Object:  StoredProcedure [dbo].[SP_XemHoaDon]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_XemHoaDon] (@MedicalRecordID int)
as
begin
	Select Bill.BillID,SERVICE_DETAIL.ServiceID,ServiceName,UnitPrice,MedicalRecordID
	from BILL,SERVICE,SERVICE_DETAIL
	where BILL.BillID = SERVICE_DETAIL.BillID and SERVICE_DETAIL.ServiceID = SERVICE.ServiceID and Bill.MedicalRecordID = @MedicalRecordID
end
 
GO
/****** Object:  StoredProcedure [dbo].[SP_XemLichHen]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_XemLichHen]
As
Begin
	Select AppointmentID,Date,a.EmployeeID,EmployeeName , PatientName , a.PhoneNumber
	From APPOINTMENT a,EMPLOYEE e
	Where a.EmployeeID = e.EmployeeID
End
GO
/****** Object:  StoredProcedure [dbo].[SP_XemLichHenHomNay]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_XemLichHenHomNay] 
As
Begin
	Select AppointmentID,Date,a.EmployeeID,EmployeeName ,a.PatientName ,a.PhoneNumber
	From APPOINTMENT a,EMPLOYEE e
	Where a.EmployeeID = e.EmployeeID and Date in (select CONVERT (date , SYSDATETIME()))
End
GO
/****** Object:  StoredProcedure [dbo].[SP_XemLichHenHomNayCuaBacSy]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_XemLichHenHomNayCuaBacSy] (@EMPLOYEEID int )
As
Begin
	Select AppointmentID,Date,a.EmployeeID,EmployeeName , a.PatientName,a.PhoneNumber
	From APPOINTMENT a,EMPLOYEE e
	Where a.EmployeeID = e.EmployeeID and Date in (select CONVERT (date , SYSDATETIME())) and a.EmployeeID=@EMPLOYEEID and a.EmployeeID in (select EmployeeID from EMPLOYEE where Position = N'Bác Sỹ') 
End 
GO
/****** Object:  StoredProcedure [dbo].[SP_XemLichSuKham]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[SP_XemLichSuKham]
 as 
 begin 
 select m.MedicalRecordID , m.Diagnostic , m .DateOfCreate , e.EmployeeName , p.PatientName , PaymentState,b.BillID
 from MEDICAL_RECORD  m , PATIENT p , EMPLOYEE e , BILL b
 where m.PatientID = p.PatientID and m.EmployeeID = e.EmployeeID and b.MedicalRecordID = m.MedicalRecordID
  end 
GO
/****** Object:  StoredProcedure [dbo].[SP_XemLichSuKhamTheoBenhNhan]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[SP_XemLichSuKhamTheoBenhNhan] (@PATIENTID int )
 as 
 begin 
 select m.MedicalRecordID , m.Diagnostic , m .DateOfCreate , e.EmployeeName , p.PatientName , PaymentState ,b.BillID
 from MEDICAL_RECORD  m , PATIENT p , EMPLOYEE e  , BILL b
 where m.PatientID = p.PatientID and m.EmployeeID = e.EmployeeID AND m.PatientID = @PATIENTID and b.MedicalRecordID = m.MedicalRecordID
  end 
GO
/****** Object:  StoredProcedure [dbo].[SP_XemNhaCungCap]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

  create proc [dbo].[SP_XemNhaCungCap] 
  as
  begin 
   select ProviderID , ProviderName from PROVIDER 
  end 
GO
/****** Object:  StoredProcedure [dbo].[SP_XemSoLanSuDungDichVu]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_XemSoLanSuDungDichVu]
as
begin
	select ServiceName,count(BillID)as 'NumberOfUse'
	from SERVICE_DETAIL, SERVICE
	Where SERVICE_DETAIL.ServiceID = SERVICE.ServiceID
	group by ServiceName
end
GO
/****** Object:  StoredProcedure [dbo].[SP_XoaBenhNhan]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_XoaBenhNhan] (@PATIENTID int)
As
Begin
	Delete from PATIENT 
	Where PatientID = @PATIENTID
End
GO
/****** Object:  StoredProcedure [dbo].[SP_XoaDichVu]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SP_XoaDichVu] (@ServiceID int)
As
Begin
	delete from SERVICE
	where ServiceID = @ServiceID
End
GO
/****** Object:  StoredProcedure [dbo].[SP_XoaLichHen]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SP_XoaLichHen] (@APPOINTMENTID int)
As
Begin
	Delete from APPOINTMENT 
	Where APPOINTMENTID = @APPOINTMENTID
End
GO
/****** Object:  StoredProcedure [dbo].[SP_XoaMedicalRecord]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  proc [dbo].[SP_XoaMedicalRecord] (@MEDICALRECORDID int)
As
Begin
	Delete from MEDICAL_RECORD 
	Where MedicalRecordID = @MEDICALRECORDID
End
GO
/****** Object:  StoredProcedure [dbo].[SuaVatLieu]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SuaVatLieu](@MATERIALID INT , @MATERIALNAME NVARCHAR(1000) , @PROVIDERID INT , @AVAILABLEAMOUNT INT ,@ExpirationDate DATE)
as
begin 
	update MATERIAL
	Set MaterialName = @MATERIALNAME, ProviderID =@PROVIDERID,AvailableAmount=@AVAILABLEAMOUNT , ExpirationDate= @ExpirationDate 
	Where MaterialID =@MATERIALID
end 
--Xoa Vat Lieu
GO
/****** Object:  StoredProcedure [dbo].[ThemVatLieu]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Them Vat Lieu
create proc [dbo].[ThemVatLieu] (@MATERIALNAME NVARCHAR(1000) , @PROVIDERID INT , @AVAILABLEAMOUNT INT ,@ExpirationDate DATE)
as
begin
	Insert into MATERIAL(MaterialName , ProviderID , AvailableAmount , ExpirationDate )
	Values (@MATERIALNAME ,@PROVIDERID , @AVAILABLEAMOUNT , @ExpirationDate)	
end
-- Sửa Vật Liệu
GO
/****** Object:  StoredProcedure [dbo].[XemGiaDichVu]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

  create proc [dbo].[XemGiaDichVu](@SERVICEID int)
  as
  begin 
  select UnitPrice from SERVICE where ServiceID = @SERVICEID 
  end
GO
/****** Object:  StoredProcedure [dbo].[XemVatLieu]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[XemVatLieu]
as
begin
	select m.MaterialID , m.MaterialName , m.AvailableAmount , p.ProviderName , p.PhoneNumder  from MATERIAL m ,PROVIDER p  where m.ProviderID = p.ProviderID
end 
GO
/****** Object:  StoredProcedure [dbo].[XoaVatLieu]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[XoaVatLieu](@MATERIALID INT )
AS 
BEGIN 
DELETE MATERIAL WHERE MaterialID= @MATERIALID
END 
GO
/****** Object:  StoredProcedure [dbo].[XuatVatLieu]    Script Date: 12/22/2018 4:11:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- XuatVatLieu
create proc [dbo].[XuatVatLieu] (@MATERIALID INT , @ISSUEAMOUNT INT , @EMPLOYEEID INT ,@ISSUETDATE DATE)
as
begin
	Insert into MATERIALS_ISSUE(MaterialsID , EmployeeID,IssueAmount,IssueDate)
	Values (@MATERIALID,@EMPLOYEEID , @ISSUEAMOUNT , @ISSUETDATE)	
end
GO
USE [master]
GO
ALTER DATABASE [iDental] SET  READ_WRITE 
GO
