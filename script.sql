USE [DBOLabManagement]
GO
/****** Object:  Table [dbo].[Job]    Script Date: 6/29/2020 9:50:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job](
	[MaCV] [char](6) NOT NULL,
	[TenCV] [nchar](30) NULL,
	[ThoiGian] [date] NOT NULL,
	[HoanThanh] [bit] NULL,
	[MaNQL] [char](6) NULL,
	[MaDA] [char](6) NULL,
	[NoiDung] [ntext] NULL,
 CONSTRAINT [PK_CongViec] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 6/29/2020 9:50:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[MaTV] [char](6) NOT NULL,
	[TenTV] [nchar](30) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[HocVan] [nchar](12) NOT NULL,
	[MaDA] [char](6) NULL,
	[LuongThuong] [money] NULL,
	[ChucVu] [nchar](12) NOT NULL,
	[MaCV] [char](6) NULL,
	[GioiTinh] [nchar](10) NULL,
	[Email] [char](30) NULL,
	[Phone] [char](10) NULL,
	[Password] [char](20) NULL,
	[NoiDung] [ntext] NULL,
 CONSTRAINT [PK_ThanhVien] PRIMARY KEY CLUSTERED 
(
	[MaTV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Project]    Script Date: 6/29/2020 9:50:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Project](
	[MaDA] [char](6) NOT NULL,
	[TenDA] [nchar](30) NULL,
	[ThoiGian] [date] NOT NULL,
	[TienDo] [float] NULL,
	[MaNQL] [char](6) NULL,
	[NoiDung] [ntext] NULL,
	[HoanThanh] [bit] NULL,
 CONSTRAINT [PK_DuAn] PRIMARY KEY CLUSTERED 
(
	[MaDA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalaryLevel]    Script Date: 6/29/2020 9:50:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalaryLevel](
	[HocVan] [nchar](12) NOT NULL,
	[Luong] [money] NOT NULL,
 CONSTRAINT [PK_LuongHV] PRIMARY KEY CLUSTERED 
(
	[HocVan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalaryPosition]    Script Date: 6/29/2020 9:50:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalaryPosition](
	[ChucVu] [nchar](12) NOT NULL,
	[Luong] [money] NOT NULL,
 CONSTRAINT [PK_LuongCV] PRIMARY KEY CLUSTERED 
(
	[ChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Job]  WITH CHECK ADD  CONSTRAINT [FK_CongViec_DuAn] FOREIGN KEY([MaDA])
REFERENCES [dbo].[Project] ([MaDA])
GO
ALTER TABLE [dbo].[Job] CHECK CONSTRAINT [FK_CongViec_DuAn]
GO
ALTER TABLE [dbo].[Member]  WITH CHECK ADD  CONSTRAINT [FK_ThanhVien_CongViec1] FOREIGN KEY([MaCV])
REFERENCES [dbo].[Job] ([MaCV])
GO
ALTER TABLE [dbo].[Member] CHECK CONSTRAINT [FK_ThanhVien_CongViec1]
GO
ALTER TABLE [dbo].[Member]  WITH CHECK ADD  CONSTRAINT [FK_ThanhVien_DuAn] FOREIGN KEY([MaDA])
REFERENCES [dbo].[Project] ([MaDA])
GO
ALTER TABLE [dbo].[Member] CHECK CONSTRAINT [FK_ThanhVien_DuAn]
GO
ALTER TABLE [dbo].[Member]  WITH CHECK ADD  CONSTRAINT [FK_ThanhVien_LuongCV] FOREIGN KEY([ChucVu])
REFERENCES [dbo].[SalaryPosition] ([ChucVu])
GO
ALTER TABLE [dbo].[Member] CHECK CONSTRAINT [FK_ThanhVien_LuongCV]
GO
ALTER TABLE [dbo].[Member]  WITH CHECK ADD  CONSTRAINT [FK_ThanhVien_LuongHV] FOREIGN KEY([HocVan])
REFERENCES [dbo].[SalaryLevel] ([HocVan])
GO
ALTER TABLE [dbo].[Member] CHECK CONSTRAINT [FK_ThanhVien_LuongHV]
GO
ALTER TABLE [dbo].[Project]  WITH CHECK ADD  CONSTRAINT [FK_DuAn_ThanhVien] FOREIGN KEY([MaNQL])
REFERENCES [dbo].[Member] ([MaTV])
GO
ALTER TABLE [dbo].[Project] CHECK CONSTRAINT [FK_DuAn_ThanhVien]
GO
