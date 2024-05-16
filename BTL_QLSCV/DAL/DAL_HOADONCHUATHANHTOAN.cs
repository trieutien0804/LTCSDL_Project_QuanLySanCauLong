using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLSCV.DAL
{
    class DAL_HOADONCHUATHANHTOAN
    {
        QLSCLEntities4 db;

        public DAL_HOADONCHUATHANHTOAN()
        {
            db = new QLSCLEntities4();
        }

        public bool thanhToanHOADON() { return true; }
    }
}
