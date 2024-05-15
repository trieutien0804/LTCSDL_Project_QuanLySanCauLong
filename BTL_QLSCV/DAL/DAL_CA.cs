using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLSCV.DAL
{
    class DAL_CA
    {
        QLSCLEntities1 db;

        public DAL_CA()
        {
            db = new QLSCLEntities1();
        }

        public dynamic getCA()
        {
            var dsCA = db.CA.Select(s => new {s.MaCa, s.ThoiGianBD, s.ThoiGianKT}).ToList();
            return dsCA;
        }

        public dynamic getCaTime()
        {
            //list string
            var dsCA = db.CA.Select(s => new { s.ThoiGianBD, s.ThoiGianKT}).ToList();
            return dsCA;
        }
        public dynamic findMaCa()
        {
            var dsCA = db.CA.Select(s => new { s.MaCa}).ToList();
            return dsCA;
        }

        public bool addCA(string tGBD, string tGKT)
        {
            var ca = new CA()
            {
                ThoiGianBD = tGBD,
                ThoiGianKT = tGKT 
            };
            db.CA.Add(ca);
            db.SaveChanges();
            return true;
        }
        public bool removeCA(int maCa)
        {
            CA ca = db.CA.Where(c => c.MaCa == maCa).FirstOrDefault();
            db.CA.Remove(ca);
            db.SaveChanges();
            return true;
        }
        public bool editCA(int curMACA, CA ca)
        {
            CA c = db.CA.Find(curMACA);
            c.ThoiGianBD = ca.ThoiGianBD;
            c.ThoiGianKT = ca.ThoiGianKT;
            db.SaveChanges();
            return true;
        }
    }
}
