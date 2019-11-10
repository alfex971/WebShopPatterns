using System;
using System.Collections.Generic;
using System.Text;

namespace WebShopPatterns
{
    class Customer : User
    {
        public override void Order()
        {
            Console.WriteLine("You ordered for " + Item.GetPrice());
        }
    }
}
