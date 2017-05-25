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
    /// Interaction logic for Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        public Page5()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            string[] file = File.ReadAllLines(@"Example.txt");
            for (int i = 0; i < file.Length; i++)
            {
                textBox.Text += file[i] + "\n";
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText(@"Example.txt", textBox.Text);
            MessageBox.Show("Сохранено");
        }
    }
}
