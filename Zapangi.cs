using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZapangiForm
{
    public partial class Zapangi : Form
    {
        int coke, fanta, water, cof;
        int sum;
        private int money;
        private int t_money;
        private int c_money;
        private bool newButton = false;
        
        public Zapangi()
        {
            InitializeComponent();
            
        }

        private void btnCp_Click(object sender, EventArgs e)
        {
            int temp;
            textBox1.Text += "선택종료!"+Environment.NewLine;
            textBox1.Text += "총 "+sum+"원 입니다!" + Environment.NewLine;

            c_money = t_money-sum;
            tbChange.Text = "*거스름돈*" + Environment.NewLine;//+c_money+"원";
            
            if((c_money/500)!=0)
                tbChange.Text +="500원 " + c_money/500 + "개" + Environment.NewLine;
            
            temp = c_money % 500;

            if ((temp / 100) != 0)
                tbChange.Text += "100원 " + temp / 100 + "개" + Environment.NewLine;

            temp = temp % 100;

            if ((temp / 50) != 0)
                tbChange.Text += "50원 " + temp / 50 + "개" + Environment.NewLine;
            
            temp = temp % 50;

            if ((temp / 10) != 0)
                tbChange.Text += "10원 " + temp / 10 + "개" + Environment.NewLine;
            
            temp = temp % 10;

            MessageBox.Show("프로그램을 종료합니다.");
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ScrollBars = ScrollBars.Both;
        }

        private void btnCoke_Click(object sender, EventArgs e)
        {
            if (newButton)
            {
                coke++; sum += 600; 
                
                if (t_money > sum)
                {
                    tbDrinks.Text += "콜라" + Environment.NewLine;
                    textBox1.Text += "콜라 총 " + coke + " 개" + Environment.NewLine;
                }
                else
                {
                    textBox1.Text += "금액이 부족합니다." + Environment.NewLine;
                    sum -= 600;
                }
                c_money = t_money - sum;
                tbChange.Text = "*남은 돈*" + Environment.NewLine + c_money + "원";
            }
            else
                textBox1.Text = "금액을 먼저 투입해주세요" + Environment.NewLine;
        }

        private void btnFanta_Click(object sender, EventArgs e)
        {
            if (newButton)
            {
                fanta++; sum += 550;
                
                if (t_money >= sum)
                {
                    tbDrinks.Text += "환타" + Environment.NewLine;
                    textBox1.Text += "환타 총 " + fanta + " 개" + Environment.NewLine;
                }
                else
                {
                    textBox1.Text += "금액이 부족합니다." + Environment.NewLine;
                    sum -= 550;
                }
                c_money = t_money - sum;
                tbChange.Text = "*남은 돈*" + Environment.NewLine + c_money + "원";
            }
            else
                textBox1.Text = "금액을 먼저 투입해주세요" + Environment.NewLine;
        }

        private void btnWater_Click(object sender, EventArgs e)
        {
            if (newButton)
            {
                water++; sum += 300;
                
                if (t_money >= sum)
                {
                    tbDrinks.Text += "물" + Environment.NewLine;
                    textBox1.Text += "물 총 " + water + " 개" + Environment.NewLine;
                }
                else
                {
                    textBox1.Text += "금액이 부족합니다." + Environment.NewLine;
                    sum -= 300;
                }
                c_money = t_money - sum;
                tbChange.Text = "*남은 돈*" + Environment.NewLine + c_money + "원";
            }
            else
                textBox1.Text = "금액을 먼저 투입해주세요" + Environment.NewLine;
        }

        private void btnCof_Click(object sender, EventArgs e)
        {
            if (newButton)
            {
                cof++; sum += 450;
                
                if (t_money >= sum)
                {
                    tbDrinks.Text += "커피" + Environment.NewLine;
                    textBox1.Text += "커피 총 " + cof + " 개" + Environment.NewLine;
                }
                else
                {
                    textBox1.Text += "금액이 부족합니다." + Environment.NewLine;
                    sum -= 450;
                }
                c_money = t_money - sum;
                tbChange.Text = "*남은 돈*" + Environment.NewLine + c_money + "원";
            }
            else
                textBox1.Text = "금액을 먼저 투입해주세요" + Environment.NewLine;
        }

        private void tbMoney_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            newButton = true;
            money += Int32.Parse(tbMoney.Text);
            t_money += money;
            textBox1.Text += money + "원을 투입했습니다." + Environment.NewLine;
            
            c_money = t_money - sum;
            tbChange.Text = "*남은 돈*" + Environment.NewLine + c_money + "원";

            tbMoney.Text = "";
            money = 0;

        }

        private void tbChange_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDrinks_TextChanged(object sender, EventArgs e)
        {
            textBox1.ScrollBars = ScrollBars.Both;
        }

        private void tbMoney_Enter(object sender, EventArgs e)
        {
            if (tbMoney.Text == "금액입력")
                tbMoney.Text = "";

            tbMoney.ForeColor = Color.Black;
        }

        private void tbMoney_Leave(object sender, EventArgs e)
        {
            if (tbMoney.Text == "")
                tbMoney.Text = "금액입력";

            tbMoney.ForeColor = Color.Gray;
        }
    }
}
