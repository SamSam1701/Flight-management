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
    public partial class BaoCaoThongKe : Form
    {

        public BaoCaoThongKe()
        {
            InitializeComponent();
        }

        BaoCaoBUS baoCaoBUS = new BaoCaoBUS();
        private void btnExportByYear_Click(object sender, EventArgs e)
        {
            //
            dtgvReport.DataSource = null;
            //Get year
            int year = dtpByYear.Value.Year;

            //Get data
            List<BaoCaoTheoThang> list = baoCaoBUS.getListReportByYear(year);

            //Show
            if (list.Count == 0)
            {
                MessageBox.Show("Năm " + year + " không có chuyến bay nào!", "Thông báo");
                return;
            }

            dtgvReport.DataSource = list;
            //Set header
            if (dtgvReport.RowCount > 0)
            {
                dtgvReport.Columns[0].HeaderText = "Tháng";
                dtgvReport.Columns[1].HeaderText = "Số Chuyến Bay";
                dtgvReport.Columns[2].HeaderText = "Doanh Thu";
                dtgvReport.Columns[3].HeaderText = "Tỉ Lệ Vé Bán";

            }
        }

        private void BaoCaoThongKe_Load(object sender, EventArgs e)
        {

        }

        private void btnExportByMonth_Click(object sender, EventArgs e)
        {
            //
            dtgvReport.DataSource = null;
            //Get year
            int month = dtpByMonth.Value.Month;
            int year = dtpByYear.Value.Year;

            //Get data
            List<BaoCaoTheoChuyen> list = baoCaoBUS.getListReportByMonth(month, year);

            //Show
            if (list.Count == 0)
            {
                MessageBox.Show("Tháng " + month + "/" + year + " không có chuyến bay nào!", "Thông báo");
                return;
            }

            dtgvReport.DataSource = list;

            //Set header
            if(dtgvReport.RowCount > 0)
            {
                dtgvReport.Columns[0].HeaderText = "MCB";
                dtgvReport.Columns[1].HeaderText = "Sân Bay Đi";
                dtgvReport.Columns[2].HeaderText = "Sân Bay Đến";
                dtgvReport.Columns[3].HeaderText = "Ngày Bay";
                dtgvReport.Columns[4].HeaderText = "Số Vé Đã Bán";
                dtgvReport.Columns[5].HeaderText = "Tỉ Lệ";
                dtgvReport.Columns[6].HeaderText = "Doanh Thu";

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
