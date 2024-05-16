using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLSCV.DAL
{
    class DAL_PHIEUDATSAN
    {
        QLSCLEntities2 db;
        public DAL_PHIEUDATSAN()
        {
            db = new QLSCLEntities2();
        }
        public int addPHIEUDATSAN(int maPhieu, string ngayLap, string ngayDat, int maKH)
        {
            var phieudatsan = new PHIEUDATSAN()
            {
                MaPhieu = maPhieu,
                NgayLap = ngayLap,
                NgayDat = ngayDat,
                MaKH = maKH
            };
            db.PHIEUDATSANs.Add(phieudatsan);
            db.SaveChanges();
            return maPhieu;
        }

        public dynamic getPHIEUDATSAN() 
        {

            var dsPHIEUDATSAN = db.PHIEUDATSANs.Select(s => new {
                s.MaPhieu,
                s.MaKH,
                s.NgayLap,
                s.NgayDat
            }).ToList();

            return dsPHIEUDATSAN;
        }

        public int nextMaPHIEUDATSAN()
        {
            var maxId = db.PHIEUDATSANs.Max(x => (int?)x.MaPhieu) ?? 0;
            var nextId = maxId + 1;
            return nextId;
        }

    }
}
