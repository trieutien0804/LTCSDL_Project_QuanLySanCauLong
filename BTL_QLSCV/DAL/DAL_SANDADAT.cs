using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLSCV.DAL
{
    class DAL_SANDADAT
    {
        QLSCLEntities2 db;
        public DAL_SANDADAT()
        {
            db = new QLSCLEntities2();
        }

        public dynamic getSanDatTrongNgay(string tinhTrang, string today)
        {
            var dsTinhTrangSan = db.TINHTRANGSANs.Select(s => new {s.MaTinhTrang, s.MaCaThue, s.TinhTrang, s.Ngay }).ToList();
            var dsCaThue = db.CATHUEs.Select(s => new { s.MaCaThue, s.Gia, s.MaSan, s.MaCa }).ToList();
            var dsChiTietDatSan = db.CHITIETDATSANs.Select(s => new { s.MaCaThue, s.MaPhieu, s.TienCoc}).ToList();
            var dsPhieuDatSan = db.PHIEUDATSANs.Select(s => new { s.MaPhieu, s.NgayDat, s.MaKH }).ToList();
            var dsKhachHang = db.KHACHHANGs.Select(s => new { s.MaKH, s.HoTen, s.SDT, s.DiaChi }).ToList();
            var dsSan = db.SANs.Select(s => new {s.MaSan, s.TenSan}).ToList();
            var dsCa = db.CAs.Select(s => new { s.MaCa, s.ThoiGianBD, s.ThoiGianKT}).ToList();


            var joinData = from ctds in dsChiTietDatSan
                           join caThue in dsCaThue on ctds.MaCaThue equals caThue.MaCaThue
                           join phieuDatSan in dsPhieuDatSan on ctds.MaPhieu equals phieuDatSan.MaPhieu
                           join tts in dsTinhTrangSan on ctds.MaCaThue equals tts.MaCaThue
                           join kh in dsKhachHang on phieuDatSan.MaKH equals kh.MaKH
                           join san in dsSan on caThue.MaSan equals san.MaSan
                           join ca in dsCa on caThue.MaCa equals ca.MaCa
                           where tts.TinhTrang == tinhTrang && tts.Ngay == today && tts.Ngay == phieuDatSan.NgayDat
                           select new
                           {
                               caThue.MaCaThue,
                               san.TenSan,
                               ca.ThoiGianBD,
                               ca.ThoiGianKT,
                               kh.MaKH,
                               kh.HoTen,
                               kh.SDT,
                               ctds.TienCoc,
                               caThue.Gia,
                               phieuDatSan.MaPhieu,
                               tts.MaTinhTrang
                           };
            return joinData.ToList();

        }

        public dynamic getSanDangHDTrongNgay(string today)
        {

            var dsSAN = db.SANs.Select(s => new { s.MaSan, s.TenSan }).ToList();
            var dsCA = db.CAs.Select(s => new { s.MaCa, s.ThoiGianBD, s.ThoiGianKT }).ToList();

            var dsTT = db.TINHTRANGSANs.Select(s => new {s.MaTinhTrang, s.MaCaThue, s.TinhTrang, s.Ngay }).ToList();
            var dsCaThue = db.CATHUEs.Select(s => new { s.MaCaThue, s.Gia, s.MaSan, s.MaCa }).ToList();

            var joinData = from tts in dsTT
                           join caThue in dsCaThue on tts.MaCaThue equals caThue.MaCaThue
                           join ca in dsCA on caThue.MaCa equals ca.MaCa
                           join san in dsSAN on caThue.MaSan equals san.MaSan
                           where tts.TinhTrang == "HD" && tts.Ngay == today
                           select new
                           {
                               tts.MaTinhTrang,
                               caThue.MaCaThue,
                               tts.Ngay,
                               san.TenSan,
                               caThue.Gia,
                               tts.TinhTrang,
                               ca.ThoiGianBD,
                               ca.ThoiGianKT
                           };
            return joinData.ToList();
        }
    }
}
