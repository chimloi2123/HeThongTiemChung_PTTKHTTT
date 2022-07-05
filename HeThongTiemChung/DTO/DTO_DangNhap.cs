using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DangNhap
    {
        private static string taiKhoan;

        public void setTaiKhoan(string tk)
        {
            taiKhoan = tk;
        }

        public string getTaiKhoan()
        {
            return taiKhoan;
        }
    }
}
