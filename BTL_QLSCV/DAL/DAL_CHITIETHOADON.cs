using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLSCV.DAL
{
    class DAL_CHITIETHOADON
    {
        QLSCLEntities2 db;

        public DAL_CHITIETHOADON()
        {
            db = new QLSCLEntities2();
        }

        public bool addCHITIETHOADON(int maHD, int maCaThue) 
        {
            var chitietdatsan = new CHITIETHOADON()
            {
                MaHD = maHD,
                MaCaThue = maCaThue
            };
            db.CHITIETHOADONs.Add(chitietdatsan);
            db.SaveChanges();
            return true;
        }

        public bool addThoiGianThanhToan(int maChiTietHoaDon, string ngay)
        {
            CHITIETHOADON s = db.CHITIETHOADONs.Find(maChiTietHoaDon);
            s.ThoiGianThanhToan = "8 - 10 - 2024 7:00:00";
            db.SaveChanges();
            return true;
        }
    }
}
