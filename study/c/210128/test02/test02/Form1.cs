using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void test_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Trim 공백 제거 해주는 함수
            if ((test.Text).Trim().Length>0)
            {
                MessageBox.Show(test.Text);
            }
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("mouseLeave...");
        }

    }
}
