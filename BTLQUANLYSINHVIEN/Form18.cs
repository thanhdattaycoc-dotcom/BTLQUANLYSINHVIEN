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
    public partial class FormThemMonHoc : Form
    {
        public FormThemMonHoc()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormThemMonHoc_Load(object sender, EventArgs e)
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maMon = textBox1.Text.Trim();
            string tenMon = textBox2.Text.Trim();
            int soTinChi;

            if (string.IsNullOrEmpty(maMon) || string.IsNullOrEmpty(tenMon) || !int.TryParse(textBox3.Text.Trim(), out soTinChi))
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
    }
}
