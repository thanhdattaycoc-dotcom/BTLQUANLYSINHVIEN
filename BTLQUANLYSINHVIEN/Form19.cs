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
    public partial class FormThemSinhVien : Form
    {
        

        public FormThemSinhVien()
        {
            InitializeComponent();
        }

        private void FormThemSinhVien_Load(object sender, EventArgs e)
        {
            cboGioiTinh.Items.Clear();
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;

            LoadData();
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO tblSinhVien (MaSV, TenSV, NgaySinh, GioiTinh, Email, SoDienThoai, NoiSinh, CCCD) " +
                             "VALUES (@MaSV, @TenSV, @NgaySinh, @GioiTinh, @Email, @SoDienThoai, @NoiSinh, @CCCD)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text);
                cmd.Parameters.AddWithValue("@TenSV", txtTenSV.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@SoDienThoai", txtSoDienThoai.Text);
                cmd.Parameters.AddWithValue("@NoiSinh", txtNoiSinh.Text);
                cmd.Parameters.AddWithValue("@CCCD", txtCCCD.Text);

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

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblCCCD_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNoiSinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNoiSinh_Click(object sender, EventArgs e)
        {

        }

        private void lblSoDienThoai_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblGioiTinh_Click(object sender, EventArgs e)
        {

        }

        private void lblNgaySinh_Click(object sender, EventArgs e)
        {

        }

        private void lblTenSV_Click(object sender, EventArgs e)
        {

        }

        private void lblMaSV_Click(object sender, EventArgs e)
        {

        }
    }
    }

