using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DB_ThucUong
    {
        Database db;
        public DB_ThucUong()
        {
            db = new Database();
        }
        public string GetTenThucUong(string maMon)
        {
            string strSQL = "select dbo.fn_GetTenThucUong ('" + maMon + "')";
            DataTable dt = db.Execute(strSQL);
            string tenThucUong = dt.Rows[0][0].ToString();
            return tenThucUong;
        }
        
        public string GetMaThucUong(string TenMon)
        {
            string strSQL = "select MaThucUong from vi_GetMaThucUong where TenThucUong = N'"+TenMon+"'";
            DataTable dt = db.Execute(strSQL);
            string maThucUong = dt.Rows[0][0].ToString();
            return maThucUong;
        }
    }
}
