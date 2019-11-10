using System;
using System.Collections.Generic;
using System.Text;

namespace WebShopPatterns
{
    class Viewer : User
    {
        public override void Order()
        {
            Console.WriteLine("Viewer cannot order");
        }
    }
}
