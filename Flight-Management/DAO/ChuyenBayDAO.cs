using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flight_Management.DTO;

namespace Flight_Management.DAO
{
    public class ChuyenBayDAO
    {
        public bool addFlight(ChuyenBay chuyenbay)
        {
            try
            {
                string query =
                    "insert into chuyen_bay(ngay_gio, thoi_gian_bay, so_ghe_hang_1, so_ghe_hang_2, ma_sb_di, ma_sb_den) value "
                    + "('" + chuyenbay.ngay_gio + "', " + chuyenbay.thoi_gian_bay + ", " + chuyenbay.so_ghe_hang_1
                    + ", " + chuyenbay.so_ghe_hang_2 + ", " + chuyenbay.ma_sb_di + ", " + chuyenbay.ma_sb_den + ");";

                dbAcess.insertData(query);

                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public List<ChuyenBayInfo> getListFlight(int? ma_cb = null, string ngay_gio = null, int? ma_sb_di = null, int? ma_sb_den = null)
        {
            List<ChuyenBayInfo> list = new List<ChuyenBayInfo>();
            try
            {
                string filterByma_cb = ma_cb == null ? "" : "chuyen_bay.ma_cb = " + ma_cb + " and ";
                string filterByngay_gio = ngay_gio == null ? "" : "date(chuyen_bay.ngay_gio) = '" + ngay_gio + "' and ";
                string filterByma_sb_di = ma_sb_di == null ? "" : "chuyen_bay.ma_sb_di = " + ma_sb_di + " and ";
                string filterByma_sb_den = ma_sb_den == null ? "" : "chuyen_bay.ma_sb_den = " + ma_sb_den + " and ";
                
                string filter = "";
                if (ma_cb != null || ngay_gio != null|| ma_sb_di != null || ma_sb_den != null)
                {
                    filter = "where " + filterByma_cb + filterByngay_gio + filterByma_sb_di + filterByma_sb_den;
                    filter = filter.Substring(0, filter.Length - 5);
                }

                string query =
                    "select chuyen_bay.*, san_bay_di.ten_san_bay as san_bay_di, san_bay_den.ten_san_bay as san_bay_den " +
                    "from chuyen_bay " +
                    "join san_bay as san_bay_di on chuyen_bay.ma_sb_di = san_bay_di.ma_sb " +
                    "join san_bay as san_bay_den on chuyen_bay.ma_sb_den = san_bay_den.ma_sb " +
                    filter + ";";

                DataTable data = dbAcess.GetData(query);

                foreach (DataRow item in data.Rows)
                {
                    ChuyenBayInfo flight = new ChuyenBayInfo();
                    flight.ma_cb = Int32.Parse(item["ma_cb"].ToString());
                    flight.ngay_gio = item["ngay_gio"].ToString();
                    flight.thoi_gian_bay = Int32.Parse(item["thoi_gian_bay"].ToString());
                    flight.so_ghe_hang_1 = Int32.Parse(item["so_ghe_hang_1"].ToString());
                    flight.so_ghe_hang_2 = Int32.Parse(item["so_ghe_hang_2"].ToString());
                    flight.san_bay_di = item["san_bay_di"].ToString();
                    flight.san_bay_den = item["san_bay_den"].ToString();

                    list.Add(flight);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return list;
        }
    }
}
