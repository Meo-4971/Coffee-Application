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
    public partial class DangKyKhachHangThanThiet : Form
    {
        public DangKyKhachHangThanThiet()
        {
            InitializeComponent();
        }

        private void DangKyKhachHangThanThiet_Load(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DB_KhachHang db_KhachHang = new DB_KhachHang();
            db_KhachHang.DangKyKhachHang(SaleOrder.sdtKhachHang, txtTenKhachHang.Text, SaleOrder.tienPhaiTra);
        }
    }
}
