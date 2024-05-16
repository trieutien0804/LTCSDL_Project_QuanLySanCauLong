using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QLSCV.DAL
{
    class DAL_SAN
    {
        QLSCLEntities2 db;

        public DAL_SAN()
        {
            db = new QLSCLEntities2();
        }

        public dynamic getSAN() 
        {
            var dsSAN = db.SANs.Select(s => new { s.MaSan, s.TenSan }).ToList();
            return dsSAN;
        }
        public List<string> getTenSan()
        {   
            List<string> dsTenSan = db.SANs.ToList().Select(s => s.TenSan).ToList();
            return dsTenSan;
        }

        public dynamic getSanDat(int maCA, string ngayDat)
        {
            var dsSAN = db.SANs.Select(s => new { s.MaSan, s.TenSan }).ToList();

            var results = from c in db.CAs.ToList()
                           join ct in db.CATHUEs.ToList() on c.MaCa equals ct.MaCa
                           join s in db.SANs.ToList() on ct.MaSan equals s.MaSan
                           join ttc in db.TINHTRANGSANs.ToList() on ct.MaCaThue equals ttc.MaCaThue
                           where ct.MaCa == maCA && ( ttc.TinhTrang != "DT" || ttc.TinhTrang != "HD") && ttc.Ngay == ngayDat
                           select (s.MaSan);
            var dsSanChuaDat = dsSAN.Where(s => !results.Contains(s.MaSan)).ToList();

            return dsSanChuaDat;

        }
        public int findMaSanByTenSan(string tenSan)
        {
            SAN san = db.SANs.Where(s => s.TenSan == tenSan).FirstOrDefault();
            return san.MaSan;
        }

        public bool addSAN(string tenSan)
        {
            var san = new SAN()
            {
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
