using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHang
    {
        public string maKH { get; set; }
        public string hoTen { get; set; }
        public string ngaySinh { get; set; }
        public string gioiTinh { get; set; }
        public string sdt { get; set; }
        public string diaChi { get; set; }
        public string maThe { get; set; }
        public string maNGH { get; set; }

        public DTO_KhachHang(string maKH, string hoTen, string ngaySinh, string gioiTinh, string sdt, string diaChi, string maThe, string maNGH)
        {
            this.maKH = maKH;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.sdt = sdt;
            this.diaChi = diaChi;
            this.maThe = maThe;
            this.maNGH = maNGH;
        }
        public DTO_KhachHang()
        {
            this.maKH = "";
            this.hoTen = "";
            this.ngaySinh = "";
            this.gioiTinh = "";
            this.sdt = "";
            this.diaChi = "";
            this.maThe = "";
            this.maNGH = "";
        }
    }
}
