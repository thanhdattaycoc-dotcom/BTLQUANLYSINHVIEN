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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.cboMaMon = new System.Windows.Forms.ComboBox();
            this.cboMaGiaoVien = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã môn:";
            // 
            // lblNhapThongTin
            // 
            this.lblNhapThongTin.AutoSize = true;
            this.lblNhapThongTin.Location = new System.Drawing.Point(42, 9);
            this.lblNhapThongTin.Name = "lblNhapThongTin";
            this.lblNhapThongTin.Size = new System.Drawing.Size(139, 16);
            this.lblNhapThongTin.TabIndex = 3;
            this.lblNhapThongTin.Text = "Nhập thông tin lớp học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sĩ số tối đa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã giáo viên:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tiết:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(391, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Thứ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(391, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Phòng:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(746, 182);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(382, 198);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(382, 415);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(75, 23);
            this.btnQuayLai.TabIndex = 11;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(163, 46);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(211, 22);
            this.txtMaLop.TabIndex = 12;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(163, 74);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(211, 22);
            this.txtTenLop.TabIndex = 13;
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(512, 49);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(211, 22);
            this.txtPhong.TabIndex = 16;
            // 
            // txtSiSoToiDa
            // 
            this.txtSiSoToiDa.Location = new System.Drawing.Point(512, 77);
            this.txtSiSoToiDa.Name = "txtSiSoToiDa";
            this.txtSiSoToiDa.Size = new System.Drawing.Size(211, 22);
            this.txtSiSoToiDa.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ngày mở lớp:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(391, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Ngày đóng:";
            // 
            // dateTimePickerNgayMo
            // 
            this.dateTimePickerNgayMo.Location = new System.Drawing.Point(163, 164);
            this.dateTimePickerNgayMo.Name = "dateTimePickerNgayMo";
            this.dateTimePickerNgayMo.Size = new System.Drawing.Size(211, 22);
            this.dateTimePickerNgayMo.TabIndex = 22;
            // 
            // dateTimePickerNgayDong
            // 
            this.dateTimePickerNgayDong.Location = new System.Drawing.Point(512, 164);
            this.dateTimePickerNgayDong.Name = "dateTimePickerNgayDong";
            this.dateTimePickerNgayDong.Size = new System.Drawing.Size(211, 22);
            this.dateTimePickerNgayDong.TabIndex = 23;
            // 
            // cboTiet
            // 
            this.cboTiet.FormattingEnabled = true;
            this.cboTiet.Location = new System.Drawing.Point(163, 134);
            this.cboTiet.Name = "cboTiet";
            this.cboTiet.Size = new System.Drawing.Size(211, 24);
            this.cboTiet.TabIndex = 24;
            // 
            // cboThu
            // 
            this.cboThu.FormattingEnabled = true;
            this.cboThu.Location = new System.Drawing.Point(512, 134);
            this.cboThu.Name = "cboThu";
            this.cboThu.Size = new System.Drawing.Size(211, 24);
            this.cboThu.TabIndex = 25;
            // 
            // cboMaMon
            // 
            this.cboMaMon.FormattingEnabled = true;
            this.cboMaMon.Location = new System.Drawing.Point(163, 102);
            this.cboMaMon.Name = "cboMaMon";
            this.cboMaMon.Size = new System.Drawing.Size(211, 24);
            this.cboMaMon.TabIndex = 26;
            // 
            // cboMaGiaoVien
            // 
            this.cboMaGiaoVien.FormattingEnabled = true;
            this.cboMaGiaoVien.Location = new System.Drawing.Point(512, 105);
            this.cboMaGiaoVien.Name = "cboMaGiaoVien";
            this.cboMaGiaoVien.Size = new System.Drawing.Size(211, 24);
            this.cboMaGiaoVien.TabIndex = 27;
            // 
            // FormThemLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboMaGiaoVien);
            this.Controls.Add(this.cboMaMon);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.ComboBox cboMaMon;
        private System.Windows.Forms.ComboBox cboMaGiaoVien;
    }
}