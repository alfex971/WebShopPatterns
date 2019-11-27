﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebShopPatterns
{
    class Manager : User
    {
        public Manager(string firstName) : base(firstName)
        {
        }

        public override void Order()
        {
            Console.WriteLine("Manager cannot order");
        }
    }
}
