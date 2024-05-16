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
    public partial class fQLSan : Form
    {
        BUS_SAN bus_SAN = new BUS_SAN();
        BUS_CA bus_CA = new BUS_CA();
        BUS_CATHUE bus_CATHUE = new BUS_CATHUE();   
        fCNCa fCNCa;
        public fQLSan()
        {
            InitializeComponent();
        }

        private void fQLsan_Load(object sender, EventArgs e)
        {
            int maCa = comboTree1.ValueMember.FirstOrDefault();
            txtTenSan.Text = maCa.ToString();
            comboTree1.DataSource = bus_CA.getCA();
            cbTenSan.DataSource = bus_SAN.getTenSan();
            dsCaThue.DataSource = bus_CATHUE.getCaThue();   
            dsSan.DataSource = bus_SAN.getSAN();
            this.ControlBox = false;
        }

        private void btThemSan_Click_1(object sender, EventArgs e)
        {
            if (txtTenSan.Text != "")
            {
                if (bus_SAN.addSAN(txtTenSan.Text))
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

        private void btSuaSan_Click_1(object sender, EventArgs e)
        {
            if (dsSan.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dsSan.SelectedRows[0];
                int curMaSan = Convert.ToInt32(row.Cells[0].Value.ToString());
                SAN san = new SAN();
                san.TenSan = txtTenSan.Text;
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

        private void btXoaSan_Click_1(object sender, EventArgs e)
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

        private void btCNCa_Click(object sender, EventArgs e)
        {
            fCNCa = new fCNCa();
            fCNCa.Show();
        }

        private void dsSan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btThemCaThue_Click(object sender, EventArgs e)
        {
            if (cbTenSan.Text != "" && comboTree1.Text != "" && txtGia.Text != "")
            {
                string maCaText = comboTree1.SelectedValue.ToString();
                int startIndex = maCaText.IndexOf("=") + 1;
                int endIndex = maCaText.IndexOf(",", startIndex);
                int maCa = Convert.ToInt32(maCaText.Substring(startIndex, endIndex - startIndex).Trim());
                int maSan = bus_SAN.findMaSanByTenSan(cbTenSan.Text);
                txtTenSan.Text = maCa.ToString();
                int gia = Convert.ToInt32(txtGia.Text);
                if (bus_CATHUE.addCaThue(gia, maSan, maCa))
                {
                    dsCaThue.DataSource = bus_CATHUE.getCaThue();
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
    }
}
