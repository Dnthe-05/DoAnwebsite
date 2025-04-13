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
    public class NhaCungCapDAL
    {
        public List<QL_NhaCungCapDTO> LayDanhSachNCC()
        {
            string query = "SELECT * FROM NHACUNGCAP";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            List<QL_NhaCungCapDTO> ds = new List<QL_NhaCungCapDTO>();

            foreach (DataRow row in dt.Rows)
            {
                QL_NhaCungCapDTO ncc = new QL_NhaCungCapDTO
                {
                    MaNCC = Convert.ToInt32(row["MaNCC"]),
                    TenNCC = row["TenNCC"].ToString(),
                    SDT = row["SDT"].ToString(),
                    DiaChi = row["DiaChi"].ToString(),
                    TRANGTHAINCC = row["TRANGTHAINCC"].ToString()
                };
                ds.Add(ncc);
            }

            return ds;
        }

        public bool IsMaNCCExist(int maNCC)
        {
            string query = "SELECT COUNT(*) FROM NHACUNGCAP WHERE MaNCC = @MaNCC";
            SqlParameter[] param = new SqlParameter[]
            {
            new SqlParameter("@MaNCC", maNCC)
            };

            int count = Convert.ToInt32(DatabaseHelper.ExecuteScalar(query, param));
            return count > 0; // Nếu count > 0 thì MaNCC đã tồn tại
        }
        public static bool ThemNhaCungCap(QL_NhaCungCapDTO nhaCungCap)
        {
            string query = @"INSERT INTO NHACUNGCAP 
                         (MaNCC, TenNCC, SDT, DiaChi, TRANGTHAINCC) 
                         VALUES 
                         (@MaNCC, @TenNCC, @SDT, @DiaChi, @TRANGTHAINCC)";

            SqlParameter[] param = new SqlParameter[]
            {
            new SqlParameter("@MaNCC", nhaCungCap.MaNCC),
            new SqlParameter("@TenNCC", nhaCungCap.TenNCC),
            new SqlParameter("@SDT", nhaCungCap.SDT),
            new SqlParameter("@DiaChi", nhaCungCap.DiaChi),
            new SqlParameter("@TRANGTHAINCC", nhaCungCap.TRANGTHAINCC)
            };

            return DatabaseHelper.ExecuteNonQuery(query, param) > 0;
        }
        public static bool CapNhatNhaCungCap(QL_NhaCungCapDTO nhaCungCap)
        {
            try
            {
                string query = @"UPDATE NHACUNGCAP 
                         SET TenNCC = @TenNCC, SDT = @SDT, DiaChi = @DiaChi, TRANGTHAINCC = @TRANGTHAINCC
                         WHERE MaNCC = @MaNCC";

                SqlParameter[] param = new SqlParameter[]
                {
            new SqlParameter("@MaNCC", nhaCungCap.MaNCC),
            new SqlParameter("@TenNCC", nhaCungCap.TenNCC),
            new SqlParameter("@SDT", nhaCungCap.SDT),
            new SqlParameter("@DiaChi", nhaCungCap.DiaChi),
            new SqlParameter("@TRANGTHAINCC", nhaCungCap.TRANGTHAINCC)
                };

                return DatabaseHelper.ExecuteNonQuery(query, param) > 0;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Vi phạm ràng buộc khóa chính hoặc unique
                {
                    throw new Exception("Mã nhà cung cấp đã tồn tại. Không thể cập nhật.");
                }
                else
                {
                    throw new Exception("Lỗi SQL: " + ex.Message);
                }
            }
        }

        public static bool XoaNhaCungCap(QL_NhaCungCapDTO ncc)
        {
            string query = "DELETE FROM NHACUNGCAP WHERE MaNCC = @MaNCC";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@MaNCC", ncc.MaNCC)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
        public static List<QL_NhaCungCapDTO> TimKiemNhaCungCap(string kieuTimKiem, string giaTri)
        {
            string query = "SELECT * FROM NHACUNGCAP WHERE ";

            if (kieuTimKiem == "MaNCC")
            {
                query += "CAST(MaNCC AS NVARCHAR) LIKE @GiaTri";
            }
            else if (kieuTimKiem == "TrangThai")
            {
                query += "TRANGTHAINCC LIKE @GiaTri";
            }

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@GiaTri", "%" + giaTri + "%")
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            List<QL_NhaCungCapDTO> ds = new List<QL_NhaCungCapDTO>();

            foreach (DataRow row in dt.Rows)
            {
                ds.Add(new QL_NhaCungCapDTO
                {
                    MaNCC = Convert.ToInt32(row["MaNCC"]),
                    TenNCC = row["TenNCC"].ToString(),
                    SDT = row["SDT"].ToString(),
                    DiaChi = row["DiaChi"].ToString(),
                    TRANGTHAINCC = row["TRANGTHAINCC"].ToString()
                });
            }

            return ds;
        }
    }

}
