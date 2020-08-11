USE [QL_Music]
GO
ALTER TABLE [dbo].[BaiHat] DROP CONSTRAINT [FK_BaiHat_PlayList]
GO
ALTER TABLE [dbo].[BaiHat] DROP CONSTRAINT [FK_BaiHat_CaSi]
GO
/****** Object:  Table [dbo].[PlayList]    Script Date: 08/11/2020 18:42:30 ******/
DROP TABLE [dbo].[PlayList]
GO
/****** Object:  Table [dbo].[CaSi]    Script Date: 08/11/2020 18:42:30 ******/
DROP TABLE [dbo].[CaSi]
GO
/****** Object:  Table [dbo].[BaiHat]    Script Date: 08/11/2020 18:42:30 ******/
DROP TABLE [dbo].[BaiHat]
GO
/****** Object:  Table [dbo].[BaiHat]    Script Date: 08/11/2020 18:42:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaiHat](
	[maBaiHat] [nchar](10) NOT NULL,
	[tenBaiHat] [nvarchar](50) NULL,
	[maCaSi] [nchar](10) NULL,
	[pathBaiHat] [nchar](100) NULL,
	[maPlayList] [nchar](10) NULL,
 CONSTRAINT [PK_BaiHat] PRIMARY KEY CLUSTERED 
(
	[maBaiHat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CaSi]    Script Date: 08/11/2020 18:42:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CaSi](
	[maCaSi] [nchar](10) NOT NULL,
	[tenCaSi] [nvarchar](50) NULL,
	[gioiTinh] [nvarchar](10) NULL,
 CONSTRAINT [PK_CaSi] PRIMARY KEY CLUSTERED 
(
	[maCaSi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlayList]    Script Date: 08/11/2020 18:42:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlayList](
	[maPlayList] [nchar](10) NOT NULL,
	[tenPlayList] [nvarchar](50) NULL,
 CONSTRAINT [PK_PlayList] PRIMARY KEY CLUSTERED 
(
	[maPlayList] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BaiHat] ([maBaiHat], [tenBaiHat], [maCaSi], [pathBaiHat], [maPlayList]) VALUES (N'BH001     ', N'haha', N'CS001     ', NULL, NULL)
INSERT [dbo].[BaiHat] ([maBaiHat], [tenBaiHat], [maCaSi], [pathBaiHat], [maPlayList]) VALUES (N'BH002     ', N'hihi', N'CS001     ', NULL, NULL)
INSERT [dbo].[BaiHat] ([maBaiHat], [tenBaiHat], [maCaSi], [pathBaiHat], [maPlayList]) VALUES (N'BH003     ', N'huuh', N'CS001     ', NULL, NULL)
INSERT [dbo].[CaSi] ([maCaSi], [tenCaSi], [gioiTinh]) VALUES (N'CS001     ', N'Sơn Tùng MTP', N'Nam')
INSERT [dbo].[CaSi] ([maCaSi], [tenCaSi], [gioiTinh]) VALUES (N'CS002     ', N'Đen Vâu', N'Nam')
INSERT [dbo].[CaSi] ([maCaSi], [tenCaSi], [gioiTinh]) VALUES (N'CS003     ', N'Đức Phúc', N'Nam')
INSERT [dbo].[CaSi] ([maCaSi], [tenCaSi], [gioiTinh]) VALUES (N'CS004     ', N'Eric', N'Nam')
INSERT [dbo].[CaSi] ([maCaSi], [tenCaSi], [gioiTinh]) VALUES (N'CS005     ', N'Hiền Hồ', N'Nữ')
INSERT [dbo].[PlayList] ([maPlayList], [tenPlayList]) VALUES (N'PL001     ', N'Nhạc rap')
INSERT [dbo].[PlayList] ([maPlayList], [tenPlayList]) VALUES (N'PL002     ', N'Nhạc trẻ')
INSERT [dbo].[PlayList] ([maPlayList], [tenPlayList]) VALUES (N'PL003     ', N'Nhạc Việt')
INSERT [dbo].[PlayList] ([maPlayList], [tenPlayList]) VALUES (N'PL004     ', N'Nhạc lofi')
ALTER TABLE [dbo].[BaiHat]  WITH CHECK ADD  CONSTRAINT [FK_BaiHat_CaSi] FOREIGN KEY([maCaSi])
REFERENCES [dbo].[CaSi] ([maCaSi])
GO
ALTER TABLE [dbo].[BaiHat] CHECK CONSTRAINT [FK_BaiHat_CaSi]
GO
ALTER TABLE [dbo].[BaiHat]  WITH CHECK ADD  CONSTRAINT [FK_BaiHat_PlayList] FOREIGN KEY([maPlayList])
REFERENCES [dbo].[PlayList] ([maPlayList])
GO
ALTER TABLE [dbo].[BaiHat] CHECK CONSTRAINT [FK_BaiHat_PlayList]
GO
