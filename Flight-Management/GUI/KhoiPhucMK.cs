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
    public partial class KhoiPhucMK : Form
    {
        public KhoiPhucMK()
        {
            InitializeComponent();
            lbresult.Text = "";
        }


        private void KhoiPhucMK_Load(object sender, EventArgs e)
        {

        }

        private void btngetpass_Click(object sender, EventArgs e)
        {
            string email = tbemail.Text;
            if (email.Trim() == "") { MessageBox.Show("Vui lòng nhập email đã đăng ký!"); }
            else
            {
                string password = KhachHangBUS.getpass(email);

                if(password!=string.Empty)
                {
                    lbresult.ForeColor = Color.Blue;
                    lbresult.Text = "Mật khẩu: " + password;
                }
                else{

                    password = AdminBUS.getpass(email);

                    if (password != string.Empty)
                    {
                        lbresult.ForeColor = Color.Blue;
                        lbresult.Text = "Mật khẩu: " + password;
                    }
                    else
                    {
                        password = nhanvienBUS.getpass(email);

                        if (password != string.Empty)
                        {
                            lbresult.ForeColor = Color.Blue;
                            lbresult.Text = "Mật khẩu: " + password;
                        }
                        else
                        {
                            lbresult.ForeColor = Color.Red;
                            lbresult.Text = "Email này chưa được đăng ký";
                        }
                    }
                }
            }
        }
    }
}
