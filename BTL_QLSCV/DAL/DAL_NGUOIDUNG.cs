using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLSCV.DAL
{
    class DAL_NGUOIDUNG
    {
        QLSCLEntities1 db;

        public DAL_NGUOIDUNG()
        {
            db = new QLSCLEntities1();
        }

        public bool Login(string username, string password)
        {
            var user = db.NGUOIDUNG.Where(u => u.TenDangNhap == username).FirstOrDefault();

            if (user != null && user.MatKhau == password)
            {
                return true;
            }
            return false;
        }

        public dynamic getNGUOIDUNG() {

            var dsNGUOIDUNG = db.NGUOIDUNG.Select(u => u.TenDangNhap == "admin").ToList();

            return dsNGUOIDUNG;
        }
    }
}
