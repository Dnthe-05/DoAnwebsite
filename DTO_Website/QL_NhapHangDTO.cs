using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Website
{
    public class QL_NhapHangDTO
    {
        public int MaNH {  get; set; }
        public int MaNCC { get; set; }
        public int MaSP { get; set; }   
        public int SOLUONGNHAP { get; set; }
        public DateTime NgayNhap { get; set; }
        public int GiaNhap { get; set; }
    }
}
