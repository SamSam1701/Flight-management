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
    public partial class DangNhap : Form
    {
        nhanvienBUS nvBUS = new nhanvienBUS();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e) //tb_username_login
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (tbusernamelogin.Text != string.Empty && tbpasslogin.Text!=string.Empty)
            {
                string username = tbusernamelogin.Text;
                string password = tbpasslogin.Text;

                if (nhanvienBUS.Login(username, password).Rows.Count > 0)
                { 
                    MainNhanVien mainnv = new MainNhanVien(username, password);
                    mainnv.Show();
                    this.Hide();
                    mainnv.Logout += Mainnv_Logout;
;
                }
                else if(AdminBUS.Login(username,password).Rows.Count>0)
                {
                    MainAdmin mainAdmin = new MainAdmin(username, password);
                    mainAdmin.Show();
                    this.Hide();
                    mainAdmin.Logout += MainAdmin_Logout;
                }
                else if (KhachHangBUS.Login(username, password).Rows.Count>0)
                {
                    MainKhachHang mainKH = new MainKhachHang(username, password);
                    mainKH.Show();
                    this.Hide();
                    mainKH.Logout += MainKH_Logout;
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu chưa chính xác!");
                }



            }
            else
            {
                MessageBox.Show("Tài khoản và mật khẩu không được để trống!");
            }



        }

        private void MainKH_Logout(object sender, EventArgs e)
        {
            (sender as MainKhachHang).isExit = false;
            (sender as MainKhachHang).Close();
            this.Show();
        }

        private void Mainnv_Logout(object sender, EventArgs e)
        {
            (sender as MainNhanVien).isExit = false;
            (sender as MainNhanVien).Close();
            this.Show();
        }

        private void MainAdmin_Logout(object sender, EventArgs e)
        {
            (sender as MainAdmin).isExit = false;
            (sender as MainAdmin).Close();
            this.Show();
        }

        private void DangNhap_formClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            DangKy reg = new DangKy();
            reg.ShowDialog();
        }

        private void btnforgetpass_Click(object sender, EventArgs e)
        { 
            KhoiPhucMK KPMK = new KhoiPhucMK();
            KPMK.ShowDialog();
        }
    }
}
