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
            string connStr = @"Data Source=LAPTOP-HPIHPRR9\DONG3;Initial Catalog=QLSinhVien;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = @"SELECT m.TenMon, m.SoTinChi, d.DiemTX, d.DiemGK, d.DiemCK
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
            double tongTinChi = 0;



            foreach (DataRow row in dt.Rows)
            {
                row["STT"] = stt++;
                double tx = Convert.ToDouble(row["DiemTX"]);
                double gk = Convert.ToDouble(row["DiemGK"]);
                double ck = Convert.ToDouble(row["DiemCK"]);
                double soTinChi = Convert.ToDouble(row["SoTinChi"]);
                double tb = TinhDiemTB(tx, gk, ck);
                row["DiemTB"] = tb;

                if (tb >= 4)
                {
                    tongDiem += tb*soTinChi;
                    soMonQua++;
                    tongTinChi += soTinChi;
                    
                }
                else
                {
           
                    soMonHocLai++;
                }
            }

            DataGridViewBangDiem.DataSource = dt;


            // Điểm trung bình chung (bỏ môn <4)
           
            double diemTBChung = (soMonQua > 0) ? tongDiem / tongTinChi : 0;
            lblTrungBinh.Text = "Điểm trung bình: " + diemTBChung.ToString("0.00");

            // Xếp loại
            string xepLoai;
            if (diemTBChung >= 8) xepLoai = "Giỏi";
            else if (diemTBChung >= 6) xepLoai = "Khá";
            else if (diemTBChung >= 4) xepLoai = "Trung bình";
            else xepLoai = "Yếu";
            lblXepLoai.Text = "Xếp loại học lực: " + xepLoai;

            lblQuaMon.Text = "Số tín chỉ tích lũy: " + tongTinChi;
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

        private void btnIn_Click(object sender, EventArgs e)
        {

            string MaSV = NhoTamThoi.MaSV;
            string connStr = @"Data Source=LAPTOP-HPIHPRR9\DONG3;Initial Catalog=QLSinhVien;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                DataSetSinhVien ds = new DataSetSinhVien();
                ds.EnforceConstraints = false;

                // tblSinhVien
              
                    SqlDataAdapter daSV = new SqlDataAdapter("SELECT * FROM tblSinhVien WHERE MaSV = @MaSV", conn);
               
                daSV.SelectCommand.Parameters.AddWithValue("@MaSV", MaSV);
                daSV.Fill(ds.Tables["tblLop"]);


                // tblLop (lọc theo MaLop)
                SqlDataAdapter daLop = new SqlDataAdapter("SELECT * FROM tblLop", conn);
              
                daLop.Fill(ds.Tables["tblLop"]);

                // tblDangKy (lọc theo MaLop)
                SqlDataAdapter daDK = new SqlDataAdapter(
                    "SELECT * FROM tblDangKy", conn);

                daDK.Fill(ds.Tables["tblDangKy"]);

                // tblDiem (lọc theo MaLop)
                SqlDataAdapter daDiem = new SqlDataAdapter(
                    "SELECT * FROM tblDiem ",
                    conn
                );
               
                daDiem.Fill(ds.Tables["tblDiem"]);

                // tblMonHoc (BẮT BUỘC phải có)
                new SqlDataAdapter(
                    "SELECT * FROM tblMonHoc",
                    conn
                ).Fill(ds.Tables["tblMonHoc"]);

                // tblGiangVien (nếu report có dùng)
                new SqlDataAdapter(
                    "SELECT * FROM tblGiangVien",
                    conn
                ).Fill(ds.Tables["tblGiangVien"]);

                // Gán report
               rptDiemCaNhan rpt = new rptDiemCaNhan();
                rpt.SetDataSource(ds);

                FormBangDiemCaNhan f = new FormBangDiemCaNhan();
                f.crystalReportViewer1.ReportSource = rpt;
                f.crystalReportViewer1.Refresh();
                f.ShowDialog();
            }
        }
    }
    }

