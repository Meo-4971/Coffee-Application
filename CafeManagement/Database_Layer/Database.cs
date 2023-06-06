using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Database
    {
        public SqlConnection sqlConn; // Doi tuong ket noi co so du lieu
        SqlDataAdapter da; // Bo dieu phoi du lieu
        DataSet ds; // chua CSDL khi giao tiep
        SqlCommand comm;

        public Database()
        {
            string strCnn = @"Data Source=DESKTOP-9BKU0HT\SQLEXPRESS;Initial Catalog=CAFE_MANAGEMENT;Integrated Security=True";
            sqlConn = new SqlConnection(strCnn);
        }

        public DataTable Execute(string sqlStr)
        {
            da = new SqlDataAdapter(sqlStr, sqlConn);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }// Phuong thuc de thuc hien them xoa sua

        public void ExecuteNonQuery(string strSQL)
        {
            SqlCommand sqlcmd = new SqlCommand(strSQL, sqlConn);
            sqlConn.Open();// Mo ket noi
            sqlcmd.ExecuteNonQuery();// Lenh thuc hien Them xoa sua
            sqlConn.Close();//DOng ket noi
        }


        public int ExecuteNonQueryVer2(string query, object[] parameter = null)
        {
            int data = 0;
            sqlConn.Open();
            SqlCommand command = new SqlCommand(query, sqlConn);

            if (parameter != null)
            {
                string[] ListPara = query.Split(' ');// cắt chuỗi theo khoảng trắng
                int i = 0;
                foreach (string item in ListPara)
                {
                    if (item.Contains('@'))
                    {
                        command.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
            }

            data = command.ExecuteNonQuery();

            sqlConn.Close();
            return data;
        }
        public object ExcuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            sqlConn.Open();
            SqlCommand command = new SqlCommand(query, sqlConn);

            if (parameter != null)
            {
                string[] ListPara = query.Split(' ');// cắt chuỗi theo khoảng trắng
                int i = 0;
                foreach (string item in ListPara)
                {
                    if (item.Contains('@'))
                    {
                        command.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
            }
            data = command.ExecuteScalar();
            sqlConn.Close();
            return data;
        }

        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (sqlConn.State == ConnectionState.Closed)
                sqlConn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}
