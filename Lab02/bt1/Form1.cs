using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(txb1.Text);
            float num2 = float.Parse(txb2.Text);
            float result = num1 + num2;
            lb_kq.Text = result.ToString();
        }
        private void btnSub_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(txb1.Text);
            float num2 = float.Parse(txb2.Text);
            float result = num1 - num2;
            lb_kq.Text = result.ToString();
        }
        private void btnMul_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(txb1.Text);
            float num2 = float.Parse(txb2.Text);
            float result = num1 * num2;
            lb_kq.Text = result.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(txb1.Text);
            float num2 = float.Parse(txb2.Text);
            if (num2 > 0)
            {
                float result = num1 / num2;
                lb_kq.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("number 1 không thể nhỏ hơn number 2\nVui lòng nhập lại !!!");
                txb1.Text = "";
                txb2.Text = "";
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txb1.Text = "";
            txb2.Text = "";
            lb_kq.Text = "";
        }
    }
}
