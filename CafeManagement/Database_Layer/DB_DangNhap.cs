using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class DB_DangNhap
    {
        Database db;
        public DB_DangNhap()
        {
            db = new Database();
        }

        public DataTable KiemTraTaiKhoanHopLe(string maNhanVien, string matKhau)
        {
            string sqlString = "select * from fn_GetMotTaiKhoan('" + maNhanVien + "', '" + matKhau + "')";
            DataTable dt = db.Execute(sqlString);
            return dt;
        }
    }
}
