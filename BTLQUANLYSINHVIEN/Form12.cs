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
    public partial class FormQuanLyNhapDiem : Form
    {

        string connStr = @"Data Source=LAPTOP-K3A92CEE;Initial Catalog=QLSinhVien;Integrated Security=True";
        public FormQuanLyNhapDiem()
        {
            InitializeComponent();
        }
        private void LoadBangDiemTheoLop(string maLop)
        {
            using (SqlConnection conn = new SqlConnection(connStr)) {
                string sql = @"
        SELECT 
            L.MaLop,
            M.TenMon,
            SV.MaSV,
            SV.TenSV,
            D.DiemTX,
            D.DiemGK,
            D.DiemCK,
            CAST(ROUND(
            (ISNULL(D.DiemTX,0)*0.2 + ISNULL(D.DiemGK,0)*0.3 + ISNULL(D.DiemCK,0)*0.5),
            2) AS FLOAT) AS DiemTB
        FROM tblLop L
        JOIN tblMonHoc M ON L.MaMon = M.MaMon
        JOIN tblDangKy DK ON L.MaLop = DK.MaLop
        JOIN tblSinhVien SV ON DK.MaSV = SV.MaSV
        LEFT JOIN tblDiem D ON SV.MaSV = D.MaSV AND L.MaLop = D.MaLop
        WHERE L.MaLop = @MaLop";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@MaLop", maLop);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewTheoLop.DataSource = dt;
                dataGridViewTheoLop.Columns["DiemTB"].ReadOnly = true;
            }
        }

        private void FormQuanLyNhapDiem_Load(object sender, EventArgs e)
        {
          
            cboMaLop.SelectedIndexChanged -= cboMaLop_SelectedIndexChanged;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string sql = @"SELECT MaLop FROM tblLop WHERE MaGV = @MaGV";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@MaGV", NhoTamThoi.MaGV);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cboMaLop.DataSource = dt;
                cboMaLop.DisplayMember = "MaLop";
                cboMaLop.ValueMember = "MaLop";

                cboMaLop.SelectedIndex = -1;
            }

            cboMaLop.SelectedIndexChanged += cboMaLop_SelectedIndexChanged;
        
        }

        private void cboMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {


                string maLop = cboMaLop.SelectedValue.ToString();

                // Hiện tên môn và mã môn
                SqlCommand cmd = new SqlCommand(
                    "SELECT L.MaMon, M.TenMon FROM tblLop L JOIN tblMonHoc M ON L.MaMon=M.MaMon WHERE L.MaLop=@MaLop", conn);
                cmd.Parameters.AddWithValue("@MaLop", maLop);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lblMaMon.Text = "Mã môn: " + dr["MaMon"].ToString();
                    lblTenMon.Text = "Tên môn: " + dr["TenMon"].ToString();
                }
                conn.Close();

                // Load sinh viên đăng ký lớp
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT SV.MaSV FROM tblDangKy DK JOIN tblSinhVien SV ON DK.MaSV=SV.MaSV WHERE DK.MaLop=@MaLop", conn);
                da.SelectCommand.Parameters.AddWithValue("@MaLop", maLop);
                DataTable dt = new DataTable();
                da.Fill(dt);
                LoadBangDiemTheoLop(maLop);

            }
        }





        private void label5_Click(object sender, EventArgs e)
        {

        }

        
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        



        private void lblTheoMon_Click(object sender, EventArgs e)
        {

        }

       
        private void btnThem_Click(object sender, EventArgs e)
        {
         
           if( cboMaLop.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn lớp trước!");
                return;
            }


            string maLop = cboMaLop.SelectedValue.ToString();


            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                foreach (DataGridViewRow row in dataGridViewTheoLop.Rows)
                {
                    if (row.IsNewRow) continue;

                    string maSV = row.Cells["MaSV"].Value.ToString();

                    float diemTX = Convert.ToSingle(row.Cells["DiemTX"].Value);
                    float diemGK = Convert.ToSingle(row.Cells["DiemGK"].Value);
                    float diemCK = Convert.ToSingle(row.Cells["DiemCK"].Value);

                    // kiểm tra đã tồn tại chưa
                    string checkSql = @"SELECT COUNT(*) FROM tblDiem 
                                WHERE MaSV=@MaSV AND MaLop=@MaLop";

                    SqlCommand checkCmd = new SqlCommand(checkSql, conn);
                    checkCmd.Parameters.AddWithValue("@MaSV", maSV);
                    checkCmd.Parameters.AddWithValue("@MaLop", maLop);

                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        // UPDATE
                        string updateSql = @"UPDATE tblDiem
                                     SET DiemTX=@DiemTX,
                                         DiemGK=@DiemGK,
                                         DiemCK=@DiemCK
                                     WHERE MaSV=@MaSV AND MaLop=@MaLop";

                        SqlCommand updateCmd = new SqlCommand(updateSql, conn);
                        updateCmd.Parameters.AddWithValue("@DiemTX", diemTX);
                        updateCmd.Parameters.AddWithValue("@DiemGK", diemGK);
                        updateCmd.Parameters.AddWithValue("@DiemCK", diemCK);
                        updateCmd.Parameters.AddWithValue("@MaSV", maSV);
                        updateCmd.Parameters.AddWithValue("@MaLop", maLop);

                        updateCmd.ExecuteNonQuery();
                    }
                    else
                    {
                        // INSERT
                        string insertSql = @"INSERT INTO tblDiem(MaSV, MaLop, DiemTX, DiemGK, DiemCK)
                                    VALUES(@MaSV, @MaLop, @DiemTX, @DiemGK, @DiemCK)";

                        SqlCommand insertCmd = new SqlCommand(insertSql, conn);
                        insertCmd.Parameters.AddWithValue("@MaSV", maSV);
                        insertCmd.Parameters.AddWithValue("@MaLop", maLop);
                        insertCmd.Parameters.AddWithValue("@DiemTX", diemTX);
                        insertCmd.Parameters.AddWithValue("@DiemGK", diemGK);
                        insertCmd.Parameters.AddWithValue("@DiemCK", diemCK);

                        insertCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Lưu điểm thành công!");
            }
        }
        

        private void txtDiemTX_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMaLop_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewTheoLop_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewTheoLop.IsCurrentCellDirty)
            {
                dataGridViewTheoLop.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridViewTheoLop_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridViewTheoLop.Rows[e.RowIndex];

            try
            {
                float tx = row.Cells["DiemTX"].Value != null ? Convert.ToSingle(row.Cells["DiemTX"].Value) : 0;
                float gk = row.Cells["DiemGK"].Value != null ? Convert.ToSingle(row.Cells["DiemGK"].Value) : 0;
                float ck = row.Cells["DiemCK"].Value != null ? Convert.ToSingle(row.Cells["DiemCK"].Value) : 0;

                float tb = tx * 0.2f + gk * 0.3f + ck * 0.5f;

                row.Cells["DiemTB"].Value = tb.ToString("0.00");
            }
            catch
            {
                // bỏ qua lỗi nhập sai kiểu
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (cboMaLop.SelectedValue == null || cboMaLop.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn lớp trước khi in!");
                return;
            }
            string MaLop = cboMaLop.SelectedValue.ToString();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                DataSetSinhVien ds = new DataSetSinhVien();
                ds.EnforceConstraints = false;

                // tblSinhVien
                new SqlDataAdapter(
                    "SELECT * FROM tblSinhVien",conn).Fill(ds.Tables["tblSinhVien"]);

                // tblLop (lọc theo MaLop)
                SqlDataAdapter daLop = new SqlDataAdapter("SELECT * FROM tblLop WHERE MaLop = @MaLop",conn);
                daLop.SelectCommand.Parameters.AddWithValue("@MaLop", MaLop);
                daLop.Fill(ds.Tables["tblLop"]);

                // tblDangKy (lọc theo MaLop)
                SqlDataAdapter daDK = new SqlDataAdapter(
                    "SELECT * FROM tblDangKy WHERE MaLop = @MaLop",conn);
                daDK.SelectCommand.Parameters.AddWithValue("@MaLop", MaLop);
                daDK.Fill(ds.Tables["tblDangKy"]);

                // tblDiem (lọc theo MaLop)
                SqlDataAdapter daDiem = new SqlDataAdapter(
                    "SELECT * FROM tblDiem WHERE MaLop = @MaLop",
                    conn
                );
                daDiem.SelectCommand.Parameters.AddWithValue("@MaLop", MaLop);
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
                rptQuanLyDiemLop rpt = new rptQuanLyDiemLop();
                rpt.SetDataSource(ds);

                FormQuanlyDiemLop f = new FormQuanlyDiemLop();
                f.crystalReportViewer1.ReportSource = rpt;
                f.crystalReportViewer1.Refresh();
                f.ShowDialog();
            }
        }
    }
}
