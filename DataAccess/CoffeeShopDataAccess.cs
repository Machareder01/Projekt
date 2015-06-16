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
        private static CoffeeShopDataAccess instance = new CoffeeShopDataAccess();

        public static CoffeeShopDataAccess Instance
        {
            get
            {
                return instance;
            }
        }

        public static string ConnectionString = "Server=localhost;Uid=Tobias;Password=Test;database=coffeeshop;";
        
        public static MySqlConnection MyConnection = new MySqlConnection(CoffeeShopDataAccess.ConnectionString);


    }
}
