namespace BTLQUANLYSINHVIEN
{
    partial class FormQuanLyLopHoc
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
            this.lblMaMonHoc = new System.Windows.Forms.Label();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.lblHienThiLopHoc = new System.Windows.Forms.Label();
            this.lblHienThiMonHoc = new System.Windows.Forms.Label();
            this.btnTimKiemMonHoc = new System.Windows.Forms.Button();
            this.btnThemMonHoc = new System.Windows.Forms.Button();
            this.btnTimKiemMaLop = new System.Windows.Forms.Button();
            this.btnThemLop = new System.Windows.Forms.Button();
            this.btnXoaMonHoc = new System.Windows.Forms.Button();
            this.btnXoaMaLop = new System.Windows.Forms.Button();
            this.txtMaMonHoc = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblPhanChiaThienHa = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaMonHoc
            // 
            this.lblMaMonHoc.AutoSize = true;
            this.lblMaMonHoc.Location = new System.Drawing.Point(21, 34);
            this.lblMaMonHoc.Name = "lblMaMonHoc";
            this.lblMaMonHoc.Size = new System.Drawing.Size(83, 16);
            this.lblMaMonHoc.TabIndex = 0;
            this.lblMaMonHoc.Text = "Mã môn học:";
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(21, 128);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(51, 16);
            this.lblMaLop.TabIndex = 1;
            this.lblMaLop.Text = "Mã lớp:";
            // 
            // lblHienThiLopHoc
            // 
            this.lblHienThiLopHoc.AutoSize = true;
            this.lblHienThiLopHoc.Location = new System.Drawing.Point(26, 201);
            this.lblHienThiLopHoc.Name = "lblHienThiLopHoc";
            this.lblHienThiLopHoc.Size = new System.Drawing.Size(89, 16);
            this.lblHienThiLopHoc.TabIndex = 2;
            this.lblHienThiLopHoc.Text = "Bảng lớp học;";
            // 
            // lblHienThiMonHoc
            // 
            this.lblHienThiMonHoc.AutoSize = true;
            this.lblHienThiMonHoc.Location = new System.Drawing.Point(433, 27);
            this.lblHienThiMonHoc.Name = "lblHienThiMonHoc";
            this.lblHienThiMonHoc.Size = new System.Drawing.Size(99, 16);
            this.lblHienThiMonHoc.TabIndex = 3;
            this.lblHienThiMonHoc.Text = "Bảng môn học: ";
            this.lblHienThiMonHoc.Click += new System.EventHandler(this.lblHienThiMonHoc_Click);
            // 
            // btnTimKiemMonHoc
            // 
            this.btnTimKiemMonHoc.Location = new System.Drawing.Point(280, 27);
            this.btnTimKiemMonHoc.Name = "btnTimKiemMonHoc";
            this.btnTimKiemMonHoc.Size = new System.Drawing.Size(126, 23);
            this.btnTimKiemMonHoc.TabIndex = 4;
            this.btnTimKiemMonHoc.Text = "Tìm kiếm";
            this.btnTimKiemMonHoc.UseVisualStyleBackColor = true;
            this.btnTimKiemMonHoc.Click += new System.EventHandler(this.btnTimKiemMonHoc_Click);
            // 
            // btnThemMonHoc
            // 
            this.btnThemMonHoc.Location = new System.Drawing.Point(20, 77);
            this.btnThemMonHoc.Name = "btnThemMonHoc";
            this.btnThemMonHoc.Size = new System.Drawing.Size(132, 23);
            this.btnThemMonHoc.TabIndex = 5;
            this.btnThemMonHoc.Text = "Thêm môn học";
            this.btnThemMonHoc.UseVisualStyleBackColor = true;
            this.btnThemMonHoc.Click += new System.EventHandler(this.btnThemMonHoc_Click);
            // 
            // btnTimKiemMaLop
            // 
            this.btnTimKiemMaLop.Location = new System.Drawing.Point(280, 125);
            this.btnTimKiemMaLop.Name = "btnTimKiemMaLop";
            this.btnTimKiemMaLop.Size = new System.Drawing.Size(126, 23);
            this.btnTimKiemMaLop.TabIndex = 6;
            this.btnTimKiemMaLop.Text = "Tìm kiếm";
            this.btnTimKiemMaLop.UseVisualStyleBackColor = true;
            this.btnTimKiemMaLop.Click += new System.EventHandler(this.btnTimKiemMaLop_Click);
            // 
            // btnThemLop
            // 
            this.btnThemLop.Location = new System.Drawing.Point(20, 175);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(132, 23);
            this.btnThemLop.TabIndex = 7;
            this.btnThemLop.Text = "Thêm lớp";
            this.btnThemLop.UseVisualStyleBackColor = true;
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // btnXoaMonHoc
            // 
            this.btnXoaMonHoc.Location = new System.Drawing.Point(280, 56);
            this.btnXoaMonHoc.Name = "btnXoaMonHoc";
            this.btnXoaMonHoc.Size = new System.Drawing.Size(126, 23);
            this.btnXoaMonHoc.TabIndex = 8;
            this.btnXoaMonHoc.Text = "Xóa";
            this.btnXoaMonHoc.UseVisualStyleBackColor = true;
            this.btnXoaMonHoc.Click += new System.EventHandler(this.btnXoaMonHoc_Click);
            // 
            // btnXoaMaLop
            // 
            this.btnXoaMaLop.Location = new System.Drawing.Point(280, 159);
            this.btnXoaMaLop.Name = "btnXoaMaLop";
            this.btnXoaMaLop.Size = new System.Drawing.Size(126, 23);
            this.btnXoaMaLop.TabIndex = 9;
            this.btnXoaMaLop.Text = "Xóa";
            this.btnXoaMaLop.UseVisualStyleBackColor = true;
            this.btnXoaMaLop.Click += new System.EventHandler(this.btnXoaMaLop_Click);
            // 
            // txtMaMonHoc
            // 
            this.txtMaMonHoc.Location = new System.Drawing.Point(116, 28);
            this.txtMaMonHoc.Name = "txtMaMonHoc";
            this.txtMaMonHoc.Size = new System.Drawing.Size(158, 22);
            this.txtMaMonHoc.TabIndex = 10;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(116, 125);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(158, 22);
            this.txtMaLop.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(436, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(352, 126);
            this.dataGridView1.TabIndex = 12;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(20, 220);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(768, 172);
            this.dataGridView2.TabIndex = 13;
            // 
            // lblPhanChiaThienHa
            // 
            this.lblPhanChiaThienHa.AutoSize = true;
            this.lblPhanChiaThienHa.Location = new System.Drawing.Point(26, 105);
            this.lblPhanChiaThienHa.Name = "lblPhanChiaThienHa";
            this.lblPhanChiaThienHa.Size = new System.Drawing.Size(375, 16);
            this.lblPhanChiaThienHa.TabIndex = 14;
            this.lblPhanChiaThienHa.Text = "---------------------------------------------------------------------------------" +
    "-----------";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(352, 398);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(82, 32);
            this.btnQuayLai.TabIndex = 15;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // FormQuanLyLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.lblPhanChiaThienHa);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.txtMaMonHoc);
            this.Controls.Add(this.btnXoaMaLop);
            this.Controls.Add(this.btnXoaMonHoc);
            this.Controls.Add(this.btnThemLop);
            this.Controls.Add(this.btnTimKiemMaLop);
            this.Controls.Add(this.btnThemMonHoc);
            this.Controls.Add(this.btnTimKiemMonHoc);
            this.Controls.Add(this.lblHienThiMonHoc);
            this.Controls.Add(this.lblHienThiLopHoc);
            this.Controls.Add(this.lblMaLop);
            this.Controls.Add(this.lblMaMonHoc);
            this.Name = "FormQuanLyLopHoc";
            this.Text = "Quản lý lớp học";
            this.Load += new System.EventHandler(this.FormQuanLyLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaMonHoc;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label lblHienThiLopHoc;
        private System.Windows.Forms.Label lblHienThiMonHoc;
        private System.Windows.Forms.Button btnTimKiemMonHoc;
        private System.Windows.Forms.Button btnThemMonHoc;
        private System.Windows.Forms.Button btnTimKiemMaLop;
        private System.Windows.Forms.Button btnThemLop;
        private System.Windows.Forms.Button btnXoaMonHoc;
        private System.Windows.Forms.Button btnXoaMaLop;
        private System.Windows.Forms.TextBox txtMaMonHoc;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblPhanChiaThienHa;
        private System.Windows.Forms.Button btnQuayLai;
    }
}