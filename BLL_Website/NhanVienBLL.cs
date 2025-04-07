using DAL_Website;
using System;
using System.Collections.Generic;
using System.Data;
using DTO_Website;

namespace BLL_Website
{
    public class NhanVienBLL
    {
        private NHANVIENDAL _nhanVienDAL;

        public NhanVienBLL()
        {
            _nhanVienDAL = new NHANVIENDAL(); // Khởi tạo DAL
        }

        // Lấy danh sách nhân viên
        public List<NhanVienDTO> GetEmployeeList()
        {
            return _nhanVienDAL.GetAllEmployees();
        }

        // Lấy dữ liệu nhân viên cho DataGridView
        public DataTable GetEmployeeData()
        {
            return _nhanVienDAL.GetEmployeeData();
        }

        // Lấy danh sách trạng thái
        public List<string> GetTrangThaiList()
        {
            // Giả sử bạn lấy danh sách trạng thái từ cơ sở dữ liệu
            List<string> trangThaiList = new List<string> { "Hoạt động", "Nghỉ việc" }; // Ví dụ
            return trangThaiList;
        }

        public List<string> GetRoleList()
        {
            // Giả sử bạn lấy danh sách chức vụ từ cơ sở dữ liệu
            List<string> roleList = new List<string> { "Admin", "Nhân viên", "Quản lý", "Thu Ngân" }; // Ví dụ
            return roleList;
        }

        public string ThemNhanVien(NhanVienDTO nv)
        {
            if (string.IsNullOrWhiteSpace(nv.HoTen))
                return "Họ tên không được để trống.";

            if (nv.Luong < 0)
                return "Lương phải lớn hơn 0.";

            bool ketQua = _nhanVienDAL.ThemNhanVien(nv);
            return ketQua ? "Thêm thành công!" : "Thêm thất bại.";
        }
        public string SuaNhanVien(NhanVienDTO nv)
        {
            bool kq = _nhanVienDAL.SuaNhanVien(nv);
            return kq ? "Sửa nhân viên thành công!" : "Sửa thất bại!";
        }

        public string XoaNhanVien(int maNV)
        {
            bool kq = _nhanVienDAL.XoaNhanVien(maNV);
            return kq ? "Xóa nhân viên thành công!" : "Xóa thất bại!";
        }
        public bool IsNhanVienExists(int maNV, string tenTK)
        {
            return _nhanVienDAL.IsNhanVienExists(maNV, tenTK);
        }
    }
}
