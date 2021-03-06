USE [AnTourApplication]
GO
/****** Object:  Table [dbo].[GIOITINH]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIOITINH](
	[ma] [int] NOT NULL,
	[ten] [nvarchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GROUPUSER]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GROUPUSER](
	[maquyen] [int] NOT NULL,
	[tenquyen] [nvarchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maquyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[makh] [int] IDENTITY(1,1) NOT NULL,
	[tenkh] [nvarchar](30) NOT NULL,
	[urlimage] [nchar](200) NULL,
	[gioitinh] [int] NOT NULL,
	[cmtnd] [nchar](15) NOT NULL,
	[sdt] [nchar](15) NOT NULL,
	[email] [nchar](50) NOT NULL,
	[diachi] [nvarchar](100) NULL,
	[tendangnhap] [nchar](30) NOT NULL,
	[matkhau] [nchar](30) NOT NULL,
	[quyen] [int] NOT NULL DEFAULT ((1)),
PRIMARY KEY CLUSTERED 
(
	[makh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[manv] [int] IDENTITY(1,1) NOT NULL,
	[tennv] [nvarchar](30) NOT NULL,
	[urlimage] [nchar](200) NULL,
	[gioitinh] [int] NOT NULL,
	[cmtnd] [nchar](15) NOT NULL,
	[sdt] [nchar](15) NOT NULL,
	[email] [nchar](50) NOT NULL,
	[diachi] [nvarchar](100) NULL,
	[tendangnhap] [nchar](30) NOT NULL,
	[matkhau] [nchar](30) NOT NULL,
	[quyen] [int] NOT NULL DEFAULT ((2)),
	[trangthai] [int] NOT NULL DEFAULT ((1)),
PRIMARY KEY CLUSTERED 
(
	[manv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUDAT]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUDAT](
	[maphieu] [int] IDENTITY(1,1) NOT NULL,
	[makh] [int] NOT NULL,
	[matour] [int] NOT NULL,
	[ngaydat] [date] NOT NULL DEFAULT (getdate()),
	[checkin] [date] NOT NULL,
	[slkhach] [int] NOT NULL,
	[sltreem] [int] NOT NULL,
	[trangthai] [int] NOT NULL DEFAULT ((1)),
	[giatien] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[maphieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TOUR]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TOUR](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[tentour] [nvarchar](100) NOT NULL,
	[urlimage] [nchar](200) NULL,
	[gioithieu] [nvarchar](1000) NULL,
	[diadiem] [nvarchar](50) NOT NULL,
	[songaytour] [int] NOT NULL,
	[slkhachtoida] [int] NOT NULL,
	[dongia] [float] NOT NULL,
	[ngaytao] [date] NOT NULL DEFAULT (getdate()),
	[trangthai] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TRANGTHAI_PHIEU]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRANGTHAI_PHIEU](
	[ma] [int] NOT NULL,
	[ten] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TRANGTHAI_Tour]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRANGTHAI_Tour](
	[ma] [int] NOT NULL,
	[ten] [nchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TRANGTHAINV]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRANGTHAINV](
	[ma] [int] NOT NULL,
	[ten] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[KHACHHANG]  WITH CHECK ADD FOREIGN KEY([gioitinh])
REFERENCES [dbo].[GIOITINH] ([ma])
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD FOREIGN KEY([gioitinh])
REFERENCES [dbo].[GIOITINH] ([ma])
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD FOREIGN KEY([quyen])
REFERENCES [dbo].[GROUPUSER] ([maquyen])
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD FOREIGN KEY([trangthai])
REFERENCES [dbo].[TRANGTHAINV] ([ma])
GO
ALTER TABLE [dbo].[PHIEUDAT]  WITH CHECK ADD FOREIGN KEY([makh])
REFERENCES [dbo].[KHACHHANG] ([makh])
GO
ALTER TABLE [dbo].[PHIEUDAT]  WITH CHECK ADD FOREIGN KEY([matour])
REFERENCES [dbo].[TOUR] ([ma])
GO
ALTER TABLE [dbo].[PHIEUDAT]  WITH CHECK ADD FOREIGN KEY([trangthai])
REFERENCES [dbo].[TRANGTHAI_PHIEU] ([ma])
GO
ALTER TABLE [dbo].[TOUR]  WITH CHECK ADD FOREIGN KEY([trangthai])
REFERENCES [dbo].[TRANGTHAI_Tour] ([ma])
GO
/****** Object:  StoredProcedure [dbo].[pro_AdminUpdateNV]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_AdminUpdateNV]
@ma INT,
@quyen INT,
@trangthai INT 
AS BEGIN
UPDATE dbo.NHANVIEN
SET quyen = @quyen, trangthai = @trangthai
WHERE @ma = manv
END

GO
/****** Object:  StoredProcedure [dbo].[pro_DoanhThuTheoNgay]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_DoanhThuTheoNgay]
@ngay DATE
AS
BEGIN
SELECT ngaydat, SUM(giatien) AS [DoanhThu],COUNT(maphieu) AS [SoPhieu]
FROM dbo.PHIEUDAT
WHERE trangthai=3 AND ngaydat = @ngay
GROUP BY ngaydat
END

GO
/****** Object:  StoredProcedure [dbo].[pro_InsertKH]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--

CREATE PROC [dbo].[pro_InsertKH]
@tenkh NVARCHAR(30),
@urlimage NCHAR(200),
@gioitinh INT ,
@cmtnd NCHAR(15),
@sdt NCHAR(15),
@email NCHAR(50),
@diachi NVARCHAR(100),
@tendangnhap NCHAR(30),
@matkhau NCHAR(30),
@quyen INT
AS 
BEGIN
INSERT INTO dbo.KHACHHANG
        ( tenkh ,
          urlimage ,
          gioitinh ,
          cmtnd ,
          sdt ,
          email ,
          diachi ,
          tendangnhap ,
          matkhau ,
          quyen
        )
VALUES  ( @tenkh ,
@urlimage ,
@gioitinh ,
@cmtnd ,
@sdt ,
@email ,
@diachi ,
@tendangnhap ,
@matkhau ,
@quyen
        )

END 

GO
/****** Object:  StoredProcedure [dbo].[pro_InsertNV]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_InsertNV]
@tennv NVARCHAR(30),
@urlimage NCHAR(200),
@gioitinh INT,
@cmtnd NCHAR(15),
@sdt NCHAR(15) ,
@email NCHAR(50) ,
@diachi NVARCHAR(100),
@tendangnhap NCHAR(30),
@matkhau NCHAR(30),
@quyen INT,
@trangthai INT
AS
BEGIN
INSERT INTO dbo.NHANVIEN
        ( tennv , urlimage ,gioitinh , cmtnd ,sdt ,email ,diachi , tendangnhap ,matkhau ,quyen ,trangthai)
VALUES  (@tennv,@urlimage,@gioitinh,@cmtnd,@sdt,@email,@diachi,@tendangnhap,@matkhau,@quyen,@trangthai )
END
GO
/****** Object:  StoredProcedure [dbo].[pro_InsertPhieuDatKH]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_InsertPhieuDatKH]
@makh int,
@matour int ,
@ngaydat DATE ,
@checkin DATE ,
@slkhach INT ,
@sltreem  INT,
@trangthai INT
AS 
BEGIN
INSERT INTO dbo.PHIEUDAT ( makh ,matour ,ngaydat ,checkin ,slkhach ,sltreem ,trangthai)
VALUES  ( @makh ,@matour ,@ngaydat ,@checkin,@slkhach,@sltreem,@trangthai)
END

GO
/****** Object:  StoredProcedure [dbo].[pro_InsertPhieuDatNV]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_InsertPhieuDatNV]
@manv int,
@matour int ,
@ngaydat DATE ,
@checkin DATE ,
@slkhach INT ,
@sltreem  INT,
@trangthai INT
AS 
BEGIN
INSERT INTO dbo.PHIEUDAT_NV( manv ,matour ,ngaydat ,checkin ,slkhach ,sltreem ,trangthai)
VALUES  ( @manv ,@matour ,@ngaydat ,@checkin,@slkhach,@sltreem,@trangthai)
END

GO
/****** Object:  StoredProcedure [dbo].[pro_InsertTour]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_InsertTour]
@tentour nvarchar(100),
@urlimage nchar(200),
@gioithieu nvarchar(1000),
@diadiem nvarchar(50),
@songaytour INT,
@slkhachtoida INT,
@dongia FLOAT,
@ngaytao DATE,
@trangthai INT
AS 
BEGIN
INSERT INTO dbo.TOUR
        ( tentour, urlimage, gioithieu, diadiem, songaytour, slkhachtoida, dongia, ngaytao, trangthai)
VALUES  ( @tentour,@urlimage,@gioithieu,@diadiem ,@songaytour ,@slkhachtoida ,@dongia ,@ngaytao ,@trangthai)
END

GO
/****** Object:  StoredProcedure [dbo].[pro_KHUpdate]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_KHUpdate]
@ma INT,
@tenkh NVARCHAR(30),
@urlimage nchar(200),
@gioitinh INT,
@cmtnd nchar(15),
@sdt  nchar(15),
@email  nchar(50),
@diachi  nvarchar(100),
@tendangnhap nchar(30)
AS 
BEGIN 
UPDATE dbo.KHACHHANG 
SET tenkh=@tenkh,urlimage= @urlimage,gioitinh = @gioitinh, cmtnd = @cmtnd, sdt = @sdt, email = @email, diachi = @diachi, tendangnhap = tendangnhap
WHERE makh = @ma
END

GO
/****** Object:  StoredProcedure [dbo].[pro_KHUpdatePass]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_KHUpdatePass]
@ma INT,
@tendangnhap NCHAR(30),
@matkhau NCHAR(30)
AS BEGIN
       UPDATE dbo.KHACHHANG SET matkhau = @matkhau WHERE makh = @ma AND tendangnhap = @tendangnhap
   END
GO
/****** Object:  StoredProcedure [dbo].[pro_ListPhieuTheoNgay]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_ListPhieuTheoNgay]
@ngay DATE
AS BEGIN

SELECT kh.makh AS [MaKH],kh.tenkh AS [TenKH],gt.ten AS [GT],kh.cmtnd,kh.sdt,kh.email,kh.diachi,t.ma AS [MaTour],t.tentour,t.diadiem AS [DD],t.songaytour,t.dongia,ph.maphieu,ph.ngaydat,ph.checkin,ph.slkhach,ph.sltreem,tt.ten AS [TrangThai],ph.giatien
	FROM ((((dbo.KHACHHANG AS kh
	INNER JOIN dbo.GIOITINH AS gt ON kh.gioitinh = gt.ma)
	INNER JOIN dbo.PHIEUDAT AS ph ON ph.makh = kh.makh)
	INNER JOIN dbo.TOUR AS t ON ph.matour = t.ma)
	INNER JOIN dbo.TRANGTHAI_PHIEU AS tt ON ph.trangthai = tt.ma)
	WHERE ph.ngaydat = @ngay AND ph.trangthai = 3
END

GO
/****** Object:  StoredProcedure [dbo].[pro_SelectCMTND]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_SelectCMTND]
AS 
BEGIN
select cmtnd as cmtnd from dbo.KHACHHANG
UNION ALL
Select cmtnd as cmtnd from dbo.NHANVIEN
END

GO
/****** Object:  StoredProcedure [dbo].[pro_SelectEmail]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_SelectEmail]
AS 
BEGIN
select email as email from dbo.KHACHHANG
UNION ALL
Select email as email from dbo.NHANVIEN
END

GO
/****** Object:  StoredProcedure [dbo].[pro_selectGioiTinh]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_selectGioiTinh]
AS 
BEGIN
SELECT * FROM dbo.GIOITINH
END

GO
/****** Object:  StoredProcedure [dbo].[pro_SelectKHByCMTND]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--
CREATE PROC [dbo].[pro_SelectKHByCMTND]
@cmtnd NCHAR(15)
AS
BEGIN
    SELECT * FROM dbo.KHACHHANG
	WHERE @cmtnd = dbo.KHACHHANG.cmtnd
END

GO
/****** Object:  StoredProcedure [dbo].[pro_SelectKHByEmail]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---
CREATE PROC [dbo].[pro_SelectKHByEmail]
@email NCHAR(50)
AS BEGIN
       SELECT * FROM dbo.KHACHHANG WHERE email = @email
   END

GO
/****** Object:  StoredProcedure [dbo].[pro_SelectKHById]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_SelectKHById]
@ma INT
AS BEGIN 
SELECT * FROM dbo.KHACHHANG
WHERE makh = @ma
END
GO
/****** Object:  StoredProcedure [dbo].[pro_SelectKHBySDT]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--
CREATE PROC [dbo].[pro_SelectKHBySDT]
@sdt NCHAR(15)
AS BEGIN
SELECT * FROM dbo.KHACHHANG 
WHERE @sdt = sdt
END

GO
/****** Object:  StoredProcedure [dbo].[pro_SelectKHByUser]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--
CREATE PROC [dbo].[pro_SelectKHByUser]
@user NCHAR(30)
AS BEGIN
SELECT * FROM dbo.KHACHHANG WHERE tendangnhap = @user
END

GO
/****** Object:  StoredProcedure [dbo].[pro_SelectKHByUserPass]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_SelectKHByUserPass]
@user NCHAR(30),
@pass NCHAR(30)
AS
BEGIN
SELECT * FROM dbo.KHACHHANG
WHERE @user = tendangnhap AND @pass = matkhau
END

GO
/****** Object:  StoredProcedure [dbo].[pro_selectListKH]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_selectListKH]
AS BEGIN
SELECT makh,tenkh,dbo.GIOITINH.ten AS[gioitinh], cmtnd, sdt, email, diachi, tendangnhap FROM dbo.GIOITINH, dbo.KHACHHANG
WHERE dbo.GIOITINH.ma = dbo.KHACHHANG.gioitinh
END

GO
/****** Object:  StoredProcedure [dbo].[pro_selectListNV]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_selectListNV]
AS BEGIN
SELECT manv, tennv, dbo.GIOITINH.ten AS [gioitinh], cmtnd, sdt, email, diachi, tendangnhap, dbo.GROUPUSER.tenquyen, dbo.TRANGTHAINV.ten AS[trangthai]
FROM (((dbo.NHANVIEN
INNER JOIN dbo.GIOITINH ON dbo.NHANVIEN.gioitinh = dbo.GIOITINH.ma)
INNER JOIN dbo.GROUPUSER ON dbo.NHANVIEN.quyen = dbo.GROUPUSER.maquyen)
INNER JOIN dbo.TRANGTHAINV ON dbo.NHANVIEN.trangthai = dbo.TRANGTHAINV.ma)
END
GO
/****** Object:  StoredProcedure [dbo].[pro_selectListPD]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_selectListPD]
AS
BEGIN
SELECT dbo.PHIEUDAT.*, dbo.TOUR.dongia
FROM dbo.PHIEUDAT
LEFT OUTER JOIN dbo.TOUR
ON PHIEUDAT.matour = TOUR.ma
END 
GO
/****** Object:  StoredProcedure [dbo].[pro_selectListPhieuDatKH]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROC [dbo].[pro_selectListPhieuDatKH]
AS
BEGIN
    SELECT kh.makh AS [MaKH],kh.tenkh AS [TenKH],gt.ten AS [GT],kh.cmtnd,kh.sdt,kh.email,kh.diachi,t.ma AS [MaTour],t.tentour,t.diadiem AS [DD],t.songaytour,t.dongia,ph.maphieu,ph.ngaydat,ph.checkin,ph.slkhach,ph.sltreem,tt.ten AS [TrangThai]
	FROM ((((dbo.KHACHHANG AS kh
	INNER JOIN dbo.GIOITINH AS gt ON kh.gioitinh = gt.ma)
	INNER JOIN dbo.PHIEUDAT AS ph ON ph.makh = kh.makh)
	INNER JOIN dbo.TOUR AS t ON ph.matour = t.ma)
	INNER JOIN dbo.TRANGTHAI_PHIEU AS tt ON ph.trangthai = tt.ma)
	
END

GO
/****** Object:  StoredProcedure [dbo].[pro_SelectNVByCMTND]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--
CREATE PROC [dbo].[pro_SelectNVByCMTND]
@cmtnd NCHAR(15)
AS
BEGIN
    SELECT * FROM dbo.NHANVIEN
	WHERE @cmtnd = dbo.NHANVIEN.cmtnd
END

GO
/****** Object:  StoredProcedure [dbo].[pro_SelectNVByEmail]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---
CREATE PROC [dbo].[pro_SelectNVByEmail]
@email NCHAR(50)
AS BEGIN
       SELECT * FROM dbo.NHANVIEN WHERE email = @email
   END

GO
/****** Object:  StoredProcedure [dbo].[pro_SelectNVById]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_SelectNVById]
@ma INT
AS BEGIN 
SELECT * FROM dbo.NHANVIEN
WHERE manv = @ma
END

GO
/****** Object:  StoredProcedure [dbo].[pro_SelectNVBySDT]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--
CREATE PROC [dbo].[pro_SelectNVBySDT]
@sdt NCHAR(15)
AS BEGIN
SELECT * FROM dbo.NHANVIEN
WHERE @sdt = sdt
END

GO
/****** Object:  StoredProcedure [dbo].[pro_SelectNVByUser]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--
CREATE PROC [dbo].[pro_SelectNVByUser]
@user NCHAR(30)
AS BEGIN
SELECT * FROM dbo.NHANVIEN WHERE tendangnhap = @user
END

GO
/****** Object:  StoredProcedure [dbo].[pro_SelectNVByUserPass]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_SelectNVByUserPass]
@user NCHAR(30),
@pass NCHAR(30)
AS
BEGIN
SELECT * FROM dbo.NHANVIEN
WHERE @user = tendangnhap AND @pass = matkhau
END

GO
/****** Object:  StoredProcedure [dbo].[pro_SelectPDKHByid]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_SelectPDKHByid]
@ma INT
AS
BEGIN
SELECT dbo.PHIEUDAT.maphieu, dbo.PHIEUDAT.makh, dbo.KHACHHANG.tenkh, dbo.PHIEUDAT.matour, dbo.TOUR.tentour, dbo.PHIEUDAT.ngaydat, dbo.PHIEUDAT.checkin, dbo.PHIEUDAT.slkhach, dbo.PHIEUDAT.sltreem, dbo.PHIEUDAT.trangthai FROM dbo.PHIEUDAT,dbo.KHACHHANG,dbo.TOUR
WHERE maphieu = @ma AND dbo.PHIEUDAT.makh = dbo.KHACHHANG.makh AND dbo.PHIEUDAT.matour = dbo.TOUR.ma
END

GO
/****** Object:  StoredProcedure [dbo].[pro_selectPhieuDatKH]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE  PROC [dbo].[pro_selectPhieuDatKH]
@makh INT
AS
BEGIN
    SELECT kh.makh AS [MaKH],kh.tenkh AS [TenKH],gt.ten AS [GT],kh.cmtnd,kh.sdt,kh.email,kh.diachi,t.ma AS [MaTour],t.tentour,t.diadiem AS [DD],t.songaytour,t.dongia,ph.maphieu,ph.ngaydat,ph.checkin,ph.slkhach,ph.sltreem,tt.ten AS [TrangThai]
	FROM ((((dbo.KHACHHANG AS kh
	INNER JOIN dbo.GIOITINH AS gt ON kh.gioitinh = gt.ma)
	INNER JOIN dbo.PHIEUDAT AS ph ON ph.makh = kh.makh)
	INNER JOIN dbo.TOUR AS t ON ph.matour = t.ma)
	INNER JOIN dbo.TRANGTHAI_PHIEU AS tt ON ph.trangthai = tt.ma)
	WHERE kh.makh = @makh
END

GO
/****** Object:  StoredProcedure [dbo].[pro_selectPhieuDatKH_byIDPhieu]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROC [dbo].[pro_selectPhieuDatKH_byIDPhieu]
@maphieu INT
AS
BEGIN
    SELECT kh.makh AS [MaKH],kh.tenkh AS [TenKH],gt.ten AS [GT],kh.cmtnd,kh.sdt,kh.email,kh.diachi,t.ma AS [MaTour],t.tentour,t.diadiem AS [DD],t.songaytour,t.dongia,ph.maphieu,ph.ngaydat,ph.checkin,ph.slkhach,ph.sltreem,tt.ten AS [TrangThai]
	FROM ((((dbo.KHACHHANG AS kh
	INNER JOIN dbo.GIOITINH AS gt ON kh.gioitinh = gt.ma)
	INNER JOIN dbo.PHIEUDAT AS ph ON ph.makh = kh.makh)
	INNER JOIN dbo.TOUR AS t ON ph.matour = t.ma)
	INNER JOIN dbo.TRANGTHAI_PHIEU AS tt ON ph.trangthai = tt.ma)
	WHERE ph.maphieu= @maphieu
END

GO
/****** Object:  StoredProcedure [dbo].[pro_SelectQuyen]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_SelectQuyen]
AS
BEGIN
SELECT * FROM dbo.GROUPUSER
END

GO
/****** Object:  StoredProcedure [dbo].[pro_SelectSDT]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_SelectSDT]
AS 
BEGIN
select sdt as sdt from dbo.KHACHHANG
UNION ALL
Select sdt as sdt from dbo.NHANVIEN
END

GO
/****** Object:  StoredProcedure [dbo].[pro_selectTourbyId]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_selectTourbyId]
@ma INT
AS BEGIN 
SELECT * FROM dbo.TOUR
WHERE ma = @ma
END 

GO
/****** Object:  StoredProcedure [dbo].[pro_SelectTTNV]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_SelectTTNV]
AS
BEGIN
SELECT * FROM dbo.TRANGTHAINV
END

GO
/****** Object:  StoredProcedure [dbo].[pro_SelectUser]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_SelectUser]
AS 
BEGIN
select tendangnhap as tendangnhap from dbo.KHACHHANG
UNION ALL
Select tendangnhap as tendangnhap from dbo.NHANVIEN
END

GO
/****** Object:  StoredProcedure [dbo].[pro_UpdateNgayDat]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_UpdateNgayDat]
@ngaydat DATE,
@ma INT
AS BEGIN
UPDATE dbo.PHIEUDAT 
SET ngaydat = @ngaydat
WHERE maphieu = @ma
END
GO
/****** Object:  StoredProcedure [dbo].[pro_UpdateNgayDatNV]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_UpdateNgayDatNV]
@ngaydat DATE,
@ma INT
AS BEGIN
UPDATE dbo.PHIEUDAT_NV
SET ngaydat = @ngaydat
WHERE maphieu = @ma
END
GO
/****** Object:  StoredProcedure [dbo].[pro_updatePDKH]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_updatePDKH]
@ma INT,
@checkin DATE,
@slkhach INT,
@sltreem INT
AS 
BEGIN
UPDATE dbo.PHIEUDAT
SET checkin = @checkin, slkhach = @slkhach, sltreem = @sltreem
WHERE maphieu = @ma
END

GO
/****** Object:  StoredProcedure [dbo].[pro_UpdateTour]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_UpdateTour]
@matour int,
@tentour nvarchar(100),
@urlimage nchar(200),
@gioithieu nvarchar(1000),
@diadiem nvarchar(50),
@songaytour INT,
@slkhachtoida INT,
@dongia FLOAT,
@ngaytao DATE,
@trangthai INT
AS
BEGIN
	UPDATE dbo.TOUR 
	SET tentour = @tentour, urlimage = @urlimage, gioithieu = @gioithieu, diadiem = @diadiem, songaytour = @songaytour, slkhachtoida = @slkhachtoida, dongia = @dongia, ngaytao = @ngaytao, trangthai = @trangthai
	WHERE ma = @matour
END

GO
/****** Object:  StoredProcedure [dbo].[pro_updateTTPhieu]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_updateTTPhieu]
@ma INT,
@trangthai INT
AS
BEGIN
    UPDATE dbo.PHIEUDAT
	SET trangthai = @trangthai
	WHERE maphieu = @ma
END
GO
/****** Object:  StoredProcedure [dbo].[pro_UseUpdate]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_UseUpdate]
@ma INT,
@tennv NVARCHAR(30),
@urlimage nchar(200),
@gioitinh INT,
@cmtnd nchar(15),
@sdt  nchar(15),
@email  nchar(50),
@diachi  nvarchar(100),
@tendangnhap nchar(30)
AS 
BEGIN 
UPDATE dbo.NHANVIEN 
SET tennv=@tennv,urlimage= @urlimage,gioitinh = @gioitinh, cmtnd = @cmtnd, sdt = @sdt, email = @email, diachi = @diachi, tendangnhap = tendangnhap
WHERE manv = @ma
END

GO
/****** Object:  StoredProcedure [dbo].[pro_UseUpdatePass]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pro_UseUpdatePass]
@ma INT,
@tendangnhap NCHAR(30),
@matkhau NCHAR(30)
AS BEGIN
       UPDATE dbo.NHANVIEN SET matkhau = @matkhau WHERE manv = @ma AND tendangnhap = @tendangnhap
   END
GO
/****** Object:  StoredProcedure [dbo].[thongtin_Tour_by_tukhoa]    Script Date: 3/5/2021 4:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[thongtin_Tour_by_tukhoa]
@TuKhoa nvarchar(100)
AS
BEGIN
	select * from dbo.TOUR where (trangthai = 1) AND ( tentour like N'%'+@TuKhoa+'%' or diadiem like N'%'+@TuKhoa+'%')
END


GO
