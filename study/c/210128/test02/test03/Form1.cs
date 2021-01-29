using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test03
{
    public partial class Form1 : Form
    {

        List<string> test = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
            textBox3.Text = sum.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if ((textBox2.Text).Trim().Length > 0) { 
            int sum = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
            textBox3.Text = sum.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((textBox2.Text).Trim().Length > 0)
            {
                if ((textBox1.Text).Trim().Length > 0) { 
                int sum = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
                textBox3.Text = sum.ToString();
                }
            }
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void num1_Click(object sender, EventArgs e)
        {
            textBox4.Text += 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void num2_Click(object sender, EventArgs e)
        {
            textBox4.Text += 2;
        }

        private void num3_Click(object sender, EventArgs e)
        {
            textBox4.Text += 3;
        }

        private void num4_Click(object sender, EventArgs e)
        {
            textBox4.Text += 4;
        }

        private void num5_Click(object sender, EventArgs e)
        {
            textBox4.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox4.Text += 6;
        }

        private void num7_Click(object sender, EventArgs e)
        {
            textBox4.Text += 7;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            textBox4.Text += 8;
        }

        private void num9_Click(object sender, EventArgs e)
        {
            textBox4.Text += 9;
        }

        private void num0_Click(object sender, EventArgs e)
        {
            textBox4.Text += 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text += "-";
            test.Add("-");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Text += '+';
            test.Add("+");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text += "/";
            test.Add("/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Text += "*";
            test.Add("*");
        }

        private void button7_Click(object sender, EventArgs e)
        {

            string[] a = textBox4.Text.Split(new char[] {'+','/','*','-'});
            
            int b = int.Parse(a[0]) ;

            
                for (int j = 0; j < test.Count; j++)
                {

                
                    if (test.Count == 1)
                    {
                        b = int.Parse(a[j]);

                        if (test[j].Equals("+"))
                        b += int.Parse(a[j+1]);

                        else if (test[j].Equals("-"))
                        b -= int.Parse(a[j+1]);

                        else if (test[j].Equals("/"))
                        b /= int.Parse(a[j+1]);

                        else if (test[j].Equals("*"))
                        b *= int.Parse(a[j+1]);
                    }

                    else if (test.Count > 1) {

                        if (test[j].Equals("+"))
                            b += int.Parse(a[j + 1]);
                        else if (test[j].Equals("-"))
                            b -= int.Parse(a[j + 1]);
                        else if (test[j].Equals("/"))
                            b /= int.Parse(a[j + 1]);
                        else if (test[j].Equals("*"))
                            b *= int.Parse(a[j + 1]);

                    }
                }

            test.Clear();
            textBox4.Text = b.ToString();

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }
    }
}
