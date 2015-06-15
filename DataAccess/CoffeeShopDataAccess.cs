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
        private static CoffeeShopDataAccess instance = new CoffeeShopDataAccess();

        public static CoffeeShopDataAccess Instance
        {
            get
            {
                return instance;
            }
        }

        private static SqlConnection myConnection;

        public static SqlConnection MyConnection
        {
            get
            {
               return myConnection;
            }
        }


    }
}
