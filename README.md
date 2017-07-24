# GRUPO_WEB_EXFINAL_CINE
USE [master]
GO
CREATE DATABASE CineDB
GO
USE [CineDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Asiento](
	[CodAsiento] [int] IDENTITY(1,1) NOT NULL,
	[DescripcionAsiento] [varchar](100) NULL,
	[CodSala] [int] NULL,
	[TipoAsiento] [int] NULL,
	[Disponible] [bit] NULL,
 CONSTRAINT [PK_Asiento] PRIMARY KEY CLUSTERED 
(
	[CodAsiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cine](
	[CodCine] [int] IDENTITY(1,1) NOT NULL,
	[NombreCine] [varchar](100) NULL,
	[Direccion] [varchar](100) NULL,
 CONSTRAINT [PK_Cine] PRIMARY KEY CLUSTERED 
(
	[CodCine] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CinePelicula]    Script Date: 30/06/2017 00:00:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CinePelicula](
	[CodCine] [int] NOT NULL,
	[CodPelicula] [int] NOT NULL,
	[EnCartelera] [bit] NULL,
 CONSTRAINT [PK_CinePelicula] PRIMARY KEY CLUSTERED 
(
	[CodCine] ASC,
	[CodPelicula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Director]    Script Date: 30/06/2017 00:00:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Director](
	[CodDirector] [int] IDENTITY(1,1) NOT NULL,
	[NombreDirector] [varchar](100) NULL,
 CONSTRAINT [PK_Director] PRIMARY KEY CLUSTERED 
(
	[CodDirector] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Funcion]    Script Date: 30/06/2017 00:00:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funcion](
	[CodFuncion] [int] IDENTITY(1,1) NOT NULL,
	[HoraInicio] [datetime] NULL,
	[HoraFin] [datetime] NULL,
	[CodPelicula] [int] NULL,
	[FechaFuncion] [datetime] NULL,
	[Precio] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Funcion] PRIMARY KEY CLUSTERED 
(
	[CodFuncion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Interprete]    Script Date: 30/06/2017 00:00:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Interprete](
	[CodInterprete] [int] IDENTITY(1,1) NOT NULL,
	[Paterno] [varchar](50) NULL,
	[Materno] [varchar](50) NULL,
	[Nombres] [varchar](50) NULL,
	[Nacionalidad] [varchar](50) NULL,
	[Foto] [varchar](1000) NULL,
	[Bio] [varchar](1000) NULL,
 CONSTRAINT [PK_Interprete] PRIMARY KEY CLUSTERED 
(
	[CodInterprete] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pedido]    Script Date: 30/06/2017 00:00:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pedido](
	[CodPedido] [int] NULL,
	[Descripcion] [varchar](50) NULL,
	[CodTicket] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pelicula]    Script Date: 30/06/2017 00:00:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pelicula](
	[CodPelicula] [int] IDENTITY(1,1) NOT NULL,
	[NombrePelicula] [varchar](100) NULL,
	[Duracion] [varchar](10) NULL,
	[FechaEstreno] [datetime] NULL,
	[CodDirector] [int] NULL,
 CONSTRAINT [PK_Pelicula] PRIMARY KEY CLUSTERED 
(
	[CodPelicula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 30/06/2017 00:00:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Persona](
	[CodPersona] [int] IDENTITY(1,1) NOT NULL,
	[Paterno] [varchar](50) NULL,
	[Materno] [varchar](50) NULL,
	[Nombres] [varchar](50) NULL,
	[Direccion] [varchar](100) NULL,
	[Email] [varchar](100) NULL,
	[FechaNacimiento] [datetime] NULL,
	[NroDocumento] [int] NULL,
	[foto] [varchar](1000) NULL,
	[doc] [varchar](1000) NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[CodPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Protagonista]    Script Date: 30/06/2017 00:00:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Protagonista](
	[CodInterprete] [int] NOT NULL,
	[CodPelicula] [int] NOT NULL,
	[NombreProtagonista] [varchar](500) NULL,
	[EsPrincipal] [bit] NULL,
 CONSTRAINT [PK_Protagonista] PRIMARY KEY CLUSTERED 
(
	[CodInterprete] ASC,
	[CodPelicula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sala]    Script Date: 30/06/2017 00:00:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sala](
	[CodSala] [int] IDENTITY(1,1) NOT NULL,
	[NombreSala] [varchar](100) NULL,
	[Capacidad] [int] NULL,
	[Tipo] [varchar](20) NULL,
	[CodCine] [int] NULL,
 CONSTRAINT [PK_Sala] PRIMARY KEY CLUSTERED 
(
	[CodSala] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ticket]    Script Date: 30/06/2017 00:00:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ticket](
	[CodTicket] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[CodAsiento] [int] NULL,
	[CodPersona] [int] NULL,
	[CodFuncion] [int] NULL,
 CONSTRAINT [PK_Ticket] PRIMARY KEY CLUSTERED 
(
	[CodTicket] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Asiento] ON 

GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (1, N'A1', 1, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (2, N'A2', 1, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (3, N'A3', 1, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (4, N'A4', 1, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (5, N'A5', 1, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (6, N'A6', 1, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (7, N'A7', 1, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (8, N'A8', 1, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (9, N'A9', 1, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (10, N'A10', 1, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (11, N'A11', 1, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (12, N'A12', 1, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (13, N'A13', 1, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (14, N'A14', 1, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (15, N'A15', 1, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (16, N'A1', 2, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (17, N'A2', 2, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (18, N'A3', 2, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (19, N'A4', 2, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (20, N'A5', 2, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (21, N'A6', 2, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (22, N'A7', 2, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (23, N'A8', 2, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (24, N'A9', 2, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (25, N'A10', 2, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (26, N'B1', 2, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (27, N'B2', 2, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (28, N'B3', 2, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (29, N'B4', 2, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (30, N'B5', 2, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (31, N'B6', 2, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (32, N'B7', 2, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (33, N'B8', 2, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (34, N'B9', 2, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (35, N'B10', 2, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (36, N'A1', 3, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (37, N'A2', 3, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (38, N'A3', 3, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (39, N'A4', 3, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (40, N'A5', 3, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (41, N'A6', 3, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (42, N'A7', 3, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (43, N'A8', 3, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (44, N'A9', 3, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (45, N'A10', 3, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (46, N'B1', 3, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (47, N'B2', 3, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (48, N'B3', 3, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (49, N'B4', 3, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (50, N'B5', 3, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (51, N'B6', 3, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (52, N'B7', 3, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (53, N'B8', 3, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (54, N'B9', 3, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (55, N'B10', 3, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (56, N'A1', 4, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (57, N'A2', 4, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (58, N'A3', 4, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (59, N'A4', 4, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (60, N'A5', 4, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (61, N'A6', 4, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (62, N'A7', 4, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (63, N'A8', 4, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (64, N'A9', 4, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (65, N'A10', 4, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (66, N'B1', 4, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (67, N'B2', 4, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (68, N'B3', 4, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (69, N'B4', 4, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (70, N'B5', 4, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (71, N'B6', 4, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (72, N'B7', 4, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (73, N'B8', 4, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (74, N'B9', 4, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (75, N'B10', 4, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (76, N'A1', 5, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (77, N'A2', 5, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (78, N'A3', 5, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (79, N'A4', 5, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (80, N'A5', 5, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (81, N'A6', 5, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (82, N'A7', 5, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (83, N'A8', 5, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (84, N'A9', 5, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (85, N'A10', 5, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (86, N'B1', 5, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (87, N'B2', 5, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (88, N'B3', 5, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (89, N'B4', 5, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (90, N'B5', 5, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (91, N'B6', 5, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (92, N'B7', 5, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (93, N'B8', 5, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (94, N'B9', 5, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (95, N'B10', 5, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (96, N'A1', 6, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (97, N'A2', 6, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (98, N'A3', 6, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (99, N'A4', 6, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (100, N'A5', 6, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (101, N'A6', 6, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (102, N'A7', 6, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (103, N'A8', 6, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (104, N'A9', 6, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (105, N'A10', 6, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (106, N'B1', 6, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (107, N'B2', 6, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (108, N'B3', 6, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (109, N'B4', 6, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (110, N'B5', 6, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (111, N'B6', 6, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (112, N'B7', 6, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (113, N'B8', 6, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (114, N'B9', 6, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (115, N'B10', 6, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (116, N'A1', 7, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (117, N'A2', 7, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (118, N'A3', 7, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (119, N'A4', 7, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (120, N'A5', 7, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (121, N'A6', 7, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (122, N'A7', 7, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (123, N'A8', 7, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (124, N'A9', 7, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (125, N'A10', 7, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (126, N'B1', 7, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (127, N'B2', 7, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (128, N'B3', 7, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (129, N'B4', 7, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (130, N'B5', 7, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (131, N'B6', 7, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (132, N'B7', 7, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (133, N'B8', 7, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (134, N'B9', 7, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (135, N'B10', 7, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (136, N'A1', 8, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (137, N'A2', 8, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (138, N'A3', 8, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (139, N'A4', 8, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (140, N'A5', 8, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (141, N'A6', 8, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (142, N'A7', 8, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (143, N'A8', 8, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (144, N'A9', 8, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (145, N'A10', 8, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (146, N'B1', 8, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (147, N'B2', 8, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (148, N'B3', 8, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (149, N'B4', 8, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (150, N'B5', 8, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (151, N'B6', 8, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (152, N'B7', 8, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (153, N'B8', 8, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (154, N'B9', 8, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (155, N'B10', 8, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (156, N'A1', 9, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (157, N'A2', 9, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (158, N'A3', 9, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (159, N'A4', 9, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (160, N'A5', 9, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (161, N'A6', 9, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (162, N'A7', 9, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (163, N'A8', 9, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (164, N'A9', 9, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (165, N'A10', 9, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (166, N'B1', 9, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (167, N'B2', 9, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (168, N'B3', 9, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (169, N'B4', 9, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (170, N'B5', 9, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (171, N'B6', 9, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (172, N'B7', 9, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (173, N'B8', 9, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (174, N'B9', 9, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (175, N'B10', 9, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (176, N'A1', 10, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (177, N'A2', 10, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (178, N'A3', 10, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (179, N'A4', 10, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (180, N'A5', 10, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (181, N'A6', 10, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (182, N'A7', 10, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (183, N'A8', 10, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (184, N'A9', 10, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (185, N'A10', 10, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (186, N'B1', 10, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (187, N'B2', 10, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (188, N'B3', 10, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (189, N'B4', 10, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (190, N'B5', 10, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (191, N'B6', 10, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (192, N'B7', 10, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (193, N'B8', 10, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (194, N'B9', 10, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (195, N'B10', 10, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (196, N'A1', 11, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (197, N'A2', 11, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (198, N'A3', 11, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (199, N'A4', 11, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (200, N'A5', 11, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (201, N'A6', 11, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (202, N'A7', 11, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (203, N'A8', 11, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (204, N'A9', 11, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (205, N'A10', 11, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (206, N'B1', 11, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (207, N'B2', 11, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (208, N'B3', 11, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (209, N'B4', 11, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (210, N'B5', 11, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (211, N'B6', 11, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (212, N'B7', 11, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (213, N'B8', 11, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (214, N'B9', 11, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (215, N'B10', 11, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (216, N'A1', 12, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (217, N'A2', 12, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (218, N'A3', 12, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (219, N'A4', 12, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (220, N'A5', 12, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (221, N'A6', 12, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (222, N'A7', 12, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (223, N'A8', 12, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (224, N'A9', 12, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (225, N'A10', 12, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (226, N'B1', 12, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (227, N'B2', 12, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (228, N'B3', 12, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (229, N'B4', 12, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (230, N'B5', 12, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (231, N'B6', 12, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (232, N'B7', 12, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (233, N'B8', 12, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (234, N'B9', 12, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (235, N'B10', 12, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (236, N'A1', 13, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (237, N'A2', 13, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (238, N'A3', 13, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (239, N'A4', 13, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (240, N'A5', 13, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (241, N'A6', 13, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (242, N'A7', 13, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (243, N'A8', 13, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (244, N'A9', 13, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (245, N'A10', 13, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (246, N'B1', 13, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (247, N'B2', 13, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (248, N'B3', 13, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (249, N'B4', 13, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (250, N'B5', 13, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (251, N'B6', 13, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (252, N'B7', 13, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (253, N'B8', 13, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (254, N'B9', 13, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (255, N'B10', 13, 1, 0)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (256, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (257, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (258, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (259, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (260, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (261, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (262, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (263, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (264, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (265, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (266, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (267, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (268, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (269, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (270, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (271, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (272, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (273, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (274, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Asiento] ([CodAsiento], [DescripcionAsiento], [CodSala], [TipoAsiento], [Disponible]) VALUES (275, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Asiento] OFF
GO
SET IDENTITY_INSERT [dbo].[Cine] ON 

GO
INSERT [dbo].[Cine] ([CodCine], [NombreCine], [Direccion]) VALUES (1, N'Cine Primavera', N'Av. Primavera 345')
GO
INSERT [dbo].[Cine] ([CodCine], [NombreCine], [Direccion]) VALUES (2, N'Cine América', N'Av. Brasil 4577')
GO
INSERT [dbo].[Cine] ([CodCine], [NombreCine], [Direccion]) VALUES (3, N'Cine Rambla', N'Av. San Borja 3345')
GO
SET IDENTITY_INSERT [dbo].[Cine] OFF
GO
INSERT [dbo].[CinePelicula] ([CodCine], [CodPelicula], [EnCartelera]) VALUES (1, 1, 1)
GO
INSERT [dbo].[CinePelicula] ([CodCine], [CodPelicula], [EnCartelera]) VALUES (1, 2, 1)
GO
INSERT [dbo].[CinePelicula] ([CodCine], [CodPelicula], [EnCartelera]) VALUES (1, 3, 1)
GO
INSERT [dbo].[CinePelicula] ([CodCine], [CodPelicula], [EnCartelera]) VALUES (1, 4, 1)
GO
INSERT [dbo].[CinePelicula] ([CodCine], [CodPelicula], [EnCartelera]) VALUES (1, 5, 1)
GO
INSERT [dbo].[CinePelicula] ([CodCine], [CodPelicula], [EnCartelera]) VALUES (1, 6, 1)
GO
INSERT [dbo].[CinePelicula] ([CodCine], [CodPelicula], [EnCartelera]) VALUES (1, 7, 1)
GO
INSERT [dbo].[CinePelicula] ([CodCine], [CodPelicula], [EnCartelera]) VALUES (1, 8, 1)
GO
INSERT [dbo].[CinePelicula] ([CodCine], [CodPelicula], [EnCartelera]) VALUES (1, 9, 0)
GO
INSERT [dbo].[CinePelicula] ([CodCine], [CodPelicula], [EnCartelera]) VALUES (1, 10, 0)
GO
INSERT [dbo].[CinePelicula] ([CodCine], [CodPelicula], [EnCartelera]) VALUES (2, 1, 1)
GO
INSERT [dbo].[CinePelicula] ([CodCine], [CodPelicula], [EnCartelera]) VALUES (2, 2, 1)
GO
INSERT [dbo].[CinePelicula] ([CodCine], [CodPelicula], [EnCartelera]) VALUES (2, 3, 1)
GO
INSERT [dbo].[CinePelicula] ([CodCine], [CodPelicula], [EnCartelera]) VALUES (2, 4, 1)
GO
INSERT [dbo].[CinePelicula] ([CodCine], [CodPelicula], [EnCartelera]) VALUES (2, 5, 1)
GO
INSERT [dbo].[CinePelicula] ([CodCine], [CodPelicula], [EnCartelera]) VALUES (2, 6, 1)
GO
INSERT [dbo].[CinePelicula] ([CodCine], [CodPelicula], [EnCartelera]) VALUES (2, 7, 1)
GO
INSERT [dbo].[CinePelicula] ([CodCine], [CodPelicula], [EnCartelera]) VALUES (2, 8, 1)
GO
INSERT [dbo].[CinePelicula] ([CodCine], [CodPelicula], [EnCartelera]) VALUES (2, 9, 0)
GO
INSERT [dbo].[CinePelicula] ([CodCine], [CodPelicula], [EnCartelera]) VALUES (2, 10, 0)
GO
INSERT [dbo].[CinePelicula] ([CodCine], [CodPelicula], [EnCartelera]) VALUES (3, 1, 1)
GO
INSERT [dbo].[CinePelicula] ([CodCine], [CodPelicula], [EnCartelera]) VALUES (3, 2, 1)
GO
INSERT [dbo].[CinePelicula] ([CodCine], [CodPelicula], [EnCartelera]) VALUES (3, 3, 1)
GO
INSERT [dbo].[CinePelicula] ([CodCine], [CodPelicula], [EnCartelera]) VALUES (3, 4, 1)
GO
INSERT [dbo].[CinePelicula] ([CodCine], [CodPelicula], [EnCartelera]) VALUES (3, 5, 1)
GO
INSERT [dbo].[CinePelicula] ([CodCine], [CodPelicula], [EnCartelera]) VALUES (3, 6, 1)
GO
INSERT [dbo].[CinePelicula] ([CodCine], [CodPelicula], [EnCartelera]) VALUES (3, 7, 1)
GO
INSERT [dbo].[CinePelicula] ([CodCine], [CodPelicula], [EnCartelera]) VALUES (3, 8, 1)
GO
INSERT [dbo].[CinePelicula] ([CodCine], [CodPelicula], [EnCartelera]) VALUES (3, 9, 0)
GO
INSERT [dbo].[CinePelicula] ([CodCine], [CodPelicula], [EnCartelera]) VALUES (3, 10, 0)
GO
SET IDENTITY_INSERT [dbo].[Director] ON 

GO
INSERT [dbo].[Director] ([CodDirector], [NombreDirector]) VALUES (1, N'ZACK SNYDER')
GO
INSERT [dbo].[Director] ([CodDirector], [NombreDirector]) VALUES (2, N'KEVIN REYNOLDS')
GO
INSERT [dbo].[Director] ([CodDirector], [NombreDirector]) VALUES (3, N'KIRK JONES')
GO
INSERT [dbo].[Director] ([CodDirector], [NombreDirector]) VALUES (4, N'KHEIRON ')
GO
INSERT [dbo].[Director] ([CodDirector], [NombreDirector]) VALUES (5, N'HIROKAZU KOREEDA')
GO
INSERT [dbo].[Director] ([CodDirector], [NombreDirector]) VALUES (6, N'DANI DE LA ORDEN')
GO
INSERT [dbo].[Director] ([CodDirector], [NombreDirector]) VALUES (7, N'LOUIS LETERRIER')
GO
INSERT [dbo].[Director] ([CodDirector], [NombreDirector]) VALUES (8, N'JOCELYN MOORHOUSE')
GO
INSERT [dbo].[Director] ([CodDirector], [NombreDirector]) VALUES (9, N'DAN TRACHTENBERG')
GO
INSERT [dbo].[Director] ([CodDirector], [NombreDirector]) VALUES (10, N'NULJOEL EDGERTONL')
GO
INSERT [dbo].[Director] ([CodDirector], [NombreDirector]) VALUES (11, N'JUSTIN LIN')
GO
SET IDENTITY_INSERT [dbo].[Director] OFF
GO
SET IDENTITY_INSERT [dbo].[Funcion] ON 

GO
INSERT [dbo].[Funcion] ([CodFuncion], [HoraInicio], [HoraFin], [CodPelicula], [FechaFuncion], [Precio]) VALUES (1, CAST(0x0000A73400F73140 AS DateTime), CAST(0x0000A7340130DEE0 AS DateTime), 1, CAST(0x0000A73400000000 AS DateTime), CAST(12.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Funcion] ([CodFuncion], [HoraInicio], [HoraFin], [CodPelicula], [FechaFuncion], [Precio]) VALUES (2, CAST(0x0000A73401391C40 AS DateTime), CAST(0x0000A7340172C9E0 AS DateTime), 1, CAST(0x0000A73400000000 AS DateTime), CAST(12.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Funcion] ([CodFuncion], [HoraInicio], [HoraFin], [CodPelicula], [FechaFuncion], [Precio]) VALUES (3, CAST(0x0000A73501391C40 AS DateTime), CAST(0x0000A735015A11C0 AS DateTime), 2, CAST(0x0000A73500000000 AS DateTime), CAST(10.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Funcion] ([CodFuncion], [HoraInicio], [HoraFin], [CodPelicula], [FechaFuncion], [Precio]) VALUES (4, CAST(0x0000A735015A11C0 AS DateTime), CAST(0x0000A735017B0740 AS DateTime), 2, CAST(0x0000A73500000000 AS DateTime), CAST(10.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Funcion] ([CodFuncion], [HoraInicio], [HoraFin], [CodPelicula], [FechaFuncion], [Precio]) VALUES (5, CAST(0x0000A73600E6B680 AS DateTime), CAST(0x0000A7360107AC00 AS DateTime), 3, CAST(0x0000A73600000000 AS DateTime), CAST(11.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Funcion] ([CodFuncion], [HoraInicio], [HoraFin], [CodPelicula], [FechaFuncion], [Precio]) VALUES (6, CAST(0x0000A736010FE960 AS DateTime), CAST(0x0000A7360130DEE0 AS DateTime), 3, CAST(0x0000A73600000000 AS DateTime), CAST(11.50 AS Decimal(18, 2)))
GO
INSERT [dbo].[Funcion] ([CodFuncion], [HoraInicio], [HoraFin], [CodPelicula], [FechaFuncion], [Precio]) VALUES (7, CAST(0x0000A737010FE960 AS DateTime), CAST(0x0000A7370130DEE0 AS DateTime), 4, CAST(0x0000A73700000000 AS DateTime), CAST(12.50 AS Decimal(18, 2)))
GO
INSERT [dbo].[Funcion] ([CodFuncion], [HoraInicio], [HoraFin], [CodPelicula], [FechaFuncion], [Precio]) VALUES (8, CAST(0x0000A7370130DEE0 AS DateTime), CAST(0x0000A7370151D460 AS DateTime), 5, CAST(0x0000A73700000000 AS DateTime), CAST(12.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Funcion] ([CodFuncion], [HoraInicio], [HoraFin], [CodPelicula], [FechaFuncion], [Precio]) VALUES (9, CAST(0x0000A73800FF6EA0 AS DateTime), CAST(0x0000A7380130DEE0 AS DateTime), 6, CAST(0x0000A73800000000 AS DateTime), CAST(10.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Funcion] ([CodFuncion], [HoraInicio], [HoraFin], [CodPelicula], [FechaFuncion], [Precio]) VALUES (10, CAST(0x0000A73900FF6EA0 AS DateTime), CAST(0x0000A7390130DEE0 AS DateTime), 7, CAST(0x0000A73900000000 AS DateTime), CAST(12.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Funcion] ([CodFuncion], [HoraInicio], [HoraFin], [CodPelicula], [FechaFuncion], [Precio]) VALUES (11, CAST(0x0000A73A00FF6EA0 AS DateTime), CAST(0x0000A73A0130DEE0 AS DateTime), 8, CAST(0x0000A7390130DEE0 AS DateTime), CAST(14.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Funcion] ([CodFuncion], [HoraInicio], [HoraFin], [CodPelicula], [FechaFuncion], [Precio]) VALUES (12, CAST(0x0000A73A0130DEE0 AS DateTime), CAST(0x0000A73A01624F20 AS DateTime), 8, CAST(0x0000A73A00000000 AS DateTime), CAST(14.00 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[Funcion] OFF
GO
SET IDENTITY_INSERT [dbo].[Interprete] ON 

GO
INSERT [dbo].[Interprete] ([CodInterprete], [Paterno], [Materno], [Nombres], [Nacionalidad], [Foto], [Bio]) VALUES (1, N'Cavill', NULL, N'Henry', N'EE.UU.', NULL, NULL)
GO
INSERT [dbo].[Interprete] ([CodInterprete], [Paterno], [Materno], [Nombres], [Nacionalidad], [Foto], [Bio]) VALUES (2, N'Adams', NULL, N'Amy', N'EE.UU.', NULL, NULL)
GO
INSERT [dbo].[Interprete] ([CodInterprete], [Paterno], [Materno], [Nombres], [Nacionalidad], [Foto], [Bio]) VALUES (3, N'Fiennes', NULL, N'Joseph', N'EE.UU.', NULL, NULL)
GO
INSERT [dbo].[Interprete] ([CodInterprete], [Paterno], [Materno], [Nombres], [Nacionalidad], [Foto], [Bio]) VALUES (4, N'Felton', NULL, N'Tom', N'EE.UU.', NULL, NULL)
GO
INSERT [dbo].[Interprete] ([CodInterprete], [Paterno], [Materno], [Nombres], [Nacionalidad], [Foto], [Bio]) VALUES (5, N'Vardalos', NULL, N'Nia', N'EE.UU.', NULL, NULL)
GO
INSERT [dbo].[Interprete] ([CodInterprete], [Paterno], [Materno], [Nombres], [Nacionalidad], [Foto], [Bio]) VALUES (6, N'Corbett', NULL, N'Nia', N'EE.UU.', NULL, NULL)
GO
INSERT [dbo].[Interprete] ([CodInterprete], [Paterno], [Materno], [Nombres], [Nacionalidad], [Foto], [Bio]) VALUES (7, N'Bekhti', NULL, N'Leila', N'EE.UU.', NULL, NULL)
GO
INSERT [dbo].[Interprete] ([CodInterprete], [Paterno], [Materno], [Nombres], [Nacionalidad], [Foto], [Bio]) VALUES (8, N'Darmon', NULL, N'Gerard', N'Rusia', NULL, NULL)
GO
INSERT [dbo].[Interprete] ([CodInterprete], [Paterno], [Materno], [Nombres], [Nacionalidad], [Foto], [Bio]) VALUES (9, N'Ayase', NULL, N'Haruka', N'Japón', NULL, NULL)
GO
INSERT [dbo].[Interprete] ([CodInterprete], [Paterno], [Materno], [Nombres], [Nacionalidad], [Foto], [Bio]) VALUES (10, N'Masami ', NULL, N'Nagasawa', N'Japón', NULL, NULL)
GO
INSERT [dbo].[Interprete] ([CodInterprete], [Paterno], [Materno], [Nombres], [Nacionalidad], [Foto], [Bio]) VALUES (11, N'Romero', NULL, N'Berto', N'Brasil', NULL, NULL)
GO
INSERT [dbo].[Interprete] ([CodInterprete], [Paterno], [Materno], [Nombres], [Nacionalidad], [Foto], [Bio]) VALUES (12, N'Buenafuente', NULL, N'Andreu', N'Brasil', NULL, NULL)
GO
INSERT [dbo].[Interprete] ([CodInterprete], [Paterno], [Materno], [Nombres], [Nacionalidad], [Foto], [Bio]) VALUES (13, N'Baron', N'Cohen', N'Sacha', N'Italia', NULL, NULL)
GO
INSERT [dbo].[Interprete] ([CodInterprete], [Paterno], [Materno], [Nombres], [Nacionalidad], [Foto], [Bio]) VALUES (14, N'Fisher', NULL, N'Isla', N'Venezuela', NULL, NULL)
GO
INSERT [dbo].[Interprete] ([CodInterprete], [Paterno], [Materno], [Nombres], [Nacionalidad], [Foto], [Bio]) VALUES (15, N'Winslet', NULL, N'Kate', N'EE.UU.', NULL, NULL)
GO
INSERT [dbo].[Interprete] ([CodInterprete], [Paterno], [Materno], [Nombres], [Nacionalidad], [Foto], [Bio]) VALUES (16, N'Hemsworth', NULL, N'Liam', N'EE.UU.', NULL, NULL)
GO
INSERT [dbo].[Interprete] ([CodInterprete], [Paterno], [Materno], [Nombres], [Nacionalidad], [Foto], [Bio]) VALUES (17, N'Winstead', N'Elizabeth', N'Mary', N'EE.UU.', NULL, NULL)
GO
INSERT [dbo].[Interprete] ([CodInterprete], [Paterno], [Materno], [Nombres], [Nacionalidad], [Foto], [Bio]) VALUES (18, N'Goodman', NULL, N'Jhon', N'EE.UU.', NULL, NULL)
GO
INSERT [dbo].[Interprete] ([CodInterprete], [Paterno], [Materno], [Nombres], [Nacionalidad], [Foto], [Bio]) VALUES (19, N'Bateman', NULL, N'Jason', N'EE.UU.', NULL, NULL)
GO
INSERT [dbo].[Interprete] ([CodInterprete], [Paterno], [Materno], [Nombres], [Nacionalidad], [Foto], [Bio]) VALUES (20, N'Hall', NULL, N'Rebeca', N'EE.UU.', NULL, NULL)
GO
INSERT [dbo].[Interprete] ([CodInterprete], [Paterno], [Materno], [Nombres], [Nacionalidad], [Foto], [Bio]) VALUES (21, N'Diesel', NULL, N'Vin', N'EE.UU.', N'Vin_Diesel.jpg', N'http://www.imdb.com/name/nm0004874/bio?ref_=nm_ov_bio_sm')
GO
INSERT [dbo].[Interprete] ([CodInterprete], [Paterno], [Materno], [Nombres], [Nacionalidad], [Foto], [Bio]) VALUES (22, N'Walker', NULL, N'Paul', N'EE.UU.', N'Paul_Walker.jpg', N'http://www.imdb.com/name/nm0908094/bio?ref_=nm_ov_bio_sm')
GO
INSERT [dbo].[Interprete] ([CodInterprete], [Paterno], [Materno], [Nombres], [Nacionalidad], [Foto], [Bio]) VALUES (23, N'Rodriguez', NULL, N'Michelle', N'EE.UU.', N'Michelle_Rodriguez.jpg', N'http://www.imdb.com/name/nm0735442/bio?ref_=nm_ov_bio_sm')
GO
INSERT [dbo].[Interprete] ([CodInterprete], [Paterno], [Materno], [Nombres], [Nacionalidad], [Foto], [Bio]) VALUES (24, N'Brewster', NULL, N'Jordana', N'Panamá', N'Jordana_Brewster.jpg', N'http://www.imdb.com/name/nm0108287/bio?ref_=nm_ov_bio_sm')
GO
INSERT [dbo].[Interprete] ([CodInterprete], [Paterno], [Materno], [Nombres], [Nacionalidad], [Foto], [Bio]) VALUES (25, N'Gadot', NULL, N'Gal', N'Israel', N'Gal_Gadot.jpg', N'http://www.imdb.com/name/nm2933757/bio?ref_=nm_ov_bio_sm')
GO
INSERT [dbo].[Interprete] ([CodInterprete], [Paterno], [Materno], [Nombres], [Nacionalidad], [Foto], [Bio]) VALUES (26, N'Kang', NULL, N'Sung', N'Japón', N'Sung_Kang.jpg', N'http://www.imdb.com/name/nm0437646/bio?ref_=nm_ov_bio_sm')
GO
INSERT [dbo].[Interprete] ([CodInterprete], [Paterno], [Materno], [Nombres], [Nacionalidad], [Foto], [Bio]) VALUES (27, N'Yune', NULL, N'Rick', N'EE.UU.', N'Rick_Yune.jpg', N'http://www.imdb.com/name/nm0950935/bio?ref_=nm_ov_bio_sm')
GO
SET IDENTITY_INSERT [dbo].[Interprete] OFF
GO
INSERT [dbo].[Pedido] ([CodPedido], [Descripcion], [CodTicket]) VALUES (1, N'Pedido', 1)
GO
INSERT [dbo].[Pedido] ([CodPedido], [Descripcion], [CodTicket]) VALUES (2, N'Pedido', 2)
GO
INSERT [dbo].[Pedido] ([CodPedido], [Descripcion], [CodTicket]) VALUES (3, N'Pedido', 3)
GO
INSERT [dbo].[Pedido] ([CodPedido], [Descripcion], [CodTicket]) VALUES (4, N'Pedido', 4)
GO
INSERT [dbo].[Pedido] ([CodPedido], [Descripcion], [CodTicket]) VALUES (5, N'Pedido', 5)
GO
INSERT [dbo].[Pedido] ([CodPedido], [Descripcion], [CodTicket]) VALUES (6, N'Pedido', 6)
GO
INSERT [dbo].[Pedido] ([CodPedido], [Descripcion], [CodTicket]) VALUES (7, N'Pedido', 7)
GO
INSERT [dbo].[Pedido] ([CodPedido], [Descripcion], [CodTicket]) VALUES (8, N'Pedido', 8)
GO
INSERT [dbo].[Pedido] ([CodPedido], [Descripcion], [CodTicket]) VALUES (9, N'Pedido', 9)
GO
INSERT [dbo].[Pedido] ([CodPedido], [Descripcion], [CodTicket]) VALUES (10, N'Pedido', 10)
GO
INSERT [dbo].[Pedido] ([CodPedido], [Descripcion], [CodTicket]) VALUES (11, N'Pedido', 11)
GO
SET IDENTITY_INSERT [dbo].[Pelicula] ON 

GO
INSERT [dbo].[Pelicula] ([CodPelicula], [NombrePelicula], [Duracion], [FechaEstreno], [CodDirector]) VALUES (1, N'Batman vs Superman', N'142', CAST(0x0000A5D200000000 AS DateTime), 1)
GO
INSERT [dbo].[Pelicula] ([CodPelicula], [NombrePelicula], [Duracion], [FechaEstreno], [CodDirector]) VALUES (2, N'Resucitado', N'111', CAST(0x0000A5B100000000 AS DateTime), 2)
GO
INSERT [dbo].[Pelicula] ([CodPelicula], [NombrePelicula], [Duracion], [FechaEstreno], [CodDirector]) VALUES (3, N'Mi gran boda gringa', N'111', CAST(0x0000A5D200000000 AS DateTime), 3)
GO
INSERT [dbo].[Pelicula] ([CodPelicula], [NombrePelicula], [Duracion], [FechaEstreno], [CodDirector]) VALUES (4, N'O los tres o ninguno', N'102', CAST(0x0000A5D200000000 AS DateTime), 4)
GO
INSERT [dbo].[Pelicula] ([CodPelicula], [NombrePelicula], [Duracion], [FechaEstreno], [CodDirector]) VALUES (5, N'Destino final', N'128', CAST(0x0000A5D200000000 AS DateTime), 5)
GO
INSERT [dbo].[Pelicula] ([CodPelicula], [NombrePelicula], [Duracion], [FechaEstreno], [CodDirector]) VALUES (6, N'El pregón', N'101', CAST(0x0000A5CD00000000 AS DateTime), 6)
GO
INSERT [dbo].[Pelicula] ([CodPelicula], [NombrePelicula], [Duracion], [FechaEstreno], [CodDirector]) VALUES (7, N'Agente contrainteligente', N'99', CAST(0x0000A5CD00000000 AS DateTime), 7)
GO
INSERT [dbo].[Pelicula] ([CodPelicula], [NombrePelicula], [Duracion], [FechaEstreno], [CodDirector]) VALUES (8, N'La modista', N'118', CAST(0x0000A5CD00000000 AS DateTime), 8)
GO
INSERT [dbo].[Pelicula] ([CodPelicula], [NombrePelicula], [Duracion], [FechaEstreno], [CodDirector]) VALUES (9, N'10 CLOVERFIELD LANE', N'112', CAST(0x0000A5C600000000 AS DateTime), 9)
GO
INSERT [dbo].[Pelicula] ([CodPelicula], [NombrePelicula], [Duracion], [FechaEstreno], [CodDirector]) VALUES (10, N'Misión final', N'103', CAST(0x0000A5CD00000000 AS DateTime), 10)
GO
INSERT [dbo].[Pelicula] ([CodPelicula], [NombrePelicula], [Duracion], [FechaEstreno], [CodDirector]) VALUES (11, N'Fast & Furious', N'145', CAST(0x0000A41300000000 AS DateTime), 11)
GO
SET IDENTITY_INSERT [dbo].[Pelicula] OFF
GO
SET IDENTITY_INSERT [dbo].[Persona] ON 

GO
INSERT [dbo].[Persona] ([CodPersona], [Paterno], [Materno], [Nombres], [Direccion], [Email], [FechaNacimiento], [NroDocumento], [foto], [doc]) VALUES (1, N'Moya ', N'Morales', N'Yulisa', N'Jr. Lampa 345', N'moya@gmail.com', CAST(0x00007E8C00000000 AS DateTime), 23543467, N'23543467.jpg', NULL)
GO
INSERT [dbo].[Persona] ([CodPersona], [Paterno], [Materno], [Nombres], [Direccion], [Email], [FechaNacimiento], [NroDocumento], [foto], [doc]) VALUES (2, N'Lazo', N'Palacios', N'Wily', N'Jr. Jose Galvez 760', N'lazo@gmail.com', CAST(0x00007FF900000000 AS DateTime), 89675645, N'89675645.jpg', NULL)
GO
INSERT [dbo].[Persona] ([CodPersona], [Paterno], [Materno], [Nombres], [Direccion], [Email], [FechaNacimiento], [NroDocumento], [foto], [doc]) VALUES (3, N'Ramos', N'Cordova', N'Henry', N'Calle Santa Isabel', N'ramos@gmail.com', CAST(0x0000805400000000 AS DateTime), 23546789, N'23546789.jpg', NULL)
GO
INSERT [dbo].[Persona] ([CodPersona], [Paterno], [Materno], [Nombres], [Direccion], [Email], [FechaNacimiento], [NroDocumento], [foto], [doc]) VALUES (4, N'Salas', N'Aliaga', N'Zulema', N'Calle San Martin 456', N'salas@gmail.com', CAST(0x0000722E00000000 AS DateTime), 35578548, N'35578548.jpg', NULL)
GO
INSERT [dbo].[Persona] ([CodPersona], [Paterno], [Materno], [Nombres], [Direccion], [Email], [FechaNacimiento], [NroDocumento], [foto], [doc]) VALUES (5, N'Velazques', N'Martinez', N'Angie', N'Av. Proceres 3456', N'velazques@gmail.com', CAST(0x000082D300000000 AS DateTime), 34352787, N'34352787.jpg', NULL)
GO
INSERT [dbo].[Persona] ([CodPersona], [Paterno], [Materno], [Nombres], [Direccion], [Email], [FechaNacimiento], [NroDocumento], [foto], [doc]) VALUES (6, N'Turbio', N'Farje', N'Milagros', N'Calle Amazonas 456', N'turbio@gmail.com', CAST(0x00007FF900000000 AS DateTime), 34567789, N'34567789.jpg', NULL)
GO
INSERT [dbo].[Persona] ([CodPersona], [Paterno], [Materno], [Nombres], [Direccion], [Email], [FechaNacimiento], [NroDocumento], [foto], [doc]) VALUES (7, N'Escobar', N'Martinez', N'Pablo', N'Av. Sucre 3455', N'escobar@gmail.com', CAST(0x00007FF900000000 AS DateTime), 23456522, N'23456522.jpg', NULL)
GO
SET IDENTITY_INSERT [dbo].[Persona] OFF
GO
INSERT [dbo].[Protagonista] ([CodInterprete], [CodPelicula], [NombreProtagonista], [EsPrincipal]) VALUES (1, 1, NULL, NULL)
GO
INSERT [dbo].[Protagonista] ([CodInterprete], [CodPelicula], [NombreProtagonista], [EsPrincipal]) VALUES (2, 1, NULL, NULL)
GO
INSERT [dbo].[Protagonista] ([CodInterprete], [CodPelicula], [NombreProtagonista], [EsPrincipal]) VALUES (3, 2, NULL, NULL)
GO
INSERT [dbo].[Protagonista] ([CodInterprete], [CodPelicula], [NombreProtagonista], [EsPrincipal]) VALUES (4, 2, NULL, NULL)
GO
INSERT [dbo].[Protagonista] ([CodInterprete], [CodPelicula], [NombreProtagonista], [EsPrincipal]) VALUES (5, 3, NULL, NULL)
GO
INSERT [dbo].[Protagonista] ([CodInterprete], [CodPelicula], [NombreProtagonista], [EsPrincipal]) VALUES (6, 3, NULL, NULL)
GO
INSERT [dbo].[Protagonista] ([CodInterprete], [CodPelicula], [NombreProtagonista], [EsPrincipal]) VALUES (7, 4, NULL, NULL)
GO
INSERT [dbo].[Protagonista] ([CodInterprete], [CodPelicula], [NombreProtagonista], [EsPrincipal]) VALUES (8, 4, NULL, NULL)
GO
INSERT [dbo].[Protagonista] ([CodInterprete], [CodPelicula], [NombreProtagonista], [EsPrincipal]) VALUES (9, 5, NULL, NULL)
GO
INSERT [dbo].[Protagonista] ([CodInterprete], [CodPelicula], [NombreProtagonista], [EsPrincipal]) VALUES (10, 5, NULL, NULL)
GO
INSERT [dbo].[Protagonista] ([CodInterprete], [CodPelicula], [NombreProtagonista], [EsPrincipal]) VALUES (11, 6, NULL, NULL)
GO
INSERT [dbo].[Protagonista] ([CodInterprete], [CodPelicula], [NombreProtagonista], [EsPrincipal]) VALUES (12, 6, NULL, NULL)
GO
INSERT [dbo].[Protagonista] ([CodInterprete], [CodPelicula], [NombreProtagonista], [EsPrincipal]) VALUES (13, 7, NULL, NULL)
GO
INSERT [dbo].[Protagonista] ([CodInterprete], [CodPelicula], [NombreProtagonista], [EsPrincipal]) VALUES (14, 7, NULL, NULL)
GO
INSERT [dbo].[Protagonista] ([CodInterprete], [CodPelicula], [NombreProtagonista], [EsPrincipal]) VALUES (15, 8, NULL, NULL)
GO
INSERT [dbo].[Protagonista] ([CodInterprete], [CodPelicula], [NombreProtagonista], [EsPrincipal]) VALUES (16, 8, NULL, NULL)
GO
INSERT [dbo].[Protagonista] ([CodInterprete], [CodPelicula], [NombreProtagonista], [EsPrincipal]) VALUES (17, 9, NULL, NULL)
GO
INSERT [dbo].[Protagonista] ([CodInterprete], [CodPelicula], [NombreProtagonista], [EsPrincipal]) VALUES (18, 9, NULL, NULL)
GO
INSERT [dbo].[Protagonista] ([CodInterprete], [CodPelicula], [NombreProtagonista], [EsPrincipal]) VALUES (19, 10, NULL, NULL)
GO
INSERT [dbo].[Protagonista] ([CodInterprete], [CodPelicula], [NombreProtagonista], [EsPrincipal]) VALUES (20, 10, NULL, NULL)
GO
INSERT [dbo].[Protagonista] ([CodInterprete], [CodPelicula], [NombreProtagonista], [EsPrincipal]) VALUES (21, 11, N'Dominic Toretto', 1)
GO
INSERT [dbo].[Protagonista] ([CodInterprete], [CodPelicula], [NombreProtagonista], [EsPrincipal]) VALUES (22, 11, N'Brian O''Conner', 0)
GO
INSERT [dbo].[Protagonista] ([CodInterprete], [CodPelicula], [NombreProtagonista], [EsPrincipal]) VALUES (23, 11, N'Letty', 0)
GO
INSERT [dbo].[Protagonista] ([CodInterprete], [CodPelicula], [NombreProtagonista], [EsPrincipal]) VALUES (24, 11, N'Mia Toretto', 0)
GO
INSERT [dbo].[Protagonista] ([CodInterprete], [CodPelicula], [NombreProtagonista], [EsPrincipal]) VALUES (27, 11, N'Johnny Tran', 0)
GO
SET IDENTITY_INSERT [dbo].[Sala] ON 

GO
INSERT [dbo].[Sala] ([CodSala], [NombreSala], [Capacidad], [Tipo], [CodCine]) VALUES (1, N'Sala 1', 10, N'Normal', 1)
GO
INSERT [dbo].[Sala] ([CodSala], [NombreSala], [Capacidad], [Tipo], [CodCine]) VALUES (2, N'Sala 2', 25, N'Normal', 1)
GO
INSERT [dbo].[Sala] ([CodSala], [NombreSala], [Capacidad], [Tipo], [CodCine]) VALUES (3, N'Sala 3', 25, N'Normal', 1)
GO
INSERT [dbo].[Sala] ([CodSala], [NombreSala], [Capacidad], [Tipo], [CodCine]) VALUES (4, N'Sala 4', 25, N'Normal', 1)
GO
INSERT [dbo].[Sala] ([CodSala], [NombreSala], [Capacidad], [Tipo], [CodCine]) VALUES (5, N'Sala 5', 25, N'Normal', 1)
GO
INSERT [dbo].[Sala] ([CodSala], [NombreSala], [Capacidad], [Tipo], [CodCine]) VALUES (6, N'Sala 6', 25, N'Normal', 1)
GO
INSERT [dbo].[Sala] ([CodSala], [NombreSala], [Capacidad], [Tipo], [CodCine]) VALUES (7, N'Sala 1', 25, N'Normal', 2)
GO
INSERT [dbo].[Sala] ([CodSala], [NombreSala], [Capacidad], [Tipo], [CodCine]) VALUES (8, N'Sala 2', 25, N'Normal', 2)
GO
INSERT [dbo].[Sala] ([CodSala], [NombreSala], [Capacidad], [Tipo], [CodCine]) VALUES (9, N'Sala 3', 25, N'Normal', 2)
GO
INSERT [dbo].[Sala] ([CodSala], [NombreSala], [Capacidad], [Tipo], [CodCine]) VALUES (10, N'Sala 4', 25, N'Normal', 2)
GO
INSERT [dbo].[Sala] ([CodSala], [NombreSala], [Capacidad], [Tipo], [CodCine]) VALUES (11, N'Sala 1', 25, N'Normal', 3)
GO
INSERT [dbo].[Sala] ([CodSala], [NombreSala], [Capacidad], [Tipo], [CodCine]) VALUES (12, N'Sala 2', 25, N'Normal', 3)
GO
INSERT [dbo].[Sala] ([CodSala], [NombreSala], [Capacidad], [Tipo], [CodCine]) VALUES (13, N'Sala 3', 25, N'Normal', 3)
GO
SET IDENTITY_INSERT [dbo].[Sala] OFF
GO
SET IDENTITY_INSERT [dbo].[Ticket] ON 

GO
INSERT [dbo].[Ticket] ([CodTicket], [Descripcion], [CodAsiento], [CodPersona], [CodFuncion]) VALUES (1, N'Venta', 1, 1, 1)
GO
INSERT [dbo].[Ticket] ([CodTicket], [Descripcion], [CodAsiento], [CodPersona], [CodFuncion]) VALUES (2, N'Venta', 2, 2, 1)
GO
INSERT [dbo].[Ticket] ([CodTicket], [Descripcion], [CodAsiento], [CodPersona], [CodFuncion]) VALUES (3, N'Venta', 3, 3, 1)
GO
INSERT [dbo].[Ticket] ([CodTicket], [Descripcion], [CodAsiento], [CodPersona], [CodFuncion]) VALUES (4, N'Venta', 4, 4, 1)
GO
INSERT [dbo].[Ticket] ([CodTicket], [Descripcion], [CodAsiento], [CodPersona], [CodFuncion]) VALUES (5, N'Venta', 5, 6, 1)
GO
INSERT [dbo].[Ticket] ([CodTicket], [Descripcion], [CodAsiento], [CodPersona], [CodFuncion]) VALUES (6, N'Venta', 16, 1, 2)
GO
INSERT [dbo].[Ticket] ([CodTicket], [Descripcion], [CodAsiento], [CodPersona], [CodFuncion]) VALUES (7, N'Venta', 17, 2, 2)
GO
INSERT [dbo].[Ticket] ([CodTicket], [Descripcion], [CodAsiento], [CodPersona], [CodFuncion]) VALUES (8, N'Venta', 18, 3, 2)
GO
INSERT [dbo].[Ticket] ([CodTicket], [Descripcion], [CodAsiento], [CodPersona], [CodFuncion]) VALUES (9, N'Venta', 19, 4, 2)
GO
INSERT [dbo].[Ticket] ([CodTicket], [Descripcion], [CodAsiento], [CodPersona], [CodFuncion]) VALUES (10, N'Venta', 20, 6, 2)
GO
INSERT [dbo].[Ticket] ([CodTicket], [Descripcion], [CodAsiento], [CodPersona], [CodFuncion]) VALUES (11, N'Venta', 45, 1, 3)
GO
SET IDENTITY_INSERT [dbo].[Ticket] OFF
GO
ALTER TABLE [dbo].[Asiento]  WITH CHECK ADD  CONSTRAINT [FK_Asiento_Sala] FOREIGN KEY([CodSala])
REFERENCES [dbo].[Sala] ([CodSala])
GO
ALTER TABLE [dbo].[Asiento] CHECK CONSTRAINT [FK_Asiento_Sala]
GO
ALTER TABLE [dbo].[CinePelicula]  WITH CHECK ADD  CONSTRAINT [FK_CinePelicula_Cine] FOREIGN KEY([CodCine])
REFERENCES [dbo].[Cine] ([CodCine])
GO
ALTER TABLE [dbo].[CinePelicula] CHECK CONSTRAINT [FK_CinePelicula_Cine]
GO
ALTER TABLE [dbo].[CinePelicula]  WITH CHECK ADD  CONSTRAINT [FK_CinePelicula_Pelicula] FOREIGN KEY([CodPelicula])
REFERENCES [dbo].[Pelicula] ([CodPelicula])
GO
ALTER TABLE [dbo].[CinePelicula] CHECK CONSTRAINT [FK_CinePelicula_Pelicula]
GO
ALTER TABLE [dbo].[Funcion]  WITH CHECK ADD  CONSTRAINT [FK_Funcion_Pelicula] FOREIGN KEY([CodPelicula])
REFERENCES [dbo].[Pelicula] ([CodPelicula])
GO
ALTER TABLE [dbo].[Funcion] CHECK CONSTRAINT [FK_Funcion_Pelicula]
GO
ALTER TABLE [dbo].[Pelicula]  WITH CHECK ADD  CONSTRAINT [FK_Pelicula_Director] FOREIGN KEY([CodDirector])
REFERENCES [dbo].[Director] ([CodDirector])
GO
ALTER TABLE [dbo].[Pelicula] CHECK CONSTRAINT [FK_Pelicula_Director]
GO
ALTER TABLE [dbo].[Protagonista]  WITH CHECK ADD  CONSTRAINT [FK_Protagonista_Interprete] FOREIGN KEY([CodInterprete])
REFERENCES [dbo].[Interprete] ([CodInterprete])
GO
ALTER TABLE [dbo].[Protagonista] CHECK CONSTRAINT [FK_Protagonista_Interprete]
GO
ALTER TABLE [dbo].[Protagonista]  WITH CHECK ADD  CONSTRAINT [FK_Protagonista_Pelicula] FOREIGN KEY([CodPelicula])
REFERENCES [dbo].[Pelicula] ([CodPelicula])
GO
ALTER TABLE [dbo].[Protagonista] CHECK CONSTRAINT [FK_Protagonista_Pelicula]
GO
ALTER TABLE [dbo].[Sala]  WITH CHECK ADD  CONSTRAINT [FK_Sala_Cine] FOREIGN KEY([CodCine])
REFERENCES [dbo].[Cine] ([CodCine])
GO
ALTER TABLE [dbo].[Sala] CHECK CONSTRAINT [FK_Sala_Cine]
GO
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_Asiento] FOREIGN KEY([CodAsiento])
REFERENCES [dbo].[Asiento] ([CodAsiento])
GO
ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_Ticket_Asiento]
GO
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_Funcion] FOREIGN KEY([CodFuncion])
REFERENCES [dbo].[Funcion] ([CodFuncion])
GO
ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_Ticket_Funcion]
GO
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_Persona] FOREIGN KEY([CodPersona])
REFERENCES [dbo].[Persona] ([CodPersona])
GO
ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_Ticket_Persona]
GO
USE [master]
GO
ALTER DATABASE [CineDB] SET  READ_WRITE 
GO
