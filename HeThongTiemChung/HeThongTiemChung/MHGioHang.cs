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
    public partial class MHGioHang : Form
    {
        public MHGioHang()
        {
            InitializeComponent();
            HienThi();
        }

        private void HienThi()
        {
            BUS_GioHang bus_GH = new BUS_GioHang();
            List<DTO_GioHang> dsgh = bus_GH.LayToanBoGioHang();
            dataGridView1.DataSource = dsgh;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            //this.Hide();
            //MHLapHoaDon mhlaphoadon = new MHLapHoaDon();
            //mhtimsp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MHDatVacxin mhdatvx = new MHDatVacxin();
            mhdatvx.ShowDialog();
        }
    }
}
