using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using DTO;


namespace DAL
{
    public class DAL_DangKiLich : DAL_DataAccess
    {     
        public void ThemLich(int ca, int thu, string ngaybatdau)
        {
            MoKetNoi();
            int malich = 0;
            SqlCommand cmd1 = new SqlCommand("select max(MALICH) from LICH", con);
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                malich = dr.GetInt32(0) + 1;
            }
            dr.Close(); 
            dr.Dispose();
            SqlCommand cmd = new SqlCommand("insert into LICH values (@ca,@thu,@ngaybatdau,1) insert into NV_LICH values(@malich, 'BS5')", con);           
            cmd.Parameters.AddWithValue("@malich", malich);
            cmd.Parameters.AddWithValue("@ca", ca);
            cmd.Parameters.AddWithValue("@thu", thu);
            cmd.Parameters.AddWithValue("@ngaybatdau", ngaybatdau);
            cmd.ExecuteNonQuery();
            DongKetNoi();
        }
    }
}
