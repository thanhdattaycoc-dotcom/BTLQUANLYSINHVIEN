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
using System.Text.RegularExpressions;

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
            string Masothue = txtMaSoThue.Text;
         
            if (string.IsNullOrWhiteSpace(Masothue))
                return ;

         
            if (!Regex.IsMatch(Masothue, @"^\d+$"))
                return ;

       
            if (Masothue.Length > 12)
                return ;
            string connectionString = @"Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO tblGiangVien (MaGV, TenGV, NgaySinh, GioiTinh, Email, SoDienThoai, NoiSinh, CCCD, Masothue) " +
                             "VALUES (@MaGV, @TenGV, @NgaySinh, @GioiTinh, @Email, @SoDienThoai, @NoiSinh, @CCCD, @Masothue)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaGV", txtMaSV.Text);
                cmd.Parameters.AddWithValue("@TenGV", txtTenSV.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@SoDienThoai", txtSoDienThoai.Text);
                cmd.Parameters.AddWithValue("@NoiSinh", txtNoiSinh.Text);
                cmd.Parameters.AddWithValue("@CCCD", txtCCCD.Text);
                cmd.Parameters.AddWithValue("@Masothue", Masothue);

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

        private void txtMaSoThue_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            string maGV = txtMaSV.Text;
            string Masothue = txtMaSoThue.Text;

            bool kq = CapNhatSo(maGV, Masothue);

            if (kq)
                MessageBox.Show("Cập nhật thành công");
            else
                MessageBox.Show("Dữ liệu không hợp lệ hoặc bị trùng");

        }



        public bool CapNhatSo(string maGV, string Masothue)
        {
           
            if (string.IsNullOrWhiteSpace(Masothue))
                return false;

            if (!Regex.IsMatch(Masothue, @"^\d+$"))
                return false;

          
            if (Masothue.Length > 12)
                return false;

            string connStr = @"Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

      
                string checkQuery = "SELECT COUNT(*) FROM tblGiangVien WHERE Masothue = @Masothue AND MaGV <> @MaGV";

                using (SqlCommand cmdCheck = new SqlCommand(checkQuery, conn))
                {
                    cmdCheck.Parameters.AddWithValue("@Masothue", Masothue);
                    cmdCheck.Parameters.AddWithValue("@MaGV", maGV);

                    int count = (int)cmdCheck.ExecuteScalar();

                    if (count > 0)
                        return false; 
                }


                string updateQuery = "UPDATE tblGiangVien SET Masothue = @Masothue WHERE MaGV = @MaGV";

                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Masothue", Masothue);
                    cmd.Parameters.AddWithValue("@MaGV", maGV);

                    return cmd.ExecuteNonQuery() > 0;
                }
                LoadData();
            }
        }

    }
}
