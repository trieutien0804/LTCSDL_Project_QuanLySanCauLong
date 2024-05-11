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
        fHome fHome;
        fDatSan lichDatSan;
        fNhansan NhanSan;
        fQLSan QLSan;
        fQLKhachHang QLKhachHang;
        fQLHoaDon QLHoaDon;
        fTaiKhoan taiKhoan;
        fThongKe thongKe;

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


        private void btDatSan_Click(object sender, EventArgs e)
        {
            if (pMain.Controls.Count > 0)
            {
                Form currentForm = pMain.Controls[0] as Form;
                currentForm.Close();
            }
            lichDatSan = new fDatSan();
            lichDatSan.TopLevel = false;
            lichDatSan.Dock = DockStyle.Fill;
            pMain.Controls.Add(lichDatSan);
            lichDatSan.Show();
        }

        private void btQLSan_Click(object sender, EventArgs e)
        {
            if (pMain.Controls.Count > 0)
            {
                Form currentForm = pMain.Controls[0] as Form;
                currentForm.Close();
            }
            QLSan = new fQLSan();
            QLSan.TopLevel = false;
            QLSan.Dock = DockStyle.Fill;
            pMain.Controls.Add(QLSan);
            QLSan.Show();
        }
        private void fAdmin_Load(object sender, EventArgs e)
        {
            if (pMain.Controls.Count > 0)
            {
                Form currentForm = pMain.Controls[0] as Form;
                currentForm.Close();
            }
            fHome = new fHome();
            fHome.TopLevel = false;
            fHome.Dock = DockStyle.Fill;
            pMain.Controls.Add(fHome);
            fHome.Show();
        }

        private void pMain_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (pMain.Controls.Count > 0)
            {
                Form currentForm = pMain.Controls[0] as Form;
                currentForm.Close();
            }
            fHome = new fHome();
            fHome.TopLevel = false;
            fHome.Dock = DockStyle.Fill;
            pMain.Controls.Add(fHome);
            fHome.Show();
        }

        private void btTaiKhoan_Click(object sender, EventArgs e)
        {
            if (pMain.Controls.Count > 0)
            {
                Form currentForm = pMain.Controls[0] as Form;
                currentForm.Close();
            }
            taiKhoan = new fTaiKhoan();
            taiKhoan.TopLevel = false;
            taiKhoan.Dock = DockStyle.Fill;
            pMain.Controls.Add(taiKhoan);
            taiKhoan.Show();
        }

        private void btNhanSan_Click(object sender, EventArgs e)
        {
            if (pMain.Controls.Count > 0)
            {
                Form currentForm = pMain.Controls[0] as Form;
                currentForm.Close();
            }
            NhanSan = new fNhansan();
            NhanSan.TopLevel = false;
            NhanSan.Dock = DockStyle.Fill;
            pMain.Controls.Add(NhanSan);
            NhanSan.Show();
        }

        private void btQLKH_Click(object sender, EventArgs e)
        {
            if (pMain.Controls.Count > 0)
            {
                Form currentForm = pMain.Controls[0] as Form;
                currentForm.Close();
            }
            QLKhachHang = new fQLKhachHang();
            QLKhachHang.TopLevel = false;
            QLKhachHang.Dock = DockStyle.Fill;
            pMain.Controls.Add(QLKhachHang);
            QLKhachHang.Show();
        }

        private void btQLHoaDon_Click(object sender, EventArgs e)
        {
            if (pMain.Controls.Count > 0)
            {
                Form currentForm = pMain.Controls[0] as Form;
                currentForm.Close();
            }
            QLHoaDon = new fQLHoaDon();
            QLHoaDon.TopLevel = false;
            QLHoaDon.Dock = DockStyle.Fill;
            pMain.Controls.Add(QLHoaDon);
            QLHoaDon.Show();
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            if (pMain.Controls.Count > 0)
            {
                Form currentForm = pMain.Controls[0] as Form;
                currentForm.Close();
            }
            thongKe = new fThongKe();
            thongKe.TopLevel = false;
            thongKe.Dock = DockStyle.Fill;
            pMain.Controls.Add(thongKe);
            thongKe.Show();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            fLogin fLogin = new fLogin();
            fLogin.Show();
        }
    }

}
