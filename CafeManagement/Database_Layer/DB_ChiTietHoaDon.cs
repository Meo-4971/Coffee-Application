using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL

{
    public class DB_ChiTietHoaDon
    {
        Database DBHoaDon;
        public DB_ChiTietHoaDon()
        {
            DBHoaDon = new Database();
        }

        public DataTable LayChiTietMotHoaDon(int maHoaDon, DateTime ngayGio)
        {
            string strSQL = "SELECT * FROM fn_XuatChiTietMotHoaDon (" + maHoaDon + ", '" + ngayGio + "')";
            DataTable dt = DBHoaDon.Execute(strSQL);
            return dt;
        }

        public void ThemChiTietHoaDon(string MaThucUong, int SoLuong)
        {
            string sqlString = " exec sp_ThemChiTietHoaDon '" + MaThucUong + "', " + SoLuong;
            DBHoaDon.ExecuteNonQuery(sqlString);
        }

    }
}
