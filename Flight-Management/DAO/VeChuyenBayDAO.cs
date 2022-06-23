using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flight_Management.DTO;

namespace Flight_Management.DAO
{
    public class VeChuyenBayDAO
    {
        public List<ChiTietHoaDon> getDetailBill(int idBill) {
            List<ChiTietHoaDon> list = new List<ChiTietHoaDon>();

            try
            {
                string query = "select ve_chuyen_bay.*, loai_ve.*, hanh_khach.*, san_bay_di.ten_san_bay as san_bay_di, san_bay_den.ten_san_bay as san_bay_den " +
                    "from ve_chuyen_bay left join hanh_khach on ve_chuyen_bay.ma_hanh_khach = hanh_khach.ma_hanh_khach " +
                    "left join loai_ve on ve_chuyen_bay.ma_loai_ve = loai_ve.ma_loai_ve " +
                    "join san_bay as san_bay_di on loai_ve.ma_sb_den = san_bay_di.ma_sb " +
                    "join san_bay as san_bay_den on loai_ve.ma_sb_di = san_bay_den.ma_sb " +
                    "where ve_chuyen_bay.ma_hd = " + idBill + ";";

                DataTable data = dbAcess.GetData(query);

                foreach(DataRow item in data.Rows)
                {
                    ChiTietHoaDon detail = new ChiTietHoaDon();
                    detail.ma_vcb = Int32.Parse(item["ma_vcb"].ToString());
                    detail.gia_ve = Convert.ToDecimal(item["gia_ve"].ToString());
                    detail.ho_ten = item["ho_ten"].ToString();
                    detail.loai_hang = Int32.Parse(item["loai_hang"].ToString());
                    detail.san_bay_den = item["san_bay_den"].ToString();
                    detail.san_bay_di = item["san_bay_den"].ToString();

                    list.Add(detail);
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
