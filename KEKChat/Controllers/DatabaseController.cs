using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace KEKChat.Controllers
{
    public class DatabaseController
    {
        public static bool CheckInformation(string username, string password)
        {
            SqlConnection con = new SqlConnection(@"CONNECTION STRING");

            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From [Table] Where [USERNAME]='" + username + "' and [PASSWORD]='" + password + "'", con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
