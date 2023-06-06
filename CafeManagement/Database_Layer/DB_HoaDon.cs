using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class DB_HoaDon
    {
        Database DBHoaDon;
        public DB_HoaDon()
        {
            DBHoaDon = new Database();
        }
        public void ThemHoaDon(string MaKhachHang, string MaNhanVien, double TongHoaDon, double GiamGia)
        {
            string sqlString = "exec sp_ThemHoaDon '" + MaKhachHang + "','" + MaNhanVien + "'," + TongHoaDon + "," + GiamGia;
            DBHoaDon.ExecuteNonQuery(sqlString);
        }

        public DataTable LayDSHoaDon()
        {
            string strSQL = "select * from HOADON";
            DataTable dt = DBHoaDon.Execute(strSQL);
            return dt;
        }




    }
}
