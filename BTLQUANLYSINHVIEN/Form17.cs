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
        string connStr = "Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True";

        public FormThemLopHoc()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadLopHoc();

            txtTenLop.Enabled = false; // không cho sửa
        }
        void LoadLopHoc()
        {
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

            if (string.IsNullOrEmpty(maLop) || string.IsNullOrEmpty(phong))
            {
                MessageBox.Show("Nhập thiếu thông tin!");
                return;
            }

            if (KiemTraMaLopTonTai(maLop))
            {
                MessageBox.Show("Mã lớp đã tồn tại!");
                return;
            }

            if (cboTenMon.SelectedValue == null || cboMaGiaoVien.SelectedValue == null)
            {
                MessageBox.Show("Chọn môn và giáo viên!");
                return;
            }

            if (!int.TryParse(txtSiSoToiDa.Text, out int siSo))
            {
                MessageBox.Show("Sĩ số phải là số!");
                return;
            }

            int thu = cboThu.Text == "CN" ? 8 : int.Parse(cboThu.Text);
            string tiet = cboTiet.Text;

            if (string.IsNullOrEmpty(tiet))
            {
                MessageBox.Show("Chọn tiết!");
                return;
            }

            string maMon = cboTenMon.SelectedValue.ToString();
            string maGV = cboMaGiaoVien.SelectedValue.ToString();

            if (KiemTraTrungLich(maGV, phong, thu, tiet))
            {
                MessageBox.Show("Trùng lịch giáo viên hoặc phòng!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = @"INSERT INTO tblLop
                (MaLop, TenLop, MaMon, MaGV, Thu, Tiet, Phong, SiSoToiDa, NgayMo, NgayDong)
                VALUES (@MaLop, @TenLop, @MaMon, @MaGV, @Thu, @Tiet, @Phong, @SiSo, @NgayMo, @NgayDong)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@MaLop", maLop);
                cmd.Parameters.AddWithValue("@TenLop", tenLop);
                cmd.Parameters.AddWithValue("@MaMon", maMon);
                cmd.Parameters.AddWithValue("@MaGV", maGV);
                cmd.Parameters.AddWithValue("@Thu", thu);
                cmd.Parameters.AddWithValue("@Tiet", tiet);
                cmd.Parameters.AddWithValue("@Phong", phong);
                cmd.Parameters.AddWithValue("@SiSo", siSo);
                cmd.Parameters.AddWithValue("@NgayMo", dateTimePickerNgayMo.Value);
                cmd.Parameters.AddWithValue("@NgayDong", dateTimePickerNgayDong.Value);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm thành công!");
                LoadLopHoc();
            }
        }

        bool KiemTraMaLopTonTai(string maLop)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM tblLop WHERE MaLop=@MaLop";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaLop", maLop);

                return (int)cmd.ExecuteScalar() > 0;
            }
        }
        bool KiemTraTrungLich(string maGV, string phong, int thu, string tiet)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = @"
                SELECT COUNT(*) 
                FROM tblLop
                WHERE Thu = @Thu AND Tiet = @Tiet
                AND (MaGV = @MaGV OR Phong = @Phong)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Thu", thu);
                cmd.Parameters.AddWithValue("@Tiet", tiet);
                cmd.Parameters.AddWithValue("@MaGV", maGV);
                cmd.Parameters.AddWithValue("@Phong", phong);

                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }


        string TaoTenLop(string tenMon, string maMon)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM tblLop WHERE MaMon = @MaMon";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaMon", maMon);

                int count = (int)cmd.ExecuteScalar() + 1;

                return tenMon + " " + count.ToString("00");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePickerNgayMo_ValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSotinchi.Text)) return;

            int stc = int.Parse(txtSotinchi.Text);
            int soTuan = 0;

            if (stc == 2) soTuan = 8;
            else if (stc == 3) soTuan = 12;
            else if (stc == 4) soTuan = 16;

            dateTimePickerNgayDong.Value = dateTimePickerNgayMo.Value.AddDays(soTuan * 7);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cboMaGiaoVien_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataRowView row = cboMaGiaoVien.SelectedItem as DataRowView;
            if (row == null) return;

            textBox2.Text = row["TenGV"].ToString();

        }

        private void cboTenMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView row = cboTenMon.SelectedItem as DataRowView;
            if (row == null) return;

            string maMon = row["MaMon"].ToString();
            int soTinChi = Convert.ToInt32(row["SoTinChi"]);

            txtMaMon.Text = maMon;
            txtSotinchi.Text = soTinChi.ToString();

            txtTenLop.Text = TaoTenLop(row["TenMon"].ToString(), maMon);
        }
        void LoadComboBox()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                // MÔN HỌC
                SqlDataAdapter daMon = new SqlDataAdapter("SELECT * FROM tblMonHoc", conn);
                DataTable dtMon = new DataTable();
                daMon.Fill(dtMon);

                cboTenMon.DataSource = dtMon;
                cboTenMon.DisplayMember = "TenMon";
                cboTenMon.ValueMember = "MaMon";

                // GIÁO VIÊN
                SqlDataAdapter daGV = new SqlDataAdapter("SELECT MaGV, TenGV FROM tblGiangVien", conn);
                DataTable dtGV = new DataTable();
                daGV.Fill(dtGV);

                cboMaGiaoVien.DataSource = dtGV;
                cboMaGiaoVien.DisplayMember = "MaGV";
                cboMaGiaoVien.ValueMember = "MaGV";

                // THỨ
                cboThu.Items.Clear();
                cboThu.Items.AddRange(new object[] { 2, 3, 4, 5, 6, 7, "CN" });

                // TIẾT
                cboTiet.Items.Clear();
                cboTiet.Items.AddRange(new object[]
                {
                    "1-4 (Sáng)",
                    "5-8 (Chiều)",
                    "9-12 (Tối)"
                });
            }
        
        }

        private void txtMaMon_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
