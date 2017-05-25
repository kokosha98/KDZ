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
    /// Interaction logic for Page10.xaml
    /// </summary>
    public partial class Page10 : Page
    {
        List<Logins> users;

        public Page10(List<Logins> users)
        {
            InitializeComponent();
            this.users = users;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (passwordBox.Password == passwordBox1.Password)
                {
                    users.Add(new Logins(textBox.Text, passwordBox.Password));
                    MessageBox.Show("Вы зарегистрированы");
                }
                else
                    MessageBox.Show("Неправильно повторён пароль!");
            }
            catch (Exception)
            {
                MessageBox.Show("Данные введены некорректно!");
            }
            
        }
    }
}
