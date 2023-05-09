using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Homework
{
    public partial class HW_ForDoWhile : Form
    {
        public HW_ForDoWhile()
        {
            InitializeComponent();
        }

        private void btnOddEven_Click(object sender, EventArgs e)
        {
            int Num;
            bool isNum = int.TryParse(txtOddEven.Text, out Num);

            if (isNum == false)
                MessageBox.Show("請輸入數值");
            else if (Num % 2 == 0)
                labResult.Text = $"輸入的數{Num}為偶數";
            else
                labResult.Text = $"輸入的數{Num}為奇數";
        }

        int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
        string[] arr0711_str = { "mother張, emma, 迪克蕭, J40, Candy, Cindy, Coconut, Motherfacker" };

        private void button2_Click(object sender, EventArgs e)
        {
            int oddcount = 0;
            int evencount = 0;
            for (int i = 0; i < arr0711.Length; i++)
            {
                if (arr0711[i] % 2 == 0)
                    evencount++;
                else oddcount++;
            }
            labResult.Text = $"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578 ]\n奇數共{oddcount}\n偶數共{evencount}";
        }

        private void button3_Click(object sender, EventArgs e)
        {//todo
         //string longestName = "";
         //foreach (string name in arr0711_str)
         //{
         //    if (name.Length > longestName.Length)
         //    {
         //        longestName = name;
         //    }
         //}
         //labResult.Text = $"陣列arr0711_str[mother張, emma, 迪克蕭, J40, Candy, Cindy, Coconut, Motherfacker]\n最長的名字為{longestName}";
            string[] arr0711_str = { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };
            string maxStr = "";

            foreach (string s in arr0711_str)
            {
                if (s.Length > maxStr.Length)
                {
                    maxStr = s;
                }
            }

            labResult.Text = $"陣列arr0711_str[mother張, emma, 迪克蕭, J40, Candy, Cindy, Coconut, Motherfacker]\n最長的名字為{maxStr}";

        }

        void Swap(ref int A, ref int B)
        {
            int T = A;
            A = B;
            B = T;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            int n1 = 100;
            int n2 = 200;
            labResult.Text = $"換位前n1 = {n1} , n2 = {n2}\n";
            Swap(ref n1, ref n2);
            labResult.Text += $"換位後n1 = {n1} , n2 = {n2}";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int sum = arr0711.Sum();
            labResult.Text = ($"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578 ]\n加總為{sum}");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string binaryString = Convert.ToString(100, 2);  // 將10進位數字轉換為2進位字串
            labResult.Text = binaryString;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            labResult.Text = "結果";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //int Num;
            //bool isNum = int.TryParse(txtOddEven.Text, out Num);
            //if (isNum)
            //    MessageBox.Show("請輸入數值");

            //todo
            bool isNum = int.TryParse(txtRows.Text, out int rows);
            if (isNum == true)
            {
                int row = Convert.ToInt32(txtRows.Text);
                string result = "";

                for (int i = 1; i <= row; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        result += "*";
                    }
                    result += "\r\n";
                }
                labResult.Text = result;
            }
            else
                MessageBox.Show("請輸入數值");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //todo 樂透:01-49 6個數字
            int[] Lottery = new int[6];
            Random r = new Random();
            for (int i = 0; i < 6; i++)
            {
                Lottery[i] = r.Next(1, 50);
                for (int j = 0; j < i; j++)
                {
                    while (Lottery[j] == Lottery[i])
                    {
                        j = 0;
                        Lottery[i] = r.Next(1, 50);
                    }
                }
            }
            labResult.Text = $"{Lottery[0].ToString()} {Lottery[1].ToString()} {Lottery[2].ToString()} {Lottery[3].ToString()} {Lottery[4].ToString()} {Lottery[5].ToString()}";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string table = "";

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    if (j < 9)
                    {
                        table += $"{j}x{i}={i * j}\t";
                    }
                    else
                    {
                        table += $"{j}x{i}={i * j}";
                    }
                }
                table += "\n";
            }
            labResult.Text = table;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[10, 10];

            // 二維陣列初始值為 0，所以只要將最外圍設為 1 即可
            for (int i = 0; i < 10; i++)
            {
                arr[i, 0] = 1; // 最上面一列設為 1
                arr[i, 9] = 1; // 最下面一列設為 1
                arr[0, i] = 1; // 最左邊一列設為 1
                arr[9, i] = 1; // 最右邊一列設為 1
            }

            // 顯示二維陣列的內容
            string output = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    output += arr[i, j] + " ";
                }
                output += "\n";
            }

            labResult.Text = output;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[10, 10];

            // 將最外圍設為 0
            for (int i = 0; i < 10; i++)
            {
                arr[0, i] = 0;
                arr[9, i] = 0;
                arr[i, 0] = 0;
                arr[i, 9] = 0;
            }

            // 將中間設為 1
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    arr[i, j] = 1;
                }
            }
            string output = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    output += arr[i, j] + " ";
                }
                output += "\n";
            }

            labResult.Text = output;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if ((i % 2 == 0 && j % 2 == 0) || (i % 2 == 1 && j % 2 == 1))
                    {
                        arr[i, j] = 1;
                    }
                    else
                    {
                        arr[i, j] = 0;
                    }
                }
            }

            string result = "";

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    result += arr[i, j].ToString() + " ";
                }
                result += "\n";
            }

            labResult.Text = result;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            int max = arr0711.Max();
            labResult.Text = ($"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578 ]\n最大值為{max}");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int min = arr0711.Min();
            labResult.Text = ($"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578 ]\n最小值為{min}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int max = arr0711.Max();
            int min = arr0711.Min();
            labResult.Text = ($"int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578 ]\n最大值為 {max}\n最小值為 {min}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[] arr0711_str = { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };
            int count = arr0711_str.Count(s => s.Contains("C") || s.Contains("c"));
            labResult.Text = $"陣列arr0711_str[mother張, emma, 迪克蕭, J40, Candy, Cindy, Coconut, Motherfacker]\n有C或c的名字共有{count}個";
            //string result = "";

            //foreach (string str in arr0711_str)
            //{
            //    if (str.Contains("C") || str.Contains("c"))
            //    {
            //        result += str + "\n";
            //    }
            //}
        }

        private void button18_Click(object sender, EventArgs e)
        {
            bool isNum1 = int.TryParse(txtFrom.Text, out int from);
            bool isNum2 = int.TryParse(txtTo.Text, out int to);
            bool isNum3 = int.TryParse(txtStep.Text, out int step);

            if (isNum1 && isNum2 && isNum3)
            {
                from = Convert.ToInt32(txtFrom.Text);
                to = Convert.ToInt32(txtTo.Text);
                step = Convert.ToInt32(txtStep.Text);
                int sum;

                List<int> list = new List<int>();
                for (int i = from; i <= to; i += step)
                {
                    list.Add(i);
                    sum = list.Sum();
                }
                sum = list.Sum();
                labResult.Text = $"{from}到{to}相隔{step - 1}\n加總為{sum}";
            }
            else
                MessageBox.Show("請輸入數值");
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            bool isNum1 = int.TryParse(txtFrom.Text, out int from);
            bool isNum2 = int.TryParse(txtTo.Text, out int to);
            bool isNum3 = int.TryParse(txtStep.Text, out int step);

            if (isNum1 && isNum2 && isNum3)
            {
                from = Convert.ToInt32(txtFrom.Text);
                to = Convert.ToInt32(txtTo.Text);
                step = Convert.ToInt32(txtStep.Text);
                int sum;
                List<int> list = new List<int>();
                int i = from;
                while (i <= to)
                {
                    list.Add(i);
                    sum = list.Sum();
                    i += step;
                }
                sum = list.Sum();
                labResult.Text = $"{from}到{to}相隔{step - 1}\n加總為{sum}";
            }
            else
                MessageBox.Show("請輸入數值");
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            bool isNum1 = int.TryParse(txtFrom.Text, out int from);
            bool isNum2 = int.TryParse(txtTo.Text, out int to);
            bool isNum3 = int.TryParse(txtStep.Text, out int step);

            if (isNum1 && isNum2 && isNum3)
            {
                from = Convert.ToInt32(txtFrom.Text);
                to = Convert.ToInt32(txtTo.Text);
                step = Convert.ToInt32(txtStep.Text);
                int sum;
                List<int> list = new List<int>();
                int i = from;

                do
                {
                    list.Add(i);
                    sum = list.Sum();
                    i += step;
                }
                while (i <= to);
                {
                    sum = list.Sum();
                }
                labResult.Text = $"{from}到{to}相隔{step - 1}\n加總為{sum}";
            }
            else
                MessageBox.Show("請輸入數值");
        }
    }
}
