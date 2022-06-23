using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management.DTO
{
    public class ChiTietHoaDon
    {
        public int ma_vcb { get; set; }
        public string ho_ten { get; set; }
        public int loai_hang { get; set; }
        public string san_bay_di { get; set; }
        public string san_bay_den { get; set; }
        public decimal gia_ve { get; set; }
    }
}
