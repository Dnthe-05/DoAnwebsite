using DAL_Website;
using DTO_Website;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Website
{
    public class QL_KhuyenMaiBLL
    {
        private QL_KhuyenMaiDAL kmDAL = new QL_KhuyenMaiDAL();

        public List<QL_KhuyenMaiDTO> LayDanhSachKhuyenMai()
        {
            return kmDAL.LayDanhSachKhuyenMai();
        }
        public bool ThemKhuyenMai(QL_KhuyenMaiDTO km)
        {
            return kmDAL.ThemKhuyenMai(km);
        }

        public bool CapNhatKhuyenMai(QL_KhuyenMaiDTO km)
        {
            return kmDAL.CapNhatKhuyenMai(km);
        }
        public bool XoaKhuyenMai(QL_KhuyenMaiDTO km)
        {
            return kmDAL.XoaKhuyenMai(km);
        }
    }
}
