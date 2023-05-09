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
    public partial class HW_Loan : Form
    {
        public HW_Loan()
        {
            InitializeComponent();
        }
            //本息平均攤還法
            //試算公式：       平均每月應攤付本金金額＝貸款本金÷還款總月數
            //        (公式中：還款總月數＝貸款年期×12)
            //每月應攤還本金與利息試算：
            //每月應付本息金額＝每月應還本金＋每月應付利息
            //每月應付利息金額＝本金餘額×月利率
            //(公式中：月利率＝年利率÷1

        private void btnMonth_Click(object sender, EventArgs e)
        {
            int LoanPrice = Convert.ToInt32(txtAmount.Text);
            int Period = Convert.ToInt32(txtYear.Text);
            float Rate = Convert.ToSingle(txtRate.Text) / 1200;
            int FirstPay = Convert.ToInt32(txtFirstPay.Text);
            float Percentage = 1 + Rate;
            float RateDividend = (float)(Math.Pow(Percentage, Period * 12)) * Rate;
            float RatedDivisor = (float)(Math.Pow(Percentage, Period * 12)) - 1;
            float MonthRate = RateDividend / RatedDivisor;
            int PMT = Convert.ToInt32((LoanPrice - FirstPay) * MonthRate);
            int Total = PMT * Period * 12;

            MessageBox.Show($"月付額: {PMT} 元");
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            int LoanPrice = Convert.ToInt32(txtAmount.Text);
            int Period = Convert.ToInt32(txtYear.Text);
            float Rate = Convert.ToSingle(txtRate.Text) / 1200;
            int FirstPay = Convert.ToInt32(txtFirstPay.Text);
            float Percentage = 1 + Rate;
            float RateDividend = (float)(Math.Pow(Percentage, Period * 12)) * Rate;
            float RatedDivisor = (float)(Math.Pow(Percentage, Period * 12)) - 1;
            float MonthRate = RateDividend / RatedDivisor;
            int PMT = Convert.ToInt32((LoanPrice - FirstPay) * MonthRate);
            int Total = PMT * Period * 12;

            MessageBox.Show($"總付款: {Total} 元");

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            HW_Loan_Report Report = new HW_Loan_Report();
            Report.Show();
            Report.labAmount2.Text = txtAmount.Text;
            Report.labYear2.Text = txtYear.Text;
            Report.labRate2.Text = txtRate.Text;

            int LoanPrice = Convert.ToInt32(txtAmount.Text);
            int Period = Convert.ToInt32(txtYear.Text);
            float Rate = Convert.ToSingle(txtRate.Text) / 1200;
            int FirstPay = Convert.ToInt32(txtFirstPay.Text);
            float Percentage = 1 + Rate;
            float RateDividend = (float)(Math.Pow(Percentage, Period * 12)) * Rate;
            float RatedDivisor = (float)(Math.Pow(Percentage, Period * 12)) - 1;
            float MonthRate = RateDividend / RatedDivisor;
            int PMT = Convert.ToInt32((LoanPrice - FirstPay) * MonthRate);
            int Total = PMT * Period * 12;

            Report.labPMT2.Text = Convert.ToString(PMT);
            Report.labTotal2.Text = Convert.ToString(Total);

        }

        private void HW_Loan_Load(object sender, EventArgs e)
        {
            txtAmount.Text = "100000";
            txtYear.Text = "2";
            txtRate.Text = "10";
            txtFirstPay.Text = "0";
        }
    }
}
