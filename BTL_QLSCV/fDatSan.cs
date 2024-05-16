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

namespace BTL_QLSCV
{
    public partial class fDatSan : Form
    {
        BUS_SAN bus_SAN = new BUS_SAN();
        BUS_CA bus_CA = new BUS_CA();
        BUS_KHACHHANG bus_KH = new BUS_KHACHHANG();
        public fDatSan()
        {   
            InitializeComponent();
        }

        private void fDatSan_Load(object sender, EventArgs e)
        {
            comboTree1.DataSource = bus_CA.getCA();
        }

        private void btTimSanTrong_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpNgayNhan.Value;
            string ngay = selectedDate.ToString("yyyy-dd-MM", CultureInfo.InvariantCulture);
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

        private void btHuy_Click(object sender, EventArgs e)
        {
            txtMaPhieu.Text = "";
            txtNVdatsan.Text = "";
            txtNgayNhan.Text = "";
            txtCa.Text = "";
            txtTienCoc.Text = "";
            txtNote.Text = "";
            txtMaKH.Text = "";
            txtHoTen.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
        }
    }
}
