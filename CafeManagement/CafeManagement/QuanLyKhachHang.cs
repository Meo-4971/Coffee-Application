using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using DAL;

namespace CafeManagement
{
    public partial class QuanLyKhachHang : Form
    {
        public static DB_KhachHang db = new DB_KhachHang();
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHangList();
        }
        public void LoadKhachHangList()
        {
            lvKhachHang.Items.Clear();
            DataTable KhachHangList = db.GetInFoKhachHang();
            for (int i = 0; i < KhachHangList.Rows.Count; i++)
            {
                ListViewItem lvi = lvKhachHang.Items.Add(KhachHangList.Rows[i][0].ToString());
                lvi.SubItems.Add(KhachHangList.Rows[i][1].ToString());
                lvi.SubItems.Add(KhachHangList.Rows[i][2].ToString());
                lvi.SubItems.Add(KhachHangList.Rows[i][3].ToString());
            }

        }

        private void lvKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvKhachHang.SelectedItems.Count > 0)
            {
                ListViewItem item = lvKhachHang.SelectedItems[0];
                txtMaKhachHang.Text = item.SubItems[0].Text;
                txtTenKhachHang.Text = item.SubItems[1].Text;
                txtDiemTichLuy.Text = item.SubItems[2].Text;
                txtTongChiTieu.Text = item.SubItems[3].Text;
            }
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaKhachHang.Text != "")
                {
                    DialogResult choose = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này không? ", "Yes/No", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (choose == DialogResult.Yes)
                    {
                        
                        bool CheckDelete = db.XoaKhachHang(txtMaKhachHang.Text);
                        if (CheckDelete==true)
                        {
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Reset();
                        }
                        else
                        {
                            MessageBox.Show("Không tồn tại Khách Hàng này!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập SĐT của khách hàng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaKhachHang.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reset()
        {
            txtMaKhachHang.Text = "";
            txtTenKhachHang.Text = "";
            txtTongChiTieu.Text = "";
            txtDiemTichLuy.Text = "";
            LoadKhachHangList();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKhachHang.Text) || string.IsNullOrEmpty(txtTenKhachHang.Text) )
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin ");
                txtMaKhachHang.Focus();
            }
            else
            {
                DialogResult choose = MessageBox.Show("Bạn có chắc cập nhật thông tin khách hàng này không? ", "Yes/No", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (choose == DialogResult.Yes)
                {

                    bool CheckDelete = db.SuaKhachHang(txtMaKhachHang.Text,txtTenKhachHang.Text);
                    if (CheckDelete == true)
                    {
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Thông tin không hợp lệ!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void txtMaKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtTenKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void btnTimKiemMaKH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKhachHang.Text))
            {
                MessageBox.Show("Vui lòng điền Mã Khách Hàng!! ");
                txtMaKhachHang.Focus();
            }
            else
            {
                lvKhachHang.Items.Clear();
                DataTable KhachHangList = db.TimKiemKhachHangTheoMa(txtMaKhachHang.Text);
                for (int i = 0; i < KhachHangList.Rows.Count; i++)
                {
                    ListViewItem lvi = lvKhachHang.Items.Add(KhachHangList.Rows[i][0].ToString());
                    lvi.SubItems.Add(KhachHangList.Rows[i][1].ToString());
                    lvi.SubItems.Add(KhachHangList.Rows[i][2].ToString());
                    lvi.SubItems.Add(KhachHangList.Rows[i][3].ToString());
                }
                
            }
        }

        private void btnTimKiemTenKH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenKhachHang.Text))
            {
                MessageBox.Show("Vui lòng điền Tên Khách Hàng!! ");
                txtTenKhachHang.Focus();
            }
            else
            {
                lvKhachHang.Items.Clear();
                DataTable KhachHangList = db.TimKiemKhachHangTheoTen(txtTenKhachHang.Text);
                for (int i = 0; i < KhachHangList.Rows.Count; i++)
                {
                    ListViewItem lvi = lvKhachHang.Items.Add(KhachHangList.Rows[i][0].ToString());
                    lvi.SubItems.Add(KhachHangList.Rows[i][1].ToString());
                    lvi.SubItems.Add(KhachHangList.Rows[i][2].ToString());
                    lvi.SubItems.Add(KhachHangList.Rows[i][3].ToString());
                }
            }
        }
    }
}
