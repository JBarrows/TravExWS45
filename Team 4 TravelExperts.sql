USE [master]
GO
/****** Object:  Database [TravelExperts]    Script Date: 8/1/2018 1:09:45 PM ******/
CREATE DATABASE [TravelExperts]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TravelExperts', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\TravelExperts.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TravelExperts_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\TravelExperts_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [TravelExperts] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TravelExperts].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TravelExperts] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TravelExperts] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TravelExperts] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TravelExperts] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TravelExperts] SET ARITHABORT OFF 
GO
ALTER DATABASE [TravelExperts] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [TravelExperts] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TravelExperts] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TravelExperts] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TravelExperts] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TravelExperts] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TravelExperts] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TravelExperts] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TravelExperts] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TravelExperts] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TravelExperts] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TravelExperts] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TravelExperts] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TravelExperts] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TravelExperts] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TravelExperts] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TravelExperts] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TravelExperts] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TravelExperts] SET  MULTI_USER 
GO
ALTER DATABASE [TravelExperts] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TravelExperts] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TravelExperts] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TravelExperts] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TravelExperts] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TravelExperts] SET QUERY_STORE = OFF
GO
USE [TravelExperts]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [TravelExperts]
GO
/****** Object:  Table [dbo].[Products_Suppliers]    Script Date: 8/1/2018 1:09:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products_Suppliers](
	[ProductSupplierId] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NULL,
	[SupplierId] [int] NULL,
 CONSTRAINT [aaaaaProducts_Suppliers_PK] PRIMARY KEY NONCLUSTERED 
(
	[ProductSupplierId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[Find duplicates for Products_Suppliers]    Script Date: 8/1/2018 1:09:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Find duplicates for Products_Suppliers] () 
RETURNS TABLE 
AS RETURN (SELECT TOP 100 PERCENT Products_Suppliers.ProductId, Products_Suppliers.SupplierId, Products_Suppliers.ProductSupplierId
FROM Products_Suppliers
WHERE (((Products_Suppliers.ProductId) In (SELECT ProductId FROM Products_Suppliers As Tmp GROUP BY ProductId,SupplierId HAVING count(*)>1  And SupplierId = Products_Suppliers.SupplierId)))
ORDER BY Products_Suppliers.ProductId, Products_Suppliers.SupplierId)
GO
/****** Object:  Table [dbo].[Bookings]    Script Date: 8/1/2018 1:09:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bookings](
	[BookingId] [int] IDENTITY(1,1) NOT NULL,
	[BookingDate] [datetime] NULL,
	[BookingNo] [nvarchar](50) NULL,
	[TravelerCount] [float] NULL,
	[CustomerId] [int] NULL,
	[TripTypeId] [nvarchar](1) NULL,
	[PackageId] [int] NULL,
 CONSTRAINT [aaaaaBookings_PK] PRIMARY KEY NONCLUSTERED 
(
	[BookingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[Find duplicates for Bookings]    Script Date: 8/1/2018 1:09:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Find duplicates for Bookings] () 
RETURNS TABLE 
AS RETURN (SELECT TOP 100 PERCENT Bookings.BookingNo, Bookings.BookingId, Bookings.BookingDate
FROM Bookings
WHERE (((Bookings.BookingNo) In (SELECT BookingNo FROM Bookings As Tmp GROUP BY BookingNo HAVING count(*)>1 )))
ORDER BY Bookings.BookingNo)
GO
/****** Object:  Table [dbo].[Affiliations]    Script Date: 8/1/2018 1:09:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Affiliations](
	[AffilitationId] [nvarchar](10) NOT NULL,
	[AffName] [nvarchar](50) NULL,
	[AffDesc] [nvarchar](50) NULL,
 CONSTRAINT [aaaaaAffiliations_PK] PRIMARY KEY NONCLUSTERED 
(
	[AffilitationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Agencies]    Script Date: 8/1/2018 1:09:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Agencies](
	[AgencyId] [int] IDENTITY(1,1) NOT NULL,
	[AgncyAddress] [nvarchar](50) NULL,
	[AgncyCity] [nvarchar](50) NULL,
	[AgncyProv] [nvarchar](50) NULL,
	[AgncyPostal] [nvarchar](50) NULL,
	[AgncyCountry] [nvarchar](50) NULL,
	[AgncyPhone] [nvarchar](50) NULL,
	[AgncyFax] [nvarchar](50) NULL,
 CONSTRAINT [PK_Agencies] PRIMARY KEY CLUSTERED 
(
	[AgencyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Agents]    Script Date: 8/1/2018 1:09:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Agents](
	[AgentId] [int] IDENTITY(1,1) NOT NULL,
	[AgtFirstName] [nvarchar](20) NULL,
	[AgtMiddleInitial] [nvarchar](5) NULL,
	[AgtLastName] [nvarchar](20) NULL,
	[AgtBusPhone] [nvarchar](20) NULL,
	[AgtEmail] [nvarchar](50) NULL,
	[AgtPosition] [nvarchar](20) NULL,
	[AgencyId] [int] NULL,
 CONSTRAINT [PK_Agents] PRIMARY KEY CLUSTERED 
(
	[AgentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookingDetails]    Script Date: 8/1/2018 1:09:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookingDetails](
	[BookingDetailId] [int] IDENTITY(1,1) NOT NULL,
	[ItineraryNo] [float] NULL,
	[TripStart] [datetime] NULL,
	[TripEnd] [datetime] NULL,
	[Description] [nvarchar](255) NULL,
	[Destination] [nvarchar](255) NULL,
	[BasePrice] [money] NULL,
	[AgencyCommission] [money] NULL,
	[BookingId] [int] NULL,
	[RegionId] [nvarchar](5) NULL,
	[ClassId] [nvarchar](5) NULL,
	[FeeId] [nvarchar](10) NULL,
	[ProductSupplierId] [int] NULL,
 CONSTRAINT [aaaaaBookingDetails_PK] PRIMARY KEY NONCLUSTERED 
(
	[BookingDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Classes]    Script Date: 8/1/2018 1:09:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Classes](
	[ClassId] [nvarchar](5) NOT NULL,
	[ClassName] [nvarchar](20) NOT NULL,
	[ClassDesc] [nvarchar](50) NULL,
 CONSTRAINT [aaaaaClasses_PK] PRIMARY KEY NONCLUSTERED 
(
	[ClassId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CreditCards]    Script Date: 8/1/2018 1:09:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CreditCards](
	[CreditCardId] [int] IDENTITY(1,1) NOT NULL,
	[CCName] [nvarchar](10) NOT NULL,
	[CCNumber] [nvarchar](50) NOT NULL,
	[CCExpiry] [datetime] NOT NULL,
	[CustomerId] [int] NOT NULL,
 CONSTRAINT [aaaaaCreditCards_PK] PRIMARY KEY NONCLUSTERED 
(
	[CreditCardId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 8/1/2018 1:09:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[CustFirstName] [nvarchar](25) NOT NULL,
	[CustLastName] [nvarchar](25) NOT NULL,
	[CustAddress] [nvarchar](75) NOT NULL,
	[CustCity] [nvarchar](50) NOT NULL,
	[CustProv] [nvarchar](2) NOT NULL,
	[CustPostal] [nvarchar](7) NOT NULL,
	[CustCountry] [nvarchar](25) NULL,
	[CustHomePhone] [nvarchar](20) NOT NULL,
	[CustBusPhone] [nvarchar](20) NULL,
	[CustEmail] [nvarchar](50) NULL,
	[AgentId] [int] NULL,
 CONSTRAINT [aaaaaCustomers_PK] PRIMARY KEY NONCLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers_Rewards]    Script Date: 8/1/2018 1:09:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers_Rewards](
	[CustomerId] [int] NOT NULL,
	[RewardId] [int] NOT NULL,
	[RwdNumber] [nvarchar](25) NOT NULL,
 CONSTRAINT [aaaaaCustomers_Rewards_PK] PRIMARY KEY NONCLUSTERED 
(
	[CustomerId] ASC,
	[RewardId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 8/1/2018 1:09:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmpFirstName] [nvarchar](20) NOT NULL,
	[EmpMiddleInitial] [nvarchar](5) NULL,
	[EmpLastName] [nvarchar](20) NOT NULL,
	[EmpBusPhone] [nvarchar](20) NOT NULL,
	[EmpEmail] [nvarchar](50) NOT NULL,
	[EmpPosition] [nvarchar](20) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fees]    Script Date: 8/1/2018 1:09:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fees](
	[FeeId] [nvarchar](10) NOT NULL,
	[FeeName] [nvarchar](50) NOT NULL,
	[FeeAmt] [money] NOT NULL,
	[FeeDesc] [nvarchar](50) NULL,
 CONSTRAINT [aaaaaFees_PK] PRIMARY KEY NONCLUSTERED 
(
	[FeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Logins]    Script Date: 8/1/2018 1:09:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logins](
	[CustomerID] [int] NOT NULL,
	[Password] [varchar](31) NOT NULL,
	[UserName] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Packages]    Script Date: 8/1/2018 1:09:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Packages](
	[PackageId] [int] IDENTITY(1,1) NOT NULL,
	[PkgName] [nvarchar](50) NOT NULL,
	[PkgStartDate] [datetime] NULL,
	[PkgEndDate] [datetime] NULL,
	[PkgDesc] [nvarchar](50) NULL,
	[PkgBasePrice] [money] NOT NULL,
	[PkgAgencyCommission] [money] NULL,
 CONSTRAINT [aaaaaPackages_PK] PRIMARY KEY NONCLUSTERED 
(
	[PackageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Packages_Products_Suppliers]    Script Date: 8/1/2018 1:09:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Packages_Products_Suppliers](
	[PackageId] [int] NOT NULL,
	[ProductSupplierId] [int] NOT NULL,
 CONSTRAINT [aaaaaPackages_Products_Suppliers_PK] PRIMARY KEY NONCLUSTERED 
(
	[PackageId] ASC,
	[ProductSupplierId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 8/1/2018 1:09:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProdName] [nvarchar](50) NOT NULL,
 CONSTRAINT [aaaaaProducts_PK] PRIMARY KEY NONCLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Regions]    Script Date: 8/1/2018 1:09:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Regions](
	[RegionId] [nvarchar](5) NOT NULL,
	[RegionName] [nvarchar](25) NULL,
 CONSTRAINT [aaaaaRegions_PK] PRIMARY KEY NONCLUSTERED 
(
	[RegionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rewards]    Script Date: 8/1/2018 1:09:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rewards](
	[RewardId] [int] NOT NULL,
	[RwdName] [nvarchar](50) NULL,
	[RwdDesc] [nvarchar](50) NULL,
 CONSTRAINT [aaaaaRewards_PK] PRIMARY KEY NONCLUSTERED 
(
	[RewardId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SupplierContacts]    Script Date: 8/1/2018 1:09:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SupplierContacts](
	[SupplierContactId] [int] NOT NULL,
	[SupConFirstName] [nvarchar](50) NULL,
	[SupConLastName] [nvarchar](50) NULL,
	[SupConCompany] [nvarchar](255) NULL,
	[SupConAddress] [nvarchar](255) NULL,
	[SupConCity] [nvarchar](255) NULL,
	[SupConProv] [nvarchar](255) NULL,
	[SupConPostal] [nvarchar](255) NULL,
	[SupConCountry] [nvarchar](255) NULL,
	[SupConBusPhone] [nvarchar](50) NULL,
	[SupConFax] [nvarchar](50) NULL,
	[SupConEmail] [nvarchar](255) NULL,
	[SupConURL] [nvarchar](255) NULL,
	[AffiliationId] [nvarchar](10) NULL,
	[SupplierId] [int] NULL,
 CONSTRAINT [aaaaaSupplierContacts_PK] PRIMARY KEY NONCLUSTERED 
(
	[SupplierContactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 8/1/2018 1:09:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[SupplierId] [int] NOT NULL,
	[SupName] [nvarchar](255) NULL,
 CONSTRAINT [aaaaaSuppliers_PK] PRIMARY KEY NONCLUSTERED 
(
	[SupplierId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TripTypes]    Script Date: 8/1/2018 1:09:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TripTypes](
	[TripTypeId] [nvarchar](1) NOT NULL,
	[TTName] [nvarchar](25) NULL,
 CONSTRAINT [aaaaaTripTypes_PK] PRIMARY KEY NONCLUSTERED 
(
	[TripTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [Agency Fee Code]    Script Date: 8/1/2018 1:09:46 PM ******/
CREATE NONCLUSTERED INDEX [Agency Fee Code] ON [dbo].[BookingDetails]
(
	[FeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [BookingId]    Script Date: 8/1/2018 1:09:46 PM ******/
CREATE NONCLUSTERED INDEX [BookingId] ON [dbo].[BookingDetails]
(
	[BookingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [BookingsBookingDetails]    Script Date: 8/1/2018 1:09:46 PM ******/
CREATE NONCLUSTERED INDEX [BookingsBookingDetails] ON [dbo].[BookingDetails]
(
	[BookingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [ClassesBookingDetails]    Script Date: 8/1/2018 1:09:46 PM ******/
CREATE NONCLUSTERED INDEX [ClassesBookingDetails] ON [dbo].[BookingDetails]
(
	[ClassId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [Dest ID]    Script Date: 8/1/2018 1:09:46 PM ******/
CREATE NONCLUSTERED INDEX [Dest ID] ON [dbo].[BookingDetails]
(
	[RegionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [DestinationsBookingDetails]    Script Date: 8/1/2018 1:09:46 PM ******/
CREATE NONCLUSTERED INDEX [DestinationsBookingDetails] ON [dbo].[BookingDetails]
(
	[RegionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [FeesBookingDetails]    Script Date: 8/1/2018 1:09:46 PM ******/
CREATE NONCLUSTERED INDEX [FeesBookingDetails] ON [dbo].[BookingDetails]
(
	[FeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Products_SuppliersBookingDetails]    Script Date: 8/1/2018 1:09:46 PM ******/
CREATE NONCLUSTERED INDEX [Products_SuppliersBookingDetails] ON [dbo].[BookingDetails]
(
	[ProductSupplierId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ProductSupplierId]    Script Date: 8/1/2018 1:09:46 PM ******/
CREATE NONCLUSTERED INDEX [ProductSupplierId] ON [dbo].[BookingDetails]
(
	[ProductSupplierId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [BookingsCustomerId]    Script Date: 8/1/2018 1:09:46 PM ******/
CREATE NONCLUSTERED INDEX [BookingsCustomerId] ON [dbo].[Bookings]
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [CustomersBookings]    Script Date: 8/1/2018 1:09:46 PM ******/
CREATE NONCLUSTERED INDEX [CustomersBookings] ON [dbo].[Bookings]
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PackageId]    Script Date: 8/1/2018 1:09:46 PM ******/
CREATE NONCLUSTERED INDEX [PackageId] ON [dbo].[Bookings]
(
	[PackageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PackagesBookings]    Script Date: 8/1/2018 1:09:46 PM ******/
CREATE NONCLUSTERED INDEX [PackagesBookings] ON [dbo].[Bookings]
(
	[PackageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [TripTypesBookings]    Script Date: 8/1/2018 1:09:46 PM ******/
CREATE NONCLUSTERED INDEX [TripTypesBookings] ON [dbo].[Bookings]
(
	[TripTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [CustomersCreditCards]    Script Date: 8/1/2018 1:09:46 PM ******/
CREATE NONCLUSTERED INDEX [CustomersCreditCards] ON [dbo].[CreditCards]
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [EmployeesCustomers]    Script Date: 8/1/2018 1:09:46 PM ******/
CREATE NONCLUSTERED INDEX [EmployeesCustomers] ON [dbo].[Customers]
(
	[AgentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [CustomersCustomers_Rewards]    Script Date: 8/1/2018 1:09:46 PM ******/
CREATE NONCLUSTERED INDEX [CustomersCustomers_Rewards] ON [dbo].[Customers_Rewards]
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [RewardsCustomers_Rewards]    Script Date: 8/1/2018 1:09:46 PM ******/
CREATE NONCLUSTERED INDEX [RewardsCustomers_Rewards] ON [dbo].[Customers_Rewards]
(
	[RewardId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PackagesPackages_Products_Suppliers]    Script Date: 8/1/2018 1:09:46 PM ******/
CREATE NONCLUSTERED INDEX [PackagesPackages_Products_Suppliers] ON [dbo].[Packages_Products_Suppliers]
(
	[PackageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Products_SuppliersPackages_Products_Suppliers]    Script Date: 8/1/2018 1:09:46 PM ******/
CREATE NONCLUSTERED INDEX [Products_SuppliersPackages_Products_Suppliers] ON [dbo].[Packages_Products_Suppliers]
(
	[ProductSupplierId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ProductSupplierId]    Script Date: 8/1/2018 1:09:46 PM ******/
CREATE NONCLUSTERED INDEX [ProductSupplierId] ON [dbo].[Packages_Products_Suppliers]
(
	[ProductSupplierId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ProductId]    Script Date: 8/1/2018 1:09:46 PM ******/
CREATE NONCLUSTERED INDEX [ProductId] ON [dbo].[Products]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Product Supplier ID]    Script Date: 8/1/2018 1:09:46 PM ******/
CREATE NONCLUSTERED INDEX [Product Supplier ID] ON [dbo].[Products_Suppliers]
(
	[SupplierId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ProductId]    Script Date: 8/1/2018 1:09:46 PM ******/
CREATE NONCLUSTERED INDEX [ProductId] ON [dbo].[Products_Suppliers]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ProductsProducts_Suppliers1]    Script Date: 8/1/2018 1:09:46 PM ******/
CREATE NONCLUSTERED INDEX [ProductsProducts_Suppliers1] ON [dbo].[Products_Suppliers]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ProductSupplierId]    Script Date: 8/1/2018 1:09:46 PM ******/
CREATE NONCLUSTERED INDEX [ProductSupplierId] ON [dbo].[Products_Suppliers]
(
	[ProductSupplierId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [SuppliersProducts_Suppliers1]    Script Date: 8/1/2018 1:09:46 PM ******/
CREATE NONCLUSTERED INDEX [SuppliersProducts_Suppliers1] ON [dbo].[Products_Suppliers]
(
	[SupplierId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [AffiliationsSupCon]    Script Date: 8/1/2018 1:09:46 PM ******/
CREATE NONCLUSTERED INDEX [AffiliationsSupCon] ON [dbo].[SupplierContacts]
(
	[AffiliationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [SuppliersSupCon]    Script Date: 8/1/2018 1:09:46 PM ******/
CREATE NONCLUSTERED INDEX [SuppliersSupCon] ON [dbo].[SupplierContacts]
(
	[SupplierId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [SupplierId]    Script Date: 8/1/2018 1:09:46 PM ******/
CREATE NONCLUSTERED INDEX [SupplierId] ON [dbo].[Suppliers]
(
	[SupplierId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BookingDetails] ADD  CONSTRAINT [DF__BookingDe__Booki__7C8480AE]  DEFAULT ((0)) FOR [BookingId]
GO
ALTER TABLE [dbo].[BookingDetails] ADD  CONSTRAINT [DF__BookingDe__Produ__7D78A4E7]  DEFAULT ((0)) FOR [ProductSupplierId]
GO
ALTER TABLE [dbo].[Bookings] ADD  CONSTRAINT [DF__Bookings__Packag__023D5A04]  DEFAULT ((0)) FOR [PackageId]
GO
ALTER TABLE [dbo].[Customers_Rewards] ADD  CONSTRAINT [DF__Customers__Rewar__1273C1CD]  DEFAULT ((0)) FOR [RewardId]
GO
ALTER TABLE [dbo].[Fees] ADD  CONSTRAINT [DF__Fees__FeeAmt__1B0907CE]  DEFAULT ((0)) FOR [FeeAmt]
GO
ALTER TABLE [dbo].[Packages] ADD  CONSTRAINT [DF__Packages__PkgBas__76CBA758]  DEFAULT ((0)) FOR [PkgBasePrice]
GO
ALTER TABLE [dbo].[Packages] ADD  CONSTRAINT [DF__Packages__PkgAge__77BFCB91]  DEFAULT ((0)) FOR [PkgAgencyCommission]
GO
ALTER TABLE [dbo].[Packages_Products_Suppliers] ADD  CONSTRAINT [DF__Packages___Packa__239E4DCF]  DEFAULT ((0)) FOR [PackageId]
GO
ALTER TABLE [dbo].[Packages_Products_Suppliers] ADD  CONSTRAINT [DF__Packages___Produ__24927208]  DEFAULT ((0)) FOR [ProductSupplierId]
GO
ALTER TABLE [dbo].[Products_Suppliers] ADD  CONSTRAINT [DF__Products___Produ__2D27B809]  DEFAULT ((0)) FOR [ProductId]
GO
ALTER TABLE [dbo].[Rewards] ADD  CONSTRAINT [DF__Rewards__RewardI__35BCFE0A]  DEFAULT ((0)) FOR [RewardId]
GO
ALTER TABLE [dbo].[SupplierContacts] ADD  CONSTRAINT [DF__SupplierC__Suppl__3A81B327]  DEFAULT ((0)) FOR [SupplierId]
GO
ALTER TABLE [dbo].[Suppliers] ADD  CONSTRAINT [DF__Suppliers__Suppl__3F466844]  DEFAULT ((0)) FOR [SupplierId]
GO
ALTER TABLE [dbo].[Agents]  WITH CHECK ADD  CONSTRAINT [FK_Agents_Agencies] FOREIGN KEY([AgencyId])
REFERENCES [dbo].[Agencies] ([AgencyId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Agents] CHECK CONSTRAINT [FK_Agents_Agencies]
GO
ALTER TABLE [dbo].[BookingDetails]  WITH CHECK ADD  CONSTRAINT [FK_BookingDetails_Bookings] FOREIGN KEY([BookingId])
REFERENCES [dbo].[Bookings] ([BookingId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[BookingDetails] CHECK CONSTRAINT [FK_BookingDetails_Bookings]
GO
ALTER TABLE [dbo].[BookingDetails]  WITH CHECK ADD  CONSTRAINT [FK_BookingDetails_Classes] FOREIGN KEY([ClassId])
REFERENCES [dbo].[Classes] ([ClassId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[BookingDetails] CHECK CONSTRAINT [FK_BookingDetails_Classes]
GO
ALTER TABLE [dbo].[BookingDetails]  WITH CHECK ADD  CONSTRAINT [FK_BookingDetails_Fees] FOREIGN KEY([FeeId])
REFERENCES [dbo].[Fees] ([FeeId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[BookingDetails] CHECK CONSTRAINT [FK_BookingDetails_Fees]
GO
ALTER TABLE [dbo].[BookingDetails]  WITH CHECK ADD  CONSTRAINT [FK_BookingDetails_Products_Suppliers] FOREIGN KEY([ProductSupplierId])
REFERENCES [dbo].[Products_Suppliers] ([ProductSupplierId])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[BookingDetails] CHECK CONSTRAINT [FK_BookingDetails_Products_Suppliers]
GO
ALTER TABLE [dbo].[BookingDetails]  WITH CHECK ADD  CONSTRAINT [FK_BookingDetails_Regions] FOREIGN KEY([RegionId])
REFERENCES [dbo].[Regions] ([RegionId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[BookingDetails] CHECK CONSTRAINT [FK_BookingDetails_Regions]
GO
ALTER TABLE [dbo].[Bookings]  WITH CHECK ADD  CONSTRAINT [Bookings_FK00] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Bookings] CHECK CONSTRAINT [Bookings_FK00]
GO
ALTER TABLE [dbo].[Bookings]  WITH CHECK ADD  CONSTRAINT [Bookings_FK01] FOREIGN KEY([PackageId])
REFERENCES [dbo].[Packages] ([PackageId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Bookings] CHECK CONSTRAINT [Bookings_FK01]
GO
ALTER TABLE [dbo].[Bookings]  WITH CHECK ADD  CONSTRAINT [Bookings_FK02] FOREIGN KEY([TripTypeId])
REFERENCES [dbo].[TripTypes] ([TripTypeId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Bookings] CHECK CONSTRAINT [Bookings_FK02]
GO
ALTER TABLE [dbo].[CreditCards]  WITH CHECK ADD  CONSTRAINT [CreditCards_FK00] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CreditCards] CHECK CONSTRAINT [CreditCards_FK00]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customers_Agents] FOREIGN KEY([AgentId])
REFERENCES [dbo].[Agents] ([AgentId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_Agents]
GO
ALTER TABLE [dbo].[Customers_Rewards]  WITH CHECK ADD  CONSTRAINT [Customers_Rewards_FK00] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Customers_Rewards] CHECK CONSTRAINT [Customers_Rewards_FK00]
GO
ALTER TABLE [dbo].[Customers_Rewards]  WITH CHECK ADD  CONSTRAINT [Customers_Rewards_FK01] FOREIGN KEY([RewardId])
REFERENCES [dbo].[Rewards] ([RewardId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Customers_Rewards] CHECK CONSTRAINT [Customers_Rewards_FK01]
GO
ALTER TABLE [dbo].[Logins]  WITH CHECK ADD FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerId])
GO
ALTER TABLE [dbo].[Packages_Products_Suppliers]  WITH CHECK ADD  CONSTRAINT [Packages_Products_Supplie_FK00] FOREIGN KEY([PackageId])
REFERENCES [dbo].[Packages] ([PackageId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Packages_Products_Suppliers] CHECK CONSTRAINT [Packages_Products_Supplie_FK00]
GO
ALTER TABLE [dbo].[Packages_Products_Suppliers]  WITH CHECK ADD  CONSTRAINT [Packages_Products_Supplie_FK01] FOREIGN KEY([ProductSupplierId])
REFERENCES [dbo].[Products_Suppliers] ([ProductSupplierId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Packages_Products_Suppliers] CHECK CONSTRAINT [Packages_Products_Supplie_FK01]
GO
ALTER TABLE [dbo].[Products_Suppliers]  WITH CHECK ADD  CONSTRAINT [Products_Suppliers_FK00] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([ProductId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products_Suppliers] CHECK CONSTRAINT [Products_Suppliers_FK00]
GO
ALTER TABLE [dbo].[Products_Suppliers]  WITH CHECK ADD  CONSTRAINT [Products_Suppliers_FK01] FOREIGN KEY([SupplierId])
REFERENCES [dbo].[Suppliers] ([SupplierId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products_Suppliers] CHECK CONSTRAINT [Products_Suppliers_FK01]
GO
ALTER TABLE [dbo].[SupplierContacts]  WITH CHECK ADD  CONSTRAINT [SupplierContacts_FK00] FOREIGN KEY([AffiliationId])
REFERENCES [dbo].[Affiliations] ([AffilitationId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[SupplierContacts] CHECK CONSTRAINT [SupplierContacts_FK00]
GO
ALTER TABLE [dbo].[SupplierContacts]  WITH CHECK ADD  CONSTRAINT [SupplierContacts_FK01] FOREIGN KEY([SupplierId])
REFERENCES [dbo].[Suppliers] ([SupplierId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SupplierContacts] CHECK CONSTRAINT [SupplierContacts_FK01]
GO
USE [master]
GO
ALTER DATABASE [TravelExperts] SET  READ_WRITE 
GO
