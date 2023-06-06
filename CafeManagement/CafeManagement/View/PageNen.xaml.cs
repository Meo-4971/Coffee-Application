using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CafeMVVM.Views
{
    public partial class PageNen : UserControl
    {
        public static PageNen pnen;
       
        public PageNen()
        {
            InitializeComponent();
            pnen = this;
           
        }
        public void setquyen(string hoten,string quyen)
        {
            txtuser.Content = "Người dùng: " + hoten;
            txtquyen.Content = "Quyền: " + quyen;
        }
    }
}
