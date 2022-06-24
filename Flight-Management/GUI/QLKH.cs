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
    public partial class QLKH : Form
    {
        MySqlConnection Conn;

        string strconn = "Server= localhost; Database= ql_ban_ve_may_bay; UId=root; Pwd=a123456789; Pooling=false;Character Set=utf8";
        string query_select = "SELECT * FROM khach_hang";
        string query_find = "SELECT * FROM khach_hang WHERE ma_kh = @seMa";
        public QLKH()
        {
            InitializeComponent();
        }

        
        private void QLKH_Load(object sender, EventArgs e)
        {
            try
            {
                Conn = new MySqlConnection(strconn);
                Conn.Open();
                MySqlCommand comR = new MySqlCommand();
                comR.CommandType = CommandType.Text;
                comR.CommandText = query_select;
                comR.Connection = Conn;
                MySqlDataReader reader = comR.ExecuteReader();
                lvKH.Items.Clear();
                while (reader.Read())
                {
                    int Ma = reader.GetInt32(0);
                    string Ten = reader.GetString(1);
                    DateTime Btime = reader.GetDateTime(2);
                    string GioiTinh = reader.GetString(3);
                    int SLV = reader.GetInt32(4);
                    string CMND = reader.GetString(5);
                    string DT = reader.GetString(6);
                    string Username = reader.GetString(8);

                    ListViewItem lvi = new ListViewItem(Ma + "");
                    lvi.SubItems.Add(Ten);
                    //lvi.SubItems.Add(GioiTinh);
                    lvi.SubItems.Add(SLV + "");
                    lvi.SubItems.Add(CMND);
                    lvi.SubItems.Add(DT);
                    lvi.SubItems.Add(Username);
                    lvKH.Items.Add(lvi);
                    if (GioiTinh == "Nam")
                    { 
                        lvi.ImageIndex = 0;
                    }
                    else if (GioiTinh == "Nữ")
                        {
                            lvi.ImageIndex = 1;
                        }
                    else lvi.ImageIndex = 2;

                    lvi.Tag = Ma;

                }
                Conn.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Lỗi kết nối MySQL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
      
        private void clearDetail()
        {
            txtMAKH.Text = "";
            txtSLV.Text = "";
            txtHvT.Text = "";
            txtSDT.Text = "";
            txtCMND.Text = "";
            cboGioiTinh.SelectedIndex = -1;
            dtNgaySinh.Value = DateTime.Now;
            txtUName.Text = "";
            txtPw.Text = "";
            btnKhoa.Text = "Khóa";
            txtMAKH.Focus();
        }


        private void lvKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvKH.SelectedItems.Count == 0)
            {
                clearDetail();
                return;
            }
            ListViewItem lvi = lvKH.SelectedItems[0];
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
                MySqlParameter paramR = new MySqlParameter("@seMa",MySqlDbType.Int32);
                paramR.Value = seMa;
                comR.Parameters.Add(paramR);
                MySqlDataReader mySqlDataReader = comR.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    string Ten = mySqlDataReader.GetString(1);
                    DateTime Btime = mySqlDataReader.GetDateTime(2);
                    string GioiTinh = mySqlDataReader.GetString(3);
                    int SLV = mySqlDataReader.GetInt32(4);
                    string CMND = mySqlDataReader.GetString(5);
                    string DT = mySqlDataReader.GetString(6);
                    bool ban = mySqlDataReader.GetBoolean(7);
                    string Username = mySqlDataReader.GetString(8);
                    string Password = mySqlDataReader.GetString(9);

                    txtMAKH.Text = seMa + "";
                    txtHvT.Text = Ten;
                    txtCMND.Text = CMND;
                    txtSDT.Text = DT;
                    txtSLV.Text = SLV + "";
                    if (GioiTinh == "Nam")
                    {
                        cboGioiTinh.SelectedIndex = 0;
                    }
                    else if (GioiTinh == "Nữ")
                    {
                        cboGioiTinh.SelectedIndex = 1;
                    }
                    else cboGioiTinh.SelectedIndex = 2;
                    dtNgaySinh.Value = Btime;
                    txtUName.Text = Username;
                    txtPw.Text = Password;
                    if (ban == true)
                        btnKhoa.Text = "Mở";
                    else btnKhoa.Text = "Khóa";
                }
                
                Conn.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Lỗi kết nối MySQL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                Conn.Close();
                return f;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            int seMa = int.Parse(txtMAKH.Text);
            if (ExistedCo(seMa) == false)
            {
                try
                {
                    Conn = new MySqlConnection(strconn);
                    Conn.Open();
                    MySqlCommand comR = new MySqlCommand();
                    comR.CommandType = CommandType.Text;
                    comR.CommandText = "INSERT INTO khach_hang(ma_kh, ho_ten, ngay_sinh, gioi_tinh, sl_ve_dat, cmnd, sdt, banned, username, password) Values(@seMa, @Ten, @Btime, @GioiTinh, @SLV, @CMND, @DT, @ban, @Username, @Password)";
                    comR.Connection = Conn;
                    comR.Parameters.Add("@seMa", MySqlDbType.Int32).Value = txtMAKH.Text;
                    comR.Parameters.Add("@Ten", MySqlDbType.String).Value = txtHvT.Text;
                    comR.Parameters.Add("@Btime", MySqlDbType.DateTime).Value = dtNgaySinh.Value;
                    comR.Parameters.Add("@GioiTinh", MySqlDbType.String).Value = cboGioiTinh.Text;
                    comR.Parameters.Add("@SLV", MySqlDbType.Int32).Value = txtSLV.Text;
                    comR.Parameters.Add("@CMND", MySqlDbType.String).Value = txtCMND.Text;
                    comR.Parameters.Add("@DT", MySqlDbType.String).Value = txtSDT.Text;
                    comR.Parameters.Add("@ban", MySqlDbType.Bit).Value = false;
                    comR.Parameters.Add("@Username", MySqlDbType.String).Value = txtUName.Text;
                    comR.Parameters.Add("@Password", MySqlDbType.String).Value = txtPw.Text;
                    int fin = comR.ExecuteNonQuery();
                    if (fin > 0)
                    {
                        QLKH_Load(sender, e);
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
                MessageBox.Show("Mã Khách Hàng Đã Tồn Tại");
            }

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            int seMa = int.Parse(txtMAKH.Text);
            if (ExistedCo(seMa) == true)
            {
                Conn = new MySqlConnection(strconn);
                Conn.Open();
                MySqlCommand comR = new MySqlCommand();
                comR.CommandType = CommandType.Text;
                comR.CommandText = "UPDATE khach_hang SET ho_ten = @Ten, ngay_sinh = @Btime, gioi_tinh = @GioiTinh, sl_ve_dat = @SLV, cmnd = @CMND, sdt = @DT WHERE ma_kh = @seMa";
                comR.Connection = Conn;
                comR.Parameters.Add("@seMa", MySqlDbType.String).Value = seMa;
                comR.Parameters.Add("@Ten", MySqlDbType.String).Value = txtHvT.Text;
                comR.Parameters.Add("@Btime", MySqlDbType.DateTime).Value = dtNgaySinh.Value;
                comR.Parameters.Add("@GioiTinh", MySqlDbType.String).Value = cboGioiTinh.Text;
                comR.Parameters.Add("@SLV", MySqlDbType.Int32).Value = txtSLV.Text;
                comR.Parameters.Add("@CMND", MySqlDbType.String).Value = txtCMND.Text;
                comR.Parameters.Add("@DT", MySqlDbType.String).Value = txtSDT.Text;
                int fin = comR.ExecuteNonQuery();
                if (fin > 0)
                {
                    QLKH_Load(sender, e);
                    MessageBox.Show("Sửa và Lưu Thành Công");
                    clearDetail();
                }
                Conn.Close();
            }
            else
            {
                MessageBox.Show("Mã Không Tồn Tại. Không Thể Sửa!!!");
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvKH.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chưa Chọn Khách Hàng Xóa");
                return;
            }
            ListViewItem lvi = lvKH.SelectedItems[0];
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
                    comR.CommandText = "DELETE FROM khach_hang WHERE ma_kh = @seMa";
                    comR.Connection = Conn;
                    comR.Parameters.Add("@seMa", MySqlDbType.Int32).Value = seMa;
                    int fin = comR.ExecuteNonQuery();
                    if (fin > 0)
                    {
                        QLKH_Load(sender, e);
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

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            if (lvKH.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chưa Chọn Khách Hàng Khóa");
                return;
            }
            ListViewItem lvi = lvKH.SelectedItems[0];
            int seMa = (int)lvi.Tag;
            bool ban = false;
            if (btnKhoa.Text == "Mở")
                ban = true;
            Conn = new MySqlConnection(strconn);
            Conn.Open();
            MySqlCommand comR = new MySqlCommand();
            comR.CommandType = CommandType.Text;
            comR.CommandText = "UPDATE khach_hang SET banned = @ban XOR 1 WHERE ma_kh = @seMa";
            comR.Connection = Conn;
            comR.Parameters.Add("@ban", MySqlDbType.Bit).Value = ban;
            comR.Parameters.Add("@seMa", MySqlDbType.String).Value = seMa;
            int fin = comR.ExecuteNonQuery();
            if (fin > 0)
            {
                QLKH_Load(sender, e);
                if (ban)
                    MessageBox.Show("Đã Mở Khóa Thành Công");
                else MessageBox.Show("Đã Khóa Thành Công");
                clearDetail();
            }

        }

    }
}
