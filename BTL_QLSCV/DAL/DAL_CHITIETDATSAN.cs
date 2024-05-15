using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLSCV.DAL
{
    class DAL_CHITIETDATSAN
    {
        QLSCLEntities1 db;

        public DAL_CHITIETDATSAN()
        {
            db = new QLSCLEntities1();
        }

        public bool addCHITIETDATSAN(int maPhieu, int maCaThue, int tienCoc)
        {
            var chiTietDatSan = new CHITIETDATSAN()
            {
                MaPhieu = maPhieu,
                MaCaThue = maCaThue,
                TienCoc = tienCoc
            };
            db.CHITIETDATSAN.Add(chiTietDatSan);
            db.SaveChanges();
            return true;
        }
    }
}
