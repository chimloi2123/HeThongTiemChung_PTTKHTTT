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
    public partial class XuatHoaDon : Form
    {
        public XuatHoaDon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            return;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void dgv_HoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tim_Click(object sender, EventArgs e)
        {
            string tim = txt_stt.Text;
            string tim2 = txt_Tim.Text;
            if (tim == "") { 
                BUS_HoaDon bus_KH = new BUS_HoaDon();
                List<DTO_HoaDon> dskh = bus_KH.LayHoaDonTheoMa(tim2);
                dgv_HoaDon.DataSource = dskh;
            } else
            {
                BUS_HoaDon bus_KH = new BUS_HoaDon();
                List<DTO_HoaDon> dskh = bus_KH.LayHoaDonTheoSTT(tim2, tim);
                dgv_HoaDon.DataSource = dskh;
            }
        }
    }
}
