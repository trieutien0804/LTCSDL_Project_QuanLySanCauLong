using BTL_QLSCV.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLSCV.BUS
{
    class BUS_KHACHHANG
    {
        DAL_KHACHHANG dal_KHACHHANG;
        public BUS_KHACHHANG()
        {
            dal_KHACHHANG = new DAL_KHACHHANG();
        }

        public dynamic getKH()
        {
            return dal_KHACHHANG.getKH();
        }

        public bool addKH(string tenSan, string sDT, string diaChi)
        {
            return dal_KHACHHANG.addKH(tenSan, sDT, diaChi);
        }

        public bool removeKH(int maKH)
        {
            return dal_KHACHHANG.removeKH(maKH);
        }

        public bool editKH(int curMAKH, KHACHHANG kh)
        {
            return dal_KHACHHANG.editKH(curMAKH, kh);
        }
        public dynamic findKHBySDT(string sDT)
        {
            return dal_KHACHHANG.findKHBySDT(sDT);
        }
    }
}
