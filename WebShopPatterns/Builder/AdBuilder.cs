using WebShopPatterns.Composite;

namespace WebShopPatterns.Builder
{
    public abstract class AdBuilder
    {
        /*
        protected readonly Ad _ad = new Ad();
        public abstract void SetName();
        public abstract void SetDescription();
        public abstract void SetPrice();
        public abstract void SetRating();


        public virtual Ad GetAd()
        {
            return _ad;
        }
    */
        protected Ad ad;

        // Gets sandwich instance
        public Ad Ad
        {
            get { return ad; }
        }

        // Abstract build methods
        public abstract void AddName(string name);
        public abstract void AddDescription(string description);
        public abstract void AddPrice(string price);
        public abstract void AddRating(string rating);
        public abstract Ad GetAd();        
    }
    
}
