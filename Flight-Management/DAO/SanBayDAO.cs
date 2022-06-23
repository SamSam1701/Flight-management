using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flight_Management.DTO;

namespace Flight_Management.DAO
{
    public class SanBayDAO
    {
        public List<SanBay> getListAirport()
        {
            List<SanBay> listAirport = new List<SanBay>();
            try
            {
                string query = "select * from san_bay;";

                DataTable data = dbAcess.GetData(query);

                foreach(DataRow item in data.Rows)
                {
                    SanBay airport = new SanBay();
                    airport.ma_sb = Int32.Parse(item["ma_sb"].ToString());
                    airport.ten_san_bay = item["ten_san_bay"].ToString();
                    airport.dia_chi = item["dia_chi"].ToString();

                    listAirport.Add(airport);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            return listAirport;
        }
    }
}
