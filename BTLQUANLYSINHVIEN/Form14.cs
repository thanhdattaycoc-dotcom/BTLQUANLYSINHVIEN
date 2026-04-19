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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTLQUANLYSINHVIEN
{
    public partial class FormQuanLyMonHoc : Form
    {
        public FormQuanLyMonHoc()
        {
            InitializeComponent();
        }

        private void FormQuanLyMonHoc_Load(object sender, EventArgs e)
        {
            LoadMonHoc();
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

        private void btnTimKiemMonHoc_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(cboMa.Text) && (string.IsNullOrEmpty(cboTen.Text)))
            {
                MessageBox.Show("Vui lòng chọn mã môn học hoặc tên môn học!");
                return;
            }

            string connStr = "Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                if (!string.IsNullOrEmpty(cboMa.Text))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblMonHoc WHERE MaMon=@MaMon", conn);
                    da.SelectCommand.Parameters.AddWithValue("@MaMon", cboMa.Text.Trim());
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else if (!string.IsNullOrEmpty(cboTen.Text))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblMonHoc WHERE TenMon=@TenMon", conn);
                    da.SelectCommand.Parameters.AddWithValue("@TenMon", cboTen.Text.Trim());
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }


            }
        }

        private void btnXoaMonHoc_Click(object sender, EventArgs e)
        {
         

            if (string.IsNullOrEmpty(cboMa.Text) && string.IsNullOrEmpty(cboTen.Text ))
            {
                MessageBox.Show("Vui lòng nhập mã môn học hoặc tên môn học cần xóa!");
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

                    if (!string.IsNullOrEmpty(cboMa.Text))
                    {
                        SqlCommand cmd = new SqlCommand("DELETE FROM tblMonHoc WHERE MaMon=@MaMon", conn);
                        cmd.Parameters.AddWithValue("@MaMon", cboMa.Text.Trim());
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
                    else if(!string.IsNullOrEmpty(cboTen.Text))
                    {

                        SqlCommand cmd = new SqlCommand("DELETE FROM tblMonHoc WHERE TenMon=@TenMon", conn);
                        cmd.Parameters.AddWithValue("@TenMon", cboMa.Text.Trim());
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
        }

        private void btnThemMonHoc_Click(object sender, EventArgs e)
        {
            string maMon = cboMa.Text.Trim();
            string tenMon = cboTen.Text.Trim();
            int soTinChi;

            if (string.IsNullOrEmpty(maMon) || string.IsNullOrEmpty(tenMon) || !int.TryParse(txtTinChi.Text.Trim(), out soTinChi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và số tín chỉ phải là số!");
                return;
            }

            string connStr = "Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "INSERT INTO tblMonHoc (MaMon, TenMon, SoTinChi) VALUES (@MaMon, @TenMon, @SoTinChi)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaMon", maMon);
                cmd.Parameters.AddWithValue("@TenMon", tenMon);
                cmd.Parameters.AddWithValue("@SoTinChi", soTinChi);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Thêm môn học thành công!");
                    LoadMonHoc(); // refresh lại bảng
                }
                else
                {
                    MessageBox.Show("Thêm môn học thất bại!");
                }
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }
    }
}
