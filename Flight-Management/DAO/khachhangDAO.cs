using Flight_Management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management.DAO
{
    public class khachhangDAO
    {
        public static DataTable Login(string username, string password)
        {
            try
            {

                string sql = "select * from khach_hang where username='" + username + "' and password = '" + password + "'";

                DataTable accKhachHang = dbAcess.GetData(sql);

                return accKhachHang;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public static bool checkExistEmail(string email)
        {
            try
            {
                string sql = "select * from khach_hang where email = '" + email + "'";

                DataTable dtemail = dbAcess.GetData(sql);

                if (dtemail.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public static bool register(KhachHang KH)
        {
            try
            {
                string sql = "select * from khach_hang where username = '" + KH.username + "'";

                DataTable dtusername = dbAcess.GetData(sql);

                if (dtusername.Rows.Count > 0)
                {
                    return false;
                }
                else
                {
                    string sql_insert = string.Format("insert into khach_hang(ma_kh, cmnd, sdt, username, password, ho_ten, email) values({0},'{1}','{2}','{3}','{4}','{5}','{6}')", KH.ma_kh, KH.cmnd, KH.sdt, KH.username, KH.password, KH.ho_ten, KH.email);
                    dbAcess.ExecuteSQL(sql_insert);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public static string getpass(string email)
        {
            string password = "";

            try
            {
                string sql = "select password from khach_hang where email = '" + email + "'";

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
                string sql = "update khach_hang set password = '" + newPassword + "' where username = '" + username + "'";
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
                string sql = "select * from khach_hang where username = '" + username + "'";
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
