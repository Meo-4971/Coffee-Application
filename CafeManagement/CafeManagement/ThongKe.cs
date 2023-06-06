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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
           
        }
        private void resetRadio()
        {
            rdoCheckHomNay.Checked = false;
            rdoCheckTheoNam.Checked = false;
            rdoCheckTheoNgay.Checked = false;
            rdoCheckTheoThang.Checked = false;
        }
        private void LoadListDoanhThu(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DateTime Ngay = DateTime.Parse(dt.Rows[i][0].ToString());

                string strNgay = QuanLyNhanVien.FormatDate(Ngay);

                ListViewItem lvi = lvDoanhThu.Items.Add(strNgay);
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
            }
        }
        private void LoadListBanDuocNhieuNhat(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DateTime Ngay = DateTime.Parse(dt.Rows[i][0].ToString());

                string strNgay = QuanLyNhanVien.FormatDate(Ngay);

                ListViewItem lvi = lsvMonBanChayNhat.Items.Add(strNgay);
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
            }
        }
        private void LoadListBanDuocItNhat(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DateTime Ngay = DateTime.Parse(dt.Rows[i][0].ToString());

                string strNgay = QuanLyNhanVien.FormatDate(Ngay);

                ListViewItem lvi = lsvMonBanItNhat.Items.Add(strNgay);
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
            }
        }
        private void LoadListKhongBanDuoc(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DateTime Ngay = DateTime.Parse(dt.Rows[i][0].ToString());

                string strNgay = QuanLyNhanVien.FormatDate(Ngay);

                ListViewItem lvi = lsvMonKhongBanDuoc.Items.Add(strNgay);
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
            }
        }
        private void LoadListSanPham(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lvSanPhamTheoDoanhThu.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add((double.Parse(dt.Rows[i][3].ToString())).ToString());
                //double TongTien = double.Parse(dt.Rows[i][3].ToString());
                lvi.SubItems.Add((double.Parse(dt.Rows[i][4].ToString())).ToString());
            }
        }

        private void rdoCheckHomNay_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoCheckHomNay.Checked)
            {
                lvDoanhThu.Items.Clear();
                lsvMonBanChayNhat.Items.Clear();
                lsvMonBanItNhat.Items.Clear();
                lsvMonKhongBanDuoc.Items.Clear();
                DB_DoanhThu db = new DB_DoanhThu();
                DataTable dt, dt1, dt2, dt3;
                dt = db.getDoanhThuHomNay();
                dt1 = db.Top5MonBanChayNhatHomNay();
                dt2 = db.Top5MonBanItNhatHomNay();
                dt3 = db.NhungMonKhongBanDuocHomNay();
                LoadListDoanhThu(dt);
                LoadListBanDuocNhieuNhat(dt1);
                LoadListBanDuocItNhat(dt2);
                LoadListKhongBanDuoc(dt3);
            }    
        }

        private void rdoCheckTheoNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCheckTheoNgay.Checked)
            {
                lvDoanhThu.Items.Clear();
                DB_DoanhThu db = new DB_DoanhThu();
                DataTable dt, dt1, dt2, dt3;
                dt = db.getDoanhThuHomNay();
                dt1 = db.Top5MonBanChayNhatTrongNgay();
                dt2 = db.Top5MonBanItNhatTrongNgay();
                dt3 = db.NhungMonKhongBanDuocTrongNgay();
                LoadListDoanhThu(dt);
                LoadListBanDuocNhieuNhat(dt1);
                LoadListBanDuocItNhat(dt2);
                LoadListKhongBanDuoc(dt3);
            }
        }

        private void rdoCheckTheoThang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCheckTheoThang.Checked)
            {
                lvDoanhThu.Items.Clear();
                lsvMonBanChayNhat.Items.Clear();
                lsvMonBanItNhat.Items.Clear();
                lsvMonKhongBanDuoc.Items.Clear();
                DB_DoanhThu db = new DB_DoanhThu();
                DataTable dt, dt1, dt2, dt3;
                dt = db.getDoanhThuTheoThang();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string Thang = "Tháng " + dt.Rows[i][0].ToString();
                    ListViewItem lvi = lvDoanhThu.Items.Add(Thang);
                    lvi.SubItems.Add(dt.Rows[i][1].ToString());
                    lvi.SubItems.Add(dt.Rows[i][2].ToString());
                    lvi.SubItems.Add(dt.Rows[i][3].ToString());
                }
                dt1 = db.Top5MonBanChayNhatTrongThang();
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    string Thang = "Tháng " + dt1.Rows[i][0].ToString();
                    ListViewItem lvi = lsvMonBanChayNhat.Items.Add(Thang);
                    lvi.SubItems.Add(dt1.Rows[i][1].ToString());
                    lvi.SubItems.Add(dt1.Rows[i][2].ToString());
                }
                dt2 = db.Top5MonBanItNhatTrongThang();
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    string Thang = "Tháng " + dt2.Rows[i][0].ToString();
                    ListViewItem lvi = lsvMonBanItNhat.Items.Add(Thang);
                    lvi.SubItems.Add(dt2.Rows[i][1].ToString());
                    lvi.SubItems.Add(dt2.Rows[i][2].ToString());
                }
                dt3 = db.NhungMonKhongBanDuocTrongThang();
                for (int i = 0; i < dt3.Rows.Count; i++)
                {
                    string Thang = "Tháng " + dt3.Rows[i][0].ToString();
                    ListViewItem lvi = lsvMonKhongBanDuoc.Items.Add(Thang);
                    lvi.SubItems.Add(dt3.Rows[i][1].ToString());
                }
            }
        }

        private void rdoCheckTheoNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCheckTheoNam.Checked)
            {
                lvDoanhThu.Items.Clear();
                lsvMonBanChayNhat.Items.Clear();
                lsvMonBanItNhat.Items.Clear();
                lsvMonKhongBanDuoc.Items.Clear();
                DB_DoanhThu db = new DB_DoanhThu();
                DataTable dt, dt1, dt2, dt3;
                dt = db.getDoanhThuTheoNam();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string Nam = "Năm " + dt.Rows[i][0].ToString();
                    ListViewItem lvi = lvDoanhThu.Items.Add(Nam);
                    lvi.SubItems.Add(dt.Rows[i][1].ToString());
                    lvi.SubItems.Add(dt.Rows[i][2].ToString());
                    lvi.SubItems.Add(dt.Rows[i][3].ToString());
                }
                dt1 = db.Top5MonBanChayNhatTrongNam();
                for (int i = 0; i < dt1.Rows.Count; i++)
                {

                    string Nam = "Năm " + dt1.Rows[i][0].ToString();
                    ListViewItem lvi = lsvMonBanChayNhat.Items.Add(Nam);
                    lvi.SubItems.Add(dt1.Rows[i][1].ToString());
                    lvi.SubItems.Add(dt1.Rows[i][2].ToString());
                }
                dt2 = db.Top5MonBanItNhatTrongNam();
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    string Nam = "Năm " + dt2.Rows[i][0].ToString();
                    ListViewItem lvi = lsvMonBanItNhat.Items.Add(Nam);
                    lvi.SubItems.Add(dt2.Rows[i][1].ToString());
                    lvi.SubItems.Add(dt2.Rows[i][2].ToString());
                }
                dt3 = db.NhungMonKhongBanDuocTrongNam();
                for (int i = 0; i < dt3.Rows.Count; i++)
                {
                    string Nam = "Năm " + dt3.Rows[i][0].ToString();
                    ListViewItem lvi = lsvMonKhongBanDuoc.Items.Add(Nam);
                    lvi.SubItems.Add(dt3.Rows[i][1].ToString());
                }
            }
        }

        private void btnXemNgayTuyChon_Click(object sender, EventArgs e)
        {
            resetRadio();
            lvDoanhThu.Items.Clear();
            int check = DateTime.Compare(Convert.ToDateTime(dtpNgayKetThuc.Value.ToString()), Convert.ToDateTime(dtpNgayBatDau.Value.ToString()));
            if (check ==-1)
            {
                MessageBox.Show("Ngày không hợp lệ!! Vui lòng chọn lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string BeginDate = dtpNgayBatDau.Value.ToString("yyyy-MM-dd");
                string EndDate = dtpNgayKetThuc.Value.ToString("yyyy-MM-dd");
                DB_DoanhThu db = new DB_DoanhThu();
                DataTable dt = db.getDoanhThuTuyChon(BeginDate, EndDate);
                LoadListDoanhThu(dt);
            }
            
            
        }
        private int NgayTrongThang(int th, int nam)
        {
            int songay = 0;
            if (th >= 1 && th <= 12)
            {
                switch (th)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12: songay = 31; break;
                    case 4:
                    case 6:
                    case 9:
                    case 11: songay = 30; break;

                    case 2:
                        if (nam % 400 == 0 || (nam % 4 == 0 && nam % 100 != 0))    // nam nhuan
                            songay = 29;
                        else
                            songay = 28;
                        break;
                }
            }
            return songay;
        }
        private void lvDoanhThu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDoanhThu.SelectedItems.Count > 0)
            {
                ListViewItem item = lvDoanhThu.SelectedItems[0];
                string date = item.SubItems[0].Text;
                lvSanPhamTheoDoanhThu.Items.Clear();
                DataTable dt = new DataTable();
                DB_DoanhThu db = new DB_DoanhThu();

                /*if (rdoCheckHomNay.Checked == true|| rdoCheckTheoNgay.Checked==true)
                {
                    date = item.SubItems[0].Text;
                    string day = convertFormatDate(date);
                    dt = db.loadSanPhamTheoDoanhThu(day, day);
                    
                }*/
                if(rdoCheckTheoThang.Checked)
                {
                    int day = NgayTrongThang(int.Parse(date.Replace("Tháng", "")),int.Parse(DateTime.Now.Year.ToString()));
                    date = DateTime.Now.Year.ToString() + "-" + date.Replace("Tháng", "") + "-";
                    dt = db.loadSanPhamTheoDoanhThu(date+"01", date+ Convert.ToString(day));

                }
                else if(rdoCheckTheoNam.Checked)
                {
                    date = date.Replace("Năm", "") + "-";
                    dt = db.loadSanPhamTheoDoanhThu(date + "01-01", date + "12-31");
                } 
                else
                {
                    date = item.SubItems[0].Text;
                    string day = convertFormatDate(date);
                    dt = db.loadSanPhamTheoDoanhThu(day, day);
                }    
                LoadListSanPham(dt);

            }
        }

        public string convertFormatDate(string date)
        {
            string day = date.Substring(0, 2);
            string month = date.Substring(3, 2);
            string year = date.Substring(6, 4);
            return year + "-" + month + "-" + day;
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            rdoCheckHomNay.Checked = false;
            dtpNgayBatDau.MaxDate = DateTime.Now;
            dtpNgayKetThuc.MaxDate = DateTime.Now;
            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayKetThuc.Value = DateTime.Now;
        }

        private void lsvMonBanChayNhat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
