using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Website
{
    public class SanPhamDTO
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public int SoLuongTon { get; set; }
        public int SoLuongMua { get; set; }
        public int GiaBan { get; set; }
    }
    public class HoaDonDTO
    {
        public int MaHD { get; set; }
        public int MaKH { get; set; }
        public string TenKH { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public int MaNV { get; set; }
        public DateTime ThoiGian { get; set; }
        public List<SanPhamDTO> GioHang { get; set; }
    }
}
