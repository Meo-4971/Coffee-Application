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
    /// <summary>
    /// Interaction logic for PageDangNhap.xaml
    /// </summary>
    public partial class PageDangNhap : Window
    {
        public static PageDangNhap dn;
        public PageDangNhap()
        {
            InitializeComponent();
            dn = this;
            txttendangnhap.Focus();
        }

        private void lbthoat_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
