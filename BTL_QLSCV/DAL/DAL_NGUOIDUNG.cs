﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BTL_QLSCV.DAL
{
    class DAL_NGUOIDUNG
    {
        QLSCLEntities3 db;

        public DAL_NGUOIDUNG()
        {
            db = new QLSCLEntities3();
        }

        public bool Login(string username, string password)
        {
            var user = db.NGUOIDUNG.Where(u => u.TenDangNhap == username).FirstOrDefault();

            if (user != null && user.MatKhau == password)
            {
                return true;
            }
            return false;
        }

        public dynamic getNGUOIDUNG()
        {

            var dsNGUOIDUNG = db.NGUOIDUNG.Select(u => u.TenDangNhap == "admin").ToList();

            return dsNGUOIDUNG;
        }
        public dynamic getUserRole()
        {
            var user = db.NGUOIDUNG.Where(u => u.Quyen == "admin").ToList();
            return user;
        }
        public dynamic getND()
        {
            var dsND = db.NGUOIDUNG.Select(s => new { s.MaNguoiDung, s.HoTen, s.TenDangNhap, s.MatKhau, s.Quyen }).ToList();
            return dsND;
        }
        public bool addND(string hoTen, string username, string pass, string role)
        {
            var u = new NGUOIDUNG()
            {
                HoTen = hoTen,
                TenDangNhap = username,
                MatKhau = pass,
                Quyen = role,
            };
            db.NGUOIDUNG.Add(u);
            db.SaveChanges();
            return true;
        }
        public bool editND(int maND, NGUOIDUNG user)
        {
            NGUOIDUNG u = db.NGUOIDUNG.Find(maND);
            u.HoTen = user.HoTen;
            db.SaveChanges();
            return true;
        }
    }
}
