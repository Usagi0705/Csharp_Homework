using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Homework
{
    public partial class Homework : Form
    {
        public Homework()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();

            HW_Hello Hello = new HW_Hello();
            Hello.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(Hello);
            Hello.Show();
            //btnHello.Enabled = false;
        }

        private void btnMyCalc_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();

            MyCalc Clac = new MyCalc();
            Clac.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(Clac);
            Clac.Show();
        }

        private void btnXOGame_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();

            HW_XOGame XOGame = new HW_XOGame();
            XOGame.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(XOGame);
            XOGame.Show();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();

            HW_POS POS = new HW_POS();
            POS.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(POS);
            POS.Show();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();

            HW_Loan Loan = new HW_Loan();
            Loan.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(Loan);
            Loan.Show();
        }

        //private void btnStudentGrade_Click(object sender, EventArgs e)
        //{
        //    splitContainer2.Panel2.Controls.Clear();

        //    StudentsGrade StudentsGrade = new StudentsGrade();
        //    StudentsGrade.TopLevel = false;
        //    splitContainer2.Panel2.Controls.Add(StudentsGrade);
        //    StudentsGrade.Show();
        //}

        //private void btnStudentGradeList_Click(object sender, EventArgs e)
        //{
        //    splitContainer2.Panel2.Controls.Clear();

        //    HW_StudentsGrade_List StudentsGradeList = new HW_StudentsGrade_List();
        //    StudentsGradeList.TopLevel = false;
        //    splitContainer2.Panel2.Controls.Add(StudentsGradeList);
        //    StudentsGradeList.Show();
        //}

        private void btnStudentStructForm_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();

            HW_Student_StructForm StudentsStructForm = new HW_Student_StructForm();
            StudentsStructForm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(StudentsStructForm);
            StudentsStructForm.Show();
        }

        private void btnForDoWhile_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();

            HW_ForDoWhile ForDoWhile = new HW_ForDoWhile();
            ForDoWhile.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(ForDoWhile);
            ForDoWhile.Show();
        }

        private void btnPictureViewer_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();

            HW_PictureViewer PictureViewer = new HW_PictureViewer();
            PictureViewer.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(PictureViewer);
            PictureViewer.Show();
        }

        private void btnScreenSaver_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();

            HW_ScreenSaver ScreenSaver = new HW_ScreenSaver();
            ScreenSaver.TopLevel = true;
            //splitContainer2.Panel2.Controls.Add(ScreenSaver);
            ScreenSaver.Show();
        }

        private void btnDrawPaint_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();

            HW_DrawPaint DrawPaint = new HW_DrawPaint();
            DrawPaint.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(DrawPaint);
            DrawPaint.Show();
        }

        private void btnNotepad_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();

            HW_Notepad Notepad = new HW_Notepad();
            Notepad.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(Notepad);
            Notepad.Show();
        }

        //private void btnGuessNumber_Click(object sender, EventArgs e)
        //{
        //    splitContainer2.Panel2.Controls.Clear();

        //    HW_GuessNumber GuessNumber = new HW_GuessNumber();
        //    GuessNumber.TopLevel = false;
        //    splitContainer2.Panel2.Controls.Add(GuessNumber);
        //    GuessNumber.Show();
        //}

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();

            HW_Alarm Alarm = new HW_Alarm();
            Alarm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(Alarm);
            Alarm.Show();
        }
    }
}
