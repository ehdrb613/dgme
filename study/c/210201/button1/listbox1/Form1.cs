using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace listbox1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label2.Text = textBox2.Text;
                listBox1.Items.Add(textBox2.Text);
                listBox2.Items.Add(textBox2.Text);
                textBox2.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("두번째");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("목록에 선택된 내용이 없습니다.");
            }
            else
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox2.SelectedIndex == -1)
            {
                MessageBox.Show("목록에 선택된 내용이 없습니다.");
            }
            else
            {
                listBox3.Items.Add(listBox2.SelectedItem);
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex == -1)
            {
                MessageBox.Show("목록에 선택된 내용이 없습니다.");
            }
            else
            {
                listBox2.Items.Add(listBox3.SelectedItem);
                listBox3.Items.RemoveAt(listBox3.SelectedIndex);
            }
        }
    }
}
