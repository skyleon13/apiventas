CREATE DATABASE [ventas]
GO

USE [ventas]
GO

/****** Object:  Table [dbo].[clientes]    Script Date: 01/02/2022 02:04:02 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[clientes](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[apellidopat] [nvarchar](50) NOT NULL,
	[apellidomat] [nvarchar](50) NOT NULL,
	[rfc] [varchar](15) NOT NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[productos](
	[idProducto] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](50) NOT NULL,
	[modelo] [nvarchar](50) NOT NULL,
	[precio] [decimal](6, 2) NOT NULL,
	[existencia] [int] NOT NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[configuracion](
	[idConfiguracion] [int] IDENTITY(1,1) NOT NULL,
	[tasa] [decimal](6, 2) NOT NULL,
	[enganche] [int] NULL,
	[plazo] [int] NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ventas](
	[idVenta] [int] IDENTITY(1,1) NOT NULL,
	[idCliente] [int] NOT NULL,
	[enganche] [decimal](6, 2) NOT NULL,
	[bonificacion] [decimal](6, 2) NOT NULL,
	[total] [decimal](6, 2) NOT NULL
) ON [PRIMARY]
GO