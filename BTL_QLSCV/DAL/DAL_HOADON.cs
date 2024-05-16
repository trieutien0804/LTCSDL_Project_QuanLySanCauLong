using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLSCV.DAL
{
    class DAL_HOADON
    {
        QLSCLEntities2 db;
        public DAL_HOADON()
        {
            db = new QLSCLEntities2();
        }

        public int addHOADON(string thoiGianThanhToan, string tenKH, int tongTien, int maPhieu)
        {
            var hoadon = new HOADON()
            {
                ThoiGianTaoHoaDon = thoiGianThanhToan,
                HoTenNguoiTT = tenKH,
                TongTien = tongTien,
                MaPhieu = maPhieu
            };
            db.HOADONs.Add(hoadon);
            db.SaveChanges();
            int a = hoadon.MaHD;
            return a;
        }

        public dynamic getHOADON() {
            var dsChiTietHoaDon = db.CHITIETHOADONs.Select(s => new {s.MaChiTietHoaDon, s.MaHD, s.MaCaThue }).ToList();
            var dsCaThue = db.CATHUEs.Select(s => new { s.MaCaThue, s.Gia, s.MaSan, s.MaCa }).ToList();
            var dsHoaDon = db.HOADONs.Select(s => new { s.MaHD, s.ThoiGianTaoHoaDon, s.HoTenNguoiTT, s.TongTien, s.MaPhieu}).ToList();
            var dsTinhTrang = db.TINHTRANGSANs.Select(s => new { s.MaCaThue, s.MaTinhTrang, s.TinhTrang}).ToList();
            var dsPhieuDatSan = db.PHIEUDATSANs.Select(s => new { s.MaPhieu, s.NgayDat, s.MaKH }).ToList();
            var dsKhachHang = db.KHACHHANGs.Select(s => new { s.MaKH, s.HoTen, s.SDT, s.DiaChi }).ToList();
            var dsChiTietDatSan = db.CHITIETDATSANs.Select(s => new { s.MaCaThue, s.MaPhieu, s.TienCoc }).ToList();
            var dsSan = db.SANs.Select(s => new { s.MaSan, s.TenSan}).ToList();


            var joinData = from cthd in dsChiTietHoaDon
                           join caThue in dsCaThue on cthd.MaCaThue equals caThue.MaCaThue
                           join hoaDon in dsHoaDon on cthd.MaHD equals hoaDon.MaHD
                           join tts in dsTinhTrang on cthd.MaCaThue equals tts.MaCaThue
                           join phieuDatSan in dsPhieuDatSan on hoaDon.MaPhieu equals phieuDatSan.MaPhieu
                           join ctds in dsChiTietDatSan on phieuDatSan.MaPhieu equals ctds.MaPhieu
                           join kh in dsKhachHang on phieuDatSan.MaKH equals kh.MaKH
                           join san in dsSan on caThue.MaSan equals san.MaSan
                           select new
                           {
                               hoaDon.MaHD,
                               san.TenSan,
                               hoaDon.ThoiGianTaoHoaDon,
                               caThue.MaCa,
                               kh.HoTen,
                               hoaDon.TongTien,
                               kh.SDT,
                               ctds.TienCoc,
                               cthd.MaChiTietHoaDon,
                               tts.MaTinhTrang
                           };
            return joinData.ToList();
        }
    }
}
