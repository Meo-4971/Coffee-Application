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
    /// Interaction logic for PageSuaBan.xaml
    /// </summary>
    public partial class PageSuaBan : Page
    {
        public PageSuaBan()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, RoutedEventArgs e)
        {
            Window Wsuaban = (Window)this.Parent;
            Wsuaban.Close();
        }
    }
}
