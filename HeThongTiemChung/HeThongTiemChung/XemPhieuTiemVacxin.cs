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
    public partial class XemPhieuTiemVacxin : Form
    {
        public XemPhieuTiemVacxin()
        {
            InitializeComponent();

        }

        private void dgv_CTPT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string maVX = dgv_CTPT.Rows[e.RowIndex].Cells[1].Value.ToString();

            tb_MaVX.Text = maVX;
        }

        private void btn_Ghi_Click(object sender, EventArgs e)
        {
            string tim = tb_MaPhieu.Text.ToUpper();

            string maPT = tb_MaPhieu.Text;
            string maVX = tb_MaVX.Text;
            string ngay = tb_NgayTiem.Text;
            BUS_CT_PhieuTiem bus_CTPT = new BUS_CT_PhieuTiem();
            bool res = bus_CTPT.GhiNgayTiem(maPT, maVX, ngay);
            if (res)
            {
                List<DTO_CT_PhieuTiem> dsPhieuTiem = bus_CTPT.LayChiTietCuaPhieuTiem(tim);
                dgv_CTPT.DataSource = dsPhieuTiem;
            }
            else
            {
                MessageBox.Show("Ngày tiêm không hợp lệ.");
            }
            
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            string tim = tb_MaPhieu.Text.ToUpper();

            BUS_PhieuTiem bus_PT = new BUS_PhieuTiem();
            BUS_CT_PhieuTiem bus_CTPT = new BUS_CT_PhieuTiem();
            BUS_KhachHang bus_KH = new BUS_KhachHang();

            DTO_PhieuTiemVacxin phieuTiem = bus_PT.LayPhieuTiemTheoMa(tim);
            DTO_KhachHang khachHang = bus_KH.LayKhachHangVoiMa(phieuTiem.maKH);
            List<DTO_CT_PhieuTiem> dsPhieuTiem = bus_CTPT.LayChiTietCuaPhieuTiem(tim);
            List<DTO_CT_PhieuTiem> dsGoiTiem = bus_CTPT.LayChiTietPhieuTiemGoi(tim);

            dgv_CTPT.DataSource = dsPhieuTiem;
            dgv_CTGT.DataSource = dsGoiTiem;
            tb_HoTen.Text = khachHang.hoTen;
            tb_MaKH.Text = khachHang.maKH;
            tb_GioiTinh.Text = khachHang.gioiTinh;
            tb_NgaySinh.Text = khachHang.ngaySinh;
            tb_NgayLap.Text = phieuTiem.ngayLap;
            tb_MaHD.Text = phieuTiem.maHD;
            tb_MaNV.Text = phieuTiem.maNV;
        }

        private void btn_Ve_Click(object sender, EventArgs e)
        {
            TiemChung obj = new TiemChung();
            obj.Show();
            this.Hide();
        }

        private void btn_GhiGoi_Click(object sender, EventArgs e)
        {
            string tim = tb_MaPhieu.Text.ToUpper();

            string maPT = tb_MaPhieu.Text;
            string maGoi = tb_MaGoi.Text;
            string ngay = tb_NgayTiemGoi.Text;
            BUS_CT_PhieuTiem bus_CTPT = new BUS_CT_PhieuTiem();
            bool res = bus_CTPT.GhiNgayTiemGoi(maPT, maGoi, ngay);

            if (res)
            {
                List<DTO_CT_PhieuTiem> dsGoiTiem = bus_CTPT.LayChiTietPhieuTiemGoi(tim);
                dgv_CTGT.DataSource = dsGoiTiem;
            }
            else
            {
                MessageBox.Show("Ngày tiêm không hợp lệ.");
            }
        }

        private void dgv_CTGT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string maGoi = dgv_CTGT.Rows[e.RowIndex].Cells[1].Value.ToString();

            tb_MaGoi.Text = maGoi;
        }
    }
}
