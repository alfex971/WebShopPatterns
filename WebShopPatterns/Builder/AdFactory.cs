namespace WebShopPatterns.Builder
{
    // the director class , where the construction takes place
    public class AdFactory : AdBuilder
    {
        public AdFactory()
        {
            ad = new Ad("New Add");
        }
        
        public override void AddName(string name)
        {
            ad["name"] = name;
        }

        

        public override void AddDescription(string description)
        {
            ad["description"] = description;
        }

        public override void AddPrice(string price)
        {
            ad["price"] = price;
        }

        public override void AddRating(string rating)
        {
            ad["rating"] = rating;
        }
    }
}