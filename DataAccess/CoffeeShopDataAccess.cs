using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace coffeeshop.DataAccess
{
    public class CoffeeShopDataAccess
    {
        public static string ConnectionString = "Server=localhost;Uid=Tobias;Password=Test;database=coffeeshop;";
        
        public static MySqlConnection MyConnection = new MySqlConnection(CoffeeShopDataAccess.ConnectionString);
        
        public static void OrderCoffee(int userID, string userName, int coffeeCount, int totalPrice)
        {
            using (MySqlCommand command = new MySqlCommand("Insert into order (Cust_ID, OrderDate, Quantity, Totalprice)"
                + " Values (" + userID.ToString()
                + ", " + DateTime.Now.ToString()
                + ", " + coffeeCount.ToString()
                + ", " + totalPrice.ToString() + "); ", MyConnection))
            {
                MyConnection.Open();
                command.ExecuteNonQuery();
               
                if (MyConnection.State == System.Data.ConnectionState.Open)
                {
                    MyConnection.Close();
                }                
            }
        }

        public static MySqlDataReader getReceipt()
        {
            MySqlDataReader reader = null;

            try
            {
                CoffeeShopDataAccess.MyConnection.Open();
                MySqlCommand command = CoffeeShopDataAccess.MyConnection.CreateCommand();
                command.CommandText = "SELECT * FROM ....";

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
