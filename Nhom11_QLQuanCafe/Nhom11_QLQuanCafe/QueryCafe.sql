
--------------------------
go
create trigger autoIDNhanVien 
on NHANVIEN
after insert
as
begin
		Declare @MaNV varchar(10)
		if not exists (select * from NHANVIEN) 
			Set @MaNV =1
		else
			Set @MaNV =(select RIGHT(MAX(MANV),3) from NHANVIEN)+1
		Set @MaNV ='NV'+REPLICATE('0',3-LEN(@MaNV))+@MaNV 
		
		update NHANVIEN set MANV=@MaNV  where MANV=(select MANV from inserted)
	end

-----------------------------------------
go
create proc ThonTinNV
as
	select *
	from NHANVIEN
---------------------------------------
go
create proc ThonTinCV
as
	select *
	from CHUCVU
---------------------------------------
go
create proc ThongTinTenCV @macv varchar(20)
as
	select TENCV
	from CHUCVU
	where MACV=@macv

----------------------------------------
go
CREATE proc ThongTinTenCV1 @tencv nvarchar(20)
as
	select MACV
	from CHUCVU
	where TENCV=@tencv
---------------------------------------
go
create trigger XoaPhanCong
on NHANVIEN
instead of delete
as
	declare @idnv varchar(20)= (select MANV from deleted)

	update  PHANCONG set MANV=NULL where MANV=@idnv
	update  HOADON set MANV=NULL where MANV=@idnv
	update  HOADONNHAP set MANV=NULL where MANV=@idnv
	update  TAIKHOAN set MANV=NULL where MANV=@idnv
	delete from NHANVIEN where MANV=@idnv
----------------------------
go
CREATE proc XoaNV @manv varchar(20)
as
	delete from NHANVIEN where MANV=@manv

--------------------------
go
create proc CongViec 
as
	select TENCV
	from CHUCVU
-----------------------------
go
create proc SuaNV @manv varchar(20), @macv varchar(20),@tennv nvarchar(50), @gioitinh nvarchar(10), @ngaysinh varchar(20), @sdt varchar(20)
as
	set dateformat dmy
	update NHANVIEN set MACV=@macv,TENNV=@tennv, GIOITINH=@gioitinh,NGAYSINH=@ngaysinh, SDT=@sdt where MANV=@manv

-----------------------------------------
go
CREATE proc themNV @macv varchar(20),@tennv nvarchar(50), @gioitinh nvarchar(10), @ngaysinh varchar(20), @sdt varchar(20)
as
	
	set dateformat dmy
	insert into NHANVIEN values ('0',@macv,@tennv,@gioitinh,@ngaysinh,@sdt)
----------------------------------------
go
--KHUYẾN MÃI
create trigger XoaKhuyenMai
on KHUYENMAI
instead of delete
as
	declare @idkm varchar(20)= (select MAKM from deleted)
	
	delete from DUOCKHUYENMAI  where MAKM=@idkm
	delete from KHUYENMAI where MAKM=@idkm
------------------------
go

CREATE proc XoaKM @makm varchar(20)
as
	delete from KHUYENMAI where MAKM=@makm
-----------------------------------
go
create proc suaKM @makm varchar(20), @tensk nvarchar(50), @noidung nvarchar(50), @tile varchar(20)
as
	update KHUYENMAI set  TENSUKIEN= @tensk, NOIDUNG=@noidung, TILEKM=@tile where MAKM=@makm
------------------------
go
create proc themKM @tensk nvarchar(50), @noidung nvarchar(50), @tile varchar(20)
as
	insert into KHUYENMAI values('00',@tensk,@noidung,@tile)
	
----------------------------------
go
create proc ThongTinKhuyenMai
as
	select *
	from KHUYENMAI
---------------------------------
go
CREATE proc ThongTinKhuyenMai1
as
	select MAKM,TENSUKIEN,NOIDUNG
	from KHUYENMAI
----------------------------------
go
CREATE proc DuocKM
as
	select ID,d.MAKM,TENSP, TENSUKIEN,NOIDUNG, NGAYBD, NGAYKT
	from DUOCKHUYENMAI d, KHUYENMAI k, SANPHAM s
	where d.MAKM=k.MAKM and d.MASP=s.MASP


------------------------------------
go
create proc xoaSPKhuyenMai @idKM varchar(20)
as
	delete from DUOCKHUYENMAI where ID=@idKM
--------------------------------------
go
create proc allSP_DKM
as
	select TENSP
	from SANPHAM
-----------------------
go
create proc allMKM
as
	select MAKM
	from KHUYENMAI
---------------------------------
go
create proc suaSPKM @idd varchar(10),@makm varchar(10), @tenspkm nvarchar(10), @ngaybd varchar(20), @ngaykt  varchar(20)
as
	declare @idsp varchar(20) = (select MASP from SANPHAM where TENSP=@tenspkm)
	set dateformat dmy
	update DUOCKHUYENMAI set MASP=@idsp,MAKM=@makm, NGAYBD=@ngaybd, NGAYKT=@ngaykt where ID=@idd
---------------------------------
go
CREATE proc themSPKM @makm varchar(10), @tenspkm nvarchar(100), @ngaybd varchar(20), @ngaykt  varchar(20)
as
	declare @idsp varchar(20) = (select MASP from SANPHAM where TENSP=@tenspkm)
	set dateformat dmy
	insert into DUOCKHUYENMAI values (@idsp, @makm,@ngaybd,@ngaykt,'0')

-----------------------------------------------
go
create trigger autoIDKhuyenMai
on KHUYENMAI
after insert
as
begin
		Declare @MaKM varchar(10)
		if not exists (select * from KHUYENMAI) 
			Set @MaKM =1
		else
			Set @MaKM =(select RIGHT(MAX(MAKM),3) from KHUYENMAI)+1
		Set @MaKM='KM'+REPLICATE('0',3-LEN(@MaKM))+@MaKM
		
		update KHUYENMAI set MAKM=@MaKM where MAKM=(select MAKM from inserted)
end

go
create trigger autoIDDUOCKHUYENMAI
on DUOCKHUYENMAI
after insert
as
begin
		Declare @ID varchar(10)
		if not exists (select * from DUOCKHUYENMAI) 
			Set @ID =1
		else
			Set @ID =(select RIGHT(MAX(ID),2) from DUOCKHUYENMAI)+1
		Set @ID='ID'+REPLICATE('0',2-LEN(@ID))+@ID
		
		update DUOCKHUYENMAI set ID=@ID where ID=(select ID from inserted)
	end
----------------------------------------
--drop trigger autoIDKhachHang
--on KHACHHANG
--after insert
--as
--begin
--		Declare @ID varchar(10)
--		if not exists (select * from KHACHHANG) 
--			Set @ID =1
--		else
--			Set @ID =(select RIGHT(MAX(MAKH),2) from KHACHHANG)+1
--		Set @ID='ID'+REPLICATE('0',2-LEN(@ID))+@ID
		
--		update KHACHHANG set MAKH=@ID where MAKH=(select MAKH from inserted)
--	end
-----------------------------------
go
create trigger autoIDHoaDon
on HOADON
after insert
as
begin
		Declare @ID varchar(10)
		if not exists (select * from HOADON) 
			Set @ID =1
		else
			Set @ID =(select RIGHT(MAX(MAHD),2) from HOADON)+1
		Set @ID='HD'+REPLICATE('0',2-LEN(@ID))+@ID
		
		update HOADON set MAHD=@ID where MAHD=(select MAHD from inserted)
	end
----------------------------------------
go
create trigger ttBan
on HOADON
after insert
as
begin
	update BAN set TINHTRANG =N'Hoạt động' where MABAN=(select MABAN from inserted)
end
-----------------------------------------

-------------------------------------


--delete


--------------------------------------------------------
go
CREATE proc DonGiaSP @tensp nvarchar(50)
as
	select * from SANPHAM where TENSP=@tensp
-------------------------------------------------------
go
CREATE proc aCTHD @TenSP nvarchar(50), @TongTien varchar(20)
as
	declare @idsp varchar(20) = (select MASP from SANPHAM where TENSP=@tensp)
	if exists( select * from  DUOCKHUYENMAI d where d.MASP=@idsp)
	begin
		declare @tile int = (select TILEKM from KHUYENMAI k, DUOCKHUYENMAI d where d.MAKM=k.MAKM and d.MASP= @idsp)

		select   @TongTien- ((@TongTien*@tile)/100) as 'Sale'
		

	end
	else
	begin
		select   @TongTien as 'Sale'
		
	end

---------------------------------------------------------
go
CREATE proc ThongTinHD
as	
	select b.TENBAN,h.TONGTIEN,h.TINHTRANG,h.MAHD, k.TENKH, NGAYBAN
	from HOADON h,BAN b,KHACHHANG k,SANPHAM s
	where b.MABAN=h.MABAN and k.MAKH = h.MAKH 
	group by  h.MAHD,b.TENBAN,k.TENKH, NGAYBAN,h.TONGTIEN,h.TINHTRANG
	ORDER BY h.TINHTRANG DESC 

----------------------------------------------------------
go
create trigger capnhapIsHD
on CHITIETHD
after insert
as
begin
	declare @aa int=(select sum(GIAMGIA) from CHITIETHD c where MAHD=(select MAHD from inserted))
	update HOADON set TONGTIEN =@aa where MAHD=(select MAHD from inserted)
end
--------------------------
go
create trigger capnhapUdHD
on CHITIETHD
after update
as
begin
	declare @aa int=(select sum(GIAMGIA) from CHITIETHD c where MAHD=(select MAHD from inserted))
	update HOADON set TONGTIEN =@aa where MAHD=(select MAHD from inserted)
end
---------------------------
go
create trigger capnhapDelHD
on CHITIETHD
after delete
as
begin
	declare @aa int=(select sum(GIAMGIA) from CHITIETHD c where MAHD=(select MAHD from deleted))
	update HOADON set TONGTIEN =@aa where MAHD=(select MAHD from deleted)
end
---------------------------
go
CREATE proc ThongTinCTHD @maHD varchar(20)
as
	select TENSP,s.GIABAN,SL,s.GIABAN*SL as 'TONGTIEN',c.GIAMGIA
	from SANPHAM s, CHITIETHD c, HOADON h
	where s.MASP=c.MASP and h.MAHD = c.MAHD and c.MAHD=@maHD
----------------------------------------------------------
go
CREATE proc XoaCTHD @maHD varchar(20), @tensp nvarchar(50)
as
	declare @idsp varchar(20) = (select MASP from SANPHAM where TENSP=@tensp)

	delete from CHITIETHD where MAHD=@maHD and MASP=@idsp

------------------------------------------------------
go
CREATE proc SuaCTHD @maHD varchar(20), @tensp nvarchar(50), @sl varchar(50), @giam varchar(20),@tong varchar(20)
as
	declare @idsp varchar(20) = (select MASP from SANPHAM where TENSP=@tensp)

	update CHITIETHD set SL=@sl,THANHTIEN=@tong,GIAMGIA=@giam where MASP=@idsp and MAHD=@maHD
-----------------------------------------------------
go

CREATE proc ThemCTHD @maHD varchar(20), @tensp nvarchar(50), @sl varchar(50), @giam varchar(20),@tong varchar(20)
as
	declare @idsp varchar(20) = (select MASP from SANPHAM where TENSP=@tensp)
	if exists (select * from CHITIETHD where MASP=@idsp and MAHD=@maHD)
	begin
		update CHITIETHD set SL=SL+@sl,THANHTIEN=THANHTIEN+@tong,GIAMGIA=GIAMGIA+@giam where MASP=@idsp and MAHD=@maHD
	end
	else
	begin
		insert into CHITIETHD values (@idsp,@maHD,@tong,@sl,@giam)
	end
-----------------------------------------------------------
go
create proc loadB
as
	select *
	from Ban
-----------------------------------------
go
create proc loadBan @tenb nvarchar(20)
as
	select *
	from Ban
	where TENBAN=@tenb
-----------------------------------------------
go
create proc tinhtrangban  @tenb nvarchar(20)
as
	update BAN set TINHTRANG=N'Hoạt động' where TENBAN=@tenb
-------------------------------------
go
create proc themKH @tenkh nvarchar(50), @phai nvarchar(20), @sdt varchar(20)
as
	insert into KHACHHANG values ('0',@tenkh,@phai,@sdt)
-----------------------------------------------------
go
CREATE proc themHD @mab varchar(10),@tenkh nvarchar(50), @phai nvarchar(20), @sdt varchar(20),@manv varchar(10),@ngay varchar(20)
as
--thêm kh
		Declare @ID varchar(10)
		if not exists (select * from KHACHHANG) 
			Set @ID =1
		else
			Set @ID =(select RIGHT(MAX(MAKH),2) from KHACHHANG)+1
		Set @ID='KH'+REPLICATE('0',2-LEN(@ID))+@ID
		insert into KHACHHANG values (@ID,@tenkh,@phai,@sdt)

--Tao hd
		set dateformat dmy
		insert into HOADON values ('0',@mab,@ID,@manv,@ngay,NULL,N'Mới')

-----------------------------
go
CREATE proc TongTienHD @maHD varchar(20)
as
	select b.TENBAN,k.TENKH,k.SDTKH,h.TONGTIEN
	from HOADON h,BAN b,KHACHHANG k
	where h.MAHD=@mahd and b.MABAN=h.MABAN and k.MAKH=h.MAKH
----------------------------
go
CREATE proc tinhtrangbanTrong  @tenb nvarchar(20)
as
	update BAN set TINHTRANG=N'Trống' where TENBAN=@tenb

-----------------------
go
create proc tinhtrangHD @idhd varchar(20)
as
	update HOADON set TINHTRANG =N'Cũ' where MAHD=@idhd
	
go
CREATE proc sesssion @ten varchar(20)
as
	select MANV
	from TAIKHOAN 
	where TENNGUOIDUNG =@ten


go
USE [QL_QUANCAFE]
GO
/****** Object:  StoredProcedure [dbo].[capNhatNguyenLieu]    Script Date: 1/4/2023 12:42:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[capNhatNguyenLieu]
(
	@ten nvarchar(30),
	@sl int,
	@hsd date,
	@dg float,
	@ma varchar(10)
)
AS
	SET NOCOUNT OFF;
update NGUYENLIEU set TENNL=@ten, SOLUONGCON=@sl, HANSD=@hsd, DONGIA=@dg where MANL=@ma

/****** Object:  StoredProcedure [dbo].[hienThiChiTietHoaDonNhap]    Script Date: 1/4/2023 12:43:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[hienThiChiTietHoaDonNhap]
(
	@MA varchar(10)
)
AS
	SET NOCOUNT ON;
SELECT MANL, MAHDNHAP, SOLUONGNHAP, THANHTIENNHAP
FROM     CHITIETHDN
WHERE  (MAHDNHAP = @MA)

/****** Object:  StoredProcedure [dbo].[hienThiDSHoaDonNhap]    Script Date: 1/4/2023 12:43:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--proc hiển thị danh sách hóa đơn nhập
CREATE proc [dbo].[hienThiDSHoaDonNhap]
as
begin
	select * from HOADONNHAP
end

/****** Object:  StoredProcedure [dbo].[hienThiDSNguyenLieu]    Script Date: 1/4/2023 12:43:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[hienThiDSNguyenLieu]
as
begin
	select * from NGUYENLIEU
end

/****** Object:  StoredProcedure [dbo].[procCapNhatHoaDonNhap]    Script Date: 1/4/2023 12:43:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[procCapNhatHoaDonNhap]
(
	@NCC varchar(10),
	@NV varchar(10),
	@TIEN float,
	@NGAY date,
	@GC nvarchar(30),
	@HDN varchar(10)
)
AS
	SET NOCOUNT OFF;
UPDATE HOADONNHAP SET MANCC=@NCC, MANV=@NV, TONGTIENNHAP=@TIEN, NGAYNHAP=@NGAY, GHICHU=@GC WHERE MAHDNHAP=@HDN

/****** Object:  StoredProcedure [dbo].[procCapNhatNguyenLieu]    Script Date: 1/4/2023 12:44:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[procCapNhatNguyenLieu]
(
	@TEN nvarchar(30),
	@SL int,
	@HSD date,
	@DG float,
	@MA varchar(10)
)
AS
	SET NOCOUNT OFF;
UPDATE NGUYENLIEU SET TENNL=@TEN, SOLUONGCON=@SL, HANSD=@HSD, DONGIA=@DG WHERE MANL=@MA

/****** Object:  StoredProcedure [dbo].[procHienThiChiTietHoaDonNhap]    Script Date: 1/4/2023 12:44:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[procHienThiChiTietHoaDonNhap]
(
	@MA varchar(10)
)
AS
	SET NOCOUNT ON;
SELECT MANL, MAHDNHAP, SOLUONGNHAP, THANHTIENNHAP FROM dbo.CHITIETHDN WHERE MAHDNHAP=@MA

/****** Object:  StoredProcedure [dbo].[procXoaHoaDonNhap]    Script Date: 1/4/2023 12:44:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[procXoaHoaDonNhap]
(
	@ma varchar(10)
)
AS
	SET NOCOUNT OFF;
delete HOADONNHAP where MAHDNHAP=@ma

/****** Object:  StoredProcedure [dbo].[procXoaNguyenLieu]    Script Date: 1/4/2023 12:44:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[procXoaNguyenLieu]
(
	@ma varchar(10)
)
AS
	SET NOCOUNT OFF;
delete NGUYENLIEU where MANL=@ma


----------------------------------------------

--trigger tự động tăng mã loại khi thêm 1 loại sản phẩm mới
create trigger Them_1LoaiSP on LOAI
for insert 
as
	begin
		Declare @maloai varchar(10)
		if not exists (select * from LOAI)
			Set @maloai =1
		else
			Set @maloai =(select RIGHT(MAX(MALOAI), 2) from LOAI)+1

		Set @maloai ='L' + REPLICATE('0',3 - LEN(@maloai))+ @maloai
		update LOAI set MALOAI = @maloai where MALOAI = (select MALOAI from inserted )
	end

go

--trigger tự động tăng mã sản phẩm khi thêm 1 sản phẩm mới
create trigger Them_1SP on SANPHAM
for insert 
as
	begin
		Declare @masp varchar(10)
		if not exists (select * from SANPHAM)
			Set @masp =1
		else
			Set @masp =(select RIGHT(MAX(MASP), 2) from SANPHAM)+1

		Set @masp ='SP' + REPLICATE('0',3 - LEN(@masp))+ @masp
		update SANPHAM set MASP = @masp where MASP = (select MASP from inserted )
	end
go


--trigger tự động tăng mã nhà cung cấp khi thêm 1 nhà cung cấpm mới
create trigger Them_1NCC on NHACUNGCAP
for insert 
as
	begin
		Declare @mancc varchar(10)
		if not exists (select * from NHACUNGCAP)
			Set @mancc =1
		else
			Set @mancc =(select RIGHT(MAX(MANCC), 1) from NHACUNGCAP)+1

		Set @mancc ='NCC' + REPLICATE('0',2 - LEN(@mancc))+ @mancc
		update NHACUNGCAP set MANCC = @mancc where MANCC = (select MANCC from inserted )
	end