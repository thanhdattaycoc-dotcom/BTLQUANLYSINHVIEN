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
        string connStr = @"Data Source=LAPTOP-HPIHPRR9\DONG4;Initial Catalog=QLSinhVien;Integrated Security=True";
            
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

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa giảng viên này?",
                                                  "Xác nhận xóa",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM tblGiangVien WHERE MaGV = @MaGV", conn);
                    cmd.Parameters.AddWithValue("@MaGV", maGV);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Xóa thành công!");
                FormQuanLyGiangVien_Load(sender, e); // refresh lại DataGridView
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemGiangVien formThem = new FormThemGiangVien();
            formThem.ShowDialog();
            FormQuanLyGiangVien_Load(sender, e); // refresh lại sau khi thêm
        }
    }
}
