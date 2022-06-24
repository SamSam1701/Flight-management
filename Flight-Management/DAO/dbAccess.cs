using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Flight_Management.DAO
{
    public class dbAcess
    {

        public static MySqlConnection ConnectionDB()
        {
            string strcon = "Server = localhost; Database = ql_ban_ve_may_bay; Port=3306; User ID= root; Password =123456 ";
            MySqlConnection Conn = new MySqlConnection(strcon);
            //Conn.Open();
            return Conn;
        }

        public static DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = dbAcess.ConnectionDB())
            {

                conn.Open();

                MySqlDataAdapter adap = new MySqlDataAdapter(sql, conn);

                adap.Fill(dt);

                conn.Close();
            }

            return dt;
        }
        public static long insertData(string sql)
        {
            long id;
            using (MySqlConnection conn = dbAcess.ConnectionDB())
            {

                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.ExecuteNonQuery();

                id = cmd.LastInsertedId;

                conn.Close();
            }

            return id;
        }

        public static int ExecuteSQL(string sql)
        {
            MySqlConnection conn = dbAcess.ConnectionDB();

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();

            var res = cmd.ExecuteNonQuery();

            conn.Close();
            return res;
        }

        public static int CheckUserLogin(string username, string password)
        {
            if (khachhangDAO.Login(username, password).Rows.Count > 0)
            {
                return 1;
            }
            else if (AdminDAO.Login(username, password).Rows.Count > 0)
            {
                return 0;
            }
            else if (NhanvienDAO.Login(username, password).Rows.Count > 0)
            {
                return 2;
            }
            else
            {
                return -1;
            }
        }
    }
}
