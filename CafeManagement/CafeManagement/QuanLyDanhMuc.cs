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
    public partial class QuanLyDanhMuc : Form
    {
        DB_DanhMuc dbDanhMuc;
        public QuanLyDanhMuc()
        {
            InitializeComponent();
            dbDanhMuc = new DB_DanhMuc();
        }

        private void lvDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDanhMuc.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvDanhMuc.SelectedItems[0];
                txtIDDanhMuc.Text = lvi.SubItems[0].Text;
                txtIDDanhMuc.Enabled = false;
                txtTenDanhMuc.Text = lvi.SubItems[1].Text;
            }
            else
                Clear();
        }

        private void FillDanhMucToListView()
        {
            lvDanhMuc.Items.Clear();
            DataTable dt = dbDanhMuc.GetDanhMuc();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lvDanhMuc.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
            }
            lvDanhMuc.View = View.Details;
            lvDanhMuc.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvDanhMuc.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        

        void Clear()
        {
            this.txtIDDanhMuc.ResetText();
            this.txtTenDanhMuc.ResetText();
        }

        private int CheckExistingMaDanhMuc(string MaDanhMuc)
        {
            for (int i = 0; i < lvDanhMuc.Items.Count; i++)
            {
                if (lvDanhMuc.Items[i].SubItems[0].Text == MaDanhMuc)
                    return i;
            }
            return -1;
        }

        
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDDanhMuc.Text == "" || txtTenDanhMuc.Text == "")
                    throw new Exception("Vui lòng điền đầy đủ thông tin!");
                int i = CheckExistingMaDanhMuc(txtIDDanhMuc.Text);
                if (i != -1)
                {
                    DialogResult selected = MessageBox.Show("Bạn chắc chắn sửa thông tin này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (selected == DialogResult.Yes)
                    {
                        dbDanhMuc.CapNhatDanhMuc(txtIDDanhMuc.Text, txtTenDanhMuc.Text);
                        FillDanhMucToListView();
                        MessageBox.Show("Sửa danh mục thành công.", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Không thể sửa nếu mã danh mục không tồn tại.", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void QuanLyDanhMuc_Load(object sender, EventArgs e)
        {
            try
            {
                FillDanhMucToListView();
                lvDanhMuc.FullRowSelect = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
