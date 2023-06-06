--- Tính thành tiền của mỗi món trong duoc goi
CREATE FUNCTION tinhThanhTien(@DonGia INT, @SoLuong INT) RETURNS INT
AS
	BEGIN
		DECLARE @ThanhTien INT;
		SELECT @ThanhTien = @DonGia * @SoLuong;
		RETURN @ThanhTien
	END
GO
/*------Tính thành tiền
CREATE FUNCTION tinhThanhTien(@MaThucUong NVARCHAR(10), @SoLuong INT) RETURNS INT
AS
	BEGIN
		DECLARE @ThanhTien INT, @DonGia INT;
		SELECT @DonGia =DonGia FROM THUCUONG WHERE MaThucUong = @MaThucUong;
		SELECT @ThanhTien = @DonGia * @SoLuong;
		RETURN @ThanhTien
	END*/

GO
--- Tính tổng tiền trên hóa đơn
CREATE FUNCTION tinhTongHoaDon(@TongHoaDon INT, @ThanhTien INT) RETURNS INT
AS
	BEGIN
		SELECT @TongHoaDon = @TongHoaDon +@ThanhTien;
		RETURN @TongHoaDon;
	END
GO
--- Lấy mã hóa đơn mới nhất của ngày hiện tại
CREATE FUNCTION fn_LayMaHoaDonHienTai (@ngayGioHienTai DATETIME)
RETURNS INT AS
BEGIN
	DECLARE @maHoaDonHienTai INT
	SELECT @maHoaDonHienTai = MAX(MaHoaDon) FROM HOADON WHERE CONVERT(DATE, NgayGio) = CONVERT(DATE, @ngayGioHienTai)
	RETURN @maHoaDonHienTai
END

GO

select dbo.fn_LayMaHoaDonHienTai ('2022/11/17')

GO

--- Tính số tiền được giảm khi quy đổi điểm tích lũy Mỗi 1 điểm tích lũy sẽ được giảm 1000đ trên tổng hóa đơn.
CREATE FUNCTION giamGia(@MaKhachHang NVARCHAR(20), @TongHoaDon INT) RETURNS INT
AS 
	BEGIN
		DECLARE @SoTienGiam INT, @DiemTichLuy INT;
		SELECT @DiemTichLuy = DiemTichLuy FROM dbo.KHACHHANGTHANTHIET WHERE SDT = @MaKhachHang
		SELECT @SoTienGiam = @DiemTichLuy *1000;

		IF (@SoTienGiam > (@TongHoaDon/2) )
			SET @SoTienGiam = (@TongHoaDon/2);
		RETURN @SoTienGiam
	END
GO
--- Tính số tiền phải trả sau khi được giảm giá
CREATE FUNCTION tinhSoTienPhaiTra(@MaKhachHang NVARCHAR(20), @TongHoaDon INT,  @DungDiem BIT ) RETURNS INT
AS
	BEGIN
		IF(EXISTS(SELECT SDT FROM KHACHHANGTHANTHIET WHERE SDT = @MaKhachHang))-- Là khách hàng thân thiết
		BEGIN
			DECLARE @SoTienPhaiTra INT;
			IF(@DungDiem =1)
			BEGIN
				SELECT @SoTienPhaiTra = @TongHoaDon - dbo.giamGia(@MaKhachHang, @TongHoaDon);
			END
			SELECT @SoTienPhaiTra = @TongHoaDon;
		END
		ELSE SELECT @SoTienPhaiTra = @TongHoaDon-- Không là khách hàng thân thiết
		RETURN @SoTienPhaiTra;
	END
GO
--- Tính lương hằng tháng cho nhân viên
CREATE FUNCTION tinhLuong (@MaNhanVien NVARCHAR(10)) RETURNS INT
AS
BEGIN
	RETURN (SELECT (Luong * SoGioLamViec) FROM NHANVIEN WHERE MaNhanVien =@MaNhanVien)	
END
GO
-- Kiểm tra xem nhân viên đó đã có tên trong bảng tính lương của tháng đó chưa
CREATE FUNCTION fn_CheckExist (@MaNhanVien NVARCHAR(10), @Thang int, @Nam int) RETURNS INT
AS
BEGIN
	DECLARE @check int, @result int
	SET @check = (SELECT COUNT(*) FROM LUONGMOITHANG WHERE MaNhanVien = @MaNhanVien AND Thang = @Thang AND Nam = @Nam AND Tinhtrang = 0)
	IF(@check>0)
		SET @result = 1
	ELSE
		SET @result = 0
	RETURN(@result)
END
GO
-- Lấy tên thức uống từ mã thức uống
CREATE FUNCTION fn_GetTenThucUong (@maMon NVARCHAR(10))
RETURNS NVARCHAR(50) AS
BEGIN
	DECLARE @tenMon NVARCHAR(50);
	SELECT @tenMon = TenThucUong FROM THUCUONG WHERE MaThucUong = @maMon
	RETURN @tenMon
END