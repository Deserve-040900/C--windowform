using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void comboBox1_Click(object sender, EventArgs e)
        {
            //ComboBox cb = sender as ComboBox;
            //MessageBox.Show(cb.SelectedItem.ToString());
            List<string> item;
            item = new List<string>() { "Quản trị kinh doanh", "Công nghệ thông tin", "Ngôn ngữ anh" };
            comboBox1.DataSource = item;
        }
    }
}
