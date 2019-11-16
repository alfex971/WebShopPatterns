namespace WebShopPatterns.Builder
{
    public class BasicAdBuilder : AdBuilder
    {
        public override void SetName()
        {
            _ad.Name = "";
        }

        public override void SetDescription()
        {
            _ad.Description = "";
        }

        public override void SetPrice()
        {
            _ad.Price = 1;
        }

        public override void SetRating()
        {
            _ad.Rating = 2;
        }
    }
}