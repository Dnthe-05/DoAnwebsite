using DAL_Website;
using DTO_Website;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Website
{
 
    public class QL_NhaCungCapBLL
     {
        private NhaCungCapDAL dal = new NhaCungCapDAL();

        public List<QL_NhaCungCapDTO> LayDanhSachNCC()
        {
            return dal.LayDanhSachNCC();
        }
        public bool ThemNhaCungCap(QL_NhaCungCapDTO sp)
        {
            return NhaCungCapDAL.ThemNhaCungCap(sp);  
        }
        public bool IsMaNCCExist(int maNCC)
        {
            return dal.IsMaNCCExist(maNCC);
        }
        public bool CapNhatNhaCungCap(QL_NhaCungCapDTO nhaCungCap)
        {
            return NhaCungCapDAL.CapNhatNhaCungCap(nhaCungCap);
        }

        public bool XoaNhaCungCap(QL_NhaCungCapDTO sp)
        {
            return NhaCungCapDAL.XoaNhaCungCap(sp);
        }
        public List<QL_NhaCungCapDTO> TimKiemNhaCungCap(string kieuTimKiem, string giaTri)
        {
            return NhaCungCapDAL.TimKiemNhaCungCap(kieuTimKiem, giaTri);
        }
    }

}

