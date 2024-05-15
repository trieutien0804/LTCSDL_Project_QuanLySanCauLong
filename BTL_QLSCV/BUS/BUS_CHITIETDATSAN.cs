using BTL_QLSCV.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLSCV.BUS
{
    class BUS_CHITIETDATSAN
    {
        DAL_CHITIETDATSAN dal_CHITIETDATSAN;

        public BUS_CHITIETDATSAN()
        {
            dal_CHITIETDATSAN = new DAL_CHITIETDATSAN();
        }

        public bool addCHITIETDATSAN(int maPhieu, int maCaThue, int tienCoc)
        {
            return dal_CHITIETDATSAN.addCHITIETDATSAN(maPhieu, maCaThue, tienCoc);
        }
    }
}
