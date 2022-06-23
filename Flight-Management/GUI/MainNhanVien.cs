using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flight_Management.GUI;

namespace Flight_Management
{
    public partial class MainNhanVien : Form
    {
        private string username;

        public bool isExit = true;

        public event EventHandler Logout; 

        public MainNhanVien(string username)
        {
            InitializeComponent();

            this.username = username;
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

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            ThemChuyenBay addFlight = new ThemChuyenBay();
            this.Hide();
            addFlight.ShowDialog();
            this.Show();
        }

        private void btnSearchFlight_Click(object sender, EventArgs e)
        {
            this.Hide();
            TraCuuChuyenBay searchFlight = new TraCuuChuyenBay();
            searchFlight.ShowDialog();
            this.Show();
        }

        private void btnUpdateCheckout_Click(object sender, EventArgs e)
        {
            this.Hide();
            CapNhatThanhToan checkout = new CapNhatThanhToan();
            checkout.ShowDialog();
            this.Show();
        }

        private void btnStatisticReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            BaoCaoThongKe baoCaoThongKeGUI = new BaoCaoThongKe();
            baoCaoThongKeGUI.ShowDialog();
            this.Show();
        }
    }
}
