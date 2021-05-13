using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tip_Tax_and_total__2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double foodCharge;                     // The food charge that the user inputs.
            const double TIP_PERCENT = 0.15;       // The percentage that is to be tipped.
            double tipAmount;                      // To hold the amount of the tip.
            const double SALES_TAX_PERCENT = 0.07; // The percentage of tax that will be added to the total.
            double salesTaxAmount;                 // To hold the amount of the tax.
            double totalPrice;                     // To hold the total amount once calculated.
            
            // To bring in the input that the user created for the food charge amount.
            foodCharge = double.Parse(foodChargeAmountTextBox.Text);

            // To calculate the amount that is to be tipped.
            tipAmount = foodCharge * TIP_PERCENT;

            // To display the amount of tip that will be added to the total.
            calculatedTipAmountLabel.Text = tipAmount.ToString("c");

            // To calculate the amount of tax that will be added to the bill.
            salesTaxAmount = foodCharge * SALES_TAX_PERCENT;

            // To display the amount of tax being added to the total.
            calculatedSalesTaxLabel.Text = salesTaxAmount.ToString("c");

            // To calculate the total.
            totalPrice = foodCharge + tipAmount + salesTaxAmount;

            // To display the overall total.
            calculatedTotalLabel.Text = totalPrice.ToString("c");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clear the input and output controls
            foodChargeAmountTextBox.Text = "";
            calculatedTipAmountLabel.Text ="";
            calculatedSalesTaxLabel.Text = "";
            calculatedTotalLabel.Text = "";
        }
    }
}
