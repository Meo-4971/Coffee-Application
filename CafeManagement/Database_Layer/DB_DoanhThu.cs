using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class DB_DoanhThu
    {
        Database DoanhThuDB;
        public DB_DoanhThu()
        {
            DoanhThuDB = new Database();
        }
        public DataTable getDoanhThuHomNay()
        {
            string strQuery = string.Format("EXEC sp_XemDoanhThuHomNay");
            DataTable TableDoanhThuHomNay = DoanhThuDB.Execute(strQuery);
            return TableDoanhThuHomNay;
        }
        public DataTable getDoanhThuTheoNgay()
        {
            string strQuery = string.Format("EXEC sp_XemDoanhThuTheoNgay");
            DataTable TableDoanhThuTheoNgay = DoanhThuDB.Execute(strQuery);
            return TableDoanhThuTheoNgay;
        }
        public DataTable getDoanhThuTheoThang()
        {
            string strQuery = string.Format("EXEC sp_XemDoanhThuTheoThang");
            DataTable TableDoanhThuTheoThang = DoanhThuDB.Execute(strQuery);
            return TableDoanhThuTheoThang;
        }
        public DataTable getDoanhThuTheoNam()
        {
            string strQuery = string.Format("EXEC sp_XemDoanhThuTheoNam");
            DataTable TableDoanhThuTheoNam = DoanhThuDB.Execute(strQuery);
            return TableDoanhThuTheoNam;
        }
        public DataTable getDoanhThuTuyChon(string begin, string end)
        {
            string strQuery = string.Format("EXEC sp_XemDoanhThuTuyChon @begin_date = '{0}', @end_date = '{1}'", begin, end);
            DataTable TableDoanhThuTuyChon = DoanhThuDB.Execute(strQuery);
            return TableDoanhThuTuyChon;
        }
        public DataTable loadSanPhamTheoDoanhThu(string begin, string end)
        {
            string strQuery = string.Format("EXEC sp_LoadSanPhamTheoDoanhThu @datebegin = '{0}', @dateend = '{1}'", begin, end);
            DataTable TableSanPham = DoanhThuDB.Execute(strQuery);
            return TableSanPham;
        }
        public DataTable Top5MonBanChayNhatHomNay()
        {
            string strQuery = string.Format("EXEC sp_Top5MonBanChayNhatHomNay");
            DataTable Table5MonBanChayNhatHomNay = DoanhThuDB.Execute(strQuery);
            return Table5MonBanChayNhatHomNay;
        }
        public DataTable Top5MonBanChayNhatTrongNgay()
        {
            string strQuery = string.Format("EXEC sp_Top5MonBanChayNhatTheoNgay");
            DataTable Table5MonBanChayNhatTheoNgay = DoanhThuDB.Execute(strQuery);
            return Table5MonBanChayNhatTheoNgay;
        }
        public DataTable Top5MonBanChayNhatTrongThang()
        {
            string strQuery = string.Format("EXEC sp_Top5MonBanChayNhatTheoThang");
            DataTable Table5MonBanChayNhatTheoThang = DoanhThuDB.Execute(strQuery);
            return Table5MonBanChayNhatTheoThang;
        }
        public DataTable Top5MonBanChayNhatTrongNam()
        {
            string strQuery = string.Format("EXEC sp_Top5MonBanChayNhatTheoNam");
            DataTable Table5MonBanChayNhatTheoNam = DoanhThuDB.Execute(strQuery);
            return Table5MonBanChayNhatTheoNam;
        }
        public DataTable Top5MonBanItNhatHomNay()
        {
            string strQuery = string.Format("EXEC sp_Top5MonBanItNhatHomNay");
            DataTable TableTop5MonItNhatHomNay = DoanhThuDB.Execute(strQuery);
            return TableTop5MonItNhatHomNay;
        }
        public DataTable Top5MonBanItNhatTrongNgay()
        {
            string strQuery = string.Format("EXEC sp_Top5MonBanItNhatTheoNgay");
            DataTable TableTop5MonItNhatTheoNgay = DoanhThuDB.Execute(strQuery);
            return TableTop5MonItNhatTheoNgay;
        }
        public DataTable Top5MonBanItNhatTrongThang()
        {
            string strQuery = string.Format("EXEC sp_Top5MonBanItNhatTheoThang");
            DataTable TableTop5MonItNhatTheoThang = DoanhThuDB.Execute(strQuery);
            return TableTop5MonItNhatTheoThang;
        }
        public DataTable Top5MonBanItNhatTrongNam()
        {
            string strQuery = string.Format("EXEC sp_Top5MonBanItNhatTheoNam");
            DataTable TableTop5MonItNhatTheoNam = DoanhThuDB.Execute(strQuery);
            return TableTop5MonItNhatTheoNam;
        }
        public DataTable NhungMonKhongBanDuocHomNay()
        {
            string strQuery = string.Format("EXEC sp_CacMonKhongBanDuocHomNay");
            DataTable TableMonKhongBanDuocHomNay = DoanhThuDB.Execute(strQuery);
            return TableMonKhongBanDuocHomNay;
        }
        public DataTable NhungMonKhongBanDuocTrongNgay()
        {
            string strQuery = string.Format("EXEC sp_CacMonKhongBanDuocTheoNgay");
            DataTable TableMonKhongBanDuocTrongNgay = DoanhThuDB.Execute(strQuery);
            return TableMonKhongBanDuocTrongNgay;
        }
        public DataTable NhungMonKhongBanDuocTrongThang()
        {
            string strQuery = string.Format("EXEC sp_CacMonKhongBanDuocTheoThang");
            DataTable TableMonKhongBanDuocTrongThang = DoanhThuDB.Execute(strQuery);
            return TableMonKhongBanDuocTrongThang;
        }
        public DataTable NhungMonKhongBanDuocTrongNam()
        {
            string strQuery = string.Format("EXEC sp_CacMonKhongBanDuocTheoNam");
            DataTable TableMonKhongBanDuocTrongNam = DoanhThuDB.Execute(strQuery);
            return TableMonKhongBanDuocTrongNam;
        }
    }
}
