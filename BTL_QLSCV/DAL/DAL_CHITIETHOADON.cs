using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLSCV.DAL
{
    class DAL_CHITIETHOADON
    {
        QLSCLEntities4 db;

        public DAL_CHITIETHOADON()
        {
            db = new QLSCLEntities4();
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
            s.ThoiGianThanhToan = ngay;
            db.SaveChanges();
            return true;
        }
    }
}
