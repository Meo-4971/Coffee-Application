-- FUNCTION TRẢ VỀ BẢNG BẰNG CÂU LỆNH ĐƠN- hiển thị các món trong mỗi danh mục
CREATE FUNCTION cacMonTrongDanhMuc(@MaDanhMuc NVARCHAR(10)) RETURNS @MonTrongDanhMuc TABLE(MaThucUong NVARCHAR(10), TenThucUong NVARCHAR(30), DonGia INT, SoLuong INT)
AS
BEGIN
	IF (@MaDanhMuc != '')
		INSERT INTO @MonTrongDanhMuc(MaThucUong,TenThucUong, DonGia, SoLuong) SELECT MaThucUong ,TenThucUong, DonGia, SoLuong FROM THUCUONG 
																			WHERE THUCUONG.DanhMuc = @MaDanhMuc AND THUCUONG.TrangThaiMon =1
	ELSE -- Không nhập @MaThucUong
		INSERT INTO @MonTrongDanhMuc(MaThucUong,TenThucUong, DonGia, SoLuong) SELECT MaThucUong,TenThucUong, DonGia, SoLuong FROM THUCUONG	
																			WHERE THUCUONG.TrangThaiMon =1
	RETURN
END

GO

--- Lấy thông tin danh mục của quán
CREATE FUNCTION getDanhMuc() returns TABLE
	AS RETURN SELECT * FROM DANHMUC
GO


CREATE FUNCTION fn_XuatChiTietMotHoaDon (@maHoaDon int, @ngayGio Datetime)
RETURNS TABLE AS
RETURN 
(
	SELECT * FROM CHITIETHOADON
	WHERE MaHoaDon = @maHoaDon and CONVERT(DATE,NgayGio) = CONVERT(DATE,@ngayGio)
)

GO

---TÀI KHOẢN
----- Lấy tất cả các tài khoản
CREATE FUNCTION fn_GetTaiKhoan() RETURNS TABLE AS
	RETURN (SELECT MaNhanVien, TenNhanVien, MatKhau, ChucVu FROM NHANVIEN)

GO

----- Lấy ra một tài khoản thỏa mãn điều kiện
CREATE FUNCTION fn_GetMotTaiKhoan (@maNhanVien NVARCHAR(10), @matKhau NVARCHAR(20))
RETURNS TABLE AS
RETURN (SELECT * FROM fn_GetTaiKhoan() WHERE MaNhanVien = @maNhanVien and MatKhau = @matKhau)

