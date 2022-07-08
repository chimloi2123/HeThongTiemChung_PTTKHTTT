using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DotThanhToan
    {
        public string stt { get; set; }
        public string maHd { get; set; }
        public string tinhTrang { get; set; }
        public string thanhTien { get; set; }
        public string ngayTT { get; set; }

        public DTO_DotThanhToan()
        {
            stt = "";
            maHd = "";
            tinhTrang = "";
            thanhTien = "";
            ngayTT = "";
        }

        public DTO_DotThanhToan(string stt, string maHd, string tinhTrang, string thanhTien, string ngayTT)
        {
            this.stt = stt;
            this.maHd = maHd;
            this.tinhTrang = tinhTrang;
            this.thanhTien = thanhTien;
            this.ngayTT = ngayTT;
        }
    }
}
