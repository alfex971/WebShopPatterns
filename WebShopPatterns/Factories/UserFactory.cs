using System;
using System.Collections.Generic;
using System.Text;

namespace WebShopPatterns.Factories
{
    class UserFactory
    {
        List<User> users = new List<User>();

        public User GetUser(string type, string email)
        {
            User nullUser = Viewer.Instance;

            switch(type)
            {
                case "Manager":
                    if (users.Exists(user => user.Email == email))
                    {
                        return users.Find(user => user.Email == email);
                    }

                    users.Add(new Manager(email));
                    return new Manager(email);
                case "Customer":
                    if (users.Exists(user => user.Email == email))
                    {
                        return users.Find(user => user.Email == email);
                    }

                    users.Add(new Manager(email));
                    return new Customer(email);
                default:
                    return nullUser;
            }
        }
    }
}
