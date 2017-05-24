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
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        List<Kompr> list;

        public Window4(List<Kompr> list)
        {
            InitializeComponent();
            this.list = list;
        }


        private void button_Click_2(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1(list);
            window1.ShowDialog();

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (Is_Logged.logged)
            {
                Window2 window2 = new Window2(list);
                window2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Доступно только для зарегистрированных пользователей!");
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow newMainWindow = new MainWindow();
            newMainWindow.Show();
        }
    }
    
}
