using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLQUANLYSINHVIEN
{
    public partial class FormTrangChuSinhVien : Form
    {
        public FormTrangChuSinhVien()
        {
            InitializeComponent();

        }

        private void FormTrangChuSinhVien_Load(object sender, EventArgs e)
        {
            // Lấy thông tin từ NhoTamThoi
            lblSinhVien.Text = "Mã sinh viên: " + NhoTamThoi.MaSV;
            lblTen.Text = "Tên sinh viên: " + NhoTamThoi.TenSV;
        }

        private void btnDangKyLop_Click(object sender, EventArgs e)
        {
            FormDangKyLopHoc frm = new FormDangKyLopHoc();
            frm.Show();
        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            FormDiemHocTap frm = new FormDiemHocTap();
            frm.Show();
        }

        private void btnLichHoc_Click(object sender, EventArgs e)
        {
            FormLichHoc frm = new FormLichHoc();
            frm.Show();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            FormThongTinSinhVien frm = new FormThongTinSinhVien();
            frm.Show();
        }
    }
}
