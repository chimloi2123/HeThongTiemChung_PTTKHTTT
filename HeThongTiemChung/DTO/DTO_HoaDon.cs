using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDon
    {
        public string maHD { get; set; }
        public string maNV { get; set; }
        public string ngaylap { get; set; }
        public string httt { get; set; }
        public string stt { get; set; } 
        public int thanhtien { get; set; }

        public string tinhtrang { get; set; }
        
        

        public DTO_HoaDon(string maHD, string maNV, string ngaylap, string httt, string stt, int thanhtien, string tinhtrang)
        {
            this.maHD = maHD;
            this.maNV = maNV;
            this.ngaylap = ngaylap;
            this.httt = httt;
            this.stt = stt;
            this.thanhtien = thanhtien;
            this.tinhtrang = tinhtrang;
        }
        public DTO_HoaDon()
        {
            this.maHD = "";
            this.maNV = "";
            this.ngaylap = "";
            this.httt = "";
            this.stt = "";
            this.thanhtien = 0;
            this.tinhtrang = "";
        }
    }
}
