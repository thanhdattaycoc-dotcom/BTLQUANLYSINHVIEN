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
    public partial class FormLichHoc : Form
    {
        public FormLichHoc()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormLichHoc_Load(object sender, EventArgs e)
        {
            lblThoiKhoaBieu.Text = "THỜI KHÓA BIỂU SINH VIÊN";

            // Khởi tạo cột Thứ 2 -> Chủ nhật
            dataGridView1.Columns.Clear();
            for (int thu = 2; thu <= 8; thu++) // 2=Thứ 2, 8=Chủ nhật
            {
                string colName = "Thu" + thu;
                string header = (thu == 8) ? "Chủ nhật" : "Thứ " + thu;
                dataGridView1.Columns.Add(colName, header);
            }

            // Thêm 3 dòng trống
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();

            // Đặt header cho từng dòng
            dataGridView1.Rows[0].HeaderCell.Value = "Sáng (1-4)";
            dataGridView1.Rows[1].HeaderCell.Value = "Chiều (5-8)";
            dataGridView1.Rows[2].HeaderCell.Value = "Tối (9-12)";

            // 👉 Chỉnh độ cao dòng
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.RowHeadersWidth = 100;


            // Load dữ liệu từ DB
            string connStr = @"Data Source=LAPTOP-HPIHPRR9\DONG3;Initial Catalog=QLSinhVien;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = @"SELECT 
                                l.TenLop, 
                                m.TenMon, 
                                gv.TenGV,   -- thêm tên giáo viên
                                l.Thu, 
                                l.Tiet, 
                                l.Phong
                            FROM tblDangKy dk
                            JOIN tblLop l ON dk.MaLop = l.MaLop
                            JOIN tblMonHoc m ON l.MaMon = m.MaMon
                            JOIN tblGiangVien gv ON l.MaGV = gv.MaGV   -- JOIN thêm
                            WHERE dk.MaSV = @MaSV;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSV", NhoTamThoi.MaSV);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int thu = Convert.ToInt32(reader["Thu"]); // 2-8
                    string tietStr = reader["Tiet"].ToString(); // ví dụ "1-3"
                    string monHoc = reader["TenMon"].ToString();
                    string lop = reader["TenLop"].ToString();
                    string phong = reader["Phong"].ToString();
                    string giaovien = reader["TenGV"].ToString();

                    // Parse tiết để xác định ca
                    string[] range = tietStr.Split('-');
                    int startTiet = int.Parse(range[0]);

                    int rowIndex;
                    if (startTiet <= 4) rowIndex = 0;       // Sáng
                    else if (startTiet <= 8) rowIndex = 1;  // Chiều
                    else rowIndex = 2;                      // Tối

                    dataGridView1.Rows[rowIndex].Cells[thu - 2].Value =
                        monHoc + "\n" + lop + "\n"+ giaovien +"\nPhòng: " + phong;
                }
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            FormLichHoc frm = new FormLichHoc();
            this.Close();
        }
    }
}
