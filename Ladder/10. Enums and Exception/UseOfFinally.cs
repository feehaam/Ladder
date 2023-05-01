namespace EnumException
{
    internal class UseOfFinally
    {
        public static void Play()
        {
            int[] ar = { 10, 5, 0, 2, 20, 0 };
            Divides(ar);
        }
        public static void Divides(int[] ar)
        {
            foreach (int n in ar)
            {
                try
                {
                    Console.WriteLine(100 / n);
                }
                catch (DivideByZeroException dbze)
                {
                    Console.WriteLine("Can't devide");
                }
                finally
                {
                    Console.WriteLine("Done for {0}", n);
                }
            }
        }
    }
}
