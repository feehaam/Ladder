using System;
namespace OOPB
{
    internal class Bugatti : Car
    {
        public Bugatti(string name, string description, string brand, double price) : base(name, description, brand, price)
        {
           
        }
        public void SelfDrive()
        {
            // Calling inherited method.
            Drive();
        }
    }
}
