using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flight_Management.DAO;
using Flight_Management.DTO;

namespace Flight_Management.BUS
{
    public class SanBayBUS
    {
        SanBayDAO sanBayDAO = new SanBayDAO();
        public List<SanBay> getListAirport()
        {
            List<SanBay> listAirport = sanBayDAO.getListAirport();
            return listAirport;
        }
    }
}
