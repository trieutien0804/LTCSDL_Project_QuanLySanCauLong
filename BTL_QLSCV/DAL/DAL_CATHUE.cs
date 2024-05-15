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
        QLSCLEntities1 db;
        public DAL_CATHUE()
        {
            db = new QLSCLEntities1();
        }
        public dynamic getCaThue()
        {
            var dsCaThue = db.CATHUE.Select(s => new { s.MaCaThue, s.Gia, s.MaSan, s.MaCa }).ToList();
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
            db.CATHUE.Add(caThue);
            db.SaveChanges();
            return true;  
        }

        public bool ktCaThue(int maSan, int maCa)
        {

            var dsCaDaDat = from s in db.CATHUE.ToList()
                           where s.MaSan == maSan && s.MaCa == maCa
                           select s.MaSan;
            bool isDsCaDaDatEmpty = dsCaDaDat.Count() == 0;
            return isDsCaDaDatEmpty;
        }
    }
}
