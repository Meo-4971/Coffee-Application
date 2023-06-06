using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class DB_SaleOrder
    {
        Database DBSaleOrder;
        public DB_SaleOrder()
        {
            DBSaleOrder = new Database();
        }
        
        public DataTable GetMonTrongMoiDanhMuc(string MaDanhMuc)
        {
            string sqlString = "select * from [dbo].cacMonTrongDanhMuc( '"+ MaDanhMuc+"')";
            DataTable dt = DBSaleOrder.Execute(sqlString);
            return dt;
        }

        public DataTable TinhThanhTien(double DonGia, int SoLuong)
        {
            string sqlString = "select [dbo].tinhThanhTien("+DonGia+","+SoLuong+")";
            DataTable ThanhTien = DBSaleOrder.Execute(sqlString);
            return ThanhTien;
        }
        /*public int ThanhTien(string maThucUong, int soLuong)
        {
            string strSQL = "select dbo.tinhThanhTien ('" + maThucUong + "', '" + soLuong + "')";
            DataTable dt = db.ExecuteQuery(strSQL);
            int thanhTien = Convert.ToInt32(dt.Rows[0][0].ToString());
            return thanhTien;
        }*/ //Của hân

        public DataTable TinhTamTinh(double TongHoaDon, double ThanhTien)
        {
            string sqlString = "select [dbo].tinhTongHoaDon(" + TongHoaDon + "," + ThanhTien + ")";
            DataTable TamTinh  = DBSaleOrder.Execute(sqlString);
            return TamTinh;
        }

        public DataTable TinhGiamGia(string MaKhachHang, double TamTinh)
        {
            string sqlString = "select [dbo].giamGia('" + MaKhachHang + "'," + TamTinh + ")";
            DataTable dt = DBSaleOrder.Execute(sqlString);
            return dt;
        }

        public int LayMaHoaDonHienTai(DateTime ngayGio)
        {
            string sqlString = "select dbo.fn_LayMaHoaDonHienTai ('" + ngayGio + "')";
            DataTable dt = DBSaleOrder.Execute(sqlString);
            int maHoaDon = int.Parse(dt.Rows[0][0].ToString());
            return maHoaDon;
        }

    }
}
