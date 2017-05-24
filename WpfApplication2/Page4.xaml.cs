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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        List<Kompr> list;

        public Page4(List<Kompr> list)
        {
            InitializeComponent();
            this.list = list;
        }


        private void button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page2(list));

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (Is_Logged.logged)
            {
                NavigationService.Navigate(new Page8(list));
            }
            else
            {
                MessageBox.Show("Доступно только для зарегистрированных пользователей!");
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1(list));
        }
    }
}
