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
    public partial class DangKiLich : Form
    {
        public DangKiLich()
        {
            InitializeComponent();
        }

        private void Quaylai_Click(object sender, EventArgs e)
        {
            XemLich obj = new XemLich();
            obj.Show();
            this.Hide();
        }

        private void DangKi_Click(object sender, EventArgs e)
        {
            BUS_DangKiLich dki = new BUS_DangKiLich();
            if (SangCN.Checked == true)
            {
                dki.DangKiLich(1, 1, NgayBatDau.Text);
            }
            if (SangT2.Checked == true)
            {
                dki.DangKiLich(1, 2, NgayBatDau.Text);
            }
            if (SangT3.Checked == true)
            {
                dki.DangKiLich(1, 3, NgayBatDau.Text);
            }
            if (SangT4.Checked == true)
            {
                dki.DangKiLich( 1, 4, NgayBatDau.Text);
            }
            if (SangT5.Checked == true)
            {
                dki.DangKiLich( 1, 5, NgayBatDau.Text);
            }
            if (SangT6.Checked == true)
            {
                dki.DangKiLich( 1, 6, NgayBatDau.Text);
            }
            if (SangT7.Checked == true)
            {
                dki.DangKiLich( 1, 7, NgayBatDau.Text);
            }
            if (ChieuCN.Checked == true)
            {
                dki.DangKiLich( 2, 1, NgayBatDau.Text);
            }
            if (ChieuT2.Checked == true)
            {
                dki.DangKiLich( 2, 2, NgayBatDau.Text);
            }
            if (ChieuT3.Checked == true)
            {
                dki.DangKiLich( 2, 3, NgayBatDau.Text);
            }
            if (ChieuT4.Checked == true)
            {
                dki.DangKiLich( 2, 4, NgayBatDau.Text);
            }
            if (ChieuT5.Checked == true)
            {
                dki.DangKiLich( 2, 5, NgayBatDau.Text);
            }
            if (ChieuT6.Checked == true)
            {
                dki.DangKiLich( 2, 6, NgayBatDau.Text);
            }
            if (ChieuT7.Checked == true)
            {
                dki.DangKiLich( 2, 7, NgayBatDau.Text);
            }
            if (ToiCN.Checked == true)
            {
                dki.DangKiLich( 3, 1, NgayBatDau.Text);
            }
            if (ToiT2.Checked == true)
            {
                dki.DangKiLich( 3, 2, NgayBatDau.Text);
            }
            if (ToiT3.Checked == true)
            {
                dki.DangKiLich( 3, 3, NgayBatDau.Text);
            }
            if (ToiT4.Checked == true)
            {
                dki.DangKiLich( 3, 4, NgayBatDau.Text);
            }
            if (ToiT5.Checked == true)
            {
                dki.DangKiLich( 3, 5, NgayBatDau.Text);
            }
            if (ToiT6.Checked == true)
            {
                dki.DangKiLich( 3, 6, NgayBatDau.Text);
            }
            if (ToiT7.Checked == true)
            {
                dki.DangKiLich( 3, 7, NgayBatDau.Text);
            }
            
            XemLich obj = new XemLich();
            obj.Show();
            this.Hide();

        }
    }
}
