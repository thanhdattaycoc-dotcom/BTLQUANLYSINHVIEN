using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLQUANLYSINHVIEN
{
    public partial class FormDiemHocTap : Form
    {
        public FormDiemHocTap()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // 1. Hàm load dữ liệu từ DB
        private DataTable LoadBangDiem()
        {
            string connStr = "Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = @"SELECT m.TenMon, d.DiemTX, d.DiemGK, d.DiemCK
                         FROM tblDiem d
                         JOIN tblLop l ON d.MaLop = l.MaLop
                         JOIN tblMonHoc m ON l.MaMon = m.MaMon
                         WHERE d.MaSV = @MaSV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSV", NhoTamThoi.MaSV);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // 2. Hàm tính điểm trung bình môn
        private double TinhDiemTB(double tx, double gk, double ck)
        {
            return tx * 0.1 + gk * 0.2 + ck * 0.7;
        }

        // 3. Hàm xử lý bảng điểm và phân loại
        private void XuLyBangDiem(DataTable dt)
        {
            // Thêm cột STT ở đầu tiên
            dt.Columns.Add("STT", typeof(int));
            dt.Columns["STT"].SetOrdinal(0); // Đặt STT thành cột đầu tiên

            // Thêm cột ĐiểmTB ở cuối
            dt.Columns.Add("DiemTB", typeof(double));

            int stt = 1;
            double tongDiem = 0;
            int soMonQua = 0;
            int soMonHocLai = 0;

            DataTable dtHocLai = dt.Clone(); // bảng học lại

            foreach (DataRow row in dt.Rows)
            {
                row["STT"] = stt++;
                double tx = Convert.ToDouble(row["DiemTX"]);
                double gk = Convert.ToDouble(row["DiemGK"]);
                double ck = Convert.ToDouble(row["DiemCK"]);
                double tb = TinhDiemTB(tx, gk, ck);
                row["DiemTB"] = tb;

                if (tb >= 4)
                {
                    tongDiem += tb;
                    soMonQua++;
                }
                else
                {
                    dtHocLai.ImportRow(row);
                    soMonHocLai++;
                }
            }

            DataGridViewBangDiem.DataSource = dt;
            dataGridViewHocLai.DataSource = dtHocLai;

            // Điểm trung bình chung (bỏ môn <4)
            double diemTBChung = (soMonQua > 0) ? tongDiem / soMonQua : 0;
            lblTrungBinh.Text = "Điểm trung bình: " + diemTBChung.ToString("0.00");

            // Xếp loại
            string xepLoai;
            if (diemTBChung >= 8) xepLoai = "Giỏi";
            else if (diemTBChung >= 6) xepLoai = "Khá";
            else if (diemTBChung >= 4) xepLoai = "Trung bình";
            else xepLoai = "Yếu";
            lblXepLoai.Text = "Xếp loại học lực: " + xepLoai;

            lblQuaMon.Text = "Số môn tích lũy: " + soMonQua;
            lblHocLai.Text = "Số môn học lại: " + soMonHocLai;
        }


        private void FormDiemHocTap_Load(object sender, EventArgs e)
        {
            DataTable dt = LoadBangDiem();
            XuLyBangDiem(dt);
        }

        private void lblQuaMon_Click(object sender, EventArgs e)
        {

        }
    }
}
