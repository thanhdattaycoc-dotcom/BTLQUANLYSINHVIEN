namespace BTLQUANLYSINHVIEN
{
    partial class FormThongTinSinhVien
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
            this.lblMaSinhVien = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNoiSinh = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.lblThongTinSinhVien = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMaSinhVien
            // 
            this.lblMaSinhVien.AutoSize = true;
            this.lblMaSinhVien.Location = new System.Drawing.Point(63, 72);
            this.lblMaSinhVien.Name = "lblMaSinhVien";
            this.lblMaSinhVien.Size = new System.Drawing.Size(85, 16);
            this.lblMaSinhVien.TabIndex = 1;
            this.lblMaSinhVien.Text = "Mã Sinh Viên";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(63, 116);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(52, 16);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ tên: ";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(63, 160);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(73, 16);
            this.lblNgaySinh.TabIndex = 3;
            this.lblNgaySinh.Text = "Ngày sinh: ";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(63, 206);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(54, 16);
            this.lblGioiTinh.TabIndex = 4;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(63, 248);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 16);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email: ";
            // 
            // lblNoiSinh
            // 
            this.lblNoiSinh.AutoSize = true;
            this.lblNoiSinh.Location = new System.Drawing.Point(63, 334);
            this.lblNoiSinh.Name = "lblNoiSinh";
            this.lblNoiSinh.Size = new System.Drawing.Size(61, 16);
            this.lblNoiSinh.TabIndex = 6;
            this.lblNoiSinh.Text = "Nơi sinh: ";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(63, 289);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(85, 16);
            this.lblSDT.TabIndex = 7;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(334, 386);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(82, 32);
            this.btnQuayLai.TabIndex = 8;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // lblThongTinSinhVien
            // 
            this.lblThongTinSinhVien.AutoSize = true;
            this.lblThongTinSinhVien.Location = new System.Drawing.Point(255, 33);
            this.lblThongTinSinhVien.Name = "lblThongTinSinhVien";
            this.lblThongTinSinhVien.Size = new System.Drawing.Size(117, 16);
            this.lblThongTinSinhVien.TabIndex = 10;
            this.lblThongTinSinhVien.Text = "Thông tin sinh viên";
            // 
            // FormThongTinSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblThongTinSinhVien);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblNoiSinh);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMaSinhVien);
            this.Name = "FormThongTinSinhVien";
            this.Text = "Thông tin sinh viên";
            this.Load += new System.EventHandler(this.FormThongTinSinhVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMaSinhVien;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNoiSinh;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Label lblThongTinSinhVien;
    }
}