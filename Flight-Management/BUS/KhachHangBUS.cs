using Flight_Management.DAO;
using Flight_Management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management.BUS
{
    public class KhachHangBUS
    {
        public static DataTable Login(string username, string password)
        {
            return khachhangDAO.Login(username, password);
        }

        public static bool checkExistEmail(string email)
        {
            return khachhangDAO.checkExistEmail(email);
        }

        public static bool register(KhachHang KH)
        {
            return khachhangDAO.register(KH);
        }

        public static string getpass(string email)
        {
            return khachhangDAO.getpass(email);
        }
    }
}
