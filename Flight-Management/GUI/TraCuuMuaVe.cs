using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Flight_Management
{
    public partial class TraCuuMuaVe : Form
    {
        MySqlConnection Conn;

        string strconn = "Server= localhost; Database= ql_ban_ve_may_bay; UId=root; Pwd=a123456789; Pooling=false;Character Set=utf8";
        string query_select = "SELECT * FROM chuyen_bay";
        string query_find = "SELECT * FROM chuyen_bay WHERE ma_cb = @seMa";
        string query_fill = "SELECT ma_cb, SBDi.ten_san_bay as 'Sân Bay Đi', SBDen.ten_san_bay as 'Sân Bay Đến', ngay_gio, thoi_gian_bay, so_ghe_hang_1, so_ghe_hang_2 FROM(chuyen_bay cb join san_bay SBDi on cb.ma_sb_di = SBDi.ma_sb) join san_bay SBDen on cb.ma_sb_den = SBDen.ma_sb";
        public TraCuuMuaVe()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void TraCuuMuaVe_Load(object sender, EventArgs e)
        {
            dgvCB.DataSource = GetCBList();
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            try
            {
                Conn = new MySqlConnection(strconn);
                Conn.Open();
                string query_cbo_MaSB = "SELECT * FROM san_bay";
                MySqlCommand comSB = new MySqlCommand(query_cbo_MaSB, Conn);
                MySqlDataReader readSB = comSB.ExecuteReader();
                cboSBDi.Items.Clear();
                cboSBDen.Items.Clear();
                while (readSB.Read())
                {
                    string subj = readSB.GetString("Ten_san_bay");
                    cboSBDi.Items.Add(subj);
                    cboSBDen.Items.Add(subj);
                }
                readSB.Close();
                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lblHrAMi.Text = dateTime.ToString("hh:mm");
            lblSec.Text = dateTime.ToString("ss");
            lblAPM.Text = dateTime.ToString("tt");
            lblDate.Text = dateTime.ToString("MMM").ToUpper() + dateTime.ToString(" dd yyyy");
            lblDay.Text = dateTime.ToString("dddd");
        }

        private DataTable GetCBList()
        {
            DataTable dt = new DataTable();
            try
            {
                Conn = new MySqlConnection(strconn);
                Conn.Open();
                MySqlCommand comR = new MySqlCommand();
                comR.CommandType = CommandType.Text;
                comR.CommandText = query_fill;
                comR.Connection = Conn;
                MySqlDataReader reader = comR.ExecuteReader();
                dt.Load(reader);
                reader.Close();
                Conn.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Lỗi kết nối MySQL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        private void btnShowFDGV_Click(object sender, EventArgs e)
        {
            dgvCB.DataSource = GetCBList();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                Conn = new MySqlConnection(strconn);
                Conn.Open();
                MySqlCommand comR = new MySqlCommand();
                comR.CommandType = CommandType.Text;
                comR.CommandText = query_fill + " WHERE SBDi.ten_san_bay = '" + cboSBDi.Text + "' AND SBDen.ten_san_bay = '" + cboSBDen.Text + "' AND (ngay_gio between '" + dtFrom.Value.ToString("yyyy-MM-dd") + "' and '" + dtTo.Value.ToString("yyyy-MM-dd") + "')";
                comR.Connection = Conn;
                MySqlDataReader reader = comR.ExecuteReader();
                dt.Load(reader);
                reader.Close();
                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvCB.DataSource = dt;
        }

        private void cboSBDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSBDen.SelectedIndex > -1)
                (dgvCB.DataSource as DataTable).DefaultView.RowFilter =
                    String.Format("[Sân Bay Đến] = '" + cboSBDen.Text + "' AND [Sân Bay Đi] = '" + cboSBDi.Text + "'");
            else
            (dgvCB.DataSource as DataTable).DefaultView.RowFilter =
                    String.Format("[Sân Bay Đi] = '" + cboSBDi.Text + "'");
        }

        private void cboSBDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSBDi.SelectedIndex > -1)
                (dgvCB.DataSource as DataTable).DefaultView.RowFilter =
                    String.Format("[Sân Bay Đi] = '" + cboSBDi.Text + "' AND [Sân Bay Đến] = '" + cboSBDen.Text + "'");
            else
                (dgvCB.DataSource as DataTable).DefaultView.RowFilter =
                        String.Format("[Sân Bay Đến] = '" + cboSBDen.Text + "'");
        }
    }
}
