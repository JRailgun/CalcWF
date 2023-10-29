using System;
using System.Windows.Forms;

namespace ТП1__2_
{
    public partial class Form1 : Form
    {
        public string action;
        public string num1;
        public bool flag_action;
        public bool flag_res;
        public Form1()
        {
            flag_res = false;
            flag_action = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (flag_action || flag_res)
            {
                flag_res = false;
                flag_action = false;
                button10.Enabled = true;
                textBox1.Text = "0";
            }
            Button B = (Button)sender;
            if (textBox1.Text == "0")
            {
                textBox1.Text = B.Text;
            }
            else
            {
                textBox1.Text += B.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("Ошибка"))
            {
                textBox1.Text = "0";
            }
            else
            {
                if (flag_res)
                {
                    button10.Enabled = false;
                }
                else if (flag_res == false)
                {                   
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                    if (textBox1.Text == "")
                    {
                        textBox1.Text = "0";
                    }
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(",") && textBox1.Text != "Ошибка")
            {
                textBox1.Text += ",";
            }    
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double dnum1, dnum2, res;
            res = 0;
            dnum1 = Convert.ToDouble(num1);
            dnum2 = Convert.ToDouble(textBox1.Text);
            if (action == "+")
            {
                res = dnum1 + dnum2;
            }
            if (action == "-")
            {
                res = dnum1 - dnum2;
            }
            if (action == "*")
            {
                res = dnum1 * dnum2;
            }
            if (action == "/")
            {
                res = dnum1 / dnum2;
            }
            action = "=";
            flag_action = true;
            if (double.IsInfinity(res) || double.IsNaN(res))
            {
                textBox1.Text = "Ошибка";
            }
            else
            {
                textBox1.Text = res.ToString();
            }
            flag_res = true;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void Form1_Click_1(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            action = B.Text;
            if(textBox1.Text == "Ошибка")
            {
                textBox1.Text = "0";
            }    
            num1 = textBox1.Text;
            flag_action = true;
            flag_res = true;
        }
    }
}
