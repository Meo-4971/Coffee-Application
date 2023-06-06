using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class DB_Mon
    {
        Database monDB;

        public DB_Mon()
        {
            monDB = new Database();
        }

        public DataTable GetInfoMon()
        {
            string sqlString = "select MaThucUong, TenThucUong, TenDanhMuc, DonGia, SoLuong, TrangThaiMon from THUCUONG, DANHMUC where DanhMuc = MaDanhMuc";
            DataTable dt = monDB.Execute(sqlString);
            return dt;
        }

        public DataTable LayDanhMuc()
        {
            string sqlString = "select distinct TenDanhMuc from DANHMUC";
            DataTable dt = monDB.Execute(sqlString);
            return dt;
        }


        /*public void ThemMon(string MaThucUong, string TenThucUong, string DanhMuc, string DonGia, string SoLuong, bool TrangThaiMon)
        {
            var paras = new SqlParameter[6];
            //@MaThucUong,@TenThucUong, @DanhMuc, @DonGia,@SoLuong,@TrangThaiMon
            paras[0] = new SqlParameter("@MaThucUong", SqlDbType.NVarChar)
            {
                Value = MaThucUong
            };
            paras[1] = new SqlParameter("@TenThucUong", SqlDbType.NVarChar)
            {
                Value = TenThucUong
            };
            paras[2] = new SqlParameter("@DanhMuc", SqlDbType.NVarChar)
            {
                Value = DanhMuc
            };
            paras[3] = new SqlParameter("@DonGia", SqlDbType.Int)
            {
                Value = Convert.ToInt32(DonGia)
            };
            paras[4] = new SqlParameter("@SoLuong", SqlDbType.Int)
            {
                Value = Convert.ToInt32(SoLuong)
            };
            paras[5] = new SqlParameter("@TrangThaiMon", SqlDbType.Bit)
            {
                Value = Convert.ToInt32(TrangThaiMon)
            };

            using (var cmd = new SqlCommand("sp_ThemMon", monDB.sqlConn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(paras);
                cmd.ExecuteNonQuery();
            }
        }

        public void CapNhatMon(string MaThucUong, string TenThucUong, string DanhMuc, string DonGia, string SoLuong, bool TrangThaiMon)
        {
            var paras = new SqlParameter[6];
            paras[0] = new SqlParameter("@MaThucUong", SqlDbType.NVarChar)
            {
                Value = MaThucUong
            };
            paras[1] = new SqlParameter("@TenThucUong", SqlDbType.NVarChar)
            {
                Value = TenThucUong
            };
            paras[2] = new SqlParameter("@DanhMuc", SqlDbType.NVarChar)
            {
                Value = DanhMuc
            };
            paras[3] = new SqlParameter("@DonGia", SqlDbType.Int)
            {
                Value = Convert.ToInt32(DonGia)
            };
            paras[4] = new SqlParameter("@SoLuong", SqlDbType.Int)
            {
                Value = Convert.ToInt32(SoLuong)
            };
            paras[5] = new SqlParameter("@TrangThaiMon", SqlDbType.Bit)
            {
                Value = Convert.ToInt32(TrangThaiMon)
            };

            using (var cmd = new SqlCommand("sp_CapNhatMon", monDB.sqlConn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(paras);
                cmd.ExecuteNonQuery();
            }
        }

        public void XoaMon(string MaThucUong)
        {
            var paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@MaThucUong", SqlDbType.NVarChar)
            {
                Value = MaThucUong
            };

            using (var cmd = new SqlCommand("sp_XoaMon", monDB.sqlConn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(paras);
                cmd.ExecuteNonQuery();
            }
        }*/

        /*public DataSet TenDanhMuc()
        {
            string sqlStr = "SELECT TenDanhMuc FROM DanhMuc";
            return monDB.ExecuteQueryDataSet(sqlStr, CommandType.Text);
        }*/

        public DataTable TimKiemMonTheoMa(string MaThucUong)
        {
            var para = new SqlParameter("@MaThucUong", SqlDbType.NVarChar)
            {
                Value = MaThucUong
            };

            using (var cmd = new SqlCommand("sp_TimKiemMonTheoMa", monDB.sqlConn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(para);
                var da = new SqlDataAdapter
                {
                    SelectCommand = cmd
                };
                var ds = new DataSet();
                da.Fill(ds);
                return ds.Tables[0];
            }
        }

        public DataTable TimKiemMonTheoTen(string TenThucUong)
        {
            var para = new SqlParameter("@TenThucUong", SqlDbType.NVarChar)
            {
                Value = TenThucUong
            };

            using (var cmd = new SqlCommand("sp_TimKiemMonTheoTen", monDB.sqlConn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(para);
                var da = new SqlDataAdapter
                {
                    SelectCommand = cmd
                };
                var ds = new DataSet();
                da.Fill(ds);
                return ds.Tables[0];
            }
        }
        public void ThemMon(string MaThucUong, string TenThucUong, string DanhMuc, string DonGia, string SoLuong, int TrangThaiMon)
        {
            string sqlString = "exec sp_ThemMon '" + MaThucUong + "','" + TenThucUong + "','" + DanhMuc + "','" + DonGia + "','" + SoLuong + "'," + TrangThaiMon;
            monDB.ExecuteNonQuery(sqlString);
        }

        public void CapNhatMon(string MaThucUong, string TenThucUong, string DanhMuc, string DonGia, string SoLuong, int TrangThaiMon)
        {
            string sqlString = "exec sp_CapNhatMon '" + MaThucUong + "',N'" + TenThucUong + "',N'" + DanhMuc + "','" + DonGia + "','" + SoLuong + "'," + TrangThaiMon;
            monDB.ExecuteNonQuery(sqlString);
        }

        public void XoaMon(string MaThucUong)
        {
            string sqlString = "exec sp_XoaMon '" + MaThucUong + "'";
            monDB.ExecuteNonQuery(sqlString);
        }
    }
}
