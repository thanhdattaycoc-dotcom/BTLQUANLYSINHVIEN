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
    public partial class FormThongTinSinhVien : Form
    {
        public FormThongTinSinhVien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormThongTinSinhVien_Load(object sender, EventArgs e)
        {
            string connStr = "Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = @"SELECT MaSV, TenSV, NgaySinh, GioiTinh, Email, SoDienThoai, NoiSinh 
                                 FROM tblSinhVien 
                                 WHERE MaSV=@MaSV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSV", NhoTamThoi.MaSV);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblMaSinhVien.Text = "Mã sinh viên: " + reader["MaSV"].ToString();
                    lblHoTen.Text = "Họ tên: " + reader["TenSV"].ToString();
                    lblNgaySinh.Text = "Ngày sinh: " + Convert.ToDateTime(reader["NgaySinh"]).ToShortDateString();
                    lblGioiTinh.Text = "Giới tính: " + reader["GioiTinh"].ToString();
                    lblEmail.Text = "Email: " + reader["Email"].ToString();
                    lblSDT.Text = "Số điện thoại: " + reader["SoDienThoai"].ToString();
                    lblNoiSinh.Text = "Nơi sinh: " + reader["NoiSinh"].ToString();
                }
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            FormTrangChuSinhVien frm = new FormTrangChuSinhVien();
            this.Close();
        }
    }
}
