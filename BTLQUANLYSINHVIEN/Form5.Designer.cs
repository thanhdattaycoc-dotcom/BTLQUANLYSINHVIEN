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
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.lblThongTinSinhVien = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.dateNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblDoiNgay = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(266, 326);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(111, 32);
            this.btnQuayLai.TabIndex = 8;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // lblThongTinSinhVien
            // 
            this.lblThongTinSinhVien.AutoSize = true;
            this.lblThongTinSinhVien.Location = new System.Drawing.Point(328, 9);
            this.lblThongTinSinhVien.Name = "lblThongTinSinhVien";
            this.lblThongTinSinhVien.Size = new System.Drawing.Size(117, 16);
            this.lblThongTinSinhVien.TabIndex = 10;
            this.lblThongTinSinhVien.Text = "Thông tin sinh viên";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(410, 382);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(111, 32);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa thông tin";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(48, 213);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(313, 22);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.Text = "Email";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(410, 57);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(313, 22);
            this.txtCCCD.TabIndex = 15;
            this.txtCCCD.Text = "CCCD";
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(48, 164);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(313, 22);
            this.txtSdt.TabIndex = 17;
            this.txtSdt.Text = "Số điện thoại";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(48, 110);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(313, 22);
            this.txtTen.TabIndex = 18;
            this.txtTen.Text = "Tên sinh viên";
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Location = new System.Drawing.Point(410, 164);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(313, 22);
            this.txtNoiSinh.TabIndex = 19;
            this.txtNoiSinh.Text = "Nơi sinh";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(48, 57);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(313, 22);
            this.txtMa.TabIndex = 20;
            this.txtMa.Text = "Mã sinh viên";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Location = new System.Drawing.Point(410, 107);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(313, 24);
            this.cboGioiTinh.TabIndex = 21;
            this.cboGioiTinh.Text = "Giới tính";
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.Location = new System.Drawing.Point(410, 268);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(313, 22);
            this.dateNgaySinh.TabIndex = 22;
            this.dateNgaySinh.ValueChanged += new System.EventHandler(this.dateNgaySinh_ValueChanged);
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(407, 222);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(70, 16);
            this.lblNgaySinh.TabIndex = 23;
            this.lblNgaySinh.Text = "Ngay sinh:";
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(410, 326);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(111, 32);
            this.btnCapnhat.TabIndex = 24;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(266, 382);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(111, 32);
            this.btnThoat.TabIndex = 25;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblDoiNgay
            // 
            this.lblDoiNgay.AutoSize = true;
            this.lblDoiNgay.Location = new System.Drawing.Point(263, 268);
            this.lblDoiNgay.Name = "lblDoiNgay";
            this.lblDoiNgay.Size = new System.Drawing.Size(101, 16);
            this.lblDoiNgay.TabIndex = 26;
            this.lblDoiNgay.Text = "Chọn ngày sinh:";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(675, 9);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(113, 28);
            this.btnIn.TabIndex = 27;
            this.btnIn.Text = "In thông tin";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // FormThongTinSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.lblThongTinSinhVien);
            this.Controls.Add(this.btnQuayLai);
            this.Name = "FormThongTinSinhVien";
            this.Text = "Thông tin sinh viên";
            this.Load += new System.EventHandler(this.FormThongTinSinhVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Label lblThongTinSinhVien;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtNoiSinh;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.DateTimePicker dateNgaySinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblDoiNgay;
        private System.Windows.Forms.Button btnIn;
    }
}