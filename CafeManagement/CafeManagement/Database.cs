using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Threading.Tasks;
namespace ChinhSuaMon
{ 
    internal class Database
    {
        SqlConnection sqlConn; // Doi tuong ket noi co so du lieu
        SqlDataAdapter da; // Bo dieu phoi du lieu
        DataSet ds; // chua CSDL khi giao tiep

        public Database()
        {
            string strCnn = "Data Source=DESKTOP-KIB57SI\\SQLEXPRESS;Initial Catalog=CAFE_MANAGEMENT;Persist Security Info=True;User ID=sa;Password=123456;MultipleActiveResultSets=True";
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
    }
}
