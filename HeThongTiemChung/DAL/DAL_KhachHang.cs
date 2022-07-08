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
    public class DAL_KhachHang: DAL_DataAccess
    {

        public List<DTO_KhachHang> LayToanBoKhachHang()
        {
            List<DTO_KhachHang> dsKhachHang = new List<DTO_KhachHang>();
            MoKetNoi();
            SqlCommand cmd = new SqlCommand("Select * from KHACHHANG", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string ma = dr.GetString(0);
                string ten = dr.GetString(1);
                string ns = dr.GetDateTime(2).ToShortDateString();
                string gt = dr.GetString(3);
                string dc = dr.GetString(4);
                string sdt = dr.GetString(5);
                string ngh = dr.GetString(7);
                DTO_KhachHang KH = new DTO_KhachHang(ma, ten, ns, gt, dc, sdt, "********", ngh);

                dsKhachHang.Add(KH);
            }
            DongKetNoi();
            return dsKhachHang;
        }

        public List<DTO_KhachHang> LayKhachHangTheoMaHoacSDT(string s)
        {
            List<DTO_KhachHang> dsKhachHang = new List<DTO_KhachHang>();
            MoKetNoi();
            SqlCommand cmd = new SqlCommand("Select * from KHACHHANG where MAKH = @ma or SDT = @ma", con);
            cmd.Parameters.AddWithValue("@ma", s);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string ma = dr.GetString(0);
                string ten = dr.GetString(1);
                string ns = dr.GetDateTime(2).ToShortDateString();
                string gt = dr.GetString(3);
                string dc = dr.GetString(4);
                string sdt = dr.GetString(5);
                string ngh = dr.GetString(7);
                DTO_KhachHang KH = new DTO_KhachHang(ma, ten, ns, gt, dc, sdt, "********", ngh);

                dsKhachHang.Add(KH);
            }
            DongKetNoi();
            return dsKhachHang;
        }

        public DTO_KhachHang LayKhachHangVoiMa(string ma)
        {
            MoKetNoi();
            DTO_KhachHang KH = new DTO_KhachHang();
            SqlCommand cmd = new SqlCommand("Select * from KHACHHANG where MAKH = @ma", con);
            cmd.Parameters.AddWithValue("@ma", ma);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string makh = dr.GetString(0);
                string ten = dr.GetString(1);
                string ns = dr.GetDateTime(2).ToShortDateString();
                string gt = dr.GetString(3);
                string dc = dr.GetString(4);
                string sdt = dr.GetString(5);
                string ngh = dr.GetString(7);
                KH = new DTO_KhachHang(makh, ten, ns, gt, dc, sdt, "********", ngh);
            }
            DongKetNoi();
            return KH;
        }
        public List<DTO_KhachHang> KiemTraMaTheKH(string ma, string ma2)
        {
            MoKetNoi();
            List<DTO_KhachHang> KH = new List<DTO_KhachHang>();
            SqlCommand cmd = new SqlCommand("Select MAKH, HOTEN, NGSINH, MATHE from KHACHHANG where MAKH = @ma and MATHE = @the", con);
            cmd.Parameters.AddWithValue("@ma", ma);
            cmd.Parameters.AddWithValue("@the", ma2);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string makh = dr.GetString(0);
                string ten = dr.GetString(1);
                string ns = dr.GetDateTime(2).ToString();
                string mathe = dr.GetString(3);
                DTO_KhachHang KHA = new DTO_KhachHang(makh, ten, ns, mathe);

                KH.Add(KHA);
            }
            DongKetNoi();
            return KH;
        }
    }
}
