using DTO_Website;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_Website
{
    public class QL_SanPhamDAL
    {
        public List<QL_SanPhamDTO> LayDanhSachSanPham()
        {
            List<QL_SanPhamDTO> list = new List<QL_SanPhamDTO>();
            string query = "SELECT * FROM SanPham";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                QL_SanPhamDTO sp = new QL_SanPhamDTO
                {
                    MaSP = int.Parse(row["MaSP"].ToString()),
                    TenSP = row["TenSP"].ToString(),
                    LoaiSP = row["LoaiSP"].ToString(),
                    GiaNhap = int.Parse(row["GiaNhap"].ToString()),
                    GiaBan = int.Parse(row["GiaBan"].ToString()),
                    SoLuong = int.Parse(row["SoLuong"].ToString()),
                    TRANGTHAISP = row["TRANGTHAISP"].ToString(),
                    NhaCungCap = int.Parse(row["NhaCungCap"].ToString()),
                    HINHANH = row["HINHANH"].ToString()
                };
                list.Add(sp);
            }
            return list;
        }
        public static bool ThemSanPham(QL_SanPhamDTO sp)
        {
            string query = @"INSERT INTO SANPHAM 
                        (MASP, TENSP, LOAISP, GIANHAP, GIABAN, SOLUONG, TRANGTHAISP, NHACUNGCAP, HINHANH)
                        VALUES 
                        (@MaSP, @TenSP, @LoaiSP, @GiaNhap, @GiaBan, @SoLuong, @TrangThai, @NCC, @HinhAnh)";

            SqlParameter[] param = new SqlParameter[]
            {
            new SqlParameter("@MaSP", sp.MaSP),
            new SqlParameter("@TenSP", sp.TenSP),
            new SqlParameter("@LoaiSP", sp.LoaiSP),
            new SqlParameter("@GiaNhap", sp.GiaNhap),
            new SqlParameter("@GiaBan", sp.GiaBan),
            new SqlParameter("@SoLuong", sp.SoLuong),
            new SqlParameter("@TrangThai", sp.TRANGTHAISP),
            new SqlParameter("@NCC", sp.NhaCungCap),
            new SqlParameter("@HinhAnh", sp.HINHANH),
            };

            return DatabaseHelper.ExecuteNonQuery(query, param) > 0;
        }
        public bool SuaSanPham(QL_SanPhamDTO sp)
        {
            string query = @"UPDATE SANPHAM 
                     SET TENSP = @TenSP, LOAISP = @LoaiSP, GIANHAP = @GiaNhap, 
                         GIABAN = @GiaBan, SOLUONG = @SoLuong, TRANGTHAISP = @TrangThai,
                         NHACUNGCAP = @NCC, HINHANH = @HinhAnh
                     WHERE MASP = @MaSP";

            SqlParameter[] param = new SqlParameter[]
            {
        new SqlParameter("@MaSP", sp.MaSP),
        new SqlParameter("@TenSP", sp.TenSP),
        new SqlParameter("@LoaiSP", sp.LoaiSP),
        new SqlParameter("@GiaNhap", sp.GiaNhap),
        new SqlParameter("@GiaBan", sp.GiaBan),
        new SqlParameter("@SoLuong", sp.SoLuong),
        new SqlParameter("@TrangThai", sp.TRANGTHAISP),
        new SqlParameter("@NCC", sp.NhaCungCap),
        new SqlParameter("@HinhAnh", sp.HINHANH),
            };

            return DatabaseHelper.ExecuteNonQuery(query, param) > 0;
        }
        public bool XoaSanPham(int maSP)
        {
            string query = "DELETE FROM SanPham WHERE MaSP = @MaSP";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaSP", maSP)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }


    }

}
