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
    /// Interaction logic for Page7.xaml
    /// </summary>
    public partial class Page7 : Page
    {
        List<Kompr> list;

        public Page7(List<Kompr> list)
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
            comboBox.Items.Add("Все компрессоры");
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Model == comboBox.SelectedItem.ToString())
                    list.RemoveAt(i);
            }
            MessageBox.Show("Удалено");
        }
    }
}
