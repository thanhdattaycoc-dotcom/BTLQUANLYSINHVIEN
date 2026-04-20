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
            this.lblMaLop = new System.Windows.Forms.Label();
            this.lblHienThiLopHoc = new System.Windows.Forms.Label();
            this.btnTimKiemMaLop = new System.Windows.Forms.Button();
            this.btnThemLop = new System.Windows.Forms.Button();
            this.btnXoaMaLop = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnQuayLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(26, 36);
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
            // btnTimKiemMaLop
            // 
            this.btnTimKiemMaLop.Location = new System.Drawing.Point(319, 33);
            this.btnTimKiemMaLop.Name = "btnTimKiemMaLop";
            this.btnTimKiemMaLop.Size = new System.Drawing.Size(126, 23);
            this.btnTimKiemMaLop.TabIndex = 6;
            this.btnTimKiemMaLop.Text = "Tìm kiếm";
            this.btnTimKiemMaLop.UseVisualStyleBackColor = true;
            this.btnTimKiemMaLop.Click += new System.EventHandler(this.btnTimKiemMaLop_Click);
            // 
            // btnThemLop
            // 
            this.btnThemLop.Location = new System.Drawing.Point(29, 97);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(132, 23);
            this.btnThemLop.TabIndex = 7;
            this.btnThemLop.Text = "Thêm lớp";
            this.btnThemLop.UseVisualStyleBackColor = true;
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // btnXoaMaLop
            // 
            this.btnXoaMaLop.Location = new System.Drawing.Point(280, 97);
            this.btnXoaMaLop.Name = "btnXoaMaLop";
            this.btnXoaMaLop.Size = new System.Drawing.Size(126, 23);
            this.btnXoaMaLop.TabIndex = 9;
            this.btnXoaMaLop.Text = "Xóa";
            this.btnXoaMaLop.UseVisualStyleBackColor = true;
            this.btnXoaMaLop.Click += new System.EventHandler(this.btnXoaMaLop_Click);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(124, 36);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(158, 22);
            this.txtMaLop.TabIndex = 11;
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
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.btnXoaMaLop);
            this.Controls.Add(this.btnThemLop);
            this.Controls.Add(this.btnTimKiemMaLop);
            this.Controls.Add(this.lblHienThiLopHoc);
            this.Controls.Add(this.lblMaLop);
            this.Name = "FormQuanLyLopHoc";
            this.Text = "Quản lý lớp học";
            this.Load += new System.EventHandler(this.FormQuanLyLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label lblHienThiLopHoc;
        private System.Windows.Forms.Button btnTimKiemMaLop;
        private System.Windows.Forms.Button btnThemLop;
        private System.Windows.Forms.Button btnXoaMaLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnQuayLai;
    }
}