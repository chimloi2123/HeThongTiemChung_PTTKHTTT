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
        public List<DTO_CT_PhieuTiem> LayChiTietCuaPhieuTiem(int ma)
        {
            return dal_CTPT.LayChiTietCuaPhieuTiem(ma);
        }

        public bool GhiNgayTiem(int maPT, string maVX, string ngay)
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

        public List<DTO_CT_PhieuTiem> LayChiTietPhieuTiemGoi(int ma)
        {
            return dal_CTPT.LayChiTietPhieuTiemGoi(ma);
        }

        public bool GhiNgayTiemGoi(int maPT, string maGoi, string ngay)
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
            bool check = false;
            DateTime date;
            check = DateTime.TryParse(ngay, out date);
            if(date > DateTime.Today)
            {
                check = false;
            }
            return check;
        }
    }
}
