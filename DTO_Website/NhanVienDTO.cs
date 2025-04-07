using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Website
{
    public class NhanVienDTO
    {
        public int MaNV { get; set; }
        public string HoTen { get; set; } 
        public string GioiTinh { get; set; }
        public string SDT { get; set; }
        public DateTime NgayVaoLam { get; set; }
        public int Luong {  get; set; }
        public string MatKhauNV { get; set; }
        public string TRANGTHAI { get; set; }
        public string ROLE {  get; set; }
        public string TenTK { get; set; }
       
    }
}
