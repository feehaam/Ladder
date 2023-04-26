namespace Maths
{
    internal class Calculator
    {
        // Sub, sub, mul and div of numbers
        public static void Sum(int a, int b)
        {
            Console.WriteLine("Sum of {0} and {1} is: {2}.", a, b, (a+b));
        }
        public static void Sub(int a, int b)
        {
            Console.WriteLine(" {0} - {1} is: {2}.", a, b, (a - b));
            Console.WriteLine(" {1} - {0} is: {2}.", a, b, (b - a));
        }
        public static void Mul(int a, int b)
        {
            Console.WriteLine("Multiplication of {0} and {1} is: {2}.", a, b, (a * b));
        }
        public static void Div(int a, int b)
        {
            Console.WriteLine(" {0}/{1} is: {2}.", a, b, (a/b));
            Console.WriteLine(" {1}/{0} is: {2}.", a, b, (b/a));
        }
    }
}
