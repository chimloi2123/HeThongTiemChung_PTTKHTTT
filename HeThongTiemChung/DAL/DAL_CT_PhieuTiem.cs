using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_CT_PhieuTiem: DAL_DataAccess
    {
        public List<DTO_CT_PhieuTiem> LayChiTietCuaPhieuTiem(string ma)
        {
            List<DTO_CT_PhieuTiem> dsChiTiet = new List<DTO_CT_PhieuTiem>();
            MoKetNoi();
            SqlCommand cmd = new SqlCommand("Select * from CT_PHIEUTIEM where MAPT = @ma", con);
            cmd.Parameters.AddWithValue("@ma", ma);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string maPT = dr.GetString(0);
                string maVX = dr.GetString(1);
                int gia = dr.GetInt32(2);
                string ngayTiem = dr.GetDateTime(3).ToString();

                DTO_CT_PhieuTiem KH = new DTO_CT_PhieuTiem(maPT, maVX, gia, ngayTiem);
                dsChiTiet.Add(KH);
            }
            DongKetNoi();
            return dsChiTiet;
        }

        public bool GhiNgayTiem(string maPT, string maVX, string ngay)
        {
            MoKetNoi();
            SqlCommand cmd = new SqlCommand("Update CT_PHIEUTIEM set NGTIEM = TO_DATE(@ngay, 'MM-dd-YYYY') where MAPT = @maPT and MAVX = @maVX", con);
            cmd.Parameters.AddWithValue("@ngay", ngay);
            cmd.Parameters.AddWithValue("@maPT", maPT);
            cmd.Parameters.AddWithValue("@maVX", maVX);
            int res = cmd.ExecuteNonQuery();
            return res > 1;
        }
    }
}
