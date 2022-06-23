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
    public partial class MainNhanVien : Form
    {

        public bool isExit = true;

        public event EventHandler Logout;

        private string username;

        private string password;

        public MainNhanVien(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void MainNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void mainNV_formClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
                Application.Exit(); //đóng chương trình hoàn toàn
        }

        private void mainNV_formClosing(object sender, FormClosingEventArgs e)
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
            ThongTinCaNhan info = new ThongTinCaNhan(username, password);
            info.ShowDialog();
        }
    }
}
