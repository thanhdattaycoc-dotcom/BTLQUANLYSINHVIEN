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
        string connStr = "Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True";


        public FormThongTinSinhVien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormThongTinSinhVien_Load(object sender, EventArgs e)
        {

            cboGioiTinh.Items.Clear();
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            LoadThongTin();


            LoadThongTin(); // hàm load từ DB

            Khoa(false);

            btnCapnhat.Visible = false;
            btnQuayLai.Visible = false;
            dateNgaySinh.Visible = false;
            lblDoiNgay.Visible = false;
            btnSua.Visible = true;

            

           
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            LoadThongTin(); // load lại dữ liệu cũ

            Khoa(false);
            dateNgaySinh.Visible = false;
            lblDoiNgay.Visible = false;
            btnCapnhat.Visible = false;
            btnQuayLai.Visible = false;

            btnSua.Visible = true; 
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

            txtMa.ReadOnly = true; // luôn khóa mã 

            cboGioiTinh.BackColor = Color.White;
            cboGioiTinh.ForeColor = Color.Black;

            dateNgaySinh.CalendarMonthBackground = Color.White;
            dateNgaySinh.CalendarForeColor = Color.Black;
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

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show(
        "Bạn có chắc chắn muốn cập nhật không?",
        "Xác nhận",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                CapNhatSinhVien();

                MessageBox.Show("Cập nhật thành công!");

                Khoa(false);

                btnCapnhat.Visible = false;
                btnQuayLai.Visible = false;
                btnSua.Visible = true;
            }
        }
        void LoadThongTin()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = "SELECT * FROM tblSinhVien WHERE MaSV = @MaSV";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSV", NhoTamThoi.MaSV);

                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    txtMa.Text = rd["MaSV"].ToString();
                    txtTen.Text = rd["TenSV"].ToString();
                    txtEmail.Text = rd["Email"].ToString();
                    txtSdt.Text = rd["SoDienThoai"].ToString();
                    txtNoiSinh.Text = rd["NoiSinh"].ToString();
                    txtCCCD.Text = rd["CCCD"].ToString();
                    cboGioiTinh.Text = rd["GioiTinh"].ToString().Trim();
                    dateNgaySinh.Value = Convert.ToDateTime(rd["NgaySinh"]);
                    DateTime ns = Convert.ToDateTime(rd["NgaySinh"]);

                    // set cho DateTimePicker
                    dateNgaySinh.Value = ns;

                    // set cho label hiển thị
                    lblNgaySinh.Text = ns.ToString("dd/MM/yyyy");
                }
                

                rd.Close();
            }
        }
        void CapNhatSinhVien()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = @"UPDATE tblSinhVien 
                     SET TenSV = @TenSV,
                         NgaySinh = @NgaySinh,
                         GioiTinh = @GioiTinh,
                         Email = @Email,
                         SoDienThoai = @SDT,
                         NoiSinh = @NoiSinh,
                         CCCD = @CCCD
                     WHERE MaSV = @MaSV";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@MaSV", txtMa.Text);
                cmd.Parameters.AddWithValue("@TenSV", txtTen.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dateNgaySinh.Value);
                cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@SDT", txtSdt.Text);
                cmd.Parameters.AddWithValue("@NoiSinh", txtNoiSinh.Text);
                cmd.Parameters.AddWithValue("@CCCD", txtCCCD.Text);

                cmd.ExecuteNonQuery();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            lblNgaySinh.Text = dateNgaySinh.Value.ToString("dd/MM/yyyy");
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string sql = "SELECT * FROM tblSinhVien";

            SqlDataAdapter da = new SqlDataAdapter(sql,conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            rptThongTinSinhVien rpt = new rptThongTinSinhVien();
            rpt.SetDataSource(dt);

            FormThongtinSV f = new FormThongtinSV();
            f.crystalReportViewer1.ReportSource = rpt;
            f.ShowDialog();
        }
    }
}
