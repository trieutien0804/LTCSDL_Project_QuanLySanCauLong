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

        public bool addPHIEUDATSAN(string ngayLap, string ngayDat, int maKH)
        {
            return dal_PHIEUDATSAN.addPHIEUDATSAN(ngayLap, ngayDat, maKH);
        }
    }
}
