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
        Logins user;
        List<Kompr> list;

        public Window8()
        {
            InitializeComponent();
            user = new Logins("hseguest", "hsepassword");
            list = new List<Kompr>();
            Main.NavigationService.Navigate(new Page1(user, list));
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Main.Content = new Page1();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //Main.Content = new Page1();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            //Main.Content = new Page1();
        }
    }
}
