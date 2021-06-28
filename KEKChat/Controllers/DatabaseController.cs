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
            
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Andrei\Desktop\LoginDatabase.mdf;Integrated Security=True;Connect Timeout=30");

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

        public static void InputInformation(string username, string password)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Andrei\Desktop\LoginDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand($" INSERT INTO [Table] (USERNAME, PASSWORD)" +
                                            $" VALUES ('{username}', '{password}');", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
