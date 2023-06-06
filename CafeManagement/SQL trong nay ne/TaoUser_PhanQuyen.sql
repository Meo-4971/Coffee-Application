


--(I) Tạo USER LOGIN 
CREATE LOGIN [QuanLy] with PASSWORD = '1',
DEFAULT_DATABASE = [CAFE_MANAGEMENT]
GO

CREATE LOGIN [NhanVien] WITH PASSWORD ='2',
DEFAULT_DATABASE = [CAFE_MANAGEMENT]
GO

--(II) Tạo User liên kết với User Login
CREATE USER [QuanLy] FOR LOGIN [QuanLy]
CREATE USER [NhanVien] FOR LOGIN [NhanVien]
GO

--(III) Tạo role và cấp quyền cho role
CREATE ROLE ThanhToan
CREATE ROLE NhanOrder
GO

CREATE ROLE QuanLyNhanVien
CREATE ROLE QuanLyKhachHang
CREATE ROLE QuanLyDanhMuc
CREATE ROLE QuanLyMon
CREATE ROLE QuanLyHoaDon
CREATE ROLE QuanLyDoanhThu
GO

--(1) Cấp quyền cho role Thanh toán
/*GRANT SELECT ON [dbo].[tinhThanhTien] TO ThanhToan
GRANT SELECT ON [dbo].[tinhTongHoaDon] TO ThanhToan
GRANT SELECT ON [dbo].[giamGia] TO ThanhToan
GRANT SELECT ON [dbo].[tinhSoTienPhaiTra] TO ThanhToan*/
GRANT SELECT ON [dbo].[fn_XuatChiTietMotHoaDon] TO  ThanhToan
GRANT EXEC ON [dbo].[sp_TimKiemKhachHangTheoMa] TO ThanhToan -- Thực hiện kiểm tra xem khách hàng đã là khách hàng thân thiết chưa để áp dụng các giảm giá
GRANT EXEC ON [dbo].[sp_ThemKhachHang] TO ThanhToan -- Thực hiện đăng kí trở thành khách hàng thân thiết
GRANT EXEC ON[dbo].[sp_CapNhatDiemTichLuy] TO ThanhToan -- Cập nhật lại điểm tích lũy của khách hàng sau mỗi lần thanh toán hóa đơn
GRANT EXEC ON [dbo].[sp_CapNhatTongChiTieu] TO ThanhToan -- Cập nhật lại tổng chi tiêu của khách hàng sau khi thanh toán
--GRANT SELECT ON [dbo].[fn_LayHoaDonHienTai] TO ThanhToan
GRANT SELECT ON [dbo].[vi_GetMaThucUong] TO ThanhToan -- Lấy mã thức uống từ tên thức uống
GO

--(2) Cấp quyền cho role Nhận order
GRANT EXEC ON [dbo].[sp_ThemChiTietHoaDon] TO NhanOrder
GRANT EXEC ON [dbo].[sp_ThemHoaDon] TO NhanOrder
GRANT EXEC ON [dbo].[sp_TinhSoGioLam] TO NhanOrder --khi thực hiện đang xuất, khoảng thời gian từ lúc đăng nhập đến lúc đăng xuất
														--sẽ đc cập nhật lại vào cột số giờ làm ở bảng nhân viên
GRANT SELECT ON [dbo].[cacMonTrongDanhMuc] TO NhanOrder -- load các món trong mỗi danh muc trên menu
GRANT SELECT ON [dbo].[getDanhMuc] TO NhanOrder
GO

---(3) Cấp quyền cho role quản lý nhân viên
GRANT SELECT ON [dbo].[vi_NhanVienList] TO QuanLyNhanVien
GRANT EXEC ON [dbo].[sp_ThemNhanVien] TO QuanLyNhanVien
GRANT EXEC ON [dbo].[sp_XoaNhanVien] TO QuanLyNhanVien
GRANT EXEC ON [dbo].[sp_CapNhatNhanVien] TO QuanLyNhanVien
GRANT EXEC ON [dbo].[sp_TimKiemNVTheoMa] TO QuanLyNhanVien
GRANT EXEC ON [dbo].[sp_TimKiemNVTheoTen] TO QuanLyNhanVien
--GRANT SELECT ON [dbo].[tinhLuong] TO QuanLyNhanVien
--GRANT SELECT ON [dbo].[fn_CheckExist] TO QuanLyNhanVien -- Kiểm tra nhân viên đã được thanh toán lương của tháng đó chưa
GO

--(4) Cấp quyền cho role quản lý Khách hàng
GRANT SELECT ON [dbo].[vi_GetInfoKhachHang] TO QuanLyKhachHang
GRANT EXEC ON [dbo].[sp_XoaKhachHang] TO QuanLyKhachHang
GRANT EXEC ON[dbo].[sp_CapNhatDiemTichLuy] TO QuanLyKhachHang -- Cập nhật lại điểm tích lũy của khách hàng
GRANT EXEC ON [dbo].[sp_CapNhatTongChiTieu] TO QuanLyKhachHang -- Cập nhật lại tổng chi tiêu của khách hàng
GRANT EXEC ON [dbo].[sp_CapNhatKhachHang] TO QuanLyKhachHang 
GRANT EXEC ON [dbo].[sp_TimKiemKhachHangTheoMa] TO QuanLyKhachHang
GRANT EXEC ON [dbo].[sp_TimKiemKhachHangTheoTen] TO QuanLyKhachHang
GO

--(5) Cấp quyền cho role quản lý danh mục
GRANT SELECT ON [dbo].[getDanhMuc] TO QuanLyDanhMuc
GRANT EXEC ON [dbo].[sp_CapNhatDanhMuc] TO QuanLyDanhMuc
GO

--(6) Cấp quyền cho role quản lý món
GRANT EXEC ON [dbo].[sp_ThemMon] TO QuanLyMon
GRANT EXEC ON [dbo].[sp_XoaMon] TO QuanLyMon
GRANT EXEC ON [dbo].[sp_CapNhatMon] TO QuanLyMon
GRANT EXEC ON [dbo].[sp_TimKiemMonTheoMa] TO QuanLyMon
GRANT EXEC ON [dbo].[sp_TimKiemMonTheoTen] TO QuanLyMon
GO

--(7) Cấp quyền cho role Quản lý hóa đơn
GRANT SELECT ON [dbo].[fn_XuatChiTietMotHoaDon] TO  QuanLyHoaDon
--GRANT SELECT ON [dbo].[fn_GetTenThucUong] TO QuanLyHoaDon
--GRANT SELECT ON [dbo].[fn_LayHoaDonHienTai] TO  QuanLyHoaDon -- Trả về mã hóa đơn mới nhất trong ngày hiện tại
GO

--(8) Cấp quyền cho role quản lý doanh thu
GRANT EXEC ON [dbo].[sp_LoadSanPhamTheoDoanhThu] TO QuanLyDoanhThu
GRANT EXEC ON [dbo].[sp_XemDoanhThuHomNay] TO QuanLyDoanhThu
GRANT EXEC ON [dbo].[sp_XemDoanhThuTheoNam] TO QuanLyDoanhThu
GRANT EXEC ON [dbo].[sp_XemDoanhThuTheoThang] TO QuanLyDoanhThu
GRANT EXEC ON [dbo].[sp_XemDoanhThuTheoNgay] TO QuanLyDoanhThu
GRANT EXEC ON [dbo].[sp_XemDoanhThuTuyChon] TO QuanLyDoanhThu
GO

--(IV) Cấp quyền cho các User
--(1) Cấp quyền truy cập vào tài khoản cho cả 2 User
GRANT SELECT ON [dbo].[fn_GetTaiKhoan] TO [QuanLy]
GRANT SELECT ON [dbo].[fn_GetTaiKhoan] TO [NhanVien]
GO

--(2) Cấp quyền cho User Quản lý

EXEC sp_addrolemember [db_datareader], 'QuanLy' --Quản lý có thể xem được mọi form
EXEC sp_addrolemember [QuanLyNhanVien], 'QuanLy'
EXEC sp_addrolemember [QuanLyKhachHang], 'QuanLy'
EXEC sp_addrolemember [QuanLyDanhMuc], 'QuanLy'
EXEC sp_addrolemember [QuanLyMon], 'QuanLy'
EXEC sp_addrolemember [QuanLyHoaDon], 'QuanLy'
EXEC sp_addrolemember [QuanLyDoanhThu], 'QuanLy'
GO

--(3) Cấp quyền cho User Nhân Viên
EXEC sp_addrolemember [ThanhToan], 'NhanVien'
EXEC sp_addrolemember [NhanOrder], 'NhanVien'
GO

exec sp_helplogins -- xem các login
exec sp_helpuser -- xem người dùng 
