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
            cboChucVu.DropDownStyle = ComboBoxStyle.DropDownList; // chỉ cho chọn, không nhập
            cboChucVu.Items.Add("SinhVien");
            cboChucVu.Items.Add("GiangVien");
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string maNguoiDung = txtMaNguoiDung.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string role = cboChucVu.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(maNguoiDung) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            string connStr = "Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM tblUser WHERE (MaSV=@Ma OR MaGV=@Ma) AND Password=@Password AND Role=@Role";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ma", maNguoiDung);
                cmd.Parameters.AddWithValue("@Password", matKhau);
                cmd.Parameters.AddWithValue("@Role", role);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công!");

                    if (role == "SinhVien")
                    {
                        FormTrangChuSinhVien frmSV = new FormTrangChuSinhVien();
                        frmSV.Show();
                    }
                    else if (role == "GiangVien")
                    {
                        FormTrangChuGiangVien frmGV = new FormTrangChuGiangVien();
                        frmGV.Show();
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

    }
}
