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
    public partial class FormQuanLyGiangVien : Form
    {
        public FormQuanLyGiangVien()
        {
            InitializeComponent();
        }
        string connStr = @"Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True";
            
        private void FormQuanLyGiangVien_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tblGiangVien";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        
        

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            string maGV = txtTimKiem.Text.Trim();
            string query = "SELECT * FROM tblGiangVien WHERE MaGV = @MaGV";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@MaGV", maGV);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
          
            string maGV = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(maGV))
            {
                MessageBox.Show("Vui lòng nhập mã giảng viên cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa giảng viên này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlTransaction trans = conn.BeginTransaction();

                    try
                    {
                        SqlCommand cmd;
                        // 1. tblDangKy (phụ thuộc tblLop)
                        cmd = new SqlCommand(@"
                    DELETE FROM tblDangKy 
                    WHERE MaLop IN (SELECT MaLop FROM tblLop WHERE MaGV = @Ma)", conn, trans);
                        cmd.Parameters.AddWithValue("@Ma", maGV);
                        cmd.ExecuteNonQuery();
                        // 2. tblUser
                        cmd = new SqlCommand("DELETE FROM tblUser WHERE MaGV=@Ma", conn, trans);
                        cmd.Parameters.AddWithValue("@Ma", maGV);
                        cmd.ExecuteNonQuery();

                        // 3. tblLop
                        cmd = new SqlCommand("DELETE FROM tblLop WHERE MaGV=@Ma", conn, trans);
                        cmd.Parameters.AddWithValue("@Ma", maGV);
                        cmd.ExecuteNonQuery();

                        // 4. tblGiangVien
                        cmd = new SqlCommand("DELETE FROM tblGiangVien WHERE MaGV=@Ma", conn, trans);
                        cmd.Parameters.AddWithValue("@Ma", maGV);
                        cmd.ExecuteNonQuery();

                        trans.Commit();

                        MessageBox.Show("Xóa thành công!");
                        FormQuanLyGiangVien_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                    }
                }
            }
        
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemGiangVien formThem = new FormThemGiangVien();
            formThem.ShowDialog();
            FormQuanLyGiangVien_Load(sender, e); // refresh lại sau khi thêm
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string sql = "SELECT * FROM tblGiangVien";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            rptQuanLyGiangVien rpt = new rptQuanLyGiangVien();
            rpt.SetDataSource(dt);

            FormQuanlyGV f = new FormQuanlyGV();
            f.crystalReportViewer1.ReportSource = rpt;
            f.ShowDialog();
        }
    }
}
