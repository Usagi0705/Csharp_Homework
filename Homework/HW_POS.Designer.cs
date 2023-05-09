namespace Homework
{
    partial class HW_POS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HW_POS));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCreditCard = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labList = new System.Windows.Forms.Label();
            this.groupboxList = new System.Windows.Forms.GroupBox();
            this.groupboxMenu = new System.Windows.Forms.GroupBox();
            this.btnWine = new System.Windows.Forms.Button();
            this.btnWhisky = new System.Windows.Forms.Button();
            this.btnTequila = new System.Windows.Forms.Button();
            this.btnBeer = new System.Windows.Forms.Button();
            this.groupboxPayment = new System.Windows.Forms.GroupBox();
            this.groupboxTotalPrice = new System.Windows.Forms.GroupBox();
            this.labTotalPrice = new System.Windows.Forms.Label();
            this.groupboxList.SuspendLayout();
            this.groupboxMenu.SuspendLayout();
            this.groupboxPayment.SuspendLayout();
            this.groupboxTotalPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "總金額 Total Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(5, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "菜單 Menu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(5, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "付款方式";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(5, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "購物清單 List";
            // 
            // btnCash
            // 
            this.btnCash.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCash.Location = new System.Drawing.Point(26, 65);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(90, 32);
            this.btnCash.TabIndex = 4;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCreditCard
            // 
            this.btnCreditCard.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreditCard.Location = new System.Drawing.Point(161, 65);
            this.btnCreditCard.Name = "btnCreditCard";
            this.btnCreditCard.Size = new System.Drawing.Size(90, 32);
            this.btnCreditCard.TabIndex = 5;
            this.btnCreditCard.Text = "信用卡";
            this.btnCreditCard.UseVisualStyleBackColor = true;
            this.btnCreditCard.Click += new System.EventHandler(this.btnCreditCard_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClearList.Location = new System.Drawing.Point(167, 259);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(90, 32);
            this.btnClearList.TabIndex = 6;
            this.btnClearList.Text = "清除清單";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(151, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "信用卡享九折!";
            // 
            // labList
            // 
            this.labList.BackColor = System.Drawing.Color.White;
            this.labList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labList.Location = new System.Drawing.Point(4, 38);
            this.labList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labList.Name = "labList";
            this.labList.Size = new System.Drawing.Size(254, 211);
            this.labList.TabIndex = 8;
            this.labList.Text = "尚未點餐";
            this.labList.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupboxList
            // 
            this.groupboxList.Controls.Add(this.labList);
            this.groupboxList.Controls.Add(this.label4);
            this.groupboxList.Controls.Add(this.btnClearList);
            this.groupboxList.Location = new System.Drawing.Point(527, 17);
            this.groupboxList.Margin = new System.Windows.Forms.Padding(2);
            this.groupboxList.Name = "groupboxList";
            this.groupboxList.Padding = new System.Windows.Forms.Padding(2);
            this.groupboxList.Size = new System.Drawing.Size(262, 307);
            this.groupboxList.TabIndex = 9;
            this.groupboxList.TabStop = false;
            // 
            // groupboxMenu
            // 
            this.groupboxMenu.Controls.Add(this.btnWine);
            this.groupboxMenu.Controls.Add(this.btnWhisky);
            this.groupboxMenu.Controls.Add(this.btnTequila);
            this.groupboxMenu.Controls.Add(this.btnBeer);
            this.groupboxMenu.Controls.Add(this.label2);
            this.groupboxMenu.Location = new System.Drawing.Point(11, 17);
            this.groupboxMenu.Margin = new System.Windows.Forms.Padding(2);
            this.groupboxMenu.Name = "groupboxMenu";
            this.groupboxMenu.Padding = new System.Windows.Forms.Padding(2);
            this.groupboxMenu.Size = new System.Drawing.Size(217, 307);
            this.groupboxMenu.TabIndex = 10;
            this.groupboxMenu.TabStop = false;
            // 
            // btnWine
            // 
            this.btnWine.BackColor = System.Drawing.Color.White;
            this.btnWine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWine.BackgroundImage")));
            this.btnWine.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWine.Location = new System.Drawing.Point(111, 185);
            this.btnWine.Margin = new System.Windows.Forms.Padding(2);
            this.btnWine.Name = "btnWine";
            this.btnWine.Size = new System.Drawing.Size(92, 102);
            this.btnWine.TabIndex = 5;
            this.btnWine.Text = "紅酒\r\nWine\r\nNT$320";
            this.btnWine.UseVisualStyleBackColor = false;
            this.btnWine.Click += new System.EventHandler(this.btnWine_Click);
            // 
            // btnWhisky
            // 
            this.btnWhisky.BackColor = System.Drawing.Color.White;
            this.btnWhisky.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWhisky.BackgroundImage")));
            this.btnWhisky.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnWhisky.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWhisky.Location = new System.Drawing.Point(9, 185);
            this.btnWhisky.Margin = new System.Windows.Forms.Padding(2);
            this.btnWhisky.Name = "btnWhisky";
            this.btnWhisky.Size = new System.Drawing.Size(92, 102);
            this.btnWhisky.TabIndex = 4;
            this.btnWhisky.Text = "威士忌\r\nWhisky\r\nNT$350";
            this.btnWhisky.UseVisualStyleBackColor = false;
            this.btnWhisky.Click += new System.EventHandler(this.btnWhisky_Click);
            // 
            // btnTequila
            // 
            this.btnTequila.BackColor = System.Drawing.Color.White;
            this.btnTequila.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTequila.BackgroundImage")));
            this.btnTequila.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTequila.Location = new System.Drawing.Point(111, 54);
            this.btnTequila.Margin = new System.Windows.Forms.Padding(2);
            this.btnTequila.Name = "btnTequila";
            this.btnTequila.Size = new System.Drawing.Size(92, 102);
            this.btnTequila.TabIndex = 3;
            this.btnTequila.Text = "龍舌蘭\r\nTequila\r\nNT$180";
            this.btnTequila.UseVisualStyleBackColor = false;
            this.btnTequila.Click += new System.EventHandler(this.btnTequila_Click);
            // 
            // btnBeer
            // 
            this.btnBeer.BackColor = System.Drawing.Color.White;
            this.btnBeer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBeer.BackgroundImage")));
            this.btnBeer.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBeer.Location = new System.Drawing.Point(9, 54);
            this.btnBeer.Margin = new System.Windows.Forms.Padding(2);
            this.btnBeer.Name = "btnBeer";
            this.btnBeer.Size = new System.Drawing.Size(92, 102);
            this.btnBeer.TabIndex = 2;
            this.btnBeer.Text = "啤酒\r\nBeer\r\nNT$120";
            this.btnBeer.UseVisualStyleBackColor = false;
            this.btnBeer.Click += new System.EventHandler(this.btnBeer_Click);
            // 
            // groupboxPayment
            // 
            this.groupboxPayment.Controls.Add(this.btnCash);
            this.groupboxPayment.Controls.Add(this.btnCreditCard);
            this.groupboxPayment.Controls.Add(this.label3);
            this.groupboxPayment.Controls.Add(this.label5);
            this.groupboxPayment.Location = new System.Drawing.Point(244, 177);
            this.groupboxPayment.Margin = new System.Windows.Forms.Padding(2);
            this.groupboxPayment.Name = "groupboxPayment";
            this.groupboxPayment.Padding = new System.Windows.Forms.Padding(2);
            this.groupboxPayment.Size = new System.Drawing.Size(268, 147);
            this.groupboxPayment.TabIndex = 11;
            this.groupboxPayment.TabStop = false;
            // 
            // groupboxTotalPrice
            // 
            this.groupboxTotalPrice.Controls.Add(this.labTotalPrice);
            this.groupboxTotalPrice.Controls.Add(this.label1);
            this.groupboxTotalPrice.Location = new System.Drawing.Point(244, 17);
            this.groupboxTotalPrice.Margin = new System.Windows.Forms.Padding(2);
            this.groupboxTotalPrice.Name = "groupboxTotalPrice";
            this.groupboxTotalPrice.Padding = new System.Windows.Forms.Padding(2);
            this.groupboxTotalPrice.Size = new System.Drawing.Size(268, 156);
            this.groupboxTotalPrice.TabIndex = 12;
            this.groupboxTotalPrice.TabStop = false;
            // 
            // labTotalPrice
            // 
            this.labTotalPrice.BackColor = System.Drawing.Color.Black;
            this.labTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotalPrice.ForeColor = System.Drawing.Color.White;
            this.labTotalPrice.Location = new System.Drawing.Point(26, 69);
            this.labTotalPrice.Name = "labTotalPrice";
            this.labTotalPrice.Size = new System.Drawing.Size(225, 43);
            this.labTotalPrice.TabIndex = 1;
            this.labTotalPrice.Text = "NT$0";
            this.labTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HW_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 351);
            this.Controls.Add(this.groupboxTotalPrice);
            this.Controls.Add(this.groupboxPayment);
            this.Controls.Add(this.groupboxMenu);
            this.Controls.Add(this.groupboxList);
            this.Name = "HW_POS";
            this.Text = "Bar POS";
            this.groupboxList.ResumeLayout(false);
            this.groupboxList.PerformLayout();
            this.groupboxMenu.ResumeLayout(false);
            this.groupboxMenu.PerformLayout();
            this.groupboxPayment.ResumeLayout(false);
            this.groupboxPayment.PerformLayout();
            this.groupboxTotalPrice.ResumeLayout(false);
            this.groupboxTotalPrice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnCreditCard;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labList;
        private System.Windows.Forms.GroupBox groupboxList;
        private System.Windows.Forms.GroupBox groupboxMenu;
        private System.Windows.Forms.Button btnBeer;
        private System.Windows.Forms.GroupBox groupboxPayment;
        private System.Windows.Forms.GroupBox groupboxTotalPrice;
        private System.Windows.Forms.Button btnWine;
        private System.Windows.Forms.Button btnWhisky;
        private System.Windows.Forms.Button btnTequila;
        private System.Windows.Forms.Label labTotalPrice;
    }
}