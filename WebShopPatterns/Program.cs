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

            AdBuilder adBuilder1, adBuilder2, adBuilder3, adBuilder4;
            AssemblyLine assemblyLine = new AssemblyLine();

            adBuilder1 = new AdFactory();
            assemblyLine.Assemble(adBuilder1);
            adBuilder1.AddName("This is the name");
            adBuilder1.AddDescription("this is the description");
            adBuilder1.AddPrice("123");
            adBuilder1.AddRating("3.4");
            adBuilder1.Ad.Show();
            var ad1 = adBuilder1.GetAd();

            adBuilder2 = new AdFactory();
            assemblyLine.Assemble(adBuilder2);
            adBuilder2.AddName("This is the name");
            adBuilder2.AddDescription("this is the description");
            adBuilder2.AddPrice("123");
            adBuilder2.AddRating("3.4");
            adBuilder2.Ad.Show();
            var ad2 = adBuilder2.GetAd();

            adBuilder3 = new AdFactory();
            assemblyLine.Assemble(adBuilder3);
            adBuilder3.AddName("This is the name");
            adBuilder3.AddDescription("this is the description");
            adBuilder3.AddPrice("123");
            adBuilder3.AddRating("3.4");
            adBuilder3.Ad.Show();
            var ad3 = adBuilder3.GetAd();

            adBuilder4 = new AdFactory();
            assemblyLine.Assemble(adBuilder4);
            adBuilder4.AddDescription("this is the description");
            adBuilder4.AddName("This is the name");
            adBuilder4.AddPrice("123");
            adBuilder4.AddRating("444");
            adBuilder4.Ad.Show();
            var ad4 = adBuilder4.GetAd();




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
