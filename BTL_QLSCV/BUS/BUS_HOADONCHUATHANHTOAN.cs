using BTL_QLSCV.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLSCV.BUS
{
    class BUS_HOADONCHUATHANHTOAN
    {
        DAL_HOADONCHUATHANHTOAN dal_HOADONCHUATHANHTOAN;

        public BUS_HOADONCHUATHANHTOAN()
        {
            dal_HOADONCHUATHANHTOAN = new DAL_HOADONCHUATHANHTOAN();
        }

        public bool thanhToanHOADON() 
        {
            return dal_HOADONCHUATHANHTOAN.thanhToanHOADON(); 
        }
    }
}
