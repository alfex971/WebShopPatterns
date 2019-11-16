using System;
using System.Collections.Generic;
using System.Text;
using WebShopPatterns.Composite;

namespace WebShopPatterns
{
    class Ad : IItem
    {
        public Ad(string name, string description, decimal price, int rating)
        {
            Name = name;
            Description = description;
            Price = price;
            Rating = rating;
        }

        public Ad()
        {
            
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Rating { get; set; }

        public decimal GetPrice()
        {
            return Price;
        }
    }
}
