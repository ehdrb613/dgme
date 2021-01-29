using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //checkBox1.Checked = true;

            /* if (checkBox1.Checked)
             {
                 checkBox1.Checked = false;
             }
             else
             {
                 checkBox1.Checked = true;
             }*/

            Console.WriteLine("checkbox1.Checked:"+checkBox1.Checked);
            checkBox1.Checked = !checkBox1.Checked; //체크면 체크 해제 체크없으면 체크

            if (checkBox1.Checked)
            {
                MessageBox.Show("hello");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] myFruit = { "Apples", "Oranges", "Tomato" };
            checkedListBox1.Items.AddRange(myFruit);
            checkedListBox1.CheckOnClick = true; //클릭한번 만으로 체크 할수있게
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            /* if (e.NewValue == CheckState.Unchecked)
             {
                 if (checkedListBox1.CheckedItems.Count == 1)
                 {
                     //button2.Enabled = false;
                 }
             }
             else
             {
                 //button2.Enabled = true;
             }*/

            textBox1.Text += "index:" + e.Index + "," + "value : " +e.NewValue + "\r\n";
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedItems.Count>0)
            {
                string curItem = checkedListBox1.SelectedItem.ToString();
                textBox1.Text += "curItem :" + curItem + "\r\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            textBox1.Text += "selected index" + checkedListBox1.SelectedIndex + "\r\n";
            if (checkedListBox1.SelectedIndex == -1)
            {
                MessageBox.Show("hihihi");
                return;
            }

            checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] items = new string[]
            {
                "가나다","123","abc","라마바","def"
            };
            comboBox1.Items.AddRange(items);
            comboBox1.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
             

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("콤보박스에 선택한 내용이 없습니다.");
                return;
            }

            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.naver.com/");
            System.Diagnostics.Process.Start(@"C:\Users\KB\Desktop\Microsoft PowerPoint 2010.lnk");//@ : \ 두개 안써도 됨
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for(int i = 0; i<checkedListBox1.CheckedIndices.Count; i++)
            {
                textBox1.Text += "" + checkedListBox1.CheckedItems[i] + "\r\n";
            }
        }
    }
}
