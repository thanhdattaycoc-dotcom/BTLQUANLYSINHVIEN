namespace BTLQUANLYSINHVIEN
{
    partial class FormThemLopHoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.lblMaMon = new System.Windows.Forms.Label();
            this.lblNhapThongTin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.txtSiSoToiDa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerNgayMo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNgayDong = new System.Windows.Forms.DateTimePicker();
            this.cboTiet = new System.Windows.Forms.ComboBox();
            this.cboThu = new System.Windows.Forms.ComboBox();
            this.cboTenMon = new System.Windows.Forms.ComboBox();
            this.cboMaGiaoVien = new System.Windows.Forms.ComboBox();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.lblTenGiaoVien = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblSoTinChi = new System.Windows.Forms.Label();
            this.txtSotinchi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp:";
            // 
            // lblTenLop
            // 
            this.lblTenLop.AutoSize = true;
            this.lblTenLop.Location = new System.Drawing.Point(472, 97);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(56, 16);
            this.lblTenLop.TabIndex = 1;
            this.lblTenLop.Text = "Tên lớp:";
            // 
            // lblMaMon
            // 
            this.lblMaMon.AutoSize = true;
            this.lblMaMon.Location = new System.Drawing.Point(472, 62);
            this.lblMaMon.Name = "lblMaMon";
            this.lblMaMon.Size = new System.Drawing.Size(58, 16);
            this.lblMaMon.TabIndex = 2;
            this.lblMaMon.Text = "Mã môn:";
            // 
            // lblNhapThongTin
            // 
            this.lblNhapThongTin.AutoSize = true;
            this.lblNhapThongTin.Location = new System.Drawing.Point(40, 26);
            this.lblNhapThongTin.Name = "lblNhapThongTin";
            this.lblNhapThongTin.Size = new System.Drawing.Size(139, 16);
            this.lblNhapThongTin.TabIndex = 3;
            this.lblNhapThongTin.Text = "Nhập thông tin lớp học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sĩ số tối đa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã giáo viên:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tiết:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(468, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Thứ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Phòng:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 340);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1161, 258);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(469, 308);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(705, 308);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(75, 23);
            this.btnQuayLai.TabIndex = 11;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(163, 97);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(211, 22);
            this.txtMaLop.TabIndex = 12;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(569, 94);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(211, 22);
            this.txtTenLop.TabIndex = 13;
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(163, 135);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(211, 22);
            this.txtPhong.TabIndex = 16;
            // 
            // txtSiSoToiDa
            // 
            this.txtSiSoToiDa.Location = new System.Drawing.Point(163, 312);
            this.txtSiSoToiDa.Name = "txtSiSoToiDa";
            this.txtSiSoToiDa.Size = new System.Drawing.Size(211, 22);
            this.txtSiSoToiDa.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ngày mở lớp:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(467, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Ngày đóng:";
            // 
            // dateTimePickerNgayMo
            // 
            this.dateTimePickerNgayMo.Location = new System.Drawing.Point(163, 267);
            this.dateTimePickerNgayMo.Name = "dateTimePickerNgayMo";
            this.dateTimePickerNgayMo.Size = new System.Drawing.Size(227, 22);
            this.dateTimePickerNgayMo.TabIndex = 22;
            this.dateTimePickerNgayMo.ValueChanged += new System.EventHandler(this.dateTimePickerNgayMo_ValueChanged);
            // 
            // dateTimePickerNgayDong
            // 
            this.dateTimePickerNgayDong.Location = new System.Drawing.Point(569, 272);
            this.dateTimePickerNgayDong.Name = "dateTimePickerNgayDong";
            this.dateTimePickerNgayDong.Size = new System.Drawing.Size(211, 22);
            this.dateTimePickerNgayDong.TabIndex = 23;
            // 
            // cboTiet
            // 
            this.cboTiet.FormattingEnabled = true;
            this.cboTiet.Location = new System.Drawing.Point(163, 223);
            this.cboTiet.Name = "cboTiet";
            this.cboTiet.Size = new System.Drawing.Size(211, 24);
            this.cboTiet.TabIndex = 24;
            // 
            // cboThu
            // 
            this.cboThu.FormattingEnabled = true;
            this.cboThu.Location = new System.Drawing.Point(569, 226);
            this.cboThu.Name = "cboThu";
            this.cboThu.Size = new System.Drawing.Size(211, 24);
            this.cboThu.TabIndex = 25;
            // 
            // cboTenMon
            // 
            this.cboTenMon.FormattingEnabled = true;
            this.cboTenMon.Location = new System.Drawing.Point(163, 59);
            this.cboTenMon.Name = "cboTenMon";
            this.cboTenMon.Size = new System.Drawing.Size(211, 24);
            this.cboTenMon.TabIndex = 26;
            this.cboTenMon.SelectedIndexChanged += new System.EventHandler(this.cboTenMon_SelectedIndexChanged);
            // 
            // cboMaGiaoVien
            // 
            this.cboMaGiaoVien.FormattingEnabled = true;
            this.cboMaGiaoVien.Location = new System.Drawing.Point(163, 177);
            this.cboMaGiaoVien.Name = "cboMaGiaoVien";
            this.cboMaGiaoVien.Size = new System.Drawing.Size(211, 24);
            this.cboMaGiaoVien.TabIndex = 27;
            this.cboMaGiaoVien.SelectedIndexChanged += new System.EventHandler(this.cboMaGiaoVien_SelectedIndexChanged);
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Location = new System.Drawing.Point(40, 62);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(63, 16);
            this.lblTenMon.TabIndex = 28;
            this.lblTenMon.Text = "Tên môn:";
            // 
            // txtMaMon
            // 
            this.txtMaMon.Location = new System.Drawing.Point(569, 59);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(211, 22);
            this.txtMaMon.TabIndex = 29;
            this.txtMaMon.TextChanged += new System.EventHandler(this.txtMaMon_TextChanged);
            // 
            // lblTenGiaoVien
            // 
            this.lblTenGiaoVien.AutoSize = true;
            this.lblTenGiaoVien.Location = new System.Drawing.Point(466, 180);
            this.lblTenGiaoVien.Name = "lblTenGiaoVien";
            this.lblTenGiaoVien.Size = new System.Drawing.Size(92, 16);
            this.lblTenGiaoVien.TabIndex = 30;
            this.lblTenGiaoVien.Text = "Tên giáo viên:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(569, 177);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 22);
            this.textBox2.TabIndex = 31;
            // 
            // lblSoTinChi
            // 
            this.lblSoTinChi.AutoSize = true;
            this.lblSoTinChi.Location = new System.Drawing.Point(468, 138);
            this.lblSoTinChi.Name = "lblSoTinChi";
            this.lblSoTinChi.Size = new System.Drawing.Size(60, 16);
            this.lblSoTinChi.TabIndex = 32;
            this.lblSoTinChi.Text = "Số tín chỉ";
            // 
            // txtSotinchi
            // 
            this.txtSotinchi.Location = new System.Drawing.Point(569, 135);
            this.txtSotinchi.Name = "txtSotinchi";
            this.txtSotinchi.Size = new System.Drawing.Size(211, 22);
            this.txtSotinchi.TabIndex = 33;
            // 
            // FormThemLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 610);
            this.Controls.Add(this.txtSotinchi);
            this.Controls.Add(this.lblSoTinChi);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblTenGiaoVien);
            this.Controls.Add(this.txtMaMon);
            this.Controls.Add(this.lblTenMon);
            this.Controls.Add(this.cboMaGiaoVien);
            this.Controls.Add(this.cboTenMon);
            this.Controls.Add(this.cboThu);
            this.Controls.Add(this.cboTiet);
            this.Controls.Add(this.dateTimePickerNgayDong);
            this.Controls.Add(this.dateTimePickerNgayMo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSiSoToiDa);
            this.Controls.Add(this.txtPhong);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNhapThongTin);
            this.Controls.Add(this.lblMaMon);
            this.Controls.Add(this.lblTenLop);
            this.Controls.Add(this.label1);
            this.Name = "FormThemLopHoc";
            this.Text = "Thêm lớp học";
            this.Load += new System.EventHandler(this.Form17_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.Label lblMaMon;
        private System.Windows.Forms.Label lblNhapThongTin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.TextBox txtSiSoToiDa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayMo;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayDong;
        private System.Windows.Forms.ComboBox cboTiet;
        private System.Windows.Forms.ComboBox cboThu;
        private System.Windows.Forms.ComboBox cboTenMon;
        private System.Windows.Forms.ComboBox cboMaGiaoVien;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Label lblTenGiaoVien;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblSoTinChi;
        private System.Windows.Forms.TextBox txtSotinchi;
    }
}