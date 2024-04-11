USE [HomeWork20]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[User](
	[Id_User] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Sex] [nchar](10) NULL,
	[BirthDate] [date] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id_User] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Address](
	[Id_Address] [int] IDENTITY(1,1) NOT NULL,
	[City] [varchar](50) NULL,
	[Street] [varchar](50) NULL,
	[House] [char](10) NULL,
	[Flat] [int] NULL,
	[Phone] [varchar](50) NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[Id_Address] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Roles](
	[Id_Roles] [int] IDENTITY(1,1) NOT NULL,
	[Name_Roles] [varchar](50) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[Id_Roles] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[UserRoles](
	[Id_User] [int] NOT NULL,
	[Id_Roles] [int] NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_Roles] FOREIGN KEY([Id_Roles])
REFERENCES [dbo].[Roles] ([Id_Roles])
GO

ALTER TABLE [dbo].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_Roles]
GO

ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_User] FOREIGN KEY([Id_User])
REFERENCES [dbo].[User] ([Id_User])
GO

ALTER TABLE [dbo].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_User]
GO


CREATE TABLE [dbo].[UserAddress](
	[Id_User] [int] NOT NULL,
	[Id_Address] [int] NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[UserAddress]  WITH CHECK ADD  CONSTRAINT [FK_UserAddress_Address] FOREIGN KEY([Id_Address])
REFERENCES [dbo].[Address] ([Id_Address])
GO

ALTER TABLE [dbo].[UserAddress] CHECK CONSTRAINT [FK_UserAddress_Address]
GO

ALTER TABLE [dbo].[UserAddress]  WITH CHECK ADD  CONSTRAINT [FK_UserAddress_User] FOREIGN KEY([Id_User])
REFERENCES [dbo].[User] ([Id_User])
GO

ALTER TABLE [dbo].[UserAddress] CHECK CONSTRAINT [FK_UserAddress_User]
GO