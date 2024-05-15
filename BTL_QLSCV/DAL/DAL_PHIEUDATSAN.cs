using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace BTL_QLSCV.DAL
    {
        class DAL_PHIEUDATSAN
        {
            QLSCLEntities1 db;
            public DAL_PHIEUDATSAN()
            {
                db = new QLSCLEntities1();
            }
            public bool addPHIEUDATSAN(string ngayLap, string ngayDat, int maKH)
            {
                var phieudatsan = new PHIEUDATSAN()
                {
                    NgayLap = ngayLap,
                    NgayDat = ngayDat,
                    MaKH = maKH
                };
                db.PHIEUDATSAN.Add(phieudatsan);
                db.SaveChanges();
                return true;
            }
        }
}
