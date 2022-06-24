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

        public static void changepass (string newPassword , string username)
        {
            AdminDAO.changepass(newPassword, username);
        }

        public static DataTable showInfo(string username)
        {
            return AdminDAO.showinfo(username);
        }

        public static void changRule(string nameRule, int ma)
        {
            AdminDAO.changeRule(nameRule, ma);
        }

        public static DataTable showRule()
        {
            return AdminDAO.showRule();
        }

        public static DataTable showKhachHangInfo()
        {
            return AdminDAO.showKhachHangInfo();
        }

        public static DataTable showNhanVienInfo()
        {
            return AdminDAO.showNhanVienInfo();
        }

        public static void addNhanVien(string username, string password)
        {
            AdminDAO.addNhanVien(username, password);
        }

        public static void deleteNhanVien(int ma)
        {
            AdminDAO.deleteNhanVien(ma);
        }
        public static void deleteKhachHang(int ma)
        {
            AdminDAO.deleteKhachHang(ma);
        }
    }
}
