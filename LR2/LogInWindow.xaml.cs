using LR2.Classes;
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
    /// Логика взаимодействия для LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        private string LOGIN = "admin";
        private string PASSWD = "admin";
        private ViewModel a;

        public LogIn()
        {
            InitializeComponent();
            DataContext = Stock.DC;
            a = DataContext as ViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (login.Text==LOGIN && passwd.Password==PASSWD)
            {
                AdminWindow adminWindow = new AdminWindow();
                adminWindow.Show();
                MainWindow catalog = (MainWindow)Stock.isAdmin;
                catalog.Close();
            }
            else
            {
                if (!a.IsLogPass(login.Text, passwd.Password))
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка");
                    return;
                }
            }
            MainWindow main = (MainWindow)Stock.isClient;
            main.In.Visibility = Visibility.Collapsed;
            main.Out.Visibility = Visibility.Visible;
            this.Close();
        }

        private void NewClient(object sender, RoutedEventArgs e)
        {
            AddClientWindow addClient = new AddClientWindow();
            a.SomePerson = new Client();
            addClient.Show();
        }
    }
}