namespace BTLQUANLYSINHVIEN
{
    partial class FormDangKyLopHoc
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
            this.lblTenSinhVien = new System.Windows.Forms.Label();
            this.cboMaLop = new System.Windows.Forms.ComboBox();
            this.lblMalop = new System.Windows.Forms.Label();
            this.lblNgayHomNay = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCon = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.lblLopDangKY = new System.Windows.Forms.Label();
            this.dataGridViewLopDaDangKy = new System.Windows.Forms.DataGridView();
            this.cboHuyDangKy = new System.Windows.Forms.ComboBox();
            this.btnHuyDangKy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVachNgan = new System.Windows.Forms.Label();
            this.lblMonHoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLopDaDangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaSinhVien
            // 
            this.lblMaSinhVien.AutoSize = true;
            this.lblMaSinhVien.Location = new System.Drawing.Point(48, 24);
            this.lblMaSinhVien.Name = "lblMaSinhVien";
            this.lblMaSinhVien.Size = new System.Drawing.Size(84, 16);
            this.lblMaSinhVien.TabIndex = 0;
            this.lblMaSinhVien.Text = "Mã sinh viên:";
            // 
            // lblTenSinhVien
            // 
            this.lblTenSinhVien.AutoSize = true;
            this.lblTenSinhVien.Location = new System.Drawing.Point(48, 57);
            this.lblTenSinhVien.Name = "lblTenSinhVien";
            this.lblTenSinhVien.Size = new System.Drawing.Size(86, 16);
            this.lblTenSinhVien.TabIndex = 1;
            this.lblTenSinhVien.Text = "Tên sinh viên";
            // 
            // cboMaLop
            // 
            this.cboMaLop.FormattingEnabled = true;
            this.cboMaLop.Location = new System.Drawing.Point(175, 122);
            this.cboMaLop.Name = "cboMaLop";
            this.cboMaLop.Size = new System.Drawing.Size(122, 24);
            this.cboMaLop.TabIndex = 2;
            this.cboMaLop.SelectedIndexChanged += new System.EventHandler(this.cboMaLop_SelectedIndexChanged);
            // 
            // lblMalop
            // 
            this.lblMalop.AutoSize = true;
            this.lblMalop.Location = new System.Drawing.Point(48, 125);
            this.lblMalop.Name = "lblMalop";
            this.lblMalop.Size = new System.Drawing.Size(51, 16);
            this.lblMalop.TabIndex = 3;
            this.lblMalop.Text = "Mã lớp:";
            // 
            // lblNgayHomNay
            // 
            this.lblNgayHomNay.AutoSize = true;
            this.lblNgayHomNay.Location = new System.Drawing.Point(48, 88);
            this.lblNgayHomNay.Name = "lblNgayHomNay";
            this.lblNgayHomNay.Size = new System.Drawing.Size(97, 16);
            this.lblNgayHomNay.TabIndex = 4;
            this.lblNgayHomNay.Text = "Ngày hôm nay:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1150, 234);
            this.dataGridView1.TabIndex = 5;
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Location = new System.Drawing.Point(48, 194);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(37, 16);
            this.lblCon.TabIndex = 6;
            this.lblCon.Text = "Còn: ";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.Location = new System.Drawing.Point(175, 165);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(122, 27);
            this.btnDangKy.TabIndex = 7;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Location = new System.Drawing.Point(306, 219);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(122, 37);
            this.btnQuayLai.TabIndex = 11;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // lblLopDangKY
            // 
            this.lblLopDangKY.AutoSize = true;
            this.lblLopDangKY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLopDangKY.Location = new System.Drawing.Point(470, 35);
            this.lblLopDangKY.Name = "lblLopDangKY";
            this.lblLopDangKY.Size = new System.Drawing.Size(122, 20);
            this.lblLopDangKY.TabIndex = 10;
            this.lblLopDangKY.Text = "Lớp đã đăng ký";
            // 
            // dataGridViewLopDaDangKy
            // 
            this.dataGridViewLopDaDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLopDaDangKy.Location = new System.Drawing.Point(473, 57);
            this.dataGridViewLopDaDangKy.Name = "dataGridViewLopDaDangKy";
            this.dataGridViewLopDaDangKy.RowHeadersWidth = 51;
            this.dataGridViewLopDaDangKy.RowTemplate.Height = 24;
            this.dataGridViewLopDaDangKy.Size = new System.Drawing.Size(716, 216);
            this.dataGridViewLopDaDangKy.TabIndex = 11;
            // 
            // cboHuyDangKy
            // 
            this.cboHuyDangKy.FormattingEnabled = true;
            this.cboHuyDangKy.Location = new System.Drawing.Point(310, 122);
            this.cboHuyDangKy.Name = "cboHuyDangKy";
            this.cboHuyDangKy.Size = new System.Drawing.Size(122, 24);
            this.cboHuyDangKy.TabIndex = 12;
            // 
            // btnHuyDangKy
            // 
            this.btnHuyDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyDangKy.Location = new System.Drawing.Point(310, 165);
            this.btnHuyDangKy.Name = "btnHuyDangKy";
            this.btnHuyDangKy.Size = new System.Drawing.Size(122, 27);
            this.btnHuyDangKy.TabIndex = 13;
            this.btnHuyDangKy.Text = "Hủy Đăng Ký";
            this.btnHuyDangKy.UseVisualStyleBackColor = true;
            this.btnHuyDangKy.Click += new System.EventHandler(this.btnHuyDangKy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Các lớp có thể chọn";
            // 
            // lblVachNgan
            // 
            this.lblVachNgan.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVachNgan.Location = new System.Drawing.Point(303, 122);
            this.lblVachNgan.Name = "lblVachNgan";
            this.lblVachNgan.Size = new System.Drawing.Size(1, 70);
            this.lblVachNgan.TabIndex = 15;
            this.lblVachNgan.Text = "||";
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Location = new System.Drawing.Point(48, 163);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(61, 16);
            this.lblMonHoc.TabIndex = 16;
            this.lblMonHoc.Text = "Môn học:";
            // 
            // FormDangKyLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 525);
            this.Controls.Add(this.lblMonHoc);
            this.Controls.Add(this.lblVachNgan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuyDangKy);
            this.Controls.Add(this.cboHuyDangKy);
            this.Controls.Add(this.dataGridViewLopDaDangKy);
            this.Controls.Add(this.lblLopDangKY);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.lblCon);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblNgayHomNay);
            this.Controls.Add(this.lblMalop);
            this.Controls.Add(this.cboMaLop);
            this.Controls.Add(this.lblTenSinhVien);
            this.Controls.Add(this.lblMaSinhVien);
            this.Name = "FormDangKyLopHoc";
            this.Text = "Đăng ký lớp học";
            this.Load += new System.EventHandler(this.FormDangKyLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLopDaDangKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaSinhVien;
        private System.Windows.Forms.Label lblTenSinhVien;
        private System.Windows.Forms.ComboBox cboMaLop;
        private System.Windows.Forms.Label lblMalop;
        private System.Windows.Forms.Label lblNgayHomNay;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Label lblLopDangKY;
        private System.Windows.Forms.DataGridView dataGridViewLopDaDangKy;
        private System.Windows.Forms.ComboBox cboHuyDangKy;
        private System.Windows.Forms.Button btnHuyDangKy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVachNgan;
        private System.Windows.Forms.Label lblMonHoc;
    }
}