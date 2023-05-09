using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Homework
{
    public partial class HW_Notepad : Form
    {
        public HW_Notepad()
        {
            InitializeComponent();
        }
        string filePath = "";

        private void Time_Tick(object sender, EventArgs e)
        {
            labTime.Text = DateTime.Now.ToString("tt hh:mm:ss");
        }

        private void HW_Notepad_Load(object sender, EventArgs e)
        {
            Time.Start();
        }

        private void 新增NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filePath = "";
            txtRichBox.Text = "";
        }

        private void 開啟OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "TextDocument|*.txt", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using(StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        filePath = ofd.FileName;
                        Task<string> text = sr.ReadToEndAsync();
                        txtRichBox.Text = text.Result;
                    }              
                }
            }
        }

        private void 新增NToolStripButton_Click(object sender, EventArgs e)
        {
            filePath = "";
            txtRichBox.Text = "";
        }

        private void 開啟OToolStripButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "TextDocument|*.txt", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        filePath = ofd.FileName;
                        Task<string> text = sr.ReadToEndAsync();
                        txtRichBox.Text = text.Result;
                    }
                }
            }
        }

        private void 儲存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                using(SaveFileDialog sfd = new SaveFileDialog() { Filter = "TextDocument|*.txt", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using(StreamWriter sw = new StreamWriter(sfd.FileName))
                        {
                            sw.WriteLineAsync(txtRichBox.Text);
                        }
                    }
                }
            }
            else
                using(StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLineAsync(txtRichBox.Text);
                }
        }

        private void 另存新檔AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "TextDocument|*.txt", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        sw.WriteLineAsync(txtRichBox.Text);
                    }
                }
            }
        }

        private void 預覽列印VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void 列印PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtRichBox.Text, txtRichBox.Font, Brushes.Black, 12, 10);
        }

        private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 儲存SToolStripButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "TextDocument|*.txt", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName))
                        {
                            sw.WriteLineAsync(txtRichBox.Text);
                        }
                    }
                }
            }
            else
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLineAsync(txtRichBox.Text);
                }
        }

        private void 列印PToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void 復原UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtRichBox.Undo();
        }

        private void 取消復原RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtRichBox.Redo();
        }

        private void 剪下TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtRichBox.Cut();
        }

        private void 複製CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtRichBox.Copy();
        }

        private void 貼上PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtRichBox.Paste();
        }

        private void 全選AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtRichBox.SelectAll();
        }

        private void 剪下UToolStripButton_Click(object sender, EventArgs e)
        {
            txtRichBox.Cut();
        }

        private void 複製CToolStripButton_Click(object sender, EventArgs e)
        {
            txtRichBox.Copy();
        }

        private void 貼上PToolStripButton_Click(object sender, EventArgs e)
        {
            txtRichBox.Paste();
        }

        private void 自動換行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (自動換行ToolStripMenuItem.Checked == true)
            {
                自動換行ToolStripMenuItem.Checked = false;
                txtRichBox.WordWrap = false;
            }
            else
            {
                自動換行ToolStripMenuItem.Checked = true;
                txtRichBox.WordWrap = true;
            }
        }

        private void toUpperUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtRichBox.Text = txtRichBox.Text.ToUpper();
        }

        private void toLowerLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtRichBox.Text = txtRichBox.Text.ToLower();
        }

        private void 字型VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            txtRichBox./*Selection*/Font = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style);
        }

        private void 關於AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HW_NotepadAboutBox About = new HW_NotepadAboutBox();
            About.ShowDialog();
        }

        private void 說明LToolStripButton_Click(object sender, EventArgs e)
        {
            HW_NotepadAboutBox About = new HW_NotepadAboutBox();
            About.ShowDialog();
        }

        private void 顏色CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            txtRichBox.ForeColor = colorDialog1.Color;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtRichBox.ForeColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtRichBox.ForeColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtRichBox.ForeColor = Color.Blue;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtRichBox.ForeColor = Color.Black;
        }

        //private void txtBox_TextChanged(object sender, EventArgs e)
        //{
        //    if(txtBox.Text.Length > 0)
        //    {
        //        剪下TToolStripMenuItem.Enabled = true;
        //        複製CToolStripMenuItem.Enabled = true;
        //    }
        //    else
        //    {
        //        剪下TToolStripMenuItem.Enabled = false;
        //        複製CToolStripMenuItem.Enabled = false;
        //    }
    }
}
