using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using coffeeshop.DataBL;

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

        public static MySqlDataReader login(string copycode)
        {
            MySqlDataReader reader = null;

            try
            {
                CoffeeShopDataAccess.MyConnection.Open();
                MySqlCommand command = CoffeeShopDataAccess.MyConnection.CreateCommand();
                command.CommandText = "SELECT * FROM customer";

                reader = command.ExecuteReader();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return reader;
        }
    }
}
