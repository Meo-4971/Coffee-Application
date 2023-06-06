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
    public partial class LoginFail : Form
    {
        public LoginFail()
        {
            InitializeComponent();
        }
        int i, n;

        private void timer1_Tick(object sender, EventArgs e)
        {
            pgbHanCho.Maximum = n;
            i--;
            this.lblDemLui.Text = "Sau " + i.ToString() + " giây bạn mới được đăng nhập tiếp";

            if(i >= 0)
            {
                pgbHanCho.Value = i;
            } 
            if(i < 0)
            {
                this.timer1.Enabled = false;
                this.Hide();
                DangNhap dangNhap = new DangNhap();
                dangNhap.ShowDialog();
            }    
        }

        private void LoginFail_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            i = 180;
            n = i;
        }
    }
}
