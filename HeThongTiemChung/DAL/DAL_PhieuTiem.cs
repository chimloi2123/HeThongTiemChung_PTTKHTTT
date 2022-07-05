using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_PhieuTiem : DAL_DataAccess
    {
        public DTO_PhieuTiemVacxin LayPhieuTiemTheoMa(string ma)
        {
            DTO_PhieuTiemVacxin phieu = new DTO_PhieuTiemVacxin();
            MoKetNoi();
            SqlCommand cmd = new SqlCommand("Select * from PHIEUTIEMVACXIN where MAPT = @ma", con);
            cmd.Parameters.AddWithValue("@ma", ma);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string maPT = dr.GetString(0);
                string maKH = dr.GetString(1);
                string maNV = dr.GetString(2);
                string maHD = dr.GetString(3);
                string ngayLap = dr.GetDateTime(4).ToShortDateString();
                phieu = new DTO_PhieuTiemVacxin(maPT, maKH, maNV, maHD, ngayLap);
            }
            DongKetNoi();
            return phieu;
        }
    }
}
