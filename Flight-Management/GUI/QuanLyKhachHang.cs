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
    public partial class QuanLyKhachHang : Form
    {
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            DataTable dt = AdminBUS.showKhachHangInfo();
            dtgvkhachhang.DataSource = dt;

            cbkhachhang.DisplayMember = "ma_kh";
            cbkhachhang.ValueMember = "ma_kh";
            cbkhachhang.DataSource = dt;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int ma;
            Int32.TryParse(cbkhachhang.SelectedValue.ToString(), out ma);
            AdminBUS.deleteKhachHang(ma);

            DataTable table = AdminBUS.showKhachHangInfo();
            dtgvkhachhang.DataSource = table;
        }
    }
}
