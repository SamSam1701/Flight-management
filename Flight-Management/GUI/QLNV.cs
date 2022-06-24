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
    public partial class QLNV : Form
    {
        MySqlConnection Conn;

        string strconn = "Server= localhost; Database= ql_ban_ve_may_bay; UId=root; Pwd=a123456789; Pooling=false;Character Set=utf8";
        string query_select = "SELECT * FROM nhan_vien";
        string query_find = "SELECT * FROM nhan_vien WHERE ma_nv = @seMa";
        public QLNV()
        {
            InitializeComponent();
        }


        private void QLNV_Load(object sender, EventArgs e)
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
                lvNV.Items.Clear();
                while (reader.Read())
                {
                    int Ma = reader.GetInt32(0);
                    string Ten = reader.GetString(1);
                    DateTime Btime = reader.GetDateTime(2);
                    string GioiTinh = reader.GetString(3);
                    string DT = reader.GetString(4);
                    string Email = reader.GetString(5);
                    string Username = reader.GetString(6);

                    ListViewItem lvi = new ListViewItem(Ma + "");
                    lvi.SubItems.Add(Ten);
                    //lvi.SubItems.Add(GioiTinh);
                    lvi.SubItems.Add(DT);
                    lvi.SubItems.Add(Email);
                    lvi.SubItems.Add(Username);
                    lvNV.Items.Add(lvi);
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
            txtMANV.Text = "";
            txtHvT.Text = "";
            txtSDT.Text = "";
            cboGioiTinh.SelectedIndex = -1;
            dtNgaySinh.Value = DateTime.Now;
            txtEmail.Text = "";
            txtUName.Text = "";
            txtPw.Text = "";
            txtMANV.Focus();
        }


        private void lvNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNV.SelectedItems.Count == 0)
            {
                clearDetail();
                return;
            }
            ListViewItem lvi = lvNV.SelectedItems[0];
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
                    string Ten = mySqlDataReader.GetString(1);
                    DateTime Btime = mySqlDataReader.GetDateTime(2);
                    string GioiTinh = mySqlDataReader.GetString(3);
                    string DT = mySqlDataReader.GetString(4);
                    string Email = mySqlDataReader.GetString(5);
                    string Username = mySqlDataReader.GetString(6);
                    string Password = mySqlDataReader.GetString(7);

                    txtMANV.Text = seMa + "";
                    txtHvT.Text = Ten;
                    txtSDT.Text = DT;
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
                    txtEmail.Text = Email;
                    txtUName.Text = Username;
                    txtPw.Text = Password;
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
            int seMa = int.Parse(txtMANV.Text);
            if (ExistedCo(seMa) == false)
            {
                try
                {
                    Conn = new MySqlConnection(strconn);
                    Conn.Open();
                    MySqlCommand comR = new MySqlCommand();
                    comR.CommandType = CommandType.Text;
                    comR.CommandText = "INSERT INTO nhan_vien(ma_nv, ho_ten, ngay_sinh, gioi_tinh, sdt, email, username, password) Values(@seMa, @Ten, @Btime, @GioiTinh, @DT, @Email, @Username, @Password)";
                    comR.Connection = Conn;
                    comR.Parameters.Add("@seMa", MySqlDbType.Int32).Value = txtMANV.Text;
                    comR.Parameters.Add("@Ten", MySqlDbType.String).Value = txtHvT.Text;
                    comR.Parameters.Add("@Btime", MySqlDbType.DateTime).Value = dtNgaySinh.Value;
                    comR.Parameters.Add("@GioiTinh", MySqlDbType.String).Value = cboGioiTinh.Text;
                    comR.Parameters.Add("@DT", MySqlDbType.String).Value = txtSDT.Text;
                    comR.Parameters.Add("@Email", MySqlDbType.String).Value = txtEmail.Text;
                    comR.Parameters.Add("@Username", MySqlDbType.String).Value = txtUName.Text;
                    comR.Parameters.Add("@Password", MySqlDbType.String).Value = txtPw.Text;
                    int fin = comR.ExecuteNonQuery();
                    if (fin > 0)
                    {
                        QLNV_Load(sender, e);
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
                MessageBox.Show("Mã Nhân Viên Đã Tồn Tại");
            }

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            int seMa = int.Parse(txtMANV.Text);
            if (ExistedCo(seMa) == true)
            {
                Conn = new MySqlConnection(strconn);
                Conn.Open();
                MySqlCommand comR = new MySqlCommand();
                comR.CommandType = CommandType.Text;
                comR.CommandText = "UPDATE nhan_vien SET ho_ten = @Ten, ngay_sinh = @Btime, gioi_tinh = @GioiTinh, sdt = @DT, email = @Email WHERE ma_nv = @seMa";
                comR.Connection = Conn;
                comR.Parameters.Add("@seMa", MySqlDbType.String).Value = seMa;
                comR.Parameters.Add("@Ten", MySqlDbType.String).Value = txtHvT.Text;
                comR.Parameters.Add("@Btime", MySqlDbType.DateTime).Value = dtNgaySinh.Value;
                comR.Parameters.Add("@GioiTinh", MySqlDbType.String).Value = cboGioiTinh.Text;
                comR.Parameters.Add("@DT", MySqlDbType.String).Value = txtSDT.Text;
                comR.Parameters.Add("@Email", MySqlDbType.String).Value = txtEmail.Text;
                int fin = comR.ExecuteNonQuery();
                if (fin > 0)
                {
                    QLNV_Load(sender, e);
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
            if (lvNV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chưa Chọn Nhân Viên Xóa");
                return;
            }
            ListViewItem lvi = lvNV.SelectedItems[0];
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
                    comR.CommandText = "DELETE FROM nhan_vien WHERE ma_nv = @seMa";
                    comR.Connection = Conn;
                    comR.Parameters.Add("@seMa", MySqlDbType.Int32).Value = seMa;
                    int fin = comR.ExecuteNonQuery();
                    if (fin > 0)
                    {
                        QLNV_Load(sender, e);
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
