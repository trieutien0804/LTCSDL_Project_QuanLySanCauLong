using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
        QLSCLEntities1 db;

        public DAL_SAN()
        {
            db = new QLSCLEntities1();
        }

        public dynamic getSAN() 
        {
            var dsSAN = db.SAN.Select(s => new { s.MaSan, s.TenSan }).ToList();
            return dsSAN;
        }
        public List<string> getTenSan()
        {   
            List<string> dsTenSan = db.SAN.ToList().Select(s => s.TenSan).ToList();
            return dsTenSan;
        }

        public dynamic getSanDat(int maCA, string ngayDat)
        {
            var dsSAN = db.SAN.Select(s => new { s.MaSan, s.TenSan }).ToList();

            var dsSanDat = from s in db.SAN.ToList()
                           join c in db.CATHUE.ToList() on s.MaSan equals c.MaSan
                           join ca in db.CA.ToList() on c.MaCa equals ca.MaCa
                           join ttc in db.TINHTRANGSAN.ToList() on c.MaCaThue equals ttc.MaCaThue
                           where c.MaCa == maCA && ca.MaCa == maCA && ttc.Ngay == ngayDat
                           select s.MaSan;

            var dsSanChuaDat = dsSAN.Where(s => !dsSanDat.Contains(s.MaSan)).ToList();

            return dsSanChuaDat;
        }
        public int findMaSanByTenSan(string tenSan)
        {
            SAN san = db.SAN.Where(s => s.TenSan == tenSan).FirstOrDefault();
            return san.MaSan;
        }

        public bool addSAN(string tenSan)
        {
            var san = new SAN()
            {
                MaSan = 1,
                TenSan = tenSan
            };
            db.SAN.Add(san);
            db.SaveChanges();
            return true;
        }

        public bool removeSAN(int maSan)
        {
            SAN san = db.SAN.Where(s => s.MaSan == maSan).FirstOrDefault();
            db.SAN.Remove(san);
            db.SaveChanges();
            return true;
        }
        public bool editSAN(int curMASAN, SAN san)
        {
            SAN s = db.SAN.Find(curMASAN);
            s.TenSan = san.TenSan;
            db.SaveChanges();
            return true;
        }
    }   

    
}
