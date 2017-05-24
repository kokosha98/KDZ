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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Logins user;
        List<Kompr> list;

        public MainWindow()
        {
            InitializeComponent();
            user = new Logins("hseguest", "hsepassword");
            list = new List<Kompr>();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (textBox.Text == user.Login && passwordBox.Password == user.Password)
                {
                    Is_Logged.logged = true;
                    this.Hide();
                    Window4 window4 = new Window4(list);
                    window4.ShowDialog();
                }
                else
                    MessageBox.Show("Неправильно введён логин или пароль!");
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильно введён логин или пароль!");
            }
            
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Is_Logged.logged = false;
            this.Hide();
            Window4 window4 = new Window4(list);
            window4.ShowDialog();
        }
    }
}

/*<Menu x:Name="menu" HorizontalAlignment="Left" Height="22
              " VerticalAlignment="Top" Width="517">
            <MenuItem Header="О компании" Height="22" Width="86"/>
            <MenuItem Header="Каталог" Height="22" Width="60" Click="MenuItem_Click">
                <MenuItem Header="Компрессорное оборудование" Click="MenuItem_Click_1"></MenuItem>
                <MenuItem Header="Расходные материалы, запчасти"></MenuItem>
            </MenuItem>
            <MenuItem Header="Сервис" Height="22" Width="58"/>
            <MenuItem Header="Контакты" Height="22" Width="65"/>

        </Menu>
для менюхи */