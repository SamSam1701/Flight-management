using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management.DTO
{
    public class BaoCaoTheoChuyen
    {
        public int ma_cb { get; set; }
        public string san_bay_di { get; set; }
        public string san_bay_den { get; set; }
        public string ngay_gio { get; set; }
        public int so_ve_ban { get; set; }
        public double ti_le { get; set; }
        public decimal doanh_thu { get; set; }
    }
}
