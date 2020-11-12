using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
            //List<string> item;
            //item = new List<string>() { };
            //comboBoxKhoa.DataSource = item;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxKhoa.SelectedIndex = 0;
        }
        private int GetSelectedRow(String studentID)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (dataGridView.Rows[i].Cells[0].Value == null)
                    return -1;
                if (dataGridView.Rows[i].Cells[0].Value.ToString() == studentID)
                    return i;
            }
            return -1;
        }
        private void update(int selectRow)
        {
            dataGridView.Rows[selectRow].Cells[0].Value = txb1.Text;
            dataGridView.Rows[selectRow].Cells[1].Value = txb2.Text;
            dataGridView.Rows[selectRow].Cells[2].Value = radiobtnNu.Checked ? "Nữ" : "Nam";
            dataGridView.Rows[selectRow].Cells[3].Value = float.Parse(txb3.Text).ToString();
            dataGridView.Rows[selectRow].Cells[4].Value = comboBoxKhoa.Text;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txb1.Text == "" || txb2.Text == "" || txb3.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin sinh viên!");
                int selectRow = GetSelectedRow(txb1.Text);
                if (selectRow == -1)
                {
                    selectRow = dataGridView.Rows.Add();
                    update(selectRow);
                    MessageBox.Show("Thêm mới dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    update(selectRow);
                    MessageBox.Show("Cập nhật dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(txb1.Text);
                if (selectedRow == -1)
                    throw new Exception("Khong co sv để xóa");
                else
                {
                    DialogResult dr = MessageBox.Show("bạn có muốn xóa ?", "YES/NO", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        dataGridView.Rows.RemoveAt(selectedRow);
                        MessageBox.Show("Xóa sinh vien thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
