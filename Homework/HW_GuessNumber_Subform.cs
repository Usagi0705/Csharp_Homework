using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class HW_GuessNumber_Subform : Form
    {
        public HW_GuessNumber_Subform(HW_GuessNumber Parentform)
        {
            InitializeComponent(); 
            this.Tag = Parentform;
        }

        int Answer,min,max;
        Random r = new Random();

        internal void btnEnter_Click(object sender, EventArgs e)
        {    
            if(Answer == 0)
            {
                Answer = r.Next(1,100);
                min = 1;
                max = 100;
            }
            bool isNum = int.TryParse(txtNumber.Text, out int Guess);
            if (isNum)
            {
                Guess = Convert.ToInt32(txtNumber.Text);
                {
                    if (Guess == Answer)
                        MessageBox.Show($"Congradulations!!!You got {Answer}!!!");
                    else if (Guess > Answer)
                    {
                        max = Guess;
                        ((HW_GuessNumber)this.Tag).labSelectNumber.Text = $"Too Big!!! Between {min} and {max}";
                    }
                    else if (Guess < Answer)
                    {
                        min = Guess;
                        ((HW_GuessNumber)this.Tag).labSelectNumber.Text = $"Too Small!!!Between {min} and {max}";
                    }
                    else
                        MessageBox.Show($"請輸入{min}-{max}之間的數字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);        
                }
            }
            else
                MessageBox.Show($"請輸入{min}-{max}之間的數字","錯誤",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
