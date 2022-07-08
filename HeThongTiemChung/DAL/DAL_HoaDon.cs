using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_HoaDon : DAL_DataAccess
    {
        public List<DTO_HoaDon> LayHoaDonTheoMa(string s)
        {
            List<DTO_HoaDon> dsHoaDon = new List<DTO_HoaDon>();
            MoKetNoi();
            SqlCommand cmd = new SqlCommand("SELECT A.MAHD, A.MANV, A.NGLAP, A.HTTT, B.STT, B.THANHTIEN FROM HOADON A, DOTTHANHTOAN B WHERE A.MAHD = @ma AND A.MAHD = B.MAHD", con);
            cmd.Parameters.AddWithValue("@ma", s);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string mahd = dr.GetString(0);
                string manv = dr.GetString(1);
                string ngaylap = dr.GetDateTime(2).ToString();
                string httt = dr.GetString(3);
                string stt = dr.GetString(4);
                int thanhtien = dr.GetInt32(5);
                DTO_HoaDon HD = new DTO_HoaDon(mahd, manv, ngaylap, httt, stt, thanhtien, "");

                dsHoaDon.Add(HD);
            }
            DongKetNoi();
            return dsHoaDon;
        }
        public List<DTO_HoaDon> LayHoaDonTheoSTT(string s, string t)
        {
            List<DTO_HoaDon> dsHoaDon = new List<DTO_HoaDon>();
            MoKetNoi();
            SqlCommand cmd = new SqlCommand("SELECT A.MAHD, A.MANV, A.NGLAP, A.HTTT, B.STT, B.THANHTIEN FROM HOADON A, DOTTHANHTOAN B WHERE A.MAHD = @ma AND STT = @stt AND A.MAHD = B.MAHD", con);
            cmd.Parameters.AddWithValue("@ma", s);
            cmd.Parameters.AddWithValue("@stt", t);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string mahd = dr.GetString(0);
                string manv = dr.GetString(1);
                string ngaylap = dr.GetDateTime(2).ToString();
                string httt = dr.GetString(3);
                string stt = dr.GetString(4);
                int thanhtien = dr.GetInt32(5);
                DTO_HoaDon HD = new DTO_HoaDon(mahd, manv, ngaylap, httt, stt, thanhtien, "");

                dsHoaDon.Add(HD);
            }
            DongKetNoi();
            return dsHoaDon;
        }

        public bool ThemHoaDonI(string a, string b, string c, string d, string e, string f)
        {
            MoKetNoi();
            SqlCommand cmd = new SqlCommand("INSERT [dbo].[HOADON] ([MAHD], [MANV], [NGLAP], [HTTT]) " +
                "VALUES (@maHD, @maNV, GETDATE(), @httt);", con);
            SqlCommand cmd1 = new SqlCommand("INSERT [dbo].[DOTTHANHTOAN] ([STT], [MAHD], [TINHTRANG], [THANHTIEN], [NGAYTT]) " +
                "VALUES (@stt, @maHD, @tinhtrang, @thanhtien, GETDATE());", con);
            cmd.Parameters.AddWithValue("@maHD", a);
            cmd.Parameters.AddWithValue("@maNV", b);
            cmd.Parameters.AddWithValue("@httt", c);

            cmd1.Parameters.AddWithValue("@maHD", a);
            cmd1.Parameters.AddWithValue("@stt", d);
            cmd1.Parameters.AddWithValue("@tinhtrang", e);
            cmd1.Parameters.AddWithValue("@thanhtien", f);
            int res = cmd.ExecuteNonQuery();
            int res1 = cmd1.ExecuteNonQuery();

            DongKetNoi();
            return res > 1 || res1 > 1;
        }


        public bool ThemHoaDonII(string a, string b, string c, string d, string e, string f)
        {
            MoKetNoi();
            SqlCommand cmd1 = new SqlCommand("INSERT [dbo].[DOTTHANHTOAN] ([STT], [MAHD], [TINHTRANG], [THANHTIEN], [NGAYTT]) " +
                "VALUES (@stt, @maHD, @tinhtrang, @thanhtien, GETDATE());", con);

            cmd1.Parameters.AddWithValue("@maHD", a);
            cmd1.Parameters.AddWithValue("@stt", d);
            cmd1.Parameters.AddWithValue("@tinhtrang", e);
            cmd1.Parameters.AddWithValue("@thanhtien", f);
            int res1 = cmd1.ExecuteNonQuery();

            DongKetNoi();
            return res1 > 1;
        }

        public bool KiemtraDon(string a, string b)
        {
            string ktra = a;
            int res1;
            if (ktra == "DONMUA")
           {
                List<DTO_HoaDon> dsHoaDon = new List<DTO_HoaDon>();
                MoKetNoi();
                SqlCommand cmd1 = new SqlCommand("SELECT * FROM DONMUA WHERE MADDM = @ma", con);

                cmd1.Parameters.AddWithValue("@ma", b);
                res1 = cmd1.ExecuteNonQuery();

                DongKetNoi();
                return res1 > 1;
            } 
            else if (ktra == "PHIEUTIEMVACXIN")
            {
                List<DTO_HoaDon> dsHoaDon = new List<DTO_HoaDon>();
                MoKetNoi();
                SqlCommand cmd1 = new SqlCommand("SELECT * FROM PHIEUTIEMVACXIN WHERE MAPT = @ma", con);

                cmd1.Parameters.AddWithValue("@ma", b);

                res1 = cmd1.ExecuteNonQuery();

                DongKetNoi();
                return res1 > 1;
            } else
            {
                return false;
            }
        }
    }
}
