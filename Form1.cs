using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Bangdiem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            Double toan, van, tb;
            toan=Convert.ToDouble(txttoan.Text);
            van=Convert.ToDouble(txtvan.Text);
            tb = (toan + van) / 2;
            txtTB.Text=tb.ToString();

            if(tb<5)
            {
                txtXL.Text = "yếu";
            }
            else if(tb<=6)
            {
                txtXL.Text = "tb";
            }
            else if (tb<8)
            { 
                txtXL.Text = "khá"; 
            }
            else 
            { 
                txtXL.Text = "giỏi";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
