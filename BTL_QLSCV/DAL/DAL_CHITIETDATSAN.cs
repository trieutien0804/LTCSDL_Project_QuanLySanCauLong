using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLSCV.DAL
{
    class DAL_CHITIETDATSAN
    {
        QLSCLEntities4 db;

        public DAL_CHITIETDATSAN()
        {
            db = new QLSCLEntities4();
        }
        public dynamic getCHITIETDATSAN()
        {

            var dsCHITIETDATSAN = db.CHITIETDATSANs.Select(s => new {
                s.MaPhieu,
                s.MaCaThue,
                s.TienCoc,
             
            }).ToList();

            return dsCHITIETDATSAN;
        }
        public bool addCHITIETDATSAN(int maPhieu, int maCaThue, int tienCoc)
        {
            var chiTietDatSan = new CHITIETDATSAN()
            {
                MaPhieu = maPhieu,
                MaCaThue = maCaThue,
                TienCoc = tienCoc
            };
            db.CHITIETDATSANs.Add(chiTietDatSan);
            db.SaveChanges();
            return true;
        }
    }
}
