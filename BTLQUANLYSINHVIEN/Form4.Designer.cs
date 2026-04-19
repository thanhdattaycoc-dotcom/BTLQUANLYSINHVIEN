namespace BTLQUANLYSINHVIEN
{
    partial class FormTrangChuGiangVien
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
            this.lblMaGiaoVien = new System.Windows.Forms.Label();
            this.lblHoTenGiaoVien = new System.Windows.Forms.Label();
            this.btnThongTinCaNhan = new System.Windows.Forms.Button();
            this.btnQuanLyGiaoVien = new System.Windows.Forms.Button();
            this.btnQuanLySinhVien = new System.Windows.Forms.Button();
            this.btnMonHoc = new System.Windows.Forms.Button();
            this.btnNhapDiem = new System.Windows.Forms.Button();
            this.btnQuanLyLopHoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaGiaoVien
            // 
            this.lblMaGiaoVien.AutoSize = true;
            this.lblMaGiaoVien.Location = new System.Drawing.Point(65, 66);
            this.lblMaGiaoVien.Name = "lblMaGiaoVien";
            this.lblMaGiaoVien.Size = new System.Drawing.Size(87, 16);
            this.lblMaGiaoVien.TabIndex = 1;
            this.lblMaGiaoVien.Text = "Mã giáo viên:";
            this.lblMaGiaoVien.Click += new System.EventHandler(this.lblMaGiaoVien_Click);
            // 
            // lblHoTenGiaoVien
            // 
            this.lblHoTenGiaoVien.AutoSize = true;
            this.lblHoTenGiaoVien.Location = new System.Drawing.Point(65, 110);
            this.lblHoTenGiaoVien.Name = "lblHoTenGiaoVien";
            this.lblHoTenGiaoVien.Size = new System.Drawing.Size(125, 16);
            this.lblHoTenGiaoVien.TabIndex = 2;
            this.lblHoTenGiaoVien.Text = "Họ và tên giáo viên:";
            this.lblHoTenGiaoVien.Click += new System.EventHandler(this.lblHoTenGiaoVien_Click);
            // 
            // btnThongTinCaNhan
            // 
            this.btnThongTinCaNhan.Location = new System.Drawing.Point(68, 187);
            this.btnThongTinCaNhan.Name = "btnThongTinCaNhan";
            this.btnThongTinCaNhan.Size = new System.Drawing.Size(203, 81);
            this.btnThongTinCaNhan.TabIndex = 4;
            this.btnThongTinCaNhan.Text = "Thông tin cá nhân";
            this.btnThongTinCaNhan.UseVisualStyleBackColor = true;
            this.btnThongTinCaNhan.Click += new System.EventHandler(this.btnThongTinCaNhan_Click);
            // 
            // btnQuanLyGiaoVien
            // 
            this.btnQuanLyGiaoVien.Location = new System.Drawing.Point(307, 187);
            this.btnQuanLyGiaoVien.Name = "btnQuanLyGiaoVien";
            this.btnQuanLyGiaoVien.Size = new System.Drawing.Size(203, 81);
            this.btnQuanLyGiaoVien.TabIndex = 5;
            this.btnQuanLyGiaoVien.Text = "Quản lý giáo viên";
            this.btnQuanLyGiaoVien.UseVisualStyleBackColor = true;
            this.btnQuanLyGiaoVien.Click += new System.EventHandler(this.btnQuanLyGiaoVien_Click);
            // 
            // btnQuanLySinhVien
            // 
            this.btnQuanLySinhVien.Location = new System.Drawing.Point(546, 187);
            this.btnQuanLySinhVien.Name = "btnQuanLySinhVien";
            this.btnQuanLySinhVien.Size = new System.Drawing.Size(203, 81);
            this.btnQuanLySinhVien.TabIndex = 6;
            this.btnQuanLySinhVien.Text = "Quản lý sinh viên";
            this.btnQuanLySinhVien.UseVisualStyleBackColor = true;
            this.btnQuanLySinhVien.Click += new System.EventHandler(this.btnQuanLySinhVien_Click);
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Location = new System.Drawing.Point(546, 306);
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.Size = new System.Drawing.Size(203, 81);
            this.btnMonHoc.TabIndex = 7;
            this.btnMonHoc.Text = "Quản lý môn học";
            this.btnMonHoc.UseVisualStyleBackColor = true;
            this.btnMonHoc.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.Location = new System.Drawing.Point(307, 306);
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.Size = new System.Drawing.Size(203, 81);
            this.btnNhapDiem.TabIndex = 8;
            this.btnNhapDiem.Text = "Quản lý nhập điểm";
            this.btnNhapDiem.UseVisualStyleBackColor = true;
            this.btnNhapDiem.Click += new System.EventHandler(this.btnNhapDiem_Click);
            // 
            // btnQuanLyLopHoc
            // 
            this.btnQuanLyLopHoc.Location = new System.Drawing.Point(68, 306);
            this.btnQuanLyLopHoc.Name = "btnQuanLyLopHoc";
            this.btnQuanLyLopHoc.Size = new System.Drawing.Size(203, 81);
            this.btnQuanLyLopHoc.TabIndex = 9;
            this.btnQuanLyLopHoc.Text = "Quản lý lớp học";
            this.btnQuanLyLopHoc.UseVisualStyleBackColor = true;
            this.btnQuanLyLopHoc.Click += new System.EventHandler(this.btnQuanLyLopHoc_Click);
            // 
            // FormTrangChuGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuanLyLopHoc);
            this.Controls.Add(this.btnNhapDiem);
            this.Controls.Add(this.btnMonHoc);
            this.Controls.Add(this.btnQuanLySinhVien);
            this.Controls.Add(this.btnQuanLyGiaoVien);
            this.Controls.Add(this.btnThongTinCaNhan);
            this.Controls.Add(this.lblHoTenGiaoVien);
            this.Controls.Add(this.lblMaGiaoVien);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormTrangChuGiangVien";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Trang chủ giảng viên";
            this.Load += new System.EventHandler(this.FormTrangChuGiangVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaGiaoVien;
        private System.Windows.Forms.Label lblHoTenGiaoVien;
        private System.Windows.Forms.Button btnThongTinCaNhan;
        private System.Windows.Forms.Button btnQuanLyGiaoVien;
        private System.Windows.Forms.Button btnQuanLySinhVien;
        private System.Windows.Forms.Button btnMonHoc;
        private System.Windows.Forms.Button btnNhapDiem;
        private System.Windows.Forms.Button btnQuanLyLopHoc;
    }
}