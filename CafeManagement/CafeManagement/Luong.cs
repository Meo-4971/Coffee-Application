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
    public partial class Luong : Form
    {
        public Luong()
        {
            InitializeComponent();
        }

        public string MaNhanVien;
        public int Thang = 0;
        public int Nam = 0;
        public int salary = 0;


        private void Luong_Load(object sender, EventArgs e)
        {
            DB_NhanVien db = new DB_NhanVien();
            DataTable NhanVienList = db.getAllNhanVien();
            cbNhanVien.DataSource = NhanVienList;
            cbNhanVien.ValueMember = "MaNhanVien";
            cbNhanVien.DisplayMember = "TenNhanVien";

        }

        private void btnXemNgayTuyChon_Click(object sender, EventArgs e)
        {
            loadLuongNhanVien();
        }

        private void loadLuongNhanVien()
        {
            lvDoanhThu.Items.Clear();
            string MaNhanVien = cbNhanVien.SelectedValue.ToString();
            if (rdoAll.Checked)
            {

                DB_NhanVien db = new DB_NhanVien();
                DataTable LuongNhanVienList = db.getAllLuong(MaNhanVien);
                for (int i = 0; i < LuongNhanVienList.Rows.Count; i++)
                {
                    ListViewItem lvi = lvDoanhThu.Items.Add(LuongNhanVienList.Rows[i][0].ToString());
                    lvi.SubItems.Add(LuongNhanVienList.Rows[i][1].ToString());
                    lvi.SubItems.Add(LuongNhanVienList.Rows[i][2].ToString());
                    lvi.SubItems.Add(LuongNhanVienList.Rows[i][3].ToString());
                    bool check = Convert.ToBoolean(LuongNhanVienList.Rows[i][4].ToString());
                    if (check)
                    {
                        lvi.SubItems.Add("Đã thanh toán");
                    }
                    else
                        lvi.SubItems.Add("Chưa thanh toán");

                }
            }
            if (rdoDaThanhToan.Checked)
            {
                DB_NhanVien db = new DB_NhanVien();
                DataTable LuongNhanVienList = db.getLuongTheoTrangThai(MaNhanVien, 1);
                for (int i = 0; i < LuongNhanVienList.Rows.Count; i++)
                {
                    ListViewItem lvi = lvDoanhThu.Items.Add(LuongNhanVienList.Rows[i][0].ToString());
                    lvi.SubItems.Add(LuongNhanVienList.Rows[i][1].ToString());
                    lvi.SubItems.Add(LuongNhanVienList.Rows[i][2].ToString());
                    lvi.SubItems.Add(LuongNhanVienList.Rows[i][3].ToString());
                    lvi.SubItems.Add("Đã Thanh Toán");
                }
            }
            if (rdoChuaThanhToan.Checked)
            {
                DB_NhanVien db = new DB_NhanVien();
                DataTable LuongNhanVienList = db.getLuongTheoTrangThai(MaNhanVien, 0);
                for (int i = 0; i < LuongNhanVienList.Rows.Count; i++)
                {
                    ListViewItem lvi = lvDoanhThu.Items.Add(LuongNhanVienList.Rows[i][0].ToString());
                    lvi.SubItems.Add(LuongNhanVienList.Rows[i][1].ToString());
                    lvi.SubItems.Add(LuongNhanVienList.Rows[i][2].ToString());
                    lvi.SubItems.Add(LuongNhanVienList.Rows[i][3].ToString());
                    lvi.SubItems.Add("Chưa Thanh Toán");
                }
            }
        }

        private void lvDoanhThu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDoanhThu.SelectedItems.Count > 0)
            {
                ListViewItem item = lvDoanhThu.SelectedItems[0];
                MaNhanVien = item.SubItems[0].Text;
                Thang = Convert.ToInt32(item.SubItems[1].Text);
                Nam = Convert.ToInt32(item.SubItems[2].Text);
                salary = Convert.ToInt32(item.SubItems[3].Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MaNhanVien == "" || Thang == 0 || Nam == 0 || salary == 0)
            {
                MessageBox.Show("Vui lòng chọn tháng lương muốn thanh toán!");
            }
            else
            {
                DB_NhanVien db = new DB_NhanVien();
                bool check = db.CapNhatTrangThaiLuong(MaNhanVien, Thang, Nam, salary);
                if(check)
                {
                    MessageBox.Show("Thanh toán lương thành công!");
                    loadLuongNhanVien();
                }
                else
                {
                    MessageBox.Show("Thanh toán lương thất bại!");
                }
            } 
        }
    }
}
