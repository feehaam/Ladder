namespace OOPC
{
    internal class TShirt : Product
    {
        private string size;
        public TShirt(string size, double price) : base ("T-Shirt", price)
        {
            this.size = size;
        }

        public override void Print()
        {
            Console.WriteLine(getName()+" | Size: "+size+" | Price: {0}", getPrice());
        }
    }
}
