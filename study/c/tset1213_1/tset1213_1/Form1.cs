using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tset1213_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelLeft.Height = buttonDashboard.Height;
            panelLeft.Top = buttonDashboard.Top;
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonDashboard.Height;
            panelLeft.Top = buttonDashboard.Top;
        }

        private void buttonSeller_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonSeller.Height;
            panelLeft.Top = buttonSeller.Top;
        }

        private void buttonCalender_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonCalender.Height;
            panelLeft.Top = buttonCalender.Top;
        }

        private void buttonTasks_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonTasks.Height;
            panelLeft.Top = buttonTasks.Top;
        }
    }
}
