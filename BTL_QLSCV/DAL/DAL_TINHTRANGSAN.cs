﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLSCV.DAL
{
    class DAL_TINHTRANGSAN
    {
        QLSCLEntities2 db;

        public DAL_TINHTRANGSAN()
        {
            db = new QLSCLEntities2();
        }

        public bool addTINHTRANGSAN(string ngay, string tinhTrang, int maCaThue)
        {
            var tinhTrangSan = new TINHTRANGSAN()
            {
                Ngay = ngay,
                TinhTrang = tinhTrang,
                MaCaThue = maCaThue
            };
            db.TINHTRANGSANs.Add(tinhTrangSan);
            db.SaveChanges();
            return true;
        }

        public bool toSanDangHoatDong(int maTinhTrang)
        {
            TINHTRANGSAN tts = db.TINHTRANGSANs.Find(maTinhTrang);
            tts.TinhTrang = "HD";
            db.SaveChanges();
            return true;
        }
    }
}
