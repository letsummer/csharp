using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private double savedValue;  // 4칙 연산자를 누르면 txtResult에 있는 값을 저장
        private bool newButton;   // 새로 숫자가 시작되어야 하는 것을 말하는 flag
        private char myOperator;  // 현재 계산할 Operator

        //int one, two, three, four, five, six, seven, eight, nine, zero = 0;
        //double sum=0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string number = btn.Text;
            if (textBox1.Text == "1" || newButton == true)
            {
                textBox1.Text = number;
                newButton = false;
            }
            else
                textBox1.Text = textBox1.Text + number;
            
            //textBox1.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string number = btn.Text;
            if (textBox1.Text == "2" || newButton == true)
            {
                textBox1.Text = number;
                newButton = false;
            }
            else
                textBox1.Text = textBox1.Text + number;
            
            //textBox1.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string number = btn.Text;
            if (textBox1.Text == "3" || newButton == true)
            {
                textBox1.Text = number;
                newButton = false;
            }
            else
                textBox1.Text = textBox1.Text + number;
            
            //textBox1.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string number = btn.Text;
            if (textBox1.Text == "4" || newButton == true)
            {
                textBox1.Text = number;
                newButton = false;
            }
            else
                textBox1.Text = textBox1.Text + number;
            
            //textBox1.Text += "4";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string number = btn.Text;
            if (textBox1.Text == "5" || newButton == true)
            {
                textBox1.Text = number;
                newButton = false;
            }
            else
                textBox1.Text = textBox1.Text + number;
            
            //textBox1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string number = btn.Text;
            if (textBox1.Text == "6" || newButton == true)
            {
                textBox1.Text = number;
                newButton = false;
            }
            else
                textBox1.Text = textBox1.Text + number;
            
            //textBox1.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string number = btn.Text;
            if (textBox1.Text == "7" || newButton == true)
            {
                textBox1.Text = number;
                newButton = false;
            }
            else
                textBox1.Text = textBox1.Text + number;
            
            //textBox1.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string number = btn.Text;
            if (textBox1.Text == "8" || newButton == true)
            {
                textBox1.Text = number;
                newButton = false;
            }
            else
                textBox1.Text = textBox1.Text + number;
            
            //textBox1.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string number = btn.Text;
            if (textBox1.Text == "9" || newButton == true)
            {
                textBox1.Text = number;
                newButton = false;
            }
            else
                textBox1.Text = textBox1.Text + number;
            
            //textBox1.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string number = btn.Text;
            if (textBox1.Text == "0" || newButton == true)
            {
                textBox1.Text = number;
                newButton = false;
            }
            else
                textBox1.Text = textBox1.Text + number;
            
            //textBox1.Text += "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            savedValue = double.Parse(textBox1.Text);// string의 첫번째 요소 값
            myOperator = btn.Text[0];
            newButton = true;
            
            //textBox1.Text += "+";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            savedValue = double.Parse(textBox1.Text);
            myOperator = btn.Text[0];
            
            //textBox1.Text += "-";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            savedValue = double.Parse(textBox1.Text);
            myOperator = btn.Text[0];
            
            //textBox1.Text += "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            savedValue = double.Parse(textBox1.Text);
            myOperator = btn.Text[0];
            
            //textBox1.Text += "/";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            // 저장했던 값과 지금 txtResult에 있는 값을 계산해 준다
            if (myOperator == '+')
                textBox1.Text = (savedValue + double.Parse(textBox1.Text)).ToString();
            else if (myOperator == '-')
                textBox1.Text = (savedValue - double.Parse(textBox1.Text)).ToString();
            else if (myOperator == '*')
                textBox1.Text = (savedValue * double.Parse(textBox1.Text)).ToString();
            else if (myOperator == '/')
                textBox1.Text = (savedValue / double.Parse(textBox1.Text)).ToString();
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
