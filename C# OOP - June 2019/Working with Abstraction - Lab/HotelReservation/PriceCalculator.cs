using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation
{
    public partial class PriceCalculator
    {
        private decimal pricePerNight;

        private int nights;

        private Seasons season;

        private Discount discount;

        public PriceCalculator(string[] commandsArgs)
        {
            pricePerNight = decimal.Parse(commandsArgs[0]);
            nights = int.Parse(commandsArgs[1]);
            season = Enum.Parse<Seasons>(commandsArgs[2]);
            discount = Discount.None;

            if (commandsArgs.Length == 4)
            {
                discount = Enum.Parse<Discount>(commandsArgs[3]);
            }
        }

        public decimal GetTotalPrice()
        {
            decimal totalPrice = (pricePerNight * nights) * (int)season;

            decimal calculateDiscount = (totalPrice * (int)discount) / 100;

            decimal totalSum = totalPrice - calculateDiscount;

            return totalSum;
        }
    }
}
