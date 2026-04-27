namespace BTLQUANLYSINHVIEN
{
    partial class FormDiemHocTap
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
            this.labelBangDiem = new System.Windows.Forms.Label();
            this.DataGridViewBangDiem = new System.Windows.Forms.DataGridView();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.lblTrungBinh = new System.Windows.Forms.Label();
            this.lblQuaMon = new System.Windows.Forms.Label();
            this.lblXepLoai = new System.Windows.Forms.Label();
            this.lblHocLai = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBangDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBangDiem
            // 
            this.labelBangDiem.AutoSize = true;
            this.labelBangDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBangDiem.Location = new System.Drawing.Point(12, 226);
            this.labelBangDiem.Name = "labelBangDiem";
            this.labelBangDiem.Size = new System.Drawing.Size(213, 20);
            this.labelBangDiem.TabIndex = 0;
            this.labelBangDiem.Text = "Bảng điểm kết quả học tập:";
            // 
            // DataGridViewBangDiem
            // 
            this.DataGridViewBangDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewBangDiem.Location = new System.Drawing.Point(9, 259);
            this.DataGridViewBangDiem.Name = "DataGridViewBangDiem";
            this.DataGridViewBangDiem.RowHeadersWidth = 51;
            this.DataGridViewBangDiem.RowTemplate.Height = 24;
            this.DataGridViewBangDiem.Size = new System.Drawing.Size(970, 261);
            this.DataGridViewBangDiem.TabIndex = 1;
            this.DataGridViewBangDiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Location = new System.Drawing.Point(853, 199);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(108, 47);
            this.btnQuayLai.TabIndex = 10;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // lblTrungBinh
            // 
            this.lblTrungBinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrungBinh.Location = new System.Drawing.Point(12, 23);
            this.lblTrungBinh.Name = "lblTrungBinh";
            this.lblTrungBinh.Size = new System.Drawing.Size(202, 32);
            this.lblTrungBinh.TabIndex = 11;
            this.lblTrungBinh.Text = "Điểm trung bình:";
            // 
            // lblQuaMon
            // 
            this.lblQuaMon.AutoSize = true;
            this.lblQuaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuaMon.Location = new System.Drawing.Point(7, 128);
            this.lblQuaMon.Name = "lblQuaMon";
            this.lblQuaMon.Size = new System.Drawing.Size(147, 20);
            this.lblQuaMon.TabIndex = 12;
            this.lblQuaMon.Text = "Số tín chỉ tích lũy: ";
            this.lblQuaMon.Click += new System.EventHandler(this.lblQuaMon_Click);
            // 
            // lblXepLoai
            // 
            this.lblXepLoai.AutoSize = true;
            this.lblXepLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXepLoai.Location = new System.Drawing.Point(438, 23);
            this.lblXepLoai.Name = "lblXepLoai";
            this.lblXepLoai.Size = new System.Drawing.Size(133, 20);
            this.lblXepLoai.TabIndex = 13;
            this.lblXepLoai.Text = "Xếp loại học lực:";
            // 
            // lblHocLai
            // 
            this.lblHocLai.AutoSize = true;
            this.lblHocLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHocLai.Location = new System.Drawing.Point(438, 128);
            this.lblHocLai.Name = "lblHocLai";
            this.lblHocLai.Size = new System.Drawing.Size(125, 20);
            this.lblHocLai.TabIndex = 15;
            this.lblHocLai.Text = "Số môn học lại:";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(848, 27);
            this.btnIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(113, 28);
            this.btnIn.TabIndex = 44;
            this.btnIn.Text = "In thông tin";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // FormDiemHocTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 541);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.lblHocLai);
            this.Controls.Add(this.lblXepLoai);
            this.Controls.Add(this.lblQuaMon);
            this.Controls.Add(this.lblTrungBinh);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.DataGridViewBangDiem);
            this.Controls.Add(this.labelBangDiem);
            this.Name = "FormDiemHocTap";
            this.Text = "Điểm học tập";
            this.Load += new System.EventHandler(this.FormDiemHocTap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBangDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBangDiem;
        private System.Windows.Forms.DataGridView DataGridViewBangDiem;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Label lblTrungBinh;
        private System.Windows.Forms.Label lblQuaMon;
        private System.Windows.Forms.Label lblXepLoai;
        private System.Windows.Forms.Label lblHocLai;
        private System.Windows.Forms.Button btnIn;
    }
}