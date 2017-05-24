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
    /// Interaction logic for Page6.xaml
    /// </summary>
    public partial class Page6 : Page
    {
        List<Kompr> list;

        public Page6(List<Kompr> list)
        {
            InitializeComponent();
            this.list = list;
        }

        private void Page_Load(object sender, RoutedEventArgs e)
        {
            comboBox.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                comboBox.Items.Add(list[i].Model);
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Model == comboBox.SelectedItem.ToString())
                    {
                        list[i].Model = textBox1.Text;
                        list[i].Pressure = double.Parse(textBox2.Text);
                        list[i].Capacity = double.Parse(textBox3.Text);
                        list[i].Power = double.Parse(textBox4.Text);
                        list[i].Length = double.Parse(textBox5.Text);
                        list[i].Width = double.Parse(textBox6.Text);
                        list[i].Height = double.Parse(textBox7.Text);
                    }
                }
                MessageBox.Show("Изменения сохранены!");
            }
            catch (Exception)
            {

                MessageBox.Show("Данные введены некорректно!");
            }


        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Model == comboBox.SelectedItem.ToString())
                {
                    textBox1.Text = list[i].Model;
                    textBox2.Text = list[i].Pressure.ToString();
                    textBox3.Text = list[i].Capacity.ToString();
                    textBox4.Text = list[i].Power.ToString();
                    textBox5.Text = list[i].Length.ToString();
                    textBox6.Text = list[i].Width.ToString();
                    textBox7.Text = list[i].Height.ToString();
                }
            }
        }
    }
}
