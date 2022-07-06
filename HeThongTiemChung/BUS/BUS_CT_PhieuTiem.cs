using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_CT_PhieuTiem
    {
        DAL_CT_PhieuTiem dal_CTPT = new DAL_CT_PhieuTiem();
        public List<DTO_CT_PhieuTiem> LayChiTietCuaPhieuTiem(string ma)
        {
            return dal_CTPT.LayChiTietCuaPhieuTiem(ma);
        }

        public bool GhiNgayTiem(string maPT, string maVX, string ngay)
        {
            if (KiemTraNgay(ngay) == false)
            {
                return false;
            }
            else
            {
                dal_CTPT.GhiNgayTiem(maPT, maVX, ngay);
                return true;
            }
        }

        public List<DTO_CT_PhieuTiem> LayChiTietPhieuTiemGoi(string ma)
        {
            return dal_CTPT.LayChiTietPhieuTiemGoi(ma);
        }

        public bool GhiNgayTiemGoi(string maPT, string maGoi, string ngay)
        {
            if (KiemTraNgay(ngay) == false)
            {
                return false;
            }
            else
            {
                dal_CTPT.GhiNgayTiemGoi(maPT, maGoi, ngay);
                return true;
            }
        }

        public bool KiemTraNgay(string ngay)
        {
            DateTime date;
            return DateTime.TryParse(ngay, out date);
        }
    }
}
