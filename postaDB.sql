USE [master]
GO
/****** Object:  Database [PostaOfis]    Script Date: 1/18/2022 2:55:54 PM ******/
CREATE DATABASE [PostaOfis]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PostaOfis', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\PostaOfis.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PostaOfis_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\PostaOfis_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PostaOfis] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PostaOfis].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PostaOfis] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PostaOfis] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PostaOfis] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PostaOfis] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PostaOfis] SET ARITHABORT OFF 
GO
ALTER DATABASE [PostaOfis] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PostaOfis] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PostaOfis] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PostaOfis] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PostaOfis] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PostaOfis] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PostaOfis] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PostaOfis] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PostaOfis] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PostaOfis] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PostaOfis] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PostaOfis] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PostaOfis] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PostaOfis] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PostaOfis] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PostaOfis] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PostaOfis] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PostaOfis] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PostaOfis] SET  MULTI_USER 
GO
ALTER DATABASE [PostaOfis] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PostaOfis] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PostaOfis] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PostaOfis] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PostaOfis] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PostaOfis] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PostaOfis] SET QUERY_STORE = OFF
GO
USE [PostaOfis]
GO
/****** Object:  Table [dbo].[Fatura]    Script Date: 1/18/2022 2:55:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fatura](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Tarih] [datetime] NOT NULL,
	[Tür] [nchar](10) NOT NULL,
	[Takipno] [nchar](10) NOT NULL,
	[Fiyat] [int] NOT NULL,
	[Açıklama] [nchar](50) NOT NULL,
	[Hız] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Fatura] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Ortalama Fiyat Üstü Posta]    Script Date: 1/18/2022 2:55:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Ortalama Fiyat Üstü Posta] AS
SELECT ID,Tarih,Fiyat
FROM Fatura
WHERE Fiyat > (SELECT AVG(Fiyat) FROM Fatura);
GO
/****** Object:  Table [dbo].[Alici]    Script Date: 1/18/2022 2:55:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alici](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AdSoyad] [nchar](50) NOT NULL,
	[TC] [nchar](11) NOT NULL,
	[Tel] [nchar](10) NOT NULL,
	[Eposta] [nchar](50) NOT NULL,
	[Adres] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Alici] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gönderici]    Script Date: 1/18/2022 2:55:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gönderici](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AdSoyad] [nvarchar](50) NOT NULL,
	[TC] [nchar](11) NOT NULL,
	[Tel] [nchar](10) NOT NULL,
	[Eposta] [nvarchar](50) NULL,
	[Adres] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Gönderici] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Müdür]    Script Date: 1/18/2022 2:55:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Müdür](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AdSoyad] [nchar](50) NOT NULL,
	[TC] [nchar](11) NOT NULL,
	[Tel] [nchar](10) NOT NULL,
	[Eposta] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Müdür] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 1/18/2022 2:55:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AdSoyad] [nchar](50) NOT NULL,
	[TC] [nchar](11) NOT NULL,
	[Tel] [nchar](10) NOT NULL,
	[Eposta] [nchar](50) NULL,
	[ŞubeID] [int] NOT NULL,
 CONSTRAINT [PK_Personel] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Posta]    Script Date: 1/18/2022 2:55:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Posta](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[GöndericiID] [int] NOT NULL,
	[AlıcıID] [int] NOT NULL,
	[FaturaID] [int] NOT NULL,
	[PersonelID] [int] NOT NULL,
	[ŞubeID] [int] NOT NULL,
	[TeslimatID] [int] NOT NULL,
 CONSTRAINT [PK_Posta] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Şube]    Script Date: 1/18/2022 2:55:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Şube](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[İl] [nchar](20) NOT NULL,
	[İlçe] [nchar](20) NOT NULL,
	[ŞubeTel] [nchar](10) NOT NULL,
	[MüdürID] [int] NOT NULL,
 CONSTRAINT [PK_Şube] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teslimat]    Script Date: 1/18/2022 2:55:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teslimat](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AdSoyad] [nvarchar](50) NOT NULL,
	[TC] [nchar](11) NOT NULL,
	[Tel] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Teslimat] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Alici] ON 

INSERT [dbo].[Alici] ([ID], [AdSoyad], [TC], [Tel], [Eposta], [Adres]) VALUES (1, N'Elif Ozturk                                       ', N'88816473654', N'5380003044', N'elif@gmail.com                                    ', N'kalem sokak Yalova                                ')
INSERT [dbo].[Alici] ([ID], [AdSoyad], [TC], [Tel], [Eposta], [Adres]) VALUES (4, N'Sena Yalcin                                       ', N'12316473654', N'5453543044', N'yalcin@gmail.com                                  ', N'visne sokak Diyarbakir                            ')
INSERT [dbo].[Alici] ([ID], [AdSoyad], [TC], [Tel], [Eposta], [Adres]) VALUES (5, N'Eylul Akac                                        ', N'34516473654', N'5450771044', N'akac@gmail.com                                    ', N'tursu sokak Amasya                                ')
INSERT [dbo].[Alici] ([ID], [AdSoyad], [TC], [Tel], [Eposta], [Adres]) VALUES (6, N'Sule Denyali                                      ', N'23316473654', N'5451155044', N'sule@gmail.com                                    ', N'siyah sokak Yalova                                ')
SET IDENTITY_INSERT [dbo].[Alici] OFF
GO
SET IDENTITY_INSERT [dbo].[Fatura] ON 

INSERT [dbo].[Fatura] ([ID], [Tarih], [Tür], [Takipno], [Fiyat], [Açıklama], [Hız]) VALUES (1, CAST(N'2022-01-01T00:00:00.000' AS DateTime), N'Belge     ', N'1ks1      ', 15, N'dgko bebegim                                      ', N'normal    ')
INSERT [dbo].[Fatura] ([ID], [Tarih], [Tür], [Takipno], [Fiyat], [Açıklama], [Hız]) VALUES (4, CAST(N'2021-12-12T00:00:00.000' AS DateTime), N'Belge     ', N'2ks2      ', 15, N'dgko bebegim                                      ', N'normal    ')
INSERT [dbo].[Fatura] ([ID], [Tarih], [Tür], [Takipno], [Fiyat], [Açıklama], [Hız]) VALUES (5, CAST(N'2021-11-11T00:00:00.000' AS DateTime), N'5-10 kg   ', N'1bs4      ', 120, N'dgko bebegim                                      ', N'hizli     ')
INSERT [dbo].[Fatura] ([ID], [Tarih], [Tür], [Takipno], [Fiyat], [Açıklama], [Hız]) VALUES (6, CAST(N'2022-01-01T00:00:00.000' AS DateTime), N'10-20 kg  ', N'1ee1      ', 240, N'dgko bebegim                                      ', N'hizli     ')
SET IDENTITY_INSERT [dbo].[Fatura] OFF
GO
SET IDENTITY_INSERT [dbo].[Gönderici] ON 

INSERT [dbo].[Gönderici] ([ID], [AdSoyad], [TC], [Tel], [Eposta], [Adres]) VALUES (1, N'e Büsra Salihoglu', N'55516473654', N'5854500044', N'busra@gmail.com', N'yasardogu sokak Samsun')
INSERT [dbo].[Gönderici] ([ID], [AdSoyad], [TC], [Tel], [Eposta], [Adres]) VALUES (4, N'Sevval Yildiz', N'33316473654', N'5384500044', N'sevval@gmail.com', N'kebap sokak Istanbul')
INSERT [dbo].[Gönderici] ([ID], [AdSoyad], [TC], [Tel], [Eposta], [Adres]) VALUES (5, N'Cemil Bayhan', N'44416473654', N'5494500044', N'cemil@gmail.com', N'kis sokak Kutahya')
INSERT [dbo].[Gönderici] ([ID], [AdSoyad], [TC], [Tel], [Eposta], [Adres]) VALUES (6, N'Mehmet Ozturk', N'66616473654', N'5453333044', N'mehmet@gmail.com', N'ataturk sokak Istanbul')
SET IDENTITY_INSERT [dbo].[Gönderici] OFF
GO
SET IDENTITY_INSERT [dbo].[Müdür] ON 

INSERT [dbo].[Müdür] ([ID], [AdSoyad], [TC], [Tel], [Eposta]) VALUES (1, N'Salih Salihoglu                                   ', N'55516723400', N'5457645302', N'salih@gmail.com                                   ')
INSERT [dbo].[Müdür] ([ID], [AdSoyad], [TC], [Tel], [Eposta]) VALUES (2, N'Mustafa Kaçmaz                                    ', N'99916723400', N'5777645302', N'mustafa@gmail.com                                 ')
SET IDENTITY_INSERT [dbo].[Müdür] OFF
GO
SET IDENTITY_INSERT [dbo].[Personel] ON 

INSERT [dbo].[Personel] ([ID], [AdSoyad], [TC], [Tel], [Eposta], [ŞubeID]) VALUES (1, N'Sena Baran                                        ', N'22253298767', N'517773321 ', N'sena@gmail.com                                    ', 1)
INSERT [dbo].[Personel] ([ID], [AdSoyad], [TC], [Tel], [Eposta], [ŞubeID]) VALUES (2, N'Merve Özdemir                                     ', N'11153298767', N'539773321 ', N'merve@gmail.com                                   ', 1)
INSERT [dbo].[Personel] ([ID], [AdSoyad], [TC], [Tel], [Eposta], [ŞubeID]) VALUES (3, N'Aysenur Öztürk                                    ', N'33353298767', N'539773321 ', N'aysenur@gmail.com                                 ', 2)
INSERT [dbo].[Personel] ([ID], [AdSoyad], [TC], [Tel], [Eposta], [ŞubeID]) VALUES (4, N'Umut Demir                                        ', N'44453298767', N'549773321 ', N'demir@gmail.com                                   ', 2)
INSERT [dbo].[Personel] ([ID], [AdSoyad], [TC], [Tel], [Eposta], [ŞubeID]) VALUES (5, N'Ali Denyali                                       ', N'10116473654', N'5391155044', N'ali@gmail.com                                     ', 3)
SET IDENTITY_INSERT [dbo].[Personel] OFF
GO
SET IDENTITY_INSERT [dbo].[Posta] ON 

INSERT [dbo].[Posta] ([ID], [GöndericiID], [AlıcıID], [FaturaID], [PersonelID], [ŞubeID], [TeslimatID]) VALUES (1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[Posta] ([ID], [GöndericiID], [AlıcıID], [FaturaID], [PersonelID], [ŞubeID], [TeslimatID]) VALUES (4, 4, 4, 4, 3, 2, 2)
INSERT [dbo].[Posta] ([ID], [GöndericiID], [AlıcıID], [FaturaID], [PersonelID], [ŞubeID], [TeslimatID]) VALUES (5, 5, 5, 5, 5, 3, 3)
INSERT [dbo].[Posta] ([ID], [GöndericiID], [AlıcıID], [FaturaID], [PersonelID], [ŞubeID], [TeslimatID]) VALUES (6, 6, 6, 6, 4, 2, 2)
SET IDENTITY_INSERT [dbo].[Posta] OFF
GO
SET IDENTITY_INSERT [dbo].[Şube] ON 

INSERT [dbo].[Şube] ([ID], [İl], [İlçe], [ŞubeTel], [MüdürID]) VALUES (1, N'Samsun              ', N'Kavak               ', N'2168882336', 1)
INSERT [dbo].[Şube] ([ID], [İl], [İlçe], [ŞubeTel], [MüdürID]) VALUES (2, N'Istanbul            ', N'Tuzla               ', N'2161112336', 2)
INSERT [dbo].[Şube] ([ID], [İl], [İlçe], [ŞubeTel], [MüdürID]) VALUES (3, N'Kutahya             ', N'Ladik               ', N'2156660990', 3)
INSERT [dbo].[Şube] ([ID], [İl], [İlçe], [ŞubeTel], [MüdürID]) VALUES (5, N'Kutahya             ', N'Ladik               ', N'2156660990', 3)
INSERT [dbo].[Şube] ([ID], [İl], [İlçe], [ŞubeTel], [MüdürID]) VALUES (6, N'Kutahya             ', N'Ladik               ', N'2156660990', 3)
SET IDENTITY_INSERT [dbo].[Şube] OFF
GO
SET IDENTITY_INSERT [dbo].[Teslimat] ON 

INSERT [dbo].[Teslimat] ([ID], [AdSoyad], [TC], [Tel]) VALUES (1, N'Ahmet Karsli', N'12343298767', N'5454323321')
INSERT [dbo].[Teslimat] ([ID], [AdSoyad], [TC], [Tel]) VALUES (2, N'Mehmet Yilmaz', N'55553298767', N'5381113321')
INSERT [dbo].[Teslimat] ([ID], [AdSoyad], [TC], [Tel]) VALUES (3, N'Berke Osmanoglu', N'99253298767', N'5497773321')
SET IDENTITY_INSERT [dbo].[Teslimat] OFF
GO
/****** Object:  StoredProcedure [dbo].[AliciIletisim]    Script Date: 1/18/2022 2:55:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AliciIletisim] @ID int
AS
SELECT AdSoyad,Tel,Eposta FROM Alici WHERE ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[FaturayıGoruntule]    Script Date: 1/18/2022 2:55:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FaturayıGoruntule] @ID int,  @ID2 int
AS
SELECT * FROM Posta WHERE GöndericiID = @ID AND AlıcıID = @ID2
GO
/****** Object:  StoredProcedure [dbo].[GöndericiAdSoyad]    Script Date: 1/18/2022 2:55:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GöndericiAdSoyad] @ID int
AS
SELECT * FROM Gönderici WHERE ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[GöndericiCagri]    Script Date: 1/18/2022 2:55:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GöndericiCagri] @ID int
AS
SELECT AdSoyad,Tel FROM Gönderici WHERE ID = @ID
GO
/****** Object:  StoredProcedure [dbo].[GöndericiIletisim]    Script Date: 1/18/2022 2:55:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GöndericiIletisim] @ID int
AS
SELECT AdSoyad,Tel,Eposta FROM Gönderici WHERE ID = @ID
GO
USE [master]
GO
ALTER DATABASE [PostaOfis] SET  READ_WRITE 
GO
