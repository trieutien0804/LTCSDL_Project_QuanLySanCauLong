using BTL_QLSCV.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLSCV.BUS
{
    class BUS_SAN
    {
        DAL_SAN dal_SAN;

        public BUS_SAN()
        {
            dal_SAN = new DAL_SAN();
        }

        public dynamic getSAN()
        {
            return dal_SAN.getSAN();
        }

        public dynamic getSanDat(int maCA, string ngayDat)
        {
            return dal_SAN.getSanDat(maCA, ngayDat);
        }

        public bool addSAN(int maSan, string tenSan)
        {
            return dal_SAN.addSAN(maSan, tenSan);
        }

        public bool removeSAN(int maSan)
        {
            return dal_SAN.removeSAN(maSan);
        }

        public bool editSAN(int curMASAN, SAN san)
        {
            return dal_SAN.editSAN(curMASAN, san);
        }
    }
}
