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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DataGridViewBangDiem = new System.Windows.Forms.DataGridView();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.lblTrungBinh = new System.Windows.Forms.Label();
            this.lblQuaMon = new System.Windows.Forms.Label();
            this.lblXepLoai = new System.Windows.Forms.Label();
            this.dataGridViewHocLai = new System.Windows.Forms.DataGridView();
            this.lblHocLai = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBangDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHocLai)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBangDiem
            // 
            this.labelBangDiem.AutoSize = true;
            this.labelBangDiem.Location = new System.Drawing.Point(27, 20);
            this.labelBangDiem.Name = "labelBangDiem";
            this.labelBangDiem.Size = new System.Drawing.Size(166, 16);
            this.labelBangDiem.TabIndex = 0;
            this.labelBangDiem.Text = "Bảng điểm kết quả học tập";
            // 
            // DataGridViewBangDiem
            // 
            this.DataGridViewBangDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewBangDiem.Location = new System.Drawing.Point(30, 223);
            this.DataGridViewBangDiem.Name = "DataGridViewBangDiem";
            this.DataGridViewBangDiem.RowHeadersWidth = 51;
            this.DataGridViewBangDiem.RowTemplate.Height = 24;
            this.DataGridViewBangDiem.Size = new System.Drawing.Size(758, 199);
            this.DataGridViewBangDiem.TabIndex = 1;
            this.DataGridViewBangDiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(262, 151);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(82, 32);
            this.btnQuayLai.TabIndex = 10;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // lblTrungBinh
            // 
            this.lblTrungBinh.AutoSize = true;
            this.lblTrungBinh.Location = new System.Drawing.Point(27, 68);
            this.lblTrungBinh.Name = "lblTrungBinh";
            this.lblTrungBinh.Size = new System.Drawing.Size(101, 16);
            this.lblTrungBinh.TabIndex = 11;
            this.lblTrungBinh.Text = "Điểm trung bình:";
            // 
            // lblQuaMon
            // 
            this.lblQuaMon.AutoSize = true;
            this.lblQuaMon.Location = new System.Drawing.Point(27, 130);
            this.lblQuaMon.Name = "lblQuaMon";
            this.lblQuaMon.Size = new System.Drawing.Size(96, 16);
            this.lblQuaMon.TabIndex = 12;
            this.lblQuaMon.Text = "Số môn tích lũy";
            this.lblQuaMon.Click += new System.EventHandler(this.lblQuaMon_Click);
            // 
            // lblXepLoai
            // 
            this.lblXepLoai.AutoSize = true;
            this.lblXepLoai.Location = new System.Drawing.Point(27, 99);
            this.lblXepLoai.Name = "lblXepLoai";
            this.lblXepLoai.Size = new System.Drawing.Size(104, 16);
            this.lblXepLoai.TabIndex = 13;
            this.lblXepLoai.Text = "Xếp loại học lực:";
            // 
            // dataGridViewHocLai
            // 
            this.dataGridViewHocLai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHocLai.Location = new System.Drawing.Point(445, 12);
            this.dataGridViewHocLai.Name = "dataGridViewHocLai";
            this.dataGridViewHocLai.RowHeadersWidth = 51;
            this.dataGridViewHocLai.RowTemplate.Height = 24;
            this.dataGridViewHocLai.Size = new System.Drawing.Size(343, 193);
            this.dataGridViewHocLai.TabIndex = 14;
            this.dataGridViewHocLai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // lblHocLai
            // 
            this.lblHocLai.AutoSize = true;
            this.lblHocLai.Location = new System.Drawing.Point(27, 167);
            this.lblHocLai.Name = "lblHocLai";
            this.lblHocLai.Size = new System.Drawing.Size(98, 16);
            this.lblHocLai.TabIndex = 15;
            this.lblHocLai.Text = "Số môn học lại:";
            // 
            // FormDiemHocTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHocLai);
            this.Controls.Add(this.dataGridViewHocLai);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHocLai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBangDiem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView DataGridViewBangDiem;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Label lblTrungBinh;
        private System.Windows.Forms.Label lblQuaMon;
        private System.Windows.Forms.Label lblXepLoai;
        private System.Windows.Forms.DataGridView dataGridViewHocLai;
        private System.Windows.Forms.Label lblHocLai;
    }
}