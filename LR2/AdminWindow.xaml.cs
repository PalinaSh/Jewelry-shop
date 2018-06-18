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
using System.Windows.Shapes;

namespace LR2
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        private ViewModel a;
        public AdminWindow()
        {
            InitializeComponent();
            DataContext = new ViewModel();
            a = DataContext as ViewModel;
            Stock.DC = DataContext;
        }

        private void GetRings(object sender, RoutedEventArgs e)
        {
            a.GetRings();
            jewelryType.ItemsSource = a.JewelryType;
        }

        private void GetEarRings(object sender, RoutedEventArgs e)
        {
            a.GetEarrings();
            jewelryType.ItemsSource = a.JewelryType;
        }

        private void GetPendant(object sender, RoutedEventArgs e)
        {
            a.GetPendant();
            jewelryType.ItemsSource = a.JewelryType;
        }

        private void GetAll(object sender, RoutedEventArgs e)
        {
            a.GetAllJewelry();
            jewelryType.ItemsSource = a.JewelryType;
        }

        private void GetAllCatalog(object sender, RoutedEventArgs e)
        {
            catalog.Visibility = Visibility.Visible;
            clients.Visibility = Visibility.Collapsed;
            masters.Visibility = Visibility.Collapsed;
            orders.Visibility = Visibility.Collapsed;
            allJewelries.IsChecked = true;
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            a.SaveChanges();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void SaveAll(object sender, CancelEventArgs e)
        {
            a.SaveChanges();
        }

        private void GetClients(object sender, RoutedEventArgs e)
        {
            catalog.Visibility = Visibility.Collapsed;
            clients.Visibility = Visibility.Visible;
            masters.Visibility = Visibility.Collapsed;
            orders.Visibility = Visibility.Collapsed;
        }

        private void GetMasters(object sender, RoutedEventArgs e)
        {
            catalog.Visibility = Visibility.Collapsed;
            clients.Visibility = Visibility.Collapsed;
            masters.Visibility = Visibility.Visible;
            orders.Visibility = Visibility.Collapsed;
        }

        private void GetOrders(object sender, RoutedEventArgs e)
        {
            catalog.Visibility = Visibility.Collapsed;
            clients.Visibility = Visibility.Collapsed;
            masters.Visibility = Visibility.Collapsed;
            orders.Visibility = Visibility.Visible;
        }

        private void SearchVenderCode(object sender, TextChangedEventArgs e)
        {
            allJewelries.IsChecked = false;
            rings.IsChecked = false;
            ear.IsChecked = false;
            pendant.IsChecked = false;
            a.GetVenderCode(vendercode.Text);
            jewelryType.ItemsSource = a.JewelryType;
        }

        private void ShowAllPerson(object sender, RoutedEventArgs e)
        {
            a.GetAllPerson();
            clientsList.ItemsSource = a.Clients;
        }

        private void SearchSurname(object sender, TextChangedEventArgs e)
        {
            a.GetSurname(surname.Text);
            clientsList.ItemsSource = a.Clients;
        }

        private void SearchId(object sender, TextChangedEventArgs e)
        {
            a.GetID(id.Text);
            clientsList.ItemsSource = a.Clients;
        }

        private void ShowAllMaster(object sender, RoutedEventArgs e)
        {
            a.GetAllMasters();
            mastersList.ItemsSource = a.Masters;
        }

        private void SearchSurnameMaster(object sender, TextChangedEventArgs e)
        {
            a.GetSurnameMaster(surnameM.Text);
            mastersList.ItemsSource = a.Masters;
        }

        private void SearchRaiting(object sender, TextChangedEventArgs e)
        {
            a.GetRating(rating.Text);
            mastersList.ItemsSource = a.Masters;
        }

        private void ShowAllOrders(object sender, RoutedEventArgs e)
        {
            a.GetAllOrders();
            ordersList.ItemsSource = a.Orders;
        }

        private void SearchCodeJewelry(object sender, TextChangedEventArgs e)
        {
            a.GetCodeJewelry(venderCode.Text);
            ordersList.ItemsSource = a.Orders;
        }

        private void SearchNameMaster(object sender, TextChangedEventArgs e)
        {
            a.GetNameMasters(nameM.Text);
            ordersList.ItemsSource = a.Orders;
        }

        private void SearchType(object sender, TextChangedEventArgs e)
        {
            a.GetTypeJewelry(type.Text);
            ordersList.ItemsSource = a.Orders;
        }

        private void AddJewelry(object sender, RoutedEventArgs e)
        {
            a.SomeJewelry = new Jewelry();
            AddJewelryWindow add = new AddJewelryWindow();
            add.add.Visibility = Visibility.Visible;
            add.redact.Visibility = Visibility.Collapsed;
            add.Show();
            //add.Owner = this;
        }

        private void RemoveJewelry(object sender, RoutedEventArgs e)
        {
            a.RemoveJewelry();
            jewelryType.ItemsSource = a.JewelryType;
        }

        private void RedactJewelry(object sender, RoutedEventArgs e)
        {
            AddJewelryWindow add = new AddJewelryWindow();
            add.redact.Visibility = Visibility.Visible;
            add.add.Visibility = Visibility.Collapsed;
            add.Show();
            add.Owner = this;
            Stock.admin = this;
        }

        private void RemoveOrder(object sender, RoutedEventArgs e)
        {
            a.RemoveOrder();
            ordersList.ItemsSource = a.Orders;
        }

        //private void AddClient(object sender, RoutedEventArgs e)
        //{
        //    a.SomePerson = new Client();
        //    a.AddClient();
        //    AddClientWindow addClient = new AddClientWindow();
        //    addClient.newClinent.Visibility = Visibility.Visible;
        //    addClient.redactClient.Visibility = Visibility.Collapsed;
        //    addClient.orders.Visibility = Visibility.Hidden;
        //    addClient.textOrders.Visibility = Visibility.Collapsed;
        //    addClient.OkAdd.Visibility = Visibility.Visible;
        //    addClient.OkRedact.Visibility = Visibility.Collapsed;
        //    addClient.Show();
        //    addClient.Owner = this;
        //    clientsList.ItemsSource = a.Clients;
        ////}

        //private void RedactClient(object sender, RoutedEventArgs e)
        //{
        //    AddClientWindow addClient = new AddClientWindow();
        //    addClient.redactClient.Visibility = Visibility.Visible;
        //    addClient.newClinent.Visibility = Visibility.Collapsed;
        //    addClient.orders.Visibility = Visibility.Visible;
        //    addClient.textOrders.Visibility = Visibility.Visible;
        //    addClient.OkAdd.Visibility = Visibility.Collapsed;
        //    addClient.OkRedact.Visibility = Visibility.Visible;
        //    addClient.Show();
        //    addClient.Owner = this;
        //    clientsList.ItemsSource = a.Clients;
        //}

        private void RemoveClient(object sender, RoutedEventArgs e)
        {
            a.RemoveClient();
            clientsList.ItemsSource = a.Clients;
        }

        private void AddMaster(object sender, RoutedEventArgs e)
        {
            a.SomeMaster = new Master();
            AddMasterWindow addMaster = new AddMasterWindow();
            addMaster.add.Visibility = Visibility.Visible;
            addMaster.redact.Visibility = Visibility.Collapsed;
            addMaster.addButton.Visibility = Visibility.Visible;
            addMaster.redactButton.Visibility = Visibility.Collapsed;
            addMaster.Show();
            addMaster.Owner = this;
        }

        private void RedactMaster(object sender, RoutedEventArgs e)
        {
            AddMasterWindow addMaster = new AddMasterWindow();
            addMaster.redact.Visibility = Visibility.Visible;
            addMaster.add.Visibility = Visibility.Collapsed;
            addMaster.redactButton.Visibility = Visibility.Visible;
            addMaster.addButton.Visibility = Visibility.Collapsed;
            addMaster.Show();
            addMaster.Owner = this;
        }

        private void RemoveMaster(object sender, RoutedEventArgs e)
        {
            bool isRemove = a.RemoveMaster();
            if (isRemove == false)
                MessageBox.Show("Мастер ещё выполняет заказы","Невозможно удалить");
            mastersList.ItemsSource = a.Masters;
        }

    }
}