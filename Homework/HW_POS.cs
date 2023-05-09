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

    public partial class HW_POS : Form
    {
        //string[] DrinkName = new string[4]
        //    {"啤酒","龍舌蘭","威士忌","啤酒"};
        //int[] DrinkPrice = new int[4]
        //    {120,180,350,320};
        //int[] DrinkCount = new int[4]
        //    {0,0,0,0};

        public HW_POS()
        {
            InitializeComponent();
        }

        int Result;
        int BeerPrice = 120;
        int TequilaPrice = 180;
        int WhiskyPrice = 350;
        int WinePrice = 320;
        int BeerCount, TequilaCount, WhiskyCount, WineCount, Beer, Tequila, Whisky, Wine;

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            if(Result == 0)
                MessageBox.Show("尚未點餐！", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            MessageBox.Show($"總金額：NT${Result}\n折扣後金額：NT${Result * 0.9}", "確認付款", MessageBoxButtons.OKCancel);
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            if(Result == 0)
                MessageBox.Show("尚未點餐！", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            MessageBox.Show($"總金額：NT${Result}", "確認付款",MessageBoxButtons.OKCancel);
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            BeerCount = 0;
            TequilaCount = 0;
            WhiskyCount = 0;
            WineCount = 0;
            Result = 0;
            labList.Text = "尚未點餐";
            labTotalPrice.Text = $"NT${Result}";
            BeerList = "";
            TequilaList = "";
            WhiskyList = "";
            WineList = "";
        }

        string BeerList;
        string TequilaList;
        string WhiskyList;
        string WineList;
    
        private void btnBeer_Click(object sender, EventArgs e)
        {
            BeerCount++;
            Beer = BeerCount * BeerPrice;
            Result += BeerPrice;
            BeerList = $"啤酒Beer x{BeerCount},共NT${Beer}元\n";
            labList.Text = BeerList + TequilaList + WhiskyList + WineList;
          
            //if (TequilaCount > 0 && WhiskyCount == 0 && WineCount == 0)
            //    labList.Text = $"啤酒Beer x{BeerCount},共NT${Beer}元\n龍舌蘭Tequila x{TequilaCount},共NT${Tequila}元";
            //else if (TequilaCount > 0 && WhiskyCount > 0 && WineCount == 0)
            //    labList.Text = $"啤酒Beer x{BeerCount},共NT${Beer}元\n龍舌蘭Tequila x{TequilaCount},共NT${Tequila}元\n威士忌Whisky x{WhiskyCount},共NT${Whisky}元";
            //else if (TequilaCount > 0 && WhiskyCount > 0 && WineCount > 0)
            //    labList.Text = $"啤酒Beer x{BeerCount},共NT${Beer}元\n龍舌蘭Tequila x{TequilaCount},共NT${Tequila}元\n威士忌Whisky x{WhiskyCount},共NT${Whisky}元\n紅酒Wine x{WineCount},共NT${Wine}元";
            //else if (TequilaCount > 0 && WhiskyCount == 0 && WineCount > 0)
            //    labList.Text = $"啤酒Beer x{BeerCount},共NT${Beer}元\n龍舌蘭Tequila x{TequilaCount},共NT${Tequila}元\n紅酒Wine x{WineCount},共NT${Wine}元";
            //else if (TequilaCount == 0 && WhiskyCount > 0 && WineCount > 0)
            //    labList.Text = $"啤酒Beer x{BeerCount},共NT${Beer}元\n威士忌Whisky x{WhiskyCount},共NT${Whisky}元\n紅酒Wine x{WineCount},共NT${Wine}元";
            //else if (TequilaCount == 0 && WhiskyCount == 0 && WineCount > 0)
            //    labList.Text = $"啤酒Beer x{BeerCount},共NT${Beer}元\n紅酒Wine x{WineCount},共NT${Wine}元";
            //else if (TequilaCount == 0 && WhiskyCount > 0 && WineCount == 0)
            //    labList.Text = $"啤酒Beer x{BeerCount},共NT${Beer}元\n威士忌Whisky x{WhiskyCount},共NT${Whisky}元";

            labTotalPrice.Text = $"NT$ {Result}";
        }
        

        private void btnTequila_Click(object sender, EventArgs e)
        {
            TequilaCount++;
            Tequila = TequilaCount * TequilaPrice;
            Result += TequilaPrice;
            TequilaList = $"龍舌蘭Tequila x{TequilaCount},共NT${Tequila}元\n";
            labList.Text = BeerList + TequilaList + WhiskyList + WineList;

            //if (BeerCount > 0 && WhiskyCount == 0 && WineCount == 0)
            //    labList.Text = $"啤酒Beer x{BeerCount},共NT${Beer}元\n龍舌蘭Tequila x{TequilaCount},共NT${Tequila}元";
            //else if (BeerCount > 0 && WhiskyCount > 0 && WineCount == 0)
            //    labList.Text = $"啤酒Beer x{BeerCount},共NT${Beer}元\n龍舌蘭Tequila x{TequilaCount},共NT${Tequila}元\n威士忌Whisky x{WhiskyCount},共NT${Whisky}元";
            //else if (BeerCount > 0 && WhiskyCount > 0 && WineCount > 0)
            //    labList.Text = $"啤酒Beer x{BeerCount},共NT${Beer}元\n龍舌蘭Tequila x{TequilaCount},共NT${Tequila}元\n威士忌Whisky x{WhiskyCount},共NT${Whisky}元\n紅酒Wine x{WineCount},共NT${Wine}元";
            //else if (BeerCount > 0 && WhiskyCount == 0 && WineCount > 0)
            //    labList.Text = $"啤酒Beer x{BeerCount},共NT${Beer}元\n龍舌蘭Tequila x{TequilaCount},共NT${Tequila}元\n紅酒Wine x{WineCount},共NT${Wine}元";
            //else if (BeerCount == 0 && WhiskyCount > 0 && WineCount > 0)
            //    labList.Text = $"龍舌蘭Tequila x{TequilaCount},共NT${Tequila}元\n威士忌Whisky x{WhiskyCount},共NT${Whisky}元\n紅酒Wine x{WineCount},共NT${Wine}元";
            //else if (BeerCount == 0 && WhiskyCount == 0 && WineCount > 0)
            //    labList.Text = $"龍舌蘭Tequila x{TequilaCount},共NT${Tequila}元\n紅酒Wine x{WineCount},共NT${Wine}元";
            //else if (BeerCount == 0 && WhiskyCount > 0 && WineCount == 0)
            //    labList.Text = $"龍舌蘭Tequila x{TequilaCount},共NT${Tequila}元\n威士忌Whisky x{WhiskyCount},共NT${Whisky}元";

            labTotalPrice.Text = $"NT$ {Result}";
        }

        private void btnWhisky_Click(object sender, EventArgs e)
        {
            WhiskyCount++;
            Whisky = WhiskyCount * WhiskyPrice;
            Result += WhiskyPrice;
            WhiskyList = $"威士忌Whisky x{WhiskyCount},共NT${Whisky}元\n";
            labList.Text = BeerList + TequilaList + WhiskyList + WineList;

            //if (BeerCount > 0 && TequilaCount == 0 && WineCount == 0)
            //    labList.Text = $"啤酒Beer x{BeerCount},共NT${Beer}元\n威士忌Whisky x{WhiskyCount},共NT${Whisky}元";
            //else if (BeerCount > 0 && TequilaCount > 0 && WineCount == 0)
            //    labList.Text = $"啤酒Beer x{BeerCount},共NT${Beer}元\n龍舌蘭Tequila x{TequilaCount},共NT${Tequila}元\n威士忌Whisky x{WhiskyCount},共NT${Whisky}元";
            //else if (BeerCount > 0 && TequilaCount > 0 && WineCount > 0)
            //    labList.Text = $"啤酒Beer x{BeerCount},共NT${Beer}元\n龍舌蘭Tequila x{TequilaCount},共NT${Tequila}元\n威士忌Whisky x{WhiskyCount},共NT${Whisky}元\n紅酒Wine x{WineCount},共NT${Wine}元";
            //else if (BeerCount > 0 && TequilaCount == 0 && WineCount > 0)
            //    labList.Text = $"啤酒Beer x{BeerCount},共NT${Beer}元\n威士忌Whisky x{WhiskyCount},共NT${Whisky}元\n紅酒Wine x{WineCount},共NT${Wine}元";
            //else if (BeerCount == 0 && TequilaCount > 0 && WineCount == 0)
            //    labList.Text = $"龍舌蘭Tequila x{TequilaCount},共NT${Tequila}元\n威士忌Whisky x{WhiskyCount},共NT${Whisky}元";
            //else if (BeerCount == 0 && TequilaCount == 0 && WineCount > 0)
            //    labList.Text = $"威士忌Whisky x{WhiskyCount},共NT${Whisky}元\n紅酒Wine x{WineCount},共NT${Wine}元";
            //else if (BeerCount == 0 && TequilaCount > 0 && WineCount > 0)
            //    labList.Text = $"龍舌蘭Tequila x{TequilaCount},共NT${Tequila}元\n威士忌Whisky x{WhiskyCount},共NT${Whisky}元\n紅酒Wine x{WineCount},共NT${Wine}元";

            labTotalPrice.Text = $"NT$ {Result}";
        }

        private void btnWine_Click(object sender, EventArgs e)
        {
            WineCount++;
            Wine = WineCount * WinePrice;
            Result += WinePrice;
            WineList = $"紅酒Wine x{WineCount},共NT${Wine}元";
            labList.Text = BeerList + TequilaList + WhiskyList + WineList;

            //if (BeerCount > 0 && TequilaCount == 0 && WhiskyCount == 0)
            //    labList.Text = $"啤酒Beer x{BeerCount},共NT${Beer}元\n紅酒Wine x{WineCount},共NT${Wine}元";
            //else if (BeerCount > 0 && TequilaCount > 0 && WhiskyCount == 0)
            //    labList.Text = $"啤酒Beer x{BeerCount},共NT${Beer}元\n龍舌蘭Tequila x{TequilaCount},共NT${Tequila}元\n紅酒Wine x{WineCount},共NT${Wine}元";
            //else if (BeerCount > 0 && TequilaCount > 0 && WhiskyCount > 0)
            //    labList.Text = $"啤酒Beer x{BeerCount},共NT${Beer}元\n龍舌蘭Tequila x{TequilaCount},共NT${Tequila}元\n威士忌Whisky x{WhiskyCount},共NT${Whisky}元\n紅酒Wine x{WineCount},共NT${Wine}元";
            //else if (BeerCount > 0 && TequilaCount == 0 && WhiskyCount > 0)
            //    labList.Text = $"啤酒Beer x{BeerCount},共NT${Beer}元\n威士忌Whisky x{WhiskyCount},共NT${Whisky}元\n紅酒Wine x{WineCount},共NT${Wine}元";
            //else if (BeerCount == 0 && TequilaCount > 0 && WhiskyCount == 0)
            //    labList.Text = $"龍舌蘭Tequila x{TequilaCount},共NT${Tequila}元\n紅酒Wine x{WineCount},共NT${Wine}元";
            //else if (BeerCount == 0 && TequilaCount > 0 && WhiskyCount > 0)
            //    labList.Text = $"龍舌蘭Tequila x{TequilaCount},共NT${Tequila}元\n威士忌Whisky x{WhiskyCount},共NT${Whisky}元\n紅酒Wine x{WineCount},共NT${Wine}元";
            //else if (BeerCount == 0 && TequilaCount == 0 && WhiskyCount > 0)
            //    labList.Text = $"威士忌Whisky x{WhiskyCount},共NT${Whisky}元\n紅酒Wine x{WineCount},共NT${Wine}元";

            labTotalPrice.Text = $"NT$ {Result}";
        }
    }
}
