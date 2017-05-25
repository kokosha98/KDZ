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
    /// Interaction logic for Page9.xaml
    /// </summary>
    public partial class Page9 : Page
    {
        List<Kompr> list;

        public Page9(List<Kompr> list)
        {
            InitializeComponent();
            this.list = list;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {                
                textBox1.Text = "";
                textBox1.Text += "Модель\tДавление, бар\tпроизводительность, л/мин\tМощность, кВт\tРазмер, мм х мм х мм\n";
                for (int i = 0; i < list.Count; i++)
                {
                    if (textBox.Text == list[i].Model || textBox.Text == list[i].Capacity.ToString() || textBox.Text == list[i].Height.ToString() || textBox.Text == list[i].Length.ToString() || textBox.Text == list[i].Power.ToString() || textBox.Text == list[i].Pressure.ToString() || textBox.Text == list[i].Width.ToString())
                        textBox1.Text += list[i].Model + "\t\t" + list[i].Pressure.ToString() + "\t\t" + list[i].Capacity.ToString() + "\t\t\t" + list[i].Power.ToString() + "\t\t\t" + list[i].Length.ToString() + "x" + list[i].Width.ToString() + "x" + list[i].Height.ToString() + "\n";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Данные для поиска введены некорректно!");
            }
        }
    }
}
