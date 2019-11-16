namespace WebShopPatterns.Builder
{
    public abstract class AdBuilder
    {
        protected readonly Ad _ad = new Ad();
        public abstract void SetName();
        public abstract void SetDescription();
        public abstract void SetPrice();
        public abstract void SetRating();


        public virtual Ad GetAd()
        {
            return _ad;
        }

    }
}