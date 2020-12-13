using System;
using System.Windows.Forms;

namespace test1213_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            firstcustom1.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            firstcustom1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            mySecondCus1.BringToFront();
        }


        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
