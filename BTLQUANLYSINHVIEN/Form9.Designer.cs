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
            this.lblDoiNgay = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dateNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.lblThongTinGiangVien = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDoiNgay
            // 
            this.lblDoiNgay.AutoSize = true;
            this.lblDoiNgay.Location = new System.Drawing.Point(208, 229);
            this.lblDoiNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDoiNgay.Name = "lblDoiNgay";
            this.lblDoiNgay.Size = new System.Drawing.Size(83, 13);
            this.lblDoiNgay.TabIndex = 41;
            this.lblDoiNgay.Text = "Chọn ngày sinh:";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(211, 322);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(83, 26);
            this.btnThoat.TabIndex = 40;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(319, 276);
            this.btnCapnhat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(83, 26);
            this.btnCapnhat.TabIndex = 39;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(316, 192);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(57, 13);
            this.lblNgaySinh.TabIndex = 38;
            this.lblNgaySinh.Text = "Ngay sinh:";
            this.lblNgaySinh.Click += new System.EventHandler(this.lblNgaySinh_Click_1);
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.Location = new System.Drawing.Point(319, 229);
            this.dateNgaySinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(236, 20);
            this.dateNgaySinh.TabIndex = 37;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Location = new System.Drawing.Point(319, 98);
            this.cboGioiTinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(236, 21);
            this.cboGioiTinh.TabIndex = 36;
            this.cboGioiTinh.Text = "Giới tính";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(47, 58);
            this.txtMa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(236, 20);
            this.txtMa.TabIndex = 35;
            this.txtMa.Text = "Mã giảng viên";
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Location = new System.Drawing.Point(319, 145);
            this.txtNoiSinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(236, 20);
            this.txtNoiSinh.TabIndex = 34;
            this.txtNoiSinh.Text = "Nơi sinh";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(47, 101);
            this.txtTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(236, 20);
            this.txtTen.TabIndex = 33;
            this.txtTen.Text = "Tên giảng viên";
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(47, 145);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(236, 20);
            this.txtSdt.TabIndex = 32;
            this.txtSdt.Text = "Số điện thoại";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(319, 58);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(236, 20);
            this.txtCCCD.TabIndex = 31;
            this.txtCCCD.Text = "CCCD";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(47, 184);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(236, 20);
            this.txtEmail.TabIndex = 30;
            this.txtEmail.Text = "Email";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(319, 322);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(83, 26);
            this.btnSua.TabIndex = 29;
            this.btnSua.Text = "Sửa thông tin";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lblThongTinGiangVien
            // 
            this.lblThongTinGiangVien.AutoSize = true;
            this.lblThongTinGiangVien.Location = new System.Drawing.Point(257, 19);
            this.lblThongTinGiangVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThongTinGiangVien.Name = "lblThongTinGiangVien";
            this.lblThongTinGiangVien.Size = new System.Drawing.Size(104, 13);
            this.lblThongTinGiangVien.TabIndex = 28;
            this.lblThongTinGiangVien.Text = "Thông tin giảng viên";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(211, 276);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(83, 26);
            this.btnQuayLai.TabIndex = 27;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click_1);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(470, 14);
            this.btnIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(85, 23);
            this.btnIn.TabIndex = 42;
            this.btnIn.Text = "In thông tin";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // FormThongTinGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.lblDoiNgay);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.dateNgaySinh);
            this.Controls.Add(this.cboGioiTinh);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.txtNoiSinh);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.lblThongTinGiangVien);
            this.Controls.Add(this.btnQuayLai);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormThongTinGiangVien";
            this.Text = "Thông tin giảng viên";
            this.Load += new System.EventHandler(this.FormThongTinGiangVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDoiNgay;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dateNgaySinh;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtNoiSinh;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label lblThongTinGiangVien;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnIn;
    }
}