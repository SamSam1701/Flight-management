using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flight_Management.DAO;
using Flight_Management.DTO;

namespace Flight_Management.BUS
{
    public class ChuyenBayBUS
    {
        ChuyenBayDAO chuyenBayDAO = new ChuyenBayDAO();
        public int validateInput(ChuyenBay chuyenbay)
        {
            //validate input here

            //pass
            return 0;
        }

        public bool addFlight(ChuyenBay chuyenbay)
        {
            return chuyenBayDAO.addFlight(chuyenbay);
        }

        public List<ChuyenBayInfo> getListFlight(int? ma_cb = null, string ngay_gio = null, int? ma_sb_di = null, int? ma_sb_den = null)
        {
            List<ChuyenBayInfo> list = chuyenBayDAO.getListFlight(ma_cb, ngay_gio, ma_sb_di, ma_sb_den);
            return list;
        }
    }
}
