using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web;

namespace BTLQUANLYSINHVIEN
{
    public partial class FormQuanLyLopHoc : Form
    {
        string connStr = "Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True";
      
        public FormQuanLyLopHoc()
        {
            InitializeComponent();
        }

        private void FormQuanLyLopHoc_Load(object sender, EventArgs e)
        {
            LoadLopHoc();
   
        }
        void LoadLopHoc()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sql = @"SELECT * FROM tblLop";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvLop.DataSource = dt;
                cboTenLop.DataSource = dt;
                cboTenLop.DisplayMember = "TenLop"; // hiển thị
                cboTenLop.ValueMember = "MaLop";    // giá trị

                cboTenLop.SelectedIndex = -1; // không chọn sẵn

            }
        }

        // ================= LOAD COMBO =================
       

        private void dgvLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboTenLop.Text))
            {
                MessageBox.Show("Mời bạn chọn tên lớp!");
                return;
            }
            string MaLop = cboTenLop.SelectedValue.ToString();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

               

                SqlCommand cmd = new SqlCommand();

            string sql = "SELECT * FROM tblLop WHERE MaLop = @MaLop";
                
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@MaLop", MaLop);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvLop.DataSource = dt;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
          
            if (cboTenLop.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn lớp cần xóa!");
                return;
            }

            if (MessageBox.Show("Xóa lớp này?", "Xác nhận",
                MessageBoxButtons.YesNo) == DialogResult.No) return;

            // 🔥 LẤY MaLop (QUAN TRỌNG NHẤT)
            string maLop = cboTenLop.SelectedValue.ToString();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                // Xóa bảng con trước
                SqlCommand cmd0 = new SqlCommand(
                    "DELETE FROM tblDiem WHERE MaLop = @MaLop", conn);
                cmd0.Parameters.AddWithValue("@MaLop", maLop);
                cmd0.ExecuteNonQuery();

                SqlCommand cmd1 = new SqlCommand(
                    "DELETE FROM tblDangKy WHERE MaLop = @MaLop", conn);
                cmd1.Parameters.AddWithValue("@MaLop", maLop);
                cmd1.ExecuteNonQuery();

                // Xóa lớp
                SqlCommand cmd2 = new SqlCommand(
                    "DELETE FROM tblLop WHERE MaLop = @MaLop", conn);
                cmd2.Parameters.AddWithValue("@MaLop", maLop);

                int rows = cmd2.ExecuteNonQuery();

                MessageBox.Show(rows > 0 ? "Xóa thành công" : "Không tìm thấy");

                LoadLopHoc();
            }
        
        }

     

        private void cboTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            FormThemLopHoc f = new FormThemLopHoc();
            f.ShowDialog();
            LoadLopHoc();
           
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInDanhSach_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            string sql = "SELECT * FROM tblLop";

            
            SqlDataAdapter da = new SqlDataAdapter(sql,conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            rptLop rpt = new rptLop();
            rpt.SetDataSource(dt);

            FormDanhSachLop f = new FormDanhSachLop();
            f.crystalReportViewer1.ReportSource = rpt;
            f.ShowDialog();
        }
    }


}
