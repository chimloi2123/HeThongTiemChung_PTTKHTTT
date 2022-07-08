using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;


namespace BUS
{
    public class BUS_XemLich
    {
        DAL_XemLich dal_xemlich = new DAL_XemLich();
        public List<DTO_XemLich> XemLichNV()
        {
            return dal_xemlich.XemLichNV();
        }
    }
}
