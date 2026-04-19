namespace BTLQUANLYSINHVIEN
{
    partial class FormDangKy
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblXacNhanMatKhau = new System.Windows.Forms.Label();
            this.txtMaNguoiDung = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtXacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.btlDangKy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDaCoTaiKhoan = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaNguoiDung
            // 
            this.lblMaNguoiDung.AutoSize = true;
            this.lblMaNguoiDung.Location = new System.Drawing.Point(59, 95);
            this.lblMaNguoiDung.Name = "lblMaNguoiDung";
            this.lblMaNguoiDung.Size = new System.Drawing.Size(95, 16);
            this.lblMaNguoiDung.TabIndex = 0;
            this.lblMaNguoiDung.Text = "Mã người dùng";
            this.lblMaNguoiDung.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AllowDrop = true;
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(59, 136);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(64, 16);
            this.lblMatKhau.TabIndex = 3;
            this.lblMatKhau.Text = "Mật khẩu ";
            this.lblMatKhau.Click += new System.EventHandler(this.lblMatKhau_Click);
            // 
            // lblXacNhanMatKhau
            // 
            this.lblXacNhanMatKhau.AutoSize = true;
            this.lblXacNhanMatKhau.Location = new System.Drawing.Point(59, 185);
            this.lblXacNhanMatKhau.Name = "lblXacNhanMatKhau";
            this.lblXacNhanMatKhau.Size = new System.Drawing.Size(119, 16);
            this.lblXacNhanMatKhau.TabIndex = 4;
            this.lblXacNhanMatKhau.Text = "Xác nhận mật khẩu";
            this.lblXacNhanMatKhau.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtMaNguoiDung
            // 
            this.txtMaNguoiDung.Location = new System.Drawing.Point(246, 92);
            this.txtMaNguoiDung.Name = "txtMaNguoiDung";
            this.txtMaNguoiDung.Size = new System.Drawing.Size(372, 22);
            this.txtMaNguoiDung.TabIndex = 5;
            this.txtMaNguoiDung.TextChanged += new System.EventHandler(this.txtMaNguoiDung_TextChanged);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(246, 130);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(372, 22);
            this.txtMatKhau.TabIndex = 7;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            // 
            // txtXacNhanMatKhau
            // 
            this.txtXacNhanMatKhau.Location = new System.Drawing.Point(246, 179);
            this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            this.txtXacNhanMatKhau.Size = new System.Drawing.Size(372, 22);
            this.txtXacNhanMatKhau.TabIndex = 8;
            this.txtXacNhanMatKhau.TextChanged += new System.EventHandler(this.txtXacNhanMatKhau_TextChanged);
            // 
            // btlDangKy
            // 
            this.btlDangKy.Location = new System.Drawing.Point(293, 288);
            this.btlDangKy.Name = "btlDangKy";
            this.btlDangKy.Size = new System.Drawing.Size(162, 40);
            this.btlDangKy.TabIndex = 9;
            this.btlDangKy.Text = "Đăng Ký";
            this.btlDangKy.UseVisualStyleBackColor = true;
            this.btlDangKy.Click += new System.EventHandler(this.btlDangKy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 10;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblDaCoTaiKhoan
            // 
            this.lblDaCoTaiKhoan.AutoSize = true;
            this.lblDaCoTaiKhoan.Location = new System.Drawing.Point(323, 342);
            this.lblDaCoTaiKhoan.Name = "lblDaCoTaiKhoan";
            this.lblDaCoTaiKhoan.Size = new System.Drawing.Size(106, 16);
            this.lblDaCoTaiKhoan.TabIndex = 13;
            this.lblDaCoTaiKhoan.Text = "Đã có tài khoản?";
            this.lblDaCoTaiKhoan.Click += new System.EventHandler(this.lblDaCoTaiKhoan_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(293, 373);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(162, 40);
            this.btnDangNhap.TabIndex = 14;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // FormDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.lblDaCoTaiKhoan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btlDangKy);
            this.Controls.Add(this.txtXacNhanMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtMaNguoiDung);
            this.Controls.Add(this.lblXacNhanMatKhau);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMaNguoiDung);
            this.Name = "FormDangKy";
            this.Text = "DangKy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaNguoiDung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblXacNhanMatKhau;
        private System.Windows.Forms.TextBox txtMaNguoiDung;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtXacNhanMatKhau;
        private System.Windows.Forms.Button btlDangKy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDaCoTaiKhoan;
        private System.Windows.Forms.Button btnDangNhap;
    }
}

