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

            MySqlConnection conn = dbAcess.ConnectionDB();

            conn.Open();

            MySqlDataAdapter adap = new MySqlDataAdapter(sql, conn);

            DataTable dt = new DataTable();

            adap.Fill(dt);

            conn.Close();

            return dt;
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

    }
}
