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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for Window8.xaml
    /// </summary>
    public partial class Window8 : Window
    {
        List<Logins> users;
        List<Kompr> list;

        public Window8()
        {
            InitializeComponent();
            users = new List<Logins>();            
            list = new List<Kompr>();
            Main.NavigationService.Navigate(new Page1(users, list));
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            users.Add(new Logins("hseguest", "hsepassword"));
            list.Add(new Kompr("Abac_Spinn_5.5", 10, 700, 6, 930, 615, 1045));
            list.Add(new Kompr("Abac_Spinn_7.5", 10, 1200, 8, 1180, 615, 1640));
            list.Add(new Kompr("Abac_Spinn_11", 10, 1650, 11, 1180, 615, 1640));
            list.Add(new Kompr("Alup_SCK_6", 10, 620, 4, 965, 662, 1045));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //Main.Content = new Page1();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            //Main.Content = new Page1();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Main.NavigationService.Navigate(new Page1(users, list));
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Main.NavigationService.Navigate(new Page4(list));
        }

        /*private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Main.NavigationService.Navigate(new Page8(list));
        }*/
    }
}
