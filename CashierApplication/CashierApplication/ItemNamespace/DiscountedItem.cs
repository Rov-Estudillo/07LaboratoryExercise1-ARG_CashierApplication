using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication.ItemNamespace
{
    public class DiscountedItem : Item
    {
        public double Discount { get; set; }

        public DiscountedItem(string name, double price, double discount) : base(name, price)
        {
            Discount = discount;
        }

        public double GetDiscountedPrice()
        {
            double discountAmount = Discount * 0.01 * Price;
            return Price - discountAmount;
        }
    }
}
