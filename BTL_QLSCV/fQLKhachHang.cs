using BTL_QLSCV.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QLSCV
{
    public partial class fQLKhachHang : Form
    {
        BUS_KHACHHANG bus_KHACHHANG = new BUS_KHACHHANG();
        public fQLKhachHang()
        {
            InitializeComponent();
        }

        private void fQLKhachHang_Load(object sender, EventArgs e)
        {
            dsKhachHang.DataSource = bus_KHACHHANG.getKH();
            this.ControlBox = false;
        }

        private void btThemKH_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text != "" && txtHoTen.Text != "" && txtSDT.Text != "" && txtDiaChi.Text != "")
            {
                if (bus_KHACHHANG.addKH(Convert.ToInt32(txtMaKH.Text), txtHoTen.Text, txtSDT.Text, txtDiaChi.Text))
                {
                    dsKhachHang.DataSource = bus_KHACHHANG.getKH();
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }
        private void btSuaKH_Click(object sender, EventArgs e)
        {
            if (dsKhachHang.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dsKhachHang.SelectedRows[0];
                int curMaKH = Convert.ToInt32(row.Cells[0].Value.ToString());
                KHACHHANG kh = new KHACHHANG();
                kh.HoTen = txtHoTen.Text;
                kh.SDT = txtSDT.Text;
                kh.DiaChi = txtDiaChi.Text;
                if (bus_KHACHHANG.editKH(curMaKH, kh))
                {
                    dsKhachHang.DataSource = bus_KHACHHANG.getKH();
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sân muốn sửa");
            }
        }
        private void btXoaKH_Click(object sender, EventArgs e)
        {
            if (dsKhachHang.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dsKhachHang.SelectedRows[0];
                int maKH = Convert.ToInt32(row.Cells[0].Value.ToString());
                if (bus_KHACHHANG.removeKH(maKH))
                {
                    dsKhachHang.DataSource = bus_KHACHHANG.getKH();
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
            else
            {
                MessageBox.Show("Xóa không thành công");
            }
        }
    }
}
