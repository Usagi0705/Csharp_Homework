namespace Homework
{
    partial class HW_DrawPaint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panColor = new System.Windows.Forms.Panel();
            this.btnColor = new System.Windows.Forms.Button();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.labTrackBar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panColor
            // 
            this.panColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panColor.Location = new System.Drawing.Point(695, 102);
            this.panColor.Name = "panColor";
            this.panColor.Size = new System.Drawing.Size(50, 50);
            this.panColor.TabIndex = 0;
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(683, 54);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 31);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "顏色";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(700, 167);
            this.trackBar.Maximum = 100;
            this.trackBar.Minimum = 1;
            this.trackBar.Name = "trackBar";
            this.trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar.Size = new System.Drawing.Size(45, 163);
            this.trackBar.TabIndex = 2;
            this.trackBar.Value = 1;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // labTrackBar
            // 
            this.labTrackBar.AutoSize = true;
            this.labTrackBar.Location = new System.Drawing.Point(712, 333);
            this.labTrackBar.Name = "labTrackBar";
            this.labTrackBar.Size = new System.Drawing.Size(11, 12);
            this.labTrackBar.TabIndex = 3;
            this.labTrackBar.Text = "1";
            // 
            // HW_DrawPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labTrackBar);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.panColor);
            this.Name = "HW_DrawPaint";
            this.Text = "DrawPaint";
            this.Load += new System.EventHandler(this.HW_DrawPaint_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HW_DrawPaint_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HW_DrawPaint_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HW_DrawPaint_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panColor;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label labTrackBar;
    }
}