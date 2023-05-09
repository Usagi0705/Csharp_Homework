using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class HW_XOGame : Form
    {
        bool turn = true; //true = X turn, false = O turn
        int turn_count = 0;

        public HW_XOGame()
        {
            InitializeComponent();
        }


        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(turn)
                b.Text = "X";
            else 
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turn_count++;

            checkForWinner();
        }

        private void checkForWinner()
        {
            bool there_is_a_winner = false;

            //horizontal checks
            if (A1.Text == A2.Text && A2.Text == A3.Text && !A1.Enabled)
                there_is_a_winner = true;
            else if (B1.Text == B2.Text && B2.Text == B3.Text && !B1.Enabled)
                there_is_a_winner = true;
            else if (C1.Text == C2.Text && C2.Text == C3.Text && !C1.Enabled)
                there_is_a_winner = true;

            //vertical checks
            else if (A1.Text == B1.Text && B1.Text == C1.Text && !A1.Enabled)
                there_is_a_winner = true;
            else if (A2.Text == B2.Text && B2.Text == C2.Text && !A2.Enabled)
                there_is_a_winner = true;
            else if (A3.Text == B3.Text && B3.Text == C3.Text && !A3.Enabled)
                there_is_a_winner = true;

            //diagonal checks
            else if (A1.Text == B2.Text && B2.Text == C3.Text && !A1.Enabled)
                there_is_a_winner = true;
            else if (A3.Text == B2.Text && B2.Text == C1.Text && !C1.Enabled)
                there_is_a_winner = true;


            if (there_is_a_winner)
            {
                disableButtons();

                string Winner = "";
                if (turn)
                    Winner = "O";
                else
                    Winner = "X";

                MessageBox.Show($"{Winner} Wins!");
                Reset();
            }//end if
            else
            {
                if(turn_count == 9)
                {
                    MessageBox.Show("Draw!");
                    Reset();
                }
            }


        } //end checkForWinner

        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                    btnReset.Enabled = true;
                    btnExit.Enabled = true;
                }//end foreach
            }//end try
            catch { }
        }

        //private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}

        //private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    turn = true; 
        //    turn_count = 0;

        //    try
        //    {
        //        foreach (Control c in Controls)
        //        {
        //            Button b = (Button)c;
        //            b.Enabled = true;
        //            b.Text = "";
        //        }//end foreach
        //    }//end try
        //    catch { }
        //}

        //快捷鍵
        private void HW_XOGame_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.btnExit_Click(sender, e);
            }
            if(e.KeyCode == Keys.R)
            {
                this.btnReset_Click(sender, e);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Reset()
        {
            turn = true;
            turn_count = 0;
            A1.Enabled = true;
            A2.Enabled = true;
            A3.Enabled = true;
            B1.Enabled = true;
            B2.Enabled = true;
            B3.Enabled = true;
            C1.Enabled = true;
            C2.Enabled = true;
            C3.Enabled = true;
            A1.Text = "";
            A2.Text = "";
            A3.Text = "";
            B1.Text = "";
            B2.Text = "";
            B3.Text = "";
            C1.Text = "";
            C2.Text = "";
            C3.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
          Reset();
        }
    }
}
