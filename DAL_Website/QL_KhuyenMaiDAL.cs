using DTO_Website;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Website
{
    public class QL_KhuyenMaiDAL
    {
        public List<QL_KhuyenMaiDTO> LayDanhSachKhuyenMai()
        {
            List<QL_KhuyenMaiDTO> list = new List<QL_KhuyenMaiDTO>();

            string query = "SELECT * FROM KHUYENMAI";

            SqlParameter[] parameters = new SqlParameter[] { };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            foreach (DataRow row in dt.Rows)
            {
                QL_KhuyenMaiDTO km = new QL_KhuyenMaiDTO
                {
                    MaKM = Convert.ToInt32(row["MaKM"]),
                    TenKM = row["TenKM"].ToString(),
                    GiamGia = Convert.ToSingle(row["GiamGia"]),
                    LOAIKM = row["LOAIKM"].ToString(),
                    NGAYBATDAU = Convert.ToDateTime(row["NGAYBATDAU"]),
                    NGAYKETTHUC = Convert.ToDateTime(row["NGAYKETTHUC"])
                };

                list.Add(km);
            }

            return list;
        }
        public bool ThemKhuyenMai(QL_KhuyenMaiDTO km)
        {
            string query = "INSERT INTO KHUYENMAI (TENKM, GIAMGIA, LOAIKM, NGAYBATDAU, NGAYKETTHUC) " +
                           "VALUES (@TenKM, @GiamGia, @LoaiKM, @NgayBD, @NgayKT)";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@TenKM", km.TenKM),
        new SqlParameter("@GiamGia", km.GiamGia),
        new SqlParameter("@LoaiKM", km.LOAIKM),
        new SqlParameter("@NgayBD", km.NGAYBATDAU),
        new SqlParameter("@NgayKT", km.NGAYKETTHUC)
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool CapNhatKhuyenMai(QL_KhuyenMaiDTO km)
        {
            string query = "UPDATE KHUYENMAI SET TENKM=@TenKM, GIAMGIA=@GiamGia, LOAIKM=@LoaiKM, " +
                           "NGAYBATDAU=@NgayBD, NGAYKETTHUC=@NgayKT WHERE MaKM=@MaKM";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@TenKM", km.TenKM),
        new SqlParameter("@GiamGia", km.GiamGia),
        new SqlParameter("@LoaiKM", km.LOAIKM),
        new SqlParameter("@NgayBD", km.NGAYBATDAU),
        new SqlParameter("@NgayKT", km.NGAYKETTHUC),
        new SqlParameter("@MaKM", km.MaKM)
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool XoaKhuyenMai(QL_KhuyenMaiDTO km)
        {
            string query = "DELETE FROM KHUYENMAI WHERE MaKM = @MaKM";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@MaKM", km.MaKM)
            };

            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return result > 0;
        }


    }
}
