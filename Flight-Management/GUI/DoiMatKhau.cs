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

namespace Flight_Management
{
    public partial class DoiMatKhau : Form
    {
        private string username;

        private string password;
        public DoiMatKhau(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void tbusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbcurpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbnewpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbconfirmpass_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnresetpass_Click(object sender, EventArgs e)
        {
            if (tbusername.Text != string.Empty &&
                tbcurpass.Text != string.Empty &&
                tbnewpass.Text != string.Empty &&
                tbconfirmpass.Text != string.Empty)
            {
                string Username = tbusername.Text;
                string curPass = tbcurpass.Text;
                string newPass = tbnewpass.Text;
                string confirmPass = tbconfirmpass.Text;

                int userLogin = checkLogin.checkUserLogin(username, password);

                if (userLogin == 0)
                {
                    if (newPass == confirmPass)
                    {
                        AdminBUS.changepass(newPass, username);
                        MessageBox.Show("Đổi mật khẩu thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Nhập xác nhận mật khẩu chưa khớp!");
                    }
                }
                else if (userLogin == 1)
                {
                    if (newPass == confirmPass)
                    {
                        KhachHangBUS.changepass(newPass, username);
                        MessageBox.Show("Đổi mật khẩu thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Nhập xác nhận mật khẩu chưa khớp!");
                    }
                }
                else if (userLogin ==2)
                {
                    if (newPass == confirmPass)
                    {
                        nhanvienBUS.changepass(newPass, username);
                        MessageBox.Show("Đổi mật khẩu thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Nhập xác nhận mật khẩu chưa khớp!");
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản này chưa tồn tại!");
                }
            }
            else
            {
                MessageBox.Show("không được để trống dữ liệu!");
            }

        }
    }
}
