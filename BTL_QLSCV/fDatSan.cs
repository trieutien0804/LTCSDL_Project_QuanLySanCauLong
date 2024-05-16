using BTL_QLSCV.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using DevComponents.DotNetBar.Controls;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Runtime.Remoting.Contexts;

namespace BTL_QLSCV
{
    public partial class fDatSan : Form
    {
        BUS_SAN bus_SAN = new BUS_SAN();
        BUS_CA bus_CA = new BUS_CA();
        BUS_CATHUE bus_CATHUE = new BUS_CATHUE();
        BUS_KHACHHANG bus_KH = new BUS_KHACHHANG();
        BUS_PHIEUDATSAN bus_PHIEUDATSAN = new BUS_PHIEUDATSAN();
        BUS_CHITIETDATSAN bus_CHITIETDATSAN = new BUS_CHITIETDATSAN();
        BUS_TINHTRANGSAN bus_TINHTRANGSAN = new BUS_TINHTRANGSAN();
        public fDatSan()
        {   
            InitializeComponent();
        }

        private void fDatSan_Load(object sender, EventArgs e)
        {
            comboTree1.DataSource = bus_CA.getCA();
            txtMaPhieu.Text = bus_PHIEUDATSAN.nextMaPHIEUDATSAN().ToString();
        }

        private void btTimSanTrong_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpNgayNhan.Value;
            string ngay = selectedDate.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture);
            string pattern = @"MaCa\s*=\s*(\d+)";
            Match match = Regex.Match(comboTree1.SelectedValue.ToString(), pattern);
            if (match.Success)
            {
                dsSanDat.DataSource = bus_SAN.getSanDat(Convert.ToInt32(match.Groups[1].Value), ngay);
            }
            this.ControlBox = false;
        }

        private void dsSanDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    //DataGridViewRow row = dsSanDat.SelectedRows[0];
                txtNgayNhan.Text = dtpNgayNhan.Value.ToString("dd-MM-yyyy");
                txtCa.Text = comboTree1.Text;
            //}
        }

        private void btDatSan_Click(object sender, EventArgs e)
        {
            if (txtNgayNhan.Text != "" &&
                txtNVdatsan.Text != "" &&
                txtCa.Text != "" &&
                txtTienCoc.Text != "" &&
                txtMaKH.Text != "")
            {
                string ngayLap = DateTime.Now.ToString("dd-MM-yyyy");
                string ngayDat = txtNgayNhan.Text;
                int maPhieu = Convert.ToInt32(txtMaPhieu.Text);
                if (bus_PHIEUDATSAN.addPHIEUDATSAN(maPhieu, ngayLap, ngayDat, Convert.ToInt32(txtMaKH.Text)))
                {
                    //lay ma san
                    DataGridViewRow row = dsSanDat.SelectedRows[0];
                    int maSan = Convert.ToInt32(row.Cells[0].Value.ToString());
                    int maCa = Convert.ToInt32(txtCa.Text.Split(',')[0].Trim());

                    //lay ma ca thue 
                    int maCaThue = bus_CATHUE.getMaCaThueByCaVaSan(maCa, maSan);
                    bus_CHITIETDATSAN.addCHITIETDATSAN(Convert.ToInt32(txtMaPhieu.Text), maCaThue, Convert.ToInt32(txtTienCoc.Text));
                    

                    //add tinh trang san

                    if(bus_TINHTRANGSAN.addTINHTRANGSAN(ngayDat, "DT", maCaThue))
                    {
                        MessageBox.Show("Đặt sân thành công");
                        txtMaPhieu.Text = bus_PHIEUDATSAN.nextMaPHIEUDATSAN().ToString();
                    }
                    else
                    {
                        MessageBox.Show("Đặt sân không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Đặt sân không thành công");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đặt sân");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            
            if (txtTimKH.Text != "")
            {
                string sdt = txtTimKH.Text;
                dgvKH.DataSource = bus_KH.findKHBySDT(sdt);
            }
            else
            {
                MessageBox.Show("Hãy nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                DataGridViewRow row = dgvKH.SelectedRows[0];
                txtMaKH.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                txtSDT.Text = row.Cells[2].Value.ToString();
                txtDiaChi.Text = row.Cells[3].Value.ToString();
            
        }
    }
}
