using BTL_QLSCV.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLSCV.BUS
{
    class BUS_CHITIETHOADON
    {
        DAL_CHITIETHOADON dal_CHITIETHOADON;

        public BUS_CHITIETHOADON()
        {
            dal_CHITIETHOADON = new DAL_CHITIETHOADON();
        }

        public bool addCHITIETHOADON(int maHD, int maCaThue) 
        {
            return dal_CHITIETHOADON.addCHITIETHOADON(maHD, maCaThue);
        }

        public bool addThoiGianThanhToan(int maChiTietHoaDon)
        {
            string now = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            return dal_CHITIETHOADON.addThoiGianThanhToan(maChiTietHoaDon, now);
        }
    }
}
