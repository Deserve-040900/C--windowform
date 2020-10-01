using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            lb1.Text = "Just close your eyes";
        }

        private void lb1_Click(object sender, EventArgs e)
        {
            lb1.Text = "You can be king again";
        }
        int i = 0;
        private void lb2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            //thuộc tính Show tạo thành các form riêng biệt, có thể thao tác trên cả 2 form
            f.Show();
            if (i % 2 == 0)
            {
                f.lb3.Text = "i always been the kind of girl that hide my face";
            }
            i++;
            //thuộc tính ShowDialog tạo 1 dialog nằm trên form, tắt dialog mới tắt form đc
            //f.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
