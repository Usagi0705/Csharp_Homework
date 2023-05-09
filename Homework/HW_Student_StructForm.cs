using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Homework
{
    public partial class HW_Student_StructForm : Form
    {
        public HW_Student_StructForm()
        {
            InitializeComponent();
        }
        //private bool isNum()
        //{
        //    int Chi, Eng, Math;
        //    bool isNum1 = int.TryParse(txtChi.Text,out Chi);
        //    bool isNum2 = int.TryParse(txtEng.Text,out Eng);
        //    bool isNum3 = int.TryParse(txtMath.Text,out Math);
        //    return isNum1 && isNum2 && isNum3;
        //}
        string ResultName,ResultChi, ResultEng, ResultMath;

        private void HW_Student_StructForm_Load(object sender, EventArgs e)
        {
            txtName.Text = "0";
            txtChi.Text = "0";
            txtEng.Text = "0";
            txtMath.Text = "0";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isNum1 = int.TryParse(txtChi.Text,out int Chi);
            bool isNum2 = int.TryParse(txtEng.Text,out int Eng);
            bool isNum3 = int.TryParse(txtMath.Text, out int Math);

            if (isNum1 && isNum2 && isNum3)
            {
                Chi = Convert.ToInt32(txtChi.Text);
                Eng = Convert.ToInt32(txtEng.Text);
                Math = Convert.ToInt32(txtMath.Text);
            }  
            else
                MessageBox.Show("請輸入數值");
     
            //Eng = Convert.ToInt32(txtEng.Text);
            //Math = Convert.ToInt32(txtMath.Text);
            //Result += Chi + Eng + Math;
            //else(int.TryParse(txtChi.Text, out Chi)== false;

            ResultName = txtName.Text;
            ResultChi = txtChi.Text;
            ResultEng = txtEng.Text;
            ResultMath = txtMath.Text;
        }
        
        //存result

        private void btnDisplaySave_Click(object sender, EventArgs e)
        {
            labName.Text = $"姓名：{ResultName}";
            labChi.Text = $"國文：{ResultChi}";
            labEng.Text = $"英文：{ResultEng}";
            labMath.Text = $"數學：{ResultMath}";
        }
        //讀result

        private void btnhsls_Click(object sender, EventArgs e)
        {   //可以使用陣列來做
            int Chi = Convert.ToInt32(ResultChi);
            int Eng = Convert.ToInt32(ResultEng);
            int Math = Convert.ToInt32(ResultMath);
            if (Chi > Eng && Chi > Math)
                labHighScore.Text = $"最高科目成績為：國文{ResultChi}分";
            if (Chi < Eng && Chi < Math)
                labLowScore.Text = $"最低科目成績為：國文{ResultChi}分";
            if (Chi == Eng && Chi < Math)
                labLowScore.Text = $"最低科目成績為：國文{ResultChi}分 英文{ResultEng}分";
            if (Chi == Eng && Chi > Math)
                labHighScore.Text = $"最高科目成績為：國文{ResultChi}分 英文{ResultEng}分";
            if (Math > Eng && Math > Chi)
                labHighScore.Text = $"最高科目成績為：數學{ResultMath}分";
            if (Math == Eng && Math > Chi)
                labHighScore.Text = $"最高科目成績為：數學{ResultMath}分 英文{ResultEng}分";
            if (Math == Eng && Math < Chi)
                labLowScore.Text = $"最低科目成績為：數學{ResultMath}分 英文{ResultEng}分";
            if (Chi == Math && Chi < Eng)
                labLowScore.Text = $"最低科目成績為：國文{ResultChi}分 數學{ResultMath}分";
            if (Chi == Math && Chi < Eng)
                labHighScore.Text = $"最高科目成績為：國文{ResultChi}分 數學{ResultMath}分";
            if (Math < Eng && Math < Chi)
                labLowScore.Text = $"最低科目成績為：數學{ResultMath}分";
            if(Eng > Chi && Eng > Chi)
                labHighScore.Text = $"最高科目成績為：英文{ResultEng}分";
            if(Eng < Chi && Eng < Math)
                labLowScore.Text = $"最低科目成績為：英文{ResultEng}分";
            if (Eng == Chi && Chi== Math)
            {
                labHighScore.Text = $"最高科目成績為：國文{ResultChi}分 英文{ResultEng}分 數學{ResultMath}分";
                labLowScore.Text = $"最低科目成績為：國文{ResultChi}分 英文{ResultEng}分 數學{ResultMath}分";
            }
        }
    }
}
