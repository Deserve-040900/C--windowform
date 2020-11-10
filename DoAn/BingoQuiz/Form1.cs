using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingoQuiz
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent(); 
            //Form2 form2 = new Form2();
            //form2.TopLevel = false;
            //this.panelChildForm.Controls.Add(form2);
            //form2.Dock = DockStyle.Fill;
            //form2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //form2.Show();
            Customize();
        }
        private void Customize()
        {
            panelMediaSubMenu.Visible = false;
            panelEqualizerSubMenu.Visible = false;
            panelToolsSubMenu.Visible = false;
        }
        private void HideSubmenu()
        {
            if(panelMediaSubMenu.Visible == true)
                panelMediaSubMenu.Visible = false;
            if (panelEqualizerSubMenu.Visible == true)
                panelEqualizerSubMenu.Visible = false;
            if (panelToolsSubMenu.Visible == true)
                panelToolsSubMenu.Visible = false;
        }
        private void ShowSubmenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                HideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelMediaSubMenu);
        }
        #region MediaSubmenu
        private void btn1_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
            HideSubmenu();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }
        #endregion
        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelEqualizerSubMenu);
        }
        #region EqualizerSubmenu
        private void button5_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }
        #endregion
        private void btnTools_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelToolsSubMenu);
        }
        #region ToolsSubmenu
        private void button9_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }
        #endregion
        private Form ActiveForm = null;
        private void openChildForm(Form childform)
        {
            if(ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActiveForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childform);
            panelChildForm.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
    }
}
