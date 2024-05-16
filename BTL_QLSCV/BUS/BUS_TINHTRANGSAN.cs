using BTL_QLSCV.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLSCV.BUS
{
    class BUS_TINHTRANGSAN
    {
        DAL_TINHTRANGSAN dal_TINHTRANGSAN;
        public BUS_TINHTRANGSAN()
        {
            dal_TINHTRANGSAN = new DAL_TINHTRANGSAN();
        }
        public bool addTINHTRANGSAN(string ngay, string tinhTrang, int maCaThue)
        {
            return dal_TINHTRANGSAN.addTINHTRANGSAN(ngay, tinhTrang, maCaThue);
        }
    }
}
