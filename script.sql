USE [master]
GO
/****** Object:  Database [EAMS]    Script Date: 5/8/2018 6:11:56 PM ******/
CREATE DATABASE [EAMS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EAMS', FILENAME = N'D:\Sql server\MSSQL11.MSSQLSERVER\MSSQL\DATA\EAMS.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'EAMS_log', FILENAME = N'D:\Sql server\MSSQL11.MSSQLSERVER\MSSQL\DATA\EAMS_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [EAMS] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EAMS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EAMS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EAMS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EAMS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EAMS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EAMS] SET ARITHABORT OFF 
GO
ALTER DATABASE [EAMS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EAMS] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [EAMS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EAMS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EAMS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EAMS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EAMS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EAMS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EAMS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EAMS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EAMS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EAMS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EAMS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EAMS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EAMS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EAMS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EAMS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EAMS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EAMS] SET RECOVERY FULL 
GO
ALTER DATABASE [EAMS] SET  MULTI_USER 
GO
ALTER DATABASE [EAMS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EAMS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EAMS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EAMS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'EAMS', N'ON'
GO
USE [EAMS]
GO
/****** Object:  Table [dbo].[AttendanceDetails]    Script Date: 5/8/2018 6:11:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AttendanceDetails](
	[AttendanceId] [int] IDENTITY(1,1) NOT NULL,
	[EmpId] [int] NULL,
	[PresentAbsent] [bit] NULL,
	[DateofDay] [datetime] NULL,
 CONSTRAINT [PK_AttendanceDetails] PRIMARY KEY CLUSTERED 
(
	[AttendanceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EmployeeInfo]    Script Date: 5/8/2018 6:11:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeInfo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmpName] [nvarchar](50) NULL,
	[IdNo] [nvarchar](50) NULL,
	[NID] [nvarchar](50) NULL,
	[DOB] [date] NULL,
	[Address] [nvarchar](50) NULL,
	[ContactNumber] [nvarchar](50) NULL,
	[Salary] [float] NULL,
 CONSTRAINT [PK_EmployeeInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[AttendanceDetails]  WITH CHECK ADD  CONSTRAINT [FK_AttendanceDetails_EmployeeInfo] FOREIGN KEY([EmpId])
REFERENCES [dbo].[EmployeeInfo] ([Id])
GO
ALTER TABLE [dbo].[AttendanceDetails] CHECK CONSTRAINT [FK_AttendanceDetails_EmployeeInfo]
GO
USE [master]
GO
ALTER DATABASE [EAMS] SET  READ_WRITE 
GO
