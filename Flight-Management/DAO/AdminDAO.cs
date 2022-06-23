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
            try
            {
                string sql = "select * from admin where username='" + username + "' and password = '" + password + "'";

                DataTable accAdmin = dbAcess.GetData(sql);

                return accAdmin;
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
                string sql = "update admin set password = '" + newPassword + "' where username = '" + username + "'";
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
                string sql = "select * from admin where username = '" + username + "'";
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

        public static void changeRule(string nameRule, int ma)
        {
            try
            {
                string sql = string.Format("update quy_dinh set ten_quy_dinh ='" + nameRule + "' where ma_qd = {0}", ma);
                dbAcess.ExecuteSQL(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static DataTable showRule()
        {
            try
            {
                string sql = "select * from quy_dinh";
                DataTable dt = dbAcess.GetData(sql);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public static DataTable showKhachHangInfo()
        {
            try
            {
                string sql = "select * from khach_hang";
                DataTable data = dbAcess.GetData(sql);
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public static DataTable showNhanVienInfo()
        {
            try
            {
                string sql = "select * from nhan_vien";
                DataTable data = dbAcess.GetData(sql);
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }


        public static void addNhanVien(string username, string password)
        {
            try
            {
                string sql = string.Format("insert into nhan_vien(username,password) values('{0}','{1}')", username, password);
                dbAcess.ExecuteSQL(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static void deleteNhanVien(int ma)
        {
            try
            {
                string sql = string.Format("Delete from nhan_vien where ma_nv = {0}", ma);
                dbAcess.ExecuteSQL(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static void deleteKhachHang(int ma)
        {
            try
            {
                string sql = string.Format("Delete from khach_hang where ma_kh = {0}", ma);
                dbAcess.ExecuteSQL(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
