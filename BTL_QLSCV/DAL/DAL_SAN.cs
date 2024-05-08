using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QLSCV.DAL
{
    class DAL_SAN
    {
        QLSCLEntities db;

        public DAL_SAN()
        {
            db = new QLSCLEntities();
        }

        public dynamic getSAN() 
        {
            var dsSAN = db.SANs.ToList();

            return dsSAN;
        }

        public bool addSAN(int maSan, string tenSan)
        {
            var san = new SAN()
            {
                MaSan = maSan,
                Vitri = tenSan
            };
            db.SANs.Add(san);
            db.SaveChanges();
            return true;
        }

        public bool removeSAN(int maSan)
        {
            SAN san = db.SANs.Where(s => s.MaSan == maSan).FirstOrDefault();
            db.SANs.Remove(san);
            db.SaveChanges();
            return true;
        }
        public bool editSAN(int curMASAN, SAN san)
        {
            SAN s = db.SANs.Find(curMASAN);
            s.Vitri = san.Vitri;
            db.SaveChanges();
            return true;
        }
    }

    
}
