using BTL_QLSCV.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLSCV.BUS
{
    class BUS_CA
    {
        DAL_CA dal_CA;

        public BUS_CA()
        {
            dal_CA = new DAL_CA();
        }
        public bool addCA(string tGBD, string tGKT)
        {
            return dal_CA.addCA(tGBD, tGKT);
        }
        public bool editCA(int curMACA, CA ca)
        {
            return dal_CA.editCA(curMACA, ca);
        }
        public bool removeCA(int maCa)
        {
            return dal_CA.removeCA(maCa);
        }
        public dynamic getCA()
        {
            return dal_CA.getCA();
        }
        public dynamic getCaTime()
        {
            return dal_CA.getCaTime();
        }
        
    }
}
