using BTL_QLSCV.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLSCV.BUS
{
    class BUS_SANDADAT
    {
        DAL_SANDADAT dal_SANDADAT;

        public BUS_SANDADAT()
        {
            dal_SANDADAT = new DAL_SANDADAT();
        }

        public dynamic getSanDatTrongNgay()
        {
            string today = DateTime.Now.ToString("dd-MM-yyyy");
            return dal_SANDADAT.getSanDatTrongNgay("DT" ,today);
        }
        public dynamic getSanDangHDTrongNgay()
        {
            string today = DateTime.Now.ToString("dd-MM-yyyy");
            return dal_SANDADAT.getSanDangHDTrongNgay(today);
        }

    }
}
