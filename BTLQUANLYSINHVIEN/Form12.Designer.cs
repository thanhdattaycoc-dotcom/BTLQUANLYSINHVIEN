namespace BTLQUANLYSINHVIEN
{
    partial class FormQuanLyNhapDiem
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
            this.lblMaLop = new System.Windows.Forms.Label();
            this.lblMaSinhVien = new System.Windows.Forms.Label();
            this.lblMaMon = new System.Windows.Forms.Label();
            this.lblDiemTX = new System.Windows.Forms.Label();
            this.lblDiemGK = new System.Windows.Forms.Label();
            this.lblDiemCK = new System.Windows.Forms.Label();
            this.txtDiemTX = new System.Windows.Forms.TextBox();
            this.txtDiemGK = new System.Windows.Forms.TextBox();
            this.txtDiemCK = new System.Windows.Forms.TextBox();
            this.dataGridViewTheoLop = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.cboMaLop = new System.Windows.Forms.ComboBox();
            this.cboMaSV = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTheoLop)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(54, 32);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(51, 16);
            this.lblMaLop.TabIndex = 0;
            this.lblMaLop.Text = "Mã lớp:";
            // 
            // lblMaSinhVien
            // 
            this.lblMaSinhVien.AutoSize = true;
            this.lblMaSinhVien.Location = new System.Drawing.Point(54, 62);
            this.lblMaSinhVien.Name = "lblMaSinhVien";
            this.lblMaSinhVien.Size = new System.Drawing.Size(84, 16);
            this.lblMaSinhVien.TabIndex = 1;
            this.lblMaSinhVien.Text = "Mã sinh viên:";
            // 
            // lblMaMon
            // 
            this.lblMaMon.AutoSize = true;
            this.lblMaMon.Location = new System.Drawing.Point(54, 90);
            this.lblMaMon.Name = "lblMaMon";
            this.lblMaMon.Size = new System.Drawing.Size(58, 16);
            this.lblMaMon.TabIndex = 2;
            this.lblMaMon.Text = "Mã môn:";
            // 
            // lblDiemTX
            // 
            this.lblDiemTX.AutoSize = true;
            this.lblDiemTX.Location = new System.Drawing.Point(54, 147);
            this.lblDiemTX.Name = "lblDiemTX";
            this.lblDiemTX.Size = new System.Drawing.Size(125, 16);
            this.lblDiemTX.TabIndex = 3;
            this.lblDiemTX.Text = "Điểm thường xuyên: ";
            // 
            // lblDiemGK
            // 
            this.lblDiemGK.AutoSize = true;
            this.lblDiemGK.Location = new System.Drawing.Point(54, 180);
            this.lblDiemGK.Name = "lblDiemGK";
            this.lblDiemGK.Size = new System.Drawing.Size(87, 16);
            this.lblDiemGK.TabIndex = 4;
            this.lblDiemGK.Text = "Điểm giữa kỳ:";
            this.lblDiemGK.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblDiemCK
            // 
            this.lblDiemCK.AutoSize = true;
            this.lblDiemCK.Location = new System.Drawing.Point(54, 216);
            this.lblDiemCK.Name = "lblDiemCK";
            this.lblDiemCK.Size = new System.Drawing.Size(86, 16);
            this.lblDiemCK.TabIndex = 5;
            this.lblDiemCK.Text = "Điểm cuối kỳ:";
            // 
            // txtDiemTX
            // 
            this.txtDiemTX.Location = new System.Drawing.Point(201, 144);
            this.txtDiemTX.Name = "txtDiemTX";
            this.txtDiemTX.Size = new System.Drawing.Size(244, 22);
            this.txtDiemTX.TabIndex = 7;
            this.txtDiemTX.TextChanged += new System.EventHandler(this.txtDiemTX_TextChanged);
            // 
            // txtDiemGK
            // 
            this.txtDiemGK.Location = new System.Drawing.Point(201, 177);
            this.txtDiemGK.Name = "txtDiemGK";
            this.txtDiemGK.Size = new System.Drawing.Size(244, 22);
            this.txtDiemGK.TabIndex = 8;
            // 
            // txtDiemCK
            // 
            this.txtDiemCK.Location = new System.Drawing.Point(201, 213);
            this.txtDiemCK.Name = "txtDiemCK";
            this.txtDiemCK.Size = new System.Drawing.Size(244, 22);
            this.txtDiemCK.TabIndex = 9;
            // 
            // dataGridViewTheoLop
            // 
            this.dataGridViewTheoLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTheoLop.Location = new System.Drawing.Point(57, 288);
            this.dataGridViewTheoLop.Name = "dataGridViewTheoLop";
            this.dataGridViewTheoLop.RowHeadersWidth = 51;
            this.dataGridViewTheoLop.RowTemplate.Height = 24;
            this.dataGridViewTheoLop.Size = new System.Drawing.Size(720, 150);
            this.dataGridViewTheoLop.TabIndex = 12;
            this.dataGridViewTheoLop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Bảng điểm theo lớp ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(201, 250);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(136, 23);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm(Cập nhật)";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(343, 250);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 23);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa điểm";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(475, 249);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(302, 23);
            this.btnQuayLai.TabIndex = 18;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Location = new System.Drawing.Point(54, 120);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(63, 16);
            this.lblTenMon.TabIndex = 20;
            this.lblTenMon.Text = "Tên môn:";
            // 
            // cboMaLop
            // 
            this.cboMaLop.FormattingEnabled = true;
            this.cboMaLop.Location = new System.Drawing.Point(201, 29);
            this.cboMaLop.Name = "cboMaLop";
            this.cboMaLop.Size = new System.Drawing.Size(244, 24);
            this.cboMaLop.TabIndex = 11;
            this.cboMaLop.SelectedIndexChanged += new System.EventHandler(this.cboMaLop_SelectedIndexChanged);
            // 
            // cboMaSV
            // 
            this.cboMaSV.FormattingEnabled = true;
            this.cboMaSV.Location = new System.Drawing.Point(201, 60);
            this.cboMaSV.Name = "cboMaSV";
            this.cboMaSV.Size = new System.Drawing.Size(244, 24);
            this.cboMaSV.TabIndex = 10;
            this.cboMaSV.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FormQuanLyNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTenMon);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTheoLop);
            this.Controls.Add(this.cboMaLop);
            this.Controls.Add(this.cboMaSV);
            this.Controls.Add(this.txtDiemCK);
            this.Controls.Add(this.txtDiemGK);
            this.Controls.Add(this.txtDiemTX);
            this.Controls.Add(this.lblDiemCK);
            this.Controls.Add(this.lblDiemGK);
            this.Controls.Add(this.lblDiemTX);
            this.Controls.Add(this.lblMaMon);
            this.Controls.Add(this.lblMaSinhVien);
            this.Controls.Add(this.lblMaLop);
            this.Name = "FormQuanLyNhapDiem";
            this.Text = "Quản lý nhập điểm";
            this.Load += new System.EventHandler(this.FormQuanLyNhapDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTheoLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label lblMaSinhVien;
        private System.Windows.Forms.Label lblMaMon;
        private System.Windows.Forms.Label lblDiemTX;
        private System.Windows.Forms.Label lblDiemGK;
        private System.Windows.Forms.Label lblDiemCK;
        private System.Windows.Forms.TextBox txtDiemTX;
        private System.Windows.Forms.TextBox txtDiemGK;
        private System.Windows.Forms.TextBox txtDiemCK;
        private System.Windows.Forms.DataGridView dataGridViewTheoLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.ComboBox cboMaLop;
        private System.Windows.Forms.ComboBox cboMaSV;
    }
}