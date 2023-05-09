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
    public partial class HW_GuessNumber : Form
    {
        public HW_GuessNumber()
        {
            InitializeComponent();
        }

        int guess,count,min,max;

        private void btnGuess_Click(object sender, EventArgs e)
        {

        }

        private void HW_GuessNumber_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            guess = r.Next(1,100);
            min = 0;
            max = 100;
            
        }
    }
}
