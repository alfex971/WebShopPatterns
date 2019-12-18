using System;
using System.Collections.Generic;
using System.Text;
using WebShopPatterns.Composite;

namespace WebShopPatterns
{
    public class Ad : IItem
   
    {

        /*
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Rating { get; set; }
        
        
         public decimal GetPrice()
        {
            return Price;
        }
        */
        
        private string _adType;
        private Dictionary<string, string> _ingredients = new Dictionary<string, string>();

        // Constructor
        public Ad(string adType)
        {
            this._adType = adType;
        }

        // Indexer
        public string this[string key]
        {
            get { return _ingredients[key]; }
            set { _ingredients[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Ad: {0}", _adType);
            Console.WriteLine(" Name: {0}", _ingredients["name"]);
            Console.WriteLine(" Description: {0}", _ingredients["description"]);
            Console.WriteLine(" Price: {0}", _ingredients["price"]);
            Console.WriteLine(" Rating: {0}", _ingredients["rating"]);
        }

        public decimal GetPrice()
        {
            throw new NotImplementedException();
        }
    }
    
}
