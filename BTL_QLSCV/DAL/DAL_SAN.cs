using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
            var dsSAN = db.SANs.Select(s => new { s.MaSan, s.TenSan }).ToList();
            return dsSAN;
        }

        public dynamic getSanDat(int maCA, string ngayDat)
        {
            var dsSAN = db.SANs.Select(s => new { s.MaSan, s.TenSan }).ToList();

            var dsSanDat = from s in db.SANs.ToList()
                           join c in db.CATHUEs.ToList() on s.MaSan equals c.MaSan
                           join ca in db.CAs.ToList() on c.MaCa equals ca.MaCa
                           join ttc in db.TINHTRANGSANs.ToList() on c.MaCaThue equals ttc.MaCaThue
                           where c.MaCa == maCA && ca.MaCa == maCA && ttc.Ngay == ngayDat
                           select s.MaSan;

            var dsSanChuaDat = dsSAN.Where(s => !dsSanDat.Contains(s.MaSan)).ToList();

            return dsSanChuaDat;
        }

        public bool addSAN(int maSan, string tenSan)
        {
            var san = new SAN()
            {
                MaSan = maSan,
                TenSan = tenSan
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
            s.TenSan = san.TenSan;
            db.SaveChanges();
            return true;
        }
    }   

    
}
