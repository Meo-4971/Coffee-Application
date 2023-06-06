using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace CafeManagement
{
    public partial class ChiTietHoaDon : Form
    {
        public ChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Clear();
            this.Close();
        }

        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            lbMaPhucVu_num.Text = QuanLyHoaDon.maHoaDonCopy.ToString();
            lbNgayGio.Text = QuanLyHoaDon.ngayGioCopy.ToString();
            DB_ChiTietHoaDon db = new DB_ChiTietHoaDon();
            DataTable dt = db.LayChiTietMotHoaDon(QuanLyHoaDon.maHoaDonCopy, QuanLyHoaDon.ngayGioCopy);
            DataTable chiTiet = DienChiTietVaoLV(dt);
            LoadInfoChiTietHoaDon(chiTiet);
            DienCacTong(chiTiet);
        }

        private void DienCacTong (DataTable dt)
        {
            int tongLy = 0;
            int tongTien = 0;
            int tongPhaiTra = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tongLy += Convert.ToInt32(dt.Rows[i][1].ToString());
                tongTien += Convert.ToInt32(dt.Rows[i][3].ToString());
            }
            lbTongLy_num.Text = tongLy.ToString();
            lbTongTien_num.Text = tongTien.ToString();
            lbGiamGia_num.Text = QuanLyHoaDon.giamGiaCopy.ToString();
            tongPhaiTra = tongTien - QuanLyHoaDon.giamGiaCopy;
            lbTongPhaiTra_num.Text = tongPhaiTra.ToString();
        }

        public DataTable DienChiTietVaoLV(DataTable LayChiTiet)
        {
            DB_ThucUong thucUongDB = new DB_ThucUong();
            DB_ChiTietHoaDon db = new DB_ChiTietHoaDon();
            DataTable dt = new DataTable();
            dt.Columns.Add("HangHoa");
            dt.Columns.Add("SoLuong");
            dt.Columns.Add("DonGia");
            dt.Columns.Add("ThanhTien");
            for (int i = 0; i < LayChiTiet.Rows.Count; i++)
            {
                DataRow dr = dt.NewRow();
                string hangHoa = thucUongDB.GetTenThucUong(LayChiTiet.Rows[i][2].ToString());
                dr["HangHoa"] = hangHoa;
                dr["SoLuong"] = LayChiTiet.Rows[i][4].ToString();
                dr["DonGia"] = double.Parse(LayChiTiet.Rows[i][3].ToString());
                DB_SaleOrder db_SaleOrder = new DB_SaleOrder();
                DataTable dt_ThanhTien = db_SaleOrder.TinhThanhTien(double.Parse(LayChiTiet.Rows[i][3].ToString()), int.Parse(LayChiTiet.Rows[i][4].ToString()));
                double thanhTien = double.Parse(dt_ThanhTien.Rows[0][0].ToString());
                dr["ThanhTien"] = thanhTien;
                dt.Rows.Add(dr);
            }
            return dt;
        }

        private void LoadInfoChiTietHoaDon(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DB_ThucUong db = new DB_ThucUong();
                ListViewItem lvi = lvChiTietHoaDon.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
            }
        }
        private void Clear()
        {
            lbMaPhucVu_num.Text = "";
            lbNgayGio.Text = "";
            lbTongLy_num.Text = "";
            lbTongTien_num.Text = "";
            lbGiamGia_num.Text = "";
            lbTongPhaiTra_num.Text = "";
        }

    }
}
