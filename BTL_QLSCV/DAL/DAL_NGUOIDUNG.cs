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
        QLSCLEntities2 db;

        public DAL_NGUOIDUNG()
        {
            db = new QLSCLEntities2();
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

        public dynamic getNGUOIDUNG() {

            var dsNGUOIDUNG = db.NGUOIDUNGs.Select(u => u.TenDangNhap == "admin").ToList();

            return dsNGUOIDUNG;
        }
    }
}
