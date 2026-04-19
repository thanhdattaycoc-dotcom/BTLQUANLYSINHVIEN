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
    public partial class FormQuanLySinhVien : Form
    {
        public FormQuanLySinhVien()
        {
            InitializeComponent();
        }
        string connStr = "Data Source=LAPTOP-K3A92CEE;Initial Catalog=QLSinhVien;Integrated Security=True";

        // Load toàn bộ danh sách sinh viên khi mở form
        
        private void FormQuanLySinhVien_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tblSinhVien";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maSV = txtTimKiem.Text.Trim();
            string query = "SELECT * FROM tblSinhVien WHERE MaSV = @MaSV";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@MaSV", maSV);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSV = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(maSV))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa sinh viên này?",
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

                        // 1. tblDiem
                        cmd = new SqlCommand("DELETE FROM tblDiem WHERE MaSV=@Ma", conn, trans);
                        cmd.Parameters.AddWithValue("@Ma", maSV);
                        cmd.ExecuteNonQuery();

                        // 2. tblDangKy
                        cmd = new SqlCommand("DELETE FROM tblDangKy WHERE MaSV=@Ma", conn, trans);
                        cmd.Parameters.AddWithValue("@Ma", maSV);
                        cmd.ExecuteNonQuery();

                        // 3. tblUser
                        cmd = new SqlCommand("DELETE FROM tblUser WHERE MaSV=@Ma", conn, trans);
                        cmd.Parameters.AddWithValue("@Ma", maSV);
                        cmd.ExecuteNonQuery();

                        // 4. tblSinhVien
                        cmd = new SqlCommand("DELETE FROM tblSinhVien WHERE MaSV=@Ma", conn, trans);
                        cmd.Parameters.AddWithValue("@Ma", maSV);
                        cmd.ExecuteNonQuery();

                        trans.Commit();

                        MessageBox.Show("Xóa thành công!");
                        FormQuanLySinhVien_Load(sender, e);
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
            FormThemSinhVien formThem = new FormThemSinhVien();
            formThem.ShowDialog();
            FormQuanLySinhVien_Load(sender, e); // refresh lại sau khi thêm
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
