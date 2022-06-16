using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management.DAO
{
    public class AdminDAO
    {
        public static DataTable Login(string username, string password)
        {
            //dbAcess.ConnectionDB();

            string sql = "select * from admin where username='" + username + "' and password = '" + password + "'";

            DataTable accAdmin = dbAcess.GetData(sql);

            return accAdmin;
        }

        public static string getpass(string email)
        {
            string password = "";

            string sql = "select password from admin where email = '" + email + "'";

            DataTable dt = dbAcess.GetData(sql);

            if (dt.Rows.Count > 0)
            {

                DataRow rowpass = dt.Rows[0];

                password = Convert.ToString(rowpass["password"]);
            }
            else
            {
                password = "";
            }
            return password;
        }

    }
}
