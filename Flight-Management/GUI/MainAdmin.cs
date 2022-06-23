using Flight_Management.GUI;
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


    public partial class MainAdmin : Form
    {
        public bool isExit = true;

        public event EventHandler Logout;

        private string username;

        private string password;

        public MainAdmin(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void MainAdmin_Load(object sender, EventArgs e)
        {

        }

        private void MainAdmin_closed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
                Application.Exit(); //đóng chương trình hoàn toàn
        }

        private void MainAdmin_closing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bán muốn thoát chương trình?", "Cảnh Báo!", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs()); //hảm ủy thác
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            DoiMatKhau doiMK = new DoiMatKhau(username, password);
            doiMK.ShowDialog();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ThongTinCaNhan fAdmin = new ThongTinCaNhan(username, password);
            fAdmin.ShowDialog();
        }

        private void btnUpdateRule_Click(object sender, EventArgs e)
        {
            QuyDinh qd = new QuyDinh();
            qd.ShowDialog();
        }

        private void btnCustomerManager_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang quanlykh = new QuanLyKhachHang();
            quanlykh.ShowDialog();
        }

        private void btnStaffManager_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien quanlynv = new QuanLyNhanVien();
            quanlynv.ShowDialog();
        }
    }
}
