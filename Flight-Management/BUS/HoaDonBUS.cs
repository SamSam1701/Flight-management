using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flight_Management.DAO;
using Flight_Management.DTO;

namespace Flight_Management.BUS
{
    public class HoaDonBUS
    {
        HoaDonDAO hoaDonDAO = new HoaDonDAO();
        public List<HoaDon> getListBill()
        {
            List<HoaDon> listBill = hoaDonDAO.getListBill();
            return listBill;
        }

        public List<HoaDon> getListBill(int trang_thai_thanh_toan)
        {
            List<HoaDon> listBill = hoaDonDAO.getListBill(trang_thai_thanh_toan);
            return listBill;
        }

        public bool setPaid(int idBill)
        {
            bool resultPaid = hoaDonDAO.setPaid(idBill);
            return resultPaid;
        }
    }
}
