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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        List<Kompr> list;

        public Window1(List<Kompr> list)
        {
            InitializeComponent();
            this.list = list;
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
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
            textBox.Text = "";
            textBox.Text += "Модель\tДавление, бар\tпроизводительность, л/мин\tМощность, кВт\tРазмер, мм х мм х мм\n";
            if (comboBox.SelectedItem.ToString() != "Все компрессоры")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (comboBox.SelectedItem.ToString() == list[i].Model)
                        textBox.Text += list[i].Model + "\t\t" + list[i].Pressure.ToString() + "\t\t" + list[i].Capacity.ToString() + "\t\t\t" + list[i].Power.ToString() + "\t\t\t" + list[i].Length.ToString() + "x" + list[i].Width.ToString() + "x" + list[i].Height.ToString() + "\n";
                }
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    textBox.Text += list[i].Model + "\t\t" + list[i].Pressure.ToString() + "\t\t" + list[i].Capacity.ToString() + "\t\t" + list[i].Power.ToString() + "\t\t" + list[i].Length.ToString() + "x" + list[i].Width.ToString() + "x" + list[i].Height.ToString() + "\n";
                }
            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
