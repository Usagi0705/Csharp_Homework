using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Homework
{
    public partial class HW_Alarm : Form
    {
        System.Timers.Timer timer;
        public HW_Alarm()
        {
            InitializeComponent();
        }

        private void HW_Alarm_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer1.Start();
        }
        delegate void UpdateLable(Label lab, string value);
        void UpdateDataLable(Label lab, string value)
        {
            lab.Text = value;
        }
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            DateTime CurrentTime = DateTime.Now;
            DateTime UserTime = dateTimePicker.Value;
            if (CurrentTime.Hour == UserTime.Hour && CurrentTime.Minute == UserTime.Minute && CurrentTime.Second == UserTime.Second)
            {
                timer.Stop();
                MessageBox.Show("!!!!!!");
                try
                {
                    UpdateLable upd = UpdateDataLable;
                    if (labStatus.InvokeRequired)
                        Invoke(upd, labStatus, "Stop");
                    SoundPlayer Player = new SoundPlayer();
                    Player.SoundLocation = "C:\\Windows\\Media\\Alarm01.wav";
                    Player.PlayLooping();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Start();
            labStatus.Text = "Running...";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            labStatus.Text = "Stop";
            SoundPlayer Player = new SoundPlayer();
            Player.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labTime.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}



//// private void timer1_Tick(object sender, EventArgs e)
//{
//    DateTime datetime = DateTime.Now;
//    this.labTime.Text = datetime.ToString();
//}
