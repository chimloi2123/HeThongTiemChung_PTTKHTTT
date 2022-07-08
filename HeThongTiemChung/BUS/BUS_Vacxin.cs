using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_Vacxin
    {
        DAL_Vacxin dal_VX = new DAL_Vacxin();
        public List<DTO_Vacxin> LayToanBoVacxin()
        {
            return dal_VX.LayToanBoVacxin();
        }

        public List<DTO_Vacxin> LayVacxinTheoMa(string s)
        {
            return dal_VX.LayVacxinTheoMa(s);
        }
    }
}
