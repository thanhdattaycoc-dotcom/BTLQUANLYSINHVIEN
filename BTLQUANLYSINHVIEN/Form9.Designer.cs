namespace BTLQUANLYSINHVIEN
{
    partial class FormThongTinGiangVien
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
            this.lblThongTinCaNhan = new System.Windows.Forms.Label();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNoiSinh = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblMaGiangVien = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblThongTinCaNhan
            // 
            this.lblThongTinCaNhan.AutoSize = true;
            this.lblThongTinCaNhan.Location = new System.Drawing.Point(252, 39);
            this.lblThongTinCaNhan.Name = "lblThongTinCaNhan";
            this.lblThongTinCaNhan.Size = new System.Drawing.Size(127, 16);
            this.lblThongTinCaNhan.TabIndex = 0;
            this.lblThongTinCaNhan.Text = "Thông tin giảng viên";
            this.lblThongTinCaNhan.Click += new System.EventHandler(this.lblThongTinCaNhan_Click);
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Location = new System.Drawing.Point(369, 153);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(44, 16);
            this.lblCCCD.TabIndex = 5;
            this.lblCCCD.Text = "CCCD";
            this.lblCCCD.Click += new System.EventHandler(this.lblCCCD_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(297, 369);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(82, 32);
            this.btnQuayLai.TabIndex = 9;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(84, 99);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(52, 16);
            this.lblHoTen.TabIndex = 10;
            this.lblHoTen.Text = "Họ tên: ";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(84, 153);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(73, 16);
            this.lblNgaySinh.TabIndex = 11;
            this.lblNgaySinh.Text = "Ngày sinh: ";
            this.lblNgaySinh.Click += new System.EventHandler(this.lblNgaySinh_Click);
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(84, 207);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(54, 16);
            this.lblGioiTinh.TabIndex = 12;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // lblNoiSinh
            // 
            this.lblNoiSinh.AutoSize = true;
            this.lblNoiSinh.Location = new System.Drawing.Point(84, 252);
            this.lblNoiSinh.Name = "lblNoiSinh";
            this.lblNoiSinh.Size = new System.Drawing.Size(61, 16);
            this.lblNoiSinh.TabIndex = 13;
            this.lblNoiSinh.Text = "Nơi sinh: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(366, 252);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 16);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email: ";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(366, 207);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(85, 16);
            this.lblSDT.TabIndex = 15;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // lblMaGiangVien
            // 
            this.lblMaGiangVien.AutoSize = true;
            this.lblMaGiangVien.Location = new System.Drawing.Point(369, 99);
            this.lblMaGiangVien.Name = "lblMaGiangVien";
            this.lblMaGiangVien.Size = new System.Drawing.Size(94, 16);
            this.lblMaGiangVien.TabIndex = 16;
            this.lblMaGiangVien.Text = "Mã giảng viên:";
            this.lblMaGiangVien.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormThongTinGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMaGiangVien);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNoiSinh);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.lblCCCD);
            this.Controls.Add(this.lblThongTinCaNhan);
            this.Name = "FormThongTinGiangVien";
            this.Text = "Thông tin giảng viên";
            this.Load += new System.EventHandler(this.FormThongTinGiangVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongTinCaNhan;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNoiSinh;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblMaGiangVien;
    }
}