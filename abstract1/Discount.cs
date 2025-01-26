using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACT1.abstract1
{

    internal abstract class Discount
    {

        public decimal Price { get; set; }
        public int quantity { get; set; }

        public abstract decimal CalculateDiscount(decimal price, int quantity);


    }
    class PercentageDiscount : Discount
    {
        decimal Percentage { get; set; }
        public PercentageDiscount(decimal Percentage)
        {
            this.Percentage = Percentage;
        }
        public decimal DiscountAmount;
        public override decimal CalculateDiscount(decimal price, int quantity)

        {
            return DiscountAmount = (price * quantity) * (Percentage / 100);
        }
    }
    class FlatDiscount : Discount
    {
        decimal FlatAmount { get; set; }

        public decimal Amount;
        public override decimal CalculateDiscount(decimal FlatAmount, int quantity)
        {
            return Amount = (FlatAmount) * (Math.Min(quantity, 1));
        }
    }
    class BuyOneGetOneDiscount : Discount
    {
        public decimal Amount;
        public override decimal CalculateDiscount(decimal price, int quantity)
        {

            if (quantity > 1)
                return Amount = (price / 2) * (quantity / 2);
            else return price * quantity;
        }
    }
   
}
