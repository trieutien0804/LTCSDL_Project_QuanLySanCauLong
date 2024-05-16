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
        BUS_HOADON bus_HOADON = new BUS_HOADON();
        BUS_CHITIETHOADON bus_CHITIETHOADON = new BUS_CHITIETHOADON();
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
            int maTinhTrang = Convert.ToInt32(row.Cells[10].Value.ToString());
            //ham thay doi tinh trang
            if (bus_TINHTRANGSAN.toSanDangHoatDong(maTinhTrang))
            {
                //tao hoa don
                string tenKH = txtHoTen.Text;
                int tongTien = Convert.ToInt32(row.Cells[8].Value.ToString());
                int maPhieu = Convert.ToInt32(txtMaPhieu.Text);
                int maCaThue = Convert.ToInt32(row.Cells[0].Value.ToString());
                int maHoaDonMoiTao =  bus_HOADON.addHOADON(tenKH, tongTien, maPhieu);
                if (bus_CHITIETHOADON.addCHITIETHOADON(maHoaDonMoiTao, maCaThue))
                {
                    MessageBox.Show("Thanh Cong");
                    dsChuaNhan.DataSource = bus_SANDADAT.getSanDatTrongNgay();
                    dsDaNhan.DataSource = bus_SANDADAT.getSanDangHDTrongNgay();
                }
                
            }         
        }

        private void dsChuaNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dsChuaNhan.SelectedRows[0];
            txtMaPhieu.Text = row.Cells[9].Value.ToString();
            txtHoTen.Text = row.Cells[5].Value.ToString();
            txtSDT.Text = row.Cells[6].Value.ToString();
            txtTienCoc.Text = row.Cells[7].Value.ToString();
            txtGBD.Text = row.Cells[2].Value.ToString();
            txtGKT.Text = row.Cells[3].Value.ToString();
            cbSanTrong.Text = row.Cells[1].Value.ToString();
        }
    }
}
