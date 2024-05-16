using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLSCV.DAL
{
    class DAL_CA
    {
        QLSCLEntities4 db;

        public DAL_CA()
        {
            db = new QLSCLEntities4();
        }

        public dynamic getCA()
        {
            var dsCA = db.CAs.Select(s => new {s.MaCa, s.ThoiGianBD, s.ThoiGianKT}).ToList();
            return dsCA;
        }

        public dynamic getCaTime()
        {
            //list string
            var dsCA = db.CAs.Select(s => new { s.ThoiGianBD, s.ThoiGianKT}).ToList();
            return dsCA;
        }
        public dynamic findMaCa()
        {
            var dsCA = db.CAs.Select(s => new { s.MaCa}).ToList();
            return dsCA;
        }

        public bool addCA(string tGBD, string tGKT)
        {
            var ca = new CA()
            {
                ThoiGianBD = tGBD,
                ThoiGianKT = tGKT 
            };
            db.CAs.Add(ca);
               db.SaveChanges();
            return true;
        }
        public bool removeCA(int maCa)
        {
            CA ca = db.CAs.Where(c => c.MaCa == maCa).FirstOrDefault();
            db.CAs.Remove(ca);
            db.SaveChanges();
            return true;
        }
        public bool editCA(int curMACA, CA ca)
        {
            CA c = db.CAs.Find(curMACA);
            c.ThoiGianBD = ca.ThoiGianBD;
            c.ThoiGianKT = ca.ThoiGianKT;
            db.SaveChanges();
            return true;
        }
        
    }
}
