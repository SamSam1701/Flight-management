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

        public MainAdmin()
        {
            InitializeComponent();
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
    }
}
