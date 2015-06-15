using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace coffeeshop.DataAccess
{
    public class CoffeeShopDataAccess
    {
     
        private static string connectionString = "Database=coffeeshop;Data Source=localhost;User Id=root;Password=";

        private static CoffeeShopDataAccess instance = new CoffeeShopDataAccess();

        public static CoffeeShopDataAccess Instance
        {
            get
            {
                return instance;
            }
        }


        private static SqlConnection myConnection = new SqlConnection(connectionString);

        public static SqlConnection MyConnection
        {
            get
            {
                return myConnection;
            }
        }

    }
}
