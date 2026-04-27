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
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblTenTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cboChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtXacNhanMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaNguoiDung_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void lblDaCoTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void btlDangKy_Click(object sender, EventArgs e)
        {
            string maNguoiDung = txtMaNguoiDung.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string xacNhanMatKhau = txtXacNhanMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(maNguoiDung) ||
                string.IsNullOrEmpty(matKhau) ||
                string.IsNullOrEmpty(xacNhanMatKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (matKhau != xacNhanMatKhau)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!");
                return;
            }

            string connStr = @"Data Source=LAPTOP-K3A92CEE;Initial Catalog=QLSinhVien;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                // Xác định là SV hay GV
                string checkSV = "SELECT COUNT(*) FROM tblSinhVien WHERE MaSV=@Ma";
                SqlCommand cmdSV = new SqlCommand(checkSV, conn);
                cmdSV.Parameters.AddWithValue("@Ma", maNguoiDung);
                int isSV = (int)cmdSV.ExecuteScalar();

                string checkGV = "SELECT COUNT(*) FROM tblGiangVien WHERE MaGV=@Ma";
                SqlCommand cmdGV = new SqlCommand(checkGV, conn);
                cmdGV.Parameters.AddWithValue("@Ma", maNguoiDung);
                int isGV = (int)cmdGV.ExecuteScalar();

                if (isSV == 0 && isGV == 0)
                {
                    MessageBox.Show("Mã không tồn tại!");
                    return;
                }

                // Kiểm tra đã đăng ký chưa
                string checkUser = "SELECT COUNT(*) FROM tblUser WHERE MaSV=@Ma OR MaGV=@Ma";
                SqlCommand cmdCheckUser = new SqlCommand(checkUser, conn);
                cmdCheckUser.Parameters.AddWithValue("@Ma", maNguoiDung);
                int exists = (int)cmdCheckUser.ExecuteScalar();

                if (exists > 0)
                {
                    MessageBox.Show("Mã này đã đăng ký tài khoản!");
                    return;
                }

                // Insert
                string insertQuery = @"
INSERT INTO tblUser (Username, Password, Role, MaSV, MaGV) 
VALUES (@Username, @Password, @Role, @MaSV, @MaGV)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);

                insertCmd.Parameters.AddWithValue("@Password", matKhau);

                if (isSV > 0)
                {
                    insertCmd.Parameters.AddWithValue("@Username", maNguoiDung);
                    insertCmd.Parameters.AddWithValue("@Role", "SinhVien");
                    insertCmd.Parameters.AddWithValue("@MaSV", maNguoiDung);
                    insertCmd.Parameters.AddWithValue("@MaGV", DBNull.Value);
                }
                else
                {
                    insertCmd.Parameters.AddWithValue("@Username", maNguoiDung);

                    insertCmd.Parameters.AddWithValue("@Role", "GiangVien");
                    insertCmd.Parameters.AddWithValue("@MaGV", maNguoiDung);
                    insertCmd.Parameters.AddWithValue("@MaSV", DBNull.Value);
                }

                insertCmd.ExecuteNonQuery();

                MessageBox.Show("Đăng ký thành công!");
            }
        }


        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            FormDangNhap frmLogin = new FormDangNhap();
            frmLogin.Show();
            this.Hide();
        }

    }
}
