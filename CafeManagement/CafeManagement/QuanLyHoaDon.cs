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
    public partial class QuanLyHoaDon : Form
    {
        public static int maHoaDonCopy;
        public static DateTime ngayGioCopy;
        public static int giamGiaCopy;
        public QuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            DB_HoaDon db = new DB_HoaDon();

            DataTable dt = db.LayDSHoaDon();
            LoadInfoHoaDon(dt);
        }

        private void LoadInfoHoaDon(DataTable dt)
        {
            lvHoaDon.Items.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lvHoaDon.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                if (i%2 == 1)
                {
                    lvi.BackColor = Color.Coral;
                }
            }
        }

        private void lvHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (lvHoaDon.SelectedItems.Count >= 1)
            {
                ListViewItem lvi = lvHoaDon.SelectedItems[0];
                maHoaDonCopy = Convert.ToInt32(lvi.SubItems[0].Text);
                ngayGioCopy = Convert.ToDateTime(lvi.SubItems[1].Text);
                giamGiaCopy = Convert.ToInt32(lvi.SubItems[5].Text);
                Form ChiTietHoaDon = new ChiTietHoaDon();
                ChiTietHoaDon.Show();
            }

            
        }
    }
}
