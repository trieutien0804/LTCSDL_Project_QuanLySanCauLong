using BTL_QLSCV.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QLSCV
{
    public partial class fAdmin : Form
    {
        BUS_NGUOIDUNG BUS_NGUOIDUNG = new BUS_NGUOIDUNG();
        public fAdmin()
        {
            InitializeComponent();
        }
        bool btQuanlyExpand = false;
     
        private void btQuanlyTrainsition_Tick_1(object sender, EventArgs e)
        {
            if (btQuanlyExpand == false)
            {
                flp_quanly.Height += 10;
                if (flp_quanly.Height >= 203)
                {
                    btQuanlyTrainsition.Stop();
                    btQuanlyExpand = true;
                }
            }
            else
            {
                flp_quanly.Height -= 10;
                if (flp_quanly.Height <= 51)
                {
                    btQuanlyTrainsition.Stop();
                    btQuanlyExpand = false;
                }
            }
        }

        private void btQuanly_Click_1(object sender, EventArgs e)
        {
            btQuanlyTrainsition.Start();
        }

        private void fAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void fAdmin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
