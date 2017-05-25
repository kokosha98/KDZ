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
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        List<Kompr> list;

        public Page3(List<Kompr> list)
        {
            InitializeComponent();
            this.list = list;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                list.Add(new Kompr(textBox.Text, uint.Parse(textBox1.Text), uint.Parse(textBox2.Text), uint.Parse(textBox3.Text), uint.Parse(textBox5.Text), uint.Parse(textBox6.Text), uint.Parse(textBox7.Text)));
                MessageBox.Show("Добавлено");
            }
            catch (Exception)
            {
                MessageBox.Show("Данные введены некорректно!");
            }

        }
    }
}
