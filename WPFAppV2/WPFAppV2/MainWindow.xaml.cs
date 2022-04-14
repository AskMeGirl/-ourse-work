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
using WPFAppV2.View;

namespace WPFAppV2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Address_OnClick(object sender, RoutedEventArgs e)
        {
            WindowAddress wAddress = new WindowAddress();
            wAddress.Show();
        }

        private void City_OnClick(object sender, RoutedEventArgs e)
        {
            WindowCity wCity = new WindowCity();
            wCity.Show();
        }

        private void Country_OnClick(object sender, RoutedEventArgs e)
        {
            WindowCountry wCountry = new WindowCountry();
            wCountry.Show();
        }

        private void Region_OnClick(object sender, RoutedEventArgs e)
        {
            WindowRegion wRegion = new WindowRegion();
            wRegion.Show();
        }

        public static int IdAddress { get; set; }
        public static int IdCity { get; set; }
        public static int IdCountry { get; set; }
        public static int IdRegion { get; set; }
    }
}
