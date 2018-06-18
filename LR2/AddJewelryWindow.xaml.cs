using LR2.Classes;
using Microsoft.Win32;
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

namespace LR2
{
    /// <summary>
    /// Логика взаимодействия для AddJewelryWindow.xaml
    /// </summary>
    public partial class AddJewelryWindow : Window
    {
        string filename = "";
        private ViewModel a;
        string[] types = new string[3] { "серьги", "кольцо", "подвеска" };
        string[] kernels = new string[3] { "рубин", "сапфир", "фианит" };
        string[] materials = new string[3] { "серебро", "золото", "комбинированный" };
        string[] brends = new string[3] { "SOKOLOV", "Санис", "Zorka" };
        public AddJewelryWindow()
        {
            InitializeComponent();
            DataContext = Stock.DC;
            a = DataContext as ViewModel;
        }

        private void LoadImage(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            bool? result = dlg.ShowDialog();
            if (result == true)
            {
                filename = dlg.FileName;
                BitmapImage path = new BitmapImage();
                path.BeginInit();
                path.UriSource = new Uri(filename, UriKind.Relative);
                path.CacheOption = BitmapCacheOption.OnLoad;
                path.EndInit();
                image.Source = path;
                a.SomeJewelry.Image = image.Source.ToString();
            }
        }

        private void OkClick(object sender, RoutedEventArgs e)
        {
            a.SomeJewelry.Type.NameOfJewerly = types[asd.SelectedIndex];
            a.SomeJewelry.Basis.Material.Name = materials[asd.SelectedIndex];
            a.SomeJewelry.Kernel.Material.Name = kernels[asd.SelectedIndex];
            a.SomeJewelry.Brand = brends[asd.SelectedIndex];
            a.AddJewelry();
            this.Close();
        }

        private void LoadImageRedact(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            bool? result = dlg.ShowDialog();
            if (result == true)
            {
                filename = dlg.FileName;
                BitmapImage path = new BitmapImage();
                path.BeginInit();
                path.UriSource = new Uri(filename, UriKind.Relative);
                path.CacheOption = BitmapCacheOption.OnLoad;
                path.EndInit();
                photo.Source = path;
                a.SomeJewelry.Image = photo.Source.ToString();
            }
        }

        private void OKRedadact(object sender, RoutedEventArgs e)
        {
            a.RedactJewelry();
            this.Close();
            AdminWindow admin = (AdminWindow)Stock.admin;
            if (admin.allJewelries.IsChecked == true)
            {
                admin.allJewelries.IsChecked = false;
                admin.allJewelries.IsChecked = true;
            }
            if (admin.rings.IsChecked == true)
            {
                admin.rings.IsChecked = false;
                admin.rings.IsChecked = true;
            }
            if (admin.ear.IsChecked == true)
            {
                admin.ear.IsChecked = false;
                admin.ear.IsChecked = true;
            }
            if (admin.pendant.IsChecked == true)
            {
                admin.pendant.IsChecked = false;
                admin.pendant.IsChecked = true;
            }
        }
    }
}
