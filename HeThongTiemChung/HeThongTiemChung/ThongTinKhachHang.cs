using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace HeThongTiemChung
{
    public partial class ThongTinKhachHang : Form
    {
        public ThongTinKhachHang()
        {
            InitializeComponent();
            HienThi();
        }

        private void HienThi()
        {
            BUS_KhachHang bus_KH = new BUS_KhachHang();
            List<DTO_KhachHang> dskh = bus_KH.LayToanBoKhachHang();
            dgv_KhachHang.DataSource = dskh;
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            string tim = tb_Tim.Text.ToUpper();
            if (tim == "")
            {
                HienThi();
            }
            else
            {
                BUS_KhachHang bus_KH = new BUS_KhachHang();
                List<DTO_KhachHang> dskh = bus_KH.LayKhachHangTheoMaHoacSDT(tim);
                dgv_KhachHang.DataSource = dskh;
            }
        }

        private void btn_Ve_Click(object sender, EventArgs e)
        {
            TiemChung obj = new TiemChung();
            obj.Show();
            this.Hide();
        }

        private void dgv_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ThongTinKhachHang_Load(object sender, EventArgs e)
        {

        }
    }
}
