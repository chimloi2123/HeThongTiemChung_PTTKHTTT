using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_XemLich
    {
        public int malich { get; set; }
        public int ca { get; set; }
        public int thu { get; set; }
        public string ngaybatdau { get; set; }
        public int duyet { get; set; }

        public DTO_XemLich(int ml, int c,int t, string batdau, int d)
        {
            this.malich = ml;
            this.ca = c;
            this.thu = t;
            this.ngaybatdau = batdau;
            this.duyet = d;

        }
        public DTO_XemLich()
        {
            this.malich = 0;
            this.ca = 0;
            this.thu = 0;
            this.ngaybatdau = "";
            this.duyet = 0;
        }
    }
}
