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
    public class QL_HoaDonDAL
    {
        public List<QL_HoaDonDTO> GetAllHoaDon()
        {
            List<QL_HoaDonDTO> ds = new List<QL_HoaDonDTO>();
            string query = "SELECT * FROM HOADON";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                QL_HoaDonDTO hd = new QL_HoaDonDTO
                {
                    MaHD = Convert.ToInt32(row["MAHD"]),
                    MaNV = Convert.ToInt32(row["MANV"]),
                    MaKH = Convert.ToInt32(row["MAKH"]),
                    NgayLapHD = Convert.ToDateTime(row["NGAYLAPHD"]),
                    TongTien = Convert.ToInt32(row["TONGTIEN"]),
                    TRANGTHAIHD = row["TRANGTHAIHD"].ToString()
                };
                ds.Add(hd);
            }
            return ds;
        }
        public static bool ThemHoaDon(QL_HoaDonDTO hoaDon)
        {
            string query = @"INSERT INTO HOADON 
                         (MAHD, MANV, MAKH, NGAYLAPHD, TONGTIEN, TRANGTHAIHD)
                         VALUES 
                         (@MaHD, @MaNV, @MaKH, @NgayLapHD, @TongTien, @TrangThaiHD)";

            SqlParameter[] param = new SqlParameter[]
            {
            new SqlParameter("@MaHD", hoaDon.MaHD),
            new SqlParameter("@MaNV", hoaDon.MaNV),
            new SqlParameter("@MaKH", hoaDon.MaKH),
            new SqlParameter("@NgayLapHD", hoaDon.NgayLapHD),
            new SqlParameter("@TongTien", hoaDon.TongTien),
            new SqlParameter("@TrangThaiHD", hoaDon.TRANGTHAIHD),
            };

            return DatabaseHelper.ExecuteNonQuery(query, param) > 0;
        }

        // Sửa hóa đơn
        public bool SuaHoaDon(QL_HoaDonDTO hoaDon)
        {
            string query = @"UPDATE HOADON 
                         SET MANV = @MaNV, MAKH = @MaKH, NGAYLAPHD = @NgayLapHD, 
                             TONGTIEN = @TongTien, TRANGTHAIHD = @TrangThaiHD
                         WHERE MAHD = @MaHD";

            SqlParameter[] param = new SqlParameter[]
            {
            new SqlParameter("@MaHD", hoaDon.MaHD),
            new SqlParameter("@MaNV", hoaDon.MaNV),
            new SqlParameter("@MaKH", hoaDon.MaKH),
            new SqlParameter("@NgayLapHD", hoaDon.NgayLapHD),
            new SqlParameter("@TongTien", hoaDon.TongTien),
            new SqlParameter("@TrangThaiHD", hoaDon.TRANGTHAIHD),
            };

            return DatabaseHelper.ExecuteNonQuery(query, param) > 0;
        }

        // Xóa hóa đơn
        public bool XoaHoaDon(int maHD)
        {
            string query = "DELETE FROM HOADON WHERE MAHD = @MaHD";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@MaHD", maHD)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}
