using BTL_QLSCV.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QLSCV.BUS
{
    class BUS_CATHUE
    {
        DAL_CATHUE dal_CATHUE;
        public BUS_CATHUE()
        {
            dal_CATHUE = new DAL_CATHUE();
        }
        public dynamic getCaThue()
        {
            return dal_CATHUE.getCaThue();
        }
        public bool addCaThue(int gia, int maSan, string maCaText)
        {
            int startIndex = maCaText.IndexOf("=") + 1;
            int endIndex = maCaText.IndexOf(",", startIndex);
            int maCa = Convert.ToInt32(maCaText.Substring(startIndex, endIndex - startIndex).Trim());

            if (dal_CATHUE.ktCaThue(maSan, maCa))
            {
                return dal_CATHUE.addCaThue(gia, maSan, maCa);
            }
            return false;
        }
        public bool removeCaThue(int maCaThue)
        {
            return dal_CATHUE.removeCaThue(maCaThue);
        }
        public bool editCaThue(int curCATHUE, CATHUE cathue)
        {
            return dal_CATHUE.editCaThue(curCATHUE, cathue);
        }
        public bool ktCaThue(int maSan, int maCa)
        {
            return dal_CATHUE.ktCaThue(maSan, maCa);
        }

        public int getMaCaThueByCaVaSan(int maCa, int maSan)
        {
            return dal_CATHUE.getMaCaThueByCaVaSan(maCa, maSan);
        }
    }
}
