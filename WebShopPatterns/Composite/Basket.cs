using System;
using System.Collections.Generic;
using System.Text;

namespace WebShopPatterns.Composite
{
    class Basket : IItem
    {
        private List<IItem> Ads { get; set; }

        public Basket()
        {
            Ads = new List<IItem>();
        }

        public decimal GetPrice()
        {
            decimal totalPrice = 0;

            foreach (var ad in Ads)
            {
                totalPrice += ad.GetPrice();
            }

            return totalPrice;
        }

        public void AddAd(IItem ad)
        {
            Ads.Add(ad);
        }
    }
}
