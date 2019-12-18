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
            /*
            Ad ad1 = new Ad() { Price = 100 };
            Ad ad2 = new Ad() { Price = 23 };
            Ad ad3 = new Ad() { Price = 400 };
            Ad ad4 = new Ad() { Price = 1240 };
            */
            /*
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
            */

            AdBuilder ad1, ad2,ad3,ad4;
            AssemblyLine assemblyLine = new AssemblyLine();
            
            ad1 = new AdFactory();
            assemblyLine.Assemble(ad1);
            ad1.AddName("This is the name");
            ad1.AddDescription("this is the description");
            ad1.AddPrice("123");
            ad1.AddRating("3.4");
            ad1.Ad.Show();
            
            ad2 = new AdFactory();
            assemblyLine.Assemble(ad2);
            ad2.AddName("This is the name");
            ad2.AddDescription("this is the description");
            ad2.AddPrice("123");
            ad2.AddRating("3.4");
            ad2.Ad.Show();

            ad3 = new AdFactory();
            assemblyLine.Assemble(ad3);
            ad3.AddName("This is the name");
            ad3.AddDescription("this is the description");
            ad3.AddPrice("123");
            ad3.AddRating("3.4");
            ad3.Ad.Show();
            
            ad4 = new AdFactory();
            assemblyLine.Assemble(ad4);
            ad4.AddName("This is the name");
            ad4.AddDescription("this is the description");
            ad4.AddPrice("123");
            ad4.AddRating("444");
            ad4.Ad.Show();
            
            
            

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
