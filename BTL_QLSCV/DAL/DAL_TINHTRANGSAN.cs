using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLSCV.DAL
{
    class DAL_TINHTRANGSAN
    {
        QLSCLEntities3 db;

        public DAL_TINHTRANGSAN()
        {
            db = new QLSCLEntities3();
        }

        public bool addTINHTRANGSAN(string ngay, string tinhTrang, int maCaThue)
        {
            var tinhTrangSan = new TINHTRANGSAN()
            {
                Ngay = ngay,
                TinhTrang = tinhTrang,
                MaCaThue = maCaThue
            };
            db.TINHTRANGSAN.Add(tinhTrangSan);
            db.SaveChanges();
            return true;
        }
    }
}
