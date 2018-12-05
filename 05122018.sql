USE [master]
GO
/****** Object:  Database [iDental]    Script Date: 12/5/2018 5:41:45 PM ******/
CREATE DATABASE [iDental]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'iDental', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.QUANSQLSEVER\MSSQL\DATA\iDental.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'iDental_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.QUANSQLSEVER\MSSQL\DATA\iDental_log.ldf' , SIZE = 1344KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
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
/****** Object:  Table [dbo].[ACCOUNT]    Script Date: 12/5/2018 5:41:45 PM ******/
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
/****** Object:  Table [dbo].[APPOINTMENT]    Script Date: 12/5/2018 5:41:45 PM ******/
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
/****** Object:  Table [dbo].[BILL]    Script Date: 12/5/2018 5:41:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BILL](
	[BillID] [int] IDENTITY(1,1) NOT NULL,
	[MedicalRecordID] [int] NULL,
	[TotalBill] [float] NULL,
 CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED 
(
	[BillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMPLOYEE]    Script Date: 12/5/2018 5:41:45 PM ******/
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
/****** Object:  Table [dbo].[MATERIAL]    Script Date: 12/5/2018 5:41:45 PM ******/
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
/****** Object:  Table [dbo].[MATERIALS_ISSUE]    Script Date: 12/5/2018 5:41:45 PM ******/
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
/****** Object:  Table [dbo].[MATERIALS_RECEIPT]    Script Date: 12/5/2018 5:41:45 PM ******/
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
/****** Object:  Table [dbo].[MEDICAL_RECORD]    Script Date: 12/5/2018 5:41:45 PM ******/
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
/****** Object:  Table [dbo].[MEDICINE]    Script Date: 12/5/2018 5:41:45 PM ******/
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
/****** Object:  Table [dbo].[MEDICINE_DETAIL]    Script Date: 12/5/2018 5:41:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MEDICINE_DETAIL](
	[MedicineDetailID] [int] IDENTITY(1,1) NOT NULL,
	[MedicineID] [int] NULL,
	[MedicalRecordID] [int] NULL,
	[Usage] [nvarchar](50) NULL,
	[among] [nchar](50) NULL,
 CONSTRAINT [PK_MedicineDetailID] PRIMARY KEY CLUSTERED 
(
	[MedicineDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PATIENT]    Script Date: 12/5/2018 5:41:45 PM ******/
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
/****** Object:  Table [dbo].[PROVIDER]    Script Date: 12/5/2018 5:41:45 PM ******/
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
/****** Object:  Table [dbo].[SERVICE]    Script Date: 12/5/2018 5:41:45 PM ******/
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
/****** Object:  Table [dbo].[SERVICE_DETAIL]    Script Date: 12/5/2018 5:41:45 PM ******/
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

INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (3, CAST(N'2018-03-01' AS Date), 5, N'Đào Thanh Tú', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (4, CAST(N'2018-04-15' AS Date), 4, N'Cao Xuân Tuấn', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (5, CAST(N'2018-11-13' AS Date), 5, N'Nguyễn Thị Ngọc Diệp', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (6, CAST(N'2018-10-10' AS Date), 5, N'Đỗ Quang Minh', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (7, CAST(N'2018-06-05' AS Date), 4, N'Cao Văn Cương', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (8, CAST(N'2018-04-04' AS Date), 5, N'Nguyễn Đình Thi', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (9, CAST(N'2018-08-04' AS Date), 4, N'Trần Thị Hải Yến', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (10, CAST(N'2018-11-12' AS Date), 5, N'Đoàn Mạnh Hòa', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (11, CAST(N'2018-11-14' AS Date), 4, N'Hứa Đức Hạnh', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (12, CAST(N'2018-11-14' AS Date), 5, N'Doãn Nam Trung', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (13, CAST(N'2018-11-17' AS Date), 5, N'Doãn Trung Dũng', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (14, CAST(N'2018-11-17' AS Date), 4, N'Doãn Trung Hậu', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (15, CAST(N'2018-11-17' AS Date), 5, N'Đoàn Thị Thùy Dung', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (16, CAST(N'2018-11-17' AS Date), 5, N'Nguyễn Ái Phương ', NULL)
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
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (37, CAST(N'2018-11-27' AS Date), 5, N'Lương Hữu Dược', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (38, CAST(N'2018-11-26' AS Date), 4, N'Nguyễn Thị Lan', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (39, CAST(N'2018-11-26' AS Date), 4, N'Doãn Nam Trung', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (40, CAST(N'2018-11-26' AS Date), 5, N'Bùi Thị Hương', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (41, CAST(N'2018-11-26' AS Date), 4, N'Bùi Thị Hương', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (42, CAST(N'2018-11-26' AS Date), 5, N'Doãn Nam Trung', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (43, CAST(N'2018-11-26' AS Date), 5, N'Doãn Nam Trung', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (44, NULL, NULL, NULL, NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (45, CAST(N'2018-11-28' AS Date), 4, N'Trần Đăng Hiếu', NULL)
INSERT [dbo].[APPOINTMENT] ([AppointmentID], [Date], [EmployeeID], [PatientName], [PhoneNumber]) VALUES (46, CAST(N'2018-12-05' AS Date), 4, N'Cao Toàn Phát ', N'0131245425')
SET IDENTITY_INSERT [dbo].[APPOINTMENT] OFF
SET IDENTITY_INSERT [dbo].[BILL] ON 

INSERT [dbo].[BILL] ([BillID], [MedicalRecordID], [TotalBill]) VALUES (1, 1, NULL)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID], [TotalBill]) VALUES (2, 2, NULL)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID], [TotalBill]) VALUES (3, 3, NULL)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID], [TotalBill]) VALUES (4, 4, NULL)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID], [TotalBill]) VALUES (5, 5, NULL)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID], [TotalBill]) VALUES (6, 6, NULL)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID], [TotalBill]) VALUES (7, 7, NULL)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID], [TotalBill]) VALUES (8, 8, NULL)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID], [TotalBill]) VALUES (9, 9, NULL)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID], [TotalBill]) VALUES (10, 10, NULL)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID], [TotalBill]) VALUES (11, 11, NULL)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID], [TotalBill]) VALUES (12, 12, NULL)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID], [TotalBill]) VALUES (13, 13, NULL)
INSERT [dbo].[BILL] ([BillID], [MedicalRecordID], [TotalBill]) VALUES (14, 14, NULL)
SET IDENTITY_INSERT [dbo].[BILL] OFF
SET IDENTITY_INSERT [dbo].[EMPLOYEE] ON 

INSERT [dbo].[EMPLOYEE] ([EmployeeID], [EmployeeName], [DateOfBirth], [PhoneNumber], [Position], [Address], [Image], [AccountID]) VALUES (1, N'Lê Hồ Bá Quang', CAST(N'1997-04-15' AS Date), N'01207273497         ', N'Nhân Viên', N'Nghệ An', NULL, 1)
INSERT [dbo].[EMPLOYEE] ([EmployeeID], [EmployeeName], [DateOfBirth], [PhoneNumber], [Position], [Address], [Image], [AccountID]) VALUES (2, N'Đỗ Vĩnh Hùng', CAST(N'1997-01-01' AS Date), N'0123456789          ', N'Nhân Viên', N'Hà Nội', NULL, 2)
INSERT [dbo].[EMPLOYEE] ([EmployeeID], [EmployeeName], [DateOfBirth], [PhoneNumber], [Position], [Address], [Image], [AccountID]) VALUES (3, N'Nguyễn Huy Hùng', CAST(N'1997-02-02' AS Date), N'0123234444          ', N'Quản Lý', N'Hà Nội', NULL, 3)
INSERT [dbo].[EMPLOYEE] ([EmployeeID], [EmployeeName], [DateOfBirth], [PhoneNumber], [Position], [Address], [Image], [AccountID]) VALUES (4, N'Dương Hải Quân', CAST(N'1997-03-03' AS Date), N'090031232           ', N'Bác Sỹ', N'Hà Nội', NULL, 4)
INSERT [dbo].[EMPLOYEE] ([EmployeeID], [EmployeeName], [DateOfBirth], [PhoneNumber], [Position], [Address], [Image], [AccountID]) VALUES (5, N'Hải Thượng Lãn Ông', CAST(N'1997-04-04' AS Date), N'0998762222          ', N'Bác Sỹ', N'Hà Nội', NULL, 5)
SET IDENTITY_INSERT [dbo].[EMPLOYEE] OFF
SET IDENTITY_INSERT [dbo].[MATERIAL] ON 

INSERT [dbo].[MATERIAL] ([MaterialID], [MaterialName], [ProviderID], [AvailableAmount], [ExpirationDate]) VALUES (1, N'Máy Cạo Vôi Răng', 1, 3, NULL)
INSERT [dbo].[MATERIAL] ([MaterialID], [MaterialName], [ProviderID], [AvailableAmount], [ExpirationDate]) VALUES (2, N'Đèn Trám Halogen', 1, 3, NULL)
INSERT [dbo].[MATERIAL] ([MaterialID], [MaterialName], [ProviderID], [AvailableAmount], [ExpirationDate]) VALUES (3, N'Thiết Bị Đo Chiều Dài Ống Tủy', 1, 2, NULL)
INSERT [dbo].[MATERIAL] ([MaterialID], [MaterialName], [ProviderID], [AvailableAmount], [ExpirationDate]) VALUES (4, N'Lò Hấp AutoClave', 2, 4, NULL)
INSERT [dbo].[MATERIAL] ([MaterialID], [MaterialName], [ProviderID], [AvailableAmount], [ExpirationDate]) VALUES (5, N'Máy Đo Huyết Áp', 2, 3, NULL)
INSERT [dbo].[MATERIAL] ([MaterialID], [MaterialName], [ProviderID], [AvailableAmount], [ExpirationDate]) VALUES (6, N'Máy X Quang Gender', 2, 4, NULL)
INSERT [dbo].[MATERIAL] ([MaterialID], [MaterialName], [ProviderID], [AvailableAmount], [ExpirationDate]) VALUES (7, N'Máy Khoan Đặt Trụ Implant', 2, 2, NULL)
INSERT [dbo].[MATERIAL] ([MaterialID], [MaterialName], [ProviderID], [AvailableAmount], [ExpirationDate]) VALUES (8, N'Đèn Tẩy Trắng ZoomWhitening', 4, 3, NULL)
INSERT [dbo].[MATERIAL] ([MaterialID], [MaterialName], [ProviderID], [AvailableAmount], [ExpirationDate]) VALUES (9, N'Hệ Thống CAD/CAM Trong Chế Tạo Răng Sứ', 4, 2, NULL)
INSERT [dbo].[MATERIAL] ([MaterialID], [MaterialName], [ProviderID], [AvailableAmount], [ExpirationDate]) VALUES (10, N'Bông Băng', 5, 1000, NULL)
INSERT [dbo].[MATERIAL] ([MaterialID], [MaterialName], [ProviderID], [AvailableAmount], [ExpirationDate]) VALUES (11, N'Thuốc Gây Mê', 5, 1000, NULL)
INSERT [dbo].[MATERIAL] ([MaterialID], [MaterialName], [ProviderID], [AvailableAmount], [ExpirationDate]) VALUES (12, N'Bàn', 3, 10, NULL)
INSERT [dbo].[MATERIAL] ([MaterialID], [MaterialName], [ProviderID], [AvailableAmount], [ExpirationDate]) VALUES (13, N'Ghế', 3, 10, NULL)
INSERT [dbo].[MATERIAL] ([MaterialID], [MaterialName], [ProviderID], [AvailableAmount], [ExpirationDate]) VALUES (14, N'Máy Tính', 3, 6, NULL)
INSERT [dbo].[MATERIAL] ([MaterialID], [MaterialName], [ProviderID], [AvailableAmount], [ExpirationDate]) VALUES (15, N'Điều Hòa', 3, 4, NULL)
INSERT [dbo].[MATERIAL] ([MaterialID], [MaterialName], [ProviderID], [AvailableAmount], [ExpirationDate]) VALUES (16, N'Kim Tiêm', 3, 1000, NULL)
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
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (15, 1, CAST(N'2018-10-09' AS Date), N'Cắt Chóp', N'Chưa Thanh Toán', 1)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (16, 7, CAST(N'2018-12-04' AS Date), N'Sâu Răng Khôn', N'0', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (17, 7, CAST(N'2018-12-04' AS Date), N'Sâu Răng Khôn 1', N'0', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (18, 12, CAST(N'2018-12-04' AS Date), N'Gãy Răng Cửa', N'0', 5)
INSERT [dbo].[MEDICAL_RECORD] ([MedicalRecordID], [PatientID], [DateOfCreate], [Diagnostic], [PaymentState], [EmployeeID]) VALUES (19, 15, CAST(N'2018-12-04' AS Date), N'Viêm Tủy Răng Số 8', N'0', 5)
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

INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [among]) VALUES (1, 18, 1, NULL, NULL)
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [among]) VALUES (2, 3, 1, NULL, NULL)
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [among]) VALUES (3, 4, 3, NULL, NULL)
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [among]) VALUES (4, 5, 4, NULL, NULL)
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [among]) VALUES (5, 9, 5, NULL, NULL)
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [among]) VALUES (6, 1, 5, NULL, NULL)
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [among]) VALUES (7, 3, 7, NULL, NULL)
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [among]) VALUES (8, 21, 8, NULL, NULL)
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [among]) VALUES (9, 17, 9, NULL, NULL)
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [among]) VALUES (10, 14, 10, NULL, NULL)
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [among]) VALUES (11, 15, 11, NULL, NULL)
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [among]) VALUES (12, 19, 11, NULL, NULL)
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [among]) VALUES (13, 6, 11, NULL, NULL)
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [among]) VALUES (14, 7, 14, NULL, NULL)
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [among]) VALUES (15, 8, 2, NULL, NULL)
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [among]) VALUES (16, 2, 6, NULL, NULL)
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [among]) VALUES (17, 3, 12, NULL, NULL)
INSERT [dbo].[MEDICINE_DETAIL] ([MedicineDetailID], [MedicineID], [MedicalRecordID], [Usage], [among]) VALUES (18, 1, 13, NULL, NULL)
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

INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (1, 14, NULL)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (2, 22, NULL)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (3, 4, NULL)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (4, 7, NULL)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (5, 19, NULL)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (6, 19, NULL)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (7, 18, NULL)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (8, 21, NULL)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (9, 21, NULL)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (10, 7, NULL)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (11, 7, NULL)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (12, 25, NULL)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (13, 26, NULL)
INSERT [dbo].[SERVICE_DETAIL] ([ServiceDetailID], [ServiceID], [BillID]) VALUES (14, 16, NULL)
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
/****** Object:  StoredProcedure [dbo].[Sp_DemLichHen]    Script Date: 12/5/2018 5:41:45 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_SuaBenhNhan]    Script Date: 12/5/2018 5:41:45 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_SuaDichVu]    Script Date: 12/5/2018 5:41:45 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_SuaLichHen]    Script Date: 12/5/2018 5:41:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_SuaLichHen] (@APPOINTMENTID int,@DATE date,@EMPLOYEEID int , @PHONENUMBER NVARCHAR(50), @PATIENTNAME NVARCHAR(50))
As
Begin
	Update APPOINTMENT
	Set Date = @DATE,EmployeeID = @EMPLOYEEID , PhoneNumber= @PHONENUMBER ,PatientName = @PATIENTNAME
	Where APPOINTMENTID = @APPOINTMENTID
End
GO
/****** Object:  StoredProcedure [dbo].[SP_SuaMedicalRecord]    Script Date: 12/5/2018 5:41:45 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_ThemBenhNhan]    Script Date: 12/5/2018 5:41:45 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_ThemChiTietDichVu]    Script Date: 12/5/2018 5:41:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 create proc [dbo].[SP_ThemChiTietDichVu] (@DETAILID INT,@SERVICEID INT , @BILLID INT )
As
Begin
	Insert into  SERVICE_DETAIL(ServiceDetailID,ServiceID,BillID)
	Values (@DETAILID,@SERVICEID,@BILLID)
End
GO
/****** Object:  StoredProcedure [dbo].[SP_ThemDichVu]    Script Date: 12/5/2018 5:41:45 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_ThemLichHen]    Script Date: 12/5/2018 5:41:45 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_ThemMedicalRecord]    Script Date: 12/5/2018 5:41:45 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_TimBenhNhanTheoID]    Script Date: 12/5/2018 5:41:45 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_TimKiemDichVu]    Script Date: 12/5/2018 5:41:45 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_TimKiemDichVuTheoMaDichVu]    Script Date: 12/5/2018 5:41:45 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_TimKiemLichHenTheoMaBacSy]    Script Date: 12/5/2018 5:41:45 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_TimKiemLichHenTheoMaLichHen]    Script Date: 12/5/2018 5:41:45 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_XemBenhNhan]    Script Date: 12/5/2018 5:41:45 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_XemDichVu]    Script Date: 12/5/2018 5:41:45 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_XemDoctor]    Script Date: 12/5/2018 5:41:45 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_XemLichHen]    Script Date: 12/5/2018 5:41:45 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_XemLichHenHomNay]    Script Date: 12/5/2018 5:41:45 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_XemLichHenHomNayCuaBacSy]    Script Date: 12/5/2018 5:41:45 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_XemLichSuKham]    Script Date: 12/5/2018 5:41:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[SP_XemLichSuKham]
 as 
 begin 
 select m.MedicalRecordID , m.Diagnostic , m .DateOfCreate , e.EmployeeName , p.PatientName , PaymentState
 from MEDICAL_RECORD  m , PATIENT p , EMPLOYEE e 
 where m.PatientID = p.PatientID and m.EmployeeID = e.EmployeeID 
  end 
GO
/****** Object:  StoredProcedure [dbo].[SP_XemLichSuKhamTheoBenhNhan]    Script Date: 12/5/2018 5:41:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[SP_XemLichSuKhamTheoBenhNhan] (@PATIENTID int )
 as 
 begin 
 select m.MedicalRecordID , m.Diagnostic , m .DateOfCreate , e.EmployeeName , p.PatientName , PaymentState
 from MEDICAL_RECORD  m , PATIENT p , EMPLOYEE e 
 where m.PatientID = p.PatientID and m.EmployeeID = e.EmployeeID AND m.PatientID = @PATIENTID
  end 
GO
/****** Object:  StoredProcedure [dbo].[SP_XoaBenhNhan]    Script Date: 12/5/2018 5:41:45 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_XoaDichVu]    Script Date: 12/5/2018 5:41:45 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_XoaLichHen]    Script Date: 12/5/2018 5:41:45 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_XoaMedicalRecord]    Script Date: 12/5/2018 5:41:45 PM ******/
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
USE [master]
GO
ALTER DATABASE [iDental] SET  READ_WRITE 
GO
