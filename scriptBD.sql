USE [registroDatos]
GO
/****** Object:  Table [dbo].[area]    Script Date: 21/06/2023 06:31:39 p. m. ******/
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
/****** Object:  Table [dbo].[bitacora]    Script Date: 21/06/2023 06:31:39 p. m. ******/
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
	[registros] [int] NULL,
	[usuario] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[contrasena]    Script Date: 21/06/2023 06:31:39 p. m. ******/
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
/****** Object:  Table [dbo].[entradasSalidas]    Script Date: 21/06/2023 06:31:39 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[entradasSalidas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_producto] [int] NOT NULL,
	[tipoFlujo] [varchar](50) NOT NULL,
	[recursos] [varchar](50) NULL,
	[emisiones] [varchar](100) NULL,
	[valor] [decimal](13, 2) NOT NULL,
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
/****** Object:  Table [dbo].[estado]    Script Date: 21/06/2023 06:31:39 p. m. ******/
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
/****** Object:  Table [dbo].[ingresoDatos]    Script Date: 21/06/2023 06:31:39 p. m. ******/
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
	[nombreFlujoR] [varchar](200) NOT NULL,
	[unidad] [varchar](50) NOT NULL,
	[valorR] [decimal](13, 2) NOT NULL,
	[objetivo] [varchar](100) NOT NULL,
	[limitesSistema] [varchar](50) NOT NULL,
	[imagen] [varchar](50) NULL,
	[tipoTecnologia] [varchar](50) NOT NULL,
	[condicionesOperacion] [varchar](200) NULL,
	[fechaReferencia] [date] NOT NULL,
	[datosValidos] [date] NOT NULL,
	[descripcion] [varchar](200) NULL,
	[id_estado] [int] NOT NULL,
	[id_area] [int] NOT NULL,
	[latitud] [float] NOT NULL,
	[longitud] [float] NOT NULL,
 CONSTRAINT [PK_ingresoDatos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[perfil]    Script Date: 21/06/2023 06:31:39 p. m. ******/
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
/****** Object:  Table [dbo].[usuario]    Script Date: 21/06/2023 06:31:39 p. m. ******/
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
SET IDENTITY_INSERT [dbo].[bitacora] ON 

INSERT [dbo].[bitacora] ([id], [operacion], [fecha], [descripcionEvento], [id_usuario], [registros], [usuario]) VALUES (1, N'Alta', CAST(N'2023-06-15T11:45:05.907' AS DateTime), N'Alta de usuario', 1, 1, N'admin')
INSERT [dbo].[bitacora] ([id], [operacion], [fecha], [descripcionEvento], [id_usuario], [registros], [usuario]) VALUES (2, N'Alta', CAST(N'2023-06-15T11:46:04.710' AS DateTime), N'Alta de usuario', 1, 1, N'admin')
INSERT [dbo].[bitacora] ([id], [operacion], [fecha], [descripcionEvento], [id_usuario], [registros], [usuario]) VALUES (3, N'Alta', CAST(N'2023-06-15T11:47:45.530' AS DateTime), N'Alta de usuario', 8, 1, N'dasdas')
INSERT [dbo].[bitacora] ([id], [operacion], [fecha], [descripcionEvento], [id_usuario], [registros], [usuario]) VALUES (4, N'Actualización', CAST(N'2023-06-15T11:54:23.680' AS DateTime), N'Modificación de usuario', 8, 1, N'dasdas')
INSERT [dbo].[bitacora] ([id], [operacion], [fecha], [descripcionEvento], [id_usuario], [registros], [usuario]) VALUES (10, N'Alta', CAST(N'2023-06-19T16:47:42.953' AS DateTime), N'Alta de usuario', 12, 1, N'adasd')
INSERT [dbo].[bitacora] ([id], [operacion], [fecha], [descripcionEvento], [id_usuario], [registros], [usuario]) VALUES (11, N'Inserción', CAST(N'2023-06-19T16:52:39.843' AS DateTime), N'Inserción de usuario', 13, 1, N'Omar\cacam')
INSERT [dbo].[bitacora] ([id], [operacion], [fecha], [descripcionEvento], [id_usuario], [registros], [usuario]) VALUES (12, N'Inserción', CAST(N'2023-06-19T17:03:14.210' AS DateTime), N'Inserción de usuario', 15, 1, N'asdsa')
INSERT [dbo].[bitacora] ([id], [operacion], [fecha], [descripcionEvento], [id_usuario], [registros], [usuario]) VALUES (13, N'Inserción', CAST(N'2023-06-19T17:14:47.020' AS DateTime), N'Inserción de usuario', 22, 1, N'asdasss')
SET IDENTITY_INSERT [dbo].[bitacora] OFF
GO
SET IDENTITY_INSERT [dbo].[contrasena] ON 

INSERT [dbo].[contrasena] ([id], [contrasena]) VALUES (1, N'8C6976E5B5410415BDE908BD4DEE15DFB167A9C873FC4BB8A81F6F2AB448A918')
INSERT [dbo].[contrasena] ([id], [contrasena]) VALUES (2, N'9250E222C4C71F0C58D4C54B50A880A312E9F9FED55D5C3AA0B0E860DED99165')
INSERT [dbo].[contrasena] ([id], [contrasena]) VALUES (3, N'8C6976E5B5410415BDE908BD4DEE15DFB167A9C873FC4BB8A81F6F2AB448A918')
INSERT [dbo].[contrasena] ([id], [contrasena]) VALUES (5, N'91bbfcd5e35717022a9d36e425ee662c8025cbe050cb6c7b1da9fb60560301d4')
INSERT [dbo].[contrasena] ([id], [contrasena]) VALUES (6, N'91bbfcd5e35717022a9d36e425ee662c8025cbe050cb6c7b1da9fb60560301d4')
INSERT [dbo].[contrasena] ([id], [contrasena]) VALUES (7, N'a871c47a7f48a12b38a994e48a9659fab5d6376f3dbce37559bcb617efe8662d')
INSERT [dbo].[contrasena] ([id], [contrasena]) VALUES (8, N'91bbfcd5e35717022a9d36e425ee662c8025cbe050cb6c7b1da9fb60560301d4')
INSERT [dbo].[contrasena] ([id], [contrasena]) VALUES (9, N'91bbfcd5e35717022a9d36e425ee662c8025cbe050cb6c7b1da9fb60560301d4')
INSERT [dbo].[contrasena] ([id], [contrasena]) VALUES (10, N'91bbfcd5e35717022a9d36e425ee662c8025cbe050cb6c7b1da9fb60560301d4')
INSERT [dbo].[contrasena] ([id], [contrasena]) VALUES (12, N'91bbfcd5e35717022a9d36e425ee662c8025cbe050cb6c7b1da9fb60560301d4')
INSERT [dbo].[contrasena] ([id], [contrasena]) VALUES (13, N'91bbfcd5e35717022a9d36e425ee662c8025cbe050cb6c7b1da9fb60560301d4')
INSERT [dbo].[contrasena] ([id], [contrasena]) VALUES (14, N'91bbfcd5e35717022a9d36e425ee662c8025cbe050cb6c7b1da9fb60560301d4')
INSERT [dbo].[contrasena] ([id], [contrasena]) VALUES (15, N'91bbfcd5e35717022a9d36e425ee662c8025cbe050cb6c7b1da9fb60560301d4')
INSERT [dbo].[contrasena] ([id], [contrasena]) VALUES (16, N'91bbfcd5e35717022a9d36e425ee662c8025cbe050cb6c7b1da9fb60560301d4')
INSERT [dbo].[contrasena] ([id], [contrasena]) VALUES (17, N'91bbfcd5e35717022a9d36e425ee662c8025cbe050cb6c7b1da9fb60560301d4')
INSERT [dbo].[contrasena] ([id], [contrasena]) VALUES (18, N'91bbfcd5e35717022a9d36e425ee662c8025cbe050cb6c7b1da9fb60560301d4')
INSERT [dbo].[contrasena] ([id], [contrasena]) VALUES (19, N'91bbfcd5e35717022a9d36e425ee662c8025cbe050cb6c7b1da9fb60560301d4')
INSERT [dbo].[contrasena] ([id], [contrasena]) VALUES (20, N'91bbfcd5e35717022a9d36e425ee662c8025cbe050cb6c7b1da9fb60560301d4')
INSERT [dbo].[contrasena] ([id], [contrasena]) VALUES (21, N'91bbfcd5e35717022a9d36e425ee662c8025cbe050cb6c7b1da9fb60560301d4')
INSERT [dbo].[contrasena] ([id], [contrasena]) VALUES (22, N'91bbfcd5e35717022a9d36e425ee662c8025cbe050cb6c7b1da9fb60560301d4')
INSERT [dbo].[contrasena] ([id], [contrasena]) VALUES (23, N'91bbfcd5e35717022a9d36e425ee662c8025cbe050cb6c7b1da9fb60560301d4')
INSERT [dbo].[contrasena] ([id], [contrasena]) VALUES (24, N'91bbfcd5e35717022a9d36e425ee662c8025cbe050cb6c7b1da9fb60560301d4')
INSERT [dbo].[contrasena] ([id], [contrasena]) VALUES (25, N'91bbfcd5e35717022a9d36e425ee662c8025cbe050cb6c7b1da9fb60560301d4')
INSERT [dbo].[contrasena] ([id], [contrasena]) VALUES (26, N'91bbfcd5e35717022a9d36e425ee662c8025cbe050cb6c7b1da9fb60560301d4')
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

INSERT [dbo].[usuario] ([id], [nombre], [apellidoP], [apellidoM], [id_perfil], [correo], [telefono], [usuario], [id_contrasena], [sesion], [estatus]) VALUES (1, N'Omar', N'Suárez', N'Casas', 1, N'omar_2.3@gmail.com', N'2281144037', N'admin', 1, 0, N'Activo')
INSERT [dbo].[usuario] ([id], [nombre], [apellidoP], [apellidoM], [id_perfil], [correo], [telefono], [usuario], [id_contrasena], [sesion], [estatus]) VALUES (2, N'prueba', N'prueba', N'Ejemplo: Hernández', 1, N'omar_2.3@gmail.com', N'4545421551', N'usuario', 2, 0, N'Inactivo')
INSERT [dbo].[usuario] ([id], [nombre], [apellidoP], [apellidoM], [id_perfil], [correo], [telefono], [usuario], [id_contrasena], [sesion], [estatus]) VALUES (3, N'Josue', N'Suarez', N'Casas', 1, N'js@gmail.com', N'225422', N'Administrador', 3, 0, N'Inactivo')
INSERT [dbo].[usuario] ([id], [nombre], [apellidoP], [apellidoM], [id_perfil], [correo], [telefono], [usuario], [id_contrasena], [sesion], [estatus]) VALUES (5, N'Eduardo', N'Perez', N'Garcia', 2, N'asdsad@gmail.com', N'8894454554', N'EPerez9', 5, 0, N'Inactivo')
INSERT [dbo].[usuario] ([id], [nombre], [apellidoP], [apellidoM], [id_perfil], [correo], [telefono], [usuario], [id_contrasena], [sesion], [estatus]) VALUES (6, N'vdgfdgd', N'fgdg', N'fgfdgdf', 2, N'gdfkgdg@gdfg.com', N'25874236987', N'dfgdgfdg', 6, 0, N'Inactivo')
INSERT [dbo].[usuario] ([id], [nombre], [apellidoP], [apellidoM], [id_perfil], [correo], [telefono], [usuario], [id_contrasena], [sesion], [estatus]) VALUES (7, N'sss', N'asdasda', N'adssad', 2, N'adsad@gmail.com', N'2281144037', N'asdasdas', 7, 0, N'Inactivo')
INSERT [dbo].[usuario] ([id], [nombre], [apellidoP], [apellidoM], [id_perfil], [correo], [telefono], [usuario], [id_contrasena], [sesion], [estatus]) VALUES (8, N'xdxd', N'asdasd', N'asdasd', 1, N'dasd@dasd.com', N'2222222222', N'dasdas', 8, 0, N'Inactivo')
INSERT [dbo].[usuario] ([id], [nombre], [apellidoP], [apellidoM], [id_perfil], [correo], [telefono], [usuario], [id_contrasena], [sesion], [estatus]) VALUES (9, N'adsad', N'asdsadsa', N'asdsadsa', 2, N'asdasds@gmail.com', N'2281144037', N'asdsadsa', 9, 0, N'Inactivo')
INSERT [dbo].[usuario] ([id], [nombre], [apellidoP], [apellidoM], [id_perfil], [correo], [telefono], [usuario], [id_contrasena], [sesion], [estatus]) VALUES (10, N'sadsadas', N'asdsad', N'asdsad', 2, N'asd@gmail.com', N'2281140372', N'asdsadas', 10, 0, N'Inactivo')
INSERT [dbo].[usuario] ([id], [nombre], [apellidoP], [apellidoM], [id_perfil], [correo], [telefono], [usuario], [id_contrasena], [sesion], [estatus]) VALUES (12, N'asdasd', N'adasd', N'adsad', 1, N'adsasdsa@adsfdsaf.com', N'2281144037', N'adasd', 12, 0, N'Inactivo')
INSERT [dbo].[usuario] ([id], [nombre], [apellidoP], [apellidoM], [id_perfil], [correo], [telefono], [usuario], [id_contrasena], [sesion], [estatus]) VALUES (13, N'asdsad', N'asdsa', N'asd', 1, N'asd@gmail.com', N'2281144037', N'asdsa', 13, 0, N'Inactivo')
INSERT [dbo].[usuario] ([id], [nombre], [apellidoP], [apellidoM], [id_perfil], [correo], [telefono], [usuario], [id_contrasena], [sesion], [estatus]) VALUES (15, N'asdsa', N'asd', N'asdas', 2, N'asd@asdsa.com', N'2281144037', N'asdas', 15, 0, N'Inactivo')
INSERT [dbo].[usuario] ([id], [nombre], [apellidoP], [apellidoM], [id_perfil], [correo], [telefono], [usuario], [id_contrasena], [sesion], [estatus]) VALUES (22, N'asdsa', N'asdsad', N'asda', 1, N'sdsa@gmail.com', N'2281144037', N'asdasss', 22, 0, N'Inactivo')
INSERT [dbo].[usuario] ([id], [nombre], [apellidoP], [apellidoM], [id_perfil], [correo], [telefono], [usuario], [id_contrasena], [sesion], [estatus]) VALUES (25, N'asdsad', N'asdsa', N'asdsa', 2, N'adas@gmail.com', N'2281140371', N'asdsass', 25, 0, N'Inactivo')
INSERT [dbo].[usuario] ([id], [nombre], [apellidoP], [apellidoM], [id_perfil], [correo], [telefono], [usuario], [id_contrasena], [sesion], [estatus]) VALUES (26, N'prueba', N'asdsad', N'asdasd', 2, N'asdsa@asdsa.comas', N'2281144032', N'pruebass', 26, 0, N'Inactivo')
SET IDENTITY_INSERT [dbo].[usuario] OFF
GO
ALTER TABLE [dbo].[area]  WITH CHECK ADD  CONSTRAINT [FK_area_estado] FOREIGN KEY([id_estado])
REFERENCES [dbo].[estado] ([id])
GO
ALTER TABLE [dbo].[area] CHECK CONSTRAINT [FK_area_estado]
GO
ALTER TABLE [dbo].[bitacora]  WITH CHECK ADD  CONSTRAINT [fk_usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[usuario] ([id])
GO
ALTER TABLE [dbo].[bitacora] CHECK CONSTRAINT [fk_usuario]
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
/****** Object:  StoredProcedure [dbo].[editarUsuario]    Script Date: 21/06/2023 06:31:39 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[editarUsuario]
(
    @ID INT,
    @Nombre VARCHAR(50),
    @ApellidoP VARCHAR(50),
    @ApellidoM VARCHAR(50),
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
/****** Object:  StoredProcedure [dbo].[eliminarUsuario]    Script Date: 21/06/2023 06:31:39 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[insertarUsuario]    Script Date: 21/06/2023 06:31:39 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertarUsuario]
(@Nombre Varchar(50),
@ApellidoP Varchar(50),
@ApellidoM Varchar(50),
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
/****** Object:  StoredProcedure [dbo].[llenarArea]    Script Date: 21/06/2023 06:31:39 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[llenarArea]
@id int = null
as
begin
select d.id, d.valor from area as d
inner join estado as e on (d.id_estado = e.id)
where @id = e.id;
end
GO
/****** Object:  StoredProcedure [dbo].[llenarEstado]    Script Date: 21/06/2023 06:31:39 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[login]    Script Date: 21/06/2023 06:31:39 p. m. ******/
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
        a.nombre,
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
/****** Object:  StoredProcedure [dbo].[logout]    Script Date: 21/06/2023 06:31:39 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[seleccionarDatosBitacora]    Script Date: 21/06/2023 06:31:39 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[seleccionarDatosBitacora]
as
select operacion, fecha, descripcionEvento, registros, usuario
		from bitacora;
GO
/****** Object:  StoredProcedure [dbo].[seleccionarDatosUsuario]    Script Date: 21/06/2023 06:31:39 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[validaUsuario]    Script Date: 21/06/2023 06:31:39 p. m. ******/
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
