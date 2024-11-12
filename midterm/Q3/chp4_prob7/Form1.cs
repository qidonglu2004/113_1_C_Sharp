using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chp4_prob7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double income;    //收入
            double taxrate;   //稅率
            double payable;   //應交稅額
            double netIncome; //淨收入

            //以下作答
            try
            {
                double per;
                income = double.Parse(incomeTextBox.Text);
                if (income > 0 & income <= 590000 )
                {
                    taxrate = 0.05;
                }
                else if (income > 590000 & income <= 1330000)
                {
                    taxrate = 0.12;
                }
                else if (income > 1330000 & income <= 2660000)
                {
                    taxrate = 0.20;
                }
                else if (income > 2660000 & income <= 4980000)
                {
                    taxrate = 0.30;
                }
                else
                {
                    taxrate = 0.40;
                }

                payable = income * taxrate;

                lbl_show_payabletax.Text = payable.ToString("c");
                lbl_show_netincome.Text = (income - payable).ToString("c");
            }
            catch 
            {
                MessageBox.Show("Error, please retry again");
                incomeTextBox.Text = "";
                lbl_show_payabletax.Text = "";
                lbl_show_netincome.Text = "";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
