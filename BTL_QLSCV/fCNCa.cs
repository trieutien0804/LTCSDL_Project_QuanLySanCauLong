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
    public partial class fCNCa : Form
    {
        BUS_CA bus_CA = new BUS_CA();
        public fCNCa()
        {
            InitializeComponent();
        }
        private void btThemCa_Click(object sender, EventArgs e)
        {
            if (txtMaCa.Text != "")
            {
                if (bus_CA.addCA(dtpTGBD.Text, dtpTGKT.Text))
                {
                    dgvdsCa.DataSource = bus_CA.getCA();
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
        private void fCNCa_Load(object sender, EventArgs e)
        {
            dgvdsCa.DataSource = bus_CA.getCA();
            this.ControlBox = false;
        }
        private void btSuaCa_Click(object sender, EventArgs e)
        {
            if (dgvdsCa.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvdsCa.SelectedRows[0];
                int curMaCA = Convert.ToInt32(row.Cells[0].Value.ToString());
                CA ca = new CA();
                ca.ThoiGianBD = dtpTGBD.Text;
                ca.ThoiGianKT = dtpTGKT.Text;
                if (bus_CA.editCA(curMaCA, ca))
                {
                    dgvdsCa.DataSource = bus_CA.getCA();
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
        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btXoaCa_Click(object sender, EventArgs e)
        {
            if (dgvdsCa.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvdsCa.SelectedRows[0];
                int maCa = Convert.ToInt32(row.Cells[0].Value.ToString());
                if (bus_CA.removeCA(maCa))
                {
                    dgvdsCa.DataSource = bus_CA.getCA();
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
