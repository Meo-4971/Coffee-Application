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
    public partial class XuatHoaDon : Form
    {
        public XuatHoaDon()
        {
            InitializeComponent();
        }

        private void XuatHoaDon_Load(object sender, EventArgs e)
        {
            DB_SaleOrder db_SaleOrder = new DB_SaleOrder();
            int maPhucVu = db_SaleOrder.LayMaHoaDonHienTai(SaleOrder.ngayGioHienTai);
            lbMaPhucVu_num.Text = maPhucVu.ToString();
            lbNgayGio.Text = SaleOrder.ngayGioHienTai.ToString();

            DB_ChiTietHoaDon db = new DB_ChiTietHoaDon();
            ListView chiTiet = SaleOrder.lvMonThanhToan;
            LoadInfoXuatHoaDon(chiTiet);
            DienCacTong();
        }

        private void DienCacTong()
        {
            lbTongLy_num.Text = SaleOrder.soLuong.ToString();
            lbTongTien_num.Text = SaleOrder.tamTinh.ToString();
            lbGiamGia_num.Text = SaleOrder.giamGia.ToString();
            lbTongPhaiTra_num.Text = SaleOrder.tienPhaiTra.ToString();

        }

        private void LoadInfoXuatHoaDon(ListView chiTiet)
        {
            for (int i = 0; i < chiTiet.Items.Count; i++)
            {
                DB_ThucUong db = new DB_ThucUong();
                ListViewItem lvi = lvXuatHoaDon.Items.Add(chiTiet.Items[i].SubItems[0].Text);
                lvi.SubItems.Add(chiTiet.Items[i].SubItems[1].Text);
                lvi.SubItems.Add(chiTiet.Items[i].SubItems[2].Text);
                lvi.SubItems.Add(chiTiet.Items[i].SubItems[3].Text);
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

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Clear();
            this.Close();
        }
    }
}
