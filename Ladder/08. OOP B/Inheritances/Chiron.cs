namespace OOPB
{
    internal class Chiron : Bugatti
    {
        public Chiron(string name, string description, string brand, double price) : base(name, description, brand, price)
        {
           
        }
        public void AutoDrive()
        {
            // Inheriting from all parents.
            Drive();
            SelfDrive();
        }
    }
}
