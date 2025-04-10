using DTO_Website;
using System.Collections.Generic;
using System.Data;
using DAL_Website;
using System.Data.SqlClient;

namespace DAL_Website
{
    public class KhachHangDAL
    {
        public List<QuanLy_KhachHangDTO> LayDanhSachKhachHang()
        {
            List<QuanLy_KhachHangDTO> list = new List<QuanLy_KhachHangDTO>();
            string query = "SELECT * FROM KhachHang";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                QuanLy_KhachHangDTO kh = new QuanLy_KhachHangDTO
                {
                    MaKH = int.Parse(row["MaKH"].ToString()),
                    TenKH = row["TenKH"].ToString(),
                    GioiTinh = row["GioiTinh"].ToString(),
                    Sdt = row["Sdt"].ToString(),
                    DiaChi = row["DiaChi"].ToString(),
                    MatKhaukh = row["MatKhauKH"].ToString(),
                    TRANGTHAI = row["TRANGTHAI"].ToString(),
                    ROLE = row["ROLE"].ToString()
                };
                list.Add(kh);
            }

            return list;
        }

        public bool ThemKhachHang(QuanLy_KhachHangDTO kh)
        {
            string query = @"INSERT INTO KhachHang (MaKH, TenKH, GioiTinh, Sdt, DiaChi, MatKhaukh, TRANGTHAI, ROLE)
                 VALUES (@MaKH, @TenKH, @GioiTinh, @Sdt, @DiaChi, @MatKhaukh, @TrangThai, @Role)";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@MaKH", kh.MaKH),
        new SqlParameter("@TenKH", kh.TenKH),
        new SqlParameter("@GioiTinh", kh.GioiTinh),
        new SqlParameter("@Sdt", kh.Sdt),
        new SqlParameter("@DiaChi", kh.DiaChi),
        new SqlParameter("@MatKhauKH", kh.MatKhaukh),
        new SqlParameter("@TrangThai", kh.TRANGTHAI),
        new SqlParameter("@Role", kh.ROLE),
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool SuaKhachHang(QuanLy_KhachHangDTO kh)
        {
            string query = @"UPDATE KhachHang 
                     SET TenKH = @TenKH, GioiTinh = @GioiTinh, Sdt = @Sdt, 
                         DiaChi = @DiaChi, MatKhaukh = @MatKhaukh, TRANGTHAI = @TrangThai, ROLE = @Role 
                     WHERE MaKH = @MaKH";

            SqlParameter[] parameters =
            {
        new SqlParameter("@MaKH", kh.MaKH),
        new SqlParameter("@TenKH", kh.TenKH),
        new SqlParameter("@GioiTinh", kh.GioiTinh),
        new SqlParameter("@Sdt", kh.Sdt),
        new SqlParameter("@DiaChi", kh.DiaChi),
        new SqlParameter("@MatKhaukh", kh.MatKhaukh),
        new SqlParameter("@TrangThai", kh.TRANGTHAI),
        new SqlParameter("@Role", kh.ROLE)
    };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
        public bool XoaKhachHang(int maKH)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM KhachHang WHERE MaKH = @MaKH";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaKH", maKH);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
