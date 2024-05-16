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
        BUS_PHIEUDATSAN bus_PHIEUDATSAN = new BUS_PHIEUDATSAN();
        BUS_CHITIETDATSAN bus_CHITIETDATSAN = new BUS_CHITIETDATSAN();
        public fNhansan()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fNhansan_Load(object sender, EventArgs e)
        {
            dsChuaNhan.DataSource = bus_PHIEUDATSAN.getPHIEUDATSAN();
            this.ControlBox = false;
        }
    }
}
