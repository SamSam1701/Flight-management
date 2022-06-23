using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flight_Management.DAO;
using Flight_Management.DTO;

namespace Flight_Management.BUS
{
    public class BaoCaoBUS
    {
        BaoCaoDAO baoCaoDAO = new BaoCaoDAO();
        public List<BaoCaoTheoThang> getListReportByYear(int year)
        {
            List<BaoCaoTheoThang> list = baoCaoDAO.getListReportByYear(year);

            return list;
        }

        public List<BaoCaoTheoChuyen> getListReportByMonth(int month, int year)
        {
            List<BaoCaoTheoChuyen> list = baoCaoDAO.getListReportByMonth(month, year);

            return list;
        }
    }
}
