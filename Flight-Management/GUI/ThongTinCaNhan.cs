using Flight_Management.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_Management.GUI
{
    public partial class ThongTinCaNhan : Form
    {
        private string username;

        private string password;

        public ThongTinCaNhan(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void ThongTinCaNhan_Admin_Load(object sender, EventArgs e)
        {

            int userloginID = checkLogin.checkUserLogin(username, password);
            if (userloginID == 0)
            {
                DataTable data = new DataTable();
                data = AdminBUS.showInfo(username);
                tbMa.Text = data.Rows[0]["ma_admin"].ToString();
                tbhoten.Text = data.Rows[0]["ho_ten"].ToString();
                tbemail.Text = data.Rows[0]["email"].ToString();
                tbusername.Text = data.Rows[0]["username"].ToString();
            }
            else if (userloginID == 1) // Khach hang
            {
                DataTable data = new DataTable();
                data = KhachHangBUS.showInfo(username);
                tbMa.Text = data.Rows[0]["ma_nv"].ToString();
                tbhoten.Text = data.Rows[0]["ho_ten"].ToString();
                tbemail.Text = data.Rows[0]["email"].ToString();
                tbusername.Text = data.Rows[0]["username"].ToString();
            }
            else if (userloginID == 2) // Nhan vien
            {
                DataTable data = new DataTable();
                data = nhanvienBUS.showInfo(username);
                tbMa.Text = data.Rows[0]["ma_nv"].ToString();
                tbhoten.Text = data.Rows[0]["ho_ten"].ToString();
                tbemail.Text = data.Rows[0]["email"].ToString();
                tbusername.Text = data.Rows[0]["username"].ToString();
            }

            //DataTable data = new DataTable();
        //    if (userLogin == 0)
        //    {
        //        if (newPass == confirmPass)
        //        {
        //            AdminBUS.changepass(newPass, username);
        //            MessageBox.Show("Đổi mật khẩu thành công!");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Nhập xác nhận mật khẩu chưa khớp!");
        //        }
        //    }
        //    else if (userLogin == 1)
        //    {
        //        if (newPass == confirmPass)
        //        {
        //            KhachHangBUS.changepass(newPass, username);
        //            MessageBox.Show("Đổi mật khẩu thành công!");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Nhập xác nhận mật khẩu chưa khớp!");
        //        }
        //    }
        //    else if (userLogin == 2)
        //    {
        //        if (newPass == confirmPass)
        //        {
        //            nhanvienBUS.changepass(newPass, username);
        //            MessageBox.Show("Đổi mật khẩu thành công!");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Nhập xác nhận mật khẩu chưa khớp!");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Tài khoản này chưa tồn tại!");
        //    }
        //}
        //    else
        //    {
        //        MessageBox.Show("không được để trống dữ liệu!");
        //    }


  
        }
    }
}
