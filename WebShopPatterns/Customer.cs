using System;
using System.Collections.Generic;
using System.Text;

namespace WebShopPatterns
{
    class Customer : User
    {
        public Customer(string firstName) : base(firstName)
        {
        }

        public override void Order()
        {
            Console.WriteLine("You ordered for " + Item.GetPrice());
        }
    }
}
