using Flight_Management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management.DAO
{
    public class NhanvienDAO
    {

        public static DataTable Login(string username, string password)
        {
            try
            {

                string sql = "select * from nhan_vien where username='" + username + "' and password = '" + password + "'";

                DataTable accNhanVien = dbAcess.GetData(sql);

                return accNhanVien;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public static DataTable Getdata()
        {
            try
            {
                string sql = "select * from nhan_vien";
                return dbAcess.GetData(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public static string getpass(string email)
        {
            string password = "";
            try
            {

                string sql = "select password from nhan_vien where email = '" + email + "'";

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
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return password;
            }
        }

        public static void changepass(string newPassword, string username)
        {
            try
            {
                string sql = "update nhan_vien set password = '" + newPassword + "' where username = '" + username + "'";
                dbAcess.ExecuteSQL(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static DataTable showinfo(string username)
        {
            try
            {
                string sql = "select * from nhan_vien where username = '" + username + "'";
                DataTable db = new DataTable();
                db = dbAcess.GetData(sql);
                return db;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
