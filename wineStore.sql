USE [master]
GO
/****** Object:  Database [WineStore]    Script Date: 9/27/2020 10:27:15 PM ******/
CREATE DATABASE [WineStore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WineStore_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\WineStore.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'WineStore_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\WineStore.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [WineStore] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WineStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WineStore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WineStore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WineStore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WineStore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WineStore] SET ARITHABORT OFF 
GO
ALTER DATABASE [WineStore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WineStore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WineStore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WineStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WineStore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WineStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WineStore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WineStore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WineStore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WineStore] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WineStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WineStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WineStore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WineStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WineStore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WineStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WineStore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WineStore] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [WineStore] SET  MULTI_USER 
GO
ALTER DATABASE [WineStore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WineStore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WineStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WineStore] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [WineStore] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [WineStore] SET QUERY_STORE = OFF
GO
USE [WineStore]
GO
/****** Object:  Table [dbo].[Admin_Login]    Script Date: 9/27/2020 10:27:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin_Login](
	[User_Name] [varchar](50) NULL,
	[User_Password] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contact_Data]    Script Date: 9/27/2020 10:27:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contact_Data](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[Message] [varchar](50) NULL,
 CONSTRAINT [PK_Contact_Data] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee_Table]    Script Date: 9/27/2020 10:27:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee_Table](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Designation] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Salary] [varchar](50) NULL,
 CONSTRAINT [PK_Employee_Table] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Purchase_Data]    Script Date: 9/27/2020 10:27:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purchase_Data](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Company] [varchar](50) NULL,
	[Category] [varchar](50) NULL,
	[Price] [varchar](50) NULL,
	[Qty] [varchar](50) NULL,
	[PurchaseDate] [varchar](50) NULL,
 CONSTRAINT [PK_Purchase_Data] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sale_Data]    Script Date: 9/27/2020 10:27:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sale_Data](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Product] [varchar](50) NULL,
	[Qty] [varchar](50) NULL,
	[Bill] [varchar](50) NULL,
	[BuyDate] [varchar](50) NULL,
 CONSTRAINT [PK_Sale_Data] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Admin_Login] ([User_Name], [User_Password]) VALUES (N'admin', N'admin')
SET IDENTITY_INSERT [dbo].[Purchase_Data] ON 

INSERT [dbo].[Purchase_Data] ([id], [Company], [Category], [Price], [Qty], [PurchaseDate]) VALUES (1, N'Jackson', N'drink', N'36', N'1', N'02/02/2020')
SET IDENTITY_INSERT [dbo].[Purchase_Data] OFF
SET IDENTITY_INSERT [dbo].[Sale_Data] ON 

INSERT [dbo].[Sale_Data] ([id], [Name], [Product], [Qty], [Bill], [BuyDate]) VALUES (1, N'Jackson', N'Bottle', N'2', N'36', N'07/09/2020')
SET IDENTITY_INSERT [dbo].[Sale_Data] OFF
USE [master]
GO
ALTER DATABASE [WineStore] SET  READ_WRITE 
GO
