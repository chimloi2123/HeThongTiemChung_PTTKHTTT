using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongTiemChung
{
    public partial class TiemChung : Form
    {
        public TiemChung()
        {
            InitializeComponent();
        }

        private void btn_PhieuTiem_Click(object sender, EventArgs e)
        {
            XemPhieuTiemVacxin obj = new XemPhieuTiemVacxin();
            obj.Show();
            this.Hide();
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            ThongTinKhachHang obj = new ThongTinKhachHang();
            obj.Show();
            this.Hide();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DangNhap obj = new DangNhap();
            obj.Show();
            this.Hide();
        }
    }
}
