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
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        List<Kompr> list;

        public Page2(List<Kompr> list)
        {
            InitializeComponent();
            this.list = list;
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void Page_Load(object sender, RoutedEventArgs e)
        {
            comboBox.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                comboBox.Items.Add(list[i].Model);
            }
            comboBox.Items.Add("Все компрессоры");
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void button_Click_2(object sender, RoutedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            Kompr[] mas = new Kompr[list.Count];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = list[i];
            }

            
            //textBox.Text = "";
            //textBox.Text += "Модель\tДавление, бар\tпроизводительность, л/мин\tМощность, кВт\tРазмер, мм х мм х мм\n";
            if (comboBox.SelectedItem.ToString() != "Все компрессоры")
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    if (comboBox.SelectedItem.ToString() == mas[i].Model)
                    {
                        Kompr[] mas1 = new Kompr[1];
                        mas1[0] = list[i];
                        dataGrid.ItemsSource = mas1;
                    }
                }
            }
            else
            {
                for (int i = 0; i < mas.Length; i++)
                {
                        dataGrid.ItemsSource = mas;
                }
            }
        }
    }
}
