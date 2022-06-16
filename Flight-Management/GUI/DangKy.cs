using Flight_Management.BUS;
using Flight_Management.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_Management
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

  
        private void btnregister_Click(object sender, EventArgs e)
        {
            if (tbname.Text != string.Empty && 
                tbusername.Text != string.Empty &&
                tbpass.Text != string.Empty &&
                tbsdt.Text != string.Empty &&
                tbcmnd.Text!= string.Empty &&
                tbemail.Text != string.Empty)
            {
                string ho_ten = tbname.Text;
                string username = tbusername.Text;
                string password = tbpass.Text;
                string cmnd = tbcmnd.Text;
                string sdt = tbsdt.Text;
                string email = tbemail.Text;

                KhachHang KH = new KhachHang(ho_ten, username, password, cmnd, sdt, email);


                if (!checkEmail(email)) { MessageBox.Show("Vui lòng nhập đúng định dạng email!");return; }
                if (KhachHangBUS.checkExistEmail(email)) { MessageBox.Show("Email đã được sử dụng!");return; }

                if (KhachHangBUS.register(KH))
                {
                    MessageBox.Show("Đăng ký tài khoản thành công!");
                }
                else
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại!");
                }

            }
            else
            {
                MessageBox.Show("không được để trống dữ liệu!");
            }
        }

        private void tbname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbcmnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbsdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbemail_TextChanged(object sender, EventArgs e)
        {

        }

        public bool checkUsername(string username)
        {
            return Regex.IsMatch(username, "^[a-zA-Z0-9]{6-24}$");
        }

        public bool checkEmail(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }

    }
}
