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
    public partial class fNhansan : Form
    {
        BUS_SANDADAT bus_SANDADAT = new BUS_SANDADAT();
        BUS_TINHTRANGSAN bus_TINHTRANGSAN = new BUS_TINHTRANGSAN();
        public fNhansan()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fNhansan_Load(object sender, EventArgs e)
        {
            dsChuaNhan.DataSource = bus_SANDADAT.getSanDatTrongNgay();
            dsDaNhan.DataSource = bus_SANDADAT.getSanDangHDTrongNgay();
            this.ControlBox = false;
        }

        private void btNhanSan_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dsChuaNhan.SelectedRows[0];
            int maTinhTrang = Convert.ToInt32(row.Cells[0].Value.ToString());

            //ham thay doi tinh trang
            if (bus_TINHTRANGSAN.toSanDangHoatDong(maTinhTrang))
            {
                MessageBox.Show("Thanh Cong");
                dsChuaNhan.DataSource = bus_SANDADAT.getSanDatTrongNgay();
                dsDaNhan.DataSource = bus_SANDADAT.getSanDangHDTrongNgay();
            }
            //show lai
            
        }
    }
}
