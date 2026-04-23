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
            this.lblMaMon = new System.Windows.Forms.Label();
            this.dataGridViewTheoLop = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.cboMaLop = new System.Windows.Forms.ComboBox();
            this.btnIn = new System.Windows.Forms.Button();
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
            this.lblMaLop.Click += new System.EventHandler(this.lblMaLop_Click);
            // 
            // lblMaMon
            // 
            this.lblMaMon.AutoSize = true;
            this.lblMaMon.Location = new System.Drawing.Point(758, 27);
            this.lblMaMon.Name = "lblMaMon";
            this.lblMaMon.Size = new System.Drawing.Size(58, 16);
            this.lblMaMon.TabIndex = 2;
            this.lblMaMon.Text = "Mã môn:";
            // 
            // dataGridViewTheoLop
            // 
            this.dataGridViewTheoLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTheoLop.Location = new System.Drawing.Point(37, 109);
            this.dataGridViewTheoLop.Name = "dataGridViewTheoLop";
            this.dataGridViewTheoLop.RowHeadersWidth = 51;
            this.dataGridViewTheoLop.RowTemplate.Height = 24;
            this.dataGridViewTheoLop.Size = new System.Drawing.Size(1231, 473);
            this.dataGridViewTheoLop.TabIndex = 12;
            this.dataGridViewTheoLop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewTheoLop.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTheoLop_CellValueChanged);
            this.dataGridViewTheoLop.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewTheoLop_CurrentCellDirtyStateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Bảng điểm theo lớp ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(277, 594);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(302, 52);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu Lại";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(681, 594);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(302, 52);
            this.btnQuayLai.TabIndex = 18;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Location = new System.Drawing.Point(423, 27);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(63, 16);
            this.lblTenMon.TabIndex = 20;
            this.lblTenMon.Text = "Tên môn:";
            // 
            // cboMaLop
            // 
            this.cboMaLop.FormattingEnabled = true;
            this.cboMaLop.Location = new System.Drawing.Point(156, 24);
            this.cboMaLop.Name = "cboMaLop";
            this.cboMaLop.Size = new System.Drawing.Size(244, 24);
            this.cboMaLop.TabIndex = 11;
            this.cboMaLop.SelectedIndexChanged += new System.EventHandler(this.cboMaLop_SelectedIndexChanged);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(1175, 1);
            this.btnIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(113, 28);
            this.btnIn.TabIndex = 43;
            this.btnIn.Text = "In thông tin";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // FormQuanLyNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 658);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.lblTenMon);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTheoLop);
            this.Controls.Add(this.cboMaLop);
            this.Controls.Add(this.lblMaMon);
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
        private System.Windows.Forms.Label lblMaMon;
        private System.Windows.Forms.DataGridView dataGridViewTheoLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.ComboBox cboMaLop;
        private System.Windows.Forms.Button btnIn;
    }
}