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
using System.IO;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        List<Kompr> list;

        public Window2(List<Kompr> list)
        {
            InitializeComponent();
            this.list = list;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3(list);
            window3.ShowDialog();            
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
                    list.Add(new Kompr(result[0], double.Parse(result[1]), double.Parse(result[2]), double.Parse(result[3]), double.Parse(result[4]), double.Parse(result[5]), double.Parse(result[6])));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректные данные в файле!");
            }
            
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Window5 window5 = new Window5();
            window5.ShowDialog();
        }
    }
}
