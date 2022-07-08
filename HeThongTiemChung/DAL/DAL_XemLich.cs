using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_XemLich:DAL_DataAccess
    {      
        public List<DTO_XemLich> XemLichNV()
        {           
            MoKetNoi();
            List<DTO_XemLich> lichnv = new List<DTO_XemLich>();
            SqlCommand cmd = new SqlCommand("Select L.MaLich,L.NgayBatDau,L.CA,L.THU,L.DUYET from NHANVIEN NV, NV_LICH NVL, LICH L where NV.MANV = 'BS5' and L.DUYET = '1' and NVL.MALICH = L.MALICH and NVL.MANV = NV.MANV", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int malich = dr.GetInt32(0);
                string ngbatdau = dr.GetDateTime(1).ToShortDateString();
                int ca = dr.GetInt32(2);
                int thu = dr.GetInt32(3);
                int duyet = dr.GetInt32(4);
                DTO_XemLich lich = new DTO_XemLich(malich, ca, thu, ngbatdau, duyet);

                lichnv.Add(lich);
            }
            DongKetNoi();
            return lichnv;
        }
      
    }
}
