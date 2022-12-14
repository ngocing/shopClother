USE [QlyShopQA]
GO
/****** Object:  Table [dbo].[Ct_Hoa_Don]    Script Date: 6/24/2020 9:13:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ct_Hoa_Don](
	[ma_hd] [nvarchar](100) NOT NULL,
	[ma_sp] [nvarchar](100) NOT NULL,
	[so_luong] [int] NULL,
	[don_gia] [int] NULL,
 CONSTRAINT [PK_Ct_Hoa_Don] PRIMARY KEY CLUSTERED 
(
	[ma_hd] ASC,
	[ma_sp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ct_Hoa_Don_Nhap]    Script Date: 6/24/2020 9:13:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ct_Hoa_Don_Nhap](
	[ma_hdn] [nvarchar](100) NOT NULL,
	[ma_sp] [nvarchar](100) NOT NULL,
	[so_luong] [int] NULL,
	[don_gia] [int] NULL,
 CONSTRAINT [PK_Ct_Hoa_Don_Nhap] PRIMARY KEY CLUSTERED 
(
	[ma_hdn] ASC,
	[ma_sp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hoa_Don]    Script Date: 6/24/2020 9:13:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hoa_Don](
	[ma_hd] [nvarchar](100) NOT NULL,
	[ngay_lap] [datetime] NULL,
	[ma_nv] [nvarchar](100) NULL,
	[ma_kh] [nvarchar](100) NULL,
	[tri_gia] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Hoa_Don] PRIMARY KEY CLUSTERED 
(
	[ma_hd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hoa_Don_Nhap]    Script Date: 6/24/2020 9:13:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hoa_Don_Nhap](
	[ma_hdn] [nvarchar](100) NOT NULL,
	[ma_ncc] [nvarchar](100) NULL,
	[ma_nv] [nvarchar](100) NULL,
	[ngay_lap] [datetime] NULL,
	[tri_gia] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Hoa_Don_Nhap] PRIMARY KEY CLUSTERED 
(
	[ma_hdn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khach_Hang]    Script Date: 6/24/2020 9:13:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khach_Hang](
	[ma_kh] [nvarchar](100) NOT NULL,
	[ten_kh] [nvarchar](255) NULL,
	[gioi_tinh] [nvarchar](100) NULL,
	[ngay_sinh] [datetime] NULL,
	[dia_chi] [nvarchar](255) NULL,
	[dien_thoai] [nvarchar](100) NULL,
	[email] [nvarchar](255) NULL,
 CONSTRAINT [PK_Khach_Hang] PRIMARY KEY CLUSTERED 
(
	[ma_kh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loai_cha]    Script Date: 6/24/2020 9:13:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loai_cha](
	[ma_loai_cha] [nvarchar](100) NOT NULL,
	[ten_loai_cha] [nvarchar](255) NULL,
	[mo_ta] [nvarchar](255) NULL,
 CONSTRAINT [PK_Loai_cha] PRIMARY KEY CLUSTERED 
(
	[ma_loai_cha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loai_San_Pham]    Script Date: 6/24/2020 9:13:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loai_San_Pham](
	[ma_loai] [nvarchar](100) NOT NULL,
	[ten_loai] [nvarchar](255) NULL,
	[mo_ta] [nvarchar](255) NULL,
	[hinh] [nvarchar](255) NULL,
	[ma_loai_cha] [nvarchar](100) NULL,
 CONSTRAINT [PK_Loai_San_Pham] PRIMARY KEY CLUSTERED 
(
	[ma_loai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nha_Cung_Cap]    Script Date: 6/24/2020 9:13:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nha_Cung_Cap](
	[ma_ncc] [nvarchar](100) NOT NULL,
	[ten_ncc] [nvarchar](255) NULL,
	[dia_chi] [nvarchar](255) NULL,
	[dien_thoai] [nvarchar](100) NULL,
	[email] [nvarchar](255) NULL,
 CONSTRAINT [PK_Nha_Cung_Cap] PRIMARY KEY CLUSTERED 
(
	[ma_ncc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nhan_Hieu]    Script Date: 6/24/2020 9:13:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhan_Hieu](
	[ma_hieu] [nvarchar](100) NOT NULL,
	[ten_hieu] [nvarchar](255) NULL,
 CONSTRAINT [PK_Nhan_Hieu] PRIMARY KEY CLUSTERED 
(
	[ma_hieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nhan_vien]    Script Date: 6/24/2020 9:13:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhan_vien](
	[ma_nv] [nvarchar](100) NOT NULL,
	[ten_nv] [nvarchar](255) NULL,
	[gioi_tinh] [nvarchar](100) NULL,
	[ngay_sinh] [datetime] NULL,
	[dia_chi] [nvarchar](255) NULL,
	[dien_thoai] [nvarchar](100) NULL,
	[email] [nvarchar](255) NULL,
	[tai_khoan] [nvarchar](255) NULL,
	[mat_khau] [nvarchar](255) NULL,
	[ma_quyen] [nvarchar](100) NULL,
 CONSTRAINT [PK_Nhan_vien] PRIMARY KEY CLUSTERED 
(
	[ma_nv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phan_quyen]    Script Date: 6/24/2020 9:13:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phan_quyen](
	[ma_quyen] [nvarchar](100) NOT NULL,
	[ten_quyen] [nvarchar](255) NULL,
 CONSTRAINT [PK_Phan_quyen] PRIMARY KEY CLUSTERED 
(
	[ma_quyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[San_Pham]    Script Date: 6/24/2020 9:13:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[San_Pham](
	[ma_sp] [nvarchar](100) NOT NULL,
	[ten_sp] [nvarchar](255) NULL,
	[ma_loai] [nvarchar](100) NULL,
	[mo_ta] [nvarchar](255) NULL,
	[don_gia] [decimal](18, 0) NULL,
	[hinh] [nvarchar](255) NULL,
	[ngay_cap_nhat] [datetime] NULL,
	[ma_hieu] [nvarchar](100) NULL,
	[loi_nhuan] [float] NULL,
 CONSTRAINT [PK_San_Pham] PRIMARY KEY CLUSTERED 
(
	[ma_sp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Ct_Hoa_Don]  WITH CHECK ADD  CONSTRAINT [FK_Ct_Hoa_Don_Hoa_Don] FOREIGN KEY([ma_hd])
REFERENCES [dbo].[Hoa_Don] ([ma_hd])
GO
ALTER TABLE [dbo].[Ct_Hoa_Don] CHECK CONSTRAINT [FK_Ct_Hoa_Don_Hoa_Don]
GO
ALTER TABLE [dbo].[Ct_Hoa_Don]  WITH CHECK ADD  CONSTRAINT [FK_Ct_Hoa_Don_San_Pham] FOREIGN KEY([ma_sp])
REFERENCES [dbo].[San_Pham] ([ma_sp])
GO
ALTER TABLE [dbo].[Ct_Hoa_Don] CHECK CONSTRAINT [FK_Ct_Hoa_Don_San_Pham]
GO
ALTER TABLE [dbo].[Ct_Hoa_Don_Nhap]  WITH CHECK ADD  CONSTRAINT [FK_Ct_Hoa_Don_Nhap_Hoa_Don_Nhap] FOREIGN KEY([ma_hdn])
REFERENCES [dbo].[Hoa_Don_Nhap] ([ma_hdn])
GO
ALTER TABLE [dbo].[Ct_Hoa_Don_Nhap] CHECK CONSTRAINT [FK_Ct_Hoa_Don_Nhap_Hoa_Don_Nhap]
GO
ALTER TABLE [dbo].[Ct_Hoa_Don_Nhap]  WITH CHECK ADD  CONSTRAINT [FK_Ct_Hoa_Don_Nhap_San_Pham] FOREIGN KEY([ma_sp])
REFERENCES [dbo].[San_Pham] ([ma_sp])
GO
ALTER TABLE [dbo].[Ct_Hoa_Don_Nhap] CHECK CONSTRAINT [FK_Ct_Hoa_Don_Nhap_San_Pham]
GO
ALTER TABLE [dbo].[Hoa_Don]  WITH CHECK ADD  CONSTRAINT [FK_Hoa_Don_Khach_Hang] FOREIGN KEY([ma_kh])
REFERENCES [dbo].[Khach_Hang] ([ma_kh])
GO
ALTER TABLE [dbo].[Hoa_Don] CHECK CONSTRAINT [FK_Hoa_Don_Khach_Hang]
GO
ALTER TABLE [dbo].[Hoa_Don]  WITH CHECK ADD  CONSTRAINT [FK_Hoa_Don_Nhan_vien] FOREIGN KEY([ma_nv])
REFERENCES [dbo].[Nhan_vien] ([ma_nv])
GO
ALTER TABLE [dbo].[Hoa_Don] CHECK CONSTRAINT [FK_Hoa_Don_Nhan_vien]
GO
ALTER TABLE [dbo].[Hoa_Don_Nhap]  WITH CHECK ADD  CONSTRAINT [FK_Hoa_Don_Nhap_Nha_Cung_Cap] FOREIGN KEY([ma_ncc])
REFERENCES [dbo].[Nha_Cung_Cap] ([ma_ncc])
GO
ALTER TABLE [dbo].[Hoa_Don_Nhap] CHECK CONSTRAINT [FK_Hoa_Don_Nhap_Nha_Cung_Cap]
GO
ALTER TABLE [dbo].[Hoa_Don_Nhap]  WITH CHECK ADD  CONSTRAINT [FK_Hoa_Don_Nhap_Nhan_vien] FOREIGN KEY([ma_nv])
REFERENCES [dbo].[Nhan_vien] ([ma_nv])
GO
ALTER TABLE [dbo].[Hoa_Don_Nhap] CHECK CONSTRAINT [FK_Hoa_Don_Nhap_Nhan_vien]
GO
ALTER TABLE [dbo].[Loai_San_Pham]  WITH CHECK ADD  CONSTRAINT [FK_Loai_San_Pham_Loai_cha] FOREIGN KEY([ma_loai_cha])
REFERENCES [dbo].[Loai_cha] ([ma_loai_cha])
GO
ALTER TABLE [dbo].[Loai_San_Pham] CHECK CONSTRAINT [FK_Loai_San_Pham_Loai_cha]
GO
ALTER TABLE [dbo].[Nhan_vien]  WITH CHECK ADD  CONSTRAINT [FK_Nhan_vien_Phan_quyen] FOREIGN KEY([ma_quyen])
REFERENCES [dbo].[Phan_quyen] ([ma_quyen])
GO
ALTER TABLE [dbo].[Nhan_vien] CHECK CONSTRAINT [FK_Nhan_vien_Phan_quyen]
GO
ALTER TABLE [dbo].[San_Pham]  WITH CHECK ADD  CONSTRAINT [FK_San_Pham_Loai_San_Pham] FOREIGN KEY([ma_loai])
REFERENCES [dbo].[Loai_San_Pham] ([ma_loai])
GO
ALTER TABLE [dbo].[San_Pham] CHECK CONSTRAINT [FK_San_Pham_Loai_San_Pham]
GO
ALTER TABLE [dbo].[San_Pham]  WITH CHECK ADD  CONSTRAINT [FK_San_Pham_Nhan_Hieu] FOREIGN KEY([ma_hieu])
REFERENCES [dbo].[Nhan_Hieu] ([ma_hieu])
GO
ALTER TABLE [dbo].[San_Pham] CHECK CONSTRAINT [FK_San_Pham_Nhan_Hieu]
GO
