using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_clac
{
    public partial class Form1 : Form
    {
        string opreation = "";
        double result =0;
        bool isoperation =false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button zero = (Button)sender;
            if(textBox1.Text=="0" || isoperation == true)
            {
                textBox1.Clear();
            }
            if(zero.Text==".")
            { 
            if(!textBox1.Text.Contains(".") )
                {
                    textBox1.Text = textBox1.Text + zero.Text;
                }
            }
            else
            {
                textBox1.Text = textBox1.Text+ zero.Text;
            }
            isoperation = false;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button zero = (Button)sender;
            opreation = zero.Text;
            result = double.Parse(textBox1.Text);
            isoperation = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            switch(opreation)
            {

                case "+":
                    textBox1.Text= (result+double.Parse(textBox1.Text)).ToString(); 
                    break;

                case "-":
                    textBox1.Text = (result - double.Parse(textBox1.Text)).ToString();
                    break;

                case "/":
                    textBox1.Text = (result / double.Parse(textBox1.Text)).ToString();
                    break;

                case "*":
                    textBox1.Text = (result * double.Parse(textBox1.Text)).ToString();
                    break;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            result = 0;
        }
    }
}
