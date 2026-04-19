namespace BTLQUANLYSINHVIEN
{
    partial class FormTrangChuSinhVien
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
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnLichHoc = new System.Windows.Forms.Button();
            this.btnDangKyLop = new System.Windows.Forms.Button();
            this.btnXemDiem = new System.Windows.Forms.Button();
            this.lblSinhVien = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(91, 103);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(301, 131);
            this.btnHienThi.TabIndex = 0;
            this.btnHienThi.Text = "Hiển thị thông tin cá nhân";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnLichHoc
            // 
            this.btnLichHoc.Location = new System.Drawing.Point(450, 103);
            this.btnLichHoc.Name = "btnLichHoc";
            this.btnLichHoc.Size = new System.Drawing.Size(301, 131);
            this.btnLichHoc.TabIndex = 1;
            this.btnLichHoc.Text = "Xem lịch học";
            this.btnLichHoc.UseVisualStyleBackColor = true;
            this.btnLichHoc.Click += new System.EventHandler(this.btnLichHoc_Click);
            // 
            // btnDangKyLop
            // 
            this.btnDangKyLop.Location = new System.Drawing.Point(450, 269);
            this.btnDangKyLop.Name = "btnDangKyLop";
            this.btnDangKyLop.Size = new System.Drawing.Size(301, 131);
            this.btnDangKyLop.TabIndex = 2;
            this.btnDangKyLop.Text = "Đăng ký lớp";
            this.btnDangKyLop.UseVisualStyleBackColor = true;
            this.btnDangKyLop.Click += new System.EventHandler(this.btnDangKyLop_Click);
            // 
            // btnXemDiem
            // 
            this.btnXemDiem.Location = new System.Drawing.Point(91, 269);
            this.btnXemDiem.Name = "btnXemDiem";
            this.btnXemDiem.Size = new System.Drawing.Size(301, 131);
            this.btnXemDiem.TabIndex = 3;
            this.btnXemDiem.Text = "Xem điểm học tập";
            this.btnXemDiem.UseVisualStyleBackColor = true;
            this.btnXemDiem.Click += new System.EventHandler(this.btnXemDiem_Click);
            // 
            // lblSinhVien
            // 
            this.lblSinhVien.AutoSize = true;
            this.lblSinhVien.Location = new System.Drawing.Point(31, 24);
            this.lblSinhVien.Name = "lblSinhVien";
            this.lblSinhVien.Size = new System.Drawing.Size(87, 16);
            this.lblSinhVien.TabIndex = 4;
            this.lblSinhVien.Text = "Mã sinh viên: ";
            this.lblSinhVien.Click += new System.EventHandler(this.lblSinhVien_Click);
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(31, 62);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(92, 16);
            this.lblTen.TabIndex = 5;
            this.lblTen.Text = "Tên sinh viên: ";
            // 
            // FormTrangChuSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblSinhVien);
            this.Controls.Add(this.btnXemDiem);
            this.Controls.Add(this.btnDangKyLop);
            this.Controls.Add(this.btnLichHoc);
            this.Controls.Add(this.btnHienThi);
            this.Name = "FormTrangChuSinhVien";
            this.Text = "Trang chủ sinh viên";
            this.Load += new System.EventHandler(this.FormTrangChuSinhVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnLichHoc;
        private System.Windows.Forms.Button btnDangKyLop;
        private System.Windows.Forms.Button btnXemDiem;
        private System.Windows.Forms.Label lblSinhVien;
        private System.Windows.Forms.Label lblTen;
    }
}