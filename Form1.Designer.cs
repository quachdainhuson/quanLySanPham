namespace quanLySanPham
{
    partial class Form1
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
            this.lb_dangki = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_account = new System.Windows.Forms.TextBox();
            this.lb_pass = new System.Windows.Forms.Label();
            this.lb_account = new System.Windows.Forms.Label();
            this.lb_login = new System.Windows.Forms.Label();
            this.btn_login_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_dangki
            // 
            this.lb_dangki.AutoSize = true;
            this.lb_dangki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dangki.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lb_dangki.Location = new System.Drawing.Point(432, 278);
            this.lb_dangki.Name = "lb_dangki";
            this.lb_dangki.Size = new System.Drawing.Size(63, 20);
            this.lb_dangki.TabIndex = 13;
            this.lb_dangki.TabStop = true;
            this.lb_dangki.Text = "Đăng kí";
            this.lb_dangki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_dangki_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "Đăng Nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(264, 197);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '@';
            this.txt_pass.Size = new System.Drawing.Size(245, 20);
            this.txt_pass.TabIndex = 11;
            this.txt_pass.TextChanged += new System.EventHandler(this.txt_pass_TextChanged);
            // 
            // txt_account
            // 
            this.txt_account.Location = new System.Drawing.Point(264, 136);
            this.txt_account.Name = "txt_account";
            this.txt_account.Size = new System.Drawing.Size(245, 20);
            this.txt_account.TabIndex = 10;
            this.txt_account.TextChanged += new System.EventHandler(this.txt_account_TextChanged);
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pass.Location = new System.Drawing.Point(141, 195);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(95, 20);
            this.lb_pass.TabIndex = 9;
            this.lb_pass.Text = "Mật Khẩu: ";
            this.lb_pass.Click += new System.EventHandler(this.lb_pass_Click);
            // 
            // lb_account
            // 
            this.lb_account.AutoSize = true;
            this.lb_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_account.Location = new System.Drawing.Point(141, 134);
            this.lb_account.Name = "lb_account";
            this.lb_account.Size = new System.Drawing.Size(104, 20);
            this.lb_account.TabIndex = 8;
            this.lb_account.Text = "Tài Khoản : ";
            this.lb_account.Click += new System.EventHandler(this.lb_account_Click);
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_login.Location = new System.Drawing.Point(257, 59);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(217, 42);
            this.lb_login.TabIndex = 7;
            this.lb_login.Text = "Đăng Nhập";
            this.lb_login.Click += new System.EventHandler(this.lb_login_Click);
            // 
            // btn_login_exit
            // 
            this.btn_login_exit.Location = new System.Drawing.Point(549, 59);
            this.btn_login_exit.Name = "btn_login_exit";
            this.btn_login_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_login_exit.TabIndex = 14;
            this.btn_login_exit.Text = "Thoats";
            this.btn_login_exit.UseVisualStyleBackColor = true;
            this.btn_login_exit.Click += new System.EventHandler(this.btn_login_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 370);
            this.Controls.Add(this.btn_login_exit);
            this.Controls.Add(this.lb_dangki);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_account);
            this.Controls.Add(this.lb_pass);
            this.Controls.Add(this.lb_account);
            this.Controls.Add(this.lb_login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lb_dangki;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_account;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.Label lb_account;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.Button btn_login_exit;
    }
}

