namespace Maths
{
    internal class MathClass
    {
        // Use of some of the built in math methods
        public static void Root(int n)
        {
            Console.WriteLine("Root: "+Math.Sqrt(n));
        }
        public static void Abs(int n)
        {
            Console.WriteLine("Abs: " + Math.Abs(n));
        }
        public static void Floor(double n)
        {
            Console.WriteLine("Floor: " + Math.Floor(n));
        }
        public static void Ceil(double n) {
            Console.WriteLine("Ceiling: " + Math.Ceiling(n));
        }
        public static void Log(int n)
        {
            Console.WriteLine("Log: " + Math.Log(n));
            Console.WriteLine("Log2: " + Math.Log2(n));
        }
    }
}
