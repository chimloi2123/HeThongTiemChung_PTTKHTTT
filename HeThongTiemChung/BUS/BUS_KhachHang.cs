using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_KhachHang
    {
        DAL_KhachHang dal_KH = new DAL_KhachHang();
        public List<DTO_KhachHang> LayToanBoKhachHang()
        {
            return dal_KH.LayToanBoKhachHang();
        }

        public List<DTO_KhachHang> LayKhachHangTheoMaHoacSDT(string s)
        {
            return dal_KH.LayKhachHangTheoMaHoacSDT(s);
        }

        public DTO_KhachHang LayKhachHangVoiMa(string ma)
        {
            return dal_KH.LayKhachHangVoiMa(ma);
        }
    }
}
