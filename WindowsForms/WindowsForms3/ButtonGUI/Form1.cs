using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        void addButton()
        {
            Random ran = new Random();
            Button btn = new Button() { Text = i.ToString() , Location = new Point(ran.Next(0,100) , ran.Next(0,100)) };
            // random theo tọa độ của form -> Location = new Point(ran.Next(0,this.Size.Width) , ran.Next(0,this.Size.Height))

            // khởi tạo giá trị như phía trên hoặc tạo giá trị trực tiếp -> btn.Text = "Hello My World";
            btn.Click += Btn_Click;
            this.Controls.Add(btn);
            i++;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show(btn.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addButton();
        }
    }
}
