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
                Kompr[] mas = new Kompr[list.Count];
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = list[i];
                }

                int k = 0;
                //textBox1.Text = "";
                //textBox1.Text += "Модель\tДавление, бар\tпроизводительность, л/мин\tМощность, кВт\tРазмер, мм х мм х мм\n";
                for (int i = 0; i < mas.Length; i++)
                {
                    if (textBox.Text == mas[i].Model || textBox.Text == mas[i].Capacity.ToString() || textBox.Text == mas[i].Height.ToString() || textBox.Text == mas[i].Length.ToString() || textBox.Text == mas[i].Power.ToString() || textBox.Text == mas[i].Pressure.ToString() || textBox.Text == mas[i].Width.ToString())
                    {
                        k++;
                    }                    
                }
                Kompr[] mas1 = new Kompr[k];
                int l = 0;
                for (int i = 0; i < mas.Length; i++)
                {
                    if (textBox.Text == mas[i].Model || textBox.Text == mas[i].Capacity.ToString() || textBox.Text == mas[i].Height.ToString() || textBox.Text == mas[i].Length.ToString() || textBox.Text == mas[i].Power.ToString() || textBox.Text == mas[i].Pressure.ToString() || textBox.Text == mas[i].Width.ToString())
                    {
                        mas1[l] = list[i];
                        l++;
                    }
                }
                
                dataGrid.ItemsSource = mas1;
            }
            catch (Exception)
            {
                MessageBox.Show("Данные для поиска введены некорректно!");
            }
        }
    }
}
