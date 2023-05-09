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
    public partial class HW_ScreenSaver : Form
    {
        private const int TIMER_INTERVAL_MS = 10;
        private const int STEP_SIZE = 3;
        private bool goingRight = true;
        private bool goingDown = true;
        public HW_ScreenSaver()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 計算新的 PictureBox1 的位置
            int newX = pictureBox1.Location.X + (goingRight ? STEP_SIZE : -STEP_SIZE);
            int newY = pictureBox1.Location.Y + (goingDown ? STEP_SIZE : -STEP_SIZE);

            // 檢查是否超出螢幕邊界
            if (newX < 0)
            {
                newX = 0;
                goingRight = true;
            }
            else if (newX > (this.Width - pictureBox1.Width))
            {
                newX = this.Width - pictureBox1.Width;
                goingRight = false;
            }

            if (newY < 0)
            {
                newY = 0;
                goingDown = true;
            }
            else if (newY > (this.Height - pictureBox1.Height))
            {
                newY = this.Height - pictureBox1.Height;
                goingDown = false;
            }

            // 更新 PictureBox1 的位置
            pictureBox1.Location = new Point(newX, newY);
        }

        private void HW_ScreenSaver_Load(object sender, EventArgs e)
        {
            // 設定 ScreenSaver 的屬性
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.Black;

            // 設定 PictureBox1 的屬性
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            // 啟動 Timer
            timer1.Interval = TIMER_INTERVAL_MS;
            timer1.Enabled = true;
        }

        private void HW_ScreenSaver_KeyDown(object sender, KeyEventArgs e)
        {
            Close();
        }
    }

}
