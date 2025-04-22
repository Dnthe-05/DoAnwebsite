using DTO_Website;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Website
{
    public class QL_NhapHangDAL
    {
        public List<QL_NhapHangDTO> LayDanhSachNhapHang()
        {
            List<QL_NhapHangDTO> list = new List<QL_NhapHangDTO>();
            string query = "SELECT * FROM NHAPHANG";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);
                
            foreach (DataRow row in dt.Rows)
            {
                QL_NhapHangDTO nhapHang = new QL_NhapHangDTO
                {
                    MaNH = int.Parse(row["MANH"].ToString()),        
                    MaNCC = int.Parse(row["MANCC"].ToString()),     
                    MaSP = int.Parse(row["MASP"].ToString()),        
                    SOLUONGNHAP = int.Parse(row["SOLUONGNHAP"].ToString()),  
                    NgayNhap = DateTime.Parse(row["NGAYNHAP"].ToString()), 
                    GiaNhap = int.Parse(row["GIANHAP"].ToString())  
                };


                list.Add(nhapHang);
            }

            return list;
        }
        public bool ThemNhapHang(QL_NhapHangDTO nhapHang)
        {
            try
            {
                string query = "INSERT INTO NHAPHANG (MANH, NGAYNHAP, MANCC, MASP, SOLUONGNHAP, GIANHAP) " +
                               "VALUES (@MaNH, @NgayNhap, @MaNCC, @MaSP, @SoLuong, @GiaNhap)";


                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@MaNH", nhapHang.MaNH),
            new SqlParameter("@NgayNhap", nhapHang.NgayNhap),
            new SqlParameter("@MaNCC", nhapHang.MaNCC),
            new SqlParameter("@MaSP", nhapHang.MaSP),
            new SqlParameter("@SoLuong", nhapHang.SOLUONGNHAP),
            new SqlParameter("@GiaNhap", nhapHang.GiaNhap)
                };

                int result = DatabaseHelper.ExecuteNonQuery(query, parameters);


                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi khi thêm nhập hàng vào CSDL: " + ex.Message);
            }
        }
        public bool CapNhatNhapHang(QL_NhapHangDTO nhapHang)
        {
            try
            {
                string query = "UPDATE NHAPHANG SET NGAYNHAP = @NgayNhap, MANCC = @MaNCC, MASP = @MaSP, SOLUONGNHAP = @SoLuong, GIANHAP = @GiaNhap " +
                               "WHERE MANH = @MaNH";

                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@NgayNhap", nhapHang.NgayNhap),
            new SqlParameter("@MaNCC", nhapHang.MaNCC),
            new SqlParameter("@MaSP", nhapHang.MaSP),
            new SqlParameter("@SoLuong", nhapHang.SOLUONGNHAP),
            new SqlParameter("@GiaNhap", nhapHang.GiaNhap),
            new SqlParameter("@MaNH", nhapHang.MaNH)
                };

                int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi khi cập nhật nhập hàng: " + ex.Message);
            }
        }
        public bool CapNhatSoLuongTonKho(int maSP, int soLuongNhap)
        {
            string query = "UPDATE SANPHAM SET SOLUONG = SOLUONG + @SoLuongNhap WHERE MASP = @MaSP";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@SoLuongNhap", soLuongNhap),
        new SqlParameter("@MaSP", maSP)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }


    }
}
