using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLySanPham
{
    public partial class Form1 : Form
    {
        public String strCon = "Server=NhuSonNe; Database=C1302; Trusted_Connection=true;";
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void prd_management() { 
            Application.Run(new main());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool timThayNguoiDung = false;
            Thread th;
            string userName = txt_account.Text;
            string passWord = txt_pass.Text;
            string strCon = "Server=NhuSonNe; Database=C1302; Trusted_Connection=true;";
            SqlConnection con = new SqlConnection(strCon);
            
            con.Open();
            String sql = $"SELECT * FROM account WHERE account_name = '{userName}' AND account_password = '{passWord}'";
            SqlCommand sqlCommand = new SqlCommand(sql, con);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (userName == "" || passWord == "")
            {
                MessageBox.Show("Chua Nhap Day Du Thong Tin");
            }
            else {
                while (sqlDataReader.Read())
                {
                    String user_name = sqlDataReader["account_name"].ToString();
                    String pass_word = sqlDataReader["account_password"].ToString();
                    if (userName == user_name && passWord == pass_word)
                    {
                        timThayNguoiDung = true;
                        break;

                    }
                }
                if (timThayNguoiDung)
                {
                    MessageBox.Show("Đăng Nhập Thành Công !!!");
                    this.Close();
                    th = new Thread(prd_management);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();

                    
                    
                }
                else
                {
                    MessageBox.Show("Sai Tài Khoản Hoặc Mật Khẩu !!!");
                }
            }
                
            
            Console.Read();
            
            con.Close();
            
        }

        private void lb_dangki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dangKi dangki = new dangKi();
            this.Hide();
            dangki.Show();
            
        }
       

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_account_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_pass_Click(object sender, EventArgs e)
        {

        }

        private void lb_account_Click(object sender, EventArgs e)
        {

        }

        private void lb_login_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_exit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
    }
}
