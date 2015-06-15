using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using coffeeshop.DataAccess;

namespace coffeeshop.DataBL
{
    public class LoginBL
    {
        public bool login(string copycode)
        {
            return LoginDataAccess.login(copycode);
        }

        public bool logout()
        {
            return LoginDataAccess.logout();
        }


    }
}
