using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;

namespace HeThongTiemChung
{
    public partial class DuyetLich : Form
    {
        public DuyetLich()
        {
            InitializeComponent();
        }

        private void DuyetLich_Load(object sender, EventArgs e)
        {

        }

        private void LoadLich_Click(object sender, EventArgs e)
        {
            SangCN.Checked = false;
            SangT2.Checked = false;
            SangT3.Checked = false;
            SangT4.Checked = false;
            SangT5.Checked = false;
            SangT6.Checked = false;
            SangT7.Checked = false;
            ChieuCN.Checked = false;
            ChieuT2.Checked = false;
            ChieuT3.Checked = false;
            ChieuT4.Checked = false;
            ChieuT5.Checked = false;
            ChieuT6.Checked = false;
            ChieuT7.Checked = false;
            ToiCN.Checked = false;
            ToiT2.Checked = false;
            ToiT3.Checked = false;
            ToiT4.Checked = false;
            ToiT5.Checked = false;
            ToiT6.Checked = false;
            ToiT7.Checked = false;
            string a = NgayBatDau.Text;
            string b = MaNV.Text;
            BUS_DuyetLich xem = new BUS_DuyetLich();
            List<DTO_DuyetLich> ds = xem.XemLichChuaDuyet(a, b);
            foreach (DTO_DuyetLich l in ds)
            {

                if (l.ca == 1 && l.thu == 1)
                {
                    SangCN.Checked = true;
                }
                else if (l.ca == 1 && l.thu == 2)
                {
                    SangT2.Checked = true;
                }
                else if (l.ca == 1 && l.thu == 3)
                {
                    SangT3.Checked = true;
                }
                else if (l.ca == 1 && l.thu == 4)
                {
                    SangT4.Checked = true;
                }
                else if (l.ca == 1 && l.thu == 5)
                {
                    SangT5.Checked = true;
                }
                else if (l.ca == 1 && l.thu == 6)
                {
                    SangT6.Checked = true;
                }
                else if (l.ca == 1 && l.thu == 7)
                {
                    SangT7.Checked = true;
                }
                if (l.ca == 2 && l.thu == 1)
                {
                    ChieuCN.Checked = true;
                }
                else if (l.ca == 2 && l.thu == 2)
                {
                    ChieuT2.Checked = true;
                }
                else if (l.ca == 2 && l.thu == 3)
                {
                    ChieuT3.Checked = true;
                }
                else if (l.ca == 2 && l.thu == 4)
                {
                    ChieuT4.Checked = true;
                }
                else if (l.ca == 2 && l.thu == 5)
                {
                    ChieuT5.Checked = true;
                }
                else if (l.ca == 2 && l.thu == 6)
                {
                    ChieuT6.Checked = true;
                }
                else if (l.ca == 2 && l.thu == 7)
                {
                    ChieuT7.Checked = true;
                }
                if (l.ca == 3 && l.thu == 1)
                {
                    ToiCN.Checked = true;
                }
                else if (l.ca == 3 && l.thu == 2)
                {
                    ToiT2.Checked = true;
                }
                else if (l.ca == 3 && l.thu == 3)
                {
                    ToiT3.Checked = true;
                }
                else if (l.ca == 3 && l.thu == 4)
                {
                    ToiT4.Checked = true;
                }
                else if (l.ca == 3 && l.thu == 5)
                {
                    ToiT5.Checked = true;
                }
                else if (l.ca == 3 && l.thu == 6)
                {
                    ToiT6.Checked = true;
                }
                else if (l.ca == 3 && l.thu == 7)
                {
                    ToiT7.Checked = true;
                }              
            }
        }

        private void Duyet_Click(object sender, EventArgs e)
        {
           
                string a = NgayBatDau.Text;
                string b = MaNV.Text;
                BUS_DuyetLich dki = new BUS_DuyetLich();
                dki.Duyet(a, b);        
                MessageBox.Show("Duyệt hoàn tất");
            
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            DangNhap obj = new DangNhap();
            obj.Show();
            this.Hide();
            return;
        }
    }
}
