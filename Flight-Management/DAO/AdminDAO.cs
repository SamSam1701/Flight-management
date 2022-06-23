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

        public static void changepass(string newPassword, string username)
        {
            //update nhan_vien Set username = '{0}', password = '{1}',hoten = '{2}', email = '{3}' where ma_nv = {4}",
            string sql = "update admin set password = '" + newPassword + "' where username = '" + username + "'";
            dbAcess.ExecuteSQL(sql);
        }

        public static DataTable showinfo(string username)
        {
            string sql = "select * from admin where username = '" + username + "'";
            DataTable db = new DataTable();
            db = dbAcess.GetData(sql);
            return db;
        }

        public static void changeRule(string nameRule, int ma)
        {
            //string sql = string.Format("insert into nhan_vien(ma_nv, username, password, ho_ten, email) values({0}, '{1}','{2}','{3}','{4}')", nv.ma_nv, nv.username, nv.password, nv.ho_te
            string sql = string.Format("update quy_dinh set ten_quy_dinh ='" + nameRule + "' where ma_qd = {0}",ma);
            dbAcess.ExecuteSQL(sql);
        }

        public static DataTable showRule()
        {
            string sql = "select * from quy_dinh";
            DataTable dt = dbAcess.GetData(sql);
            return dt;
        }

        public static DataTable showKhachHangInfo()
        {
            string sql = "select * from khach_hang";
            DataTable data = dbAcess.GetData(sql);
            return data;
        }

        public static DataTable showNhanVienInfo()
        {
            string sql = "select * from nhan_vien";
            DataTable data = dbAcess.GetData(sql);
            return data;
        }


        public static void addNhanVien(string username, string password)
        {
            // string sql = string.Format("insert into nhan_vien(ma_nv, username, password, ho_ten, email) values({0}, '{1}','{2}','{3}','{4}')", nv.ma_nv, nv.username, nv.password, nv.ho_ten, nv.email);
            string sql = string.Format("insert into nhan_vien(username,password) values('{0}','{1}')", username, password);
            dbAcess.ExecuteSQL(sql);
        }

        public static void deleteNhanVien(int ma)
        {
            string sql = string.Format("Delete from nhan_vien where ma_nv = {0}", ma);
            dbAcess.ExecuteSQL(sql);
        }

        public static void deleteKhachHang(int ma)
        {
            string sql = string.Format("Delete from khach_hang where ma_kh = {0}", ma);
            dbAcess.ExecuteSQL(sql);
        }
    }
}
