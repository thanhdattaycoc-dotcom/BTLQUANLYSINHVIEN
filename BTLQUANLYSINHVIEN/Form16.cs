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
    public partial class FormThemGiangVien : Form
    {
        public FormThemGiangVien()
        {
            InitializeComponent();
        }

        private void FormThemGiangVien_Load(object sender, EventArgs e)
        {
            cboGioiTinh.Items.Clear();
            cboGioiTinh.Items.Clear();
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;

            LoadData();
        }
        //Hàm load data
        private void LoadData()
        {
            string connectionString = @"Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblGiangVien", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO tblGiangVien (MaGV, TenGV, NgaySinh, GioiTinh, Email, SoDienThoai, NoiSinh, CCCD) " +
                             "VALUES (@MaGV, @TenGV, @NgaySinh, @GioiTinh, @Email, @SoDienThoai, @NoiSinh, @CCCD)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaGV", txtMaSV.Text);
                cmd.Parameters.AddWithValue("@TenGV", txtTenSV.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@SoDienThoai", txtSoDienThoai.Text);
                cmd.Parameters.AddWithValue("@NoiSinh", txtNoiSinh.Text);
                cmd.Parameters.AddWithValue("@CCCD", txtCCCD.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm giảng viên thành công!");
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

            this.Close();
        }
    }
}
