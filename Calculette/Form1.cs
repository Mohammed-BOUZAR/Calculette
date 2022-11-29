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
        string op;
        float num;
        string exp;

        public Form1()
        {
            InitializeComponent();
            op = string.Empty;
            num = 0;
            exp = string.Empty;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            textInput.Text += "1";
            lblRs.Text = textInput.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            textInput.Text += "2";
            lblRs.Text = textInput.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            textInput.Text += "3";
            lblRs.Text = textInput.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            textInput.Text += "4";
            lblRs.Text = textInput.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            textInput.Text += "5";
            lblRs.Text = textInput.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            textInput.Text += "6";
            lblRs.Text = textInput.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            textInput.Text += "7";
            lblRs.Text = textInput.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            textInput.Text += "8";
            lblRs.Text = textInput.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            textInput.Text += "9";
            lblRs.Text = textInput.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            textInput.Text += "0";
            lblRs.Text = textInput.Text;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            textInput.Text += ".";
            lblRs.Text = textInput.Text;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if( op == "+")
            {
                num += float.Parse(textInput.Text);
                textInput.Text = string.Empty;
            }
            if (op == "/")
            {
                num /= float.Parse(textInput.Text);
                textInput.Text = string.Empty;
            }
            if (op == "*")
            {
                num *= float.Parse(textInput.Text);
                textInput.Text = string.Empty;
            }
            if (op == "-")
            {
                num -= float.Parse(textInput.Text);
                textInput.Text = string.Empty;
            }

            lblRs.Text = num.ToString();
            op = string.Empty;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textInput.Text = String.Empty;
            lblRs.Text = String.Empty;
            num = 0;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //textInput.Focus();
            textInput.Text = textInput.Text.Remove(textInput.Text.Length-1,1);
            lblRs.Text = lblRs.Text.Remove(lblRs.Text.Length-1,1);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            //textInput.Text += "+";
            if (op == "+")
            {
                num += float.Parse(textInput.Text);
                textInput.Text = string.Empty;
            }
            if (op == "/")
            {
                num /= float.Parse(textInput.Text);
                textInput.Text = string.Empty;
            }
            if (op == "*")
            {
                num *= float.Parse(textInput.Text);
                textInput.Text = string.Empty;
            }
            if (op == "-")
            {
                num -= float.Parse(textInput.Text);
                textInput.Text = string.Empty;
            }
            if (op == String.Empty)
                num = float.Parse(textInput.Text);
            op = "+";
            textInput.Text = String.Empty;
            lblRs.Text = num.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            //textInput.Text += "-";
            if (op == "+")
            {
                num += float.Parse(textInput.Text);
                textInput.Text = string.Empty;
            }
            if (op == "/")
            {
                num /= float.Parse(textInput.Text);
                textInput.Text = string.Empty;
            }
            if (op == "*")
            {
                num *= float.Parse(textInput.Text);
                textInput.Text = string.Empty;
            }
            if (op == "-")
            {
                num -= float.Parse(textInput.Text);
                textInput.Text = string.Empty;
            }
            if (op == String.Empty)
                num = float.Parse(textInput.Text);
            op = "-";
            textInput.Text = String.Empty;
            lblRs.Text = num.ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            //textInput.Text += "*";
            if (op == "+")
            {
                num += float.Parse(textInput.Text);
                textInput.Text = string.Empty;
            }
            if (op == "/")
            {
                num /= float.Parse(textInput.Text);
                textInput.Text = string.Empty;
            }
            if (op == "*")
            {
                num *= float.Parse(textInput.Text);
                textInput.Text = string.Empty;
            }
            if (op == "-")
            {
                num -= float.Parse(textInput.Text);
                textInput.Text = string.Empty;
            }
            if (op == String.Empty)
                num = float.Parse(textInput.Text);
            op = "*";
            textInput.Text = String.Empty;
            lblRs.Text = num.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            //textInput.Text += "/";
            if (op == "+")
            {
                num += float.Parse(textInput.Text);
                textInput.Text = string.Empty;
            }
            if (op == "/")
            {
                num /= float.Parse(textInput.Text);
                textInput.Text = string.Empty;
            }
            if (op == "*")
            {
                num *= float.Parse(textInput.Text);
                textInput.Text = string.Empty;
            }
            if (op == "-")
            {
                num -= float.Parse(textInput.Text);
                textInput.Text = string.Empty;
            }
            if (op == String.Empty)
                num = float.Parse(textInput.Text);
            op = "/";
            textInput.Text = String.Empty;
            lblRs.Text = num.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textInput.Focus();
            if (e.KeyChar == (char)Keys.Back)
            {
                textInput.Text = textInput.Text.Remove(textInput.Text.Length - 1, 1);
                lblRs.Text = lblRs.Text.Remove(lblRs.Text.Length - 1, 1);
            }
            
            if (e.KeyChar == '1')
            {
                lblRs.Text += '1';
            }
            if (e.KeyChar == '2')
            {
                lblRs.Text += '2';
            }
            if (e.KeyChar == '3')
            {
                lblRs.Text += '3';
            }
            if (e.KeyChar == '4')
            {
                lblRs.Text += '4';
            }
            if (e.KeyChar == '5')
            {
                lblRs.Text += '5';
            }
            if (e.KeyChar == '6')
            {
                lblRs.Text += '6';
            }
            if (e.KeyChar == '7')
            {
                lblRs.Text += '7';
            }
            if (e.KeyChar == '8')
            {
                lblRs.Text += '8';
            }
            if (e.KeyChar == '9')
            {
                lblRs.Text += '9';
            }
            if (e.KeyChar == '0')
            {
                lblRs.Text += '0';
            }
            if (e.KeyChar == '.')
            {
                lblRs.Text += '.';
            }

            if (e.KeyChar == '+')
            {
                num += float.Parse(textInput.Text);
                textInput.Text = string.Empty;
                lblRs.Text = string.Empty;
                e.Handled = true;
                op = "+";
            }
            if (e.KeyChar == '-')
            {
                num -= float.Parse(textInput.Text);
                textInput.Text = string.Empty;
                lblRs.Text = num.ToString();
                e.Handled = true;
                op = "-";
            }
            if (e.KeyChar == '*')
            {
                num *= float.Parse(textInput.Text);
                textInput.Text = string.Empty;
                lblRs.Text = string.Empty;
                e.Handled = true;
                op = "*";
            }
            if (e.KeyChar == '/')
            {
                num /= float.Parse(textInput.Text);
                textInput.Text = string.Empty;
                lblRs.Text = string.Empty;
                e.Handled = true;
                op = "/";
            }
            if (e.KeyChar == '=')
            {
                if (op == "+")
                {
                    num += float.Parse(textInput.Text);
                    textInput.Text = string.Empty;
                }
                if (op == "/")
                {
                    num /= float.Parse(textInput.Text);
                    textInput.Text = string.Empty;
                }
                if (op == "*")
                {
                    num *= float.Parse(textInput.Text);
                    textInput.Text = string.Empty;
                }
                if (op == "-")
                {
                    num -= float.Parse(textInput.Text);
                    textInput.Text = string.Empty;
                }

                lblRs.Text = num.ToString();
                e.Handled = true;
            }
        }
    }
}
