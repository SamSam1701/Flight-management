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
    public partial class ThemChuyenBay : Form
    {
        ChuyenBayBUS chuyenBayBUS = new ChuyenBayBUS();
        SanBayBUS sanBayBUS = new SanBayBUS();
        public ThemChuyenBay()
        {
            //init GUI
            InitializeComponent();

            //Load airport for combobox
            loadAirport();
        }

        private void loadAirport()
        {
            //Get list airport
            List<SanBay> listAirport = sanBayBUS.getListAirport();

            //Show to gui
            foreach(SanBay airport in listAirport)
            {
                cbbLandAirport.Items.Add(airport.ma_sb + " - " + airport.ten_san_bay);
                cbbTakeOffAirport.Items.Add(airport.ma_sb + " - " + airport.ten_san_bay);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            //Get data from form
            ChuyenBay chuyenbay = new ChuyenBay();
            chuyenbay.ngay_gio = dtpDayOfTakeOff.Value.ToString("yyyy-MM-dd") + " " + dtpTimeOfTakeOff.Value.ToString("HH:mm");
            chuyenbay.thoi_gian_bay = Convert.ToInt32(nudDuration.Value);
            chuyenbay.so_ghe_hang_1 = Convert.ToInt32(nudVipSeat.Value);
            chuyenbay.so_ghe_hang_2 = Convert.ToInt32(nudNormalSeat.Value);
            chuyenbay.ma_sb_di = Int32.Parse(cbbTakeOffAirport.Text.Substring(0, cbbTakeOffAirport.Text.IndexOf(" - ")));
            chuyenbay.ma_sb_den = Int32.Parse(cbbLandAirport.Text.Substring(0, cbbTakeOffAirport.Text.IndexOf(" - ")));

            //validate input
            int resultValidate = chuyenBayBUS.validateInput(chuyenbay);

            //show error input here

            //pass
            bool resultAddFlight = chuyenBayBUS.addFlight(chuyenbay);

            if (!resultAddFlight)
            {
                MessageBox.Show("Lỗi server! Vui lòng thử lại!", "Thông báo");
                return;
            }

            MessageBox.Show("Thêm thành công!", "Thông báo");

            //Reset input here
            cbbTakeOffAirport.Text = null;
            cbbLandAirport.Text = null;
        }

        private void ThemChuyenBay_Load(object sender, EventArgs e)
        {

        }
    }
}
