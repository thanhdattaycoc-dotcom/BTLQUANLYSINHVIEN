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
    public partial class FormTrangChuGiangVien : Form
    {
        public FormTrangChuGiangVien()
        {
            InitializeComponent();
        }

        private void btnQuanLyGiaoVien_Click(object sender, EventArgs e)
        {
            FormQuanLyGiangVien frm = new FormQuanLyGiangVien();
            frm.ShowDialog();
        }

        private void lblMaGiaoVien_Click(object sender, EventArgs e)
        {

        }

        private void lblHoTenGiaoVien_Click(object sender, EventArgs e)
        {

        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            FormThongTinGiangVien frm = new FormThongTinGiangVien();
            frm.ShowDialog();
        }

        private void btnQuanLySinhVien_Click(object sender, EventArgs e)
        {
            FormQuanLySinhVien frm = new FormQuanLySinhVien();
            frm.ShowDialog();
        }

        private void btnQuanLyLopHoc_Click(object sender, EventArgs e)
        {
            FormQuanLyLopHoc frm = new FormQuanLyLopHoc();
            frm.ShowDialog();
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            FormQuanLyNhapDiem frm = new FormQuanLyNhapDiem();
            frm.ShowDialog();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            FormBaoCao frm = new FormBaoCao();
            frm.ShowDialog();
        }

        private void FormTrangChuGiangVien_Load(object sender, EventArgs e)
        {
            lblMaGiaoVien.Text = "Mã giáo viên: " + NhoTamThoi.MaGV;
            lblHoTenGiaoVien.Text = "Họ và tên giáo viên: " + NhoTamThoi.TenGV;
        }

    }
}
