using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculette
{
    public partial class Form1 : Form
    {
        String op;
        float num;
        String num1;

        public Form1()
        {
            InitializeComponent();
            op = "";
            num = 0;
            num1 = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(textbox.Text == null))
            {
                if (op != "")
                {
                    if (op == "+")
                        num += int.Parse(num1);
                    if (op == "-")
                        num -= int.Parse(num1);
                    if (op == "/")
                        num /= int.Parse(num1);
                    if (op == "*")
                        num *= int.Parse(num1);
                }
                else
                    num += int.Parse(num1);
                op = "+";
                textbox2.Text = (num).ToString();
                num1 = "";
                textbox.Text += "+";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            num1 += "1";
            if (textbox.Text == null)
                textbox.Text = "1";
            else
                textbox.Text += "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            num1 += "2";
            if (textbox.Text == null)
                textbox.Text = "2";
            else
                textbox.Text += "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (num1 != "")
            {
                if (op != "")
                {
                    if (op == "+")
                        num += int.Parse(num1);
                    if (op == "-")
                        num -= int.Parse(num1);
                    if (op == "/")
                        num /= int.Parse(num1);
                    if (op == "*")
                        num *= int.Parse(num1);
                }
                else
                    num /= int.Parse(num1);
                op = "/";
                textbox2.Text = (num).ToString();
                num1 = "";
                textbox.Text += "/";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (num1 != "")
            {
                if (op != "")
                {
                    if (op == "+")
                        num += int.Parse(num1);
                    if (op == "-")
                        num -= int.Parse(num1);
                    if (op == "/")
                        num /= int.Parse(num1);
                    if (op == "*")
                        num *= int.Parse(num1);
                }
                else
                    num *= int.Parse(num1);
                op = "*";
                textbox2.Text = (num).ToString();
                num1 = "";
                textbox.Text += "x";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (num1 != "")
            {
                if (op != "")
                {
                    if (op == "+")
                        num += int.Parse(num1);
                    if (op == "-")
                        num -= int.Parse(num1);
                    if (op == "/")
                        num /= int.Parse(num1);
                    if (op == "*")
                        num *= int.Parse(num1);
                }
                else
                    num = int.Parse(num1);
                op = "-";
                textbox2.Text = (num).ToString();
                num1 = "";
                textbox.Text += "-";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            num1 += "3";
            if (textbox.Text == null)
                textbox.Text = "3";
            else
                textbox.Text += "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            num1 += "4";
            if (textbox.Text == null)
                textbox.Text = "4";
            else
                textbox.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            num1 += "5";
            if (textbox.Text == null)
                textbox.Text = "5";
            else
                textbox.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            num1 += "6";
            if (textbox.Text == null)
                textbox.Text = "6";
            else
                textbox.Text += "6";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            num1 += "7";
            if (textbox.Text == null)
                textbox.Text = "7";
            else
                textbox.Text += "7";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num1 += "8";
            if (textbox.Text == null)
                textbox.Text = "8";
            else
                textbox.Text += "8";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            num1 += "9";
            if (textbox.Text == null)
                textbox.Text = "9";
            else
                textbox.Text += "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num1 += "0";
            if (textbox.Text == null)
                textbox.Text = "0";
            else
                textbox.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textbox.Text = "";
            textbox2.Text = "";
            num = 0;
            num1 = "";
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            
                if (op != "")
                {
                    if (op == "+")
                        num += int.Parse(num1);
                    if (op == "-")
                        num -= int.Parse(num1);
                    if (op == "/")
                        num /= int.Parse(num1);
                    if (op == "*")
                        num *= int.Parse(num1);
                }
                else
                    num = int.Parse(num1);
                textbox2.Text = (num).ToString();
                textbox.Text = (num).ToString();
                num1 = (num).ToString();
                op = "";
            
        }
    }
}
