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
    public partial class fLogin : Form
    {
        BUS_NGUOIDUNG BUS_NGUOIDUNG = new BUS_NGUOIDUNG();
        //fAdmin fAdmin;
        fAdmin fAdmin;
        fHome fHome;
        fQLSan fQLsan;
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtLoginName.Text;
            string password = txtPassword.Text;

            if (username != "" && password != "")
            {
                if (BUS_NGUOIDUNG.Login(username, password))
                {
                    fAdmin = new fAdmin();
                    fAdmin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Khong thanh cong");
                }
            }
            else
            {
                MessageBox.Show("Vui long nhap day du");
            }
            
        }

        private void txtLoginName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick(); ;
            }
        }

    }
}
