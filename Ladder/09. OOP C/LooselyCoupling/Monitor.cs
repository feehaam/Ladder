namespace OOPC
{
    internal class Monitor : Product
    {
        private string screenSize;
        public Monitor(string screenSize, double price) : base("Monitor", price)
        {
            this.screenSize = screenSize;
        }

        public override void Print()
        {
            Console.WriteLine(getName() + " | Screen: " + screenSize + "inch | Price: {0}", getPrice());
        }
    }
}
