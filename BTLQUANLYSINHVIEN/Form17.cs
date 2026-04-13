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
    public partial class FormThemLopHoc : Form
    {
        public FormThemLopHoc()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            // Load dữ liệu lớp học vào DataGridView
            LoadLopHoc();

            // Combobox Thứ (2 -> 8)
            cboThu.Items.Clear();
            for (int i = 2; i <= 8; i++)
            {
                cboThu.Items.Add("Thứ " + i);
            }

            // Combobox Tiết
            cboTiet.Items.Clear();
            cboTiet.Items.Add("1-4 (Sáng)");
            cboTiet.Items.Add("5-8 (Chiều)");
            cboTiet.Items.Add("9-12 (Tối)");

            // Load mã môn từ DB
            string connStr = "Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlDataAdapter daMon = new SqlDataAdapter("SELECT MaMon FROM tblMonHoc", conn);
                DataTable dtMon = new DataTable();
                daMon.Fill(dtMon);
                cboMaMon.DataSource = dtMon;
                cboMaMon.DisplayMember = "MaMon";
                cboMaMon.ValueMember = "MaMon";

                SqlDataAdapter daGV = new SqlDataAdapter("SELECT MaGV FROM tblGiangVien", conn);
                DataTable dtGV = new DataTable();
                daGV.Fill(dtGV);
                cboMaGiaoVien.DataSource = dtGV;
                cboMaGiaoVien.DisplayMember = "MaGV";
                cboMaGiaoVien.ValueMember = "MaGV";
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
                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text.Trim();
            string tenLop = txtTenLop.Text.Trim();
            string phong = txtPhong.Text.Trim();
            int siSoToiDa;

            if (!int.TryParse(txtSiSoToiDa.Text.Trim(), out siSoToiDa))
            {
                MessageBox.Show("Sĩ số tối đa phải là số!");
                return;
            }

            DateTime ngayMo = dateTimePickerNgayMo.Value;
            DateTime ngayDong = dateTimePickerNgayDong.Value;

            if (ngayDong < ngayMo)
            {
                MessageBox.Show("Ngày đóng phải lớn hơn hoặc bằng ngày mở!");
                return;
            }

            string tiet = cboTiet.SelectedItem?.ToString();
            string thu = cboThu.SelectedItem?.ToString();
            string maMon = cboMaMon.SelectedValue?.ToString();
            string maGV = cboMaGiaoVien.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(maLop) || string.IsNullOrEmpty(tenLop) || string.IsNullOrEmpty(maMon) || string.IsNullOrEmpty(maGV))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            string connStr = "Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = @"INSERT INTO tblLop (MaLop, TenLop, MaMon, MaGV, Thu, Tiet, Phong, SiSoToiDa, NgayMo, NgayDong)
                         VALUES (@MaLop, @TenLop, @MaMon, @MaGV, @Thu, @Tiet, @Phong, @SiSoToiDa, @NgayMo, @NgayDong)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaLop", maLop);
                cmd.Parameters.AddWithValue("@TenLop", tenLop);
                cmd.Parameters.AddWithValue("@MaMon", maMon);
                cmd.Parameters.AddWithValue("@MaGV", maGV);
                cmd.Parameters.AddWithValue("@Thu", int.Parse(thu.Replace("Thứ ", "")));
                cmd.Parameters.AddWithValue("@Tiet", tiet);
                cmd.Parameters.AddWithValue("@Phong", phong);
                cmd.Parameters.AddWithValue("@SiSoToiDa", siSoToiDa);
                cmd.Parameters.AddWithValue("@NgayMo", ngayMo);
                cmd.Parameters.AddWithValue("@NgayDong", ngayDong);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Thêm lớp học thành công!");
                    LoadLopHoc(); // refresh lại DataGridView
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
