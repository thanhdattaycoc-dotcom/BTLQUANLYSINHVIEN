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
    public partial class FormTEST : Form

    {
        string connStr = "Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True";

        public FormTEST()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string connectionString = @"Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblSinhVien", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void FormTEST_Load(object sender, EventArgs e)
        {
            cboGioiTinh.Items.Clear();
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            txtSonam.ReadOnly = true;
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
            string Sonam = txtSonamMuonTim.Text.Trim();
            string connectionString = "Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM tblSinhVien where Sonam = @Sonam";
               
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@Sonam", Sonam);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();

            if (string.IsNullOrEmpty(maSV))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
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

                        // 1. Xóa bảng điểm
                        cmd = new SqlCommand("DELETE FROM tblDiem WHERE MaSV=@Ma", conn, trans);
                        cmd.Parameters.AddWithValue("@Ma", maSV);
                        cmd.ExecuteNonQuery();

                        // 2. Xóa đăng ký lớp
                        cmd = new SqlCommand("DELETE FROM tblDangKy WHERE MaSV=@Ma", conn, trans);
                        cmd.Parameters.AddWithValue("@Ma", maSV);
                        cmd.ExecuteNonQuery();

                        // 3. Xóa user
                        cmd = new SqlCommand("DELETE FROM tblUser WHERE MaSV=@Ma", conn, trans);
                        cmd.Parameters.AddWithValue("@Ma", maSV);
                        cmd.ExecuteNonQuery();

                        // 4. Cuối cùng mới xóa sinh viên
                        cmd = new SqlCommand("DELETE FROM tblSinhVien WHERE MaSV=@Ma", conn, trans);
                        cmd.Parameters.AddWithValue("@Ma", maSV);
                        int rows = cmd.ExecuteNonQuery();

                        trans.Commit();

                        MessageBox.Show(rows > 0 ? "Xóa thành công!" : "Không tìm thấy sinh viên");

                        FormTEST_Load(sender, e);
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
            DateTime start = dateTimePicker2.Value;
            DateTime end = DateTime.Today;
            int Sonam = end.Year - start.Year;
            string connectionString = @"Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO tblSinhVien (MaSV, TenSV, NgaySinh, GioiTinh, Email, SoDienThoai, NoiSinh, CCCD, Ngaybatdau, Sonam) " +
                             "VALUES (@MaSV, @TenSV, @NgaySinh, @GioiTinh, @Email, @SoDienThoai, @NoiSinh, @CCCD, @Ngaybatdau,@Sonam)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text);
                cmd.Parameters.AddWithValue("@TenSV", txtTenSV.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@SoDienThoai", txtSoDienThoai.Text);
                cmd.Parameters.AddWithValue("@NoiSinh", txtNoiSinh.Text);
                cmd.Parameters.AddWithValue("@CCCD", txtCCCD.Text);
                cmd.Parameters.AddWithValue("@Ngaybatdau", dateTimePicker2.Value);
                cmd.Parameters.AddWithValue("@Sonam", Sonam);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm sinh viên thành công!");
                    LoadData(); // Hiển thị lại dữ liệu
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DateTime start = dateTimePicker1.Value;
            DateTime end = DateTime.Today;
            int Sonam = end.Year - start.Year;
            string connectionString = @"Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "UPDATE  tblSinhVien SET" +
                    " TenSV = @TenSV," +
                    "NgaySinh = @NgaySinh," +
                    " GioiTinh= @GioiTinh," +
                    " Email = @Email," +
                    " SoDienThoai= @SoDienThoai," +
                    " NoiSinh = @NoiSinh," +
                    " CCCD =@CCCD," +
                    " Ngaybatdau = @Ngaybatdau," +
                    " Sonam = @Sonam" +
                    " WHERE MaSV = @MaSV ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text);
                cmd.Parameters.AddWithValue("@TenSV", txtTenSV.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@SoDienThoai", txtSoDienThoai.Text);
                cmd.Parameters.AddWithValue("@NoiSinh", txtNoiSinh.Text);
                cmd.Parameters.AddWithValue("@CCCD", txtCCCD.Text);
                cmd.Parameters.AddWithValue("@Ngaybatdau", dateTimePicker2.Value);
                cmd.Parameters.AddWithValue("@Sonam", Sonam);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cap nhat sinh viên thành công!");
                    LoadData(); // Hiển thị lại dữ liệu
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime start = dateTimePicker1.Value;
            DateTime end = DateTime.Today;
            int Sonam = end.Year - start.Year;
            txtSonam.Text = Sonam.ToString();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string Sonam = txtSonamMuonTim.Text;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string sql = "SELECT * FROM tblSinhVien where Sonam = @Sonam";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@Sonam", Sonam);

            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;


           
            DataTable dt = new DataTable();
            da.Fill(dt);

            CrystalReport3 rpt = new CrystalReport3();
            rpt.SetDataSource(dt);

            FormTeSTTT f = new FormTeSTTT();
            f.crystalReportViewer1.ReportSource = rpt;
            f.ShowDialog();
        }
    }
}