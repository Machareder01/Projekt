using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffeeshop.DataAccess
{
    public class LoginDataAccess
    {
        private static LoginDataAccess instance = new LoginDataAccess();

        public static LoginDataAccess Instance
        {
            get
            {
                return instance;
            }
        }

        public static bool login(string copycode)
        {
            try
            {
                CoffeeShopDataAccess.MyConnection.Open();
                CoffeeShopDataAccess.MyConnection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public static bool logout()
        {
            try
            {
                CoffeeShopDataAccess.MyConnection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

    }
}
