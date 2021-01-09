using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        decimal num1, num2, num3, result;
        string operate = "";
        bool isOperand = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + "-";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (operate.Length > 0)
            {
                textBox1.Text = "";
                isOperand = false;
            }
            textBox1.Text += "1";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text += textBox1.Text + "+";
            num1 = decimal.Parse(textBox1.Text);
            operate = "+";
            isOperand = true;
        }
       
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Text += textBox1.Text + "=";
            num2 = decimal.Parse(textBox1.Text);
            if (operate == "+") ;
            {
                num3 = num1 + num2;
                textBox1.Text = num3.ToString();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + "/";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + "x";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text)) 
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            else
            {
                MessageBox.Show("ลบบ่ได้แล้ว");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
