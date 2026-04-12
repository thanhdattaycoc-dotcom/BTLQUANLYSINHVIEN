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
    public partial class FormThongTinGiangVien : Form
    {
        public FormThongTinGiangVien()
        {
            InitializeComponent();
        }

        private void lblThongTinCaNhan_Click(object sender, EventArgs e)
        {

        }

        private void lblCCCD_Click(object sender, EventArgs e)
        {

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormThongTinGiangVien_Load(object sender, EventArgs e)
        {
            string connStr = "Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = @"SELECT MaGV, TenGV, CCCD, GioiTinh, NoiSinh, Email, SoDienThoai, Ngaysinh 
                         FROM tblGiangVien
                         WHERE MaGV = @MaGV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaGV", NhoTamThoi.MaGV);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblMaGiangVien.Text = "Mã giảng viên: " + reader["MaGV"].ToString();
                    lblHoTen.Text = "Họ tên: " + reader[ "TenGV"].ToString();
                    lblCCCD.Text = "CCCD: " + reader["CCCD"].ToString();
                    lblGioiTinh.Text = "Giới tính: " + reader["GioiTinh"].ToString();
                    lblNoiSinh.Text = "Nơi sinh: " + reader["NoiSinh"].ToString();
                    lblEmail.Text = "Email: " + reader["Email"].ToString();
                    lblSDT.Text = "Số điện thoại: " + reader["SoDienThoai"].ToString();
                    lblNgaySinh.Text = "Ngày sinh: " + Convert.ToDateTime(reader["NgaySinh"]).ToShortDateString();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNgaySinh_Click(object sender, EventArgs e)
        {

        }
    }
}
