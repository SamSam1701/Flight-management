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

namespace Flight_Management
{
    public partial class QuyDinh : Form
    {
        public QuyDinh()
        {
            InitializeComponent();
        }

        private void QuyDinh_Load(object sender, EventArgs e)
        {
            DataTable dt = AdminBUS.showRule();

            datagridviewRule.DataSource = dt;

            cbmaqd.DisplayMember = "ma_qd";
            cbmaqd.ValueMember = "ma_qd";
            cbmaqd.DataSource = dt;
        }

        private void datagridviewRule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbmaqd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (tbnamerule.Text != string.Empty)
            {
                int ma;
                Int32.TryParse(cbmaqd.SelectedValue.ToString(), out ma);

                string ruleUpdate = tbnamerule.Text;
                AdminBUS.changRule(ruleUpdate, ma);

                DataTable dt = AdminBUS.showRule();
                datagridviewRule.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Tên quy định không được để trống!");
            }
        }
    }
}
