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
    public partial class thongKe : Form
    {
        String strCon = "Server=NhuSonNe; Database=C1302; Trusted_Connection=true;";
        public thongKe()
        {
            InitializeComponent();
            total_product();
            total_cate();
            gridView();
        }

        private void total_product() {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                string sql = "SELECT COUNT(product.prd_id) AS total_product FROM product ";
                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            String total = reader["total_product"].ToString();
                            lb_total.Text = total;
                        }
                    }
                }

                con.Close();
                
            }
            
        }
        private void total_cate() {
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                string sql = "SELECT COUNT(categories.cate_id) AS total_cate FROM categories ";
                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            String total = reader["total_cate"].ToString();
                            label1.Text = total;
                        }
                    }
                }

                con.Close();

            }

        }
        private void gridView() {
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string sql = "SELECT categories.cate_id, categories.cate_name, COUNT(product.prd_id) AS tong_so_san_pham, SUM(product.prd_quantity) AS tong_san_pham\r\nFROM product\r\nJOIN categories ON product.cate_id = categories.cate_id\r\nGROUP BY categories.cate_id, categories.cate_name;";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "product");
            tongSanPhamTheoDanhMuc.DataSource = dataSet.Tables["product"].DefaultView;
            tongSanPhamTheoDanhMuc.Columns[0].HeaderText = "Mã Danh Mục";
            tongSanPhamTheoDanhMuc.Columns[1].HeaderText = "Tên Danh Mục";
            tongSanPhamTheoDanhMuc.Columns[2].HeaderText = "Tổng Số Sản Phẩm";
            tongSanPhamTheoDanhMuc.Columns[3].HeaderText = "Tổng Số Lượng Sản Phẩm";
            
        }
        private void tongSanPhamTheoDanhMuc_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            main main = new main(); 
            this.Hide();
            main.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void thongKe_Load(object sender, EventArgs e)
        {

        }
    }
}
