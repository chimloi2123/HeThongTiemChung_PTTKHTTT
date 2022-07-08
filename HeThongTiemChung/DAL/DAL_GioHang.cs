using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_GioHang : DAL_DataAccess
    {
        public List<DTO_GioHang> LayToanBoDonMua()
        {
            List<DTO_GioHang> dsGH = new List<DTO_GioHang>();
            MoKetNoi();
            SqlCommand cmd = new SqlCommand("Select * from DONMUA", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string maDDM = dr.GetString(0);
                string maKH = dr.GetString(1);
                string maNV = dr.GetString(2);
                string maDDH = dr.GetString(3);
                string ngayLap = dr.GetDateTime(4).ToShortDateString();
                int daDuyet = dr.GetInt32(5);

                DTO_GioHang GH = new DTO_GioHang(maDDM, maKH, maNV, maDDH, ngayLap, daDuyet);

                dsGH.Add(GH);
            }
            DongKetNoi();
            return dsGH;

        }

        public List<DTO_GioHang> LayToanBoDonMuavoiMaKH(string s)
        {
            List<DTO_GioHang> dsGH = new List<DTO_GioHang>();
            MoKetNoi();
            SqlCommand cmd = new SqlCommand("Select * from DONMUA where MAKH = @ma", con);
            cmd.Parameters.AddWithValue("@ma", s);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string maDDM = dr.GetString(0);
                string maKH = dr.GetString(1);
                string maNV = dr.GetString(2);
                string maDDH = dr.GetString(3);
                string ngayLap = dr.GetDateTime(4).ToShortDateString();
                int daDuyet = dr.GetInt32(5);

                DTO_GioHang GH = new DTO_GioHang(maDDM, maKH, maNV, maDDH, ngayLap, daDuyet);

                dsGH.Add(GH);
            }
            DongKetNoi();
            return dsGH;

        }
        public DTO_GioHang LayGioHangVoiMaGH(string ma)
        {
            MoKetNoi();
            DTO_GioHang gh = new DTO_GioHang();
            SqlCommand cmd = new SqlCommand("Select * from DONMUA where MADDM = @ma", con);
            cmd.Parameters.AddWithValue("@ma", ma);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string maDDM = dr.GetString(0);
                string maKH = dr.GetString(1);
                string maNV = dr.GetString(2);
                string maDDH = dr.GetString(3);
                string ngayLap = dr.GetDateTime(4).ToShortDateString();
                int daDuyet = dr.GetInt32(5);
                gh = new DTO_GioHang(maDDM, maKH, maNV, maDDH, ngayLap, daDuyet);
            }
            DongKetNoi();
            return gh;
        }
    }
}
