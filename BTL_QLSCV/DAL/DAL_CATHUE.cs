using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLSCV.DAL
{
    class DAL_CATHUE
    {
        QLSCLEntities2 db;
        public DAL_CATHUE()
        {
            db = new QLSCLEntities2();
        }
        public dynamic getCaThue()
        {
            var dsCaThue = db.CATHUEs.Select(s => new { s.MaCaThue, s.Gia, s.MaSan, s.MaCa }).ToList();
            return dsCaThue;
        }

        public bool addCaThue(int gia, int maSan, int maCa)
        {
            var caThue = new CATHUE()
            {
                Gia = gia,
                MaSan = maSan,
                MaCa = maCa
            };
            db.CATHUEs.Add(caThue);
            db.SaveChanges();
            return true;  
        }

        public bool ktCaThue(int maSan, int maCa)
        {

            var dsCaDaDat = from s in db.CATHUEs.ToList()
                           where s.MaSan == maSan && s.MaCa == maCa
                           select s.MaSan;
            bool isDsCaDaDatEmpty = dsCaDaDat.Count() == 0;
            return isDsCaDaDatEmpty;
        }

        public int getMaCaThueByCaVaSan(int maCa, int maSan)
        {
            var dsCaDaDat = from s in db.CATHUEs.ToList()
                            where s.MaSan == maSan && s.MaCa == maCa
                            select s.MaCaThue;
            List<int> a = dsCaDaDat.ToList();
            int b = a.FirstOrDefault();
            return b;
        }
        public int nextMaCATHUE()
        {
            var maxId = db.CATHUEs.Max(x => (int?)x.MaCaThue) ?? 0;
            var nextId = maxId + 1;
            return nextId;
        }
    }
}
