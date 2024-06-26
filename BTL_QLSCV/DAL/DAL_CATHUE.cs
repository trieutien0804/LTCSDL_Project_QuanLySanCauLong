﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLSCV.DAL
{
    class DAL_CATHUE
    {
        QLSCLEntities4 db;
        public DAL_CATHUE()
        {
            db = new QLSCLEntities4();
        }
        public dynamic getCaThue()
        {

            var dsCaThue = db.CATHUEs.Select(s => new { s.MaCaThue, s.Gia, s.MaSan, s.MaCa }).ToList();
            var dsSAN = db.SANs.Select(s => new { s.MaSan, s.TenSan }).ToList();
            var dsCA = db.CAs.Select(s => new { s.MaCa, s.ThoiGianBD, s.ThoiGianKT }).ToList();
            var joinedData = from caThue in dsCaThue
                             join san in dsSAN on caThue.MaSan equals san.MaSan
                             join ca in dsCA on caThue.MaCa equals ca.MaCa
                             select new
                             {
                                 caThue.MaCaThue,
                                 caThue.Gia,
                                 san.TenSan,
                                 ca.ThoiGianBD,
                                 ca.ThoiGianKT
                             };

            return joinedData.ToList();

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
        public bool removeCaThue(int maCaThue)
        {
            CATHUE cathue = db.CATHUEs.Where(s => s.MaCaThue == maCaThue).FirstOrDefault();
            db.CATHUEs.Remove(cathue);
            db.SaveChanges();
            return true;
        }
        public bool editCaThue(int curCATHUE, CATHUE cathue)
        {
            CATHUE c = db.CATHUEs.Find(curCATHUE);
            c.Gia = cathue.Gia;
            c.MaSan = cathue.MaSan;
            c.MaCa = cathue.MaCa;
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
