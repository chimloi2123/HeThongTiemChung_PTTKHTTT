using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_Vacxin : DAL_DataAccess
    {
        public List<DTO_Vacxin> LayToanBoVacxin()
        {
            List<DTO_Vacxin> dsVacxin = new List<DTO_Vacxin>();
            MoKetNoi();
            SqlCommand cmd = new SqlCommand("Select * from VACXIN", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string ma = dr.GetString(0);
                string ten = dr.GetString(1);
                int gia = dr.GetInt32(2);
                string thongTin = dr.GetString(3);
                int sl = dr.GetInt32(2);
                DTO_Vacxin VX = new DTO_Vacxin(ma, ten, gia, thongTin, sl);

                dsVacxin.Add(VX);
            }
            DongKetNoi();
            return dsVacxin;

        }
        public List<DTO_Vacxin> LayVacxinTheoMa(string s)
        {
            List<DTO_Vacxin> dsVacxin = new List<DTO_Vacxin>();
            MoKetNoi();
            SqlCommand cmd = new SqlCommand("Select * from VACXIN where MAVX = @ma", con);
            cmd.Parameters.AddWithValue("@ma", s);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string ma = dr.GetString(0);
                string ten = dr.GetString(1);
                int gia = dr.GetInt32(2);
                string thongTin = dr.GetString(3);
                int sl = dr.GetInt32(2);
                DTO_Vacxin VX = new DTO_Vacxin(ma, ten, gia, thongTin, sl);

                dsVacxin.Add(VX);
            }
            DongKetNoi();
            return dsVacxin;
        }
    }
}
