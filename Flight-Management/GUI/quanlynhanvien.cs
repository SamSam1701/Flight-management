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
    public partial class quanlynhanvien : Form
    {

        public quanlynhanvien()
        {
            InitializeComponent();
        }

        private void quanlynhanvien_Load(object sender, EventArgs e)
        {

        }


        private void btnadd_Click(object sender, EventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            DataTable table = nhanvienBUS.Getdata();

            datagvquanlynhanvien.DataSource = table;
        }

        private void datagvquanlynhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
