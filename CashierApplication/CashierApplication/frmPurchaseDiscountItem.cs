using CashierApplication.ItemNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountItem : Form
    {
        public frmPurchaseDiscountItem()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = txtItemName.Text;
                double price = Convert.ToDouble(txtPrice.Text);
                double discount = Convert.ToDouble(txtDiscount.Text);
                int quantity = Convert.ToInt32(txtQuantity.Text);
                double payment = Convert.ToDouble(txtPayment.Text);

                DiscountedItem discountedItem = new DiscountedItem(itemName, price, discount);

                double discountedPrice = discountedItem.GetDiscountedPrice();
                double totalAmount = discountedPrice * quantity;

                double change = payment - totalAmount;

                lblChange.Text = $"Change: {change:C}";
                lblChange.Text = $"Change: {change:C}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid values.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = txtItemName.Text;
                double price = Convert.ToDouble(txtPrice.Text);
                double discount = Convert.ToDouble(txtDiscount.Text);
                int quantity = Convert.ToInt32(txtQuantity.Text);

                DiscountedItem discountedItem = new DiscountedItem(itemName, price, discount);

                double discountedPrice = discountedItem.GetDiscountedPrice();
                double totalAmount = discountedPrice * quantity;

                lblTotalAmount.Text = $" {totalAmount:C}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid values.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
