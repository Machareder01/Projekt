using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

        public static string login(string copycode)
        {
            string user = string.Empty;

            try
            {
                CoffeeShopDataAccess.MyConnection.Open();
                MySqlCommand command = CoffeeShopDataAccess.MyConnection.CreateCommand();
                command.CommandText = "SELECT * FROM customer";

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["Copycode"].ToString().Equals(copycode))
                    {
                        user = reader["Name"].ToString();
                    }
                }

                CoffeeShopDataAccess.MyConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return user;
        }

        public static bool logout()
        {
            try
            {
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
