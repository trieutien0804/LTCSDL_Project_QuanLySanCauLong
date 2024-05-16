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
        public bool addPHIEUDATSAN(int maPhieu, string ngayLap, string ngayDat, int maKH)
        {
            try
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
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }   

        public int nextMaPHIEUDATSAN()
        {
            var maxId = db.PHIEUDATSANs.Max(x => (int?)x.MaPhieu) ?? 0;
            var nextId = maxId + 1;
            return nextId;
        }

    }
}
