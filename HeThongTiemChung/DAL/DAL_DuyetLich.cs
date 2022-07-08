using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_DuyetLich:DAL_DataAccess
    {
        public List<DTO_DuyetLich> XemLichChuaDuyet(string NgBatDau, string MaNV)
        {
            List<DTO_DuyetLich> dslichnv = new List<DTO_DuyetLich>();
            MoKetNoi();         
            SqlCommand cmd = new SqlCommand("Select L.MaLich,L.NgayBatDau,L.CA,L.THU,L.DUYET,NVL.MaNV from NV_LICH NVL, LICH L where L.NgayBatDau = @NgBatDau and NVL.MaNV = @MaNV and L.DUYET = '0' and NVL.MALICH = L.MALICH", con);
            cmd.Parameters.AddWithValue("@NgBatDau", NgBatDau);
            cmd.Parameters.AddWithValue("@MaNV", MaNV);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int malich = dr.GetInt32(0);
                string ngbatdau = dr.GetDateTime(1).ToShortDateString();
                int ca = dr.GetInt32(2);
                int thu = dr.GetInt32(3);
                int duyet = dr.GetInt32(4);
                string manv = dr.GetString(5);
                DTO_DuyetLich lichnv = new DTO_DuyetLich(malich, ca, thu, ngbatdau, duyet, manv);

                dslichnv.Add(lichnv);
            }
            DongKetNoi();
            return dslichnv;
        }
        public void Duyet(string NgBatDau, string MaNV)
        {
            MoKetNoi();
            List<DTO_DuyetLich> dslichnv1 = new List<DTO_DuyetLich>();
            SqlCommand cmd2 = new SqlCommand("select L.MaLich,L.NgayBatDau,L.CA,L.THU,L.DUYET,NVL.MaNV from NV_LICH NVL, LICH L where L.NgayBatDau = @NgBatDau and NVL.MaNV = @MaNV and NVL.MALICH = L.MALICH and L.DUYET = '1'", con);
            cmd2.Parameters.AddWithValue("@NgBatDau", NgBatDau);
            cmd2.Parameters.AddWithValue("@MaNV", MaNV);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                int malich = dr2.GetInt32(0);
                string ngbatdau = dr2.GetDateTime(1).ToShortDateString();
                int ca = dr2.GetInt32(2);
                int thu = dr2.GetInt32(3);
                int duyet = dr2.GetInt32(4);
                string manv = dr2.GetString(5);
                DTO_DuyetLich lichnv1 = new DTO_DuyetLich(malich, ca, thu, ngbatdau, duyet, manv);

                dslichnv1.Add(lichnv1);
            }
            dr2.Close();
            dr2.Dispose();
            foreach (DTO_DuyetLich l in dslichnv1)
            {
                MoKetNoi();
                SqlCommand cmd = new SqlCommand("Update LICH SET DUYET = '0' where MaLich = @mali", con);
                cmd.Parameters.AddWithValue("@NgBatDau", NgBatDau);
                cmd.Parameters.AddWithValue("@MaNV", MaNV);
                cmd.Parameters.AddWithValue("@mali", l.malich);
                cmd.ExecuteNonQuery();
                DongKetNoi();
            }
            DongKetNoi();
            MoKetNoi();
            List<DTO_DuyetLich> dslichnv = new List<DTO_DuyetLich>();
            SqlCommand cmd1 = new SqlCommand("select L.MaLich,L.NgayBatDau,L.CA,L.THU,L.DUYET,NVL.MaNV from NV_LICH NVL, LICH L where L.NgayBatDau = @NgBatDau and NVL.MaNV = @MaNV and NVL.MALICH = L.MALICH and L.DUYET = '0'", con);
            cmd1.Parameters.AddWithValue("@NgBatDau", NgBatDau);
            cmd1.Parameters.AddWithValue("@MaNV", MaNV);
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                int malich = dr.GetInt32(0);
                string ngbatdau = dr.GetDateTime(1).ToShortDateString();
                int ca = dr.GetInt32(2);
                int thu = dr.GetInt32(3);
                int duyet = dr.GetInt32(4);
                string manv = dr.GetString(5);
                DTO_DuyetLich lichnv = new DTO_DuyetLich(malich, ca, thu, ngbatdau, duyet, manv);

                dslichnv.Add(lichnv);
            }
            dr.Close();
            dr.Dispose();
            foreach (DTO_DuyetLich l in dslichnv)
            {
                MoKetNoi();
                SqlCommand cmd = new SqlCommand("Update LICH SET DUYET = '1' where MaLich = @mal", con);
                cmd.Parameters.AddWithValue("@NgBatDau", NgBatDau);
                cmd.Parameters.AddWithValue("@MaNV", MaNV);
                cmd.Parameters.AddWithValue("@mal", l.malich);
                cmd.ExecuteNonQuery();
                DongKetNoi();
            }
            DongKetNoi();
        }
    }
}
