using static System.Net.Mime.MediaTypeNames;
using System.Data;
using System.Net;
using System;

namespace HomeWork20
{
    internal class Program
    {
        static void Main(string[] args)
        {


            USE[MyHomeWorkBD]
GO
/****** Object:  Table [dbo].[Adress]    Script Date: 11.04.2024 23:43:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE[dbo].[Adress](
    [Address][text] NULL
) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 11.04.2024 23:43:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE[dbo].[Role](
    [Role][text] NULL,
    [MainRole][nchar](10) NOT NULL,
    [SecondRole][nchar](10) NULL,
 CONSTRAINT[PK_Role] PRIMARY KEY CLUSTERED
(
    [MainRole] ASC
)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 11.04.2024 23:43:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE[dbo].[User](
    [User][text] NULL,
    [UserFirstName][nchar](10) NOT NULL,
    [UserLastName][nchar](10) NULL,
 CONSTRAINT[PK_User] PRIMARY KEY CLUSTERED
(
    [UserFirstName] ASC
)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]
GO
ALTER TABLE[dbo].[Role] ADD CONSTRAINT[DF_Role_Role]  DEFAULT('0') FOR[Role]
GO
ALTER TABLE[dbo].[User] ADD CONSTRAINT[DF_User_User]  DEFAULT('0') FOR[User]
GO



        }
    }

}

