using DAL_Website;
using DTO_Website;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Website
{
    public class QL_SanPhamBLL
    {
        private QL_SanPhamDAL dal = new QL_SanPhamDAL();

        public List<QL_SanPhamDTO> LayDanhSachSanPham()
        {
            return dal.LayDanhSachSanPham();
        }

        public bool ThemSanPham(QL_SanPhamDTO sp)
        {
            return QL_SanPhamDAL.ThemSanPham(sp);
        }

        public bool SuaSanPham(QL_SanPhamDTO sp)
        {
            return dal.SuaSanPham(sp);
        }

        public bool XoaSanPham(int maSP)
        {
            return dal.XoaSanPham(maSP);
        }
    }
}
