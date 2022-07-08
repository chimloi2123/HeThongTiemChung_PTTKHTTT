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

namespace HeThongTiemChung
{
    public partial class DangNhap : Form
    {

        public DangNhap()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            DTO_DangNhap dn = new DTO_DangNhap();
            string tk = tb_TaiKhoan.Text;
            dn.setTaiKhoan(tk);
            
            if(tk.Substring(0, 2) == "TC")
            {
                TiemChung obj = new TiemChung();
                obj.Show();
                this.Hide();
                return;
            } 
            else if(tk.Substring(0, 2) == "LT")
            {
                LapHoaDon obj = new LapHoaDon();
                obj.Show();
                this.Hide();
                return;
            }
            else if (tk.Substring(0, 2) == "BS")
            {
                XemLich obj = new XemLich();
                obj.Show();
                this.Hide();
                return;
            }
            else if (tk.Substring(0,2) == "KH")
            {
                MHDatVacxin obj = new MHDatVacxin();
                obj.Show();
                this.Hide();
                return;
            }
            else if (tk.Substring(0, 2) == "DH")
            {
                DuyetLich obj = new DuyetLich();
                obj.Show();
                this.Hide();
                return;
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
