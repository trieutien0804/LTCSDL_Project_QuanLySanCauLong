using BTL_QLSCV.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLSCV.BUS
{
    class BUS_HOADON
    {
        DAL_HOADON dal_HOADON;

        public BUS_HOADON()
        {
            dal_HOADON = new DAL_HOADON();
        }   

        public int addHOADON(string tenKH, int tongTien, int maPhieu)
        {
            string today = DateTime.Now.ToString("dd-MM-yyyy");
            return dal_HOADON.addHOADON(today, tenKH, tongTien, maPhieu);
        }

        public dynamic getHOADON() { 
            return dal_HOADON.getHOADON();
        }
    }
}
