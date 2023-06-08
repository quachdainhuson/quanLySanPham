namespace quanLySanPham
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_product_quantity = new System.Windows.Forms.TextBox();
            this.txt_product_price = new System.Windows.Forms.TextBox();
            this.cb_categories = new System.Windows.Forms.ComboBox();
            this.txt_product_name = new System.Windows.Forms.TextBox();
            this.txt_product_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pic_product = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btn_reset_data = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_destroy = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.edit_function = new System.Windows.Forms.GroupBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.create_function = new System.Windows.Forms.GroupBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_picture = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.edit_function.SuspendLayout();
            this.create_function.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Red;
            this.title.Location = new System.Drawing.Point(225, 27);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(715, 55);
            this.title.TabIndex = 0;
            this.title.Text = "Phần Mềm Quản Lý Sản Phẩm";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txt_product_quantity);
            this.groupBox1.Controls.Add(this.txt_product_price);
            this.groupBox1.Controls.Add(this.cb_categories);
            this.groupBox1.Controls.Add(this.txt_product_name);
            this.groupBox1.Controls.Add(this.txt_product_id);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pic_product);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(63, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 276);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sản Phẩm";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(400, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Chọn Ảnh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_product_quantity
            // 
            this.txt_product_quantity.Location = new System.Drawing.Point(110, 246);
            this.txt_product_quantity.Name = "txt_product_quantity";
            this.txt_product_quantity.Size = new System.Drawing.Size(146, 20);
            this.txt_product_quantity.TabIndex = 10;
            // 
            // txt_product_price
            // 
            this.txt_product_price.Location = new System.Drawing.Point(61, 163);
            this.txt_product_price.Name = "txt_product_price";
            this.txt_product_price.Size = new System.Drawing.Size(135, 20);
            this.txt_product_price.TabIndex = 9;
            // 
            // cb_categories
            // 
            this.cb_categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_categories.FormattingEnabled = true;
            this.cb_categories.Location = new System.Drawing.Point(110, 201);
            this.cb_categories.Name = "cb_categories";
            this.cb_categories.Size = new System.Drawing.Size(146, 21);
            this.cb_categories.TabIndex = 8;
            // 
            // txt_product_name
            // 
            this.txt_product_name.Location = new System.Drawing.Point(18, 116);
            this.txt_product_name.Name = "txt_product_name";
            this.txt_product_name.Size = new System.Drawing.Size(319, 20);
            this.txt_product_name.TabIndex = 7;
            // 
            // txt_product_id
            // 
            this.txt_product_id.Location = new System.Drawing.Point(131, 41);
            this.txt_product_id.Name = "txt_product_id";
            this.txt_product_id.Size = new System.Drawing.Size(206, 20);
            this.txt_product_id.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã Sản Phẩm :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Danh Mục :";
            // 
            // pic_product
            // 
            this.pic_product.Location = new System.Drawing.Point(400, 39);
            this.pic_product.Name = "pic_product";
            this.pic_product.Size = new System.Drawing.Size(242, 219);
            this.pic_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_product.TabIndex = 5;
            this.pic_product.TabStop = false;
            this.pic_product.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Lượng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sản Phẩm :";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(63, 367);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1016, 195);
            this.dataGridView.TabIndex = 6;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // btn_reset_data
            // 
            this.btn_reset_data.Location = new System.Drawing.Point(164, 15);
            this.btn_reset_data.Name = "btn_reset_data";
            this.btn_reset_data.Size = new System.Drawing.Size(106, 31);
            this.btn_reset_data.TabIndex = 7;
            this.btn_reset_data.Text = "Làm Mới";
            this.btn_reset_data.UseVisualStyleBackColor = true;
            this.btn_reset_data.Click += new System.EventHandler(this.btn_reset_data_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_exit);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.edit_function);
            this.groupBox2.Controls.Add(this.create_function);
            this.groupBox2.Location = new System.Drawing.Point(742, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 275);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.btn_destroy);
            this.groupBox6.Location = new System.Drawing.Point(26, 206);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(291, 51);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chức năng Khác";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(52, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "Quản Lý Danh Mục";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_destroy
            // 
            this.btn_destroy.Location = new System.Drawing.Point(164, 13);
            this.btn_destroy.Name = "btn_destroy";
            this.btn_destroy.Size = new System.Drawing.Size(106, 32);
            this.btn_destroy.TabIndex = 12;
            this.btn_destroy.Text = "Đăng Xuất";
            this.btn_destroy.UseVisualStyleBackColor = true;
            this.btn_destroy.Click += new System.EventHandler(this.btn_destroy_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_delete);
            this.groupBox5.Controls.Add(this.btn_reset_data);
            this.groupBox5.Location = new System.Drawing.Point(26, 148);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(291, 51);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Xóa";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(52, 14);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(106, 32);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // edit_function
            // 
            this.edit_function.Controls.Add(this.btn_update);
            this.edit_function.Controls.Add(this.btn_edit);
            this.edit_function.Location = new System.Drawing.Point(26, 91);
            this.edit_function.Name = "edit_function";
            this.edit_function.Size = new System.Drawing.Size(291, 51);
            this.edit_function.TabIndex = 1;
            this.edit_function.TabStop = false;
            this.edit_function.Text = "Sửa";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(164, 12);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(106, 32);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "Cập Nhật";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(52, 12);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(106, 32);
            this.btn_edit.TabIndex = 10;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // create_function
            // 
            this.create_function.Controls.Add(this.btn_save);
            this.create_function.Controls.Add(this.btn_add);
            this.create_function.Location = new System.Drawing.Point(26, 34);
            this.create_function.Name = "create_function";
            this.create_function.Size = new System.Drawing.Size(291, 51);
            this.create_function.TabIndex = 0;
            this.create_function.TabStop = false;
            this.create_function.Text = "Thêm ";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(164, 13);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(106, 32);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(52, 13);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(106, 32);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_picture
            // 
            this.txt_picture.Location = new System.Drawing.Point(575, 98);
            this.txt_picture.Name = "txt_picture";
            this.txt_picture.Size = new System.Drawing.Size(130, 20);
            this.txt_picture.TabIndex = 11;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(242, 10);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1162, 593);
            this.Controls.Add(this.txt_picture);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.title);
            this.Name = "main";
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.edit_function.ResumeLayout(false);
            this.create_function.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pic_product;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_product_name;
        private System.Windows.Forms.TextBox txt_product_id;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_reset_data;
        private System.Windows.Forms.TextBox txt_product_quantity;
        private System.Windows.Forms.TextBox txt_product_price;
        private System.Windows.Forms.ComboBox cb_categories;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.GroupBox edit_function;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.GroupBox create_function;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_destroy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_picture;
        private System.Windows.Forms.Button btn_exit;
    }
}