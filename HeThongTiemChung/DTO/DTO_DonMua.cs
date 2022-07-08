using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DonMua
    {
        public string maDDM { get; set; }
        public string maKH { get; set; }
        public string maNV { get; set; }
        public string maDDH { get; set; }
        public string ngayLap { get; set; }
        public int daDuyet { get; set; }

        public DTO_DonMua()
        {
            maDDM = "";
            maKH = "";
            maNV = "";
            maDDH = "";
            ngayLap = "";
            daDuyet = 0;
        }

        public DTO_DonMua(string maDDM, string maKH, string maNV, string maDDH, string ngayLap, int daDuyet)
        {
            this.maDDM = maDDM;
            this.maKH = maKH;
            this.maNV = maNV;
            this.maDDH = maDDH;
            this.daDuyet =  daDuyet;
            this.ngayLap = ngayLap;
        }
    }
}
