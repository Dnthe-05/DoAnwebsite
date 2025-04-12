using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Website
{
    public class TaiKhoanDAL
    {
        public string Login(string tenTK, string matKhau)
        {
            string query = "SELECT ROLE FROM NHANVIEN WHERE TENTK = @tenTK AND MATKHAUNV = @matKhau";

            SqlParameter[] parameters = {
            new SqlParameter("@tenTK", tenTK),
            new SqlParameter("@matKhau", matKhau)
        };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["ROLE"].ToString();  
            }

            return null;
        }
    }

}
