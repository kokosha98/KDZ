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
        Logins user;
        List<Kompr> list;

        public Page1(Logins user, List<Kompr> list)
        {
            InitializeComponent();
            this.user = user;
            this.list = list;
        }

        public Page1(List<Kompr> list)
        {
            InitializeComponent();
            this.list = list;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                if (textBox.Text == user.Login && passwordBox.Password == user.Password)
                {
                    Is_Logged.logged = true;
                    //this.Hide();
                    /*Window4 window4 = new Window4(list);
                    window4.ShowDialog();*/
                    //Main.
                    NavigationService.Navigate(new Page4(list));
                    //NavigationService.Navigate(new Uri("/Page2.xaml", UriKind.Relative));
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
            //this.Hide();
            NavigationService.Navigate(new Page4(list));
        }


    }
}
