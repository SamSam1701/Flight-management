using Flight_Management.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management.BUS
{
    public class AdminBUS
    {
        public static DataTable Login(string username, string password)
        {
            return AdminDAO.Login(username, password);
        }

        public static string getpass(string email)
        {
            return AdminDAO.getpass(email);
        }
    }
}
