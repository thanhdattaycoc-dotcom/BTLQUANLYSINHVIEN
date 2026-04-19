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
            this.SuspendLayout();
            // 
            // lblDoiNgay
            // 
            this.lblDoiNgay.AutoSize = true;
            this.lblDoiNgay.Location = new System.Drawing.Point(278, 282);
            this.lblDoiNgay.Name = "lblDoiNgay";
            this.lblDoiNgay.Size = new System.Drawing.Size(101, 16);
            this.lblDoiNgay.TabIndex = 41;
            this.lblDoiNgay.Text = "Chọn ngày sinh:";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(281, 396);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(111, 32);
            this.btnThoat.TabIndex = 40;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(425, 340);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(111, 32);
            this.btnCapnhat.TabIndex = 39;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(422, 236);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(70, 16);
            this.lblNgaySinh.TabIndex = 38;
            this.lblNgaySinh.Text = "Ngay sinh:";
            this.lblNgaySinh.Click += new System.EventHandler(this.lblNgaySinh_Click_1);
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.Location = new System.Drawing.Point(425, 282);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(313, 22);
            this.dateNgaySinh.TabIndex = 37;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Location = new System.Drawing.Point(425, 121);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(313, 24);
            this.cboGioiTinh.TabIndex = 36;
            this.cboGioiTinh.Text = "Giới tính";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(63, 71);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(313, 22);
            this.txtMa.TabIndex = 35;
            this.txtMa.Text = "Mã giảng viên";
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Location = new System.Drawing.Point(425, 178);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(313, 22);
            this.txtNoiSinh.TabIndex = 34;
            this.txtNoiSinh.Text = "Nơi sinh";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(63, 124);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(313, 22);
            this.txtTen.TabIndex = 33;
            this.txtTen.Text = "Tên giảng viên";
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(63, 178);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(313, 22);
            this.txtSdt.TabIndex = 32;
            this.txtSdt.Text = "Số điện thoại";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(425, 71);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(313, 22);
            this.txtCCCD.TabIndex = 31;
            this.txtCCCD.Text = "CCCD";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(63, 227);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(313, 22);
            this.txtEmail.TabIndex = 30;
            this.txtEmail.Text = "Email";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(425, 396);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(111, 32);
            this.btnSua.TabIndex = 29;
            this.btnSua.Text = "Sửa thông tin";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lblThongTinGiangVien
            // 
            this.lblThongTinGiangVien.AutoSize = true;
            this.lblThongTinGiangVien.Location = new System.Drawing.Point(343, 23);
            this.lblThongTinGiangVien.Name = "lblThongTinGiangVien";
            this.lblThongTinGiangVien.Size = new System.Drawing.Size(127, 16);
            this.lblThongTinGiangVien.TabIndex = 28;
            this.lblThongTinGiangVien.Text = "Thông tin giảng viên";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(281, 340);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(111, 32);
            this.btnQuayLai.TabIndex = 27;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click_1);
            // 
            // FormThongTinGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}