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
    public partial class FormQuanLyLopHoc : Form
    {
        public FormQuanLyLopHoc()
        {
            InitializeComponent();
        }

        private void lblHienThiMonHoc_Click(object sender, EventArgs e)
        {

        }

        private void FormQuanLyLopHoc_Load(object sender, EventArgs e)
        {
            LoadMonHoc();
            LoadLopHoc();
        }
        private void LoadMonHoc()
        {
            string connStr = "Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblMonHoc", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void LoadLopHoc()
        {
            string connStr = "Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblLop", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
            }
        }

        private void btnTimKiemMonHoc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaMonHoc.Text))
            {
                MessageBox.Show("Vui lòng nhập mã môn học!");
                return;
            }

            string connStr = "Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblMonHoc WHERE MaMon=@MaMon", conn);
                da.SelectCommand.Parameters.AddWithValue("@MaMon", txtMaMonHoc.Text.Trim());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnTimKiemMaLop_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLop.Text))
            {
                MessageBox.Show("Vui lòng nhập mã lớp học!");
                return;
            }

            string connStr = "Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblLopHoc WHERE MaLop=@MaLop", conn);
                da.SelectCommand.Parameters.AddWithValue("@MaLop", txtMaLop.Text.Trim());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnXoaMonHoc_Click(object sender, EventArgs e)
        {
         
            if (string.IsNullOrEmpty(txtMaMonHoc.Text))
            {
                MessageBox.Show("Vui lòng nhập mã môn học cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa môn học này?",
                                                  "Xác nhận xóa",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string connStr = "Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM tblMonHoc WHERE MaMon=@MaMon", conn);
                    cmd.Parameters.AddWithValue("@MaMon", txtMaMonHoc.Text.Trim());
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Xóa thành công!");
                        LoadMonHoc(); // refresh lại bảng
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy môn học để xóa!");
                    }
                }
            }
        }

        private void btnXoaMaLop_Click(object sender, EventArgs e)
        {
        
            if (string.IsNullOrEmpty(txtMaLop.Text))
            {
                MessageBox.Show("Vui lòng nhập mã lớp học cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp học này?",
                                                  "Xác nhận xóa",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string connStr = "Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM tblLopHoc WHERE MaLop=@MaLop", conn);
                    cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text.Trim());
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Xóa thành công!");
                        LoadLopHoc(); // refresh lại bảng
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy lớp để xóa!");
                    }
                }
            }
        }

        private void btnThemMonHoc_Click(object sender, EventArgs e)
        {
            FormThemMonHoc frm = new FormThemMonHoc();
            frm.ShowDialog();
            LoadMonHoc(); // refresh lại sau khi thêm
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            FormThemLopHoc frm = new FormThemLopHoc();
            frm.ShowDialog();
            LoadLopHoc(); // refresh lại sau khi thêm
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

