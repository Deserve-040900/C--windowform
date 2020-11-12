using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;

namespace bt3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Button> dsChon = new List<Button>();
        int tong = 0;
        private void choiceSeat(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            BackColor = Color.White;

            if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Blue;
                dsChon.Add(btn);
            }
            else if (btn.BackColor == Color.Blue)
            {
                btn.BackColor = Color.White;
                dsChon.Remove(btn);
            }
            else if (btn.BackColor == Color.Yellow)
                MessageBox.Show("Ghế đã được chọn");
        }
        #region seatMulti

        private void btn1_Click(object sender, EventArgs e)
        {
            choiceSeat(sender, e);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            choiceSeat(sender, e);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            choiceSeat(sender, e);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            choiceSeat(sender, e);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            choiceSeat(sender, e);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            choiceSeat(sender, e);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            choiceSeat(sender, e);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            choiceSeat(sender, e);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            choiceSeat(sender, e);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            choiceSeat(sender, e);
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            choiceSeat(sender, e);
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            choiceSeat(sender, e);
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            choiceSeat(sender, e);
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            choiceSeat(sender, e);
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            choiceSeat(sender, e);
        }
        #endregion

        private void btnChoice_Click(object sender, EventArgs e)
        {
            foreach (Button b in dsChon)
            {
                b.BackColor = Color.Yellow;
                if (float.Parse(b.Text.ToString()) <= 5)
                    tong += 5000;
                else if (float.Parse(b.Text.ToString()) <= 10)
                    tong += 6500;
                else
                    tong += 8000;

            }
            txbThanhToan.Text = tong.ToString();
            txbThanhToan.Text = "";
            dsChon = new List<Button>();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach (Button b in dsChon)
            {
                b.BackColor = Color.White;
                txbThanhToan.Text = "";
            }
            dsChon = new List<Button>();
        }
    }
}
