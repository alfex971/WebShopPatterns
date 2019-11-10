using System;
using System.Collections.Generic;
using System.Text;
using WebShopPatterns.Composite;

namespace WebShopPatterns
{
    abstract class User
    {
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public IItem Item { get; set; }

        public abstract void Order();
    }
}
