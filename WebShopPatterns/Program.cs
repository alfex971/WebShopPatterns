using System;
using System.Collections.Generic;
using WebShopPatterns.Builder;
using WebShopPatterns.Composite;
using WebShopPatterns.Factories;

namespace WebShopPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Ad ad1 = new Ad() { Price = 100 };
            Ad ad2 = new Ad() { Price = 23 };
            Ad ad3 = new Ad() { Price = 400 };
            Ad ad4 = new Ad() { Price = 1240 };
            
            var basicBuilder = new BasicAdBuilder();
            
            var factory = new AdFactory();
            var builders = new List<AdBuilder>
            {
                basicBuilder
            };
            
            foreach (var b in builders)
            {
                var a = factory.Build(b);
                Console.WriteLine(a.GetPrice());

            }

            UserFactory userFactory = new UserFactory();
            User user = userFactory.GetUser("Customer", "martin@gmail.com");

            Basket basket = new Basket();
            basket.AddAd(ad2);
            basket.AddAd(ad4);

            Basket basket2 = new Basket();
            basket.AddAd(ad1);
            basket.AddAd(ad3);

            basket.AddAd(basket2);

            user.Item = basket;
            user.Order();

            Console.ReadLine();
            
        }
    }
}
