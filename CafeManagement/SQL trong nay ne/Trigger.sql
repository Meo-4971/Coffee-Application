USE CAFE_MANAGEMENT
GO
-- Khi thuc hien xoa mon, khong xoa vinh vien 
--ma chi set gia tri cua bien trang thai la 0 (tuc la khong ton tai)
CREATE TRIGGER tg_XoaMon on [THUCUONG]
INSTEAD OF DELETE
AS
	DECLARE @old nvarchar(10)
	SELECT @old = ol.MaThucUong FROM deleted ol
	BEGIN
		UPDATE THUCUONG SET TrangThaiMon = 0 WHERE THUCUONG.MaThucUong = @old
	END



--trigger thêm món
--Khi thuc hien them 1 mon moi vao MENU thi trang thai cua no mac dinh la "dang ton tai"
CREATE TRIGGER tg_ThemMon on [THUCUONG]
AFTER INSERT
AS
	DECLARE @new NVARCHAR(10)
	SELECT 	@new = ne.MaThucUong from inserted ne
	BEGIN
		UPDATE THUCUONG SET TrangThaiMon = 1 where MaThucUong = @new
	END



---Để hạn chế lãng phí bộ nhớ, khi bước sang ngày mới thì mã hóa đơn sẽ tự quay đầu thành 1	
CREATE TRIGGER tg_InsertHoaDon on [HOADON]
INSTEAD OF INSERT
AS
	DECLARE @newMaHoaDon INT, @newNgayGio DATETIME , @newNgay DATE, @Ngay DATE, @newMaKhacHang nvarchar(20), 
			@newMaNhanVien nvarchar(10), @newTongHoaDon MONEY, @newGiamGia MONEY, @MHDTemp INT;

	SELECT @newMaHoaDon = ne.MaHoaDon, @newNgayGio = ne.NgayGio, @newMaKhacHang = ne.MaKhachHang, @newMaNhanVien = ne.MaNhanVien,
			@newTongHoaDon = ne.TongHoaDon, @newGiamGia = ne.GiamGia  FROM inserted ne;

	SET @newNgay = CONVERT (DATE,@newNgayGio);
	SET @Ngay = CONVERT (DATE,(SELECT MAX(NgayGio) FROM HOADON)) -- Ngày mới nhất trong bảng hóa đơn
	
	SET XACT_ABORT ON
	BEGIN TRAN INSERT_HoaDon

	---Để hạn chế lãng phí bộ nhớ, khi bước sang ngày mới thì mã hóa đơn sẽ tự quay đầu thành 1	
	IF (@newNgay > @Ngay OR NOT EXISTS(SELECT NgayGio FROM HOADON) OR (@newNgay NOT IN (SELECT CONVERT (DATE, NgayGio) FROM HOADON)) )-- BẮT ĐÀU NGÀY MỚI
		BEGIN
			SET @newMaHoaDon = 1;
		END
	ELSE -- Trong ngày đã có hóa đơn
		BEGIN
			SET @MHDTemp = (SELECT MAX(MaHoaDon) FROM HOADON WHERE CONVERT (DATE,NgayGio) = CONVERT (DATE,@newNgay))
			SET @newMaHoaDon = @MHDTemp+1;
		END
	--- nếu khách hàng không cung cấp số điện thoại thì set mã khách hàng thành null
	IF @newMaKhacHang = ''
		SET @newMaKhacHang = null

	--- Thanh toán thành công thì hóa đơn mới sẽ được thêm, số lượng còn lại của các món sẽ được cập nhật lại
	
	INSERT INTO HOADON VALUES  (@newMaHoaDon, @newNgayGio,@newMaKhacHang , @newMaNhanVien, @newTongHoaDon, @newGiamGia)
	COMMIT TRAN INSERT_HoaDon

drop trigger tg_InsertHoaDon



CREATE TRIGGER tg_TinhLuongMoiThang on [LUONGMOITHANG]
INSTEAD OF INSERT AS
BEGIN
	DECLARE @newMaNhanVien NVARCHAR(10), @newThang INT, @newNam INT, @newLuong INT, @newTrangThai BIT;
	SELECT @newMaNhanVien = ne.MaNhanVien, @newTrangThai = ne.TinhTrang FROM inserted ne;

	SET @newThang = DATEPART(MONTH, GETDATE());
	SET @newNam = DATEPART (YEAR, GETDATE());
	SET @newLuong = (SELECT [dbo].tinhLuong(@newMaNhanVien));

	SET XACT_ABORT ON
	BEGIN TRAN
		IF @newLuong != 0 -- Tháng đó nhân viên đã làm được một số giờ nhất định
		BEGIN
			DECLARE @check int
			SET @check = (SELECT dbo.fn_CheckExist(@newMaNhanVien, @newThang, @newNam)) ---Trả về 1 nếu đã tồn tại nhân viên đó trong bảng thanh toán lương ngược lại thì trả về 0
			IF (@check = 1 AND @newTrangThai = 0)
				UPDATE LUONGMOITHANG SET Luong = Luong + @newLuong WHERE MaNhanVien = @newMaNhanVien AND Thang = @newThang AND Nam = @newNam AND TinhTrang = 0 
			ELSE
				INSERT INTO LUONGMOITHANG VALUES (@newMaNhanVien, @newThang, @newNam, @newLuong, @newTrangThai);

			UPDATE NHANVIEN SET SoGioLamViec = 0 WHERE MaNhanVien = @newMaNhanVien;
		END
		--ELSE -- Chưa làm được giờ nào hoặc đã tính lương rồi
	COMMIT TRAN
END

drop trigger tg_TinhLuongMoiThang






---------------TRIGGER CẬP NHẬT DOANH THU KHI THÊM HÓA ĐƠN------------------------------------------------------------------------
CREATE TRIGGER tg_CapNhatDoanhThu on [HOADON]
AFTER INSERT 
AS
	DECLARE @date date, @tongtien int, @giamgia int
	SELECT @date = (SELECT CONVERT (DATE, ne.NgayGio)), @tongtien = ne.TongHoaDon , @giamgia = ne.GiamGia
	FROM inserted ne
	IF @date in (SELECT DISTINCT d.Ngay FROM DOANHTHU d )
	BEGIN
		UPDATE DOANHTHU SET DoanhThu = DoanhThu + @tongtien - @giamgia WHERE Ngay = @date
	END
	ELSE
		INSERT INTO DOANHTHU (Ngay,DoanhThu) VALUES (@date,(@tongtien-@giamgia) )


drop trigger tg_CapNhatDoanhThu


-- Trigger XoaNhanVien Thay vì xóa hoàn toàn nhân viên thì hệ thống chỉ cập nhật trạng thái của nhân viên đó từ đang làm việc sang đã nghỉ việc
CREATE TRIGGER tg_XoaNhanVien on [NhanVien]
INSTEAD OF DELETE
AS
	DECLARE @old nvarchar(10)
	SELECT @old = ol.MaNhanVien FROM deleted ol
	BEGIN
		UPDATE NHANVIEN SET TrangThai = 0 WHERE NHANVIEN.MaNhanVien = @old
	END
GO

CREATE TRIGGER tg_UpdateDiemTichLuy on HOADON
AFTER INSERT AS
BEGIN
	DECLARE @makhachhang varchar(10),@tonghoadon int,@diemtichluy int
	SELECT @makhachhang = temp.MaKhachHang ,@tonghoadon = temp.TongHoaDon
	FROM inserted temp
	Update KHACHHANGTHANTHIET set DiemTichLuy = DiemTichLuy + @tonghoadon / 10000 WHERE @makhachhang = SDT
END
GO