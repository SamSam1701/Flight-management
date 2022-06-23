using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flight_Management.DTO;

namespace Flight_Management.DAO
{
    public class HoaDonDAO
    {
        public List<HoaDon> getListBill()
        {
            List<HoaDon> listBill = new List<HoaDon>();
            try
            {
                string query = "select * from hoa_don join khach_hang on hoa_don.ma_kh = khach_hang.ma_kh;";

                DataTable data = dbAcess.GetData(query);

                foreach(DataRow item in data.Rows)
                {
                    HoaDon bill = new HoaDon();
                    bill.ma_hd = Int32.Parse(item["ma_hd"].ToString());
                    bill.tong_tien = Convert.ToDecimal(item["tong_tien"].ToString());
                    bill.trang_thai_thanh_toan = Int32.Parse(item["trang_thai_thanh_toan"].ToString());
                    bill.ma_kh = Int32.Parse(item["ma_kh"].ToString());
                    bill.ho_ten = item["ho_ten"].ToString();
                    bill.username = item["username"].ToString();

                    listBill.Add(bill);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return listBill;
        }

        public List<HoaDon> getListBill(int trang_thai_thanh_toan)
        {
            List<HoaDon> listBill = new List<HoaDon>();
            try
            {
                string query = "select * from hoa_don join khach_hang on hoa_don.ma_kh = khach_hang.ma_kh "
                + "where hoa_don.trang_thai_thanh_toan = " + trang_thai_thanh_toan + ";";

                DataTable data = dbAcess.GetData(query);

                foreach (DataRow item in data.Rows)
                {
                    HoaDon bill = new HoaDon();
                    bill.ma_hd = Int32.Parse(item["ma_hd"].ToString());
                    bill.tong_tien = Convert.ToDecimal(item["tong_tien"].ToString());
                    bill.trang_thai_thanh_toan = Int32.Parse(item["trang_thai_thanh_toan"].ToString());
                    bill.ma_kh = Int32.Parse(item["ma_kh"].ToString());
                    bill.ho_ten = item["ho_ten"].ToString();
                    bill.username = item["username"].ToString();

                    listBill.Add(bill);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return listBill;
        }

        public bool setPaid(int idBill)
        {
            try
            {
                string query = 
                    "update hoa_don " +
                    "set hoa_don.trang_thai_thanh_toan = 1 " +
                    "where hoa_don.ma_hd = " + idBill + ";";
                dbAcess.GetData(query);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}
