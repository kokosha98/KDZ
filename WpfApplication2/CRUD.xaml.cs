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
using System.IO;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for Page8.xaml
    /// </summary>
    public partial class Page8 : Page
    {
        List<Kompr> list;

        public Page8(List<Kompr> list)
        {
            InitializeComponent();
            this.list = list;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page3(list));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string[] file = File.ReadAllLines(@"Example.txt");
                string[] result;
                for (int i = 0; i < file.Length; i++)
                {
                    result = file[i].Split(' ');
                    list.Add(new Kompr(result[0], uint.Parse(result[1]), uint.Parse(result[2]), uint.Parse(result[3]), uint.Parse(result[4]), uint.Parse(result[5]), uint.Parse(result[6])));
                }
                MessageBox.Show("Добавлено");
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректные данные в файле!");
            }

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page5());
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page11(list));
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page7(list));
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page9(list));
        }
    }
}
