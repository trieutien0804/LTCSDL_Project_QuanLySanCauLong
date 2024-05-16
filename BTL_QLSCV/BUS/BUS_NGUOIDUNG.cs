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
        public dynamic getND()
        {
            return dal_NGUOIDUNG.getND();
        }
        public bool addND(string hoTen, string username, string pass, string role)
        {
            return dal_NGUOIDUNG.addND(hoTen, username, pass, role);    
        }
        public bool editND(int maND, NGUOIDUNG user)
        {
            return dal_NGUOIDUNG.editND(maND, user);
        }
    }
}
