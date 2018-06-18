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
    /// Логика взаимодействия для AddMasterWindow.xaml
    /// </summary>
    public partial class AddMasterWindow : Window
    {
        private ViewModel a;
        public AddMasterWindow()
        {
            InitializeComponent();
            DataContext = Stock.DC;
            a = DataContext as ViewModel;
        }

        private void OkAdd(object sender, RoutedEventArgs e)
        {
            a.AddMaster();
            this.Close();
        }

        private void OkRedact(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
