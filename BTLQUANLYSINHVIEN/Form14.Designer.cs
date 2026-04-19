namespace BTLQUANLYSINHVIEN
{
    partial class FormQuanLyMonHoc
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
            this.components = new System.ComponentModel.Container();
            this.lblMaMonHoc = new System.Windows.Forms.Label();
            this.btnTimKiemMonHoc = new System.Windows.Forms.Button();
            this.btnThemMonHoc = new System.Windows.Forms.Button();
            this.btnXoaMonHoc = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblHienThiMonHoc = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.lblTen = new System.Windows.Forms.Label();
            this.cboMa = new System.Windows.Forms.ComboBox();
            this.cboTen = new System.Windows.Forms.ComboBox();
            this.txtTinChi = new System.Windows.Forms.TextBox();
            this.lbTinchi = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnCapNhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaMonHoc
            // 
            this.lblMaMonHoc.AutoSize = true;
            this.lblMaMonHoc.Location = new System.Drawing.Point(28, 62);
            this.lblMaMonHoc.Name = "lblMaMonHoc";
            this.lblMaMonHoc.Size = new System.Drawing.Size(83, 16);
            this.lblMaMonHoc.TabIndex = 1;
            this.lblMaMonHoc.Text = "Mã môn học:";
            // 
            // btnTimKiemMonHoc
            // 
            this.btnTimKiemMonHoc.Location = new System.Drawing.Point(12, 227);
            this.btnTimKiemMonHoc.Name = "btnTimKiemMonHoc";
            this.btnTimKiemMonHoc.Size = new System.Drawing.Size(132, 23);
            this.btnTimKiemMonHoc.TabIndex = 5;
            this.btnTimKiemMonHoc.Text = "Tìm kiếm";
            this.btnTimKiemMonHoc.UseVisualStyleBackColor = true;
            this.btnTimKiemMonHoc.Click += new System.EventHandler(this.btnTimKiemMonHoc_Click);
            // 
            // btnThemMonHoc
            // 
            this.btnThemMonHoc.Location = new System.Drawing.Point(178, 227);
            this.btnThemMonHoc.Name = "btnThemMonHoc";
            this.btnThemMonHoc.Size = new System.Drawing.Size(132, 23);
            this.btnThemMonHoc.TabIndex = 12;
            this.btnThemMonHoc.Text = "Thêm môn học";
            this.btnThemMonHoc.UseVisualStyleBackColor = true;
            this.btnThemMonHoc.Click += new System.EventHandler(this.btnThemMonHoc_Click);
            // 
            // btnXoaMonHoc
            // 
            this.btnXoaMonHoc.Location = new System.Drawing.Point(12, 278);
            this.btnXoaMonHoc.Name = "btnXoaMonHoc";
            this.btnXoaMonHoc.Size = new System.Drawing.Size(132, 23);
            this.btnXoaMonHoc.TabIndex = 13;
            this.btnXoaMonHoc.Text = "Xóa";
            this.btnXoaMonHoc.UseVisualStyleBackColor = true;
            this.btnXoaMonHoc.Click += new System.EventHandler(this.btnXoaMonHoc_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(353, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(626, 376);
            this.dataGridView1.TabIndex = 14;
            // 
            // lblHienThiMonHoc
            // 
            this.lblHienThiMonHoc.AutoSize = true;
            this.lblHienThiMonHoc.Location = new System.Drawing.Point(350, 33);
            this.lblHienThiMonHoc.Name = "lblHienThiMonHoc";
            this.lblHienThiMonHoc.Size = new System.Drawing.Size(99, 16);
            this.lblHienThiMonHoc.TabIndex = 15;
            this.lblHienThiMonHoc.Text = "Bảng môn học: ";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(178, 373);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(132, 32);
            this.btnQuayLai.TabIndex = 16;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(28, 109);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(88, 16);
            this.lblTen.TabIndex = 17;
            this.lblTen.Text = "Tên môn học:";
            // 
            // cboMa
            // 
            this.cboMa.FormattingEnabled = true;
            this.cboMa.Location = new System.Drawing.Point(134, 62);
            this.cboMa.Name = "cboMa";
            this.cboMa.Size = new System.Drawing.Size(213, 24);
            this.cboMa.TabIndex = 18;
            this.cboMa.SelectedIndexChanged += new System.EventHandler(this.cboMa_SelectedIndexChanged);
            // 
            // cboTen
            // 
            this.cboTen.FormattingEnabled = true;
            this.cboTen.Location = new System.Drawing.Point(134, 109);
            this.cboTen.Name = "cboTen";
            this.cboTen.Size = new System.Drawing.Size(213, 24);
            this.cboTen.TabIndex = 19;
            this.cboTen.SelectedIndexChanged += new System.EventHandler(this.cboTen_SelectedIndexChanged);
            // 
            // txtTinChi
            // 
            this.txtTinChi.Location = new System.Drawing.Point(134, 161);
            this.txtTinChi.Name = "txtTinChi";
            this.txtTinChi.Size = new System.Drawing.Size(213, 22);
            this.txtTinChi.TabIndex = 20;
            // 
            // lbTinchi
            // 
            this.lbTinchi.AutoSize = true;
            this.lbTinchi.Location = new System.Drawing.Point(31, 161);
            this.lbTinchi.Name = "lbTinchi";
            this.lbTinchi.Size = new System.Drawing.Size(60, 16);
            this.lbTinchi.TabIndex = 21;
            this.lbTinchi.Text = "Số tín chỉ";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(178, 277);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(132, 23);
            this.btnCapNhat.TabIndex = 22;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // FormQuanLyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 450);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.lbTinchi);
            this.Controls.Add(this.txtTinChi);
            this.Controls.Add(this.cboTen);
            this.Controls.Add(this.cboMa);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.lblHienThiMonHoc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnXoaMonHoc);
            this.Controls.Add(this.btnThemMonHoc);
            this.Controls.Add(this.btnTimKiemMonHoc);
            this.Controls.Add(this.lblMaMonHoc);
            this.Name = "FormQuanLyMonHoc";
            this.Text = "Quản lý môn học";
            this.Load += new System.EventHandler(this.FormQuanLyMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaMonHoc;
        private System.Windows.Forms.Button btnTimKiemMonHoc;
        private System.Windows.Forms.Button btnThemMonHoc;
        private System.Windows.Forms.Button btnXoaMonHoc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblHienThiMonHoc;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.ComboBox cboMa;
        private System.Windows.Forms.ComboBox cboTen;
        private System.Windows.Forms.TextBox txtTinChi;
        private System.Windows.Forms.Label lbTinchi;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnCapNhat;
    }
}