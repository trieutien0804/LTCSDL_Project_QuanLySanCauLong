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
    public partial class fQLNguoDung : Form
    {
        BUS_NGUOIDUNG bus_NGUOIDUNG = new BUS_NGUOIDUNG();  
        public fQLNguoDung()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btThemNguoiDung_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text != "" && txtUsername.Text != "" && txtPass.Text != "" && txtCPass.Text != "" && cbRole.Text != "")
            {
                if(txtPass.Text != txtCPass.Text)
                {
                    MessageBox.Show("Mật khẩu không trùng khớp!");
                }
                else
                {
                    if (bus_NGUOIDUNG.addND(txtHoTen.Text, txtUsername.Text, txtPass.Text, cbRole.Text))
                    {
                        dsNguoiDung.DataSource = bus_NGUOIDUNG.getND();
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công");
                    }
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void fThemNguoDung_Load(object sender, EventArgs e)
        {
            cbRole.Items.Add("admin");
            cbRole.Items.Add("Nhân viên");
            dsNguoiDung.DataSource = bus_NGUOIDUNG.getND();
        }
    }
}
