using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhanVien
    {
        public string maNV { get; set; }
        public string hoTen { get; set; }
        public string ngaySinh { get; set; }
        public string gioiTinh { get; set; }
        public string diaChi { get; set; }
        public string sdt { get; set; }
        public string bangCap { get; set; }
        public string eMail { get; set; }
        public string luong { get; set; }
        public string maTT { get; set; }
        public string maLoai { get; set; }


        public DTO_NhanVien(string maNV, string hoTen, string ngaySinh, string gioiTinh, string diaChi, string sdt, string bangCap, string eMail, string luong, string maTT, string maLoai)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.sdt = sdt;     
            this.bangCap = bangCap;
            this.eMail = eMail;
            this.luong = luong;
            this.maTT = maTT;
            this.maLoai = maLoai;
        }
        public DTO_NhanVien()
        {
            this.maNV = "";
            this.hoTen = "";
            this.ngaySinh = "";
            this.gioiTinh = "";
            this.diaChi = "";
            this.sdt = "";
            this.bangCap = "";
            this.eMail = "";
            this.luong = "";
            this.maTT = "";
            this.maLoai = "";
        }
    }
}
