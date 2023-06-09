USE [registroDatos]
GO
/****** Object:  Table [dbo].[area]    Script Date: 09/06/2023 09:07:31 a. m. ******/
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
/****** Object:  Table [dbo].[bitacora]    Script Date: 09/06/2023 09:07:31 a. m. ******/
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
/****** Object:  Table [dbo].[contraseña]    Script Date: 09/06/2023 09:07:31 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[contraseña](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[contraseña] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[entradasSalidas]    Script Date: 09/06/2023 09:07:31 a. m. ******/
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
/****** Object:  Table [dbo].[estado]    Script Date: 09/06/2023 09:07:31 a. m. ******/
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
/****** Object:  Table [dbo].[ingresoDatos]    Script Date: 09/06/2023 09:07:31 a. m. ******/
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
/****** Object:  Table [dbo].[perfil]    Script Date: 09/06/2023 09:07:31 a. m. ******/
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
/****** Object:  Table [dbo].[usuario]    Script Date: 09/06/2023 09:07:31 a. m. ******/
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
	[id_contraseña] [int] NOT NULL,
	[sesion] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
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
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [fk_contraseña] FOREIGN KEY([id_contraseña])
REFERENCES [dbo].[contraseña] ([id])
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [fk_contraseña]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [fk_perfil] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[perfil] ([id])
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [fk_perfil]
GO
