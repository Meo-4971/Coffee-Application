-- XUẤT CHITIETHOADON SAU KHI KHÁCH HÀNG NHẬN HÓA ĐƠN VÀ CHỜ LẤY NƯỚC
CREATE VIEW vi_ChiTietHoaDon AS
SELECT d.MaHoaDon, hd.MaNhanVien, nv.TenNhanVien, MaKhachHang,hd.NgayGio, m.TenThucUong, d.DonGia, d.SoLuong
FROM CHITIETHOADON d INNER JOIN THUCUONG m ON d.MaThucUong = m.MaThucUong
		INNER JOIN HOADON hd ON d.MaHoaDon = hd.MaHoaDon
		INNER JOIN NHANVIEN nv ON hd.MaNhanVien = nv.MaNhanVien

--TRÍCH XUẤT LỊCH SỬ BÁN HÀNG 
--(Mã hóa đơn, ngày giờ, thông tin nhân viên nhận order, thông tin món, giá tiền)
CREATE VIEW vi_LichSuBanHang AS
SELECT hd.MaHoaDon,hd.NgayGio, hd.MaKhachHang, kh.TenKhachHang, hd.MaNhanVien, nv.TenNhanVien, hd.TongHoaDon, hd.GiamGia
FROM HOADON hd, NHANVIEN nv, KHACHHANGTHANTHIET kh
WHERE hd.MaNhanVien = nv.MaNhanVien and hd.MaKhachHang = kh.SDT

--Hiển thị món trên MENU để khách hàng order

CREATE VIEW vi_Menu AS
SELECT TU.TenThucUong, TU.DonGia
FROM THUCUONG TU 
WHERE TU.TrangThaiMon = 1
drop view vi_Menu

CREATE View vi_XemDoanhThuNam 
AS
	SELECT YEAR(Ngay) AS Nam, SUM(DoanhThu) AS DoanhThuNam
	FROM DOANHTHU
	GROUP BY YEAR(Ngay)


-- View trả về danh sách khách hàng thân thiết
CREATE VIEW vi_GetInfoKhachHang
AS
	SELECT * FROM KHACHHANGTHANTHIET


CREATE VIEW vi_GetMaThucUong
AS
	SELECT MaThucUong, TenThucUong from THUCUONG

select MaThucUong from vi_GetMaThucUong where TenThucUong = 'Trà Sen Vàng'

CREATE VIEW vi_NhanVienList
AS
	SELECT *FROM NHANVIEN
GO
CREATE VIEW vi_Top5LoaiThucUongBanChayNhat AS
SELECT top(5)TenThucUong as 'Tên Món',Sum(b.SoLuong) as 'Số lượng bán được' from CHITIETHOADON b, THUCUONG a
		where a.MaThucUong = b.MaThucUong group by TenThucUong order by Sum(b.SoLuong) DESC
GO

GO
CREATE VIEW vi_Top5LoaiThucUongBanItNhat AS
SELECT top(5)TenThucUong as 'Tên Món',Sum(b.SoLuong) as 'Số lượng bán được' from CHITIETHOADON b, THUCUONG a
		where a.MaThucUong = b.MaThucUong group by TenThucUong order by Sum(b.SoLuong) ASC
GO

GO
CREATE VIEW vi_CacMonKhongBanDuoc AS
SELECT TenThucUong as 'Tên Món' from THUCUONG a, CHITIETHOADON b
		where a.MaThucUong != b.MaThucUong group by TenThucUong
GO