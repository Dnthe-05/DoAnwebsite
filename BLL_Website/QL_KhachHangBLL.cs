using DAL_Website;
using DTO_Website;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Website
{
    public class KhachHangBLL
    {
        private KhachHangDAL dal = new KhachHangDAL();  

   
        public List<QuanLy_KhachHangDTO> LayDanhSachKhachHang()
        {
            return dal.LayDanhSachKhachHang();  
        }
        public bool ThemKhachHang(QuanLy_KhachHangDTO kh)
        {
            KhachHangDAL dal = new KhachHangDAL();
            return dal.ThemKhachHang(kh);
        }
        public bool SuaKhachHang(QuanLy_KhachHangDTO kh)
        {
            return dal.SuaKhachHang(kh);
        }
        public bool XoaKhachHang(int maKH)
        {
            return dal.XoaKhachHang(maKH);
        }

    }
}
