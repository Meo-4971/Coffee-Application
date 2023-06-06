using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class DB_NhanVien
    {
        Database NhanVienDB;
        public DB_NhanVien()
        {
            NhanVienDB = new Database();
        }
        public  DataTable getAllNhanVien()
        {
            string strQuery = string.Format("SELECT *FROM vi_NhanVienList");

            DataTable NhanVienTable = NhanVienDB.Execute(strQuery);
            return NhanVienTable;
        }
        public bool ThemNhanVien(string TenNhanVien, string MatKhau, string ChucVu, string NgaySinh, string SDT, double Luong)
        {
            int result = 0;
            string strQuery = string.Format("EXEC sp_ThemNhanVien @TenNhanVien = N'{0}' ," +
                "@MatKhau = '{1}', @ChucVu = N'{2}', @NgaySinh = '{3}', @SDT = '{4}', @Luong = {5}", TenNhanVien, MatKhau, ChucVu, NgaySinh, SDT, Luong);
            result = NhanVienDB.ExecuteNonQueryVer2(strQuery);
            return result > 0;
            
        }
        public bool SuaNhanVien(string MaNhanVien, string TenNhanVien, string MatKhau, string NgaySinh, string SDT, double Luong, int TrangThai)
        {
            int result = 0;
            string strQuery = string.Format("EXEC sp_CapNhatNhanVien @MaNhanVien = N'{0}', @TenNhanVien = N'{1}',  " +
                "@MatKhau = N'{2}', @NgaySinh = N'{3}', @SDT = N'{4}', @Luong = N'{5}', @TrangThai = {6}", MaNhanVien, TenNhanVien, MatKhau, NgaySinh, SDT, Luong, TrangThai);
            result = NhanVienDB.ExecuteNonQueryVer2(strQuery);
            return result > 0;
        }
        public bool XoaNhanVien(string MaNhanVien)
        {
            int result = 0;
            string strQuery = string.Format("EXEC sp_XoaNhanVien @MaNhanVien = N'{0}'", MaNhanVien);
            result = NhanVienDB.ExecuteNonQueryVer2(strQuery);
            return result > 0;
        }
        public bool TinhLuongNhanVien(string MaNhanVien, int luong, int trangthai)
        {
            int check = 0;
            string strQuery = string.Format("INSERT INTO LUONGMOITHANG VALUES (N'{0}',{1},{2},{3},{4})", MaNhanVien,DateTime.Now.Month,DateTime.Now.Year,luong,trangthai);
            check = NhanVienDB.ExecuteNonQueryVer2(strQuery);
            return check > 0;
        }
        public DataTable getAllLuong (string MaNhanVien)
        {
            string strQuery = string.Format("SELECT *FROM LuongMoiThang Where MaNhanVien = '{0}'", MaNhanVien);

            DataTable LuongNhanVienTable = NhanVienDB.Execute(strQuery);
            return LuongNhanVienTable;
        }
        public DataTable getLuongTheoTrangThai(string MaNhanVien, int status)
        {
            string strQuery = string.Format("SELECT *FROM LuongMoiThang Where MaNhanVien = '{0}' AND TinhTrang = {1}", MaNhanVien,status);
            DataTable LuongNhanVienTable = NhanVienDB.Execute(strQuery);
            return LuongNhanVienTable;
        }
        public bool CapNhatTrangThaiLuong(string MaNhanVien, int thang, int nam, int salary)
        {
            int result = 0;
            string strQuery = string.Format("UPDATE LUONGMOITHANG SET TinhTrang = 1 WHERE MaNhanVien = '{0}' AND Thang = {1} AND Nam = {2} AND Luong = {3} AND TinhTrang = 0", MaNhanVien, thang, nam, salary);
            result = NhanVienDB.ExecuteNonQueryVer2(strQuery);
            return result > 0;
        }
    }
}
