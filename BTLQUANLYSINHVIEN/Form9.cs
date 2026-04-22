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
        string connStr = @"Data Source=LAPTOP-HPIHPRR9\DONG3;Initial Catalog=QLSinhVien;Integrated Security=True";

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
            cboGioiTinh.Items.Clear();
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");

            // nếu muốn chặn nhập:
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;

            LoadThongTin();

            Khoa(false);

            btnCapnhat.Visible = false;
            btnQuayLai.Visible = false;
            dateNgaySinh.Visible = false;
            lblDoiNgay.Visible = false;
            btnSua.Visible = true;

        }
        void LoadThongTin()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = "SELECT * FROM tblGiangVien WHERE MaGV = @MaGV";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaGV", NhoTamThoi.MaGV);

                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    txtMa.Text = rd["MaGV"].ToString();
                    txtTen.Text = rd["TenGV"].ToString();
                    txtEmail.Text = rd["Email"].ToString();
                    txtSdt.Text = rd["SoDienThoai"].ToString();
                    txtNoiSinh.Text = rd["NoiSinh"].ToString();
                    txtCCCD.Text = rd["CCCD"].ToString();

                    // Fix giới tính
                    string gt = rd["GioiTinh"].ToString().Trim();
                    cboGioiTinh.Text = gt;

                    // Ngày sinh
                    DateTime ns = Convert.ToDateTime(rd["NgaySinh"]);
                    dateNgaySinh.Value = ns;
                    lblNgaySinh.Text = ns.ToString("dd/MM/yyyy");
                }

                rd.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNgaySinh_Click(object sender, EventArgs e)
        {

        }
        void Khoa(bool enable)
        {
            txtTen.ReadOnly = !enable;
            txtEmail.ReadOnly = !enable;
            txtSdt.ReadOnly = !enable;
            txtNoiSinh.ReadOnly = !enable;
            txtCCCD.ReadOnly = !enable;

            cboGioiTinh.Enabled = enable;
            dateNgaySinh.Enabled = enable;

            txtMa.ReadOnly = true;

            cboGioiTinh.BackColor = Color.White;
            cboGioiTinh.ForeColor = Color.Black;
        }

        private void lblNgaySinh_Click_1(object sender, EventArgs e)
        {
            lblNgaySinh.Text = dateNgaySinh.Value.ToString("dd/MM/yyyy");

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Khoa(true);

            dateNgaySinh.Visible = true;
            lblDoiNgay.Visible = true;

            btnCapnhat.Visible = true;
            btnQuayLai.Visible = true;
            btnSua.Visible = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuayLai_Click_1(object sender, EventArgs e)
        {
            LoadThongTin(); // load lại dữ liệu cũ


            Khoa(false);
            dateNgaySinh.Visible = false;
            lblDoiNgay.Visible = false;
            btnCapnhat.Visible = false;
            btnQuayLai.Visible = false;

            btnSua.Visible = true;
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show(
        "Bạn có chắc chắn muốn cập nhật không?",
        "Xác nhận",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                CapNhatGiangVien();

                MessageBox.Show("Cập nhật thành công!");

                Khoa(false);

                btnCapnhat.Visible = false;
                btnQuayLai.Visible = false;
                btnSua.Visible = true;
            }
        }
    


    void CapNhatGiangVien()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = @"UPDATE tblGiangVien 
                     SET TenGV = @TenGV,
                         NgaySinh = @NgaySinh,
                         GioiTinh = @GioiTinh,
                         Email = @Email,
                         SoDienThoai = @SDT,
                         NoiSinh = @NoiSinh,
                         CCCD = @CCCD
                     WHERE MaGV = @MaGV";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@MaGV", txtMa.Text);
                cmd.Parameters.AddWithValue("@TenGV", txtTen.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dateNgaySinh.Value);
                cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@SDT", txtSdt.Text);
                cmd.Parameters.AddWithValue("@NoiSinh", txtNoiSinh.Text);
                cmd.Parameters.AddWithValue("@CCCD", txtCCCD.Text);

                cmd.ExecuteNonQuery();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string sql = "SELECT * FROM tblGiangVien";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            rptThongTinGiangVien rpt = new rptThongTinGiangVien();
            rpt.SetDataSource(dt);

            FormThongtinSV f = new FormThongtinSV();
            f.crystalReportViewer1.ReportSource = rpt;
            f.ShowDialog();
        }
    }
}

