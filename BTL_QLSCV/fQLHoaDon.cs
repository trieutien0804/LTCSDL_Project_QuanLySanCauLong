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
    public partial class fQLHoaDon : Form
    {
        BUS_HOADON bus_HOADON = new BUS_HOADON();
        BUS_TINHTRANGSAN bus_TINHTRANGSAN = new BUS_TINHTRANGSAN();
        BUS_CHITIETHOADON bus_CHITIETHOADON = new BUS_CHITIETHOADON();
        public fQLHoaDon()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void fQLHoaDon_Load(object sender, EventArgs e)
        {
            dsHoaDon.DataSource = bus_HOADON.getHOADON();
            this.ControlBox = false;
        }

        private void dsHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dsHoaDon.SelectedRows[0];
            txtMaHD.Text = row.Cells[0].Value.ToString();
            txtSan.Text = row.Cells[1].Value.ToString();
            txtNgayLap.Text = row.Cells[2].Value.ToString();
            txtCa.Text = row.Cells[3].Value.ToString();
            txtHoten.Text = row.Cells[4].Value.ToString();
            txtTongTien.Text = row.Cells[5].Value.ToString();
            txtSDT.Text = row.Cells[6].Value.ToString();
            txtTienCoc.Text = row.Cells[7].Value.ToString();
            int tongTien = Convert.ToInt32(txtTongTien.Text);
            int tienCoc = Convert.ToInt32(txtTienCoc.Text);
            txtThanhTien.Text = (tongTien - tienCoc).ToString();
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dsHoaDon.SelectedRows[0];
            int maChiTietHoaDon = Convert.ToInt32(row.Cells[8].Value.ToString());
            int maTinhTrang = Convert.ToInt32(row.Cells[9].Value.ToString());
            if (bus_CHITIETHOADON.addThoiGianThanhToan(maChiTietHoaDon))
            {
                if (bus_TINHTRANGSAN.toSanTrong(maTinhTrang))
                {
                    MessageBox.Show("Thanh toan thanh cong");
                }
                else
                {
                    MessageBox.Show("Thanh toan that bai");
                }
            }
            else
            {
                MessageBox.Show("Thanh toan that bai");
            }
        }
    }
}
