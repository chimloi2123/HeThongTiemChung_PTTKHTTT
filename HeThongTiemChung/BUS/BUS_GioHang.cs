using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_GioHang
    {
        DAL_GioHang dal_GH = new DAL_GioHang();
        public List<DTO_GioHang> LayToanBoGioHang()
        {
            return dal_GH.LayToanBoDonMua();
        }
        public List<DTO_GioHang> LayToanBoDonMuavoiMaKH(string s)
        {
            return dal_GH.LayToanBoDonMuavoiMaKH(s);
        }
        public DTO_GioHang LayGioHangVoiMaGH(string ma)
        {
            return dal_GH.LayGioHangVoiMaGH(ma);
        }
    }
}
