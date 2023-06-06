
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using WpfPageTransitions;

namespace CafeMVVM.Views
{
    public partial class Cafe : Window
    {
        public static Cafe fHome;
        public Cafe()
        {
            InitializeComponent();           
            fHome = this;
            string duongdan = AppDomain.CurrentDomain.BaseDirectory;
            igridnen.ImageSource = new BitmapImage(new Uri(duongdan + "Image/" + "NenCafe.jpeg"));
            hinhphucvu.Source = new BitmapImage(new Uri(duongdan + "Image/" + "ButtonPhucVu.png"));
            hinhkhuvuc.Source = new BitmapImage(new Uri(duongdan + "Image/" + "ButtonKhuVuc.png"));
            hinhban.Source = new BitmapImage(new Uri(duongdan + "Image/" + "ButtonTable.png"));
            hinhthucdon.Source = new BitmapImage(new Uri(duongdan + "Image/" + "ButtonThucDon.png"));
            hinhgiamgia.Source = new BitmapImage(new Uri(duongdan + "Image/" + "ButtonGiamGia.png"));
            hinhthongke.Source = new BitmapImage(new Uri(duongdan + "Image/" + "ButtonThongKe.png"));
            hinhtaikhoan.Source = new BitmapImage(new Uri(duongdan + "Image/" + "ButtonTaiKhoan.png"));
            hinhdangxuat.Source = new BitmapImage(new Uri(duongdan + "Image/" + "BtnDangXuat.png"));
            hinhthoat.Source = new BitmapImage(new Uri(duongdan + "Image/" + "ButtonExit.png"));
            PageNen nen = new PageNen();
            pageTransitionControl.TransitionType = (PageTransitionType)Enum.Parse(typeof(PageTransitionType), "Fade", true);
            pageTransitionControl.ShowPage(nen);
        }
      
        public void capquyen(string Quyen)
        {
            if (Quyen.ToUpper() == "ADMIN")
            {
                btnphucvu.IsEnabled = true;
                btnkhuvuc.IsEnabled = true;
                btnban.IsEnabled = true;
                btnthucdon.IsEnabled = true;
                btngiamgia.IsEnabled = true;
                btnthongke.IsEnabled = true;
                btntaikhoan.IsEnabled = true;
                btnthoat.IsEnabled = true;
                btndangxuat.IsEnabled = true;
            }
            else if (Quyen.ToUpper() == "USER")
            {
                btnphucvu.IsEnabled = true;
                btnthoat.IsEnabled = true;
                btndangxuat.IsEnabled = true;
                btnkhuvuc.IsEnabled = false;
                btnban.IsEnabled = false;
                btnthucdon.IsEnabled = false;
                btngiamgia.IsEnabled = false;
                btnthongke.IsEnabled = false;
                btntaikhoan.IsEnabled = false;
            }
        }
        
        
        
        
           
        
        
        private void btnphucvu_Click(object sender, RoutedEventArgs e)
        {
            PageHome phucvu = new PageHome();
            pageTransitionControl.TransitionType= (PageTransitionType)Enum.Parse(typeof(PageTransitionType), "Fade", true);
            pageTransitionControl.ShowPage(phucvu);
        }

        private void btnthoat_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void btnkhuvuc_Click(object sender, RoutedEventArgs e)
        {
            PageKhuVuc khuvuc = new PageKhuVuc();
            pageTransitionControl.TransitionType = (PageTransitionType)Enum.Parse(typeof(PageTransitionType), "Fade", true);
            pageTransitionControl.ShowPage(khuvuc);
        }

        private void btnban_Click(object sender, RoutedEventArgs e)
        {
            PageBan ban = new PageBan();
            pageTransitionControl.TransitionType = (PageTransitionType)Enum.Parse(typeof(PageTransitionType), "Fade", true);
            pageTransitionControl.ShowPage(ban);
        }

        private void btnthucdon_Click(object sender, RoutedEventArgs e)
        {
            PageThucDon thucdon = new PageThucDon();
            pageTransitionControl.TransitionType = (PageTransitionType)Enum.Parse(typeof(PageTransitionType), "Fade", true);
            pageTransitionControl.ShowPage(thucdon);
        }

        private void btngiamgia_Click(object sender, RoutedEventArgs e)
        {
            PageGiamGia giamgia = new PageGiamGia();
            pageTransitionControl.TransitionType = (PageTransitionType)Enum.Parse(typeof(PageTransitionType), "Fade", true);
            pageTransitionControl.ShowPage(giamgia);
        }

        private void btntaikhoan_Click(object sender, RoutedEventArgs e)
        {
            PageQuanLyTaiKhoan taikhoan = new PageQuanLyTaiKhoan();
            pageTransitionControl.TransitionType = (PageTransitionType)Enum.Parse(typeof(PageTransitionType), "Fade", true);
            pageTransitionControl.ShowPage(taikhoan);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PageDangNhap dn = new PageDangNhap();
            dn.ShowInTaskbar = false;       
            dn.ShowDialog();
        }

        private void btndangxuat_Click(object sender, RoutedEventArgs e)
        {
            btnkhuvuc.IsEnabled = false;
            btnban.IsEnabled = false;
            btnthucdon.IsEnabled = false;
            btngiamgia.IsEnabled = false;
            btnthongke.IsEnabled = false;
            btntaikhoan.IsEnabled = false;
            btnphucvu.IsEnabled = false;
            btndangxuat.IsEnabled = false;
            btnthoat.IsEnabled = false;
            PageDangNhap dn = new PageDangNhap();
            dn.ShowDialog();
        }

        private void btnthongke_Click(object sender, RoutedEventArgs e)
        {
            PageThongKe taikhoan = new PageThongKe();
            pageTransitionControl.TransitionType = (PageTransitionType)Enum.Parse(typeof(PageTransitionType), "Fade", true);
            pageTransitionControl.ShowPage(taikhoan);
        }
    }
}
