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

        private void fAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void fAdmin_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BUS_NGUOIDUNG.getNGUOIDUNG();
        }
    }
}
