namespace WebShopPatterns.Builder
{
    // the director class , where the construction takes place
    public class AdFactory
    {
        public Ad Build(AdBuilder builder)
        {
            builder.SetName();
            builder.SetDescription();
            builder.SetPrice();
            builder.SetRating();
            return builder.GetAd();
        }
    }
}