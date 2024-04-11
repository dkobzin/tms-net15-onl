USE [Lesson 20]
GO

/****** Object:  Table [dbo].[UserInfo]    Script Date: 11.04.2024 1:50:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UserInfo](
	[user_id] [int] NULL,
	[role] [int] NULL,
	[address] [int] NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[UserInfo]  WITH CHECK ADD  CONSTRAINT [FK_UserInfo_Address] FOREIGN KEY([address])
REFERENCES [dbo].[Address] ([id])
GO

ALTER TABLE [dbo].[UserInfo] CHECK CONSTRAINT [FK_UserInfo_Address]
GO

ALTER TABLE [dbo].[UserInfo]  WITH CHECK ADD  CONSTRAINT [FK_UserInfo_Role] FOREIGN KEY([role])
REFERENCES [dbo].[Role] ([id])
GO

ALTER TABLE [dbo].[UserInfo] CHECK CONSTRAINT [FK_UserInfo_Role]
GO

ALTER TABLE [dbo].[UserInfo]  WITH CHECK ADD  CONSTRAINT [FK_UserInfo_Users] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([id])
GO

ALTER TABLE [dbo].[UserInfo] CHECK CONSTRAINT [FK_UserInfo_Users]
GO

---------------------------------------------------------------------------------------------------------

USE [Lesson 20]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 11.04.2024 1:50:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Users] FOREIGN KEY([id])
REFERENCES [dbo].[Users] ([id])
GO

ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Users]
GO

---------------------------------------------------------------------------------------------------------

USE [Lesson 20]
GO

/****** Object:  Table [dbo].[Role]    Script Date: 11.04.2024 1:50:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Role](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

---------------------------------------------------------------------------------------------------------

USE [Lesson 20]
GO

/****** Object:  Table [dbo].[Address]    Script Date: 11.04.2024 1:50:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Address](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[street] [nvarchar](50) NULL,
	[home] [int] NULL,
	[apart] [int] NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


