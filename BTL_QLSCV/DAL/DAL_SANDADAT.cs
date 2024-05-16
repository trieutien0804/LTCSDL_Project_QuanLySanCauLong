using System;
using System.Collections.Generic;
using System.Linq;
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

        public dynamic getSanDatTrongNgay(string today)
        {
            var dsSAN = db.SANs.Select(s => new { s.MaSan, s.TenSan }).ToList();
            var dsCA = db.CAs.Select(s => new { s.MaCa, s.ThoiGianBD, s.ThoiGianKT }).ToList();

            var dsTT = db.TINHTRANGSANs.Select(s => new {s.MaTinhTrang, s.MaCaThue, s.TinhTrang, s.Ngay }).ToList();
            var dsCaThue = db.CATHUEs.Select(s => new { s.MaCaThue, s.Gia, s.MaSan, s.MaCa }).ToList();

            var joinData = from tts in dsTT
                           join caThue in dsCaThue on tts.MaCaThue equals caThue.MaCaThue
                           join ca in dsCA on caThue.MaCa equals ca.MaCa
                           join san in dsSAN on caThue.MaSan equals san.MaSan
                           where tts.TinhTrang == "DT" && tts.Ngay == today
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
