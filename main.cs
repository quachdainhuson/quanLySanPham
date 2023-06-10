using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Reflection;
using System.Threading;

namespace quanLySanPham
{
    public partial class main : Form

    {
        
        String strCon = "Server=NhuSonNe; Database=C1302; Trusted_Connection=true;";

        public main()
        {
            InitializeComponent();
            

        }

        private void main_Load(object sender, EventArgs e)
        {
            loadData();
            /*LoadCategories();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string sql = "SELECT product.prd_id, product.prd_name, product.prd_price,product.prd_quantity, categories.cate_name, product.prd_image FROM product INNER JOIN categories ON product.cate_id = categories.cate_id";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "product");
            dataGridView.DataSource = dataSet.Tables["product"].DefaultView;
            dataGridView.Columns[0].HeaderText = "Mã Sản Phảm";
            dataGridView.Columns[1].HeaderText = "Tên Sản Phẩm";
            dataGridView.Columns[2].HeaderText = "Giá Sản Phảm";
            dataGridView.Columns[3].HeaderText = "Số Lượng";
            dataGridView.Columns[4].HeaderText = "Danh Mục Sản Phảm";
            dataGridView.Columns[5].HeaderText = "Ảnh Sản Phảm";
            dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            con.Close();
            txt_product_id.Enabled = false;
            txt_product_name.Enabled = false;
            txt_product_price.Enabled = false;
            txt_product_quantity.Enabled = false;
            cb_categories.Enabled = false;
            btn_save.Enabled = false;
            btn_update.Enabled = false;
            button2.Enabled = false;
            txt_picture.Enabled = false;*/

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        private void loadData()
        {   
            LoadCategories();

            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string sql = "SELECT product.prd_id, product.prd_name, product.prd_price,product.prd_quantity, categories.cate_name, product.prd_image FROM product INNER JOIN categories ON product.cate_id = categories.cate_id";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "product");
            dataGridView.DataSource = dataSet.Tables["product"].DefaultView;
            dataGridView.Columns[0].HeaderText = "Mã Sản Phảm";
            dataGridView.Columns[1].HeaderText = "Tên Sản Phẩm";
            dataGridView.Columns[2].HeaderText = "Giá Sản Phảm";
            dataGridView.Columns[3].HeaderText = "Số Lượng";
            dataGridView.Columns[4].HeaderText = "Danh Mục Sản Phảm";
            dataGridView.Columns[5].HeaderText = "Ảnh Sản Phảm";
            con.Close();
            txt_product_id.Clear();
            txt_product_name.Clear();
            txt_product_price.Clear();
            txt_product_quantity.Clear();
            txt_picture.Clear();
            txt_product_id.Enabled = false;
            txt_product_name.Enabled = false;
            txt_product_price.Enabled = false;
            txt_product_quantity.Enabled = false;
            cb_categories.Enabled = false;
            btn_add.Enabled = true;
            btn_edit.Enabled = true;
            btn_delete.Enabled = true;
            btn_save.Enabled = false;
            btn_update.Enabled = false;
            pic_product.ImageLocation = @"D:\\BK_1302\\quanLySanPham\\Resources\\download.jpg";


        }
        private void btn_reset_data_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void LoadCategories()
        {
            var list_cate = new List<object>();
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                string sql = "SELECT cate_id, cate_name FROM categories";
                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string cate_id = reader["cate_id"].ToString();
                            string cate_name = reader["cate_name"].ToString();

                            var cate_1 = new { cate_id = cate_id, cate_name = cate_name };
                            list_cate.Add(cate_1);
                        }
                    }
                }
                con.Close();
            }

            cb_categories.DisplayMember = "cate_name";
            cb_categories.ValueMember = "cate_id";
            cb_categories.DataSource = list_cate;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = false;
            btn_save.Enabled = true;
            btn_edit.Enabled = false;
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            txt_product_id.Enabled = false;
            txt_product_name.Enabled = true;
            txt_product_price.Enabled = true;
            txt_product_quantity.Enabled = true;
            cb_categories.Enabled = true;
            txt_product_id.Clear();
            txt_product_name.Clear();
            txt_product_price.Clear();
            txt_product_quantity.Clear();
            txt_picture.Clear();
            button2.Enabled = true;
            pic_product.ImageLocation = @"D:\\BK_1302\\quanLySanPham\\Resources\\download.jpg";
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try {
                String prd_name = txt_product_name.Text;
                String prd_price = txt_product_price.Text;
                String prd_quantity = txt_product_quantity.Text;
                String prd_cate = cb_categories.Text;
                String image = txt_picture.Text;
                SqlConnection con = new SqlConnection(strCon);
                
                
                if (prd_name == "" || prd_price == "" || prd_quantity == "" || prd_cate == "")
                {
                    MessageBox.Show("Nhap Thieu Thong Tin!!");
                }
                else
                {
                    string selectedIdCate = cb_categories.SelectedValue.ToString();
                    con.Open();
                    String sql_save = $"INSERT INTO product values ('{prd_name}', {prd_price},{prd_quantity} ,{selectedIdCate}, '{image}' )";
                    SqlCommand cmd = new SqlCommand(sql_save, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Da Them Thanh Cong");
                    loadData();
                    

                }
            }
            catch (Exception ex) {
                MessageBox.Show("Nhap dung so luong hoac gia tien!!");
            }
            


        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                DataGridViewRow row = this.dataGridView.SelectedRows[0];
                string prd_id = row.Cells["prd_id"].Value.ToString();
                string prd_name = row.Cells["prd_name"].Value.ToString();
                string prd_price = row.Cells["prd_price"].Value.ToString();
                string prd_quantity = row.Cells["prd_quantity"].Value.ToString();
                string cate_name = row.Cells["cate_name"].Value.ToString();
                string image = row.Cells["prd_image"].Value.ToString();

                txt_product_id.Text = prd_id;
                txt_product_name.Text = prd_name;
                txt_product_price.Text = prd_price;
                txt_product_quantity.Text = prd_quantity;
                cb_categories.Text = cate_name;
                pic_product.ImageLocation = image;
                txt_picture.Text = image;


            }
            catch (Exception ex)
            {

            }



        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = false;
            btn_save.Enabled = false;
            btn_edit.Enabled = false;
            btn_update.Enabled = true;
            btn_delete.Enabled = false;
            txt_product_id.Enabled = false;
            txt_product_name.Enabled = true;
            txt_product_price.Enabled = true;
            txt_product_quantity.Enabled = true;
            cb_categories.Enabled = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try {
                String cate_id = "";
                String prd_id = txt_product_id.Text;
                String prd_name = txt_product_name.Text;
                String prd_price = txt_product_price.Text;
                String prd_quantity = txt_product_quantity.Text;
                String prd_cate = cb_categories.Text;
                String image = txt_picture.Text;
                SqlConnection con = new SqlConnection(strCon);
                
                if (prd_name == "" || prd_price == "" || prd_quantity == "" || prd_cate == "")
                {
                    MessageBox.Show("Nhap Thieu Thong Tin!!");
                }
                else
                {
                    string selectedIdCate = cb_categories.SelectedValue.ToString();
                    con.Open();
                    String sql_save = $"UPDATE product SET prd_name = '{prd_name}', prd_price = '{prd_price}', prd_quantity ='{prd_quantity}', cate_id = '{selectedIdCate}', prd_image = '{image}' WHERE prd_id = '{prd_id}'";
                    SqlCommand cmd = new SqlCommand(sql_save, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Da Them Thanh Cong");
                    txt_product_name.Clear();
                    txt_product_price.Clear();
                    txt_product_quantity.Clear();
                    txt_picture.Clear();
                    btn_save.Enabled = false;
                    txt_product_id.Enabled = false;
                    txt_product_name.Enabled = false;
                    txt_product_price.Enabled = false;
                    txt_product_quantity.Enabled = false;
                    txt_picture.Enabled = false;
                    cb_categories.Enabled = false;
                    btn_save.Enabled = false;
                    btn_update.Enabled = false;
                    btn_add.Enabled = true;
                    btn_edit.Enabled = true;
                    btn_delete.Enabled = true;
                    loadData();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Nhap dung so luong hoac gia tien!!");
                
            }
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co chac chan muon xoa san pham nay khong??", "Xoa", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes) {
                String prd_id = txt_product_id.Text;
                SqlConnection con = new SqlConnection(strCon);
                con.Open();
                String sql_save = $"DELETE FROM product WHERE prd_id = '{prd_id}' ";
                SqlCommand cmd = new SqlCommand(sql_save, con);
                cmd.ExecuteNonQuery();
                con.Close();
                loadData();
            }
            
        }
        private void cate_management()
        {
            Application.Run(new cate());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(cate_management);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif, *.webp) | *.jpg; *.jpeg; *.png; *.gif ; *.webp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                byte[] imageData = File.ReadAllBytes(imagePath);
                pic_product.ImageLocation = imagePath;
                txt_picture.Text = imagePath;
            }
        }

        private void btn_destroy_Click(object sender, EventArgs e)
        {
            
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
            

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void thongKe_management()
        {
            Application.Run(new thongKe());
        }
        private void btn_thong_ke_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(thongKe_management);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }
    }
}
