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
    public partial class FormQuanLyNhapDiem : Form
    {
        SqlConnection conn = new SqlConnection(
            @"Data Source=.;Initial Catalog=QLSinhVien;Integrated Security=True");
        public FormQuanLyNhapDiem()
        {
            InitializeComponent();
        }
        private void LoadBangDiemTheoLop(string maLop)
        {
            string sql = @"
        SELECT 
            L.MaLop,
            M.TenMon,
            SV.MaSV,
            SV.TenSV,
            D.DiemTX,
            D.DiemGK,
            D.DiemCK,
            (ISNULL(D.DiemTX,0)*0.2 + ISNULL(D.DiemGK,0)*0.3 + ISNULL(D.DiemCK,0)*0.5) AS DiemTB
        FROM tblLop L
        JOIN tblMonHoc M ON L.MaMon = M.MaMon
        JOIN tblDangKy DK ON L.MaLop = DK.MaLop
        JOIN tblSinhVien SV ON DK.MaSV = SV.MaSV
        LEFT JOIN tblDiem D ON SV.MaSV = D.MaSV AND L.MaLop = D.MaLop
        WHERE L.MaLop = @MaLop";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.SelectCommand.Parameters.AddWithValue("@MaLop", maLop);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewTheoLop.DataSource = dt;
        }

        private void FormQuanLyNhapDiem_Load(object sender, EventArgs e)
        {
            // Load danh sách lớp
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaLop FROM tblLop", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboMaLop.DataSource = dt;
            cboMaLop.DisplayMember = "MaLop";
            cboMaLop.ValueMember = "MaLop";

        }
        private void cboMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maLop = cboMaLop.SelectedValue.ToString();

            // Hiện tên môn và mã môn
            SqlCommand cmd = new SqlCommand(
                "SELECT L.MaMon, M.TenMon FROM tblLop L JOIN tblMonHoc M ON L.MaMon=M.MaMon WHERE L.MaLop=@MaLop", conn);
            cmd.Parameters.AddWithValue("@MaLop", maLop);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblMaMon.Text = "Mã môn: " + dr["MaMon"].ToString();
                lblTenMon.Text = "Tên môn: " + dr["TenMon"].ToString();
            }
            conn.Close();

            // Load sinh viên đăng ký lớp
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT SV.MaSV FROM tblDangKy DK JOIN tblSinhVien SV ON DK.MaSV=SV.MaSV WHERE DK.MaLop=@MaLop", conn);
            da.SelectCommand.Parameters.AddWithValue("@MaLop", maLop);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboMaSV.DataSource = dt;
            cboMaSV.DisplayMember = "MaSV";
            cboMaSV.ValueMember = "MaSV";
            LoadBangDiemTheoLop(maLop);


        }





        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maSV = cboMaSV.SelectedValue.ToString();
            string maLop = cboMaLop.SelectedValue.ToString();

            SqlCommand cmd = new SqlCommand(
                "SELECT DiemTX, DiemGK, DiemCK FROM tblDiem WHERE MaSV=@MaSV AND MaLop=@MaLop", conn);
            cmd.Parameters.AddWithValue("@MaSV", maSV);
            cmd.Parameters.AddWithValue("@MaLop", maLop);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtDiemTX.Text = dr["DiemTX"].ToString();
                txtDiemGK.Text = dr["DiemGK"].ToString();
                txtDiemCK.Text = dr["DiemCK"].ToString();
            }
            else
            {
                txtDiemTX.Clear();
                txtDiemGK.Clear();
                txtDiemCK.Clear();
            }
            conn.Close();

        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string maSV = cboMaSV.SelectedValue.ToString();
            string maLop = cboMaLop.SelectedValue.ToString();

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa điểm?", "Xác nhận",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand deleteCmd = new SqlCommand(
                    "DELETE FROM tblDiem WHERE MaSV=@MaSV AND MaLop=@MaLop", conn);
                deleteCmd.Parameters.AddWithValue("@MaSV", maSV);
                deleteCmd.Parameters.AddWithValue("@MaLop", maLop);
                conn.Open();
                deleteCmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Đã xóa điểm!");
                LoadBangDiemTheoLop(maLop);

            }
        }
        



        private void lblTheoMon_Click(object sender, EventArgs e)
        {

        }

       
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSV = cboMaSV.SelectedValue.ToString();
            string maLop = cboMaLop.SelectedValue.ToString();

            SqlCommand checkCmd = new SqlCommand(
                "SELECT COUNT(*) FROM tblDiem WHERE MaSV=@MaSV AND MaLop=@MaLop", conn);
            checkCmd.Parameters.AddWithValue("@MaSV", maSV);
            checkCmd.Parameters.AddWithValue("@MaLop", maLop);
            conn.Open();
            int count = (int)checkCmd.ExecuteScalar();
            conn.Close();

            if (count > 0)
            {
                if (MessageBox.Show("Điểm đã tồn tại. Bạn có muốn cập nhật không?", "Xác nhận",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlCommand updateCmd = new SqlCommand(
                        "UPDATE tblDiem SET DiemTX=@TX, DiemGK=@GK, DiemCK=@CK WHERE MaSV=@MaSV AND MaLop=@MaLop", conn);
                    updateCmd.Parameters.AddWithValue("@TX", txtDiemTX.Text);
                    updateCmd.Parameters.AddWithValue("@GK", txtDiemGK.Text);
                    updateCmd.Parameters.AddWithValue("@CK", txtDiemCK.Text);
                    updateCmd.Parameters.AddWithValue("@MaSV", maSV);
                    updateCmd.Parameters.AddWithValue("@MaLop", maLop);
                    conn.Open();
                    updateCmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Đã cập nhật điểm!");
                    LoadBangDiemTheoLop(maLop);

                }
            }
            else
            {
                SqlCommand insertCmd = new SqlCommand(
                    "INSERT INTO tblDiem(MaSV, MaLop, DiemTX, DiemGK, DiemCK) VALUES(@MaSV,@MaLop,@TX,@GK,@CK)", conn);
                insertCmd.Parameters.AddWithValue("@MaSV", maSV);
                insertCmd.Parameters.AddWithValue("@MaLop", maLop);
                insertCmd.Parameters.AddWithValue("@TX", txtDiemTX.Text);
                insertCmd.Parameters.AddWithValue("@GK", txtDiemGK.Text);
                insertCmd.Parameters.AddWithValue("@CK", txtDiemCK.Text);
                conn.Open();
                insertCmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Đã thêm điểm!");
                LoadBangDiemTheoLop(maLop);

            }
        }

        private void txtDiemTX_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMaLop_Click(object sender, EventArgs e)
        {

        }
    }
}
