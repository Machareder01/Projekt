using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeeshop.DataAccess
{
   public class Connection
   {
       private string connectionString = "SERVER=localhost;DATABASE=coffeeshop;UID=root;PASSWORD=;";

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
