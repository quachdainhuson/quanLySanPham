namespace quanLySanPham
{
    partial class thongKe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tongSanPhamTheoDanhMuc = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tongSanPhamTheoDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(145, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tổng Sản Phẩm :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(329, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(465, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tổng Sản Phẩm Theo Danh Mục";
            // 
            // tongSanPhamTheoDanhMuc
            // 
            this.tongSanPhamTheoDanhMuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tongSanPhamTheoDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tongSanPhamTheoDanhMuc.Location = new System.Drawing.Point(217, 314);
            this.tongSanPhamTheoDanhMuc.Name = "tongSanPhamTheoDanhMuc";
            this.tongSanPhamTheoDanhMuc.Size = new System.Drawing.Size(651, 200);
            this.tongSanPhamTheoDanhMuc.TabIndex = 8;
            this.tongSanPhamTheoDanhMuc.SelectionChanged += new System.EventHandler(this.tongSanPhamTheoDanhMuc_SelectionChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Red;
            this.title.Location = new System.Drawing.Point(274, 52);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(502, 55);
            this.title.TabIndex = 9;
            this.title.Text = "Thống Kê  Sản Phẩm";
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.Location = new System.Drawing.Point(406, 188);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(92, 31);
            this.lb_total.TabIndex = 10;
            this.lb_total.Text = "label3";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(913, 77);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(98, 29);
            this.btn_back.TabIndex = 11;
            this.btn_back.Text = "Trở Về";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // thongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 565);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.title);
            this.Controls.Add(this.tongSanPhamTheoDanhMuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "thongKe";
            this.Text = "thongKe";
            ((System.ComponentModel.ISupportInitialize)(this.tongSanPhamTheoDanhMuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tongSanPhamTheoDanhMuc;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Button btn_back;
    }
}