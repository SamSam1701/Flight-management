using Flight_Management.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management.BUS
{
    class checkLogin
    {
        public static int checkUserLogin (string username, string password)
        {
            return dbAcess.CheckUserLogin(username, password);
        }
    }
}
