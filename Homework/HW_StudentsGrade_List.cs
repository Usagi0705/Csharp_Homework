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
    public partial class HW_StudentsGrade_List : Form
    {
        public HW_StudentsGrade_List()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            int Chi = Convert.ToInt32(txtChi.Text);
            int Eng = Convert.ToInt32(txtEng.Text);
            int Math = Convert.ToInt32(txtMath.Text);
            string result = $"Name {Chi}    {Eng}    {Math}";
        }
    }
}
