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
    public partial class ThemChuyenBay : Form
    {
        MySqlConnection Conn;

        string strconn = "Server= localhost; Database= ql_ban_ve_may_bay; UId=root; Pwd=a123456789; Pooling=false;Character Set=utf8";
        string query_select = "SELECT * FROM chuyen_bay";
        string query_find = "SELECT * FROM chuyen_bay WHERE ma_cb = @seMa";
        public ThemChuyenBay()
        {
            InitializeComponent();
        }
        private void ThemChuyenBay_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            try
            {
                Conn = new MySqlConnection(strconn);
                Conn.Open();
                MySqlCommand comR = new MySqlCommand();
                comR.CommandType = CommandType.Text;
                comR.CommandText = query_select;
                comR.Connection = Conn;
                MySqlDataReader reader = comR.ExecuteReader();
                lvCB.Items.Clear();
                while (reader.Read())
                {
                    int Ma = reader.GetInt32(0);
                    DateTime Dtime = reader.GetDateTime(1);
                    int TGB = reader.GetInt32(2);
                    int SoGH1 = reader.GetInt32(3);
                    int SoGH2 = reader.GetInt32(4);
                    int MaSBDi = reader.GetInt32(5);
                    int MaSBDen = reader.GetInt32(6);

                    ListViewItem lvi = new ListViewItem(Ma + "");
                    lvi.SubItems.Add(Dtime.ToString());
                    //lvi.SubItems.Add(GioiTinh);
                    lvi.SubItems.Add(TGB + "");
                    lvi.SubItems.Add(SoGH1 + "");
                    lvi.SubItems.Add(SoGH2 + "");
                    lvi.SubItems.Add(MaSBDi + "");
                    lvi.SubItems.Add(MaSBDen + "");
                    lvCB.Items.Add(lvi);
                    lvi.Tag = Ma;

                }
                Conn.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Lỗi kết nối MySQL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadComboBox()
        {

            try
            {
                Conn = new MySqlConnection(strconn);
                Conn.Open();
                string query_cbo_MaSB = "SELECT * FROM san_bay";
                string query_cbo_MaCB = "SELECT * FROM chuyen_bay";
                MySqlCommand comSB = new MySqlCommand(query_cbo_MaSB, Conn);
                MySqlDataReader readSB = comSB.ExecuteReader();
                cboMaSBDi.Items.Clear();
                cboMaSBDen.Items.Clear();
                cboMaCB.Items.Clear();
                while (readSB.Read())
                {
                    int subj = readSB.GetInt32("ma_sb");
                    cboMaSBDi.Items.Add(subj);
                    cboMaSBDen.Items.Add(subj);
                }
                readSB.Close();
                MySqlCommand comCB = new MySqlCommand(query_cbo_MaCB, Conn);
                MySqlDataReader readCB = comCB.ExecuteReader();
                while (readCB.Read())
                {
                    int subj = readCB.GetInt32("ma_cb");
                    cboMaCB.Items.Add(subj);
                }
                readCB.Close();
                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearDetail()
        {
            txtSGH1.Text = "";
            txtSGH2.Text = "";
            cboMaCB.SelectedIndex = -1;
            cboMaCB.Text = "";
            cboMaSBDen.SelectedIndex = -1;
            cboMaSBDen.Text = "";
            cboMaSBDi.SelectedIndex = -1;
            cboMaSBDi.Text = "";
            cboMaCB.Focus();
        }


        private void lvCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCB.SelectedItems.Count == 0)
            {
                clearDetail();
                return;
            }
            ListViewItem lvi = lvCB.SelectedItems[0];
            int SeMa = (int)lvi.Tag;
            ShowDetail(SeMa);
        }

        private void ShowDetail(int seMa)
        {
            try
            {
                Conn = new MySqlConnection(strconn);
                Conn.Open();
                MySqlCommand comR = new MySqlCommand();
                comR.CommandType = CommandType.Text;
                comR.CommandText = query_find;
                comR.Connection = Conn;
                MySqlParameter paramR = new MySqlParameter("@seMa", MySqlDbType.Int32);
                paramR.Value = seMa;
                comR.Parameters.Add(paramR);
                MySqlDataReader mySqlDataReader = comR.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    int Ma = mySqlDataReader.GetInt32(0);
                    DateTime Dtime = mySqlDataReader.GetDateTime(1);
                    int TGB = mySqlDataReader.GetInt32(2);
                    int SoGH1 = mySqlDataReader.GetInt32(3);
                    int SoGH2 = mySqlDataReader.GetInt32(4);
                    int MaSBDi = mySqlDataReader.GetInt32(5);
                    int MaSBDen = mySqlDataReader.GetInt32(6);

                    cboMaCB.SelectedIndex = seMa - 1;
                    dtNgayGio.Value = Dtime;
                    txtTGB.Text = TGB + "";
                    txtSGH1.Text = SoGH1 + "";
                    txtSGH2.Text = SoGH2 + "";
                    cboMaSBDi.SelectedIndex = MaSBDi - 1;
                    cboMaSBDen.SelectedIndex = MaSBDen - 1;
                }

                Conn.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Lỗi kết nối MySQL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            
            try
            {
                Conn = new MySqlConnection(strconn);
                Conn.Open();
                MySqlCommand comR = new MySqlCommand();
                comR.CommandType = CommandType.Text;
                comR.CommandText = "INSERT INTO chuyen_bay(ngay_gio, thoi_gian_bay, so_ghe_hang_1, so_ghe_hang_2, ma_sb_di, ma_sb_den) Values(@Dtime, @TGBay, @SGH1, @SGH2, @MaSBDi, @MaSBDen)";
                comR.Connection = Conn;
                comR.Parameters.Add("@Dtime", MySqlDbType.DateTime).Value = dtNgayGio.Value;
                comR.Parameters.Add("@TGBay", MySqlDbType.Int32).Value = txtTGB.Text;
                comR.Parameters.Add("@SGH1", MySqlDbType.String).Value = txtSGH1.Text;
                comR.Parameters.Add("@SGH2", MySqlDbType.String).Value = txtSGH2.Text;
                comR.Parameters.Add("@MaSBDi", MySqlDbType.String).Value = cboMaSBDi.Text;
                comR.Parameters.Add("@MaSBDen", MySqlDbType.String).Value = cboMaSBDen.Text;
                int fin = comR.ExecuteNonQuery();
                if (fin > 0)
                {
                    ThemChuyenBay_Load(sender, e);
                    MessageBox.Show("Thêm Thành Công");
                    clearDetail();
                }
                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
      

        }
    
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvCB.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chưa Chọn Chuyến Bay Xóa");
                return;
            }
            ListViewItem lvi = lvCB.SelectedItems[0];
            int seMa = (int)lvi.Tag;
            DialogResult ret = MessageBox.Show("Bạn Có Chắc Muốn Xóa Không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                try
                {
                    Conn = new MySqlConnection(strconn);
                    Conn.Open();
                    MySqlCommand comR = new MySqlCommand();
                    comR.CommandType = CommandType.Text;
                    comR.CommandText = "DELETE FROM chuyen_bay WHERE ma_cb = @seMa";
                    comR.Connection = Conn;
                    comR.Parameters.Add("@seMa", MySqlDbType.Int32).Value = seMa;
                    int fin = comR.ExecuteNonQuery();
                    if (fin > 0)
                    {
                        ThemChuyenBay_Load(sender, e);
                        MessageBox.Show("Xóa Thành Công");
                        clearDetail();
                    }
                    else
                    {
                        MessageBox.Show("Xóa Thất Bại");
                    }
                    Conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
