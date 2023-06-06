using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement
{
    public partial class ChucNangQuanLy : Form
    {
        public ChucNangQuanLy()
        {
            InitializeComponent();
            
        }

        private Form currentForm;
        private void OpenChildForm (Form childForm)
        {
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void buttonChangeColor(object sender, EventArgs e)
        {
            foreach (Control c in btnpanel.Controls)
            {
                c.BackColor = Color.PeachPuff;
            }
            Control click = (Control)sender;
            click.BackColor = Color.SandyBrown;
        }
        

        //private void btnTrangChu_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new TrangChu());
        //    buttonChangeColor(btnTrangChu, null);
        //}

        private void btnThucDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyMon());
            buttonChangeColor(btnThucDon, null);
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyDanhMuc());
            buttonChangeColor(btnDanhMuc, null);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyHoaDon());
            buttonChangeColor(btnHoaDon, null);
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKe());
            buttonChangeColor(btnDoanhThu, null);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyNhanVien());
            buttonChangeColor(btnNhanVien, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }

        private void ChucNangQuanLy_Load(object sender, EventArgs e)
        {
            
        }

        private void panelBody_Paint(object sender, PaintEventArgs e)
        {
            TrangChu child = new TrangChu() { TopLevel = false, TopMost = true };
            child.FormBorderStyle = FormBorderStyle.None;
            panelBody.Controls.Add(child);
            child.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyKhachHang());
            buttonChangeColor(btnKhachHang, null);
        }
    }
}
