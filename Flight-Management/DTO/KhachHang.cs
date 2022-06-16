using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management.DTO
{
    public class KhachHang
    {
        public int ma_kh { get; set; }
        
        public string cmnd { get; set; }

        public string sdt { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public string ho_ten { get; set; }

        public string email { get; set; }

        public KhachHang(string ho_ten,string username,string password,string cmnd,string sdt,string email)
        {
            this.ho_ten = ho_ten;
            this.username = username;
            this.password = password;
            this.cmnd = cmnd;
            this.sdt = sdt;
            this.email = email;
        }
    }
}
