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
    public partial class KiemTraMaThe : Form
    {
        public KiemTraMaThe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string maKH = txt_makh.Text;
            string maThe = txt_mathe.Text;
            if (maKH == ""){
                
            } else
            {
                BUS_KhachHang bus_KH = new BUS_KhachHang();
                List<DTO_KhachHang> dskh = bus_KH.KiemTraMaTheKH(maKH, maThe);
                dataGridView1.DataSource = dskh;
            }
        }
    }
}
