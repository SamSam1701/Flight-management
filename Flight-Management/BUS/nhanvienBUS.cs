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
    public class nhanvienBUS
    {

        public static DataTable Login(string username, string password)
        {
            return NhanvienDAO.Login(username, password);
        }

        public static DataTable Getdata()
        {
            return NhanvienDAO.Getdata();
        }

        public static string getpass(string email)
        {
            return NhanvienDAO.getpass(email);
        }

        public static void changepass(string newPassword, string username)
        {
            NhanvienDAO.changepass(newPassword, username);
        }

        public static DataTable showInfo(string username)
        {
            return NhanvienDAO.showinfo(username);
        }

        //public static int AddData(nhanvien nv)
        //{
        //    return NhanvienDAO.AddData(nv);
        //}

        //public static int updateData(nhanvien nv)
        //{
        //    return NhanvienDAO.updateData(nv);
        //}

        //public static int delete(int manv)
        //{
        //    return NhanvienDAO.delete(manv);
        //}
    }
}
