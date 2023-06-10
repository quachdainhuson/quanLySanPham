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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace quanLySanPham
{
    public partial class cate : Form
    {
        public String strCon = "Server=NhuSonNe; Database=C1302; Trusted_Connection=true;";
        public cate()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string sql = "SELECT * FROM categories";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "categories");
            dataGridView.DataSource = dataSet.Tables["categories"].DefaultView;
            dataGridView.Columns[0].HeaderText = "Mã Danh Mục";
            dataGridView.Columns[1].HeaderText = "Tên Danh Mục";
            dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;            
            con.Close();
            txt_cate_id.Enabled = false;
            txt_cate_name.Enabled = false;
            btn_save.Enabled = false;
            btn_update.Enabled = false;
        }
        private void loadData() {
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            string sql = "SELECT * FROM categories";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "categories");
            dataGridView.DataSource = dataSet.Tables["categories"].DefaultView;
            dataGridView.Columns[0].HeaderText = "Mã Danh Mục";
            dataGridView.Columns[1].HeaderText = "Tên Danh Mục";
            dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            con.Close();
            txt_cate_id.Enabled = false;
            txt_cate_name.Enabled = false;
            btn_add.Enabled = true;
            btn_save.Enabled = false;
            btn_edit.Enabled = true;
            btn_update.Enabled = false;
            btn_delete.Enabled = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = false;
            btn_save.Enabled = true;
            btn_edit.Enabled = false;
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            txt_cate_name.Enabled = true;
            txt_cate_id.Clear();
            txt_cate_name.Clear();
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            String cate_name = txt_cate_name.Text;
            SqlConnection con = new SqlConnection(strCon);
            try {
                if (cate_name == "") {
                    MessageBox.Show("Nhập Đầy Đủ Thông Tin !!!!");
                } else {
                    con.Open();
                    string checkQuery = $"SELECT COUNT(cate_id) FROM categories WHERE cate_name = '{cate_name}'";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, con);
                    int existingCateNamet = (int)checkCommand.ExecuteScalar();
                    con.Close();
                    if (existingCateNamet > 0)
                    {
                        MessageBox.Show("Danh mục đã tồn tại!");
                    }
                    else
                    {
                        con.Open();
                        string sql = $"INSERT INTO categories values ('{cate_name}')";
                        SqlCommand command = new SqlCommand(sql, con);
                        command.ExecuteNonQuery();
                        con.Close();
                        loadData();
                    }
                }
                
                
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);    
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main main = new main();
            this.Hide();
            main.Show();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            txt_cate_name.Enabled = true;
            btn_add.Enabled = false;
            btn_save.Enabled=false;
            btn_edit.Enabled = false;
            btn_update.Enabled = true;
            btn_delete.Enabled=false;
            btn_destroy.Enabled = true;
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                DataGridViewRow row = this.dataGridView.SelectedRows[0];
                string cate_id = row.Cells["cate_id"].Value.ToString();
                string cate_name = row.Cells["cate_name"].Value.ToString();
                txt_cate_id.Text = cate_id;
                txt_cate_name.Text = cate_name;
                

            }
            catch (Exception ex)
            {

            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            String cate_name = txt_cate_name.Text;
            String cate_id = txt_cate_id.Text;
            SqlConnection con = new SqlConnection(strCon);
            try
            {
                if (cate_name == "")
                {
                    MessageBox.Show("Nhập Đầy Đủ Thông Tin !!!!");
                }
                else
                {
                    con.Open();
                    string checkQuery = $"SELECT COUNT(cate_id) FROM categories WHERE cate_name = '{cate_name}'";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, con);
                    int existingCateNamet = (int)checkCommand.ExecuteScalar();
                    con.Close();
                    if (existingCateNamet > 0)
                    {
                        MessageBox.Show("Danh mục đã tồn tại!");
                    }
                    else
                    {
                        con.Open();
                        String sql = $"UPDATE categories SET cate_name = '{cate_name}' WHERE cate_id = '{cate_id}'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cap Nhat Thanh Cong !!!");
                        loadData();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
            
            
        }

        private void btn_reset_data_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try {
                DialogResult result = MessageBox.Show("Ban co chac chan muon xoa danh muc nay khong nay khong??", "Xoa", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {

                    String cate_id = txt_cate_id.Text;
                    SqlConnection con = new SqlConnection(strCon);
                    con.Open();
                    String sql = $"DELETE FROM categories WHERE cate_id = '{cate_id}'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cap Nhat Thanh Cong !!!");
                    loadData();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Danh Muc Nay co the ton tai san pham!!");
            }
            
            
        }

        private void btn_destroy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
