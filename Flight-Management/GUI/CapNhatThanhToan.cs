using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flight_Management.DTO;
using Flight_Management.BUS;

namespace Flight_Management.GUI
{
    public partial class CapNhatThanhToan : Form
    {
        const int UNPAID = 0;
        const int PAID = 1;
        const int ALL = 2;

        HoaDonBUS hoaDonBUS = new HoaDonBUS();
        VeChuyenBayBUS veChuyenBayBUS = new VeChuyenBayBUS();
        public CapNhatThanhToan()
        {
            InitializeComponent();

            //Load all bill that not checkout
            btnUnpaid_Click(this, new EventArgs());
        }

        private void loadBills(int action)
        {
            //Get data
            List<HoaDon> listBill = new List<HoaDon>();

            switch (action)
            {
                case UNPAID:
                    listBill = hoaDonBUS.getListBill(0);
                    break;
                case PAID:
                    listBill = hoaDonBUS.getListBill(1);
                    break;
                case ALL:
                    listBill = hoaDonBUS.getListBill();
                    break;
            }

            //Show
            dtgvBill.DataSource = listBill;
        }

        private void CapNhatThanhToan_Load(object sender, EventArgs e)
        {

        }

        private void btnAllBill_Click(object sender, EventArgs e)
        {
            loadBills(ALL);
            setHeaderHoaDon();
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            loadBills(PAID);
            setHeaderHoaDon();
        }

        private void btnUnpaid_Click(object sender, EventArgs e)
        {
            loadBills(UNPAID);
            setHeaderHoaDon();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtgvBill.Rows.RemoveAt(0);
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            //Id bill is choose
            if(dtgvBill.Rows.Count == 0) { return; }
            int rowIndex = dtgvBill.CurrentCell.RowIndex;
            int idBill = Int32.Parse(dtgvBill.Rows[rowIndex].Cells[0].Value.ToString());

            //Get detail of bill
            List<ChiTietHoaDon> detail = veChuyenBayBUS.getDetailBill(idBill);

            //Show
            dtgvBill.DataSource = detail;
            setHeaderChiTiet();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //Id bill is choose
            if (dtgvBill.Rows.Count == 0) { return; }
            int rowIndex = dtgvBill.CurrentCell.RowIndex;
            int idBill = Int32.Parse(dtgvBill.Rows[rowIndex].Cells[0].Value.ToString());

            //Update bill
            bool resultPaid = hoaDonBUS.setPaid(idBill);

            //Response GUI
            if (!resultPaid)
            {
                MessageBox.Show("Lỗi server!Vui lòng thử lại!", "Thông báo");
                return;
            }

            loadBills(UNPAID);
            MessageBox.Show("Cập nhật thành công!", "Thông báo");

        }

        private void dtgvBill_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setHeaderHoaDon()
        {
            //Set header
            if (dtgvBill.RowCount > 0)
            {
                dtgvBill.Columns[0].HeaderText = "Mã HĐ";
                dtgvBill.Columns[1].HeaderText = "Tổng Tiền";
                dtgvBill.Columns[2].HeaderText = "Thanh Toán";
                dtgvBill.Columns[3].HeaderText = "Mã KH";
                dtgvBill.Columns[4].HeaderText = "Họ Tên";
                dtgvBill.Columns[5].HeaderText = "Username";
            }
        }

        private void setHeaderChiTiet()
        {
            //Set header
            if (dtgvBill.RowCount > 0)
            {
                dtgvBill.Columns[0].HeaderText = "Mã VCB";
                dtgvBill.Columns[1].HeaderText = "Hành Khách";
                dtgvBill.Columns[2].HeaderText = "Loại Hạng";
                dtgvBill.Columns[3].HeaderText = "Sân Bay Đi";
                dtgvBill.Columns[4].HeaderText = "Sân Bay Đến";
                dtgvBill.Columns[5].HeaderText = "Giá Vé";
            }
        }
    }
}
