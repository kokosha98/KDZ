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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        List<Kompr> list;

        public Window3(List<Kompr> list)
        {
            InitializeComponent();
            this.list = list;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                list.Add(new Kompr(textBox.Text, double.Parse(textBox1.Text), double.Parse(textBox2.Text), double.Parse(textBox3.Text), double.Parse(textBox5.Text), double.Parse(textBox6.Text), double.Parse(textBox7.Text)));
            }
            catch (Exception)
            {
                MessageBox.Show("Данные введены некорректно!");
            }
            
        }
    }
}
