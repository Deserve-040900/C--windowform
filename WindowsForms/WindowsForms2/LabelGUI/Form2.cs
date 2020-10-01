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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            LoadLabel();
        }
        void LoadLabel()
        {
            Label lb = new Label();
            lb.Text = "P'Gulf lak P'Mew may kha";
            this.Controls.Add(lb);

            lb.BackColor = Color.Red;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
