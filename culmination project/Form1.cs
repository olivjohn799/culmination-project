using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace culmination_project
{
    public partial class Form1 : Form
    {
        double grimaceshakePrice = 5;
        double bigmacPrice = 7;
        double lgfriesPrice = 6;
        int numOfgrimaceshakes = 0;
        int numOflgfries = 0;
        int numOfbigmac = 0;
        double taxRate = 0.13;
        double subTotal = 0;
        double taxAmount = 0;
        double totalPrice = 0;
        double tendered = 0;
        double change = 0;


        public Form1()
        {
            
            InitializeComponent();
        }

        private void calculatetotalButton_Click(object sender, EventArgs e)
        {
            numOfgrimaceshakes = Convert.ToInt16(grimaceshakeInput.Text);
            numOfbigmac = Convert.ToInt16(bigmacInput.Text);
            numOflgfries = Convert.ToInt16(lgfriesInput.Text); 
             
            subTotal = grimaceshakePrice * numOfgrimaceshakes + bigmacPrice * numOfbigmac + lgfriesPrice * numOflgfries;
            subtotalOutput.Text = $"{subTotal.ToString("C")}";

            taxAmount = subTotal * taxRate;
            taxOutput.Text = $"{taxAmount.ToString("C")}";

            totalPrice = subTotal + taxAmount;
            totalOutput.Text = $"{totalPrice.ToString("C")}"; 
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            tendered = Convert.ToDouble (tenderedInput.Text);

            change = tendered - totalPrice;
            changeOutput.Text = $"{change.ToString("C")}";

            if (tendered < totalPrice)
            {
                changeOutput.Text = "No Funds";
            }
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            receiptOutput.Text = $"McDonalds";
            receiptOutput.Text += $"\nFebuary 28, 2024";
            receiptOutput.Text += $"\n\nGrimace Shakes   x{numOfgrimaceshakes} @ ${grimaceshakePrice}";
            receiptOutput.Text += $"\nBig Macs           x{numOfbigmac} @ ${bigmacPrice}";
            receiptOutput.Text += $"\nlg Fries           x{numOflgfries} @ ${lgfriesPrice}";
            receiptOutput.Text += $"\n\nSubtotal         ${subTotal}";
            receiptOutput.Text += $"\nTax                ${taxAmount}";
            receiptOutput.Text += $"\nTotal              ${totalPrice}";
            receiptOutput.Text += $"\n\nTendered         ${tendered}";
            receiptOutput.Text += $"\nChange             {change.ToString("C")}";
            receiptOutput.Text += $"\n\nThank You!";

        }
    }
}
