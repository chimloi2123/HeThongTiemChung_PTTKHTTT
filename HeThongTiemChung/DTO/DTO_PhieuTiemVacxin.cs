using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhieuTiemVacxin
    {
        public int maPhieu { get; set; }
        public string maKH { get; set; }
        public string maNV { get; set; }
        public string maHD { get; set; }
        public string ngayLap { get; set; }

        public DTO_PhieuTiemVacxin(int maPhieu, string maKH, string maNV, string maHD, string ngayLap)
        {
            this.maPhieu = maPhieu;
            this.maKH = maKH;
            this.maNV = maNV;
            this.maHD = maHD;
            this.ngayLap = ngayLap;
        }

        public DTO_PhieuTiemVacxin()
        {
            this.maPhieu = 0;
            this.maKH = "";
            this.maNV = "";
            this.maHD = "";
            this.ngayLap = "";
        }
    }
}
