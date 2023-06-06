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
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVienList();
        }
        public void LoadNhanVienList()
        {
            lvNhanVien.Items.Clear();
            DB_NhanVien db = new DB_NhanVien();
            DataTable NhanVienList = db.getAllNhanVien();
            for (int i= 0; i < NhanVienList.Rows.Count; i++)
            {
                ListViewItem lvi = lvNhanVien.Items.Add(NhanVienList.Rows[i][0].ToString());
                DateTime NgaySinh = DateTime.Parse(NhanVienList.Rows[i][4].ToString());
                string strNgaySinh = FormatDate(NgaySinh);
                //string strNgaySinh = NgaySinh.Day.ToString() + '-' + NgaySinh.Month.ToString() + '-' + NgaySinh.Year.ToString();
                //DateTime NgaySinh = DateTime.ParseExact(dt.Rows[i][4].ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

                lvi.SubItems.Add(NhanVienList.Rows[i][1].ToString());
                lvi.SubItems.Add(NhanVienList.Rows[i][2].ToString());
                lvi.SubItems.Add(NhanVienList.Rows[i][3].ToString());
                lvi.SubItems.Add(strNgaySinh);
                lvi.SubItems.Add(NhanVienList.Rows[i][5].ToString());
                lvi.SubItems.Add(NhanVienList.Rows[i][6].ToString());
                lvi.SubItems.Add(NhanVienList.Rows[i][7].ToString());
                int Status = int.Parse(NhanVienList.Rows[i][8].ToString());
                if (Status == 1 )
                    lvi.SubItems.Add("Đang làm");
                else
                {
                    lvi.SubItems.Add("Nghỉ việc");
                    
                }    
                    
            }

        }
        public static string FormatDate (DateTime Date )
        {
            string Day, Month, Year;
            Year = Date.Year.ToString();
            if (Date.Day < 10)
                Day = '0' + Date.Day.ToString();
            else
                Day = Date.Day.ToString();
            if (Date.Month < 10)
                Month = '0' + Date.Month.ToString();
            else
                Month = Date.Month.ToString();
            return Day + '-' + Month + '-' + Year;
        }

        /*public void FillDateIntoCbTrangThai()
        {
            List<NhanVien> nvlist = NhanVienDB.getAllNhanVien();
            cbTrangThai.
        }*/
        
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNV.Text) || string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtMatKhau.Text) || string.IsNullOrEmpty(txtLuong.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin ");
            }
            else
            {
                DB_NhanVien db = new DB_NhanVien();
                string TenNhanVien, MatKhau, ChucVu, SDT;
                string NgaySinh = "";
                double Luong;
                if (checkDateInvalid(dtpNgaySinh))
                {
                    NgaySinh = dtpNgaySinh.Value.Year.ToString() + '-' + dtpNgaySinh.Value.Month.ToString() + '-' + dtpNgaySinh.Value.Day.ToString();
                    TenNhanVien = txtTenNV.Text;
                    MatKhau = txtMatKhau.Text;
                    ChucVu = txtChucVu.Text;
                    SDT = txtSDT.Text;

                    Luong = Double.Parse(txtLuong.Text);

                    if (txtMaNV.Text == "")
                    {
                        bool CheckAdd = db.ThemNhanVien(TenNhanVien, MatKhau, ChucVu, NgaySinh, SDT, Luong);
                        if (CheckAdd)
                        {
                            LoadNhanVienList();
                        }
                        MessageBox.Show("Thêm mới nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm được", "Thông báo", MessageBoxButtons.OK);
                    }
                }    
                else
                {
                    MessageBox.Show("Tuổi không hợp lệ! Vui lòng nhập đúng thông tin");
                }
                
                
            }
        }
        private void lvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedItems.Count > 0 )
            {
                ListViewItem item = lvNhanVien.SelectedItems[0];
                txtMaNV.Text = item.SubItems[0].Text;
                txtTenNV.Text = item.SubItems[1].Text;
                txtMatKhau.Text = item.SubItems[2].Text;
                txtChucVu.Text = item.SubItems[3].Text;
                string DateFromList = item.SubItems[4].Text;
                dtpNgaySinh.Value = DateTime.ParseExact(DateFromList, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                txtSDT.Text = item.SubItems[5].Text;
                txtSoGioLam.Text = item.SubItems[7].Text;
                txtLuong.Text = item.SubItems[6].Text;
                string status = item.SubItems[8].Text;
                if (status == "Đang làm")
                {
                    cbTrangThai.SelectedIndex = 0;
                    Enable();
                }   
                else
                {
                    cbTrangThai.SelectedIndex = 1;
                    Disable();
                }    
                    
            }    
        }

        public void Reset()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            txtLuong.Clear();
            txtMatKhau.Clear();
            txtSDT.Clear();
            txtSoGioLam.Clear();
            cbTrangThai.SelectedIndex = -1;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
            Enable();
            LoadNhanVienList();
        }
        private void Disable()
        {
            txtTenNV.Enabled = false;
            dtpNgaySinh.Enabled = false;
            txtMatKhau.Enabled = false;
            txtSDT.Enabled = false;
            txtLuong.Enabled = false;

            btnSuaNV.Enabled = false;
            btnThemNV.Enabled = false;
            btnXoaNV.Enabled = false;
            btnTinhLuongNV.Enabled = false;
        }
        private void Enable()
        {
            txtTenNV.Enabled = true;
            dtpNgaySinh.Enabled = true;
            txtMatKhau.Enabled = true;
            txtSDT.Enabled = true;
            txtLuong.Enabled = true;

            btnSuaNV.Enabled = true;
            btnThemNV.Enabled = true;
            btnXoaNV.Enabled = true;
            btnTinhLuongNV.Enabled = true;
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNV.Text) || string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtMatKhau.Text) || string.IsNullOrEmpty(txtLuong.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin ");
            }
            else
            {
                string MaNhanVien = txtMaNV.Text;
                string TenNhanVien_Update, MatKhau_Update, SDT_Update;
                string NgaySinh_Update;
                double Luong_Update;
                int TrangThai;
                TenNhanVien_Update = txtTenNV.Text;
                MatKhau_Update = txtMatKhau.Text;
                SDT_Update = txtSDT.Text;
                NgaySinh_Update = dtpNgaySinh.Value.Year.ToString() + '-' + dtpNgaySinh.Value.Month.ToString() + '-' + dtpNgaySinh.Value.Day.ToString();
                Luong_Update = Double.Parse(txtLuong.Text);
                if (cbTrangThai.Text == "Đang làm")
                {
                    TrangThai = 1;
                }
                else
                    TrangThai = 0;

                if (txtMaNV.Text != "" )
                {
                    DB_NhanVien db = new DB_NhanVien();
                    if (TrangThai == 1)
                    {
                        bool CheckUpdate = db.SuaNhanVien(MaNhanVien, TenNhanVien_Update, MatKhau_Update, NgaySinh_Update, SDT_Update, Luong_Update, TrangThai);
                        if (CheckUpdate)
                        {
                            LoadNhanVienList();
                        }
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }    
                    else
                        MessageBox.Show("Nhân viên đã bị vô hiệu hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật được", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
        
        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNV.Text != "")
                {
                    DialogResult choose = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này không? ", "Yes/No", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (choose == DialogResult.Yes)
                    {
                        DB_NhanVien db = new DB_NhanVien();
                        bool CheckDelete = db.XoaNhanVien(txtMaNV.Text);
                        if (CheckDelete)
                        {
                            LoadNhanVienList();
                            cbTrangThai.SelectedIndex = 1;
                            Disable();

                        }
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Không thể xóa được", "Thông báo", MessageBoxButtons.OK , MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool checkDateInvalid (DateTimePicker NgaySinh)
        {
            if (DateTime.Now.Year - NgaySinh.Value.Year >= 18)
                return true;
            else
                return false;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
                // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
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

        private void txtLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
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

        private void btnTinhLuongNV_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "")
            {
                int luong = int.Parse(txtSoGioLam.Text) * int.Parse(txtLuong.Text);
                int status = 0;
                DialogResult choose = MessageBox.Show("Nhân viên:  " + txtTenNV.Text +"\n"+ "Số Giờ Làm: " + txtSoGioLam.Text +" tiếng \nLương 1h: " + txtLuong.Text +" VND" + "\n Tổng lương: " + luong + "\n Bạn có muốn thanh toán lương cho nhân viên này không? ", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (choose == DialogResult.Yes)
                {
                    status = 1;
                    
                }
                DB_NhanVien db = new DB_NhanVien();
                bool check = db.TinhLuongNhanVien(txtMaNV.Text, luong, status);
                LoadNhanVienList();
                MessageBox.Show("Thực hiện thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }   
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Form frmLuong = new Luong();
            frmLuong.Show();
        }
    }
}
