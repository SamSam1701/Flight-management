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
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
