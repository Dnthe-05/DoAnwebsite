using DAL_Website;
using DTO_Website;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BLL_Website
{
    public class QL_NhapHangBLL
    {
        QL_NhapHangDAL nhapHangDAL = new QL_NhapHangDAL();


        public List<QL_NhapHangDTO> LayDanhSachNhapHang()
        {
            return nhapHangDAL.LayDanhSachNhapHang();
        }
        public bool ThemNhapHang(QL_NhapHangDTO nhapHang)
        {
            return nhapHangDAL.ThemNhapHang(nhapHang);
        }
        public bool CapNhatNhapHang(QL_NhapHangDTO nhapHang)
        {
            return nhapHangDAL.CapNhatNhapHang(nhapHang);
        }

    }
}
