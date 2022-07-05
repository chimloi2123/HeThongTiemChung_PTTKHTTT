using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_PhieuTiem
    {
        DAL_PhieuTiem dal_PT = new DAL_PhieuTiem();
        public DTO_PhieuTiemVacxin LayPhieuTiemTheoMa(string ma)
        {
            return dal_PT.LayPhieuTiemTheoMa(ma);
        }
    }
}
