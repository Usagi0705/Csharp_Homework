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
        Random RandomNumber = new Random();
        int GuessNumber;

        private void CheckAnswer()
        {
            int Answer = RandomNumber.Next(1,100);
            if (GuessNumber == Answer)
                MessageBox.Show($"Congradulations!!!You got{Answer}!!!");
            else if (GuessNumber < Answer && Answer < 100)
                MessageBox.Show($"Too Small!!\nBetween {GuessNumber} and 100");
            else if (GuessNumber > Answer)
                MessageBox.Show($"Too Large!!\nBetween  and ");
        }
        //todo
        //if Answer 65
        //T1:45 -->too small between 45 and 100
        //T2:70 -->too large between 45 and 70
        //T3:60 -->too small between 60 and 70
        //T4:65 -->GOT


        public HW_GuessNumber_Subform()
        {
            InitializeComponent(); 
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            RandomNumber.Next(0, 100);
        }
    }
}
