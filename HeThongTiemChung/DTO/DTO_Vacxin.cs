using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Vacxin
    {
        public string maVX { get; set; }
        public string tenVX { get; set; }
        public int gia { get; set; }
        public string thongTin { get; set; }
        public int slTon { get; set; }

        public DTO_Vacxin(string maVX, string tenVX, int gia, string thongTin, int slTon)
        {
            this.maVX = maVX;
            this.tenVX = tenVX;
            this.gia = gia;
            this.thongTin = thongTin;
            this.slTon= slTon;
        }

        public DTO_Vacxin()
        {
            this.maVX = "";
            this.tenVX = "";
            this.gia = 0;
            this.thongTin = "";
            this.slTon = 0;
            
        }
    }
    
}
