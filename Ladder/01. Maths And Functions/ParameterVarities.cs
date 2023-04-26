namespace Maths
{
    internal class ParameterVarities
    {
        public static void Play()
        {
            int a = 100;
            Update(ref a);
            Console.WriteLine("Value of a is "+a);
            Incr(in a);
            string country;
            int population = 100;
            Update(out country, out population);
            Console.WriteLine("Country = {0} and its pupulation = {1}.", country, population);
        }
        // Use of ref keyword
        public static void Update(ref int a)
        {
            a = a + 10;
        }
        // Use of in keyword
        public static void Incr(in int a)
        {
            // Doesn't work because value of a must not be changed from this method
            // a = a + 10; 
            int x = a + 10;
            Console.WriteLine("Incremented value is " + x);
        }
        // Use of out keyword
        public static void Update(out string c, out int p)
        {
            // We must update change the value of c and p,
            // regardless of these variables had values assigned previously or not
            // otherwise the method will result error
            c = "Bangladesh";
            p = 170000000; 
        }
    }
}
