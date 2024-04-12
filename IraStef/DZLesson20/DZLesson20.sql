USE [IST_DB]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[User](
	[id_card] [int] NOT NULL,
	[id_address] [int] NOT NULL,
	[id_role] [int] NOT NULL,
	[surname] [varchar](50) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[secname] [varchar](50) NULL,
	[date_birth] [date] NOT NULL,
	[sex] [nchar](10) NOT NULL,
	[phone_number] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[id_card] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Address](
	[id_address] [int] NOT NULL,
	[country] [varchar](max) NOT NULL,
	[town] [varchar](max) NOT NULL,
	[street] [varchar](max) NULL,
	[number_house] [int] NOT NULL,
	[number_flat] [int] NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[id_address] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


CREATE TABLE [dbo].[Roles](
	[id_role] [int] NOT NULL,
	[role_name] [varchar](50) NOT NULL,
	[role_description] [varchar](max) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[id_role] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Address] FOREIGN KEY([id_address])
REFERENCES [dbo].[Address] ([id_address])
GO

ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Address]
GO

ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Roles] FOREIGN KEY([id_role])
REFERENCES [dbo].[Roles] ([id_role])
GO

ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Roles]
GO
