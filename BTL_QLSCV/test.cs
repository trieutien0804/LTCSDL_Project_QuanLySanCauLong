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
    public partial class test : Form
    {
        private bool isRed = false;
        public test()
        {
            InitializeComponent();
        }


        private void changeColorbtn(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                // Kiểm tra màu hiện tại của button và thay đổi màu
                if (clickedButton.BackColor == Color.Red)
                {
                    clickedButton.BackColor = Color.White;
                }
                else
                {
                    clickedButton.BackColor = Color.Red;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
