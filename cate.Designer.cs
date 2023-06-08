namespace quanLySanPham
{
    partial class cate
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_destroy = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_reset_data = new System.Windows.Forms.Button();
            this.edit_function = new System.Windows.Forms.GroupBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.create_function = new System.Windows.Forms.GroupBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_cate_name = new System.Windows.Forms.TextBox();
            this.txt_cate_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.edit_function.SuspendLayout();
            this.create_function.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.edit_function);
            this.groupBox2.Controls.Add(this.create_function);
            this.groupBox2.Location = new System.Drawing.Point(718, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 275);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
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
            this.button1.Text = "Quản Lý Sản Phẩm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_destroy
            // 
            this.btn_destroy.Location = new System.Drawing.Point(164, 14);
            this.btn_destroy.Name = "btn_destroy";
            this.btn_destroy.Size = new System.Drawing.Size(106, 32);
            this.btn_destroy.TabIndex = 12;
            this.btn_destroy.Text = "Thoát";
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
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(39, 357);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1016, 195);
            this.dataGridView.TabIndex = 11;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.txt_cate_name);
            this.groupBox1.Controls.Add(this.txt_cate_id);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(39, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 276);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sản Phẩm";
            // 
            // txt_cate_name
            // 
            this.txt_cate_name.Location = new System.Drawing.Point(131, 84);
            this.txt_cate_name.Name = "txt_cate_name";
            this.txt_cate_name.Size = new System.Drawing.Size(319, 20);
            this.txt_cate_name.TabIndex = 7;
            // 
            // txt_cate_id
            // 
            this.txt_cate_id.Location = new System.Drawing.Point(131, 41);
            this.txt_cate_id.Name = "txt_cate_id";
            this.txt_cate_id.Size = new System.Drawing.Size(206, 20);
            this.txt_cate_id.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã Danh Mục :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Mục :";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Red;
            this.title.Location = new System.Drawing.Point(201, 17);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(455, 55);
            this.title.TabIndex = 9;
            this.title.Text = "Quản Lý Danh Mục";
            // 
            // cate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 568);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.title);
            this.Name = "cate";
            this.Text = "cate";
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.edit_function.ResumeLayout(false);
            this.create_function.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_destroy;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_reset_data;
        private System.Windows.Forms.GroupBox edit_function;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.GroupBox create_function;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_cate_name;
        private System.Windows.Forms.TextBox txt_cate_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title;
    }
}