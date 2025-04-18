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
    public class QL_BaoHanhDAL
    {
        public List<QL_BaoHanhDTO> LayDanhSachBaoHanh()
        {
            List<QL_BaoHanhDTO> list = new List<QL_BaoHanhDTO>();
            string query = "SELECT * FROM BAOHANH";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                QL_BaoHanhDTO bh = new QL_BaoHanhDTO
                {
                    MaBH = int.Parse(row["MaBH"].ToString()),
                    MaSP = int.Parse(row["MaSP"].ToString()),
                    ThoiGian = int.Parse(row["ThoiGian"].ToString()),
                    DIEUKIEN = row["DIEUKIEN"].ToString(),
                    NGAYBATDAU = DateTime.Parse(row["NGAYBATDAU"].ToString()),
                    NGAYHETHAN = DateTime.Parse(row["NGAYHETHAN"].ToString())
                };

                list.Add(bh);
            }

            return list;
        }
        public bool ThemBaoHanh(QL_BaoHanhDTO bh)
        {
            string query = "INSERT INTO BAOHANH (MaSP, ThoiGian, DIEUKIEN, NGAYBATDAU, NGAYHETHAN) " +
                           "VALUES (@MaSP, @ThoiGian, @DIEUKIEN, @NgayBD, @NgayKT)";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@MaSP", bh.MaSP),
        new SqlParameter("@ThoiGian", bh.ThoiGian),
        new SqlParameter("@DIEUKIEN", bh.DIEUKIEN),
        new SqlParameter("@NgayBD", bh.NGAYBATDAU),
        new SqlParameter("@NgayKT", bh.NGAYHETHAN)
            };

            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return result > 0;
        }


        public bool CapNhatBaoHanh(QL_BaoHanhDTO bh)
        {
            string query = "UPDATE BAOHANH SET MaSP=@MaSP, ThoiGian=@ThoiGian, DIEUKIEN=@DIEUKIEN, " +
                           "NGAYBATDAU=@NgayBD, NGAYHETHAN=@NgayKT WHERE MaBH=@MaBH";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaSP", bh.MaSP),
                new SqlParameter("@ThoiGian", bh.ThoiGian),
                new SqlParameter("@DIEUKIEN", bh.DIEUKIEN),
                new SqlParameter("@NgayBD", bh.NGAYBATDAU),
                new SqlParameter("@NgayKT", bh.NGAYHETHAN),
                new SqlParameter("@MaBH", bh.MaBH)
            };

            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
    }
}
