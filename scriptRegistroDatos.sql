USE [master]
GO
/****** Object:  Database [registroDatos]    Script Date: 06/08/2023 04:42:56 p. m. ******/
CREATE DATABASE [registroDatos]
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
/****** Object:  Table [dbo].[area]    Script Date: 06/08/2023 04:42:57 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[area](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[clave] [char](10) NOT NULL,
	[valor] [varchar](140) NOT NULL,
	[id_estado] [int] NOT NULL,
 CONSTRAINT [PK_area] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bitacora]    Script Date: 06/08/2023 04:42:57 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bitacora](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[operacion] [varchar](50) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[descripcionEvento] [varchar](100) NOT NULL,
	[usuario] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[contrasena]    Script Date: 06/08/2023 04:42:57 p. m. ******/
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
/****** Object:  Table [dbo].[entradasSalidas]    Script Date: 06/08/2023 04:42:57 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[entradasSalidas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_producto] [int] NOT NULL,
	[nombreFlujo] [varchar](200) NOT NULL,
	[tipoFlujo] [varchar](50) NOT NULL,
	[recursos] [varchar](200) NOT NULL,
	[emisiones] [varchar](200) NULL,
	[valor] [varchar](100) NOT NULL,
	[unidad] [varchar](50) NOT NULL,
	[tratamientoDato] [varchar](150) NOT NULL,
	[adquisicionDato] [varchar](50) NOT NULL,
	[citasReferencia] [varchar](100) NULL,
	[cometario] [varchar](150) NULL,
 CONSTRAINT [PK_entradasSalidas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estado]    Script Date: 06/08/2023 04:42:57 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estado](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[clave] [varchar](10) NOT NULL,
	[valor] [varchar](140) NOT NULL,
 CONSTRAINT [PK_estado] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ingresoDatos]    Script Date: 06/08/2023 04:42:57 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ingresoDatos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[producto] [varchar](100) NOT NULL,
	[tecnologia] [varchar](100) NOT NULL,
	[otro] [varchar](100) NOT NULL,
	[NombreProceso] [varchar](200) NOT NULL,
	[tipoProceso] [varchar](50) NULL,
	[autor] [varchar](50) NOT NULL,
	[correo] [varchar](50) NOT NULL,
	[nombreFlujoR] [varchar](300) NOT NULL,
	[unidad] [varchar](50) NOT NULL,
	[valorR] [varchar](100) NOT NULL,
	[objetivo] [varchar](500) NULL,
	[limitesSistema] [varchar](50) NULL,
	[imagen] [image] NULL,
	[imagenDos] [image] NULL,
	[urlRepositorio] [varchar](300) NULL,
	[tipoTecnologia] [varchar](100) NOT NULL,
	[condicionesOperacion] [varchar](500) NULL,
	[fechaReferencia] [date] NOT NULL,
	[datosValidos] [date] NOT NULL,
	[descripcion] [varchar](300) NULL,
	[id_estado] [int] NOT NULL,
	[id_area] [int] NOT NULL,
	[latitud] [varchar](100) NOT NULL,
	[longitud] [varchar](100) NOT NULL,
	[observaciones] [varchar](500) NULL,
 CONSTRAINT [PK_ingresoDatos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[perfil]    Script Date: 06/08/2023 04:42:57 p. m. ******/
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
/****** Object:  Table [dbo].[usuario]    Script Date: 06/08/2023 04:42:57 p. m. ******/
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
	[estatus] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[area] ON 

INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (1, N'AGU       ', N'Aguascalientes', 1)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (2, N'TIJ       ', N'Tijuana', 2)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (3, N'MEL       ', N'Mexicali', 2)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (4, N'EST       ', N'Ensenada', 2)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (5, N'ROS       ', N'Rosarito', 2)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (6, N'TEC       ', N'Tecate', 2)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (7, N'LPZ       ', N'La Paz', 3)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (8, N'LCS       ', N'Los Cabos', 3)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (9, N'LOR       ', N'Loreto', 3)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (10, N'COM       ', N'Comondú', 3)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (11, N'MUL       ', N'Mulegé', 3)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (12, N'CAM       ', N'Campeche', 4)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (13, N'CDC       ', N'Ciudad del Carmen', 4)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (14, N'CPT       ', N'Champotón', 4)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (15, N'HPN       ', N'Hopelchén', 4)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (16, N'ECE       ', N'Escárcega', 4)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (17, N'TXG       ', N'Tuxtla Gutiérrez', 5)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (18, N'TPL       ', N'Tapachula', 5)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (19, N'SCC       ', N'San Cristóbal de las Casas', 5)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (20, N'CTN       ', N'Comitán', 5)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (21, N'PQE       ', N'Palenque', 5)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (22, N'CHA       ', N'Chihuahua', 6)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (23, N'CJZ       ', N'Ciudad Juárez', 6)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (24, N'COC       ', N'Cuauhtémoc', 6)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (25, N'DAS       ', N'Delicias', 6)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (26, N'PRL       ', N'Parral', 6)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (27, N'SLO       ', N'Saltillo', 7)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (28, N'TRN       ', N'Torreón', 7)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (29, N'MCA       ', N'Monclova', 7)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (30, N'PNR       ', N'Piedras Negras', 7)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (31, N'CA        ', N'Ciudad Acuña', 7)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (32, N'COL       ', N'Colima', 8)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (33, N'MNZ       ', N'Manzanillo', 8)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (34, N'TEC       ', N'Tecomán', 8)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (35, N'VAZ       ', N'Villa de Álvarez', 8)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (36, N'ARA       ', N'Armería', 8)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (37, N'ADC       ', N'Alcaldía de Cuauhtémoc', 9)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (38, N'ADI       ', N'Alcaldía de Iztapalapa', 9)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (39, N'AMH       ', N'Alcaldía de Miguel Hidalgo', 9)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (40, N'ABJ       ', N'Alcaldía de Benito Juárez', 9)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (41, N'ADC       ', N'Alcaldía de Coyoacán', 9)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (42, N'DRO       ', N'Durango', 10)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (43, N'GPO       ', N'Gómez Palacio', 10)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (44, N'CLO       ', N'Ciudad Lerdo', 10)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (45, N'SPR       ', N'Santiago Papasquiaro', 10)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (46, N'CTN       ', N'Canatlán', 10)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (47, N'ZCM       ', N'Zona centro de México', 11)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (48, N'TLU       ', N'Toluca', 11)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (49, N'ETC       ', N'Ecatepec', 11)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (50, N'NAN       ', N'Naucalpan', 11)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (51, N'NEZ       ', N'Nezahualcóyotl', 11)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (52, N'TLA       ', N'Tlalnepantla', 11)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (53, N'LON       ', N'León', 12)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (54, N'GTO       ', N'Guanajuato', 12)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (55, N'IRO       ', N'Irapuato', 12)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (56, N'SLC       ', N'Salamanca', 12)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (57, N'CLA       ', N'Celaya', 12)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (58, N'ALC       ', N'Acapulco', 13)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (59, N'CHG       ', N'Chilpancingo', 13)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (60, N'ZIJ       ', N'Zihuatanejo', 13)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (61, N'IGL       ', N'Iguala', 13)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (62, N'TAX       ', N'Taxco', 13)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (63, N'PCA       ', N'Pachuca', 14)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (64, N'TNG       ', N'Tulancingo', 14)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (65, N'TDR       ', N'Tepeji del Río', 14)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (66, N'MDR       ', N'Mineral de la Reforma', 14)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (67, N'GJA       ', N'Guadalajara', 15)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (68, N'ZPO       ', N'Zapopan', 15)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (69, N'TLA       ', N'Tlaquepaque', 15)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (70, N'TLE       ', N'Tonalá', 15)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (71, N'PVA       ', N'Puerto Vallarta', 15)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (72, N'MRA       ', N'Morelia', 16)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (73, N'URN       ', N'Uruapan', 16)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (74, N'ZMA       ', N'Zamora', 16)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (75, N'LCA       ', N'Lázaro Cárdenas', 16)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (76, N'AGA       ', N'Apatzingán', 16)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (77, N'CUA       ', N'Cuernavaca', 17)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (78, N'JPC       ', N'Jiutepec', 17)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (79, N'TMX       ', N'Temixco', 17)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (80, N'EZA       ', N'Emiliano Zapata', 17)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (81, N'YAC       ', N'Yautepec', 17)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (82, N'TPC       ', N'Tepic', 18)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (83, N'BDB       ', N'Bahía de Banderas', 18)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (84, N'SXC       ', N'Santiago Ixcuintla', 18)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (85, N'CPL       ', N'Compostela', 18)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (86, N'RIZ       ', N'Ruiz', 18)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (87, N'MTY       ', N'Monterrey', 19)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (88, N'GLP       ', N'Guadalupe', 19)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (89, N'SDG       ', N'San Nicolás de los Garza', 19)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (90, N'APC       ', N'Apodaca', 19)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (91, N'GEO       ', N'General Escobedo', 19)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (92, N'ODZ       ', N'Oaxaca de Juárez', 20)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (93, N'SCZ       ', N'Salina Cruz', 20)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (94, N'JIN       ', N'Juchitán', 20)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (95, N'PES       ', N'Puerto Escondido', 20)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (96, N'HUA       ', N'Huatulco', 20)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (97, N'PBL       ', N'Puebla', 21)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (98, N'TEN       ', N'Tehuacán', 21)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (99, N'CLA       ', N'Cholula', 21)
GO
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (100, N'ATI       ', N'Atlixco', 21)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (101, N'SMT       ', N'San Martín Texmelucan', 21)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (102, N'QTA       ', N'Querétaro', 22)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (103, N'SJD       ', N'San Juan del Río', 22)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (104, N'CRA       ', N'Corregidora', 22)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (105, N'EME       ', N'El Marqués', 22)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (106, N'PES       ', N'Pedro Escobedo', 22)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (107, N'CAN       ', N'Cancún', 23)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (108, N'PDC       ', N'Playa del Carmen', 23)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (109, N'CZU       ', N'Cozumel', 23)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (110, N'TUL       ', N'Tulum', 23)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (111, N'CHT       ', N'Chetumal', 23)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (112, N'SLP       ', N'San Luis Potosí', 24)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (113, N'SDG       ', N'Soledad de Graciano Sánchez', 24)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (114, N'MTL       ', N'Matehuala', 24)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (115, N'ROV       ', N'Rioverde', 24)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (116, N'CVA       ', N'Ciudad Valles', 24)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (117, N'ZAC       ', N'Culiacán', 25)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (118, N'ZAC       ', N'Mazatlán', 25)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (119, N'LMO       ', N'Los Mochis', 25)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (120, N'GUA       ', N'Guasave', 25)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (121, N'GUM       ', N'Guam', 25)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (122, N'HER       ', N'Hermosillo', 26)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (123, N'COB       ', N'Ciudad Obregón', 26)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (124, N'NOG       ', N'Nogales', 26)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (125, N'SLR       ', N'San Luis Río Colorado', 26)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (126, N'GYM       ', N'Guaymas', 26)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (127, N'VHM       ', N'Villahermosa', 27)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (128, N'CDA       ', N'Cárdenas', 27)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (129, N'COC       ', N'Comalcalco', 27)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (130, N'PRA       ', N'Paraíso', 27)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (131, N'MCA       ', N'Macuspana', 27)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (132, N'CVC       ', N'Ciudad Victoria', 28)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (133, N'REY       ', N'Reynosa', 28)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (134, N'MTO       ', N'Matamoros', 28)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (135, N'NUE       ', N'Nuevo Laredo', 28)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (136, N'TAM       ', N'Tampico', 28)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (137, N'TLA       ', N'Tlaxcala de Xicohténcatl', 29)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (138, N'API       ', N'Apizaco', 29)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (139, N'HAA       ', N'Huamantla', 29)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (140, N'CHA       ', N'Chiautempan', 29)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (141, N'ZCA       ', N'Zacatelco', 29)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (142, N'VER       ', N'Veracruz', 30)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (143, N'XAL       ', N'Xalapa', 30)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (144, N'COA       ', N'Coatzacoalcos', 30)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (145, N'POZ       ', N'Poza Rica', 30)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (146, N'COR       ', N'Córdoba', 30)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (147, N'MER       ', N'Mérida', 31)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (148, N'VAL       ', N'Valladolid', 31)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (149, N'PRO       ', N'Progreso', 31)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (150, N'TIZ       ', N'Tizimín', 31)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (151, N'UMA       ', N'Umán', 31)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (152, N'ZAC       ', N'Zacatecas', 32)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (153, N'GUA       ', N'Guadalupe', 32)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (154, N'FRE       ', N'Fresnillo', 32)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (155, N'JER       ', N'Jerez', 32)
INSERT [dbo].[area] ([id], [clave], [valor], [id_estado]) VALUES (156, N'SOM       ', N'Sombrerete', 32)
SET IDENTITY_INSERT [dbo].[area] OFF
GO
SET IDENTITY_INSERT [dbo].[contrasena] ON 

INSERT [dbo].[contrasena] ([id], [contrasena]) VALUES (1, N'8C6976E5B5410415BDE908BD4DEE15DFB167A9C873FC4BB8A81F6F2AB448A918')
SET IDENTITY_INSERT [dbo].[contrasena] OFF
GO
SET IDENTITY_INSERT [dbo].[estado] ON 

INSERT [dbo].[estado] ([id], [clave], [valor]) VALUES (1, N'AGU', N'Aguascalientes')
INSERT [dbo].[estado] ([id], [clave], [valor]) VALUES (2, N'BCN', N'Baja California')
INSERT [dbo].[estado] ([id], [clave], [valor]) VALUES (3, N'BCS', N'Baja California Sur')
INSERT [dbo].[estado] ([id], [clave], [valor]) VALUES (4, N'CAM', N'Campeche')
INSERT [dbo].[estado] ([id], [clave], [valor]) VALUES (5, N'CHP', N'Chiapas')
INSERT [dbo].[estado] ([id], [clave], [valor]) VALUES (6, N'CHH', N'Chihuahua')
INSERT [dbo].[estado] ([id], [clave], [valor]) VALUES (7, N'COA', N'Coahuila')
INSERT [dbo].[estado] ([id], [clave], [valor]) VALUES (8, N'COL', N'Colima')
INSERT [dbo].[estado] ([id], [clave], [valor]) VALUES (9, N'CMX', N'Ciudad de México')
INSERT [dbo].[estado] ([id], [clave], [valor]) VALUES (10, N'DUR', N'Durango')
INSERT [dbo].[estado] ([id], [clave], [valor]) VALUES (11, N'MEX', N'Estado de México')
INSERT [dbo].[estado] ([id], [clave], [valor]) VALUES (12, N'GUA', N'Guanajuato')
INSERT [dbo].[estado] ([id], [clave], [valor]) VALUES (13, N'GRO', N'Guerrero')
INSERT [dbo].[estado] ([id], [clave], [valor]) VALUES (14, N'HID', N'Hidalgo')
INSERT [dbo].[estado] ([id], [clave], [valor]) VALUES (15, N'JAL', N'Jalisco')
INSERT [dbo].[estado] ([id], [clave], [valor]) VALUES (16, N'MIC', N'Michoacán')
INSERT [dbo].[estado] ([id], [clave], [valor]) VALUES (17, N'MOR', N'Morelos')
INSERT [dbo].[estado] ([id], [clave], [valor]) VALUES (18, N'NAY', N'Nayarit')
INSERT [dbo].[estado] ([id], [clave], [valor]) VALUES (19, N'NLE', N'Nuevo León')
INSERT [dbo].[estado] ([id], [clave], [valor]) VALUES (20, N'OAX', N'Oaxaca')
INSERT [dbo].[estado] ([id], [clave], [valor]) VALUES (21, N'PUE', N'Puebla')
INSERT [dbo].[estado] ([id], [clave], [valor]) VALUES (22, N'QUE', N'Querétaro')
INSERT [dbo].[estado] ([id], [clave], [valor]) VALUES (23, N'ROO', N'Quintana Roo')
INSERT [dbo].[estado] ([id], [clave], [valor]) VALUES (24, N'SLP', N'San Luis Potosí')
INSERT [dbo].[estado] ([id], [clave], [valor]) VALUES (25, N'SIN', N'Sinaloa')
INSERT [dbo].[estado] ([id], [clave], [valor]) VALUES (26, N'SON', N'Sonora')
INSERT [dbo].[estado] ([id], [clave], [valor]) VALUES (27, N'TAB', N'Tabasco')
INSERT [dbo].[estado] ([id], [clave], [valor]) VALUES (28, N'TAM', N'Tamaulipas')
INSERT [dbo].[estado] ([id], [clave], [valor]) VALUES (29, N'TLA', N'Tlaxcala')
INSERT [dbo].[estado] ([id], [clave], [valor]) VALUES (30, N'VER', N'Veracruz')
INSERT [dbo].[estado] ([id], [clave], [valor]) VALUES (31, N'YUC', N'Yucatán')
INSERT [dbo].[estado] ([id], [clave], [valor]) VALUES (32, N'ZAC', N'Zacatecas')
SET IDENTITY_INSERT [dbo].[estado] OFF
GO
SET IDENTITY_INSERT [dbo].[perfil] ON 

INSERT [dbo].[perfil] ([id], [cargo]) VALUES (1, N'Administrador')
INSERT [dbo].[perfil] ([id], [cargo]) VALUES (2, N'Usuario')
SET IDENTITY_INSERT [dbo].[perfil] OFF
GO
SET IDENTITY_INSERT [dbo].[usuario] ON 

INSERT [dbo].[usuario] ([id], [nombre], [apellidoP], [apellidoM], [id_perfil], [correo], [telefono], [usuario], [id_contrasena], [sesion], [estatus]) VALUES (1, N'Admin', N'admin', N'admin', 1, N'admin@gmail.com', N'0000000000', N'admin', 1, 0, N'Activo')
SET IDENTITY_INSERT [dbo].[usuario] OFF
GO
ALTER TABLE [dbo].[area]  WITH CHECK ADD  CONSTRAINT [FK_area_estado] FOREIGN KEY([id_estado])
REFERENCES [dbo].[estado] ([id])
GO
ALTER TABLE [dbo].[area] CHECK CONSTRAINT [FK_area_estado]
GO
ALTER TABLE [dbo].[entradasSalidas]  WITH CHECK ADD  CONSTRAINT [FK_entradasSalidas_ingresoDatos] FOREIGN KEY([id_producto])
REFERENCES [dbo].[ingresoDatos] ([id])
GO
ALTER TABLE [dbo].[entradasSalidas] CHECK CONSTRAINT [FK_entradasSalidas_ingresoDatos]
GO
ALTER TABLE [dbo].[ingresoDatos]  WITH CHECK ADD  CONSTRAINT [FK_ingresoDatos_area] FOREIGN KEY([id_area])
REFERENCES [dbo].[area] ([id])
GO
ALTER TABLE [dbo].[ingresoDatos] CHECK CONSTRAINT [FK_ingresoDatos_area]
GO
ALTER TABLE [dbo].[ingresoDatos]  WITH CHECK ADD  CONSTRAINT [FK_ingresoDatos_estado] FOREIGN KEY([id_estado])
REFERENCES [dbo].[estado] ([id])
GO
ALTER TABLE [dbo].[ingresoDatos] CHECK CONSTRAINT [FK_ingresoDatos_estado]
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
/****** Object:  StoredProcedure [dbo].[cargarComboProducto]    Script Date: 06/08/2023 04:42:57 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[cargarComboProducto]

as
begin
select id, producto from ingresoDatos

end
GO
/****** Object:  StoredProcedure [dbo].[editarDatosFormulario]    Script Date: 06/08/2023 04:42:57 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[editarDatosFormulario]
(@ID INT,
    @NombreProceso Varchar(200),
@TipoProceso Varchar(50)= null,
@Autor Varchar(50),
@Correo Varchar(50),
@NombreFlujoR Varchar(300),
@Unidad Varchar(50),
@ValorR Varchar(100),
@Objetivo Varchar(500)= null,
@LimiteSistema Varchar(50)= null,
@Imagen image = null,
@ImagenDos image = null,
@UrlRepositorio Varchar(300) = null,
@TipoTecnologia varchar(100),
@CondicionesOperacion varchar(500)= null,
@FechaReferencia date,
@DatosValidos date,
@Descripcion varchar(300)= null,
@Estado INT, 
@Area INT,
@Latitud float,
@Longitud float,
@Observaciones varchar(500) = null
)
AS
BEGIN
  
    UPDATE ingresoDatos
    SET NombreProceso = @NombreProceso,
	    tipoProceso = @TipoProceso,
        autor = @Autor,
         correo = @Correo,
		   nombreFlujoR = @NombreFlujoR
		   ,unidad = @Unidad
		   ,valorR = @ValorR
		   ,objetivo = @Objetivo
		   ,limitesSistema = @LimiteSistema
		   ,imagen = @Imagen
		   ,imagenDos = @ImagenDos
		   ,urlRepositorio = @UrlRepositorio
		   ,tipoTecnologia = @TipoTecnologia
		   ,condicionesOperacion = @CondicionesOperacion
		   ,fechaReferencia = @FechaReferencia
		   ,datosValidos = @DatosValidos
		   ,descripcion = @Descripcion
		   ,id_estado = @Estado
		   ,id_area = @Area
		   ,latitud = @Latitud
		   ,longitud = @Longitud
		   ,observaciones = @Observaciones
    WHERE id = @ID;

END;
GO
/****** Object:  StoredProcedure [dbo].[editarEntradasSalidas]    Script Date: 06/08/2023 04:42:57 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[editarEntradasSalidas]
(@ID INT,
@NombreFlujo Varchar(200),
@TipoFlujo Varchar(50),
@Recursos Varchar(200),
@Emisiones Varchar(200) = null,
@Valor Varchar(100),
@Unidad Varchar(50),
@TratamientoDato Varchar(150),
@Adquisicion Varchar(50),
@Citas Varchar(100) = null,
@Comentario Varchar(150)= null
)
AS
BEGIN
    UPDATE entradasSalidas
    SET nombreFlujo = @NombreFlujo,
	    tipoFlujo = @TipoFlujo,
        recursos = @Recursos,
         emisiones = @Emisiones,
		   valor = @Valor
		   ,unidad = @Unidad
		   ,tratamientoDato = @TratamientoDato
		   ,adquisicionDato = @Adquisicion
		   ,citasReferencia = @Citas
		   ,cometario = @Comentario
    WHERE id = @ID;

END;
GO
/****** Object:  StoredProcedure [dbo].[editarUsuario]    Script Date: 06/08/2023 04:42:57 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[editarUsuario]
(
    @ID INT,
    @Nombre VARCHAR(50),
    @ApellidoP VARCHAR(50),
    @ApellidoM VARCHAR(50)= null,
    @Perfil INT,
    @CorreoElectronico VARCHAR(50),
    @Telefono VARCHAR(50),
    @Usuario VARCHAR(50),
	@Estatus VARCHAR(20),
    @Contraseña VARCHAR(200) = NULL
)
AS
BEGIN
    -- Actualizar la tabla 'usuario'
    UPDATE usuario
    SET nombre = @Nombre,
        apellidoP = @ApellidoP,
        apellidoM = @ApellidoM,
        id_perfil = @Perfil,
        correo = @CorreoElectronico,
        telefono = @Telefono,
        usuario = @Usuario,
		estatus = @Estatus
    WHERE id = @ID;

    -- Verificar si se debe actualizar la contraseña
    IF @Contraseña IS NOT NULL
    BEGIN
        -- Actualizar la tabla 'contrasena'
        UPDATE contrasena
        SET contrasena = @Contraseña
        WHERE id = (SELECT id_contrasena FROM usuario WHERE id = @ID);
    END;
END;
GO
/****** Object:  StoredProcedure [dbo].[eliminarDatosF]    Script Date: 06/08/2023 04:42:57 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[eliminarDatosF]
(
    @Id int
) 
AS
BEGIN
    -- Verificar si existen registros relacionados en la tabla entradasSalidas
    IF EXISTS (SELECT 1 FROM entradasSalidas WHERE id_producto = @Id)
    BEGIN
        -- Registro relacionado encontrado, devolver valor indicando que no se puede eliminar
        SELECT 0
        RETURN
    END

    -- No existen registros relacionados, eliminar el registro de la tabla ingresoDatos
    DELETE FROM ingresoDatos WHERE id = @Id;
    SELECT 1 -- Valor indicando que se eliminó correctamente
END
GO
/****** Object:  StoredProcedure [dbo].[eliminarDatosFormulario]    Script Date: 06/08/2023 04:42:57 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[eliminarDatosFormulario]
(@Id int
 ) 
as
BEGIN            
	delete from ingresoDatos
    where id = @Id;
end
GO
/****** Object:  StoredProcedure [dbo].[eliminarEntradasSalidas]    Script Date: 06/08/2023 04:42:57 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[eliminarEntradasSalidas]
(@Id int
 ) 
as
BEGIN            
	delete from entradasSalidas
    where id = @Id;
end
GO
/****** Object:  StoredProcedure [dbo].[EliminarRegistroYEntradas]    Script Date: 06/08/2023 04:42:57 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarRegistroYEntradas]
    @ID int
AS
BEGIN
  SET NOCOUNT ON;

    -- Eliminar registros relacionados en la tabla entradasSalidas
    DELETE FROM dbo.entradasSalidas
    WHERE id_producto = @ID;

    -- Eliminar el registro en la tabla ingresoDatos
    DELETE FROM dbo.ingresoDatos
    WHERE id = @ID;
END
GO
/****** Object:  StoredProcedure [dbo].[eliminarUsuario]    Script Date: 06/08/2023 04:42:57 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[eliminarUsuario]
(@Id int
 ) 
as
BEGIN            
	update   usuario
	set
			 estatus = 'Inactivo'
	where
	id = @Id;
end

GO
/****** Object:  StoredProcedure [dbo].[insertarDatosFormulario]    Script Date: 06/08/2023 04:42:57 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertarDatosFormulario]
(@Producto Varchar(100),
@Tecnologia Varchar(100),
@Otro Varchar(100),
@NombreProceso Varchar(200),
@TipoProceso Varchar(50) = null,
@Autor Varchar(50),
@Correo Varchar(50),
@NombreFlujoR Varchar(300),
@Unidad Varchar(50),
@ValorR Varchar(100),
@Objetivo Varchar(500)= null,
@LimiteSistema Varchar(50)= null,
@Imagen image = null,
@ImagenDos image = null,
@UrlRepositorio Varchar(300) = null,
@TipoTecnologia varchar(100),
@CondicionesOperacion varchar(500) = null,
@FechaReferencia date,
@DatosValidos date,
@Descripcion varchar(300) = null,
@Estado INT, 
@Area INT,
@Latitud float,
@Longitud float,
@Observaciones varchar(500) = null
) 
as
BEGIN

INSERT INTO ingresoDatos
           (producto
           ,tecnologia
           ,otro
		   ,NombreProceso
           ,tipoProceso
		   ,autor
		   ,correo
		   ,nombreFlujoR
		   ,unidad
		   ,valorR
		   ,objetivo
		   ,limitesSistema
		   ,imagen
		   ,imagenDos
		   ,urlRepositorio
		   ,tipoTecnologia
		   ,condicionesOperacion
		   ,fechaReferencia
		   ,datosValidos
		   ,descripcion
		   ,id_estado
		   ,id_area
		   ,latitud
		   ,longitud
		   ,observaciones)
     VALUES
           (@Producto ,
			@Tecnologia,
			@Otro ,
			@NombreProceso,
			@TipoProceso,
			@Autor ,
			@Correo ,
			@NombreFlujoR ,
			@Unidad ,
			@ValorR ,
			@Objetivo ,
			@LimiteSistema ,
			@Imagen ,
			@ImagenDos,
			@UrlRepositorio,
			@TipoTecnologia ,
			@CondicionesOperacion ,
			@FechaReferencia ,
			@DatosValidos ,
			@Descripcion,
			@Estado ,
			@Area ,
			@Latitud,
			@Longitud,
			@Observaciones)
		   end
GO
/****** Object:  StoredProcedure [dbo].[insertarEntradasSalidas]    Script Date: 06/08/2023 04:42:57 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[insertarEntradasSalidas]
(@Producto int,
@NombreFlujo Varchar(200),
@TipoFlujo Varchar(50),
@Recursos Varchar(200),
@Emisiones Varchar(200) = null,
@Valor Varchar(100),
@Unidad Varchar(50),
@TratamientoDato Varchar(150),
@Adquisicion Varchar(50),
@Citas Varchar(100) = null,
@Comentario Varchar(150)= null

) 
as
BEGIN

INSERT INTO entradasSalidas
           (id_producto
           ,nombreFlujo
           ,tipoFlujo
		   ,recursos
           ,emisiones
		   ,valor
		   ,unidad
		   ,tratamientoDato
		   ,adquisicionDato
		   ,citasReferencia
		   ,cometario
		   )
     VALUES
           (@Producto, 
			@NombreFlujo, 
			@TipoFlujo, 
			@Recursos ,
			@Emisiones, 
			@Valor, 
			@Unidad, 
			@TratamientoDato, 
			@Adquisicion, 
			@Citas, 
			@Comentario 
			)
		   end
GO
/****** Object:  StoredProcedure [dbo].[insertarUsuario]    Script Date: 06/08/2023 04:42:57 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertarUsuario]
(@Nombre Varchar(50),
@ApellidoP Varchar(50),
@ApellidoM Varchar(50) = null,
@Perfil int,
@CorreoElectronico Varchar(50),
@Telefono Varchar(50),
@Usuario Varchar(50),
@Contraseña Varchar(200)
) 
as
BEGIN

INSERT INTO contrasena (contrasena) values (@Contraseña)
declare @idContraseña as int
set @idContraseña = (select max(id) from contrasena)

INSERT INTO usuario
           (nombre
           ,apellidoP
           ,apellidoM
		   ,id_perfil
           ,correo
		   ,telefono
		   ,usuario
		   ,id_contrasena
		   ,sesion
		   ,estatus)
     VALUES
           (@Nombre,
          @ApellidoP,
		  @ApellidoM,
		  @Perfil,
		  @CorreoElectronico,
		  @Telefono,
		  @Usuario,
		  @idContraseña,
		  0,
		  'Activo');
		   end
GO
/****** Object:  StoredProcedure [dbo].[insertBitacora]    Script Date: 06/08/2023 04:42:57 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[insertBitacora]
(@Operacion Varchar(50),
@Fecha datetime,
@DescripcionEvento Varchar(100),
@Usuario Varchar(50)
) 
as
BEGIN

INSERT INTO bitacora
           (operacion
           ,fecha
           ,descripcionEvento
		   ,usuario
		   )
     VALUES
           (@Operacion, 
			@Fecha, 
			@DescripcionEvento, 
			@Usuario
			)
		   end
GO
/****** Object:  StoredProcedure [dbo].[llenarArea]    Script Date: 06/08/2023 04:42:57 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[llenarArea]
@id int 
as
begin
select d.id, d.valor from area as d
inner join estado as e on (d.id_estado = e.id)
where @id = e.id;
end
GO
/****** Object:  StoredProcedure [dbo].[llenarEstado]    Script Date: 06/08/2023 04:42:57 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[llenarEstado]
as
begin
select id, valor from estado;
end
GO
/****** Object:  StoredProcedure [dbo].[login]    Script Date: 06/08/2023 04:42:57 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[login]
(
    @Usuario varchar(50),
    @Contrasena varchar(200)
)
AS
BEGIN
    SELECT
        a.usuario,
        b.cargo,
        a.id
    FROM
        usuario as a
        INNER JOIN perfil as b ON (a.id_perfil = b.id)
        INNER JOIN contrasena as c ON (a.id_contrasena = c.id)
    WHERE
        a.usuario = @Usuario
        AND c.contrasena = @Contrasena
       AND a.estatus = 'Activo' -- Agregar la condición para verificar el estatus sea igual a 1

    UPDATE sus
    SET sesion = 1
    FROM
        usuario as sus
        INNER JOIN perfil as b ON (sus.id_perfil = b.id)
        INNER JOIN contrasena as c ON (sus.id_contrasena = c.id)
    WHERE
        sus.usuario = @Usuario
        AND c.contrasena = @Contrasena
         AND sus.estatus = 'Activo' -- Agregar la condición para verificar el estatus sea igual a 1
END
GO
/****** Object:  StoredProcedure [dbo].[logout]    Script Date: 06/08/2023 04:42:57 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[logout]
(@Usuario tinyint)
as
begin
--declare @us

update sus set sesion = 0 	
		from usuario as sus
		where id=@Usuario
		end
GO
/****** Object:  StoredProcedure [dbo].[seleccionarDatosBitacora]    Script Date: 06/08/2023 04:42:57 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[seleccionarDatosBitacora]
as
select operacion, fecha, descripcionEvento, usuario
		from bitacora;
GO
/****** Object:  StoredProcedure [dbo].[seleccionarDatosFormulario]    Script Date: 06/08/2023 04:42:57 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[seleccionarDatosFormulario]
AS
BEGIN
    SELECT 
			a.id,
            CONCAT(a.producto, ', ', a.tecnologia, ', ', a.otro) AS producto_tecnologia,
            a.producto,
            a.tecnologia,
            a.otro,
            a.NombreProceso,
            a.tipoProceso,
            a.autor,
            a.correo,
            a.nombreFlujoR,
            a.unidad,
            a.valorR,
            a.objetivo,
            a.limitesSistema,
			a.imagen,
			a.imagenDos,
			a.urlRepositorio,
            a.tipoTecnologia,
            a.condicionesOperacion,
            a.fechaReferencia,
            a.datosValidos,
            a.descripcion,
            b.valor,
            c.valor,
            CONCAT(a.latitud, ', ', a.longitud) AS representacionGeografica,
			a.latitud,
			a.longitud,
			a.observaciones
    FROM ingresoDatos AS a
    JOIN estado AS b ON a.id_estado = b.id
    JOIN area AS c ON a.id_area = c.id;
END
GO
/****** Object:  StoredProcedure [dbo].[seleccionarDatosUsuario]    Script Date: 06/08/2023 04:42:57 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[seleccionarDatosUsuario]
as
select	a.id,
		CONCAT(a.nombre, ' ', a.apellidoP, ' ', a.apellidoM) Nombre_completo,
		a.nombre,
		a.apellidoP,
		a.apellidoM,
		b.cargo,
		a.correo,
		a.telefono,
		a.usuario,
		a.estatus
		from usuario as a join perfil as b on(a.id_perfil = b.id);
GO
/****** Object:  StoredProcedure [dbo].[seleccionarEntradasSalidas]    Script Date: 06/08/2023 04:42:57 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[seleccionarEntradasSalidas]
AS
BEGIN
    SELECT  a.id,
			b.id AS ingresoDatos,
            CONCAT(b.producto, ', ', b.tecnologia, ', ', b.otro) AS producto_tecnologia,
            b.producto,
            b.tecnologia,
            b.otro,
            a.nombreFlujo
           ,a.tipoFlujo
		   ,a.recursos
           ,a.emisiones
		   ,a.valor
		   ,a.unidad
		   ,a.tratamientoDato
		   ,a.adquisicionDato
		   ,a.citasReferencia
		   ,a.cometario
    FROM entradasSalidas AS a
    JOIN ingresoDatos AS b ON a.id_producto = b.id
 
END
GO
/****** Object:  StoredProcedure [dbo].[validaUsuario]    Script Date: 06/08/2023 04:42:57 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[validaUsuario]
as
select id,
		usuario
		from usuario;
GO
USE [master]
GO
ALTER DATABASE [registroDatos] SET  READ_WRITE 
GO
