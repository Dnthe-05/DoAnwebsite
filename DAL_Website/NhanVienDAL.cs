using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using DTO_Website;
using System.Data.Common;
namespace DAL_Website
{
    public class NHANVIENDAL
    {
        public List<NhanVienDTO> GetAllEmployees()
        {
            List<NhanVienDTO> nhanVienList = new List<NhanVienDTO>();

            string query = "SELECT MANV, HOTENNV FROM NHANVIEN";

            using (SqlConnection conn = DatabaseHelper.GetConnection()) 
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    NhanVienDTO nhanVien = new NhanVienDTO
                    {
                        MaNV = reader.GetInt32(0),
                        HoTen = reader.GetString(1)
                    };
                    nhanVienList.Add(nhanVien);
                }
            }
            return nhanVienList;
        }


        public DataTable GetEmployeeData()
        {
            string query = "SELECT * FROM NHANVIEN";
            DataTable dt = new DataTable();

            using (SqlConnection conn = DatabaseHelper.GetConnection()) 
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        // Phương thức lấy danh sách trạng thái
        public List<string> GetTrangThaiList()
        {
            List<string> trangThaiList = new List<string>();
            string query = "SELECT DISTINCT TRANGTHAI FROM NHANVIEN"; 

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    trangThaiList.Add(reader.GetString(0)); 
                }
            }
            return trangThaiList;
        }


        public List<string> GetRoleList()
        {
            List<string> roleList = new List<string>();
            string query = "SELECT DISTINCT ROLE FROM NHANVIEN"; 

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    roleList.Add(reader.GetString(0));
                }
            }
            return roleList;
        }
        public bool ThemNhanVien(NhanVienDTO nv)
        {
            string query = "INSERT INTO NhanVien VALUES (@MaNV, @HoTenNV, @GioiTinh, @SDT, @NgayVaoLam, @Luong, @MatKhauNV, @TrangThai, @Role, @TenTK)";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@MaNV", nv.MaNV),
            new SqlParameter("@HoTenNV", nv.HoTen),
            new SqlParameter("@GioiTinh", nv.GioiTinh),
            new SqlParameter("@SDT", string.IsNullOrEmpty(nv.SDT) ? DBNull.Value : (object)nv.SDT),
            new SqlParameter("@NgayVaoLam", nv.NgayVaoLam),
            new SqlParameter("@Luong", nv.Luong),
            new SqlParameter("@MatKhauNV", nv.MatKhauNV),
            new SqlParameter("@TrangThai", nv.TRANGTHAI),
            new SqlParameter("@Role", nv.ROLE),
            new SqlParameter("@TenTK", nv.TenTK),
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
        public bool SuaNhanVien(NhanVienDTO nv)
        {
            string query = @"UPDATE NHANVIEN SET 
                    HOTENNV = @HoTen,
                    GIOITINH = @GioiTinh,
                    SDT = @SDT,
                    NGAYVAOLAM = @NgayVaoLam,
                    LUONG = @Luong,
                    MATKHAUNV = @MatKhauNV,
                    TRANGTHAI = @TrangThai,
                    ROLE = @Role,
                    TENTK = @TenTK
                    WHERE MANV = @MaNV";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@HoTen", nv.HoTen),
        new SqlParameter("@GioiTinh", nv.GioiTinh),
        new SqlParameter("@SDT", nv.SDT),
        new SqlParameter("@NgayVaoLam", nv.NgayVaoLam),
        new SqlParameter("@Luong", nv.Luong),
        new SqlParameter("@MatKhauNV", nv.MatKhauNV),
        new SqlParameter("@TrangThai", nv.TRANGTHAI),
        new SqlParameter("@Role", nv.ROLE),
        new SqlParameter("@TenTK", nv.TenTK),
        new SqlParameter("@MaNV", nv.MaNV),
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
        public bool XoaNhanVien(int maNV)
        {
            string query = "DELETE FROM NHANVIEN WHERE MANV = @MaNV";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaNV", maNV)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
        public bool IsNhanVienExists(int maNV, string tenTK)
        {
            string query = "SELECT COUNT(*) FROM NHANVIEN WHERE MANV = @MaNV OR TENTK = @TenTK";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@MaNV", maNV),
        new SqlParameter("@TenTK", tenTK)
            };


            int count = (int)DatabaseHelper.ExecuteScalar(query, parameters);
            return count > 0;  
        }


    }
}
