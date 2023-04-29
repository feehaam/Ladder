namespace OOPC
{
    internal abstract class Product
    {
        private string _name;
        private double _price;
        public abstract void Print();
        public string getName() { return _name; }
        public double getPrice() { return _price;}
        public Product(string name, double price)
        {
            _name = name;
            _price = price;
        }
    }
}
