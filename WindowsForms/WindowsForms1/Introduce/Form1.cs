using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introduce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 1;
        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("yêu cầu của bạn đã được chấp nhận lần " + i);
            i++;
        }
        int j = 1;
        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("yêu cầu của bạn đã bị từ chối lần " + j);
            j++;
        }
        int l = 1;
        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bạn đã click vào form lần thứ " + l);
            l++;
        }
    }
}
