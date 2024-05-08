using BTL_QLSCV.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QLSCV.BUS
{
    class BUS_NGUOIDUNG
    {
        DAL_NGUOIDUNG dal_NGUOIDUNG;

        public BUS_NGUOIDUNG() {
           dal_NGUOIDUNG = new DAL_NGUOIDUNG();
        }

        public bool Login(string username, string password)
        {
            return dal_NGUOIDUNG.Login(username, password);
        }

        public dynamic getNGUOIDUNG()
        {
            return dal_NGUOIDUNG.getNGUOIDUNG();
        }
    }
}
