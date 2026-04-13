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
    public partial class FormDangKyLopHoc : Form
    {
        public FormDangKyLopHoc()
        {
            InitializeComponent();
        }

        private void FormDangKyLopHoc_Load(object sender, EventArgs e)
        {
            lblMaSinhVien.Text = "Mã sinh viên: " + NhoTamThoi.MaSV;
            lblTenSinhVien.Text = "Tên sinh viên: " + NhoTamThoi.TenSV;
            lblNgayHomNay.Text = "Ngày hôm nay: " + DateTime.Now.ToString("dd/MM/yyyy");

            LoadLopConMo();
            LoadLopDaDangKy();
        }
        private void LoadLopDaDangKy()
        {
            string connStr = "Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = @"SELECT l.MaLop, l.TenLop, l.MaMon, l.Thu, l.Tiet, l.Phong, l.NgayMo, l.NgayDong
                         FROM tblDangKy dk
                         JOIN tblLop l ON dk.MaLop = l.MaLop
                         WHERE dk.MaSV = @MaSV";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@MaSV", NhoTamThoi.MaSV);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewLopDaDangKy.DataSource = dt;

                // Gán cho combobox hủy đăng ký
                cboHuyDangKy.DataSource = dt;
                cboHuyDangKy.DisplayMember = "MaLop";
                cboHuyDangKy.ValueMember = "MaLop";
            }
        }
        private void LoadLopConMo()
        {
            string connStr = "Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = @"SELECT l.MaLop, l.TenLop, l.MaMon, l.MaGV, l.Thu, l.Tiet, l.Phong, l.SiSoToiDa,
                                (l.SiSoToiDa - COUNT(dk.MaSV)) AS ConLai,
                                l.NgayMo, l.NgayDong
                         FROM tblLop l
                         LEFT JOIN tblDangKy dk ON l.MaLop = dk.MaLop
                         WHERE GETDATE() BETWEEN l.NgayMo AND l.NgayDong
                         GROUP BY l.MaLop, l.TenLop, l.MaMon, l.MaGV, l.Thu, l.Tiet, l.Phong, l.SiSoToiDa, l.NgayMo, l.NgayDong";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                cboMaLop.DataSource = dt;
                cboMaLop.DisplayMember = "MaLop";
                cboMaLop.ValueMember = "MaLop";
            }
        }

        private void cboMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaLop.SelectedItem != null)
            {
                DataRowView row = (DataRowView)cboMaLop.SelectedItem;
                int conLai = Convert.ToInt32(row["ConLai"]);
                int siSoToiDa = Convert.ToInt32(row["SiSoToiDa"]);
                lblCon.Text = $"Còn: {conLai}/{siSoToiDa}";
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (cboMaLop.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn lớp!");
                return;
            }

            DataRowView row = (DataRowView)cboMaLop.SelectedItem;
            string maLop = row["MaLop"].ToString();
            int conLai = Convert.ToInt32(row["ConLai"]);

            if (conLai <= 0)
            {
                MessageBox.Show("Lớp đã đủ sĩ số, không thể đăng ký!");
                return;
            }

            string connStr = "Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "INSERT INTO tblDangKy (MaSV, MaLop, NgayDangKy) VALUES (@MaSV, @MaLop, GETDATE())";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSV", NhoTamThoi.MaSV);
                cmd.Parameters.AddWithValue("@MaLop", maLop);

                try
                {
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Đăng ký thành công!");
                        LoadLopConMo();      // refresh lớp còn mở
                        LoadLopDaDangKy();   // refresh lớp đã đăng ký
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) // PK violation (đã đăng ký lớp này)
                    {
                        MessageBox.Show("Bạn đã đăng ký lớp này rồi!");
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                    }
                }
            }
        }

        private void btnHuyDangKy_Click(object sender, EventArgs e)
        {
            if (cboHuyDangKy.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn lớp cần hủy!");
                return;
            }

            string maLop = cboHuyDangKy.SelectedValue.ToString();

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy đăng ký lớp " + maLop + " ?",
                                                  "Xác nhận hủy",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string connStr = "Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = "DELETE FROM tblDangKy WHERE MaSV=@MaSV AND MaLop=@MaLop";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaSV", NhoTamThoi.MaSV);
                    cmd.Parameters.AddWithValue("@MaLop", maLop);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Hủy đăng ký thành công!");
                        LoadLopConMo();      // refresh lớp còn mở
                        LoadLopDaDangKy();   // refresh lớp đã đăng ký
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy lớp để hủy!");
                    }
                }

            }
        }
    }
}
