using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLSCV.DAL
{
    internal class DAL_KHACHHANG
    {
        QLSCLEntities db;
        public DAL_KHACHHANG()
        {
            db = new QLSCLEntities();
        }
        public dynamic getKH()
        {
            var dsKHACHHANG = db.KHACHHANGs.Select(s => new { s.MaKH, s.HoTen, s.SDT, s.DiaChi}).ToList();
            return dsKHACHHANG;
        }
        public dynamic findKHBySDT()
        {
            var dsKHACHHANG = db.KHACHHANGs.Select(s => new { s.MaKH, s.HoTen, s.SDT, s.DiaChi }).ToList();
            return dsKHACHHANG;
        }
        public bool addKH(int maKH, string hoTen, string sDT, string diaChi)
        {
            var kh = new KHACHHANG()
            {
                MaKH = maKH,
                HoTen = hoTen,
                SDT = sDT,
                DiaChi = diaChi
            };
            db.KHACHHANGs.Add(kh);
            db.SaveChanges();
            return true;
        }
        public bool removeKH(int maKH)
        {
            KHACHHANG kh = db.KHACHHANGs.Where(k => k.MaKH == maKH).FirstOrDefault();
            db.KHACHHANGs.Remove(kh);
            db.SaveChanges();
            return true;
        }
        public bool editKH(int curMAKH, KHACHHANG kh)
        {
            KHACHHANG k = db.KHACHHANGs.Find(curMAKH);
            k.HoTen = kh.HoTen;
            k.SDT = kh.SDT;
            k.DiaChi = kh.DiaChi;   
            db.SaveChanges();
            return true;
        }
    }
}
