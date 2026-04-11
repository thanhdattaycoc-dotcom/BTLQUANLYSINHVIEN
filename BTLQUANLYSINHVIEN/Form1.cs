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
            cboChucVu.Items.Add("SinhVien");
            cboChucVu.Items.Add("GiangVien");
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
            string tenTaiKhoan = txtTenTaiKhoan.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string xacNhanMatKhau = txtXacNhanMatKhau.Text.Trim();
            string role = cboChucVu.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(maNguoiDung) || string.IsNullOrEmpty(tenTaiKhoan) ||
                string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(xacNhanMatKhau) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (matKhau != xacNhanMatKhau)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!");
                return;
            }

            string connStr = "Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string checkQuery = "SELECT COUNT(*) FROM tblUser WHERE Username=@Username";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@Username", tenTaiKhoan);
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại!");
                    return;
                }

                string insertQuery = "INSERT INTO tblUser (Username, Password, Role, MaSV, MaGV) VALUES (@Username, @Password, @Role, @MaSV, @MaGV)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@Username", tenTaiKhoan);
                insertCmd.Parameters.AddWithValue("@Password", matKhau);
                insertCmd.Parameters.AddWithValue("@Role", role);

                if (role == "SinhVien")
                {
                    insertCmd.Parameters.AddWithValue("@MaSV", maNguoiDung);
                    insertCmd.Parameters.AddWithValue("@MaGV", DBNull.Value);
                }
                else // GiangVien
                {
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
