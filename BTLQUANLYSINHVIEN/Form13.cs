using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTLQUANLYSINHVIEN
{
    public partial class FormQuanLyLopHoc : Form
    {
        string connStr = "Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True";
      
        public FormQuanLyLopHoc()
        {
            InitializeComponent();
        }

        private void FormQuanLyLopHoc_Load(object sender, EventArgs e)
        {
            LoadLopHoc();
   
        }
        void LoadLopHoc()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sql = @"SELECT * FROM tblLop";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvLop.DataSource = dt;
                cboTenLop.DataSource = dt;
                cboTenLop.DisplayMember = "TenLop"; // hiển thị
                cboTenLop.ValueMember = "MaLop";    // giá trị

                cboTenLop.SelectedIndex = -1; // không chọn sẵn

            }
        }

        // ================= LOAD COMBO =================
       

        private void dgvLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboTenLop.Text))
            {
                MessageBox.Show("Mời bạn chọn tên lớp!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string sql = @"SELECT * FROM tblLop";

                SqlCommand cmd = new SqlCommand();

            
                    sql += " AND l.TenLop = @TenLop";
                    cmd.Parameters.AddWithValue("@TenLop", cboTenLop.Text.Trim());
                
                cmd.CommandText = sql;
                cmd.Connection = conn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvLop.DataSource = dt;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboTenLop.Text))
            {
                MessageBox.Show("Chọn ten  lớp cần xóa!");
                return;
            }

            if (MessageBox.Show("Xóa lớp này?", "Xác nhận",
                MessageBoxButtons.YesNo) == DialogResult.No) return;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                // Xóa dữ liệu liên quan trước (tránh lỗi FK)
                SqlCommand cmd0 = new SqlCommand("DELETE FROM tblDiem WHERE TenLop=@TenLop", conn);
                cmd0.Parameters.AddWithValue("@TenLop", cboTenLop.Text);
                cmd0.ExecuteNonQuery();

                SqlCommand cmd1 = new SqlCommand("DELETE FROM tblDangKy WHERE TenLop=@TenLop", conn);
                cmd1.Parameters.AddWithValue("@TenLop", cboTenLop.Text);
                cmd1.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("DELETE FROM tblLop WHERE TenLop=@TenLop", conn);
                cmd2.Parameters.AddWithValue("@TenLop", cboTenLop.Text);

                int rows = cmd2.ExecuteNonQuery();

                MessageBox.Show(rows > 0 ? "Xóa thành công" : "Không tìm thấy");

                LoadLopHoc();
               
            }
        }

     

        private void cboTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            FormThemLopHoc f = new FormThemLopHoc();
            f.ShowDialog();
            LoadLopHoc();
           
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
