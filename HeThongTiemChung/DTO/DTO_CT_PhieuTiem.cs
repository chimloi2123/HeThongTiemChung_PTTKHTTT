using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CT_PhieuTiem
    {
        public string maPhieu { get; set; }
        public string maVX { get; set; }
        public int donGia { get; set; }
        public string ngayTiem { get; set; }

        public DTO_CT_PhieuTiem()
        {
            maPhieu = "";
            maVX = "";
            donGia = 0;
            ngayTiem = "";
        }

        public DTO_CT_PhieuTiem(string maPhieu, string maVX, int donGia, string ngayTiem)
        {
            this.maPhieu = maPhieu;
            this.maVX = maVX;
            this.donGia = donGia;
            this.ngayTiem = ngayTiem;
        }
    }
}
