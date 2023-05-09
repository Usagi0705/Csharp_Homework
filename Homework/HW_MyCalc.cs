using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class MyCalc : Form
    {
        public MyCalc()
        {
            InitializeComponent();
        }

        decimal Num1;
        decimal Num2;

        private bool isNum()
        {
            bool isNum1 = decimal.TryParse(txtNum1.Text, out Num1);
            bool isNum2 = decimal.TryParse(txtNum2.Text, out Num2);
            return isNum1 && isNum2;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (isNum())
            {
                string Answer = (Num1 + Num2).ToString();
                labAnswer.Text = Answer;
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (isNum())
            {
            string Answer = (Num1 - Num2).ToString();
            labAnswer.Text = Answer;
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void bntCross_Click(object sender, EventArgs e)
        {
            if (isNum())
            {
            string Answer = (Num1 * Num2).ToString();
            labAnswer.Text = Answer;
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (isNum())
            {
                try
                {
                    string Answer = (Num1 / Num2).ToString();
                    labAnswer.Text = Answer;
                }
                catch(DivideByZeroException)
                {
                    labAnswer.Text = "∞";
                }
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }
    }
}
