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
    
    public partial class PageThongKe : UserControl
    {
        public PageThongKe()
        {
            InitializeComponent();
            cbngay_mon.IsEnabled = false;
            cbthang_mon.IsEnabled = false;
            date_mon.IsEnabled = false;
            cbngaydoanhthu.IsEnabled = false;
            cbthangdoanhthu.IsEnabled = false;
            date_doanhthu.IsEnabled = false;
            for (int i = 1; i <= 31; i++)
            {
                cbngay_mon.Items.Add(i.ToString());
                cbngaydoanhthu.Items.Add(i.ToString());
            }
            for (int j = 1; j <= 12; j++)
            {
                cbthangdoanhthu.Items.Add(j.ToString());
                cbthang_mon.Items.Add(j.ToString());
            }
        }

        private void btndoanhthu_Click(object sender, RoutedEventArgs e)
        {
            dg_macdinh.Visibility = Visibility.Visible;           
            dg_mon.Visibility = Visibility.Collapsed;
        }

        private void btnmon_Click(object sender, RoutedEventArgs e)
        {
            dg_macdinh.Visibility = Visibility.Collapsed;            
            dg_mon.Visibility = Visibility.Visible;
        }

        private void rdngaymon_Click(object sender, RoutedEventArgs e)
        {
            if (rdngaymon.IsChecked == true)
            {
                cbngay_mon.IsEnabled = true;
                cbthang_mon.IsEnabled = false;
                date_mon.IsEnabled = false;
            }
        }

        private void rdthangmon_Click(object sender, RoutedEventArgs e)
        {
            if (rdthangmon.IsChecked == true)
            {
                cbngay_mon.IsEnabled = false;
                cbthang_mon.IsEnabled = true;
                date_mon.IsEnabled = false;
            }
        }

        private void rdtuchonmon_Click(object sender, RoutedEventArgs e)
        {
            if (rdtuchonmon.IsChecked == true)
            {
                cbngay_mon.IsEnabled = false;
                cbthang_mon.IsEnabled = false;
                date_mon.IsEnabled = true;
            }
        }

        private void rdngay_doanhthu_Click(object sender, RoutedEventArgs e)
        {
            if (rdngay_doanhthu.IsEnabled == true)
            {
                cbngaydoanhthu.IsEnabled = true;
                cbthangdoanhthu.IsEnabled = false;
                date_doanhthu.IsEnabled = false;
            }
        }

        private void rdthang_doanhthu_Click(object sender, RoutedEventArgs e)
        {
            if (rdthang_doanhthu.IsEnabled == true)
            {
                cbngaydoanhthu.IsEnabled = false;
                cbthangdoanhthu.IsEnabled = true;
                date_doanhthu.IsEnabled = false;
            }
        }

        private void rdchonngay_doanhthu_Click(object sender, RoutedEventArgs e)
        {
            if (rdchonngay_doanhthu.IsEnabled == true)
            {
                cbngaydoanhthu.IsEnabled = false;
                cbthangdoanhthu.IsEnabled = false;
                date_doanhthu.IsEnabled = true;
            }
        }
    }
}
