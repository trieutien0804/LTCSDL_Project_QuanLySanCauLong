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
    public partial class fTaiKhoan : Form
    {
        BUS_NGUOIDUNG bus_NGUOIDUNG = new BUS_NGUOIDUNG();
        fQLNguoDung fQLNguoDung;
        public fTaiKhoan()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void fTaiKhoan_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btCNTK_Click(object sender, EventArgs e)
        {
            
            fQLNguoDung = new fQLNguoDung();
            fQLNguoDung.Show();
        }
    }
}
