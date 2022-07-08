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
    public partial class MHDatVacxin : Form
    {
        public MHDatVacxin()
        {
            InitializeComponent();
            HienThi();
        }

        private void HienThi()
        {
            BUS_Vacxin bus_VX = new BUS_Vacxin();
            List<DTO_Vacxin> dsvx = bus_VX.LayToanBoVacxin();
            dtgv_DSVX.DataSource = dsvx;
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            string tim = tb_TimKiem.Text.ToUpper();
            if (tim == "")
            {
                HienThi();
            }
            else
            {
                BUS_Vacxin bus_VX = new BUS_Vacxin();
                List<DTO_Vacxin> dsvx = bus_VX.LayVacxinTheoMa(tim);
                dtgv_DSVX.DataSource = dsvx;
            }
        }

        private void btn_ThemGioHang_Click(object sender, EventArgs e)
        {

        }

        private void btn_GioHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            MHGioHang mhgiohang = new MHGioHang();
            mhgiohang.ShowDialog();
        }

        private void btn_ThemVacxin_Click(object sender, EventArgs e)
        {

        }
    }
}
