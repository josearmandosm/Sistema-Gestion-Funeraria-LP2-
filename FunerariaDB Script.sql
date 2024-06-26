USE [master]
GO
/****** Object:  Database [Funeraria]    Script Date: 6/27/2024 11:03:57 AM ******/
CREATE DATABASE [Funeraria]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Funeraria', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Funeraria.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Funeraria_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Funeraria_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Funeraria] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Funeraria].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Funeraria] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Funeraria] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Funeraria] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Funeraria] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Funeraria] SET ARITHABORT OFF 
GO
ALTER DATABASE [Funeraria] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Funeraria] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Funeraria] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Funeraria] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Funeraria] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Funeraria] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Funeraria] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Funeraria] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Funeraria] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Funeraria] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Funeraria] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Funeraria] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Funeraria] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Funeraria] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Funeraria] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Funeraria] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Funeraria] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Funeraria] SET RECOVERY FULL 
GO
ALTER DATABASE [Funeraria] SET  MULTI_USER 
GO
ALTER DATABASE [Funeraria] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Funeraria] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Funeraria] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Funeraria] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Funeraria] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Funeraria] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Funeraria', N'ON'
GO
ALTER DATABASE [Funeraria] SET QUERY_STORE = OFF
GO
USE [Funeraria]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 6/27/2024 11:03:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 6/27/2024 11:03:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 6/27/2024 11:03:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 6/27/2024 11:03:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 6/27/2024 11:03:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 6/27/2024 11:03:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 6/27/2024 11:03:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 6/27/2024 11:03:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Atributos]    Script Date: 6/27/2024 11:03:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Atributos](
	[ID_Atributo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Descripcion] [nvarchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Atributo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Atributos_Categorias]    Script Date: 6/27/2024 11:03:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Atributos_Categorias](
	[ID_Atributo] [int] NOT NULL,
	[ID_Categoria] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Atributo] ASC,
	[ID_Categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cargos]    Script Date: 6/27/2024 11:03:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cargos](
	[ID_Cargo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Descripcion] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK__Cargo__8D69B95FB68199D1] PRIMARY KEY CLUSTERED 
(
	[ID_Cargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 6/27/2024 11:03:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[ID_Categoria] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Descripcion] [nvarchar](200) NULL,
	[Total_Cobertura] [decimal](12, 2) NOT NULL,
 CONSTRAINT [PK__Categori__02AA0785B34B9C91] PRIMARY KEY CLUSTERED 
(
	[ID_Categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Difuntos]    Script Date: 6/27/2024 11:03:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Difuntos](
	[ID_Difunto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Difunto] [nvarchar](100) NOT NULL,
	[ID_TipoIdentificacion] [int] NOT NULL,
	[Identificacion] [nvarchar](11) NOT NULL,
	[Representante] [nvarchar](100) NOT NULL,
	[Representante_Telefono] [nvarchar](9) NULL,
	[Fecha_Fallecimiento] [date] NOT NULL,
	[Horario_Entrada] [time](7) NOT NULL,
	[Horario_Salida] [time](7) NOT NULL,
	[Certificacion_Defuncion] [image] NOT NULL,
	[ID_Sala] [int] NOT NULL,
 CONSTRAINT [PK__Defuncio__E05EBEA85A1B991F] PRIMARY KEY CLUSTERED 
(
	[ID_Difunto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 6/27/2024 11:03:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[ID_Empleado] [int] IDENTITY(1,1) NOT NULL,
	[NumDocumento] [nvarchar](11) NOT NULL,
	[ID_TipoIdentificacion] [int] NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Direccion] [nvarchar](200) NULL,
	[Telefono] [nvarchar](10) NOT NULL,
	[ID_Cargo] [int] NOT NULL,
	[ID_Jornada_Laboral] [int] NOT NULL,
	[ID_Localidad] [int] NOT NULL,
 CONSTRAINT [PK__Empleado__B7872C90AFF4E8ED] PRIMARY KEY CLUSTERED 
(
	[ID_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facturas_Servicios]    Script Date: 6/27/2024 11:03:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturas_Servicios](
	[ID_Servicio] [int] NOT NULL,
	[ID_Difunto] [int] NOT NULL,
	[Costo] [decimal](12, 2) NOT NULL,
 CONSTRAINT [PK__Facturac__87371E6E5CF4A5BB] PRIMARY KEY CLUSTERED 
(
	[ID_Servicio] ASC,
	[ID_Difunto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Jornada_Laborales]    Script Date: 6/27/2024 11:03:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jornada_Laborales](
	[ID_Jornada_Laboral] [int] IDENTITY(1,1) NOT NULL,
	[Fecha_Entrada] [date] NOT NULL,
	[Fecha_Salida] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Jornada_Laboral] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Libro_Firmas]    Script Date: 6/27/2024 11:03:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Libro_Firmas](
	[ID_Libro_Firma] [int] IDENTITY(1,1) NOT NULL,
	[ID_Difunto] [int] NOT NULL,
	[Nombre_Firma] [nvarchar](100) NOT NULL,
	[Mensaje] [nvarchar](500) NULL,
 CONSTRAINT [PK__Libro_Fi__4A04D334864E53AC] PRIMARY KEY CLUSTERED 
(
	[ID_Libro_Firma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Localidad]    Script Date: 6/27/2024 11:03:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Localidad](
	[ID_Localidad] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Direccion] [nvarchar](200) NOT NULL,
	[Telefono] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK__Localida__8ACE3DA1F196609E] PRIMARY KEY CLUSTERED 
(
	[ID_Localidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salas]    Script Date: 6/27/2024 11:03:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salas](
	[ID_Sala] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Capacidad] [int] NOT NULL,
	[Estatus] [char](1) NOT NULL,
	[ID_Categoria] [int] NOT NULL,
	[ID_Localidad] [int] NOT NULL,
 CONSTRAINT [PK__Salas__2071DEA7B374F345] PRIMARY KEY CLUSTERED 
(
	[ID_Sala] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servicios]    Script Date: 6/27/2024 11:03:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicios](
	[ID_Servicio] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Descripcion] [nvarchar](200) NOT NULL,
	[Costo] [decimal](12, 2) NOT NULL,
 CONSTRAINT [PK__Servicio__1932F584415698B8] PRIMARY KEY CLUSTERED 
(
	[ID_Servicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servicios_Categorias]    Script Date: 6/27/2024 11:03:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicios_Categorias](
	[ID_Servicio] [int] NOT NULL,
	[ID_Categoria] [int] NOT NULL,
	[Costo] [decimal](12, 2) NOT NULL,
 CONSTRAINT [PK__Servicio__591855FC0A40FA83] PRIMARY KEY CLUSTERED 
(
	[ID_Servicio] ASC,
	[ID_Categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Identificaciones]    Script Date: 6/27/2024 11:03:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Identificaciones](
	[ID_TipoIdentificacion] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_TipoIdentificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 6/27/2024 11:03:58 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 6/27/2024 11:03:58 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 6/27/2024 11:03:58 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 6/27/2024 11:03:58 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 6/27/2024 11:03:58 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 6/27/2024 11:03:58 AM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 6/27/2024 11:03:58 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Atributos_Categorias]  WITH CHECK ADD FOREIGN KEY([ID_Atributo])
REFERENCES [dbo].[Atributos] ([ID_Atributo])
GO
ALTER TABLE [dbo].[Atributos_Categorias]  WITH CHECK ADD  CONSTRAINT [FK__Atributo___ID_Ca__2F10007B] FOREIGN KEY([ID_Categoria])
REFERENCES [dbo].[Categorias] ([ID_Categoria])
GO
ALTER TABLE [dbo].[Atributos_Categorias] CHECK CONSTRAINT [FK__Atributo___ID_Ca__2F10007B]
GO
ALTER TABLE [dbo].[Difuntos]  WITH CHECK ADD  CONSTRAINT [FK_Difuntos_Salas] FOREIGN KEY([ID_Sala])
REFERENCES [dbo].[Salas] ([ID_Sala])
GO
ALTER TABLE [dbo].[Difuntos] CHECK CONSTRAINT [FK_Difuntos_Salas]
GO
ALTER TABLE [dbo].[Difuntos]  WITH CHECK ADD  CONSTRAINT [FK_Difuntos_Tipo_Identificaciones] FOREIGN KEY([ID_Difunto])
REFERENCES [dbo].[Tipo_Identificaciones] ([ID_TipoIdentificacion])
GO
ALTER TABLE [dbo].[Difuntos] CHECK CONSTRAINT [FK_Difuntos_Tipo_Identificaciones]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Cargos] FOREIGN KEY([ID_Cargo])
REFERENCES [dbo].[Cargos] ([ID_Cargo])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Cargos]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Jornada_Laborales] FOREIGN KEY([ID_Jornada_Laboral])
REFERENCES [dbo].[Jornada_Laborales] ([ID_Jornada_Laboral])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Jornada_Laborales]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Localidad] FOREIGN KEY([ID_Localidad])
REFERENCES [dbo].[Localidad] ([ID_Localidad])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Localidad]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Tipo_Identificaciones] FOREIGN KEY([ID_TipoIdentificacion])
REFERENCES [dbo].[Tipo_Identificaciones] ([ID_TipoIdentificacion])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Tipo_Identificaciones]
GO
ALTER TABLE [dbo].[Facturas_Servicios]  WITH CHECK ADD  CONSTRAINT [FK__Facturaci__ID_Se__4D94879B] FOREIGN KEY([ID_Servicio])
REFERENCES [dbo].[Servicios] ([ID_Servicio])
GO
ALTER TABLE [dbo].[Facturas_Servicios] CHECK CONSTRAINT [FK__Facturaci__ID_Se__4D94879B]
GO
ALTER TABLE [dbo].[Libro_Firmas]  WITH CHECK ADD  CONSTRAINT [FK_Libro_Firmas_Difuntos] FOREIGN KEY([ID_Difunto])
REFERENCES [dbo].[Difuntos] ([ID_Difunto])
GO
ALTER TABLE [dbo].[Libro_Firmas] CHECK CONSTRAINT [FK_Libro_Firmas_Difuntos]
GO
ALTER TABLE [dbo].[Salas]  WITH CHECK ADD  CONSTRAINT [FK__Salas__ID_Catego__29572725] FOREIGN KEY([ID_Categoria])
REFERENCES [dbo].[Categorias] ([ID_Categoria])
GO
ALTER TABLE [dbo].[Salas] CHECK CONSTRAINT [FK__Salas__ID_Catego__29572725]
GO
ALTER TABLE [dbo].[Salas]  WITH CHECK ADD  CONSTRAINT [FK__Salas__ID_Locali__286302EC] FOREIGN KEY([ID_Localidad])
REFERENCES [dbo].[Localidad] ([ID_Localidad])
GO
ALTER TABLE [dbo].[Salas] CHECK CONSTRAINT [FK__Salas__ID_Locali__286302EC]
GO
ALTER TABLE [dbo].[Servicios_Categorias]  WITH CHECK ADD  CONSTRAINT [FK__Servicios__ID_Ca__34C8D9D1] FOREIGN KEY([ID_Categoria])
REFERENCES [dbo].[Categorias] ([ID_Categoria])
GO
ALTER TABLE [dbo].[Servicios_Categorias] CHECK CONSTRAINT [FK__Servicios__ID_Ca__34C8D9D1]
GO
ALTER TABLE [dbo].[Servicios_Categorias]  WITH CHECK ADD  CONSTRAINT [FK__Servicios__ID_Se__33D4B598] FOREIGN KEY([ID_Servicio])
REFERENCES [dbo].[Servicios] ([ID_Servicio])
GO
ALTER TABLE [dbo].[Servicios_Categorias] CHECK CONSTRAINT [FK__Servicios__ID_Se__33D4B598]
GO
USE [master]
GO
ALTER DATABASE [Funeraria] SET  READ_WRITE 
GO
