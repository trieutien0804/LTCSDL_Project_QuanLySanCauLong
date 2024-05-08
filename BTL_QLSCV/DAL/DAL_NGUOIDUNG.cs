using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLSCV.DAL
{
    class DAL_NGUOIDUNG
    {
        QLSCLEntities db;

        public DAL_NGUOIDUNG()
        {
            db = new QLSCLEntities();
        }

        public bool Login(string username, string password)
        {
            var user = db.NGUOIDUNGs.Where(u => u.TenDangNhap == username).FirstOrDefault();

            if (user != null && user.MatKhau == password)
            {
                return true;
            }
            return false;
        }
    }
}
