USE [dbDevTest]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 21/02/2024 17:58:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employees](
	[id_employee] [int] IDENTITY(1,1) NOT NULL,
	[name_employee] [varchar](50) NULL,
	[lastname_employee] [varchar](50) NULL,
	[rfc_employee] [varchar](13) NULL,
	[borndate_employee] [datetime] NULL,
	[status_employee] [int] NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[id_employee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 

GO
INSERT [dbo].[Employees] ([id_employee], [name_employee], [lastname_employee], [rfc_employee], [borndate_employee], [status_employee]) VALUES (76, N'Ulises', N'Ramirez', N'RARU990429UP4', CAST(0x00008DB5011E0644 AS DateTime), 1)
GO
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
