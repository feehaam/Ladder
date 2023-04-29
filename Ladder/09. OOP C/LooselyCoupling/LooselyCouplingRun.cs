namespace OOPC
{
    internal class LooselyCouplingRun
    {
        public static void Play()
        {
            Product product;
            product = new TShirt("XL", 300.25);
            product.Print();
            product = new Monitor("24", 24999.90);
            product.Print();
        }
    }
}
