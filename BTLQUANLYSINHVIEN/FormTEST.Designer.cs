namespace BTLQUANLYSINHVIEN
{
    partial class FormTEST
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
            this.cachedrptDanhSachLopDangKy1 = new BTLQUANLYSINHVIEN.CachedrptDanhSachLopDangKy();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lblSonamcantim = new System.Windows.Forms.Label();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblNoiSinh = new System.Windows.Forms.Label();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.lblSoNam = new System.Windows.Forms.Label();
            this.txtSonam = new System.Windows.Forms.TextBox();
            this.txtSonamMuonTim = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(530, 188);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(82, 23);
            this.btnQuayLai.TabIndex = 21;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1144, 175);
            this.dataGridView1.TabIndex = 20;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(31, 189);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 22);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(158, 188);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 23);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(758, 138);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(108, 23);
            this.btnTimKiem.TabIndex = 17;
            this.btnTimKiem.Text = "Tìm kiếm ";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lblSonamcantim
            // 
            this.lblSonamcantim.AutoSize = true;
            this.lblSonamcantim.Location = new System.Drawing.Point(651, 191);
            this.lblSonamcantim.Name = "lblSonamcantim";
            this.lblSonamcantim.Size = new System.Drawing.Size(98, 16);
            this.lblSonamcantim.TabIndex = 15;
            this.lblSonamcantim.Text = "So nam can tim";
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Location = new System.Drawing.Point(391, 117);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(44, 16);
            this.lblCCCD.TabIndex = 40;
            this.lblCCCD.Text = "CCCD";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(495, 107);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(201, 22);
            this.txtCCCD.TabIndex = 39;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Location = new System.Drawing.Point(104, 114);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(225, 24);
            this.cboGioiTinh.TabIndex = 38;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(104, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(225, 22);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Location = new System.Drawing.Point(493, 69);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(203, 22);
            this.txtNoiSinh.TabIndex = 33;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(495, 34);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(201, 22);
            this.txtSoDienThoai.TabIndex = 32;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(493, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(203, 22);
            this.txtEmail.TabIndex = 31;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(104, 44);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(218, 22);
            this.txtTenSV.TabIndex = 30;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(104, 12);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(218, 22);
            this.txtMaSV.TabIndex = 29;
            // 
            // lblNoiSinh
            // 
            this.lblNoiSinh.AutoSize = true;
            this.lblNoiSinh.Location = new System.Drawing.Point(391, 72);
            this.lblNoiSinh.Name = "lblNoiSinh";
            this.lblNoiSinh.Size = new System.Drawing.Size(63, 16);
            this.lblNoiSinh.TabIndex = 28;
            this.lblNoiSinh.Text = "Nơi Sinh :";
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Location = new System.Drawing.Point(391, 40);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(98, 16);
            this.lblSoDienThoai.TabIndex = 27;
            this.lblSoDienThoai.Text = "Só Điện Thoại :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(391, 9);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 16);
            this.lblEmail.TabIndex = 26;
            this.lblEmail.Text = "Email :";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(25, 114);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(66, 16);
            this.lblGioiTinh.TabIndex = 25;
            this.lblGioiTinh.Text = "Giới Tính :";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(25, 81);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(75, 16);
            this.lblNgaySinh.TabIndex = 24;
            this.lblNgaySinh.Text = "Ngày Sinh :";
            // 
            // lblTenSV
            // 
            this.lblTenSV.AutoSize = true;
            this.lblTenSV.Location = new System.Drawing.Point(25, 47);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(58, 16);
            this.lblTenSV.TabIndex = 23;
            this.lblTenSV.Text = "Tên SV :";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(25, 18);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(53, 16);
            this.lblMaSV.TabIndex = 22;
            this.lblMaSV.Text = "Mã SV :";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(290, 188);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(103, 23);
            this.btnCapNhat.TabIndex = 41;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(104, 145);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(225, 22);
            this.dateTimePicker2.TabIndex = 42;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.AutoSize = true;
            this.lblNgayBatDau.Location = new System.Drawing.Point(12, 145);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(85, 16);
            this.lblNgayBatDau.TabIndex = 43;
            this.lblNgayBatDau.Text = "NgayBatDau";
            // 
            // lblSoNam
            // 
            this.lblSoNam.AutoSize = true;
            this.lblSoNam.Location = new System.Drawing.Point(394, 150);
            this.lblSoNam.Name = "lblSoNam";
            this.lblSoNam.Size = new System.Drawing.Size(53, 16);
            this.lblSoNam.TabIndex = 44;
            this.lblSoNam.Text = "Số năm";
            // 
            // txtSonam
            // 
            this.txtSonam.Location = new System.Drawing.Point(493, 150);
            this.txtSonam.Name = "txtSonam";
            this.txtSonam.Size = new System.Drawing.Size(203, 22);
            this.txtSonam.TabIndex = 45;
            // 
            // txtSonamMuonTim
            // 
            this.txtSonamMuonTim.Location = new System.Drawing.Point(766, 188);
            this.txtSonamMuonTim.Name = "txtSonamMuonTim";
            this.txtSonamMuonTim.Size = new System.Drawing.Size(100, 22);
            this.txtSonamMuonTim.TabIndex = 46;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(777, 47);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 47;
            this.btnIn.Text = "PrivatIn";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // FormTEST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 450);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txtSonamMuonTim);
            this.Controls.Add(this.txtSonam);
            this.Controls.Add(this.lblSoNam);
            this.Controls.Add(this.lblNgayBatDau);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.lblCCCD);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.cboGioiTinh);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtNoiSinh);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.lblNoiSinh);
            this.Controls.Add(this.lblSoDienThoai);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblTenSV);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.lblSonamcantim);
            this.Name = "FormTEST";
            this.Text = "FormTEST";
            this.Load += new System.EventHandler(this.FormTEST_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CachedrptDanhSachLopDangKy cachedrptDanhSachLopDangKy1;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblSonamcantim;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtNoiSinh;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblNoiSinh;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.Label lblSoNam;
        private System.Windows.Forms.TextBox txtSonam;
        private System.Windows.Forms.TextBox txtSonamMuonTim;
        private System.Windows.Forms.Button btnIn;
    }
}