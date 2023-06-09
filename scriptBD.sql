USE [master]
GO
/****** Object:  Database [registroDatos]    Script Date: 09/06/2023 01:44:58 p. m. ******/
CREATE DATABASE [registroDatos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'registroDatos', FILENAME = N'D:\programas\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\registroDatos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'registroDatos_log', FILENAME = N'D:\programas\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\registroDatos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [registroDatos] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [registroDatos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [registroDatos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [registroDatos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [registroDatos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [registroDatos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [registroDatos] SET ARITHABORT OFF 
GO
ALTER DATABASE [registroDatos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [registroDatos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [registroDatos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [registroDatos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [registroDatos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [registroDatos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [registroDatos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [registroDatos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [registroDatos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [registroDatos] SET  ENABLE_BROKER 
GO
ALTER DATABASE [registroDatos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [registroDatos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [registroDatos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [registroDatos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [registroDatos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [registroDatos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [registroDatos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [registroDatos] SET RECOVERY FULL 
GO
ALTER DATABASE [registroDatos] SET  MULTI_USER 
GO
ALTER DATABASE [registroDatos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [registroDatos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [registroDatos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [registroDatos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [registroDatos] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [registroDatos] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'registroDatos', N'ON'
GO
ALTER DATABASE [registroDatos] SET QUERY_STORE = ON
GO
ALTER DATABASE [registroDatos] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [registroDatos]
GO
/****** Object:  Table [dbo].[area]    Script Date: 09/06/2023 01:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[area](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[clave] [char](10) NOT NULL,
	[valor] [varchar](140) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bitacora]    Script Date: 09/06/2023 01:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bitacora](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[operacion] [varchar](50) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[descripcionEvento] [varchar](100) NOT NULL,
	[id_usuario] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[contrasena]    Script Date: 09/06/2023 01:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[contrasena](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[contrasena] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[entradasSalidas]    Script Date: 09/06/2023 01:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[entradasSalidas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_productoTecnologia] [int] NOT NULL,
	[tipoFlujo] [varchar](50) NOT NULL,
	[recursos] [varchar](50) NOT NULL,
	[emisiones] [varchar](100) NOT NULL,
	[valor] [float] NOT NULL,
	[unidad] [varchar](50) NOT NULL,
	[tratamientoDato] [varchar](150) NOT NULL,
	[adquisicionDato] [varchar](50) NULL,
	[citasReferencia] [varchar](100) NULL,
	[cometario] [varchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estado]    Script Date: 09/06/2023 01:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estado](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[clave] [varchar](10) NOT NULL,
	[valor] [varchar](140) NOT NULL,
	[id_area] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ingresoDatos]    Script Date: 09/06/2023 01:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ingresoDatos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[productoTecnologia] [varchar](100) NOT NULL,
	[NombreProceso] [varchar](200) NOT NULL,
	[tipoProceso] [varchar](50) NOT NULL,
	[autor] [varchar](50) NOT NULL,
	[correo] [varchar](50) NOT NULL,
	[nombreFlujoR] [varchar](200) NOT NULL,
	[valorR] [float] NOT NULL,
	[unidad] [varchar](50) NOT NULL,
	[objetivo] [varchar](100) NULL,
	[limitesSistema] [varchar](50) NOT NULL,
	[imagen] [varchar](50) NULL,
	[tipoTecnologia] [varchar](50) NOT NULL,
	[condicionesOperacion] [varchar](200) NOT NULL,
	[fechaReferencia] [date] NOT NULL,
	[datosValidos] [date] NOT NULL,
	[descripcion] [varchar](200) NULL,
	[id_estado] [int] NOT NULL,
	[reprentacionGeografica] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[perfil]    Script Date: 09/06/2023 01:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[perfil](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cargo] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 09/06/2023 01:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellidoP] [varchar](50) NOT NULL,
	[apellidoM] [varchar](50) NULL,
	[id_perfil] [int] NOT NULL,
	[correo] [varchar](50) NOT NULL,
	[telefono] [varchar](50) NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[id_contrasena] [int] NOT NULL,
	[sesion] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[contrasena] ON 

INSERT [dbo].[contrasena] ([id], [contrasena]) VALUES (1, N'8C6976E5B5410415BDE908BD4DEE15DFB167A9C873FC4BB8A81F6F2AB448A918')
INSERT [dbo].[contrasena] ([id], [contrasena]) VALUES (2, N'9250E222C4C71F0C58D4C54B50A880A312E9F9FED55D5C3AA0B0E860DED99165')
SET IDENTITY_INSERT [dbo].[contrasena] OFF
GO
SET IDENTITY_INSERT [dbo].[perfil] ON 

INSERT [dbo].[perfil] ([id], [cargo]) VALUES (1, N'Administrador')
INSERT [dbo].[perfil] ([id], [cargo]) VALUES (2, N'Usuario')
SET IDENTITY_INSERT [dbo].[perfil] OFF
GO
SET IDENTITY_INSERT [dbo].[usuario] ON 

INSERT [dbo].[usuario] ([id], [nombre], [apellidoP], [apellidoM], [id_perfil], [correo], [telefono], [usuario], [id_contrasena], [sesion]) VALUES (1, N'Omar', N'Suárez', N'Casas', 1, N'omar_2.3@gmail.com', N'2281144037', N'admin', 1, 1)
INSERT [dbo].[usuario] ([id], [nombre], [apellidoP], [apellidoM], [id_perfil], [correo], [telefono], [usuario], [id_contrasena], [sesion]) VALUES (2, N'prueba', N'prueba', N'prueba', 2, N'prueba@prueba.com', N'4545421551', N'usuario', 2, 1)
SET IDENTITY_INSERT [dbo].[usuario] OFF
GO
ALTER TABLE [dbo].[bitacora]  WITH CHECK ADD  CONSTRAINT [fk_usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[usuario] ([id])
GO
ALTER TABLE [dbo].[bitacora] CHECK CONSTRAINT [fk_usuario]
GO
ALTER TABLE [dbo].[entradasSalidas]  WITH CHECK ADD  CONSTRAINT [fk_ingresoDatos] FOREIGN KEY([id_productoTecnologia])
REFERENCES [dbo].[ingresoDatos] ([id])
GO
ALTER TABLE [dbo].[entradasSalidas] CHECK CONSTRAINT [fk_ingresoDatos]
GO
ALTER TABLE [dbo].[estado]  WITH CHECK ADD  CONSTRAINT [fk_area] FOREIGN KEY([id_area])
REFERENCES [dbo].[area] ([id])
GO
ALTER TABLE [dbo].[estado] CHECK CONSTRAINT [fk_area]
GO
ALTER TABLE [dbo].[ingresoDatos]  WITH CHECK ADD  CONSTRAINT [fk_estado] FOREIGN KEY([id_estado])
REFERENCES [dbo].[estado] ([id])
GO
ALTER TABLE [dbo].[ingresoDatos] CHECK CONSTRAINT [fk_estado]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [fk_contrasena] FOREIGN KEY([id_contrasena])
REFERENCES [dbo].[contrasena] ([id])
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [fk_contrasena]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [fk_perfil] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[perfil] ([id])
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [fk_perfil]
GO
/****** Object:  StoredProcedure [dbo].[login]    Script Date: 09/06/2023 01:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[login]
(@Usuario varchar(50),
@Contrasena varchar(200))
as
begin
--declare @us
select	
        a.nombre,
		b.cargo,
		a.id
		from usuario as a
		inner join perfil as b on (a.id_perfil = b.id) inner join contrasena as c on (a.id_contrasena = c.id) where a.usuario = @Usuario and c.contrasena = @Contrasena
update sus set sesion = 1 	
		from usuario as sus
		inner join perfil as b on (sus.id_perfil = b.id) inner join contrasena as c on (sus.id_contrasena = c.id) where sus.usuario = @Usuario and c.contrasena = @Contrasena
		end
GO
USE [master]
GO
ALTER DATABASE [registroDatos] SET  READ_WRITE 
GO
