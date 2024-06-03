using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_TINHTONGmoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void btntinhtong_Click(object sender, EventArgs e)
        {
            Double so1, so2, so3;
            so1 = Convert.ToDouble(txtso1.Text);
            so2 = Convert.ToDouble(txtso2.Text);
            so3 = so1 + so2;
            txtso3.Text = so3.ToString();
            lblkq.Text = so3.ToString();
        }

        private void lblso1_MouseHover(object sender, EventArgs e)
        {
            btntinhtong.Text= "GIÁ TRỊ BIẾN";
        }

        private void lblso2_MouseHover(object sender, EventArgs e)
        {
            btntinhtong.Text = "GIÁ TRỊ BIẾN 2";
        }

        private void btntinhhieu_Click(object sender, EventArgs e)
        {
            Double so1, so2, so3;
            so1 = Convert.ToDouble(txtso1.Text);
            so2 = Convert.ToDouble(txtso2.Text);
            so3 = so1 - so2;
            txtso3.Text = so3.ToString();
            lblkq.Text = so3.ToString();
        }

        private void btntinhtich_Click(object sender, EventArgs e)
        {
            Double so1, so2, so3;
            so1 = Convert.ToDouble(txtso1.Text);
            so2 = Convert.ToDouble(txtso2.Text);
            so3 = so1 * so2;
            txtso3.Text = so3.ToString();
            lblkq.Text = so3.ToString();
        }

        private void btntinhthuong_Click(object sender, EventArgs e)
        {
            Double so1, so2, so3;
            so1 = Convert.ToDouble(txtso1.Text);
            so2 = Convert.ToDouble(txtso2.Text);
            if (so2 == 0)
            {
                MessageBox.Show("KHÔNG THỂ CHIA KHÔNG", "THÔNG BÁO LỖI", MessageBoxButtons.OKCancel);
            }
            else
            {
                so3 = so1 * so2;
                txtso3.Text = so3.ToString();
                lblkq.Text = so3.ToString();
            }
        }
    }
}
