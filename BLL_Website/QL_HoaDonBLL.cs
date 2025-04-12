using DAL_Website;
using DTO_Website;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Website
{
    public class QL_HoaDonBLL
    {
        private QL_HoaDonDAL dal = new QL_HoaDonDAL();

        public List<QL_HoaDonDTO> LayDanhSachHoaDon()
        {
            return dal.GetAllHoaDon();
        }

        public bool ThemHoaDon(QL_HoaDonDTO hd)
        {
            return QL_HoaDonDAL.ThemHoaDon(hd);
        }

        public bool XoaHoaDon(int maHD)
        {
            return dal.XoaHoaDon(maHD);
        }

        public bool SuaHoaDon(QL_HoaDonDTO hd)
        {
            return dal.SuaHoaDon(hd);
        }
        public List<QL_HoaDonDTO> TimKiemHoaDon(string tieuChi, string tuKhoa)
        {
            var danhSach = dal.GetAllHoaDon(); 
            tuKhoa = tuKhoa.ToLower().Trim();

            if (tieuChi == "Mã Hóa Đơn")
                return danhSach.Where(hd => hd.MaHD.ToString().ToLower().Contains(tuKhoa)).ToList();

            if (tieuChi == "Mã Khách Hàng")
                return danhSach.Where(hd => hd.MaKH.ToString().ToLower().Contains(tuKhoa)).ToList();

            if (tieuChi == "Mã Nhân Viên")
                return danhSach.Where(hd => hd.MaNV.ToString().ToLower().Contains(tuKhoa)).ToList();

            return danhSach;
        }
    }
}
