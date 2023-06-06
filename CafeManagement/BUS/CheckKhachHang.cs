using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BUS
{
    public class CheckKhachHang
    {
        DB_KhachHang db_KhachHang = new DB_KhachHang();
        public bool CheckKhachHangThanThiet(string MaKhachHang)
        {
           
            DataTable dt_KhachHang = db_KhachHang.GetInFoKhachHang();
            for (int i = 0; i < dt_KhachHang.Rows.Count; i++)
            {
                if (MaKhachHang == (dt_KhachHang.Rows[i][0].ToString()))
                    return true;
            }
            return false;
        }

        public bool CheckDKDangKyKhachHang(double TamTinh)
        {
            if (TamTinh >= 100000)
                return true;
            return false;
        }
    }
}
