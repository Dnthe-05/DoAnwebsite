using DAL_Website;
using DTO_Website;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Website
{
    public class QL_BaoHanhBLL
    {
        QL_BaoHanhDAL dal = new QL_BaoHanhDAL();

        public List<QL_BaoHanhDTO> LayDanhSachBaoHanh()
        {
            return dal.LayDanhSachBaoHanh();
        }

        public bool ThemBaoHanh(QL_BaoHanhDTO bh)
        {
            return dal.ThemBaoHanh(bh);
        }

        public bool CapNhatBaoHanh(QL_BaoHanhDTO bh)
        {
            return dal.CapNhatBaoHanh(bh);
        }
    }
}
