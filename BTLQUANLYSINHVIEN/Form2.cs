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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void lblDaCoTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string maNguoiDung = txtMaNguoiDung.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            

            if (string.IsNullOrEmpty(maNguoiDung) || string.IsNullOrEmpty(matKhau) )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            string connStr = @"Data Source=LAPTOP-HPIHPRR9\DONG3;Initial Catalog=QLSinhVien;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = @"
SELECT Role, MaSV, MaGV 
FROM tblUser 
WHERE (MaSV = @Ma OR MaGV = @Ma) 
AND Password = @Password";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ma", maNguoiDung);
                cmd.Parameters.AddWithValue("@Password", matKhau);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string role = reader["Role"].ToString();

                    

                    NhoTamThoi.Role = role;

                    if (role == "SinhVien")
                    {
                        NhoTamThoi.MaSV = maNguoiDung;
                        reader.Close();

                        // lấy tên
                        string queryTen = "SELECT TenSV FROM tblSinhVien WHERE MaSV=@MaSV";
                        SqlCommand cmdTen = new SqlCommand(queryTen, conn);
                        cmdTen.Parameters.AddWithValue("@MaSV", maNguoiDung);

                        object ten = cmdTen.ExecuteScalar();
                        if (ten != null) NhoTamThoi.TenSV = ten.ToString();

                        FormTrangChuSinhVien frm = new FormTrangChuSinhVien();
                        frm.Show();
                    }
                    else if (role == "GiangVien")
                    {
                        NhoTamThoi.MaGV = maNguoiDung;
                        reader.Close();

                        string queryTen = "SELECT TenGV FROM tblGiangVien WHERE MaGV=@MaGV";
                        SqlCommand cmdTen = new SqlCommand(queryTen, conn);
                        cmdTen.Parameters.AddWithValue("@MaGV", maNguoiDung);

                        object ten = cmdTen.ExecuteScalar();
                        if (ten != null) NhoTamThoi.TenGV = ten.ToString();

                        FormTrangChuGiangVien frm = new FormTrangChuGiangVien();
                        frm.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Thông tin đăng nhập không đúng!");
                }
            }
        }

        private void btlDangKy_Click(object sender, EventArgs e)
        {
            FormDangKy frmDK = new FormDangKy();
            frmDK.Show();
            this.Hide();
        }

        private void cboChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtXacNhanMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
