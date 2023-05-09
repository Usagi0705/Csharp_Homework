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
    public partial class HW_DrawPaint : Form
    {
        Graphics g;
        Pen pen;
        bool isMouseDown = false;
        List <Point> points = new List<Point>();

        public HW_DrawPaint()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            pen = new Pen(Color.Black, 3);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            //cd.AllowFullOpen = true;
            cd.Color = panColor.BackColor;
            cd.FullOpen = true;
            cd.AnyColor = true;

            if (cd.ShowDialog() == DialogResult.OK)
            {
                panColor.BackColor = cd.Color;
                pen.Color = cd.Color;
            }    
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            int Value = trackBar.Value;
            labTrackBar.Text = Convert.ToString(Value);
            pen.Width = Value;
        }

        private void HW_DrawPaint_Load(object sender, EventArgs e)
        {
            panColor.BackColor = Color.Black;
        }

        private void HW_DrawPaint_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            points.Add(e.Location);
        }

        private void HW_DrawPaint_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                points.Add(e.Location);
                g.DrawLine(pen, points[points.Count - 2], points[points.Count - 1]);
            }
        }

        private void HW_DrawPaint_MouseUp(object sender, MouseEventArgs e)
        {
            points.Add(new Point(-1, -1));
            isMouseDown = false;
        }
    }
}
