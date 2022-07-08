using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_DangKiLich
    {

        DAL_DangKiLich dal_dangki = new DAL_DangKiLich();
        public void DangKiLich(int ca,int thu,string ngay)
        {
            dal_dangki.ThemLich(ca, thu, ngay);
        }

    }
}
