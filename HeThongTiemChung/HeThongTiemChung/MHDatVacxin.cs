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
    public partial class MHDatVacxin : Form
    {
        public MHDatVacxin()
        {
            InitializeComponent();
        }


        private void btn_Tim_Click(object sender, EventArgs e)
        {
            //dtgv_DSVX.DataSource = BUS_Vacxin.Instance.TimKiemSPTheoTen(tb_TimKiem.Text);
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
