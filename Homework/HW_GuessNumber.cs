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

        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int Answer = r.Next(1, 100);
            MessageBox.Show($"Answer：{Answer}");
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            HW_GuessNumber_Subform Subform = new HW_GuessNumber_Subform(this);
            Subform.Show();
        }
    }
}
