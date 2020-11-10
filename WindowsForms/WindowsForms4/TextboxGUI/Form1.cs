using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextboxGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (Int32.TryParse(tb5.Text, out num))
            {
                tb5.Text = (2020 - num).ToString();
            }
            else
            {
                tb5.Text = "Vui lòng nhập số !!";
            }
            lbValue.Text = tb1.Text + "\n" + tb2.Text + "\n" + tb3.Text + "\n" + tb4.Text + "\n" + tb5.Text + " tuổi";
        }

        private void tb6_TextChanged(object sender, EventArgs e)
        {
            /*int num = 0;
            if (Int32.TryParse(tbValue.Text, out num))
            {
                if (num % 2 != 0)
                {
                    lbValue.Text = (num + num).ToString();
                }
                else
                {
                    lbValue.Text = (num * num).ToString();
                }
            }
            else
            {
                lbValue.Text = "Vui lòng nhập số !!";
            }*/
        }
    }
}
