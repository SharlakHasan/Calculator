﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int a;
           // a = Convert.ToInt16(num.Text)*10;
            num.Text = num.Text+"0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num.Text = num.Text + "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num.Text = num.Text + "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num.Text = num.Text + "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num.Text = num.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            num.Text = num.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            num.Text = num.Text + "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            num.Text = num.Text + "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            num.Text = num.Text + "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            num.Text = num.Text + "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            num.Text = num.Text + ".";
        }

        private void button12_Click(object sender, EventArgs e)
        {
         result.Text = "+ " + num.Text;
         num.Text = null;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double fnum , snum , ans;
            char[] spliting = { ' ' };
            string[] s1 = result.Text.Split(spliting);
            fnum = Convert.ToDouble(s1[1]);
            snum = Convert.ToDouble(num.Text);

            if (s1[0] == "+") {
                ans = fnum + snum;
            }
            else if (s1[0] == "-") {
                ans = fnum - snum;
            }
            else if(s1[0] == "*") {
                ans = fnum * snum;
            }
            else if(s1[0] == "/"){
                ans = fnum / snum;
            }  
            else
                ans = 0;
            result.Text = "= " + ans.ToString();
            num.Text = null;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            result.Text = "- " + num.Text;
            num.Text = null;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            result.Text = "* " + num.Text;
            num.Text = null;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            result.Text = "/ " + num.Text;
            num.Text = null;
        }
    }
}
