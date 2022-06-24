using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flight_Management.DTO;

namespace Flight_Management.DAO
{
    public class BaoCaoDAO
    {
        public List<BaoCaoTheoChuyen> getListReportByMonth(int month, int year)
        {

            List<BaoCaoTheoChuyen> list = new List<BaoCaoTheoChuyen>();
            try
            {
                string query =
                   "select " +
                   "chuyen_bay.ma_cb, " +
                   "san_bay_di.ten_san_bay as san_bay_di, " +
                   "san_bay_den.ten_san_bay as san_bay_den, " +
                   "chuyen_bay.ngay_gio, " +
                   "count(ve_chuyen_bay.ma_vcb) as so_ve_ban, " +
                   "chuyen_bay.so_ghe_hang_1 + so_ghe_hang_2 as so_ve, " +
                   "coalesce(sum(ve_chuyen_bay.gia_ve), 0) as doanh_thu " +
                   "from chuyen_bay left join ve_chuyen_bay on chuyen_bay.ma_cb = ve_chuyen_bay.ma_cb " +
                   "left join hoa_don on ve_chuyen_bay.ma_hd = hoa_don.ma_hd " +
                   "join san_bay as san_bay_di on chuyen_bay.ma_sb_di = san_bay_di.ma_sb " +
                   "join san_bay as san_bay_den on chuyen_bay.ma_sb_den = san_bay_den.ma_sb " +
                   "where month(chuyen_bay.ngay_gio) = " + month + " and year(chuyen_bay.ngay_gio) = " + year + " " +
                   "and hoa_don.trang_thai_thanh_toan = 1 " +
                   "group by chuyen_bay.ma_cb;";

                DataTable data = dbAcess.GetData(query);

                foreach (DataRow item in data.Rows)
                {
                    BaoCaoTheoChuyen InfoByFlight = new BaoCaoTheoChuyen();
                    InfoByFlight.ma_cb = Int32.Parse(item["ma_cb"].ToString());
                    InfoByFlight.san_bay_di = item["san_bay_di"].ToString();
                    InfoByFlight.san_bay_den = item["san_bay_den"].ToString();
                    InfoByFlight.ngay_gio = item["ngay_gio"].ToString();
                    InfoByFlight.so_ve_ban = Int32.Parse(item["so_ve_ban"].ToString());
                    InfoByFlight.ti_le =
                        Math.Round(Double.Parse(item["so_ve_ban"].ToString()) / Int32.Parse(item["so_ve"].ToString()), 3);
                    InfoByFlight.doanh_thu = Convert.ToDecimal(item["doanh_thu"].ToString());
                    list.Add(InfoByFlight);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return list;
        }
        public List<BaoCaoTheoThang> getListReportByYear(int year)
        {

            List<BaoCaoTheoThang> list = new List<BaoCaoTheoThang>();
            try
            {
                string query =
                    "select " +
                    "month(chuyen_bay.ngay_gio) as thang, " +
                    "count(distinct chuyen_bay.ma_cb) as so_chuyen_bay, " +
                    "sum(ve_chuyen_bay.gia_ve) as doanh_thu, " +
                    "sum(chuyen_bay.so_ghe_hang_1) + sum(chuyen_bay.so_ghe_hang_2) as so_ve, " +
                    "count(ve_chuyen_bay.ma_vcb) as so_ve_ban " +
                    "from chuyen_bay join ve_chuyen_bay on chuyen_bay.ma_cb = ve_chuyen_bay.ma_cb " +
                    "left join hoa_don on ve_chuyen_bay.ma_hd = hoa_don.ma_hd " + 
                    "where year(chuyen_bay.ngay_gio) = " + year + " and hoa_don.trang_thai_thanh_toan = 1 " +
                    "group by month(chuyen_bay.ngay_gio);";

                DataTable data = dbAcess.GetData(query);

                foreach (DataRow item in data.Rows)
                {
                    BaoCaoTheoThang InfoByMonth = new BaoCaoTheoThang();
                    InfoByMonth.thang = Int32.Parse(item["thang"].ToString());
                    InfoByMonth.so_chuyen_bay = Int32.Parse(item["so_chuyen_bay"].ToString());
                    InfoByMonth.doanh_thu = Convert.ToDecimal(item["doanh_thu"].ToString());
                    InfoByMonth.ti_le_ban_ve =
                        Math.Round(Double.Parse(item["so_ve_ban"].ToString()) / Int32.Parse(item["so_ve"].ToString()), 3);

                    list.Add(InfoByMonth);

                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            return list;
        }
    }
}
