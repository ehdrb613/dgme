using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace listbox2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem subitem = new ListViewItem();
            subitem.Text = textBox1.Text;
            listView1.Items.Add(subitem);
            subitem.SubItems.Add(textBox2.Text);
            subitem.SubItems.Add(textBox3.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices == -1) { 
                listView1.Items.Remove(listView1.SelectedIndices(1));
            }
        }
    }
}
