using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using coffeeshop.DataAccess;
using MySql.Data.MySqlClient;

namespace coffeeshop.DataBL
{
    public class LoginBL
    {
        public DTO login(string copycode)
        {
            DTO dto = null;
            MySqlDataReader reader = LoginDataAccess.login(copycode);

            if(reader != null)
            {
                while (reader.Read())
                {
                    User user = new User();
                    user.Username = reader["Name"].ToString();
                    user.Id = Convert.ToInt32(reader["ID"].ToString());

                    dto = new DTO();
                    dto.User = user;
                }
            }

            return dto;
        }
    }
}
