using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flight_Management.DAO;
using Flight_Management.DTO;

namespace Flight_Management.BUS
{
    public class VeChuyenBayBUS
    {
        VeChuyenBayDAO veChuyenBayDAO = new VeChuyenBayDAO();
        public List<ChiTietHoaDon> getDetailBill(int idBill)
        {
            List<ChiTietHoaDon> list = veChuyenBayDAO.getDetailBill(idBill);
            return list;
        }
    }
}
