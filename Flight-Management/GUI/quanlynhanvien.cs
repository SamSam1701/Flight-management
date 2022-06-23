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
    public partial class QuanLyNhanVien : Form
    {

        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void quanlynhanvien_Load(object sender, EventArgs e)
        {
            DataTable dt = AdminBUS.showNhanVienInfo();
            datagvquanlynhanvien.DataSource = dt;

            cbmanv.DisplayMember = "ma_nv";
            cbmanv.ValueMember = "ma_nv";
            cbmanv.DataSource = dt;

        }


        private void btnadd_Click(object sender, EventArgs e)
        {
            if(tbusername.Text!=string.Empty && tbpassword.Text!= string.Empty)
            {
                string username = tbusername.Text;
                string password = tbpassword.Text;
                AdminBUS.addNhanVien(username, password);

                quanlynhanvien_Load(sender, e);

            }
            else
            {
                MessageBox.Show("Không được để trống dữ liệu!");
            }
        }

        private void datagvquanlynhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int ma;
            Int32.TryParse(cbmanv.SelectedValue.ToString(), out ma);
            AdminBUS.deleteNhanVien(ma);

            DataTable table = AdminBUS.showNhanVienInfo();
            datagvquanlynhanvien.DataSource = table;

        }
    }
}
