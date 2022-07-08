using System;       
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_GioHang
    {
        public string maDDM { get; set; }
        public string maKH { get; set; }
        public string maNV { get; set; }
        public string maDDH { get; set; }
        public string ngayLap { get; set; }
        public int daDuyet { get; set; }


        public DTO_GioHang(string maDDM, string maKH, string maNV, string maDDH, string ngayLap, int daDuyet)
        {

            this.maDDM = maDDM;
            this.maKH = maKH;
            this.maNV = maNV;
            this.maDDH = maDDH;
            this.ngayLap = ngayLap;
            this.daDuyet=daDuyet;
        }

        public DTO_GioHang()
        {

            this.maDDM = "";
            this.maKH = "";
            this.maNV = "";
            this.maDDH = "";
            this.ngayLap = "";
            this.daDuyet = 0;
        }

    }
}
