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
    public partial class QuanLyMon : Form
    {
        DB_Mon dbMon;
        public QuanLyMon()
        {
            InitializeComponent();
            dbMon = new DB_Mon();
        }

        private void QuanLyMon_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtDanhMuc = dbMon.LayDanhMuc();
                FillMonToListView();
                FillDataIntoComboxDanhMuc(dtDanhMuc);
                lvMon.FullRowSelect = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillMonToListView()
        {
            lvMon.Items.Clear();
            DataTable dt = dbMon.GetInfoMon();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lvMon.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                if (dt.Rows[i][5].ToString() == "True")
                    lvi.SubItems.Add("Còn phục vụ");
                else lvi.SubItems.Add("Hết phục vụ");
            }
            lvMon.View = View.Details;
            lvMon.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvMon.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void FillDataIntoComboxDanhMuc(DataTable dtMon)
        {
            cbDanhMuc.Items.Clear();
            for (int i = 0; i < dtMon.Rows.Count; i++)
            {
                cbDanhMuc.Items.Add(dtMon.Rows[i][0].ToString());
            }
        }

        private void lvMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMon.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvMon.SelectedItems[0];
                txtMaMon.Text = lvi.SubItems[0].Text;
                txtMaMon.Enabled = false;
                txtTenMon.Text = lvi.SubItems[1].Text;
                cbDanhMuc.Text = lvi.SubItems[2].Text;
                txtDonGia.Text = lvi.SubItems[3].Text;
                txtSoLuong.Text = lvi.SubItems[4].Text;
                if (lvi.SubItems[5].Text == "Còn phục vụ")
                    rdoTrangThai.Checked = true;
                else rdoTrangThai.Checked = false;
            }
            else
            {
                txtMaMon.Enabled = true;
                Clear();
            }
        }

        void Clear()
        {
            this.txtMaMon.ResetText();
            this.txtTenMon.ResetText();
            this.cbDanhMuc.ResetText();
            this.txtDonGia.ResetText();
            this.txtSoLuong.ResetText();
            this.rdoTrangThai.Checked = false;
        }

        private int CheckExistingMaMon(string MaMon)
        {
            for (int i = 0; i < lvMon.Items.Count; i++)
            {
                if (lvMon.Items[i].SubItems[0].Text == MaMon)
                    return i;
            }
            return -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaMon.Text == "" || txtTenMon.Text == "" || cbDanhMuc.Text == "" || txtDonGia.Text == "" || txtSoLuong.Text == "")
                throw new Exception("Vui lòng điền đầy đủ thông tin!");
            if (CheckExistingMaMon(txtMaMon.Text) == -1)
            {
                string maDanhMuc;
                if (cbDanhMuc.Text == "Cà phê")
                    maDanhMuc = "DM01";
                else if (cbDanhMuc.Text == "Trà")
                    maDanhMuc = "DM02";
                else maDanhMuc = "DM03";


                dbMon.ThemMon(txtMaMon.Text, txtTenMon.Text, maDanhMuc, txtDonGia.Text, txtSoLuong.Text, 1);
                FillMonToListView();
                MessageBox.Show("Thêm món thành công.", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Món đã tồn tại trong Menu!", "Thông báo", MessageBoxButtons.OK);
                Clear();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaMon.Text == "" || txtTenMon.Text == "" || cbDanhMuc.Text == "" || txtDonGia.Text == "" || txtSoLuong.Text == "")
                    throw new Exception("Vui lòng điền đầy đủ thông tin!");
                int i = CheckExistingMaMon(txtMaMon.Text);
                if (i != -1)
                {
                    DialogResult selected = MessageBox.Show("Bạn chắc chắn sửa thông tin này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (selected == DialogResult.Yes)
                    {
                        string maDanhMuc;
                        if (cbDanhMuc.Text == "Cà phê")
                            maDanhMuc = "DM01";
                        else if (cbDanhMuc.Text == "Trà")
                            maDanhMuc = "DM02";
                        else maDanhMuc = "DM03";
                        dbMon.CapNhatMon(txtMaMon.Text, txtTenMon.Text, maDanhMuc, txtDonGia.Text, txtSoLuong.Text, 1);
                        FillMonToListView();
                        MessageBox.Show("Sửa món thành công.", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Không thể sửa nếu mã món không tồn tại.", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi rồi, không thể sửa!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = CheckExistingMaMon(txtMaMon.Text);
            if (i != -1)
            {
                DialogResult selected = MessageBox.Show("Bạn chắc chắn muốn xóa món này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (selected == DialogResult.Yes)
                {
                    dbMon.XoaMon(txtMaMon.Text);
                    FillMonToListView();
                    MessageBox.Show("Xóa món thành công.", "Thông báo", MessageBoxButtons.OK);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Không thực hiện việc xóa món!");
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                FillMonToListView();
            }
            else
            {
                if (rdbTheoMa.Checked == true)
                {
                    try
                    {
                        DataTable dt = dbMon.TimKiemMonTheoMa(txtTimKiem.Text);
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy món cần tìm!", "Thông báo", MessageBoxButtons.OK);
                            txtTimKiem.Text = "";
                        }
                        else
                        {
                            lvMon.Items.Clear();
                            for (int i = 0; i < dt.Rows.Count; ++i)
                            {
                                ListViewItem lvi = lvMon.Items.Add(dt.Rows[i][0].ToString());
                                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                                if (dt.Rows[i][5].ToString() == "True")
                                    lvi.SubItems.Add("Còn phục vụ");
                                else lvi.SubItems.Add("Hết phục vụ");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        DataTable dt = dbMon.TimKiemMonTheoTen(txtTimKiem.Text);
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy món cần tìm!", "Thông báo", MessageBoxButtons.OK);
                            txtTimKiem.Text = "";
                        }
                        else
                        {
                            lvMon.Items.Clear();
                            for (int i = 0; i < dt.Rows.Count; ++i)
                            {
                                ListViewItem lvi = lvMon.Items.Add(dt.Rows[i][0].ToString());
                                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                                if (dt.Rows[i][5].ToString() == "True")
                                    lvi.SubItems.Add("Còn phục vụ");
                                else lvi.SubItems.Add("Hết phục vụ");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
