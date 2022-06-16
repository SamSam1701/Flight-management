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


            string sql = "select * from nhan_vien where username='" + username + "' and password = '"+password+"'";

            DataTable accNhanVien = dbAcess.GetData(sql);

            return accNhanVien;
        }

        public static DataTable Getdata()
        {
            string sql = "select * from nhan_vien";
            return dbAcess.GetData(sql);
        }

        public static string getpass(string email)
        {
            string password = "";

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


        //public static int AddData(nhanvien nv)
        //{
        //    try
        //    {
        //        string sql = string.Format("insert into nhan_vien(ma_nv, username, password, ho_ten, email) values({0}, '{1}','{2}','{3}','{4}')", nv.ma_nv, nv.username, nv.password, nv.ho_ten, nv.email);

        //        return dbAcess.ExecuteSQL(sql);
        //    }
        //    catch (Exception ex)
        //    {
        //        //throw ex;
        //        Console.WriteLine(ex.ToString());
        //        return 0;
        //    }
        //}

        //public static int updateData(nhanvien nv)
        //{

        //    try
        //    {
        //        string sql = string.Format("update nhan_vien Set username = '{0}', password = '{1}',hoten = '{2}', email = '{3}' where ma_nv = {4}", nv.username, nv.password, nv.ho_ten, nv.email, nv.ma_nv);

        //        return dbAcess.ExecuteSQL(sql);
        //    }
        //    catch (Exception ex)
        //    {
        //        //throw ex;
        //        Console.WriteLine(ex.ToString());
        //        return 0;
        //    }
        //}

        //public static int delete(int manv)
        //{

        //    int id = 5;

        //    try
        //    {
        //        string sql = string.Format("Delete from nhan_vien where ma_nv = {0}", id);

        //        return dbAcess.ExecuteSQL(sql);
        //    }
        //    catch (Exception ex)
        //    {
        //        //throw ex;
        //        Console.WriteLine(ex.ToString());
        //        return 0;
        //    }
        //}
    }
}
