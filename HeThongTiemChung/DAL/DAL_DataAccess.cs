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
    public class DAL_DataAccess
    {
        public SqlConnection con = null;
        string conStr = @"Data Source=RAINBOWNICORN\SQLEXPRESS;Initial Catalog=HeThongTiemChung;Integrated Security=True;";

        public void MoKetNoi()
        {
            if(con == null)
            {
                con = new SqlConnection(conStr);
            }
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void DongKetNoi()
        {
            if(con != null && con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
