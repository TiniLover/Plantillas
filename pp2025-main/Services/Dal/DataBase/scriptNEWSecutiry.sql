USE [SecurityDB]
GO
/****** Object:  User [securityUser]    Script Date: 30/6/2025 19:25:12 ******/
CREATE USER [securityUser] FOR LOGIN [securityUser] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [securityUser]
GO
/****** Object:  Table [dbo].[Familia]    Script Date: 30/6/2025 19:25:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Familia](
	[IdFamilia] [uniqueidentifier] NOT NULL,
	[Nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Familia] PRIMARY KEY CLUSTERED 
(
	[IdFamilia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FamiliaFamilia]    Script Date: 30/6/2025 19:25:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FamiliaFamilia](
	[IdFamiliaPadre] [uniqueidentifier] NOT NULL,
	[IdFamiliaHijo] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_FamiliaFamilia] PRIMARY KEY CLUSTERED 
(
	[IdFamiliaPadre] ASC,
	[IdFamiliaHijo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FamiliaPatente]    Script Date: 30/6/2025 19:25:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FamiliaPatente](
	[IdFamilia] [uniqueidentifier] NOT NULL,
	[IdPatente] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_FamiliaPatente] PRIMARY KEY CLUSTERED 
(
	[IdFamilia] ASC,
	[IdPatente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patente]    Script Date: 30/6/2025 19:25:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patente](
	[IdPatente] [uniqueidentifier] NOT NULL,
	[DataKey] [varchar](50) NULL,
	[TipoAcceso] [int] NULL,
 CONSTRAINT [PK_Patente] PRIMARY KEY CLUSTERED 
(
	[IdPatente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 30/6/2025 19:25:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [uniqueidentifier] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Habilitado] [bit] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuarioFamilia]    Script Date: 30/6/2025 19:25:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioFamilia](
	[IdUsuario] [uniqueidentifier] NOT NULL,
	[IdFamilia] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_UsuarioFamilia] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC,
	[IdFamilia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuarioPatente]    Script Date: 30/6/2025 19:25:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioPatente](
	[IdUsuario] [uniqueidentifier] NOT NULL,
	[IdPatente] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_UsuarioPatente] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC,
	[IdPatente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Familia] ([IdFamilia], [Nombre]) VALUES (N'7d9875d7-965d-4ef3-9ae7-39236678c57c', N'Ventas')
INSERT [dbo].[Familia] ([IdFamilia], [Nombre]) VALUES (N'0a7c5d0d-7d9d-4fcd-b8b3-7b80f8306180', N'Administrador')
INSERT [dbo].[Familia] ([IdFamilia], [Nombre]) VALUES (N'6f5e615b-70c2-4b05-aaf7-c12f88d3645a', N'Compras')
GO
INSERT [dbo].[Patente] ([IdPatente], [DataKey], [TipoAcceso]) VALUES (N'0a7c5d0d-7d9d-4fcd-b8b3-7b80f8306181', N'tsmGestionVentas', 0)
GO
INSERT [dbo].[Usuario] ([IdUsuario], [Nombre], [Email], [Password], [Habilitado]) VALUES (N'57a84297-407c-4ca9-9fd7-3c10a2c85bbd', N'gaston', N'gastonweingand@gmail.com', N'0f037584c99e7fd4f4f8c59550f8f507', 1)
INSERT [dbo].[Usuario] ([IdUsuario], [Nombre], [Email], [Password], [Habilitado]) VALUES (N'58a78003-3700-4388-be91-fc8e6fed3e35', N'admin', N'gaston.weingand@uai.edu.ar', N'19a2854144b63a8f7617a6f225019b12', 1)
GO
INSERT [dbo].[UsuarioFamilia] ([IdUsuario], [IdFamilia]) VALUES (N'58a78003-3700-4388-be91-fc8e6fed3e35', N'0a7c5d0d-7d9d-4fcd-b8b3-7b80f8306180')
GO
INSERT [dbo].[UsuarioPatente] ([IdUsuario], [IdPatente]) VALUES (N'58a78003-3700-4388-be91-fc8e6fed3e35', N'0a7c5d0d-7d9d-4fcd-b8b3-7b80f8306181')
GO
ALTER TABLE [dbo].[FamiliaFamilia]  WITH CHECK ADD  CONSTRAINT [FK_FamiliaFamilia_Familia] FOREIGN KEY([IdFamiliaPadre])
REFERENCES [dbo].[Familia] ([IdFamilia])
GO
ALTER TABLE [dbo].[FamiliaFamilia] CHECK CONSTRAINT [FK_FamiliaFamilia_Familia]
GO
ALTER TABLE [dbo].[FamiliaFamilia]  WITH CHECK ADD  CONSTRAINT [FK_FamiliaFamilia_Familia1] FOREIGN KEY([IdFamiliaHijo])
REFERENCES [dbo].[Familia] ([IdFamilia])
GO
ALTER TABLE [dbo].[FamiliaFamilia] CHECK CONSTRAINT [FK_FamiliaFamilia_Familia1]
GO
ALTER TABLE [dbo].[FamiliaPatente]  WITH CHECK ADD  CONSTRAINT [FK_FamiliaPatente_Familia] FOREIGN KEY([IdFamilia])
REFERENCES [dbo].[Familia] ([IdFamilia])
GO
ALTER TABLE [dbo].[FamiliaPatente] CHECK CONSTRAINT [FK_FamiliaPatente_Familia]
GO
ALTER TABLE [dbo].[FamiliaPatente]  WITH CHECK ADD  CONSTRAINT [FK_FamiliaPatente_Patente] FOREIGN KEY([IdPatente])
REFERENCES [dbo].[Patente] ([IdPatente])
GO
ALTER TABLE [dbo].[FamiliaPatente] CHECK CONSTRAINT [FK_FamiliaPatente_Patente]
GO
ALTER TABLE [dbo].[UsuarioFamilia]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioFamilia_Familia] FOREIGN KEY([IdFamilia])
REFERENCES [dbo].[Familia] ([IdFamilia])
GO
ALTER TABLE [dbo].[UsuarioFamilia] CHECK CONSTRAINT [FK_UsuarioFamilia_Familia]
GO
ALTER TABLE [dbo].[UsuarioFamilia]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioFamilia_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[UsuarioFamilia] CHECK CONSTRAINT [FK_UsuarioFamilia_Usuario]
GO
ALTER TABLE [dbo].[UsuarioPatente]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioPatente_Patente] FOREIGN KEY([IdPatente])
REFERENCES [dbo].[Patente] ([IdPatente])
GO
ALTER TABLE [dbo].[UsuarioPatente] CHECK CONSTRAINT [FK_UsuarioPatente_Patente]
GO
ALTER TABLE [dbo].[UsuarioPatente]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioPatente_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[UsuarioPatente] CHECK CONSTRAINT [FK_UsuarioPatente_Usuario]
GO
USE [master]
GO
ALTER DATABASE [SecurityDB] SET  READ_WRITE 
GO
