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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        List<Logins> users;
        List<Kompr> list;

        public Page1(List<Logins> users, List<Kompr> list)
        {
            InitializeComponent();
            this.users = users;
            this.list = list;
        }

        public Page1(List<Kompr> list)
        {
            InitializeComponent();
            this.list = list;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            bool flag = false;
            try
            {
                for (int i = 0; i < users.Count; i++)
                {
                    if (textBox.Text == users[i].Login && passwordBox.Password == users[i].Password)
                    {
                        Is_Logged.logged = true;
                        //this.Hide();
                        /*Window4 window4 = new Window4(list);
                        window4.ShowDialog();*/
                        //Main.
                        flag = true;
                        NavigationService.Navigate(new Page4(list));
                        
                        //NavigationService.Navigate(new Uri("/Page2.xaml", UriKind.Relative));
                    }
                    
                }
                if (!flag)
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
            //this.Hide();
            NavigationService.Navigate(new Page4(list));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page10(users));
        }
    }
}
