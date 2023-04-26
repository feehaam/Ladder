namespace Str
{
    internal static class ExtentionMethod
    {
        public static void Play()
        {
            Car car = new Car();
            car.Drive();
            car.Wash();
        }
        static void Wash(this Car car)
        {
            Console.WriteLine("I'm clean!");
        }
    }
    class Car
    {
        public void Drive()
        {
            Console.WriteLine("Driving...");
        }
        public void Wheels()
        {
            Console.WriteLine("I have 4 wheels...");
        }
    }
}
