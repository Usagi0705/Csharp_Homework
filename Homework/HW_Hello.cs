using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Homework
{
    public partial class HW_Hello : Form
    {
        public HW_Hello()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string EngName = txtEngName.Text;
            string Gender = txtGender.Text;
            string Constellation = txtConstellation.Text;
            MessageBox.Show($"Hello,我是{Name},\n英文名字是{EngName},\n性別是{Gender},\n星座是{Constellation},\n很高興認識你。");
        }

        private void btnSayHi_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string EngName = txtEngName.Text;
            string Gender = txtGender.Text;
            string Constellation = txtConstellation.Text;
            MessageBox.Show($"HI,我是{Name},\n英文名字是{EngName},\n性別是{Gender},\n星座是{Constellation},\n很高興認識你。");
        }
    }
}
