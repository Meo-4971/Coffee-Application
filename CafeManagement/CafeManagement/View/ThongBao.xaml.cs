using CafeMVVM.ViewModels;
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
using System.Windows.Shapes;


namespace CafeMVVM.Views
{
    public partial class ThongBao : Window
    {
        public ThongBao(string noidung, string tieudehinh)
        {
            InitializeComponent();
            string duongdan = System.AppDomain.CurrentDomain.BaseDirectory;
            if (tieudehinh == "ThanhCong")
            {
                btnYes.Visibility = Visibility.Collapsed;
                btnNo.Visibility = Visibility.Collapsed;
                duongdan = duongdan + "Image/" + "CheckTC.png";
            }
            else if (tieudehinh == "CauHoi")
            {
                btnOk.Visibility = Visibility.Collapsed;
                duongdan = duongdan + "Image/" + "CauHoi.png";
            }
            else if (tieudehinh == "CanhBao")
            {
                btnYes.Visibility = Visibility.Collapsed;
                btnNo.Visibility = Visibility.Collapsed;
                duongdan = duongdan + "Image/" + "CanhBao.png";
            }
            hinhanh.Source = new BitmapImage(new Uri(duongdan));
            lbNoidung.Content = noidung;
        }
        public ThongBao()
        {
            InitializeComponent();                     
        }
        public void EventYesNo(string noidung, string tieudehinh)
        {
            string duongdan = System.AppDomain.CurrentDomain.BaseDirectory;
            if (tieudehinh == "CauHoi")
            {
                btnOk.Visibility = Visibility.Collapsed;
                duongdan = duongdan + "Image/" + "CauHoi.png";
            }          
            hinhanh.Source = new BitmapImage(new Uri(duongdan));
            lbNoidung.Content = noidung;
        }
        public  bool Yes=false;
        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnYes_Click(object sender, RoutedEventArgs e)
        {
            Yes = true;
            this.Close();
        }

        private void btnNo_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
