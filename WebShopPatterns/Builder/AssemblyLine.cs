namespace WebShopPatterns.Builder
{
    public class AssemblyLine
    {
        public void Assemble(AdBuilder adBuilder)
        {
            adBuilder.AddName("");
            adBuilder.AddDescription("");
            adBuilder.AddPrice("");
            adBuilder.AddRating("");
        }
    }
}