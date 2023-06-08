using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLySanPham
{
    public partial class dangKi : Form
    {
        public dangKi()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string user_name = txt_register_username.Text;
            string email = txt_register_email.Text;
            string phone = txt_register_phone.Text;
            string pass = txt_register_pass.Text;
            string re_pass = txt_register_re_pass.Text;

            if (pass != re_pass)
            {
                MessageBox.Show("Xin mời nhập lại mật khẩu!!");
                txt_register_re_pass.Clear();
                txt_register_pass.Clear();
            }
            else
            {
                string strCon = "Server=NhuSonNe; Database=C1302; Trusted_Connection=true;";
                SqlConnection con = new SqlConnection(strCon);
                con.Open();

                // Kiểm tra xem user_name đã tồn tại hay chưa
                string checkQuery = $"SELECT COUNT(*) FROM account WHERE account_name = '{user_name}'";
                SqlCommand checkCommand = new SqlCommand(checkQuery, con);
                int existingUserCount = (int)checkCommand.ExecuteScalar();

                if (existingUserCount > 0)
                {
                    MessageBox.Show("Tên người dùng đã tồn tại!");
                }
                else
                {
                    // Nếu user_name không bị trùng, thực hiện thêm dữ liệu vào cơ sở dữ liệu
                    string insertQuery = $"INSERT INTO account VALUES ('{user_name}', '{email}', '{phone}', '{pass}')";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, con);
                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("Đăng kí thành công!"); 
                    Form1 form1 = new Form1();
                    form1.ShowDialog();
                    this.Close();
                }

                con.Close();
            }
        }

        private void dangKi_Load(object sender, EventArgs e)
        {

        }

        private void lb_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 main = new Form1();
            main.ShowDialog();
            this.Close();
        }
    }
}
