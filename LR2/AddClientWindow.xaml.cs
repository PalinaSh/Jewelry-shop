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
    /// Логика взаимодействия для AddClientWindow.xaml
    /// </summary>
    public partial class AddClientWindow : Window
    {
        private ViewModel a;
        public AddClientWindow()
        {
            InitializeComponent();
            DataContext = Stock.DC;
            a = DataContext as ViewModel;
        }

        private void AddClient(object sender, RoutedEventArgs e)
        {
            a.AddClient();
            this.Close();
        }

        private void RedactClient(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
