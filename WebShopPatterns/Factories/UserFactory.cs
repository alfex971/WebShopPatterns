using System;
using System.Collections.Generic;
using System.Text;

namespace WebShopPatterns.Factories
{
    class UserFactory
    {
        public User GetUser(string type)
        {
            User nullUser = NullUser.Instance;

            switch(type)
            {
                case "Manager":
                    return new Manager();
                case "Customer":
                    return new Customer();
                case "Viewer":
                    return new Viewer();
                default:
                    return nullUser;
            }
        }
    }
}
