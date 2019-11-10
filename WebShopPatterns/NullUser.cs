using System;
using System.Collections.Generic;
using System.Text;

namespace WebShopPatterns
{
    class NullUser : User
    {
        // Null Object does nothing
        public override void Order()
        {
        }
    }
}
