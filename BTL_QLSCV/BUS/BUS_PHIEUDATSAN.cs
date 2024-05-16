using BTL_QLSCV.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLSCV.BUS
{
    class BUS_PHIEUDATSAN
    {
        DAL_PHIEUDATSAN dal_PHIEUDATSAN;

        public BUS_PHIEUDATSAN()
        {
            dal_PHIEUDATSAN = new DAL_PHIEUDATSAN();
        }

        public bool addPHIEUDATSAN(int maPhieu, string ngayLap, string ngayDat, int maKH)
        {
            return dal_PHIEUDATSAN.addPHIEUDATSAN(maPhieu,ngayLap, ngayDat, maKH);
        }

        public int nextMaPHIEUDATSAN()
        {
            return dal_PHIEUDATSAN.nextMaPHIEUDATSAN();
        }
    }
}

