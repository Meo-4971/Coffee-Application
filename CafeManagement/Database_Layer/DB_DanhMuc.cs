using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DB_DanhMuc
    {
        Database DanhMucDB;
        public DB_DanhMuc()
        {
            DanhMucDB = new Database();
        }

        public DataTable GetDanhMuc()
        {
            string sqlString = "select * from DANHMUC";
            DataTable dt = DanhMucDB.Execute(sqlString);
            return dt;
        }

        /*public void ThemDanhMuc(string MaDanhMuc, string TenDanhMuc)
        {
            var paras = new SqlParameter[2];
            paras[0] = new SqlParameter("@MaDanhMuc", SqlDbType.NVarChar)
            {
                Value = MaDanhMuc
            };
            paras[1] = new SqlParameter("@TenDanhMuc", SqlDbType.NVarChar)
            {
                Value = TenDanhMuc
            };

            using (var cmd = new SqlCommand("sp_ThemDanhMuc", DanhMucDB.sqlConn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(paras);
                cmd.ExecuteNonQuery();
            }
        }

        public void CapNhatDanhMuc(string MaDanhMuc, string TenDanhMuc)
        {
            var paras = new SqlParameter[2];
            paras[0] = new SqlParameter("@MaDanhMuc", SqlDbType.NVarChar)
            {
                Value = MaDanhMuc
            };
            paras[1] = new SqlParameter("@TenDanhMuc", SqlDbType.NVarChar)
            {
                Value = TenDanhMuc
            };

            using (var cmd = new SqlCommand("sp_CapNhatDanhMuc", DanhMucDB.sqlConn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(paras);
                cmd.ExecuteNonQuery();
            }
        }

        public void XoaDanhMuc(string MaDanhMuc)
        {
            var paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@MaDanhMuc", SqlDbType.NVarChar)
            {
                Value = MaDanhMuc
            };

            using (var cmd = new SqlCommand("sp_XoaDanhMuc", DanhMucDB.sqlConn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(paras);
                cmd.ExecuteNonQuery();
            }
        }*/
        
        public void CapNhatDanhMuc(string MaDanhMuc, string TenDanhMuc)
        {
            string sqlString = "exec sp_CapNhatDanhMuc '" + MaDanhMuc + "','" + TenDanhMuc + "'";
            DanhMucDB.ExecuteNonQuery(sqlString);
        }


    }
}
