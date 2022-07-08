using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_HoaDon
    {
        DAL_HoaDon dal_HD = new DAL_HoaDon();
        public List<DTO_HoaDon> LayHoaDonTheoMa(string s)
        {
            return dal_HD.LayHoaDonTheoMa(s);
        }

        public List<DTO_HoaDon> LayHoaDonTheoSTT(string s, string t)
        {
            return dal_HD.LayHoaDonTheoSTT(s, t);
        }
        public bool ThemHoaDonI(string a, string b, string c, string d, string e, string f)
        {
            return dal_HD.ThemHoaDonI(a, b, c, d, e, f);
        }
        public bool ThemHoaDonII(string a, string b, string c, string d, string e, string f)
        {
            return dal_HD.ThemHoaDonII(a, b, c, d, e, f);
        }
        public bool KiemtraDon(string a, string b)
        {
            return dal_HD.KiemtraDon(a, b);
        }
    }
}
