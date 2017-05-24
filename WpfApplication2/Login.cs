using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    public static class Is_Logged
    {
        public static bool logged = false;
    }

    public class Logins
    {
        string login;
        string password;

        public Logins(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
    }


}
