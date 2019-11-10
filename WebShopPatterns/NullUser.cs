using System;
using System.Collections.Generic;
using System.Text;

namespace WebShopPatterns
{
    class NullUser : User
    {
        private static readonly Lazy<NullUser> nullUser = new Lazy<NullUser>(() => new NullUser());

        public static NullUser Instance { get { return nullUser.Value; } }

        private NullUser()
        {

        }

        // Null Object does nothing
        public override void Order()
        {

        }
    }
}
