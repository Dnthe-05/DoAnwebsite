using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Website;
namespace BLL_Website
{
    public class TaiKhoanBLL
    {
        private TaiKhoanDAL dal = new TaiKhoanDAL();

        public string Login(string username, string password)
        {
            return dal.Login(username, password);
        }
    }
}
