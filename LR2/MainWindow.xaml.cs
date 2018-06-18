using LR2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace LR2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static bool filterSilver = false;
        public static bool filterGold = false;
        public static bool filterComb = false;
        private ViewModel a;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ViewModel();
            a = DataContext as ViewModel;
            Stock.DC = DataContext;
            Stock.isAdmin = this;
        }

        private void GetAll(object sender, RoutedEventArgs e)
        {
            silver.IsChecked = false;
            gold.IsChecked = false;
            combine.IsChecked = false;
            sokolov.IsChecked = false;
            zorka.IsChecked = false;
            sanis.IsChecked = false;
            rubin.IsChecked = false;
            phianit.IsChecked = false;
            sapfir.IsChecked = false;
            a.GetAllJewelry();
            jewelryType.ItemsSource = a.JewelryType;
        }

        private void GetRings(object sender, RoutedEventArgs e)
        {
            silver.IsChecked = false;
            gold.IsChecked = false;
            combine.IsChecked = false;
            sokolov.IsChecked = false;
            zorka.IsChecked = false;
            sanis.IsChecked = false;
            rubin.IsChecked = false;
            phianit.IsChecked = false;
            sapfir.IsChecked = false;
            a.GetRings();
            jewelryType.ItemsSource = a.JewelryType;
        }

        private void GetEarRings(object sender, RoutedEventArgs e)
        {
            silver.IsChecked = false;
            gold.IsChecked = false;
            combine.IsChecked = false;
            sokolov.IsChecked = false;
            zorka.IsChecked = false;
            sanis.IsChecked = false;
            rubin.IsChecked = false;
            phianit.IsChecked = false;
            sapfir.IsChecked = false;
            a.GetEarrings();
            jewelryType.ItemsSource = a.JewelryType;
        }

        private void GetPendant(object sender, RoutedEventArgs e)
        {
            silver.IsChecked = false;
            gold.IsChecked = false;
            combine.IsChecked = false;
            sokolov.IsChecked = false;
            zorka.IsChecked = false;
            sanis.IsChecked = false;
            rubin.IsChecked = false;
            phianit.IsChecked = false;
            sapfir.IsChecked = false;
            a.GetPendant();
            jewelryType.ItemsSource = a.JewelryType;
        }

        private void LogIn(object sender, RoutedEventArgs e)
        {
            LogIn dialog = new LogIn();
            Stock.isClient = this;
            dialog.Owner = this;
            dialog.ShowDialog();
        }

        private void LogOut(object sender, RoutedEventArgs e)
        {
            In.Visibility = Visibility.Visible;
            Out.Visibility = Visibility.Collapsed;
            filters.Visibility = Visibility.Visible;
            selectedMaster.Visibility = Visibility.Collapsed;
            jewelryType.Visibility = Visibility.Visible;
            jewelryBasket.Visibility = Visibility.Collapsed;
            all.IsChecked = true;
            a.GetAllJewelry();
        }

        private void GetSilver(object sender, RoutedEventArgs e)
        {
            a.GetSilver();
            jewelryType.ItemsSource = a.JewelryType;
        }

        private void GetGold(object sender, RoutedEventArgs e)
        {
            a.GetGold();
            jewelryType.ItemsSource = a.JewelryType;
        }

        private void GetCombine(object sender, RoutedEventArgs e)
        {
            a.GetCombine();
            jewelryType.ItemsSource = a.JewelryType;
        }

        private void GetSokolov(object sender, RoutedEventArgs e)
        {
            a.GetBrand("SOKOLOV");
            jewelryType.ItemsSource = a.JewelryType;
        }

        private void GetZorka(object sender, RoutedEventArgs e)
        {
            a.GetBrand("Zorka");
            jewelryType.ItemsSource = a.JewelryType;
        }

        private void GetSanis(object sender, RoutedEventArgs e)
        {
            a.GetBrand("Санис");
            jewelryType.ItemsSource = a.JewelryType;
        }

        private void GetRubin(object sender, RoutedEventArgs e)
        {
            a.GetKernel("рубин");
            jewelryType.ItemsSource = a.JewelryType;
        }

        private void GetSapfir(object sender, RoutedEventArgs e)
        {
            a.GetKernel("сапфир");
            jewelryType.ItemsSource = a.JewelryType;
        }

        private void GetPhianit(object sender, RoutedEventArgs e)
        {
            a.GetKernel("фианит");
            jewelryType.ItemsSource = a.JewelryType;
        }

        private void ShowBasket(object sender, RoutedEventArgs e)
        {
            jewelryType.Visibility = Visibility.Collapsed;
            jewelryBasket.Visibility = Visibility.Visible;
            ordersList.Visibility = Visibility.Collapsed;
            add.Visibility = Visibility.Collapsed;
            sub.Visibility = Visibility.Visible;
            filters.Visibility = Visibility.Collapsed;
            selectedMaster.Visibility = Visibility.Visible;
            showBasket.Visibility = Visibility.Collapsed;
            showCatalog.Visibility = Visibility.Visible;
            a.ShowBasket();
        }

        private void ShowCatalog(object sender, RoutedEventArgs e)
        {
            a.ShowCatalog();
            jewelryType.Visibility = Visibility.Visible;
            jewelryBasket.Visibility = Visibility.Collapsed;
            ordersList.Visibility = Visibility.Collapsed;
            add.Visibility = Visibility.Visible;
            sub.Visibility = Visibility.Collapsed;
            filters.Visibility = Visibility.Visible;
            selectedMaster.Visibility = Visibility.Collapsed;
            showBasket.Visibility = Visibility.Visible;
            showCatalog.Visibility = Visibility.Collapsed;
            all.IsChecked = true;
            a.GetAllJewelry();
        }

        private void ShowOrders(object sender, RoutedEventArgs e)
        {
            a.ShowOrders();
            ordersList.Visibility = Visibility.Visible;
            jewelryBasket.Visibility = Visibility.Collapsed;
            add.Visibility = Visibility.Hidden;
            sub.Visibility = Visibility.Collapsed;
            filters.Visibility = Visibility.Collapsed;
            selectedMaster.Visibility = Visibility.Collapsed;
            showBasket.Visibility = Visibility.Collapsed;
            showCatalog.Visibility = Visibility.Visible;
        }

        private void AddJewelryInBasket(object sender, RoutedEventArgs e)
        {
            a.AddJewelryInBasket();
        }

        private void SubJewelryFromBasket(object sender, RoutedEventArgs e)
        {
            a.RemoveJewelryFromBasket();
        }

        private void GetPrice(object sender, SelectionChangedEventArgs e)
        {
            workPrice.Text = a.GetPrice().ToString();
            beginWork.Text = a.Today.AddDays(a.SomeMaster.Busy + 1).ToString();
            endWork.Text = a.Today.AddDays(a.GetEndWork()).ToString();
            priceOrder.Text = a.GetPriceOrder().ToString();
        }

        private void NewOrder(object sender, RoutedEventArgs e)
        {
            a.NewOrder();
        }

        private void NewDay(object sender, RoutedEventArgs e)
        {
            a.GetNewDay();
        }

        private void SaveAll(object sender, CancelEventArgs e)
        {
            a.SaveChanges();
        }
    }
}