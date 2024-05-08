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
    public partial class fQLsan : Form
    {
        BUS_SAN bus_SAN = new BUS_SAN();
        public fQLsan()
        {
            InitializeComponent();
        }

        private void fQLsan_Load(object sender, EventArgs e)
        {
            dsSan.DataSource = bus_SAN.getSAN();
        }

        private void btThemSan_Click(object sender, EventArgs e)
        {
            if (txtTenSan.Text != "" && txtMaSan.Text != "")
            {
                if (bus_SAN.addSAN(Convert.ToInt32(txtMaSan.Text), txtTenSan.Text))
                {
                    dsSan.DataSource = bus_SAN.getSAN();
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

        private void btXoaSan_Click(object sender, EventArgs e)
        {
            if (dsSan.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dsSan.SelectedRows[0];
                int maSan = Convert.ToInt32(row.Cells[0].Value.ToString());
                if (bus_SAN.removeSAN(maSan))
                {
                    dsSan.DataSource = bus_SAN.getSAN();
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

        private void btSuaSan_Click(object sender, EventArgs e)
        {
            if (dsSan.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dsSan.SelectedRows[0];
                int curMaSan = Convert.ToInt32(row.Cells[0].Value.ToString());
                SAN san = new SAN();
                san.Vitri = txtTenSan.Text;
                if (bus_SAN.editSAN(curMaSan, san))
                {
                    dsSan.DataSource = bus_SAN.getSAN();
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
    }
}
