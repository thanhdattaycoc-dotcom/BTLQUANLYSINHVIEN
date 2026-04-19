namespace BTLQUANLYSINHVIEN
{
    partial class FormDangNhap
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
            this.lblMaNguoiDung = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtMaNguoiDung = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btlDangKy = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.lblChuaCoTaiKhoan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMaNguoiDung
            // 
            this.lblMaNguoiDung.AutoSize = true;
            this.lblMaNguoiDung.Location = new System.Drawing.Point(71, 79);
            this.lblMaNguoiDung.Name = "lblMaNguoiDung";
            this.lblMaNguoiDung.Size = new System.Drawing.Size(95, 16);
            this.lblMaNguoiDung.TabIndex = 1;
            this.lblMaNguoiDung.Text = "Mã người dùng";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AllowDrop = true;
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(71, 130);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(64, 16);
            this.lblMatKhau.TabIndex = 4;
            this.lblMatKhau.Text = "Mật khẩu ";
            // 
            // txtMaNguoiDung
            // 
            this.txtMaNguoiDung.Location = new System.Drawing.Point(232, 76);
            this.txtMaNguoiDung.Name = "txtMaNguoiDung";
            this.txtMaNguoiDung.Size = new System.Drawing.Size(372, 22);
            this.txtMaNguoiDung.TabIndex = 14;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(232, 127);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(372, 22);
            this.txtMatKhau.TabIndex = 15;
            // 
            // btlDangKy
            // 
            this.btlDangKy.Location = new System.Drawing.Point(302, 376);
            this.btlDangKy.Name = "btlDangKy";
            this.btlDangKy.Size = new System.Drawing.Size(162, 40);
            this.btlDangKy.TabIndex = 18;
            this.btlDangKy.Text = "Đăng Ký";
            this.btlDangKy.UseVisualStyleBackColor = true;
            this.btlDangKy.Click += new System.EventHandler(this.btlDangKy_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(302, 283);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(162, 40);
            this.btnDangNhap.TabIndex = 19;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // lblChuaCoTaiKhoan
            // 
            this.lblChuaCoTaiKhoan.AutoSize = true;
            this.lblChuaCoTaiKhoan.Location = new System.Drawing.Point(335, 341);
            this.lblChuaCoTaiKhoan.Name = "lblChuaCoTaiKhoan";
            this.lblChuaCoTaiKhoan.Size = new System.Drawing.Size(120, 16);
            this.lblChuaCoTaiKhoan.TabIndex = 20;
            this.lblChuaCoTaiKhoan.Text = "Chưa có tài khoản?";
            this.lblChuaCoTaiKhoan.Click += new System.EventHandler(this.lblDaCoTaiKhoan_Click);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblChuaCoTaiKhoan);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.btlDangKy);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtMaNguoiDung);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblMaNguoiDung);
            this.Name = "FormDangNhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaNguoiDung;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtMaNguoiDung;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btlDangKy;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label lblChuaCoTaiKhoan;
    }
}