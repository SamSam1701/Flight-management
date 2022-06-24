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
    public partial class PhieuMuaVe : Form
    {
        MySqlConnection Conn;
        string strconn = "Server= localhost; Database= ql_ban_ve_may_bay; UId=root; Pwd=a123456789; Pooling=false;Character Set=utf8";
        string query_find = "SELECT * FROM ve_chuyen_bay WHERE ma_vcb = @seMa";

        public PhieuMuaVe()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PhieuMuaVe_Load(object sender, EventArgs e)
        {
            dgvVeMua.DataSource = GetTicketList();
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            
            try
            {
                Conn = new MySqlConnection(strconn);
                Conn.Open();
                string query_cbo_LV = "SELECT * FROM loai_ve";
                string query_cbo_MaCB = "SELECT * FROM chuyen_bay";
                MySqlCommand comLV = new MySqlCommand(query_cbo_LV, Conn);
                MySqlDataReader readLV = comLV.ExecuteReader();
                cboLoaiVe.Items.Clear();
                cboMaCB.Items.Clear();
                while (readLV.Read())
                {
                    int subj = readLV.GetInt32("ma_loai_ve");
                    cboLoaiVe.Items.Add(subj);
                }
                readLV.Close();
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

        private DataTable GetTicketList()
        {
            DataTable dt = new DataTable();
            try
            {
                Conn = new MySqlConnection(strconn);
                Conn.Open();
                MySqlCommand comR = new MySqlCommand();
                comR.CommandType = CommandType.Text;
                comR.CommandText = "SELECT * FROM ve_chuyen_bay";
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

        private void clearDetail()
        {
            txtMaVCB.Text = "";
            txtSLCho.Text = "";
            txtMaHK.Text = "";
            txtMaHD.Text = "";
            txtGia.Text = "";
            txtTotal.Text = "";
            cboMaCB.SelectedIndex = -1;
            cboMaCB.Text = "";
            cboLoaiVe.SelectedIndex = -1;
            cboLoaiVe.Text = "";
            cboTT.SelectedIndex = -1;
            txtMaVCB.Focus();
        }

        private bool ExistedCo(int seMa)
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
                bool f = mySqlDataReader.Read();
                mySqlDataReader.Close();
                Conn.Close();
                return f;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        private decimal getGiaVe()
        {
            Conn = new MySqlConnection(strconn);
            Conn.Open();
            MySqlCommand comGV = new MySqlCommand();
            comGV.CommandType = CommandType.Text;
            comGV.CommandText = "SELECT gia_ve FROM loai_ve WHERE ma_loai_ve = " + cboLoaiVe.Text;
            comGV.Connection = Conn;
            MySqlDataReader readGV = comGV.ExecuteReader();
            decimal GiaVe = 0M;

            while (readGV.Read())
                GiaVe = readGV.GetDecimal("gia_ve");
            readGV.Close();
            Conn.Close();
            return GiaVe;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int seMa = int.Parse(txtMaVCB.Text);
            if (ExistedCo(seMa) == false)
            {

                try
                {
                    decimal GiaVe = getGiaVe();
                    Conn = new MySqlConnection(strconn);
                    Conn.Open();
                    MySqlCommand comR = new MySqlCommand();
                    comR.CommandType = CommandType.Text;
                    comR.CommandText = "INSERT INTO ve_chuyen_bay(ma_vcb, gia_ve, so_cho_ngoi, trang_thai, ma_hd, ma_hanh_khach, ma_loai_ve, ma_cb) Values(" + txtMaVCB.Text + ", @GiaVe," + txtSLCho.Text + ", @TrangThai," + txtMaHD.Text + "," + txtMaHK.Text + "," + cboLoaiVe.Text + "," + cboMaCB.Text + ")";
                    comR.Connection = Conn;
                    comR.Parameters.Add("@GiaVe", MySqlDbType.Decimal).Value = GiaVe;
                    int TrangThai = 0;
                    if (cboTT.SelectedIndex == 1)
                        TrangThai = 1;
                    comR.Parameters.Add("TrangThai", MySqlDbType.Int32).Value = TrangThai;
                    int fin = comR.ExecuteNonQuery();
                    if (fin > 0)
                    {
                        PhieuMuaVe_Load(sender, e);
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
            else
            {
                MessageBox.Show("Mã Phiếu Mua Vé Đã Tồn Tại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int seMa = int.Parse(txtMaVCB.Text);
            if (ExistedCo(seMa) == true)
            {
                try
                {
                    decimal GiaVe = getGiaVe();
                    Conn = new MySqlConnection(strconn);
                    Conn.Open();
                    MySqlCommand comR = new MySqlCommand();
                    comR.CommandType = CommandType.Text;
                    comR.CommandText = "UPDATE ve_chuyen_bay SET gia_ve = " + GiaVe + ", so_cho_ngoi = " + txtSLCho.Text + ", trang_thai = @TrangThai, ma_hd = " + txtMaHD.Text + ", ma_hanh_khach = " + txtMaHK.Text + ", ma_loai_ve = " + cboLoaiVe.Text + ", ma_cb = " + cboMaCB.Text + " WHERE ma_vcb = " + txtMaVCB.Text;
                    comR.Connection = Conn;
                    int TrangThai = 0;
                    if(cboTT.SelectedIndex == 1)
                        TrangThai = 1;
                    comR.Parameters.Add("TrangThai", MySqlDbType.Int32).Value = TrangThai;
                    int fin = comR.ExecuteNonQuery();
                    if (fin > 0)
                    {
                        PhieuMuaVe_Load(sender, e);
                        MessageBox.Show("Sửa Thành Công");
                        clearDetail();
                    }
                    Conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Mã Không Tồn Tại. Không Thể Sửa!!!");
            }
        }

        private void dgvVeMua_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedCellCount = dgvVeMua.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                int Total = int.Parse(dgvVeMua.CurrentRow.Cells[1].Value.ToString()) * int.Parse(dgvVeMua.CurrentRow.Cells[2].Value.ToString());
                txtMaVCB.Text = dgvVeMua.CurrentRow.Cells[0].Value.ToString();
                txtGia.Text = dgvVeMua.CurrentRow.Cells[1].Value.ToString();
                txtSLCho.Text = dgvVeMua.CurrentRow.Cells[2].Value.ToString();
                cboTT.SelectedIndex = (int)dgvVeMua.CurrentRow.Cells[3].Value;
                txtMaHD.Text = dgvVeMua.CurrentRow.Cells[4].Value.ToString();
                txtMaHK.Text = dgvVeMua.CurrentRow.Cells[5].Value.ToString();
                cboLoaiVe.SelectedIndex = (int)dgvVeMua.CurrentRow.Cells[6].Value - 1;
                cboMaCB.SelectedIndex = (int)dgvVeMua.CurrentRow.Cells[7].Value - 1;
                txtTotal.Text = Total + "";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount = dgvVeMua.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount == 0)
            {
                MessageBox.Show("Chưa Chọn Phiếu Mua Vé Xóa");
                return;
            }
            DialogResult ret = MessageBox.Show("Bạn Có Chắc Muốn Xóa Không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                try
                {
                    Conn = new MySqlConnection(strconn);
                    Conn.Open();
                    MySqlCommand comR = new MySqlCommand();
                    comR.CommandType = CommandType.Text;
                    comR.CommandText = "DELETE FROM ve_chuyen_bay WHERE ma_vcb = " + txtMaVCB.Text;
                    comR.Connection = Conn;
                    int fin = comR.ExecuteNonQuery();
                    if (fin > 0)
                    {
                        PhieuMuaVe_Load(sender, e);
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
    }
}
