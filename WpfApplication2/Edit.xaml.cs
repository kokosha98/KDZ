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
    /// Interaction logic for Page11.xaml
    /// </summary>
    public partial class Page11 : Page
    {
        List<Kompr> list;

        public Page11(List<Kompr> list)
        {
            InitializeComponent();
            this.list = list;
        }

        private void Page_Load(object sender, RoutedEventArgs e)
        {
            comboBox1.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                comboBox1.Items.Add(list[i].Model);
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Model == comboBox1.SelectedItem.ToString())
                    {
                        list[i].Model = textBox8.Text;
                        list[i].Pressure = uint.Parse(textBox9.Text);
                        list[i].Capacity = uint.Parse(textBox10.Text);
                        list[i].Power = uint.Parse(textBox11.Text);
                        list[i].Length = uint.Parse(textBox12.Text);
                        list[i].Width = uint.Parse(textBox13.Text);
                        list[i].Height = uint.Parse(textBox14.Text);
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
                if (list[i].Model == comboBox1.SelectedItem.ToString())
                {
                    textBox8.Text = list[i].Model;
                    textBox9.Text = list[i].Pressure.ToString();
                    textBox10.Text = list[i].Capacity.ToString();
                    textBox11.Text = list[i].Power.ToString();
                    textBox12.Text = list[i].Length.ToString();
                    textBox13.Text = list[i].Width.ToString();
                    textBox14.Text = list[i].Height.ToString();
                }
            }
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
