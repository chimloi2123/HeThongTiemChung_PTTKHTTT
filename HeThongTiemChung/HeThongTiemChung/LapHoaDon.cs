using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace HeThongTiemChung
{
    public partial class LapHoaDon : Form
    {
        public LapHoaDon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {   
            KiemTraMaThe obj = new KiemTraMaThe();
            obj.Show();
            return;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XuatHoaDon obj = new XuatHoaDon();
            obj.Show();
            return;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txt_loaihinhtt.Text == "Toan bo")
            {
                try
                {
                    string a = txt_mahd.Text;
                    string b = txt_manv.Text;
                    string c = txt_httt.Text;
                    string d = "1";
                    string g = ccb_tinhtrang.Text;
                    string f = txt_sotien.Text;
                    BUS_HoaDon bus_CTPT = new BUS_HoaDon();
                    bool res = bus_CTPT.ThemHoaDonI(a, b, c, d, g, f);
                    MessageBox.Show("Thêm hóa đơn thành công thành công!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR" + ex.Message);
                }
            }
            else if(txt_loaihinhtt.Text == "Theo dot")
            {
                try
                {
                    string a = txt_mahdt.Text;
                    string b = txt_manv.Text;
                    string c = txt_httt.Text;
                    string d = txt_stt.Text;
                    string g = ccb_tinhtrang.Text;
                    string f = txt_sotien.Text;
                    BUS_HoaDon bus_CTPT = new BUS_HoaDon();
                    bool res = bus_CTPT.ThemHoaDonII(a, b, c, d, g, f);
                    MessageBox.Show("Thêm hóa đơn theo đợt thành công thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR" + ex.Message);
                }
            }
            
        }
    }
}
