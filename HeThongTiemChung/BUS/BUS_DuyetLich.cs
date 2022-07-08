using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_DuyetLich
    {
        DAL_DuyetLich dal_duyetlich = new DAL_DuyetLich();
        public List<DTO_DuyetLich> XemLichChuaDuyet(string ngbatdau, string manv)
        {
            return dal_duyetlich.XemLichChuaDuyet(ngbatdau,manv);
        }
        public void Duyet(string ngbatdau, string manv)
        {
            dal_duyetlich.Duyet(ngbatdau, manv);
        }
    }
}
