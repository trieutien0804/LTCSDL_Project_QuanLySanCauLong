using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLSCV.DAL
{
    internal class DAL_KHACHHANG
    {
        QLSCLEntities3 db;
        public DAL_KHACHHANG()
        {
            db = new QLSCLEntities3();
        }
        public dynamic getKH()
        {
            var dsKHACHHANG = db.KHACHHANG.Select(s => new { s.MaKH, s.HoTen, s.SDT, s.DiaChi}).ToList();
            return dsKHACHHANG;
        }
        public dynamic findKHBySDT(string sDT)
        {
            var query = db.KHACHHANG.AsQueryable();
            if (!string.IsNullOrEmpty(sDT))
            {
                query = query.Where(kh => kh.SDT.Contains(sDT));

            }
            // Thực thi truy vấn và trả về kết quả
            var ds = query.Select(s => new
            {
                s.MaKH,
                s.HoTen,
                s.DiaChi,
                s.SDT
            }).ToList();

            return ds;
        }
        public dynamic timKhach(string sDT)
        {
                var query = db.KHACHHANG.AsQueryable();
                if (!string.IsNullOrEmpty(sDT))
                {
                    query = query.Where(kh => kh.SDT.Contains(sDT));

                }
                // Thực thi truy vấn và trả về kết quả
                var ds = query.Select(s => new
                {
                    s.MaKH,
                    s.HoTen,
                    s.DiaChi,
                    s.SDT
                }).ToList();

                return ds;
        }
        public bool addKH(string hoTen, string sDT, string diaChi)
        {
            var kh = new KHACHHANG()
            {
                HoTen = hoTen,
                SDT = sDT,
                DiaChi = diaChi
            };
            db.KHACHHANG.Add(kh);
            db.SaveChanges();
            return true;    
        }
        public bool removeKH(int maKH)
        {
            KHACHHANG kh = db.KHACHHANG.Where(k => k.MaKH == maKH).FirstOrDefault();
            db.KHACHHANG.Remove(kh);
            db.SaveChanges();
            return true;
        }
        public bool editKH(int curMAKH, KHACHHANG kh)
        {
            KHACHHANG k = db.KHACHHANG.Find(curMAKH);
            k.HoTen = kh.HoTen;
            k.SDT = kh.SDT;
            k.DiaChi = kh.DiaChi;   
            db.SaveChanges();
            return true;
        }
    }
}
