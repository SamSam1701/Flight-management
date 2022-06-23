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

namespace Flight_Management
{
    public partial class TraCuuChuyenBay : Form
    {
        ChuyenBayBUS chuyenBayBUS = new ChuyenBayBUS();
        SanBayBUS sanBayBUS = new SanBayBUS();
        public TraCuuChuyenBay()
        {
            InitializeComponent();

            //Load list airport
            loadListAirport();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TraCuuChuyenBay_Load(object sender, EventArgs e)
        {

        }

        private void loadListFlight()
        {
            //Get list flight
            List<ChuyenBayInfo> list = chuyenBayBUS.getListFlight();

            //Show
            dtgvListFlight.DataSource = list;
        }

        private void loadListAirport()
        {
            //Get  list airport
            List<SanBay> list = sanBayBUS.getListAirport();

            //Show
            cbbTakeOffAirport.Items.Add("");
            cbbLandAirport.Items.Add("");
            foreach (SanBay airport in list)
            {
                cbbTakeOffAirport.Items.Add(airport.ma_sb + " - " + airport.ten_san_bay);
                cbbLandAirport.Items.Add(airport.ma_sb + " - " + airport.ten_san_bay);

            }
        }

        private void searchFlight()
        {
            //Get data input
            int? ma_cb = null;
            string ngay_gio = null;
            int? ma_sb_di = null;
            int? ma_sb_den = null;

            if (txbId.Text != "") { ma_cb = Int32.Parse(txbId.Text); };
            if (cbDayOfTakeOff.Checked && dtpDayOfTakeOff.Value != null) { ngay_gio = dtpDayOfTakeOff.Value.ToString("yyyyMMdd"); };
            if (cbbTakeOffAirport.Text != "") { ma_sb_di = Int32.Parse(cbbTakeOffAirport.Text.Substring(0, cbbTakeOffAirport.Text.IndexOf(" - "))); }
            if (cbbLandAirport.Text != "") { ma_sb_den = Int32.Parse(cbbLandAirport.Text.Substring(0, cbbLandAirport.Text.IndexOf(" - "))); }

            //
            if (ma_cb == null && ngay_gio == null && ma_sb_den == null && ma_sb_di == null) { ma_cb = 0; }
            List<ChuyenBayInfo> listFlight = chuyenBayBUS.getListFlight(ma_cb, ngay_gio, ma_sb_di, ma_sb_den);

            //
            if (listFlight.Count == 0)
            {
                MessageBox.Show("Không tìm thấy chuyến bay nào!", "Thông báo");
                return;
            }

            dtgvListFlight.DataSource = listFlight;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtgvListFlight.DataSource = null;
            searchFlight();
            setHeaderDatagridView();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            dtgvListFlight.DataSource = null;
            loadListFlight();
            setHeaderDatagridView();
        }

        private void setHeaderDatagridView()
        {
            if (dtgvListFlight.RowCount > 0)
            {
                dtgvListFlight.Columns[0].HeaderText = "MCB";
                dtgvListFlight.Columns[1].HeaderText = "Sân Bay Đi";
                dtgvListFlight.Columns[2].HeaderText = "Sân Bay Đến";
                dtgvListFlight.Columns[3].HeaderText = "Ngày Bay";
                dtgvListFlight.Columns[4].HeaderText = "Số Phút Bay";
                dtgvListFlight.Columns[5].HeaderText = "Số Ghế Hạng 1";
                dtgvListFlight.Columns[6].HeaderText = "Số Ghế Hạng 2";
            }
        }
    }
}
