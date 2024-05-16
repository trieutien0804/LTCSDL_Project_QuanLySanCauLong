using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLSCV.DAL
{
    class DAL_PHIEUDATSAN
    {
        QLSCLEntities3 db;
        public DAL_PHIEUDATSAN()
        {
            db = new QLSCLEntities3();
        }
        public int addPHIEUDATSAN(int maPhieu, string ngayLap, string ngayDat, int maKH)
        {
            var phieudatsan = new PHIEUDATSAN()
            {
                MaPhieu = maPhieu,
                NgayLap = ngayLap,
                NgayDat = ngayDat,
                MaKH = maKH
            };
            db.PHIEUDATSAN.Add(phieudatsan);
            db.SaveChanges();
            return maPhieu;
        }

        public dynamic getPHIEUDATSAN() 
        {

            var dsPHIEUDATSAN = db.PHIEUDATSAN.Select(s => new {
                s.MaPhieu,
                s.MaKH,
                s.NgayLap,
                s.NgayDat
            }).ToList();

            return dsPHIEUDATSAN;
        }
        public dynamic getPhieuTrongNgay()
        {
            var today = DateTime.Today;

            var dsPhieuTrongNgay = db.PHIEUDATSAN
                .ToList()
                .Where(s => DateTime.ParseExact(s.NgayDat, "dd-MM-yyyy", null).Date == today)
                .Select(s => new {
                    s.MaPhieu,
                    s.NgayDat,
                    
                })
                .ToList();

            return dsPhieuTrongNgay;
        }

        public int nextMaPHIEUDATSAN()
        {
            var maxId = db.PHIEUDATSAN.Max(x => (int?)x.MaPhieu) ?? 0;
            var nextId = maxId + 1;
            return nextId;
        }
        public dynamic getDSDatSan()
        {
            var dsPHIEUDATSAN = db.PHIEUDATSAN.Select(s => new {
                s.MaPhieu,
                s.MaKH,
                s.NgayLap,
                s.NgayDat
            }).ToList();

            var dsCHITIETDATSAN = db.CHITIETDATSAN.Select(s => new {
                s.MaPhieu,
                s.MaCaThue,
                s.TienCoc
            }).ToList();

            var dsKHACHHANG = db.KHACHHANG.Select(s => new {
                s.MaKH,
                s.HoTen,
                s.SDT,
                s.DiaChi
            }).ToList();

            var joinedData = (from pds in dsPHIEUDATSAN
                              join ctds in dsCHITIETDATSAN on pds.MaPhieu equals ctds.MaPhieu
                              join kh in dsKHACHHANG on pds.MaKH equals kh.MaKH
                              select new
                              {
                                  pds.MaPhieu,
                                  pds.MaKH,
                                  pds.NgayLap,
                                  pds.NgayDat,
                                  ctds.MaCaThue,
                                  ctds.TienCoc,
                                  kh.HoTen,
                                  kh.SDT,
                                  kh.DiaChi
                              }).ToList();

            return joinedData.ToList();
        }
    }
}
