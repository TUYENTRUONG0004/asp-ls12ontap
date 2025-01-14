USE [TruongDinhTuyen_2210900134]
GO
/****** Object:  Table [dbo].[Tdt_SACH]    Script Date: 11/07/2024 10:42:11 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tdt_SACH](
	[Tdt_MaSach] [char](10) NULL,
	[Tdt_TenSach] [nvarchar](50) NULL,
	[Tdt_SoTrang] [int] NULL,
	[Tdt_NamXB] [char](10) NULL,
	[Tdt_MaTG] [char](5) NULL,
	[Tdt_TrangThai] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tdt_TACGIA]    Script Date: 11/07/2024 10:42:11 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tdt_TACGIA](
	[Tdt_MaTG] [char](5) NOT NULL,
	[Tdt_TenTacGia] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tdt_TACGIA] PRIMARY KEY CLUSTERED 
(
	[Tdt_MaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
